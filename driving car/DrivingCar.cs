using System.Diagnostics;
using System.Numerics;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

/**
 Info:
> .Left => posisi sumbu X object 
> .Top => posisi sumbu Y object
    > Cek di properties > location
> timer, timer start = game jalan, timer stop = game berhenti

 */

namespace driving_car
{
    public partial class DrivingCar : Form
    {
        //global variables
        int level = 1;
        int carSpeed = 5;           //speed mobil player
        int roadSpeed = 5;          //speed jalanan
        int trafficSpeed = 5;       //speed kendaraan
        int Score = 0;
        int finish = 1000;
        bool carLeft;               //true = belok kiri
        bool carRight;              //true = belok kanan
        //bool carUp;                 //true = keatas
        //bool carDown;               //true = kebawah
        bool GameStarted = false;   //true = game dimulai
        bool GamePaused = false;    //true = game dipause
        bool GameOver = false;
        Random rnd = new Random();
        Menu menu = new Menu();
        Level lvl = new Level();

        public DrivingCar()
        {
            InitializeComponent();
            Reset();
            //random_map();
        }

        private void random_map()
        {
            int map = rnd.Next(1, 3);
            switch (map)
            {
                case 1:
                    road1.Image = Properties.Resources.road1;
                    road2.Image = Properties.Resources.road1;
                    break;
                case 2:
                    road1.Image = Properties.Resources.road2;
                    road2.Image = Properties.Resources.road2;
                    break;
                case 3:
                    road1.Image = Properties.Resources.road3;
                    road2.Image = Properties.Resources.road3;
                    break;
                default:
                    break;
            }
        }

        //reset game
        private void Reset()
        {
            explosion.Visible = false; // hide the explosion image
            trafficSpeed = Level.trafficSpeed; // set the traffic back to default
            roadSpeed = Level.roadSpeed; // set the road speed back to default
            level = Level.level;
            carSpeed = Level.carSpeed;
            panelGame.Focus();
            menu.SelectCar(Menu.num_car, Player);
            lbllevel.Text = level.ToString();
            Score = 0; // reset score to 0
            Player.Left = 224; // reset player left
            Player.Top = 562; // reset player top
            carLeft = false; // reset the moving left to false
            carRight = false; // reset the moving right to false
            //carUp = false; // reset the moving up to false
            //carDown = false; // reset the moving down to false
            // pindah posisi AI ke luar screen
            AI1.Left = 66;
            AI1.Top = -120;
            AI2.Left = 294;
            AI2.Top = -185;
            //reset the road to their default position
            road1.Left = -2;
            road1.Top = 0;
            road2.Left = -2;
            road2.Top = -750;
            //Stop the game
            GameStarted = false;
            GamePaused = false;
            GameOver = false;
            panelPause.Visible = false;
            lblStart.Visible = true;
            timer1.Stop();

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            pause();
        }

        private void btnrestart_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnmenu_Click(object sender, EventArgs e)
        {
            menu.Show();
            this.Close();
        }

        private void pause()
        {
            //work only if game is started
            if (!GameOver)
            {
                if (!GamePaused)    //pause game
                {
                    panelPause.Visible = true;   //show label pause
                    lblgameover.Visible = false;
                    lblpaused.Visible = true;
                    lblfinish.Visible = false;
                    btnResume.Visible = true;
                    btnnext.Visible = false;
                    GamePaused = true;
                    timer1.Stop();              //stop game
                }
                else
                {               //resume game
                    panelPause.Visible = false;
                    GamePaused = false;
                    timer1.Start();         //start game
                }
            }
        }

        //fungsi utama/inti
        private void timer1_Tick(object sender, EventArgs e)
        {
            //fungsi ini jalan pas timer start/game start
            Score++;
            panelGame.Focus();
            lblscore.Text = "" + Score;
            progressBar.Maximum = finish;
            progressBar.Value = Score;
            if (finish == Score)
            {
                finished();
            }
            road1.Top += roadSpeed; // move the track 1 down with the += 
            road2.Top += roadSpeed; // move the track 2 down with the += 
            // if the track has gone past -580 then we set it back to default
            if (road1.Top > 750)
            {
                road1.Top = -750;
            }
            if (road2.Top > 750)
            {
                road2.Top = -750;
            }

            if (carLeft) { Player.Left -= carSpeed; } // move the car left if the car left is true
            if (carRight) { Player.Left += carSpeed; } // move the car right if the car right is true
            //if (carUp) { Player.Top -= carSpeed; } // move the car up if the car right is true
            //if (carDown) { Player.Top += carSpeed; } // move the car down if the car right is true

            //mencegah player bergerak keluar panel game
            if (Player.Left < 1)
            {
                carLeft = false;
            }
            else if (Player.Left + Player.Width > 441)
            {
                carRight = false;
            }
            //else if (Player.Top < 19)
            //{
            //    carUp = false;
            //}
            //else if (Player.Top + Player.Height > 589)
            //{
            //    carDown = false;
            //}

            //move the AI cars down
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;
            //respawn the AIs and change the their images
            if (AI1.Top > panelGame.Height)
            {
                menu.SelectCar(rnd.Next(1, 10), AI1); // change the AI car images once they left the scene
                AI1.Left = rnd.Next(2, 180); // random posisi left
                AI1.Top = rnd.Next(100, 200) * -1; // random posisi top
            }
            if (AI2.Top > panelGame.Height)
            {
                menu.SelectCar(rnd.Next(1, 10), AI2); // change the AI car images once they left the scene
                AI2.Left = rnd.Next(240, 440); // random numbers where they appear on the left
                AI2.Top = rnd.Next(100, 200) * -1; // random numbers where they appear on top
            }

            // if player hits AI1 OR player hits AI2
            if (Player.Bounds.IntersectsWith(AI1.Bounds) || Player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver(); // this will run when the player hits an AI object
            }
        }

