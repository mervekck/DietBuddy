namespace DietBuddyApp.UI.Forms
{
    partial class Login
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
            label2 = new Label();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            label3 = new Label();
            btnSignin = new Button();
            lblSifre = new LinkLabel();
            btnCreateAnAccount = new Button();
            ıcnbtnPasswordShow = new FontAwesome.Sharp.IconButton();
            ıconButton1 = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 260);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 0;
            label1.Text = "E-mail";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(117, 313);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 30);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.Location = new Point(215, 260);
            txtEmail.Margin = new Padding(2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(238, 27);
            txtEmail.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.Gainsboro;
            txtPassword.Location = new Point(215, 313);
            txtPassword.Margin = new Padding(2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(238, 27);
            txtPassword.TabIndex = 3;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Lucida Handwriting", 40.2F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.DarkOliveGreen;
            label3.Location = new Point(64, 130);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(467, 114);
            label3.TabIndex = 4;
            label3.Text = "DietBuddy";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.DarkSeaGreen;
            btnSignin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSignin.Location = new Point(157, 415);
            btnSignin.Margin = new Padding(2);
            btnSignin.Name = "btnSignin";
            btnSignin.Size = new Size(103, 38);
            btnSignin.TabIndex = 5;
            btnSignin.Text = "Sign In";
            btnSignin.UseVisualStyleBackColor = false;
            btnSignin.Click += btnSignin_Click;
            // 
            // lblSifre
            // 
            lblSifre.AutoSize = true;
            lblSifre.BackColor = Color.FromArgb(224, 224, 224);
            lblSifre.BorderStyle = BorderStyle.FixedSingle;
            lblSifre.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            lblSifre.LinkColor = Color.Black;
            lblSifre.Location = new Point(325, 346);
            lblSifre.Margin = new Padding(2, 0, 2, 0);
            lblSifre.Name = "lblSifre";
            lblSifre.Size = new Size(128, 22);
            lblSifre.TabIndex = 6;
            lblSifre.TabStop = true;
            lblSifre.Text = "Update Password?";
            lblSifre.LinkClicked += lblSifre_LinkClicked;
            // 
            // btnCreateAnAccount
            // 
            btnCreateAnAccount.BackColor = SystemColors.InactiveCaption;
            btnCreateAnAccount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCreateAnAccount.Location = new Point(265, 415);
            btnCreateAnAccount.Margin = new Padding(2);
            btnCreateAnAccount.Name = "btnCreateAnAccount";
            btnCreateAnAccount.Size = new Size(188, 38);
            btnCreateAnAccount.TabIndex = 7;
            btnCreateAnAccount.Text = "Create An Account";
            btnCreateAnAccount.UseVisualStyleBackColor = false;
            btnCreateAnAccount.Click += btnCreateAnAccount_Click;
            // 
            // ıcnbtnPasswordShow
            // 
            ıcnbtnPasswordShow.BackColor = Color.Transparent;
            ıcnbtnPasswordShow.BackgroundImageLayout = ImageLayout.Stretch;
            ıcnbtnPasswordShow.FlatStyle = FlatStyle.Flat;
            ıcnbtnPasswordShow.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            ıcnbtnPasswordShow.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            ıcnbtnPasswordShow.IconColor = Color.Black;
            ıcnbtnPasswordShow.IconFont = FontAwesome.Sharp.IconFont.Solid;
            ıcnbtnPasswordShow.IconSize = 30;
            ıcnbtnPasswordShow.Location = new Point(458, 313);
            ıcnbtnPasswordShow.Name = "ıcnbtnPasswordShow";
            ıcnbtnPasswordShow.Size = new Size(33, 30);
            ıcnbtnPasswordShow.TabIndex = 91;
            ıcnbtnPasswordShow.UseVisualStyleBackColor = false;
            ıcnbtnPasswordShow.Click += ıcnbtnPasswordShow_Click;
            // 
            // ıconButton1
            // 
            ıconButton1.BackColor = Color.Transparent;
            ıconButton1.FlatStyle = FlatStyle.Flat;
            ıconButton1.IconChar = FontAwesome.Sharp.IconChar.Info;
            ıconButton1.IconColor = Color.Navy;
            ıconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ıconButton1.IconSize = 20;
            ıconButton1.Location = new Point(215, 346);
            ıconButton1.Name = "ıconButton1";
            ıconButton1.Size = new Size(15, 25);
            ıconButton1.TabIndex = 94;
            ıconButton1.UseVisualStyleBackColor = false;
            ıconButton1.MouseHover += ıconButton1_MouseHover;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaShell;
            BackgroundImage = Properties.Resources.pngtree_dietary_health_diet_image_182099;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(571, 730);
            Controls.Add(ıconButton1);
            Controls.Add(ıcnbtnPasswordShow);
            Controls.Add(btnCreateAnAccount);
            Controls.Add(lblSifre);
            Controls.Add(btnSignin);
            Controls.Add(label3);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "Login";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            TransparencyKey = Color.Transparent;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private Label label3;
        private Button btnSignin;
        private LinkLabel lblSifre;
        private Button btnCreateAnAccount;
        private FontAwesome.Sharp.IconButton ıcnbtnPasswordShow;
        private FontAwesome.Sharp.IconButton ıconButton1;
    }
}