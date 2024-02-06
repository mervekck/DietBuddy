using DietBuddyApp.BLL.Concrete;
using DietBuddyApp.DAL.Entities.Models;
using FontAwesome.Sharp;
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
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string email = txtEMail.Text;
            string newPassword = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            UserRepository userRepository = new UserRepository();


            try
            {
                //IsEmailExist bu UserRepository içerisinde yazıyor
                //Eposta var mı kontrolü yoksa güncelleyemezsin
                if (!userRepository.IsEmailExist(email))
                {
                    MessageBox.Show("Girilen e-posta adresi kayıtlı değil. Lütfen kayıtlı bir e-posta adresi giriniz.");
                    return;
                }
                //IsNullOrWhiteSpace: string ifadelerinin boş veya yalnızca boşluklardan oluşup oluşmadığını kontrol etmek için kullanılır. 
                if (string.IsNullOrWhiteSpace(newPassword) || string.IsNullOrWhiteSpace(confirmPassword))
                {
                    MessageBox.Show("Yeni şifre ve şifre tekrarı alanları boş bırakılamaz.");
                    return;
                }
                //iki şifre de aynı mı
                if (newPassword != confirmPassword)
                {
                    MessageBox.Show("Yeni şifre ve şifre tekrarı uyuşmuyor. Lütfen aynı şifreyi iki kez giriniz.");
                    return;
                }
                ////////////////////////////////////////////////////////////////////
                //Kullanıcı şifresi güncelle
                User user = userRepository.GetUserByEmail(email);

                if (user != null)
                {
                    user.Password = newPassword;
                    userRepository.Update(user);//update repositoryden geliyor
                    MessageBox.Show("Şifre güncelleme işlemi başarılı.");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Bir hata oluştu. Lütfen tekrar deneyiniz.");
                }
                ////////////////////////////////////////////////////////////////////
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Şifre güncelleme sırasında bir hata oluştu: {ex.Message}");
            }

        }

        private void ıcnbtnPasswordShow_Click(object sender, EventArgs e)
        {
            bool isPasswordVisible = false;
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '*' : '\0';
            

            ıcnbtnPasswordShow.IconChar = isPasswordVisible ? IconChar.EyeSlash : IconChar.Eye;
        }

        private void ıcnbtnRePasswordShow_Click(object sender, EventArgs e)
        {
            bool isPasswordVisible = false;
            isPasswordVisible = !isPasswordVisible;
            txtConfirmPassword.PasswordChar = isPasswordVisible ? '*' : '\0';
            

            ıcnbtnRePasswordShow.IconChar = isPasswordVisible ? IconChar.EyeSlash : IconChar.Eye;
        }

        private void ıconButton2_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("The password must contain at least one uppercase letter, one lowercase letter, one number, one special character and at least 8 characters.", "Password Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
