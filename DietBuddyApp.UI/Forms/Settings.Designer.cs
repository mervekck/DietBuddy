namespace DietBuddyApp.UI.Forms
{
    partial class Settings
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
            txtHeight = new TextBox();
            txtLastName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            icbLogout = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            txtWeight = new TextBox();
            txtEmail = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label15 = new Label();
            label18 = new Label();
            label19 = new Label();
            dateTimePicker1 = new DateTimePicker();
            ıconButton2 = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            label17 = new Label();
            txtFirstName = new TextBox();
            btnSave = new Button();
            btnDelete = new Button();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtHeight
            // 
            txtHeight.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtHeight.Location = new Point(245, 340);
            txtHeight.Margin = new Padding(3, 4, 3, 4);
            txtHeight.Name = "txtHeight";
            txtHeight.Size = new Size(302, 32);
            txtHeight.TabIndex = 0;
            txtHeight.Leave += txtHeight_Leave;
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Window;
            txtLastName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtLastName.Location = new Point(243, 221);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(302, 32);
            txtLastName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(53, 231);
            label1.Name = "label1";
            label1.Size = new Size(94, 23);
            label1.TabIndex = 2;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(53, 464);
            label2.Name = "label2";
            label2.Size = new Size(66, 23);
            label2.TabIndex = 3;
            label2.Text = "E-Mail ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(53, 291);
            label3.Name = "label3";
            label3.Size = new Size(93, 23);
            label3.TabIndex = 4;
            label3.Text = "BirthDate ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(53, 349);
            label5.Name = "label5";
            label5.Size = new Size(70, 23);
            label5.TabIndex = 6;
            label5.Text = "Height ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(53, 407);
            label7.Name = "label7";
            label7.Size = new Size(69, 23);
            label7.TabIndex = 8;
            label7.Text = "Weight";
            // 
            // icbLogout
            // 
            icbLogout.BackgroundImage = Properties.Resources.indir2;
            icbLogout.BackgroundImageLayout = ImageLayout.Stretch;
            icbLogout.IconChar = FontAwesome.Sharp.IconChar.None;
            icbLogout.IconColor = Color.Black;
            icbLogout.IconFont = FontAwesome.Sharp.IconFont.Auto;
            icbLogout.Location = new Point(494, 704);
            icbLogout.Margin = new Padding(3, 4, 3, 4);
            icbLogout.Name = "icbLogout";
            icbLogout.Size = new Size(54, 53);
            icbLogout.TabIndex = 18;
            icbLogout.UseVisualStyleBackColor = true;
            icbLogout.Click += icbLogout_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(375, 719);
            label9.Name = "label9";
            label9.Size = new Size(79, 23);
            label9.TabIndex = 19;
            label9.Text = "LOGOUT";
            // 
            // txtWeight
            // 
            txtWeight.BackColor = SystemColors.Window;
            txtWeight.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtWeight.Location = new Point(245, 397);
            txtWeight.Margin = new Padding(3, 4, 3, 4);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(302, 32);
            txtWeight.TabIndex = 21;
            txtWeight.Leave += txtWeight_Leave;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtEmail.Location = new Point(245, 455);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(302, 32);
            txtEmail.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(223, 344);
            label10.Name = "label10";
            label10.Size = new Size(15, 23);
            label10.TabIndex = 26;
            label10.Text = ":";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(223, 289);
            label11.Name = "label11";
            label11.Size = new Size(15, 23);
            label11.TabIndex = 27;
            label11.Text = ":";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(223, 225);
            label12.Name = "label12";
            label12.Size = new Size(15, 23);
            label12.TabIndex = 28;
            label12.Text = ":";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.Transparent;
            label13.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(223, 401);
            label13.Name = "label13";
            label13.Size = new Size(15, 23);
            label13.TabIndex = 31;
            label13.Text = ":";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.Transparent;
            label15.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(223, 455);
            label15.Name = "label15";
            label15.Size = new Size(15, 23);
            label15.TabIndex = 29;
            label15.Text = ":";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.BackColor = Color.Transparent;
            label18.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label18.ForeColor = SystemColors.ControlText;
            label18.Location = new Point(223, 65);
            label18.Name = "label18";
            label18.Size = new Size(163, 50);
            label18.TabIndex = 34;
            label18.Text = "Settings";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.BackColor = Color.Transparent;
            label19.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label19.Location = new Point(457, 717);
            label19.Name = "label19";
            label19.Size = new Size(17, 25);
            label19.TabIndex = 38;
            label19.Text = ":";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Enabled = false;
            dateTimePicker1.Location = new Point(245, 287);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(302, 27);
            dateTimePicker1.TabIndex = 39;
            // 
            // ıconButton2
            // 
            ıconButton2.BackColor = Color.Transparent;
            ıconButton2.ForeColor = Color.Transparent;
            ıconButton2.IconChar = FontAwesome.Sharp.IconChar.AngleLeft;
            ıconButton2.IconColor = Color.Black;
            ıconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton2.Location = new Point(11, 12);
            ıconButton2.Name = "ıconButton2";
            ıconButton2.Size = new Size(37, 53);
            ıconButton2.TabIndex = 40;
            ıconButton2.UseVisualStyleBackColor = false;
            ıconButton2.Click += ıconButton2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(53, 173);
            label8.Name = "label8";
            label8.Size = new Size(97, 23);
            label8.TabIndex = 43;
            label8.Text = "First Name";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.BackColor = Color.Transparent;
            label17.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label17.Location = new Point(222, 173);
            label17.Name = "label17";
            label17.Size = new Size(15, 23);
            label17.TabIndex = 44;
            label17.Text = ":";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Window;
            txtFirstName.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            txtFirstName.Location = new Point(243, 169);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(302, 32);
            txtFirstName.TabIndex = 45;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Transparent;
            btnSave.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.Location = new Point(237, 538);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(154, 70);
            btnSave.TabIndex = 46;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(397, 538);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(150, 70);
            btnDelete.TabIndex = 47;
            btnDelete.Text = "Delete Account";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Info;
            ıconButton1.IconColor = Color.Navy;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 20;
            ıconButton1.Location = new Point(245, 494);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(15, 25);
            ıconButton1.TabIndex = 94;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.Click += ıconButton1_Click;
            ıconButton1.MouseHover += ıconButton1_MouseHover_1;
            // 
            // Settings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.settings;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(605, 773);
            Controls.Add(ıconButton1);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(txtFirstName);
            Controls.Add(label17);
            Controls.Add(label8);
            Controls.Add(ıconButton2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label13);
            Controls.Add(label15);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(txtEmail);
            Controls.Add(txtWeight);
            Controls.Add(label9);
            Controls.Add(icbLogout);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtLastName);
            Controls.Add(txtHeight);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Settings";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtHeight;
        private TextBox txtLastName;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label7;
        private FontAwesome.Sharp.IconButton icbLogout;
        private Label label9;
        private TextBox txtWeight;
        private TextBox txtEmail;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label15;
        private Label label18;
        private Label label19;
        private DateTimePicker dateTimePicker1;
        private FontAwesome.Sharp.IconButton ıconButton2;
        private Label label8;
        private Label label17;
        private TextBox txtFirstName;
        private Button btnSave;
        private Button btnDelete;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}