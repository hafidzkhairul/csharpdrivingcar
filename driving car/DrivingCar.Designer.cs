namespace driving_car
{
    partial class DrivingCar
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblscore = new Label();
            label1 = new Label();
            lblStart = new Label();
            panelGame = new Panel();
            panelPause = new Panel();
            btnnext = new Button();
            lblfinish = new Label();
            lblgameover = new Label();
            btnrestart = new Button();
            btnmenu = new Button();
            btnResume = new Button();
            lblpaused = new Label();
            progressBar = new ProgressBar();
            btnpause = new PictureBox();
            lbllevel = new Label();
            label2 = new Label();
            explosion = new PictureBox();
            Player = new PictureBox();
            AI2 = new PictureBox();
            AI1 = new PictureBox();
            road1 = new PictureBox();
            road2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panelGame.SuspendLayout();
            panelPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnpause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road2).BeginInit();
            SuspendLayout();
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.BackColor = Color.Transparent;
            lblscore.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblscore.ForeColor = Color.White;
            lblscore.Location = new Point(3, 88);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(30, 32);
            lblscore.TabIndex = 6;
            lblscore.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 65);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 5;
            label1.Text = "Score : ";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.BackColor = Color.Transparent;
            lblStart.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStart.ForeColor = Color.White;
            lblStart.Location = new Point(134, 696);
            lblStart.Name = "lblStart";
            lblStart.RightToLeft = RightToLeft.No;
            lblStart.Size = new Size(227, 24);
            lblStart.TabIndex = 0;
            lblStart.Text = "Press any key to Start";
            // 
            // panelGame
            // 
            panelGame.BackColor = Color.Black;
            panelGame.BorderStyle = BorderStyle.Fixed3D;
            panelGame.Controls.Add(panelPause);
            panelGame.Controls.Add(progressBar);
            panelGame.Controls.Add(btnpause);
            panelGame.Controls.Add(lbllevel);
            panelGame.Controls.Add(label2);
            panelGame.Controls.Add(lblscore);
            panelGame.Controls.Add(label1);
            panelGame.Controls.Add(lblStart);
            panelGame.Controls.Add(explosion);
            panelGame.Controls.Add(Player);
            panelGame.Controls.Add(AI2);
            panelGame.Controls.Add(AI1);
            panelGame.Controls.Add(road1);
            panelGame.Controls.Add(road2);
            panelGame.Location = new Point(12, 12);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(525, 751);
            panelGame.TabIndex = 2;
            // 
            // panelPause
            // 
            panelPause.BackColor = Color.FromArgb(64, 64, 64);
            panelPause.Controls.Add(btnnext);
            panelPause.Controls.Add(lblfinish);
            panelPause.Controls.Add(lblgameover);
            panelPause.Controls.Add(btnrestart);
            panelPause.Controls.Add(btnmenu);
            panelPause.Controls.Add(btnResume);
            panelPause.Controls.Add(lblpaused);
            panelPause.Location = new Point(67, 88);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(389, 505);
            panelPause.TabIndex = 3;
            panelPause.Visible = false;
            // 
            // btnnext
            // 
            btnnext.Location = new Point(160, 226);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(75, 23);
            btnnext.TabIndex = 6;
            btnnext.Text = "Next";
            btnnext.UseVisualStyleBackColor = true;
            btnnext.Click += btnnext_Click;
            // 
            // lblfinish
            // 
            lblfinish.AutoSize = true;
            lblfinish.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblfinish.ForeColor = SystemColors.Control;
            lblfinish.Location = new Point(151, 128);
            lblfinish.Name = "lblfinish";
            lblfinish.Size = new Size(98, 32);
            lblfinish.TabIndex = 5;
            lblfinish.Text = "you win";
            // 
            // lblgameover
            // 
            lblgameover.AutoSize = true;
            lblgameover.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblgameover.ForeColor = SystemColors.Control;
            lblgameover.Location = new Point(143, 85);
            lblgameover.Name = "lblgameover";
            lblgameover.Size = new Size(128, 32);
            lblgameover.TabIndex = 4;
            lblgameover.Text = "game over";
            // 
            // btnrestart
            // 
            btnrestart.Location = new Point(160, 311);
            btnrestart.Name = "btnrestart";
            btnrestart.Size = new Size(75, 23);
            btnrestart.TabIndex = 3;
            btnrestart.Text = "Restart";
            btnrestart.UseVisualStyleBackColor = true;
            btnrestart.Click += btnrestart_Click;
            // 
            // btnmenu
            // 
            btnmenu.Location = new Point(160, 356);
            btnmenu.Name = "btnmenu";
            btnmenu.Size = new Size(75, 23);
            btnmenu.TabIndex = 2;
            btnmenu.Text = "Menu";
            btnmenu.UseVisualStyleBackColor = true;
            btnmenu.Click += btnmenu_Click;
            // 
            // btnResume
            // 
            btnResume.Location = new Point(160, 269);
            btnResume.Name = "btnResume";
            btnResume.Size = new Size(75, 23);
            btnResume.TabIndex = 1;
            btnResume.Text = "Resume";
            btnResume.UseVisualStyleBackColor = true;
            btnResume.Click += btnResume_Click;
            // 
            // lblpaused
            // 
            lblpaused.AutoSize = true;
            lblpaused.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpaused.ForeColor = SystemColors.Control;
            lblpaused.Location = new Point(160, 30);
            lblpaused.Name = "lblpaused";
            lblpaused.Size = new Size(89, 32);
            lblpaused.TabIndex = 0;
            lblpaused.Text = "Paused";
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.ControlLight;
            progressBar.ForeColor = Color.GreenYellow;
            progressBar.Location = new Point(119, 11);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(276, 10);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 12;
            // 
            // btnpause
            // 
            btnpause.BackColor = Color.LightGray;
            btnpause.ErrorImage = null;
            btnpause.Location = new Point(429, 3);
            btnpause.Name = "btnpause";
            btnpause.Size = new Size(89, 50);
            btnpause.TabIndex = 11;
            btnpause.TabStop = false;
            btnpause.Click += btnPause_Click;
            // 
            // lbllevel
            // 
            lbllevel.AutoSize = true;
            lbllevel.BackColor = Color.Transparent;
            lbllevel.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllevel.ForeColor = Color.White;
            lbllevel.Location = new Point(3, 33);
            lbllevel.Name = "lbllevel";
            lbllevel.Size = new Size(30, 32);
            lbllevel.TabIndex = 8;
            lbllevel.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 11);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 7;
            label2.Text = "Level : ";
            // 
            // explosion
            // 
            explosion.BackColor = Color.Transparent;
            explosion.Image = Properties.Resources.explosion;
            explosion.Location = new Point(290, 357);
            explosion.Name = "explosion";
            explosion.Size = new Size(80, 87);
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            explosion.TabIndex = 4;
            explosion.TabStop = false;
            explosion.Visible = false;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.Resources.CarRed;
            Player.Location = new Point(224, 562);
            Player.Name = "Player";
            Player.Size = new Size(79, 131);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 3;
            Player.TabStop = false;
            // 
            // AI2
            // 
            AI2.BackColor = Color.Transparent;
            AI2.Image = Properties.Resources.carPink;
            AI2.Location = new Point(441, 278);
            AI2.Name = "AI2";
            AI2.Size = new Size(77, 131);
            AI2.SizeMode = PictureBoxSizeMode.StretchImage;
            AI2.TabIndex = 2;
            AI2.TabStop = false;
            // 
            // AI1
            // 
            AI1.BackColor = Color.Transparent;
            AI1.Image = Properties.Resources.carGrey;
            AI1.Location = new Point(6, 163);
            AI1.Name = "AI1";
            AI1.Size = new Size(77, 131);
            AI1.SizeMode = PictureBoxSizeMode.StretchImage;
            AI1.TabIndex = 0;
            AI1.TabStop = false;
            // 
            // road1
            // 
            road1.Image = Properties.Resources.roadTrack;
            road1.Location = new Point(83, -7);
            road1.Name = "road1";
            road1.Size = new Size(345, 751);
            road1.SizeMode = PictureBoxSizeMode.StretchImage;
            road1.TabIndex = 0;
            road1.TabStop = false;
            // 
            // road2
            // 
            road2.Image = Properties.Resources.roadTrack;
            road2.Location = new Point(83, -770);
            road2.Name = "road2";
            road2.Size = new Size(345, 751);
            road2.SizeMode = PictureBoxSizeMode.StretchImage;
            road2.TabIndex = 10;
            road2.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // DrivingCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(544, 841);
            Controls.Add(panelGame);
            KeyPreview = true;
            Name = "DrivingCar";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Driving car";
            KeyDown += moveCar;
            KeyUp += stopCar;
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelPause.ResumeLayout(false);
            panelPause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnpause).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)road1).EndInit();
            ((System.ComponentModel.ISupportInitialize)road2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelGame;
        private Label lblStart;
        private PictureBox road1;
        private PictureBox AI2;
        private PictureBox AI1;
        private PictureBox explosion;
        private System.Windows.Forms.Timer timer1;
        private Label lblscore;
        private Label label1;
        private Label lbllevel;
        private Label label2;
        private PictureBox road2;
        private PictureBox btnpause;
        private Panel panelPause;
        private Button btnResume;
        private Label lblpaused;
        private Button btnmenu;
        public PictureBox Player;
        private Button btnrestart;
        private Label lblgameover;
        private ProgressBar progressBar;
        private Button btnnext;
        private Label lblfinish;
    }
}
