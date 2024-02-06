namespace DietBuddyApp.UI.Forms
{
    partial class HowManyCalories
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
            pictureBox1 = new PictureBox();
            label3 = new Label();
            cbFood = new ComboBox();
            label2 = new Label();
            cbFoodCategories = new ComboBox();
            label1 = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            btnShow = new Button();
            dataGridView1 = new DataGridView();
            nudMeasure = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMeasure).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(528, 164);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 29;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(216, 240);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 27;
            label3.Text = "Food";
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(216, 271);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(239, 28);
            cbFood.TabIndex = 26;
            cbFood.SelectedIndexChanged += cbFood_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(216, 319);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 24;
            label2.Text = "Measure";
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(216, 195);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(239, 28);
            cbFoodCategories.TabIndex = 23;
            cbFoodCategories.SelectedIndexChanged += cbFoodCategories_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(216, 164);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 22;
            label1.Text = "Food Categories";
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.ForeColor = Color.Transparent;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(36, 39);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(37, 53);
            ıconButton1.TabIndex = 30;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(528, 319);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(118, 51);
            btnShow.TabIndex = 31;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(148, 416);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(544, 112);
            dataGridView1.TabIndex = 32;
            // 
            // nudMeasure
            // 
            nudMeasure.Location = new Point(216, 359);
            nudMeasure.Name = "nudMeasure";
            nudMeasure.Size = new Size(239, 27);
            nudMeasure.TabIndex = 33;
            // 
            // HowManyCalories
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.zeytinli;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(860, 620);
            Controls.Add(nudMeasure);
            Controls.Add(dataGridView1);
            Controls.Add(btnShow);
            Controls.Add(ıconButton1);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(cbFood);
            Controls.Add(label2);
            Controls.Add(cbFoodCategories);
            Controls.Add(label1);
            Name = "HowManyCalories";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HowManyCalories";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMeasure).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox cbFood;
        private Label label2;
        private ComboBox cbFoodCategories;
        private Label label1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Button btnShow;
        private DataGridView dataGridView1;
        private NumericUpDown nudMeasure;
    }
}