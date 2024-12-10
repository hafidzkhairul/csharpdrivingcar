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
            panel1 = new Panel();
            lblhighscore = new Label();
            label2 = new Label();
            lblscore = new Label();
            label1 = new Label();
            panel2 = new Panel();
            btnreset = new Button();
            lblLetsStart = new Label();
            lblPaused = new Label();
            btnPause = new Button();
            btnStart = new Button();
            inputName = new TextBox();
            labelyourname = new Label();
            panel3 = new Panel();
            trophy = new PictureBox();
            explosion = new PictureBox();
            Player = new PictureBox();
            AI2 = new PictureBox();
            AI1 = new PictureBox();
            road2 = new PictureBox();
            road1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trophy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)explosion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AI1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)road1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblhighscore);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lblscore);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(244, 553);
            panel1.TabIndex = 0;
            // 
            // lblhighscore
            // 
            lblhighscore.AutoSize = true;
            lblhighscore.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblhighscore.Location = new Point(19, 133);
            lblhighscore.Name = "lblhighscore";
            lblhighscore.Size = new Size(30, 32);
            lblhighscore.TabIndex = 8;
            lblhighscore.Text = "0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 94);
            label2.Name = "label2";
            label2.Size = new Size(155, 22);
            label2.TabIndex = 7;
            label2.Text = "Highest Score : ";
            // 
            // lblscore
            // 
            lblscore.AutoSize = true;
            lblscore.Font = new Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblscore.Location = new Point(19, 51);
            lblscore.Name = "lblscore";
            lblscore.Size = new Size(30, 32);
            lblscore.TabIndex = 6;
            lblscore.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(19, 13);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 5;
            label1.Text = "Score : ";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnreset);
            panel2.Controls.Add(btnPause);
            panel2.Controls.Add(btnStart);
            panel2.Controls.Add(inputName);
            panel2.Controls.Add(labelyourname);
            panel2.Location = new Point(751, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 553);
            panel2.TabIndex = 1;
            // 
            // btnreset
            // 
            btnreset.Location = new Point(99, 240);
            btnreset.Name = "btnreset";
            btnreset.Size = new Size(75, 23);
            btnreset.TabIndex = 4;
            btnreset.Text = "Reset";
            btnreset.UseVisualStyleBackColor = true;
            btnreset.Click += btnreset_Click;
            // 
            // lblLetsStart
            // 
            lblLetsStart.AutoSize = true;
            lblLetsStart.BackColor = Color.Transparent;
            lblLetsStart.Font = new Font("Arial Rounded MT Bold", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLetsStart.ForeColor = Color.White;
            lblLetsStart.Location = new Point(81, 209);
            lblLetsStart.Name = "lblLetsStart";
            lblLetsStart.RightToLeft = RightToLeft.No;
            lblLetsStart.Size = new Size(313, 55);
            lblLetsStart.TabIndex = 0;
            lblLetsStart.Text = "Lets Start !!!";
            // 
            // lblPaused
            // 
            lblPaused.AutoSize = true;
            lblPaused.BackColor = Color.Transparent;
            lblPaused.Font = new Font("Arial Rounded MT Bold", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPaused.ForeColor = Color.White;
            lblPaused.Location = new Point(93, 264);
            lblPaused.Name = "lblPaused";
            lblPaused.Size = new Size(268, 43);
            lblPaused.TabIndex = 3;
            lblPaused.Text = "Game Paused";
            lblPaused.Visible = false;
            // 
            // btnPause
            // 
            btnPause.Location = new Point(99, 184);
            btnPause.Name = "btnPause";
            btnPause.Size = new Size(75, 23);
            btnPause.TabIndex = 3;
            btnPause.Text = "Pause";
            btnPause.UseVisualStyleBackColor = true;
            btnPause.Click += btnPause_Click;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(99, 132);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 2;
            btnStart.Text = "New Game";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // inputName
            // 
            inputName.Font = new Font("Arial Rounded MT Bold", 14F);
            inputName.Location = new Point(51, 67);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Your Name";
            inputName.Size = new Size(165, 29);
            inputName.TabIndex = 1;
            // 
            // labelyourname
            // 
            labelyourname.AutoSize = true;
            labelyourname.Font = new Font("Arial Rounded MT Bold", 15F);
            labelyourname.Location = new Point(65, 30);
            labelyourname.Name = "labelyourname";
            labelyourname.Size = new Size(134, 23);
            labelyourname.TabIndex = 0;
            labelyourname.Text = "Your Name : ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.BorderStyle = BorderStyle.Fixed3D;
            panel3.Controls.Add(lblPaused);
            panel3.Controls.Add(lblLetsStart);
            panel3.Controls.Add(trophy);
            panel3.Controls.Add(explosion);
            panel3.Controls.Add(Player);
            panel3.Controls.Add(AI2);
            panel3.Controls.Add(AI1);
            panel3.Controls.Add(road2);
            panel3.Controls.Add(road1);
            panel3.Location = new Point(262, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(483, 555);
            panel3.TabIndex = 2;
            // 
            // trophy
            // 
            trophy.BackColor = Color.Transparent;
            trophy.Image = Properties.Resources.gold;
            trophy.Location = new Point(168, 264);
            trophy.Name = "trophy";
            trophy.Size = new Size(163, 87);
            trophy.SizeMode = PictureBoxSizeMode.StretchImage;
            trophy.TabIndex = 5;
            trophy.TabStop = false;
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
            // 
            // Player
            // 
            Player.BackColor = Color.Transparent;
            Player.Image = Properties.Resources.CarRed;
            Player.Location = new Point(211, 430);
            Player.Name = "Player";
            Player.Size = new Size(58, 98);
            Player.SizeMode = PictureBoxSizeMode.StretchImage;
            Player.TabIndex = 3;
            Player.TabStop = false;
            // 
            // AI2
            // 
            AI2.BackColor = Color.Transparent;
            AI2.Image = Properties.Resources.carPink;
            AI2.Location = new Point(290, 65);
            AI2.Name = "AI2";
            AI2.Size = new Size(58, 98);
            AI2.SizeMode = PictureBoxSizeMode.StretchImage;
            AI2.TabIndex = 2;
            AI2.TabStop = false;
            // 
            // AI1
            // 
            AI1.BackColor = Color.Transparent;
            AI1.Image = Properties.Resources.carGrey;
            AI1.Location = new Point(149, 65);
            AI1.Name = "AI1";
            AI1.Size = new Size(58, 98);
            AI1.SizeMode = PictureBoxSizeMode.StretchImage;
            AI1.TabIndex = 0;
            AI1.TabStop = false;
            // 
            // road2
            // 
            road2.Image = Properties.Resources.roadTrack;
            road2.Location = new Point(81, -580);
            road2.Name = "road2";
            road2.Size = new Size(311, 550);
            road2.SizeMode = PictureBoxSizeMode.StretchImage;
            road2.TabIndex = 1;
            road2.TabStop = false;
            // 
            // road1
            // 
            road1.Image = Properties.Resources.roadTrack;
            road1.Location = new Point(81, -2);
            road1.Name = "road1";
            road1.Size = new Size(311, 550);
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
            // DrivingCar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(1047, 579);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "DrivingCar";
            Text = "Driving car";
            KeyDown += moveCar;
            KeyUp += stopCar;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trophy).EndInit();
            ((System.ComponentModel.ISupportInitialize)explosion).EndInit();
            ((System.ComponentModel.ISupportInitialize)Player).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI2).EndInit();
            ((System.ComponentModel.ISupportInitialize)AI1).EndInit();
            ((System.ComponentModel.ISupportInitialize)road2).EndInit();
            ((System.ComponentModel.ISupportInitialize)road1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btnPause;
        private Button btnStart;
        private TextBox inputName;
        private Label labelyourname;
        private Panel panel3;
        private Label lblLetsStart;
        private Label lblPaused;
        private Button btnreset;
        private PictureBox road1;
        private PictureBox road2;
        private PictureBox Player;
        private PictureBox AI2;
        private PictureBox AI1;
        private PictureBox trophy;
        private PictureBox explosion;
        private System.Windows.Forms.Timer timer1;
        private Label lblscore;
        private Label label1;
        private Label lblhighscore;
        private Label label2;
    }
}
