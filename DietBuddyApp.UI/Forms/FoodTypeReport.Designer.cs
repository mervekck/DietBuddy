namespace DietBuddyApp.UI.Forms
{
    partial class FoodTypeReport
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
            dataGridView1 = new DataGridView();
            btnBreakfast = new Button();
            btnLunch = new Button();
            btnSnack = new Button();
            btnDinner = new Button();
            label1 = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.ScrollBar;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(154, 279);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(278, 289);
            dataGridView1.TabIndex = 0;
            // 
            // btnBreakfast
            // 
            btnBreakfast.BackColor = SystemColors.ButtonFace;
            btnBreakfast.Location = new Point(101, 234);
            btnBreakfast.Name = "btnBreakfast";
            btnBreakfast.Size = new Size(94, 39);
            btnBreakfast.TabIndex = 1;
            btnBreakfast.Text = "Breakfast";
            btnBreakfast.UseVisualStyleBackColor = false;
            btnBreakfast.Click += btnBreakfast_Click;
            // 
            // btnLunch
            // 
            btnLunch.BackColor = SystemColors.ButtonFace;
            btnLunch.Location = new Point(201, 234);
            btnLunch.Name = "btnLunch";
            btnLunch.Size = new Size(94, 39);
            btnLunch.TabIndex = 2;
            btnLunch.Text = "Lunch";
            btnLunch.UseVisualStyleBackColor = false;
            btnLunch.Click += btnLunch_Click;
            // 
            // btnSnack
            // 
            btnSnack.BackColor = SystemColors.ButtonFace;
            btnSnack.Location = new Point(301, 234);
            btnSnack.Name = "btnSnack";
            btnSnack.Size = new Size(94, 39);
            btnSnack.TabIndex = 3;
            btnSnack.Text = "Snack";
            btnSnack.UseVisualStyleBackColor = false;
            btnSnack.Click += btnSnack_Click;
            // 
            // btnDinner
            // 
            btnDinner.BackColor = SystemColors.ButtonFace;
            btnDinner.Location = new Point(401, 234);
            btnDinner.Name = "btnDinner";
            btnDinner.Size = new Size(94, 39);
            btnDinner.TabIndex = 4;
            btnDinner.Text = "Dinner";
            btnDinner.UseVisualStyleBackColor = false;
            btnDinner.Click += btnDinner_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(172, 197);
            label1.Name = "label1";
            label1.Size = new Size(269, 24);
            label1.TabIndex = 5;
            label1.Text = "What is your favorite food?";
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.ForeColor = Color.Transparent;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            ıconButton1.IconColor = Color.Black;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.Location = new Point(21, 25);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(37, 53);
            ıconButton1.TabIndex = 18;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // FoodTypeReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.foodtype;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(565, 788);
            Controls.Add(ıconButton1);
            Controls.Add(label1);
            Controls.Add(btnDinner);
            Controls.Add(btnSnack);
            Controls.Add(btnLunch);
            Controls.Add(btnBreakfast);
            Controls.Add(dataGridView1);
            Name = "FoodTypeReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FoodTypeReport";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBreakfast;
        private Button btnLunch;
        private Button btnSnack;
        private Button btnDinner;
        private Label label1;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}