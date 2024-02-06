using DietBuddyApp.BLL.Concrete;
using DietBuddyApp.DAL.Entities.Enums;
using DietBuddyApp.DAL.Entities.Models;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietBuddyApp.UI.Forms
{
    public partial class CreateAnAccount : Form
    {
        public CreateAnAccount()
        {
            InitializeComponent();
        }
        UserRepository userRepository = new UserRepository();

        private void btnContinue_Click(object sender, EventArgs e)
        {
            User newUser = new User();

            if (rbMale.Checked)
            {
                newUser.Gender = Gender.Male;
            }
            else if (rbFemale.Checked)
            {
                newUser.Gender = Gender.Female;
            }
            else
            {
                MessageBox.Show("Please choose gender!");
                return;
            }
            newUser.FirstName = txtFirstName.Text;
            newUser.LastName = txtLastName.Text;
            newUser.BirthDate = dateTimePicker1.Value;
            newUser.Height = Convert.ToDouble(txtHeight.Text);
            newUser.Weight = Convert.ToDouble(txtWeight.Text);
            newUser.EMail = txtEMail.Text;

            string password = txtPassword.Text;
            string reenteredPassword = txtReenterPassword.Text;

            if (userRepository.IsEmailExist(newUser.EMail))
            {
                MessageBox.Show("This e-mail is already taken. Please try another e-mail.");
                return;
            }
            if (!IsPasswordValid(password))
            {
                MessageBox.Show("Password is nor walid. Follow the rules.");
                return;
            }

            if (password != reenteredPassword)
            {
                MessageBox.Show("Password is not match. Please enter the right password.");
                return;
            }
            newUser.Password = password;
            try
            {
                userRepository.Add(newUser);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.Close();
            }
        }
        //Yaşı 18den büyük seçene kadar datetimepickerdan çıkmana izin vermiyor
        private void dateTimePicker1_Leave(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            DateTime now = DateTime.Now;

            DateTime eighteenYearsAgo = now.AddYears(-18);
            if (selectedDate >= eighteenYearsAgo)
            {
                MessageBox.Show("An account cannot be created. Minimum age is 18!");
                dateTimePicker1.Focus();
            }
        }
        //Boyu 100 ve 250 arasında yazana kadar textten çıkmana izin vermiyor
        private void txtHeight_Leave(object sender, EventArgs e)
        {
            string heightText = txtHeight.Text;
            if (double.TryParse(heightText, out double height))
            {
                if (height >= 100 && height <= 250)
                {
                    return;
                }
            }
            MessageBox.Show("Please enter a value between 100 and 250 cm.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtHeight.Focus();
        }
        //Kilosunu 30 ve 300 arasında yazana kadar textten çıkmana izin vermiyor
        private void txtWeight_Leave(object sender, EventArgs e)
        {
            string weightText = txtWeight.Text;
            if (double.TryParse(weightText, out double weight))
            {
                if (weight >= 30 && weight <= 300)
                {
                    return;
                }
            }
            MessageBox.Show("Please Enter between 30 and 300 kg!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            txtHeight.Focus();
        }
        //mail içerisinde @ olmalı bu yüzden text içinde @ yazmadan textten çıkmana izin vermiyor
        private void txtEMail_Leave_1(object sender, EventArgs e)
        {
            string email = txtEMail.Text;
            if (!email.Contains("@"))
            {
                MessageBox.Show("Please enter a valid e-mail address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEMail.Focus();
                return;
            }
        }
        //şifrelerin yanındaki göz butonu ve şifre görünsün isterse göz açık,görünmesin isterse göz kapalı olark ayarlandı
        bool isPasswordVisible = true;
        private void ıcnbtnPasswordShow_Click_1(object sender, EventArgs e)
        {
            isPasswordVisible = !isPasswordVisible;
            txtPassword.PasswordChar = isPasswordVisible ? '\0' : '*';
            ıcnbtnPasswordShow.IconChar = isPasswordVisible ? IconChar.EyeSlash : IconChar.Eye;
        }
        bool isPasswordVisible1 = true;
        private void ıcnbtnRePasswordShow_Click(object sender, EventArgs e)
        {
            isPasswordVisible1 = !isPasswordVisible1;
            txtReenterPassword.PasswordChar = isPasswordVisible1 ? '\0' : '*';
            ıcnbtnRePasswordShow.IconChar = isPasswordVisible1 ? IconChar.EyeSlash : IconChar.Eye;
        }
        //şifre kuralları
        static bool IsPasswordValid(string password)
        {
            string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,}$";
            return Regex.IsMatch(password, passwordPattern);
        }
        //Şifre kurallarını gösteren buton 
        private void ıconButton1_MouseHover(object sender, EventArgs e)
        {
            MessageBox.Show("The password must contain at least one uppercase letter, one lowercase letter, one number, one special character, and at least 8 characters.", "Password Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
