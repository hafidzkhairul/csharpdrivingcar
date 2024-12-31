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
            label1 = new Label();
            label2 = new Label();
            selectedCar = new PictureBox();
            btnright = new PictureBox();
            btnleft = new PictureBox();
            btnstart = new PictureBox();
            buttonexit = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)selectedCar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnright).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnleft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnstart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)buttonexit).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 30);
            label1.Name = "label1";
            label1.Size = new Size(295, 54);
            label1.TabIndex = 0;
            label1.Text = "ringroad racing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(247, 113);
            label2.Name = "label2";
            label2.Size = new Size(150, 28);
            label2.TabIndex = 1;
            label2.Text = "choose your car";
            // 
            // selectedCar
            // 
            selectedCar.Image = Properties.Resources.car101;
            selectedCar.Location = new Point(247, 180);
            selectedCar.Margin = new Padding(3, 4, 3, 4);
            selectedCar.Name = "selectedCar";
            selectedCar.Size = new Size(123, 269);
            selectedCar.SizeMode = PictureBoxSizeMode.StretchImage;
            selectedCar.TabIndex = 2;
            selectedCar.TabStop = false;
            // 
            // btnright
            // 
            btnright.Image = Properties.Resources.btn_right1;
            btnright.Location = new Point(445, 260);
            btnright.Margin = new Padding(3, 4, 3, 4);
            btnright.Name = "btnright";
            btnright.Size = new Size(112, 136);
            btnright.SizeMode = PictureBoxSizeMode.Zoom;
            btnright.TabIndex = 8;
            btnright.TabStop = false;
            btnright.Click += slcright_Click;
            // 
            // btnleft
            // 
            btnleft.Image = Properties.Resources.btn_left21;
            btnleft.Location = new Point(63, 260);
            btnleft.Margin = new Padding(3, 4, 3, 4);
            btnleft.Name = "btnleft";
            btnleft.Size = new Size(112, 136);
            btnleft.SizeMode = PictureBoxSizeMode.Zoom;
            btnleft.TabIndex = 9;
            btnleft.TabStop = false;
            btnleft.Click += slcleft_Click;
            // 
            // btnstart
            // 
            btnstart.Image = Properties.Resources.btn_start1;
            btnstart.Location = new Point(195, 568);
            btnstart.Margin = new Padding(3, 4, 3, 4);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(209, 101);
            btnstart.SizeMode = PictureBoxSizeMode.Zoom;
            btnstart.TabIndex = 12;
            btnstart.TabStop = false;
            btnstart.Click += btnStart_Click;
            // 
            // buttonexit
            // 
            buttonexit.Image = Properties.Resources.btn_exit1;
            buttonexit.Location = new Point(195, 691);
            buttonexit.Margin = new Padding(3, 4, 3, 4);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(209, 101);
            buttonexit.SizeMode = PictureBoxSizeMode.Zoom;
            buttonexit.TabIndex = 13;
            buttonexit.TabStop = false;
            buttonexit.Click += btnExit_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(622, 1055);
            Controls.Add(buttonexit);
            Controls.Add(btnstart);
            Controls.Add(btnleft);
            Controls.Add(btnright);
            Controls.Add(selectedCar);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ll";
            ((System.ComponentModel.ISupportInitialize)selectedCar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnright).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnleft).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnstart).EndInit();
            ((System.ComponentModel.ISupportInitialize)buttonexit).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private PictureBox selectedCar;
        private PictureBox btnright;
        private PictureBox btnleft;
        private PictureBox btnstart;
        private PictureBox buttonexit;
    }
}