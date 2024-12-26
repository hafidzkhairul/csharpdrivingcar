namespace driving_car
{
    partial class Level
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
            lvl1 = new Button();
            lvl5 = new Button();
            lvl6 = new Button();
            lvl4 = new Button();
            lvl3 = new Button();
            lvl2 = new Button();
            backtomenu = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(222, 25);
            label1.Name = "label1";
            label1.Size = new Size(60, 30);
            label1.TabIndex = 0;
            label1.Text = "Level";
            // 
            // lvl1
            // 
            lvl1.Location = new Point(36, 83);
            lvl1.Name = "lvl1";
            lvl1.Size = new Size(85, 83);
            lvl1.TabIndex = 1;
            lvl1.Text = "1";
            lvl1.UseVisualStyleBackColor = true;
            lvl1.Click += lvl1_Click;
            // 
            // lvl5
            // 
            lvl5.Location = new Point(222, 268);
            lvl5.Name = "lvl5";
            lvl5.Size = new Size(85, 83);
            lvl5.TabIndex = 2;
            lvl5.Text = "5";
            lvl5.UseVisualStyleBackColor = true;
            lvl5.Click += lvl5_Click;
            // 
            // lvl6
            // 
            lvl6.Location = new Point(395, 268);
            lvl6.Name = "lvl6";
            lvl6.Size = new Size(85, 83);
            lvl6.TabIndex = 3;
            lvl6.Text = "6";
            lvl6.UseVisualStyleBackColor = true;
            lvl6.Click += lvl6_Click;
            // 
            // lvl4
            // 
            lvl4.Location = new Point(36, 268);
            lvl4.Name = "lvl4";
            lvl4.Size = new Size(85, 83);
            lvl4.TabIndex = 4;
            lvl4.Text = "4";
            lvl4.UseVisualStyleBackColor = true;
            lvl4.Click += lvl4_Click;
            // 
            // lvl3
            // 
            lvl3.Location = new Point(395, 83);
            lvl3.Name = "lvl3";
            lvl3.Size = new Size(85, 83);
            lvl3.TabIndex = 5;
            lvl3.Text = "3";
            lvl3.UseVisualStyleBackColor = true;
            lvl3.Click += lvl3_Click;
            // 
            // lvl2
            // 
            lvl2.Location = new Point(222, 83);
            lvl2.Name = "lvl2";
            lvl2.Size = new Size(85, 83);
            lvl2.TabIndex = 6;
            lvl2.Text = "2";
            lvl2.UseVisualStyleBackColor = true;
            lvl2.Click += lvl2_Click;
            // 
            // backtomenu
            // 
            backtomenu.Image = Properties.Resources.btn_exit;
            backtomenu.Location = new Point(401, 12);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(131, 51);
            backtomenu.SizeMode = PictureBoxSizeMode.Zoom;
            backtomenu.TabIndex = 12;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // Level
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(544, 841);
            Controls.Add(backtomenu);
            Controls.Add(lvl2);
            Controls.Add(lvl3);
            Controls.Add(lvl4);
            Controls.Add(lvl6);
            Controls.Add(lvl5);
            Controls.Add(lvl1);
            Controls.Add(label1);
            Name = "Level";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level";
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button lvl1;
        private Button lvl5;
        private Button lvl6;
        private Button lvl4;
        private Button lvl3;
        private Button lvl2;
        private PictureBox backtomenu;
    }
}