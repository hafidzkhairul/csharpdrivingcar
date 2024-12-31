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
            lvl1 = new Button();
            lvl5 = new Button();
            lvl6 = new Button();
            lvl4 = new Button();
            lvl3 = new Button();
            lvl2 = new Button();
            backtomenu = new PictureBox();
            pictureBox6 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)backtomenu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // lvl1
            // 
            lvl1.Image = Properties.Resources.levels1;
            lvl1.Location = new Point(41, 111);
            lvl1.Margin = new Padding(3, 4, 3, 4);
            lvl1.Name = "lvl1";
            lvl1.Size = new Size(107, 111);
            lvl1.TabIndex = 1;
            lvl1.UseVisualStyleBackColor = true;
            lvl1.Click += lvl1_Click;
            // 
            // lvl5
            // 
            lvl5.Image = Properties.Resources.levels5;
            lvl5.Location = new Point(254, 357);
            lvl5.Margin = new Padding(3, 4, 3, 4);
            lvl5.Name = "lvl5";
            lvl5.Size = new Size(104, 111);
            lvl5.TabIndex = 2;
            lvl5.UseVisualStyleBackColor = true;
            lvl5.Click += lvl5_Click;
            // 
            // lvl6
            // 
            lvl6.Image = Properties.Resources.levels6;
            lvl6.Location = new Point(451, 357);
            lvl6.Margin = new Padding(3, 4, 3, 4);
            lvl6.Name = "lvl6";
            lvl6.Size = new Size(102, 111);
            lvl6.TabIndex = 3;
            lvl6.UseVisualStyleBackColor = true;
            lvl6.Click += lvl6_Click;
            // 
            // lvl4
            // 
            lvl4.Image = Properties.Resources.levels4;
            lvl4.Location = new Point(41, 357);
            lvl4.Margin = new Padding(3, 4, 3, 4);
            lvl4.Name = "lvl4";
            lvl4.Size = new Size(107, 111);
            lvl4.TabIndex = 4;
            lvl4.UseVisualStyleBackColor = true;
            lvl4.Click += lvl4_Click;
            // 
            // lvl3
            // 
            lvl3.Image = Properties.Resources.levels3;
            lvl3.Location = new Point(451, 111);
            lvl3.Margin = new Padding(3, 4, 3, 4);
            lvl3.Name = "lvl3";
            lvl3.Size = new Size(102, 111);
            lvl3.TabIndex = 5;
            lvl3.UseVisualStyleBackColor = true;
            lvl3.Click += lvl3_Click;
            // 
            // lvl2
            // 
            lvl2.Image = Properties.Resources.levels2;
            lvl2.Location = new Point(254, 111);
            lvl2.Margin = new Padding(3, 4, 3, 4);
            lvl2.Name = "lvl2";
            lvl2.Size = new Size(104, 111);
            lvl2.TabIndex = 6;
            lvl2.UseVisualStyleBackColor = true;
            lvl2.Click += lvl2_Click;
            // 
            // backtomenu
            // 
            backtomenu.Image = Properties.Resources.btn_exit1;
            backtomenu.Location = new Point(482, 28);
            backtomenu.Margin = new Padding(3, 4, 3, 4);
            backtomenu.Name = "backtomenu";
            backtomenu.Size = new Size(128, 46);
            backtomenu.SizeMode = PictureBoxSizeMode.Zoom;
            backtomenu.TabIndex = 12;
            backtomenu.TabStop = false;
            backtomenu.Click += backtomenu_Click;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.level;
            pictureBox6.Location = new Point(245, 28);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(125, 46);
            pictureBox6.TabIndex = 18;
            pictureBox6.TabStop = false;
            // 
            // Level
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(622, 1055);
            Controls.Add(pictureBox6);
            Controls.Add(backtomenu);
            Controls.Add(lvl2);
            Controls.Add(lvl3);
            Controls.Add(lvl4);
            Controls.Add(lvl6);
            Controls.Add(lvl5);
            Controls.Add(lvl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Level";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Level";
            ((System.ComponentModel.ISupportInitialize)backtomenu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button lvl1;
        private Button lvl5;
        private Button lvl6;
        private Button lvl4;
        private Button lvl3;
        private Button lvl2;
        private PictureBox backtomenu;
        private PictureBox pictureBox6;
    }
}