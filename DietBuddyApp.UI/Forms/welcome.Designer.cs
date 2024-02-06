namespace DietBuddyApp.UI
{
    partial class Welcome
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
            timer1 = new System.Windows.Forms.Timer(components);
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 5000;
            timer1.Tick += timer1_Tick;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Lucida Handwriting", 36F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(10, 63);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(508, 115);
            label1.TabIndex = 0;
            label1.Text = "DietBuddy";
            label1.TextAlign = ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Lucida Handwriting", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.OrangeRed;
            label2.Location = new Point(18, 196);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(464, 115);
            label2.TabIndex = 1;
            label2.Text = "All You Need!";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label2_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.welcome1;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(506, 631);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            MaximumSize = new Size(527, 685);
            Name = "Welcome";
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private Label label2;
    }
}