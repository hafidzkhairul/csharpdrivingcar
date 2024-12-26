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
            inputName = new TextBox();
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
            label1.Location = new Point(152, 30);
            label1.Name = "label1";
            label1.Size = new Size(237, 45);
            label1.TabIndex = 0;
            label1.Text = "ringroad racing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(216, 85);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 1;
            label2.Text = "choose your car";
            // 
            // selectedCar
            // 
            selectedCar.Image = Properties.Resources.car1;
            selectedCar.Location = new Point(216, 135);
            selectedCar.Name = "selectedCar";
            selectedCar.Size = new Size(108, 202);
            selectedCar.SizeMode = PictureBoxSizeMode.StretchImage;
            selectedCar.TabIndex = 2;
            selectedCar.TabStop = false;
            // 
            // inputName
            // 
            inputName.Font = new Font("Arial Rounded MT Bold", 14F);
            inputName.Location = new Point(171, 381);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Player";
            inputName.Size = new Size(183, 29);
            inputName.TabIndex = 5;
            inputName.TextAlign = HorizontalAlignment.Center;
            // 
            // btnright
            // 
            btnright.Image = Properties.Resources.btn_right;
            btnright.Location = new Point(389, 195);
            btnright.Name = "btnright";
            btnright.Size = new Size(98, 102);
            btnright.SizeMode = PictureBoxSizeMode.Zoom;
            btnright.TabIndex = 8;
            btnright.TabStop = false;
            btnright.Click += slcright_Click;
            // 
            // btnleft
            // 
            btnleft.Image = Properties.Resources.btn_left2;
            btnleft.Location = new Point(55, 195);
            btnleft.Name = "btnleft";
            btnleft.Size = new Size(98, 102);
            btnleft.SizeMode = PictureBoxSizeMode.Zoom;
            btnleft.TabIndex = 9;
            btnleft.TabStop = false;
            btnleft.Click += slcleft_Click;
            // 
            // btnstart
            // 
            btnstart.Image = Properties.Resources.btn_star;
            btnstart.Location = new Point(171, 426);
            btnstart.Name = "btnstart";
            btnstart.Size = new Size(183, 76);
            btnstart.SizeMode = PictureBoxSizeMode.Zoom;
            btnstart.TabIndex = 12;
            btnstart.TabStop = false;
            btnstart.Click += btnStart_Click;
            // 
            // buttonexit
            // 
            buttonexit.Image = Properties.Resources.btn_exit;
            buttonexit.Location = new Point(171, 518);
            buttonexit.Name = "buttonexit";
            buttonexit.Size = new Size(183, 76);
            buttonexit.SizeMode = PictureBoxSizeMode.Zoom;
            buttonexit.TabIndex = 13;
            buttonexit.TabStop = false;
            buttonexit.Click += btnExit_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(544, 841);
            Controls.Add(buttonexit);
            Controls.Add(btnstart);
            Controls.Add(btnleft);
            Controls.Add(btnright);
            Controls.Add(inputName);
            Controls.Add(selectedCar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
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
        private TextBox inputName;
        private PictureBox selectedCar;
        private PictureBox btnright;
        private PictureBox btnleft;
        private PictureBox btnstart;
        private PictureBox buttonexit;
    }
}