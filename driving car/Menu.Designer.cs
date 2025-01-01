namespace driving_car
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            selectedCar = new PictureBox();
            btnright = new PictureBox();
            btnleft = new PictureBox();
            btnstart = new PictureBox();
            buttonexit = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)selectedCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnleft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnstart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonexit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // selectedCar
            // 
            selectedCar.BackColor = Color.Transparent;
            selectedCar.Image = Properties.Resources.car101;
            selectedCar.Location = new Point(216, 195);
            selectedCar.Name = "selectedCar";
            selectedCar.Size = new Size(108, 202);
            selectedCar.SizeMode = PictureBoxSizeMode.StretchImage;
            selectedCar.TabIndex = 2;
            selectedCar.TabStop = false;
            // 
            // btnright
            // 
            btnright.BackColor = Color.Transparent;
            btnright.Image = Properties.Resources.btn_right1;
            btnright.Location = new Point(388, 250);
            btnright.Name = "btnright";
            btnright.Size = new Size(98, 102);
            btnright.SizeMode = PictureBoxSizeMode.Zoom;
            btnright.TabIndex = 8;
            btnright.TabStop = false;
            btnright.Click += slcright_Click;
            // 
            // btnleft
            // 
            btnleft.BackColor = Color.Transparent;
            btnleft.Image = Properties.Resources.btn_left21;
            btnleft.Location = new Point(58, 250);
            btnleft.Name = "btnleft";
            btnleft.Size = new Size(98, 102);
            btnleft.SizeMode = PictureBoxSizeMode.Zoom;
            btnleft.TabIndex = 9;
            btnleft.TabStop = false;
            btnleft.Click += slcleft_Click;
            // 
            // btnstart
            // 
            btnstart.BackColor = Color.Transparent;
            btnstart.Image = Properties.Resources.startbtn;
            btnstart.Location = new Point(149, 442);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(214, 96);
            btnstart.SizeMode = PictureBoxSizeMode.Zoom;
            btnstart.TabIndex = 12;
            btnstart.TabStop = false;
            btnstart.Click += btnStart_Click;
            // 
            // buttonexit
            // 
            buttonexit.BackColor = Color.Transparent;
            buttonexit.Image = Properties.Resources.btn_exit1;
            buttonexit.Location = new Point(163, 544);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(200, 64);
            buttonexit.SizeMode = PictureBoxSizeMode.Zoom;
            buttonexit.TabIndex = 13;
            buttonexit.TabStop = false;
            buttonexit.Click += btnExit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(103, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(337, 175);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(544, 791);
            Controls.Add(pictureBox1);
            Controls.Add(buttonexit);
            Controls.Add(btnstart);
            Controls.Add(btnleft);
            Controls.Add(btnright);
            Controls.Add(selectedCar);
            DoubleBuffered = true;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)selectedCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnright).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnleft).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnstart).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonexit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox selectedCar;
        private PictureBox btnright;
        private PictureBox btnleft;
        private PictureBox btnstart;
        private PictureBox buttonexit;
        private PictureBox pictureBox1;
    }
}