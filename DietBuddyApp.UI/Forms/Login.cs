using DietBuddyApp.BLL.Concrete;
using DietBuddyApp.DAL.Context;
using DietBuddyApp.DAL.Entities.Models;
using FontAwesome.Sharp;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietBuddyApp.UI.Forms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();

        }
        private void lblSifre_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //ForgotPassword formu aç
            UpdatePassword forgotPassword = new UpdatePassword();
            forgotPassword.Show();
        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            string enteredEmail = txtEmail.Text;
            string enteredPassword = txtPassword.Text;

            UserRepository userRepository = new UserRepository();
            DAL.Entities.Models.User loggedInUser = userRepository.GetUserByEmail(enteredEmail);

            if (loggedInUser != null && loggedInUser.Password == enteredPassword)
            {
                UserManager.CurrentUser = loggedInUser;

                HomePage homePage = new HomePage();
                homePage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }
        private void btnCreateAnAccount_Click(object sender, EventArgs e)
        {
            //CreateAnAccount formu aç
            CreateAnAccount createAnAccount = new CreateAnAccount();
            createAnAccount.Show();
        }
        private DietBuddyContext db = new DietBuddyContext();
        private bool IsUserValid(string email, string password)
        {
            return db.Users.Any(u => u.EMail == email && u.Password == password);
        }
        // Örneğin, veritabanından kullanıcıyı çeken bir metot
        private DAL.Entities.Models.User GetUserFromDatabase(string email)
        {
            return db.Users.FirstOrDefault(u => u.EMail == email);
        }
        private bool isPasswordVisible = true;
        private void ıcnbtnPasswordShow_Click(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
            ıcnbtnPasswordShow.IconChar = isPasswordVisible ? IconChar.EyeSlash : IconChar.Eye;
        }
        private void ıconButton1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("The password must contain at least one uppercase letter, one lowercase letter, one number, one special character and at least 8 characters.", "Password Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
