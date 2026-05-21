namespace Snake
{
    partial class Ending
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(297, 199);
            button1.MaximumSize = new Size(400, 400);
            button1.Name = "button1";
            button1.Size = new Size(221, 52);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(297, 266);
            button2.MaximumSize = new Size(400, 400);
            button2.Name = "button2";
            button2.Size = new Size(221, 52);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(297, 335);
            button3.MaximumSize = new Size(400, 400);
            button3.Name = "button3";
            button3.Size = new Size(221, 52);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = false;
            // 
            // Ending
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage =Properties.Resources.ChatGPT_Image_21_maj_2026__12_03_45;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 546);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            MaximizeBox = false;
            MaximumSize = new Size(816, 585);
            MinimizeBox = false;
            MinimumSize = new Size(816, 585);
            Name = "Ending";
            Text = "Ending";
            Load += Ending_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button button1;
        public Button button2;
        public Button button3;
    }
}