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
            victory = new PictureBox();
            overgame = new PictureBox();
            buttonmenu = new PictureBox();
            buttonresume = new PictureBox();
            btnnext = new PictureBox();
            lblpaused = new Label();
            lbllevel = new Label();
            label2 = new Label();
            progressBar = new ProgressBar();
            btnpause = new PictureBox();
            Player = new PictureBox();
            explosion = new PictureBox();
            AI2 = new PictureBox();
            AI1 = new PictureBox();
            road2 = new PictureBox();
            road1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            btnrestart = new PictureBox();
            panelGame.SuspendLayout();
            panelPause.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)victory).BeginInit();
            ((System.ComponentModel.ISupportInitialize)overgame).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonmenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonresume).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnnext).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnpause).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnrestart).BeginInit();
            SuspendLayout();
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.BackColor = Color.Transparent;
            lblscore.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblscore.ForeColor = Color.White;
            lblscore.Location = new Point(3, 117);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(37, 39);
            lblscore.TabIndex = 6;
            lblscore.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 87);
            label1.Name = "label1";
            label1.Size = new Size(101, 28);
            label1.TabIndex = 5;
            label1.Text = "Score : ";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.BackColor = Color.Transparent;
            lblStart.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblStart.ForeColor = Color.White;
            lblStart.Location = new Point(153, 928);
            lblStart.Name = "lblStart";
            lblStart.RightToLeft = RightToLeft.No;
            lblStart.Size = new Size(342, 32);
            lblStart.TabIndex = 0;
            lblStart.Text = "Press Arrow Key to Start";
            // 
            // panelGame
            // 
            panelGame.BackColor = SystemColors.ActiveCaptionText;
            panelGame.BackgroundImageLayout = ImageLayout.Stretch;
            panelGame.BorderStyle = BorderStyle.Fixed3D;
            panelGame.Controls.Add(panelPause);
            panelGame.Controls.Add(lblStart);
            panelGame.Controls.Add(lblscore);
            panelGame.Controls.Add(label1);
            panelGame.Controls.Add(lbllevel);
            panelGame.Controls.Add(label2);
            panelGame.Controls.Add(progressBar);
            panelGame.Controls.Add(btnpause);
            panelGame.Controls.Add(Player);
            panelGame.Controls.Add(explosion);
            panelGame.Controls.Add(AI2);
            panelGame.Controls.Add(AI1);
            panelGame.Controls.Add(road2);
            panelGame.Controls.Add(road1);
            panelGame.Location = new Point(14, 16);
            panelGame.Margin = new Padding(3, 4, 3, 4);
            panelGame.Name = "panelGame";
            panelGame.Size = new Size(599, 1000);
            panelGame.TabIndex = 2;
            // 
            // panelPause
            // 
            panelPause.BackColor = Color.FromArgb(64, 64, 64);
            panelPause.Controls.Add(btnrestart);
            panelPause.Controls.Add(victory);
            panelPause.Controls.Add(overgame);
            panelPause.Controls.Add(buttonmenu);
            panelPause.Controls.Add(buttonresume);
            panelPause.Controls.Add(btnnext);
            panelPause.Controls.Add(lblpaused);
            panelPause.Location = new Point(71, 119);
            panelPause.Margin = new Padding(3, 4, 3, 4);
            panelPause.Name = "panelPause";
            panelPause.Size = new Size(445, 673);
            panelPause.TabIndex = 3;
            panelPause.Visible = false;
            // 
            // victory
            // 
            victory.Image = Properties.Resources.victory_Photoroom;
            victory.Location = new Point(117, 29);
            victory.Name = "victory";
            victory.Size = new Size(220, 198);
            victory.SizeMode = PictureBoxSizeMode.StretchImage;
            victory.TabIndex = 20;
            victory.TabStop = false;
            // 
            // overgame
            // 
            overgame.Image = Properties.Resources.game_over;
            overgame.Location = new Point(117, 61);
            overgame.Name = "overgame";
            overgame.Size = new Size(238, 129);
            overgame.SizeMode = PictureBoxSizeMode.StretchImage;
            overgame.TabIndex = 19;
            overgame.TabStop = false;
            // 
            // buttonmenu
            // 
            buttonmenu.Image = Properties.Resources.btn_exit1;
            buttonmenu.Location = new Point(137, 458);
            buttonmenu.Margin = new Padding(3, 4, 3, 4);
            buttonmenu.Name = "buttonmenu";
            buttonmenu.Size = new Size(171, 68);
            buttonmenu.SizeMode = PictureBoxSizeMode.Zoom;
            buttonmenu.TabIndex = 18;
            buttonmenu.TabStop = false;
            buttonmenu.Click += btnmenu_Click;
            // 
            // buttonresume
            // 
            buttonresume.Image = Properties.Resources.btn_resume1;
            buttonresume.Location = new Point(137, 232);
            buttonresume.Margin = new Padding(3, 4, 3, 4);
            buttonresume.Name = "buttonresume";
            buttonresume.Size = new Size(171, 68);
            buttonresume.SizeMode = PictureBoxSizeMode.Zoom;
            buttonresume.TabIndex = 17;
            buttonresume.TabStop = false;
            buttonresume.Click += btnResume_Click;
            // 
            // btnnext
            // 
            btnnext.Image = Properties.Resources.btn_next;
            btnnext.Location = new Point(137, 234);
            btnnext.Margin = new Padding(3, 4, 3, 4);
            btnnext.Name = "btnnext";
            btnnext.Size = new Size(171, 68);
            btnnext.SizeMode = PictureBoxSizeMode.Zoom;
            btnnext.TabIndex = 13;
            btnnext.TabStop = false;
            btnnext.Click += btnnext_Click;
            // 
            // lblpaused
            // 
            lblpaused.AutoSize = true;
            lblpaused.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblpaused.ForeColor = SystemColors.Control;
            lblpaused.Location = new Point(182, 17);
            lblpaused.Name = "lblpaused";
            lblpaused.Size = new Size(113, 41);
            lblpaused.TabIndex = 0;
            lblpaused.Text = "Paused";
            // 
            // lbllevel
            // 
            lbllevel.AutoSize = true;
            lbllevel.BackColor = Color.Transparent;
            lbllevel.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbllevel.ForeColor = Color.White;
            lbllevel.Location = new Point(3, 44);
            lbllevel.Name = "lbllevel";
            lbllevel.Size = new Size(37, 39);
            lbllevel.TabIndex = 8;
            lbllevel.Text = "1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 15);
            label2.Name = "label2";
            label2.Size = new Size(94, 28);
            label2.TabIndex = 7;
            label2.Text = "Level : ";
            // 
            // progressBar
            // 
            progressBar.BackColor = SystemColors.ControlLight;
            progressBar.ForeColor = Color.GreenYellow;
            progressBar.Location = new Point(136, 15);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(315, 13);
            progressBar.Style = ProgressBarStyle.Continuous;
            progressBar.TabIndex = 12;
            // 
            // btnpause
            // 
            btnpause.BackColor = Color.Transparent;
            btnpause.ErrorImage = null;
            btnpause.Image = Properties.Resources.btn_pause1;
            btnpause.Location = new Point(517, 4);
            btnpause.Margin = new Padding(3, 4, 3, 4);
            btnpause.Name = "btnpause";
            btnpause.Size = new Size(75, 83);
            btnpause.SizeMode = PictureBoxSizeMode.Zoom;
            btnpause.TabIndex = 11;
            btnpause.TabStop = false;
            btnpause.Click += btnPause_Click;
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.Resources.car41;
            Player.Location = new Point(265, 728);
            Player.Margin = new Padding(3, 4, 3, 4);
            Player.Name = "Player";
            Player.Size = new Size(79, 175);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 3;
            Player.TabStop = false;
            // 
            // explosion
            // 
            explosion.BackColor = Color.Transparent;
            explosion.BackgroundImageLayout = ImageLayout.None;
            explosion.Image = Properties.Resources.explosion;
            explosion.Location = new Point(253, 303);
            explosion.Margin = new Padding(3, 4, 3, 4);
            explosion.Name = "explosion";
            explosion.Size = new Size(91, 116);
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            explosion.TabIndex = 4;
            explosion.TabStop = false;
            explosion.Visible = false;
            // 
            // AI2
            // 
            AI2.BackColor = Color.Transparent;
            AI2.Image = Properties.Resources.car101;
            AI2.Location = new Point(392, 372);
            AI2.Margin = new Padding(3, 4, 3, 4);
            AI2.Name = "AI2";
            AI2.Size = new Size(75, 175);
            AI2.SizeMode = PictureBoxSizeMode.Zoom;
            AI2.TabIndex = 2;
            AI2.TabStop = false;
            // 
            // AI1
            // 
            AI1.BackColor = Color.Transparent;
            AI1.Image = Properties.Resources.car81;
            AI1.Location = new Point(107, 395);
            AI1.Margin = new Padding(3, 4, 3, 4);
            AI1.Name = "AI1";
            AI1.Size = new Size(72, 168);
            AI1.SizeMode = PictureBoxSizeMode.Zoom;
            AI1.TabIndex = 0;
            AI1.TabStop = false;
            // 
            // road2
            // 
            road2.BackColor = Color.Transparent;
            road2.Image = Properties.Resources.roadTrack;
            road2.Location = new Point(-2, -1000);
            road2.Margin = new Padding(3, 4, 3, 4);
            road2.Name = "road2";
            road2.Size = new Size(600, 1044);
            road2.SizeMode = PictureBoxSizeMode.StretchImage;
            road2.TabIndex = 13;
            road2.TabStop = false;
            // 
            // road1
            // 
            road1.BackColor = Color.Transparent;
            road1.Image = Properties.Resources.roadTrack;
            road1.Location = new Point(-2, -3);
            road1.Margin = new Padding(3, 4, 3, 4);
            road1.Name = "road1";
            road1.Size = new Size(600, 1044);
            road1.SizeMode = PictureBoxSizeMode.StretchImage;
            road1.TabIndex = 0;
            road1.TabStop = false;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 10;
            timer1.Tick += timer1_Tick;
            // 
            // btnrestart
            // 
            btnrestart.Image = Properties.Resources.btn_resume1;
            btnrestart.Location = new Point(137, 337);
            btnrestart.Margin = new Padding(3, 4, 3, 4);
            btnrestart.Name = "btnrestart";
            btnrestart.Size = new Size(171, 68);
            btnrestart.SizeMode = PictureBoxSizeMode.Zoom;
            btnrestart.TabIndex = 21;
            btnrestart.TabStop = false;
            btnrestart.Click += btnrestart_Click;
            // 
            // DrivingCar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(630, 1055);
            Controls.Add(panelGame);
            KeyPreview = true;
            Margin = new Padding(3, 4, 3, 4);
            Name = "DrivingCar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Driving car";
            KeyDown += moveCar;
            KeyUp += stopCar;
            panelGame.ResumeLayout(false);
            panelGame.PerformLayout();
            panelPause.ResumeLayout(false);
            panelPause.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)victory).EndInit();
            ((System.ComponentModel.ISupportInitialize)overgame).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonmenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonresume).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnnext).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnpause).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)road2).EndInit();
            ((System.ComponentModel.ISupportInitialize)road1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnrestart).EndInit();
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
        private PictureBox btnpause;
        private Panel panelPause;
        private Label lblpaused;
        public PictureBox Player;
        private ProgressBar progressBar;
        private PictureBox road2;
        private PictureBox btnnext;
        private PictureBox buttonresume;
        private PictureBox buttonmenu;
        private PictureBox overgame;
        private PictureBox victory;
        private PictureBox btnrestart;
    }
}
