namespace Snake
{
    partial class Snake
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Snake));
            timer1 = new System.Windows.Forms.Timer(components);
            pktlbl = new Label();
            lvllbl = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Tick += UpdateGame;
            // 
            // pktlbl
            // 
            pktlbl.BackColor = Color.Transparent;
            pktlbl.Cursor = Cursors.Help;
            pktlbl.Font = new Font("Copperplate Gothic Light", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            pktlbl.Location = new Point(96, 25);
            pktlbl.Name = "pktlbl";
            pktlbl.Size = new Size(246, 36);
            pktlbl.TabIndex = 0;
            pktlbl.Text = "Punkty: 0";
            pktlbl.Click += pktlbl_Click;
            // 
            // lvllbl
            // 
            lvllbl.AutoEllipsis = true;
            lvllbl.AutoSize = true;
            lvllbl.BackColor = Color.Transparent;
            lvllbl.Cursor = Cursors.Help;
            lvllbl.Font = new Font("Copperplate Gothic Light", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvllbl.Location = new Point(338, 30);
            lvllbl.Name = "lvllbl";
            lvllbl.Size = new Size(111, 31);
            lvllbl.TabIndex = 1;
            lvllbl.Text = "LVL: 1";
            // 
            // Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage =Properties.Resources.ChatGPT_Image_14_maj_2026__11_56_27;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(634, 526);
            Controls.Add(lvllbl);
            Controls.Add(pktlbl);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximumSize = new Size(650, 565);
            MinimumSize = new Size(650, 565);
            Name = "Snake";
            Text = "Classic Snake";
            Load += Snake_Load;
            KeyDown += Snake_KeyDown;
            KeyPress += Snake_KeyPress;
            KeyUp += Snake_KeyUp;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label pktlbl;
        private Label lvllbl;
    }
}