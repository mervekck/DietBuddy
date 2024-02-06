namespace DietBuddyApp.UI.Forms
{
    partial class EndOfDayReport
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
            date = new DateTimePicker();
            label1 = new Label();
            lbltoplam = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel1 = new Panel();
            lblProtein = new Label();
            lblTotalFat = new Label();
            lblCarbs = new Label();
            panel2 = new Panel();
            groupBox1 = new GroupBox();
            lblBCalorie = new Label();
            label14 = new Label();
            lblBProtein = new Label();
            lblBFat = new Label();
            lblBCarbs = new Label();
            label21 = new Label();
            label22 = new Label();
            label23 = new Label();
            groupBox2 = new GroupBox();
            lblSCalorie = new Label();
            label26 = new Label();
            lblSProtein = new Label();
            lblSFat = new Label();
            lblSCarbs = new Label();
            label33 = new Label();
            label34 = new Label();
            label35 = new Label();
            groupBox3 = new GroupBox();
            lblLCalorie = new Label();
            label38 = new Label();
            lblLProtein = new Label();
            lblLFat = new Label();
            lblLCarbs = new Label();
            label45 = new Label();
            label46 = new Label();
            label47 = new Label();
            groupBox5 = new GroupBox();
            lblDCalorie = new Label();
            label62 = new Label();
            lblDProtein = new Label();
            lblDFat = new Label();
            lblDCarbs = new Label();
            label69 = new Label();
            label70 = new Label();
            label71 = new Label();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            SuspendLayout();
            // 
            // date
            // 
            date.Location = new Point(242, 194);
            date.Name = "date";
            date.Size = new Size(210, 27);
            date.TabIndex = 0;
            date.ValueChanged += date_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 17);
            label1.Name = "label1";
            label1.Size = new Size(93, 20);
            label1.TabIndex = 1;
            label1.Text = "Total Calorie";
            // 
            // lbltoplam
            // 
            lbltoplam.AutoSize = true;
            lbltoplam.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbltoplam.Location = new Point(10, 54);
            lbltoplam.Name = "lbltoplam";
            lbltoplam.Size = new Size(32, 23);
            lbltoplam.TabIndex = 2;
            lbltoplam.Text = "0.0";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(58, 12);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 5;
            label2.Text = "Carbs";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(201, 12);
            label4.Name = "label4";
            label4.Size = new Size(56, 20);
            label4.TabIndex = 6;
            label4.Text = "Protein";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(369, 12);
            label5.Name = "label5";
            label5.Size = new Size(28, 20);
            label5.TabIndex = 7;
            label5.Text = "Fat";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(lblProtein);
            panel1.Controls.Add(lblTotalFat);
            panel1.Controls.Add(lblCarbs);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Location = new Point(101, 350);
            panel1.Name = "panel1";
            panel1.Size = new Size(494, 64);
            panel1.TabIndex = 8;
            // 
            // lblProtein
            // 
            lblProtein.AutoSize = true;
            lblProtein.Location = new Point(203, 32);
            lblProtein.Name = "lblProtein";
            lblProtein.Size = new Size(17, 20);
            lblProtein.TabIndex = 12;
            lblProtein.Text = "0";
            // 
            // lblTotalFat
            // 
            lblTotalFat.AutoSize = true;
            lblTotalFat.Location = new Point(360, 32);
            lblTotalFat.Name = "lblTotalFat";
            lblTotalFat.Size = new Size(17, 20);
            lblTotalFat.TabIndex = 10;
            lblTotalFat.Text = "0";
            // 
            // lblCarbs
            // 
            lblCarbs.AutoSize = true;
            lblCarbs.Location = new Point(61, 32);
            lblCarbs.Name = "lblCarbs";
            lblCarbs.Size = new Size(17, 20);
            lblCarbs.TabIndex = 8;
            lblCarbs.Text = "0";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(label1);
            panel2.Controls.Add(lbltoplam);
            panel2.Location = new Point(284, 237);
            panel2.Name = "panel2";
            panel2.Size = new Size(118, 107);
            panel2.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(lblBCalorie);
            groupBox1.Controls.Add(label14);
            groupBox1.Controls.Add(lblBProtein);
            groupBox1.Controls.Add(lblBFat);
            groupBox1.Controls.Add(lblBCarbs);
            groupBox1.Controls.Add(label21);
            groupBox1.Controls.Add(label22);
            groupBox1.Controls.Add(label23);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(46, 430);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(596, 75);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "Breakfast";
            // 
            // lblBCalorie
            // 
            lblBCalorie.AutoSize = true;
            lblBCalorie.Location = new Point(427, 46);
            lblBCalorie.Name = "lblBCalorie";
            lblBCalorie.Size = new Size(31, 20);
            lblBCalorie.TabIndex = 37;
            lblBCalorie.Text = "0.0";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(418, 23);
            label14.Name = "label14";
            label14.Size = new Size(57, 20);
            label14.TabIndex = 36;
            label14.Text = "Calorie";
            // 
            // lblBProtein
            // 
            lblBProtein.AutoSize = true;
            lblBProtein.Location = new Point(217, 46);
            lblBProtein.Name = "lblBProtein";
            lblBProtein.Size = new Size(18, 20);
            lblBProtein.TabIndex = 34;
            lblBProtein.Text = "0";
            // 
            // lblBFat
            // 
            lblBFat.AutoSize = true;
            lblBFat.Location = new Point(305, 46);
            lblBFat.Name = "lblBFat";
            lblBFat.Size = new Size(18, 20);
            lblBFat.TabIndex = 32;
            lblBFat.Text = "0";
            // 
            // lblBCarbs
            // 
            lblBCarbs.AutoSize = true;
            lblBCarbs.Location = new Point(129, 46);
            lblBCarbs.Name = "lblBCarbs";
            lblBCarbs.Size = new Size(18, 20);
            lblBCarbs.TabIndex = 30;
            lblBCarbs.Text = "0";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(126, 23);
            label21.Name = "label21";
            label21.Size = new Size(48, 20);
            label21.TabIndex = 27;
            label21.Text = "Carbs";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(305, 23);
            label22.Name = "label22";
            label22.Size = new Size(31, 20);
            label22.TabIndex = 29;
            label22.Text = "Fat";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(205, 23);
            label23.Name = "label23";
            label23.Size = new Size(60, 20);
            label23.TabIndex = 28;
            label23.Text = "Protein";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(lblSCalorie);
            groupBox2.Controls.Add(label26);
            groupBox2.Controls.Add(lblSProtein);
            groupBox2.Controls.Add(lblSFat);
            groupBox2.Controls.Add(lblSCarbs);
            groupBox2.Controls.Add(label33);
            groupBox2.Controls.Add(label34);
            groupBox2.Controls.Add(label35);
            groupBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(46, 592);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(596, 75);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Snack";
            // 
            // lblSCalorie
            // 
            lblSCalorie.AutoSize = true;
            lblSCalorie.Location = new Point(427, 46);
            lblSCalorie.Name = "lblSCalorie";
            lblSCalorie.Size = new Size(29, 20);
            lblSCalorie.TabIndex = 24;
            lblSCalorie.Text = "0.0";
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(418, 23);
            label26.Name = "label26";
            label26.Size = new Size(57, 20);
            label26.TabIndex = 23;
            label26.Text = "Calorie";
            // 
            // lblSProtein
            // 
            lblSProtein.AutoSize = true;
            lblSProtein.Location = new Point(217, 46);
            lblSProtein.Name = "lblSProtein";
            lblSProtein.Size = new Size(17, 20);
            lblSProtein.TabIndex = 21;
            lblSProtein.Text = "0";
            // 
            // lblSFat
            // 
            lblSFat.AutoSize = true;
            lblSFat.Location = new Point(305, 46);
            lblSFat.Name = "lblSFat";
            lblSFat.Size = new Size(17, 20);
            lblSFat.TabIndex = 19;
            lblSFat.Text = "0";
            // 
            // lblSCarbs
            // 
            lblSCarbs.AutoSize = true;
            lblSCarbs.Location = new Point(129, 46);
            lblSCarbs.Name = "lblSCarbs";
            lblSCarbs.Size = new Size(17, 20);
            lblSCarbs.TabIndex = 17;
            lblSCarbs.Text = "0";
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(126, 23);
            label33.Name = "label33";
            label33.Size = new Size(47, 20);
            label33.TabIndex = 14;
            label33.Text = "Carbs";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(305, 23);
            label34.Name = "label34";
            label34.Size = new Size(29, 20);
            label34.TabIndex = 16;
            label34.Text = "Fat";
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(205, 23);
            label35.Name = "label35";
            label35.Size = new Size(59, 20);
            label35.TabIndex = 15;
            label35.Text = "Protein";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = Color.Transparent;
            groupBox3.Controls.Add(lblLCalorie);
            groupBox3.Controls.Add(label38);
            groupBox3.Controls.Add(lblLProtein);
            groupBox3.Controls.Add(lblLFat);
            groupBox3.Controls.Add(lblLCarbs);
            groupBox3.Controls.Add(label45);
            groupBox3.Controls.Add(label46);
            groupBox3.Controls.Add(label47);
            groupBox3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox3.Location = new Point(46, 511);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(596, 75);
            groupBox3.TabIndex = 13;
            groupBox3.TabStop = false;
            groupBox3.Text = "Lunch";
            // 
            // lblLCalorie
            // 
            lblLCalorie.AutoSize = true;
            lblLCalorie.Location = new Point(427, 46);
            lblLCalorie.Name = "lblLCalorie";
            lblLCalorie.Size = new Size(31, 20);
            lblLCalorie.TabIndex = 24;
            lblLCalorie.Text = "0.0";
            // 
            // label38
            // 
            label38.AutoSize = true;
            label38.Location = new Point(418, 23);
            label38.Name = "label38";
            label38.Size = new Size(57, 20);
            label38.TabIndex = 23;
            label38.Text = "Calorie";
            // 
            // lblLProtein
            // 
            lblLProtein.AutoSize = true;
            lblLProtein.Location = new Point(217, 46);
            lblLProtein.Name = "lblLProtein";
            lblLProtein.Size = new Size(18, 20);
            lblLProtein.TabIndex = 21;
            lblLProtein.Text = "0";
            // 
            // lblLFat
            // 
            lblLFat.AutoSize = true;
            lblLFat.Location = new Point(305, 46);
            lblLFat.Name = "lblLFat";
            lblLFat.Size = new Size(18, 20);
            lblLFat.TabIndex = 19;
            lblLFat.Text = "0";
            // 
            // lblLCarbs
            // 
            lblLCarbs.AutoSize = true;
            lblLCarbs.Location = new Point(129, 46);
            lblLCarbs.Name = "lblLCarbs";
            lblLCarbs.Size = new Size(18, 20);
            lblLCarbs.TabIndex = 17;
            lblLCarbs.Text = "0";
            // 
            // label45
            // 
            label45.AutoSize = true;
            label45.Location = new Point(126, 23);
            label45.Name = "label45";
            label45.Size = new Size(48, 20);
            label45.TabIndex = 14;
            label45.Text = "Carbs";
            // 
            // label46
            // 
            label46.AutoSize = true;
            label46.Location = new Point(305, 23);
            label46.Name = "label46";
            label46.Size = new Size(31, 20);
            label46.TabIndex = 16;
            label46.Text = "Fat";
            // 
            // label47
            // 
            label47.AutoSize = true;
            label47.Location = new Point(205, 23);
            label47.Name = "label47";
            label47.Size = new Size(60, 20);
            label47.TabIndex = 15;
            label47.Text = "Protein";
            // 
            // groupBox5
            // 
            groupBox5.BackColor = Color.Transparent;
            groupBox5.Controls.Add(lblDCalorie);
            groupBox5.Controls.Add(label62);
            groupBox5.Controls.Add(lblDProtein);
            groupBox5.Controls.Add(lblDFat);
            groupBox5.Controls.Add(lblDCarbs);
            groupBox5.Controls.Add(label69);
            groupBox5.Controls.Add(label70);
            groupBox5.Controls.Add(label71);
            groupBox5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox5.Location = new Point(46, 673);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(596, 75);
            groupBox5.TabIndex = 15;
            groupBox5.TabStop = false;
            groupBox5.Text = "Dinner";
            // 
            // lblDCalorie
            // 
            lblDCalorie.AutoSize = true;
            lblDCalorie.Location = new Point(427, 46);
            lblDCalorie.Name = "lblDCalorie";
            lblDCalorie.Size = new Size(31, 20);
            lblDCalorie.TabIndex = 24;
            lblDCalorie.Text = "0.0";
            // 
            // label62
            // 
            label62.AutoSize = true;
            label62.Location = new Point(418, 23);
            label62.Name = "label62";
            label62.Size = new Size(57, 20);
            label62.TabIndex = 23;
            label62.Text = "Calorie";
            // 
            // lblDProtein
            // 
            lblDProtein.AutoSize = true;
            lblDProtein.Location = new Point(217, 46);
            lblDProtein.Name = "lblDProtein";
            lblDProtein.Size = new Size(18, 20);
            lblDProtein.TabIndex = 21;
            lblDProtein.Text = "0";
            // 
            // lblDFat
            // 
            lblDFat.AutoSize = true;
            lblDFat.Location = new Point(305, 46);
            lblDFat.Name = "lblDFat";
            lblDFat.Size = new Size(18, 20);
            lblDFat.TabIndex = 19;
            lblDFat.Text = "0";
            // 
            // lblDCarbs
            // 
            lblDCarbs.AutoSize = true;
            lblDCarbs.Location = new Point(129, 46);
            lblDCarbs.Name = "lblDCarbs";
            lblDCarbs.Size = new Size(18, 20);
            lblDCarbs.TabIndex = 17;
            lblDCarbs.Text = "0";
            // 
            // label69
            // 
            label69.AutoSize = true;
            label69.Location = new Point(126, 23);
            label69.Name = "label69";
            label69.Size = new Size(48, 20);
            label69.TabIndex = 14;
            label69.Text = "Carbs";
            // 
            // label70
            // 
            label70.AutoSize = true;
            label70.Location = new Point(305, 23);
            label70.Name = "label70";
            label70.Size = new Size(31, 20);
            label70.TabIndex = 16;
            label70.Text = "Fat";
            // 
            // label71
            // 
            label71.AutoSize = true;
            label71.Location = new Point(205, 23);
            label71.Name = "label71";
            label71.Size = new Size(60, 20);
            label71.TabIndex = 15;
            label71.Text = "Protein";
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
            ıconButton1.TabIndex = 16;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            // 
            // EndOfDayReport
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.meals;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(654, 915);
            Controls.Add(ıconButton1);
            Controls.Add(groupBox5);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(date);
            Name = "EndOfDayReport";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "End Of Day Report";
            Load += Meals_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DateTimePicker date;
        private Label label1;
        private Label lbltoplam;
        private Label label2;
        private Label label4;
        private Label label5;
        private Panel panel1;
        private Label lblProtein;
        private Label lblTotalFat;
        private Label lblCarbs;
        private Panel panel2;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label24;
        private Label lblSCalorie;
        private Label label26;
        private Label label27;
        private Label lblSProtein;
        private Label label29;
        private Label lblSFat;
        private Label label31;
        private Label lblSCarbs;
        private Label label33;
        private Label label34;
        private Label label35;
        private GroupBox groupBox3;
        private Label label36;
        private Label lblLCalorie;
        private Label label38;
        private Label label39;
        private Label lblLProtein;
        private Label label41;
        private Label lblLFat;
        private Label label43;
        private Label lblLCarbs;
        private Label label45;
        private Label label46;
        private Label label47;
        private GroupBox groupBox5;
        private Label label60;
        private Label lblDCalorie;
        private Label label62;
        private Label label63;
        private Label lblDProtein;
        private Label label65;
        private Label lblDFat;
        private Label label67;
        private Label lblDCarbs;
        private Label label69;
        private Label label70;
        private Label label71;
        private FontAwesome.Sharp.IconButton ıconButton1;
        private Label label12;
        private Label lblBCalorie;
        private Label label14;
        private Label label15;
        private Label lblBProtein;
        private Label label17;
        private Label lblBFat;
        private Label label19;
        private Label lblBCarbs;
        private Label label21;
        private Label label22;
        private Label label23;
    }
}