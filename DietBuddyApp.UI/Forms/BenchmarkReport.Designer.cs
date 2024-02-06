namespace DietBuddyApp.UI.Forms
{
    partial class BenchmarkReport
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
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            dataGridView1 = new DataGridView();
            menuStrip1 = new MenuStrip();
            weeklyToolStripMenuItem = new ToolStripMenuItem();
            weeklyFoodCategories = new ToolStripMenuItem();
            weeklyMeals = new ToolStripMenuItem();
            monthlyToolStripMenuItem = new ToolStripMenuItem();
            monthlyFoodCategories = new ToolStripMenuItem();
            monthlyMeals = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.ForeColor = Color.Transparent;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(8, 12);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(37, 53);
            ıconButton1.TabIndex = 17;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Snow;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(158, 174);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(627, 327);
            dataGridView1.TabIndex = 22;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Snow;
            menuStrip1.Dock = DockStyle.None;
            menuStrip1.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { weeklyToolStripMenuItem, monthlyToolStripMenuItem });
            menuStrip1.Location = new Point(346, 107);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(263, 46);
            menuStrip1.TabIndex = 23;
            menuStrip1.Text = "menuStrip1";
            // 
            // weeklyToolStripMenuItem
            // 
            weeklyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { weeklyFoodCategories, weeklyMeals });
            weeklyToolStripMenuItem.Name = "weeklyToolStripMenuItem";
            weeklyToolStripMenuItem.Size = new Size(121, 42);
            weeklyToolStripMenuItem.Text = "Weekly";
            // 
            // weeklyFoodCategories
            // 
            weeklyFoodCategories.Name = "weeklyFoodCategories";
            weeklyFoodCategories.Size = new Size(309, 42);
            weeklyFoodCategories.Text = "Food Categories";
            weeklyFoodCategories.Click += weeklyFoodCategories_Click;
            // 
            // weeklyMeals
            // 
            weeklyMeals.Name = "weeklyMeals";
            weeklyMeals.Size = new Size(309, 42);
            weeklyMeals.Text = "Meals";
            weeklyMeals.Click += weeklyMeals_Click;
            // 
            // monthlyToolStripMenuItem
            // 
            monthlyToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { monthlyFoodCategories, monthlyMeals });
            monthlyToolStripMenuItem.Name = "monthlyToolStripMenuItem";
            monthlyToolStripMenuItem.Size = new Size(134, 42);
            monthlyToolStripMenuItem.Text = "Monthly";
            // 
            // monthlyFoodCategories
            // 
            monthlyFoodCategories.Name = "monthlyFoodCategories";
            monthlyFoodCategories.Size = new Size(309, 42);
            monthlyFoodCategories.Text = "Food Categories";
            monthlyFoodCategories.Click += monthlyFoodCategories_Click;
            // 
            // monthlyMeals
            // 
            monthlyMeals.Name = "monthlyMeals";
            monthlyMeals.Size = new Size(309, 42);
            monthlyMeals.Text = "Meals";
            monthlyMeals.Click += monthlyMeals_Click;
            // 
            // BenchmarkReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.benchmark3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(923, 577);
            Controls.Add(dataGridView1);
            Controls.Add(ıconButton1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "BenchmarkReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Benchmark Report";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FontAwesome.Sharp.IconButton ıconButton1;
        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem weeklyToolStripMenuItem;
        private ToolStripMenuItem monthlyToolStripMenuItem;
        private ToolStripMenuItem weeklyFoodCategories;
        private ToolStripMenuItem weeklyMeals;
        private ToolStripMenuItem monthlyFoodCategories;
        private ToolStripMenuItem monthlyMeals;
    }
}