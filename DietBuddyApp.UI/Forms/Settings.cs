using DietBuddyApp.DAL.Context;
using DietBuddyApp.DAL.Entities.Enums;
using DietBuddyApp.DAL.Entities.Models;
using DietBuddyApp.DAL.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DietBuddyApp.BLL.Concrete;
using FontAwesome.Sharp;

namespace DietBuddyApp.UI.Forms
{
    public partial class Settings : Form
    {
        DietBuddyContext db = new DietBuddyContext();
        UserRepository userRepository = new UserRepository();
        public Settings()
        {
            InitializeComponent();
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = $"{UserManager.CurrentUser.FirstName}";
            txtLastName.Text = $"{UserManager.CurrentUser.LastName}";
            txtHeight.Text = $"{UserManager.CurrentUser.Height}";
            txtWeight.Text = $"{UserManager.CurrentUser.Weight}";
            txtEmail.Text = $"{UserManager.CurrentUser.EMail}";
            dateTimePicker1.Text = $"{UserManager.CurrentUser.BirthDate}";
        }
        private void ıconButton2_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
        private void icbLogout_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Hide();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var guncellenecek = db.Users.First(x => x.EMail == UserManager.CurrentUser.EMail);
            guncellenecek.FirstName = txtFirstName.Text;
            guncellenecek.LastName = txtLastName.Text;
            guncellenecek.Height = Convert.ToDouble(txtHeight.Text);
            guncellenecek.Weight = Convert.ToDouble(txtWeight.Text);
            guncellenecek.BirthDate = Convert.ToDateTime(dateTimePicker1.Text);

            UserManager.CurrentUser.FirstName = txtFirstName.Text;
            UserManager.CurrentUser.LastName = txtLastName.Text;
            UserManager.CurrentUser.Height = Convert.ToDouble(txtHeight.Text);
            UserManager.CurrentUser.Weight = Convert.ToDouble(txtWeight.Text);
            UserManager.CurrentUser.BirthDate = Convert.ToDateTime(dateTimePicker1.Text);

            DialogResult result = MessageBox.Show("Do you want to update your profile?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                userRepository.Update(guncellenecek);
                MessageBox.Show("Profile updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var silinecek = db.Users.FirstOrDefault(x => x.EMail == UserManager.CurrentUser.EMail);

            DialogResult result = MessageBox.Show("Do you want to delete your profile?", "Conformation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (result == DialogResult.OK)
            {
                userRepository.Delete(silinecek);
                MessageBox.Show("Profile deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
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
        private void ıconButton1_MouseHover_1(object sender, EventArgs e)
        {
            MessageBox.Show("The password must contain at least one uppercase letter, one lowercase letter, one number, one special character and at least 8 characters.", "Password Rules", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