        private void moveCar(object sender, KeyEventArgs e)
        {
            if (!GameStarted && !GameOver && (e.KeyCode == Keys.Left || e.KeyCode == Keys.Right))
            {
                GameStarted = true;
                lblStart.Visible = false;
                timer1.Start();
            }
            if (e.KeyCode == Keys.Left && Player.Left > 0)
            {
                carLeft = true;
            }
            if (e.KeyCode == Keys.Right && Player.Left + Player.Width < panelGame.Width)
            {
                carRight = true;
            }
            //if (e.KeyCode == Keys.Up && Player.Top > panelGame.Height)
            //{
            //    carUp = true;
            //}
            //if (e.KeyCode == Keys.Down && Player.Top + Player.Height < panelGame.Height)
            //{
            //    carDown = true;
            //}
        }

        private void stopCar(object sender, KeyEventArgs e)
        {
            // if the LEFT key is up we set the car left to false
            if (e.KeyCode == Keys.Left)
            {
                carLeft = false;
            }
            // if the RIGHT key is up we set the car right to false
            if (e.KeyCode == Keys.Right)
            {
                carRight = false;
            }
            // if the UP key is up we set the car right to false
            //if (e.KeyCode == Keys.Up)
            //{
            //    carUp = false;
            //}
            //// if the DOWN key is up we set the car right to false
            //if (e.KeyCode == Keys.Down)
            //{
            //    carDown = false;
            //}

            //space for pause the game
            if (e.KeyCode == Keys.Space)
            {
                pause();
            }
        }

        private void gameOver()
        {
            GameStarted = false;
            timer1.Stop(); // stop the timer
            panelPause.Visible = true;
            btnResume.Visible = false;
            btnnext.Visible = false;
            lblfinish.Visible = false;
            lblpaused.Visible = false;
            lblgameover.Visible = true;
            GameOver = true;
            //show gambar ledakan ke atas gambar mobil player
            explosion.Visible = true; // make the image visible
            Player.Controls.Add(explosion); // add the explosion image on top of the player image
            explosion.Location = new Point(-8, 5); // we are moving the image so its suitably positioned
            explosion.BackColor = Color.Transparent; // change the background to transparent
            explosion.BringToFront();// bring to front of the player image

        }

        private void unlockLevel()
        {
            if (level == 1)
            {
                Level.lvel2 = true;
            }
            else if (level == 2)
            {
                Level.lvel3 = true;
            }
            else if (level == 3)
            {
                Level.lvel4 = true;
            }
            else if (level == 4)
            {
                Level.lvel5 = true;
            }
            else if (level == 5)
            {
                Level.lvel6 = true;
            }
        }

        private void finished()
        {
            timer1.Stop();
            panelPause.Visible = true;
            btnResume.Visible = false;
            lblpaused.Visible = false;
            lblgameover.Visible = false;
            lblfinish.Visible = true;
            unlockLevel();

            if (level == 6)
            {
                btnnext.Visible = false;
            }
            else
            {

                btnnext.Visible = true;
            }
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            switch (level)
            {
                case 1:
                    {
                        lvl.level2();
                        Reset();
                        random_map();
                        break;
                    }
                case 2:
                    {
                        lvl.level3();
                        Reset();
                        random_map();
                        break;
                    }
                case 3:
                    {
                        lvl.level4();
                        Reset();
                        random_map();
                        break;
                    }
                case 4:
                    {
                        lvl.level5();
                        Reset();
                        random_map();
                        break;
                    }
                case 5:
                    {
                        lvl.level6();
                        Reset();
                        random_map();
                        break;
                    }
                default:
                    break;
            }
        }

        private void DrivingCar_Load(object sender, EventArgs e)
        {

        }
    }
}
