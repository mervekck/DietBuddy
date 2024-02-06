namespace DietBuddyApp.UI.Forms
{
    partial class HomePage
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
            pbUser = new PictureBox();
            lblUser = new Label();
            button1 = new Button();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            foodToolStripMenuItem = new ToolStripMenuItem();
            whatDidYouEatToolStripMenuItem = new ToolStripMenuItem();
            raporlarToolStripMenuItem = new ToolStripMenuItem();
            endOfDayReportToolStripMenuItem = new ToolStripMenuItem();
            benchmarkToolStripMenuItem = new ToolStripMenuItem();
            foodTypeReportToolStripMenuItem = new ToolStripMenuItem();
            ayarlarToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblBMI = new Label();
            lblHeight = new Label();
            lblWeight = new Label();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pbUser
            // 
            pbUser.BackgroundImage = Properties.Resources.admin1;
            pbUser.BackgroundImageLayout = ImageLayout.Stretch;
            pbUser.Location = new Point(521, 12);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(62, 59);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.BackColor = Color.Transparent;
            lblUser.Location = new Point(486, 87);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(38, 20);
            lblUser.TabIndex = 1;
            lblUser.Text = "User";
            // 
            // button1
            // 
            button1.Location = new Point(486, 259);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Handwriting", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(16, 12);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(236, 77);
            label3.TabIndex = 5;
            label3.Text = "DietBuddy";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Transparent;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { foodToolStripMenuItem, whatDidYouEatToolStripMenuItem, raporlarToolStripMenuItem, ayarlarToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(9, 107);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(6, 3, 0, 3);
            menuStrip1.Size = new Size(595, 33);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // foodToolStripMenuItem
            // 
            foodToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            foodToolStripMenuItem.Name = "foodToolStripMenuItem";
            foodToolStripMenuItem.Size = new Size(178, 27);
            foodToolStripMenuItem.Text = "How many Calories?";
            foodToolStripMenuItem.Click += foodToolStripMenuItem_Click;
            // 
            // whatDidYouEatToolStripMenuItem
            // 
            whatDidYouEatToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            whatDidYouEatToolStripMenuItem.Name = "whatDidYouEatToolStripMenuItem";
            whatDidYouEatToolStripMenuItem.Size = new Size(164, 27);
            whatDidYouEatToolStripMenuItem.Text = "What did you eat?";
            whatDidYouEatToolStripMenuItem.Click += whatDidYouEatToolStripMenuItem_Click;
            // 
            // raporlarToolStripMenuItem
            // 
            raporlarToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { endOfDayReportToolStripMenuItem, benchmarkToolStripMenuItem, foodTypeReportToolStripMenuItem });
            raporlarToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            raporlarToolStripMenuItem.Name = "raporlarToolStripMenuItem";
            raporlarToolStripMenuItem.Size = new Size(82, 27);
            raporlarToolStripMenuItem.Text = "Reports";
            // 
            // endOfDayReportToolStripMenuItem
            // 
            endOfDayReportToolStripMenuItem.Name = "endOfDayReportToolStripMenuItem";
            endOfDayReportToolStripMenuItem.Size = new Size(236, 28);
            endOfDayReportToolStripMenuItem.Text = "End Of Day Report";
            endOfDayReportToolStripMenuItem.Click += endOfDayReportToolStripMenuItem_Click;
            // 
            // benchmarkToolStripMenuItem
            // 
            benchmarkToolStripMenuItem.Name = "benchmarkToolStripMenuItem";
            benchmarkToolStripMenuItem.Size = new Size(236, 28);
            benchmarkToolStripMenuItem.Text = "Benchmark Report";
            benchmarkToolStripMenuItem.Click += benchmarkToolStripMenuItem_Click;
            // 
            // foodTypeReportToolStripMenuItem
            // 
            foodTypeReportToolStripMenuItem.Name = "foodTypeReportToolStripMenuItem";
            foodTypeReportToolStripMenuItem.Size = new Size(236, 28);
            foodTypeReportToolStripMenuItem.Text = "Food Type Report";
            foodTypeReportToolStripMenuItem.Click += foodTypeReportToolStripMenuItem_Click;
            // 
            // ayarlarToolStripMenuItem
            // 
            ayarlarToolStripMenuItem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            ayarlarToolStripMenuItem.Size = new Size(85, 27);
            ayarlarToolStripMenuItem.Text = "Settings";
            ayarlarToolStripMenuItem.Click += ayarlarToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(78, 27);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(156, 254);
            label2.Name = "label2";
            label2.Size = new Size(128, 46);
            label2.TabIndex = 14;
            label2.Text = "Weight";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(156, 178);
            label4.Name = "label4";
            label4.Size = new Size(121, 46);
            label4.TabIndex = 15;
            label4.Text = "Height";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(156, 334);
            label5.Name = "label5";
            label5.Size = new Size(79, 46);
            label5.TabIndex = 16;
            label5.Text = "BMI";
            // 
            // lblBMI
            // 
            lblBMI.AutoSize = true;
            lblBMI.BackColor = Color.Transparent;
            lblBMI.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblBMI.Location = new Point(373, 334);
            lblBMI.Name = "lblBMI";
            lblBMI.Size = new Size(63, 46);
            lblBMI.TabIndex = 19;
            lblBMI.Text = "0.0";
            // 
            // lblHeight
            // 
            lblHeight.AutoSize = true;
            lblHeight.BackColor = Color.Transparent;
            lblHeight.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblHeight.Location = new Point(373, 178);
            lblHeight.Name = "lblHeight";
            lblHeight.Size = new Size(63, 46);
            lblHeight.TabIndex = 18;
            lblHeight.Text = "0.0";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.BackColor = Color.Transparent;
            lblWeight.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblWeight.Location = new Point(373, 254);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(63, 46);
            lblWeight.TabIndex = 17;
            lblWeight.Text = "0.0";
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Menu;
            BackgroundImage = Properties.Resources.baharat;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(614, 644);
            Controls.Add(lblBMI);
            Controls.Add(lblHeight);
            Controls.Add(lblWeight);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(lblUser);
            Controls.Add(pbUser);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pbUser;
        private Label lblUser;
        private Button button1;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem whatDidYouEatToolStripMenuItem;
        private ToolStripMenuItem raporlarToolStripMenuItem;
        private ToolStripMenuItem ayarlarToolStripMenuItem;
        private ToolStripMenuItem çıkışToolStripMenuItem;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label lblBMI;
        private Label lblHeight;
        private Label lblWeight;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private ToolStripMenuItem foodToolStripMenuItem;
        private ToolStripMenuItem endOfDayReportToolStripMenuItem;
        private ToolStripMenuItem benchmarkToolStripMenuItem;
        private ToolStripMenuItem foodTypeReportToolStripMenuItem;
    }
}