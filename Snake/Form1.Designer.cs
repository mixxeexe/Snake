namespace Snake
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.ForeColor = SystemColors.ControlText;
            button1.Location = new Point(262, 211);
            button1.MaximumSize = new Size(400, 400);
            button1.Name = "button1";
            button1.Size = new Size(272, 61);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(262, 287);
            button2.Name = "button2";
            button2.Size = new Size(272, 59);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLightLight;
            BackgroundImage = Properties.Resources.ChatGPT_Image_14_maj_2026__11_51_22;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(772, 536);
            Controls.Add(button2);
            Controls.Add(button1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Classic Snake";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        public Button button1;
        public Button button2;
    }
}
