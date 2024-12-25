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
            slcright = new Button();
            slcleft = new Button();
            inputName = new TextBox();
            btnStart = new Button();
            btnExit = new Button();
            ((System.ComponentModel.ISupportInitialize)selectedCar).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(141, 29);
            label1.Name = "label1";
            label1.Size = new Size(237, 45);
            label1.TabIndex = 0;
            label1.Text = "ringroad racing";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(198, 91);
            label2.Name = "label2";
            label2.Size = new Size(120, 21);
            label2.TabIndex = 1;
            label2.Text = "choose your car";
            // 
            // selectedCar
            // 
            selectedCar.Image = Properties.Resources.car1;
            selectedCar.Location = new Point(220, 147);
            selectedCar.Name = "selectedCar";
            selectedCar.Size = new Size(108, 202);
            selectedCar.SizeMode = PictureBoxSizeMode.StretchImage;
            selectedCar.TabIndex = 2;
            selectedCar.TabStop = false;
            // 
            // slcright
            // 
            slcright.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slcright.Location = new Point(411, 195);
            slcright.Name = "slcright";
            slcright.Size = new Size(75, 85);
            slcright.TabIndex = 3;
            slcright.Text = ">";
            slcright.UseVisualStyleBackColor = true;
            slcright.Click += slcright_Click;
            // 
            // slcleft
            // 
            slcleft.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            slcleft.Location = new Point(52, 195);
            slcleft.Name = "slcleft";
            slcleft.Size = new Size(75, 85);
            slcleft.TabIndex = 4;
            slcleft.Text = "<";
            slcleft.UseVisualStyleBackColor = true;
            slcleft.Click += slcleft_Click;
            // 
            // inputName
            // 
            inputName.Font = new Font("Arial Rounded MT Bold", 14F);
            inputName.Location = new Point(170, 393);
            inputName.Name = "inputName";
            inputName.PlaceholderText = "Your Name";
            inputName.Size = new Size(196, 29);
            inputName.TabIndex = 5;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(229, 484);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(75, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(229, 552);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(544, 841);
            Controls.Add(btnExit);
            Controls.Add(btnStart);
            Controls.Add(inputName);
            Controls.Add(slcleft);
            Controls.Add(slcright);
            Controls.Add(selectedCar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)selectedCar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button slcright;
        private Button slcleft;
        private TextBox inputName;
        private Button btnStart;
        private Button btnExit;
        private PictureBox selectedCar;
    }
}