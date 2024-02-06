namespace DietBuddyApp.UI.Forms
{
    partial class WhatDidYouEat
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
            cbFoodCategories = new ComboBox();
            label2 = new Label();
            cbFood = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            label4 = new Label();
            cbMeal = new ComboBox();
            date = new DateTimePicker();
            nudMeasure = new NumericUpDown();
            lblUser = new Label();
            dataGridView1 = new DataGridView();
            btnEkle = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMeasure).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(142, 210);
            label1.Name = "label1";
            label1.Size = new Size(164, 28);
            label1.TabIndex = 0;
            label1.Text = "Food Categories";
            // 
            // cbFoodCategories
            // 
            cbFoodCategories.FormattingEnabled = true;
            cbFoodCategories.Location = new Point(142, 241);
            cbFoodCategories.Name = "cbFoodCategories";
            cbFoodCategories.Size = new Size(239, 28);
            cbFoodCategories.TabIndex = 1;
            cbFoodCategories.SelectedIndexChanged += cbFoodCategories_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(142, 365);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 2;
            label2.Text = "Measure";
            // 
            // cbFood
            // 
            cbFood.FormattingEnabled = true;
            cbFood.Location = new Point(142, 317);
            cbFood.Name = "cbFood";
            cbFood.Size = new Size(239, 28);
            cbFood.TabIndex = 5;
            cbFood.SelectedIndexChanged += cbFood_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(142, 286);
            label3.Name = "label3";
            label3.Size = new Size(58, 28);
            label3.TabIndex = 6;
            label3.Text = "Food";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(463, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 122);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.ForeColor = Color.Transparent;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(12, 12);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(37, 53);
            ıconButton1.TabIndex = 18;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(142, 132);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 19;
            label4.Text = "Meal";
            // 
            // cbMeal
            // 
            cbMeal.FormattingEnabled = true;
            cbMeal.Location = new Point(142, 163);
            cbMeal.Name = "cbMeal";
            cbMeal.Size = new Size(239, 28);
            cbMeal.TabIndex = 20;
            // 
            // date
            // 
            date.Location = new Point(142, 75);
            date.Name = "date";
            date.Size = new Size(210, 27);
            date.TabIndex = 21;
            date.ValueChanged += date_ValueChanged;
            // 
            // nudMeasure
            // 
            nudMeasure.Location = new Point(142, 396);
            nudMeasure.Name = "nudMeasure";
            nudMeasure.Size = new Size(239, 27);
            nudMeasure.TabIndex = 22;
            // 
            // lblUser
            // 
            lblUser.AutoSize = true;
            lblUser.Location = new Point(513, 64);
            lblUser.Name = "lblUser";
            lblUser.Size = new Size(50, 20);
            lblUser.TabIndex = 23;
            lblUser.Text = "label5";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 448);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(743, 265);
            dataGridView1.TabIndex = 25;
            // 
            // btnEkle
            // 
            btnEkle.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnEkle.Location = new Point(142, 744);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(133, 51);
            btnEkle.TabIndex = 27;
            btnEkle.Text = "Add";
            btnEkle.UseVisualStyleBackColor = true;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(322, 744);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(133, 51);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(496, 744);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(133, 51);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // WhatDidYouEat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foodcat3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(767, 845);
            Controls.Add(btnEkle);
            Controls.Add(dataGridView1);
            Controls.Add(lblUser);
            Controls.Add(nudMeasure);
            Controls.Add(date);
            Controls.Add(cbMeal);
            Controls.Add(label4);
            Controls.Add(ıconButton1);
            Controls.Add(pictureBox1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(label3);
            Controls.Add(cbFood);
            Controls.Add(label2);
            Controls.Add(cbFoodCategories);
            Controls.Add(label1);
            Name = "WhatDidYouEat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WhatDidYouEat";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMeasure).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }





        #endregion

        private Label label1;
        private ComboBox cbFoodCategories;
        private Label label2;
        private ComboBox cbFood;
        private Label label3;
        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Label label4;
        private ComboBox cbMeal;
        private DateTimePicker date;
        private NumericUpDown nudMeasure;
        private Label lblUser;
        private DataGridView dataGridView1;
        private Button btnEkle;
        private Button btnUpdate;
        private Button btnDelete;
    }
}