using DietBuddyApp.DAL.Entities.Models;
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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
            if (UserManager.CurrentUser != null)
            {
                // Kullanıcı bilgilerini kullanarak sayfayı güncelle
                lblUser.Text = $"{UserManager.CurrentUser.FirstName} {UserManager.CurrentUser.LastName}";
                lblHeight.Text = $"{UserManager.CurrentUser.Height} cm";
                lblWeight.Text = $"{UserManager.CurrentUser.Weight} kg";

                double bMi = 10000 * UserManager.CurrentUser.Weight / (UserManager.CurrentUser.Height * UserManager.CurrentUser.Height);
                lblBMI.Text = $"{bMi.ToString("0.0")}";
            }
            else
            {
                // Kullanıcı bilgisi bulunamazsa, giriş ekranına yönlendir
                MessageBox.Show("User info is not found. Please enter again.");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }

        private void foodToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HowManyCalories howManyCalories = new HowManyCalories();
            howManyCalories.Show();
            this.Close();
        }
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.Close();
        }
        private void whatDidYouEatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            WhatDidYouEat whatDidYouEat = new WhatDidYouEat();
            whatDidYouEat.Show();
            this.Close();
        }
        private void ayarlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.Show();
            this.Close();
        }

        private void endOfDayReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EndOfDayReport endOfDayReport = new EndOfDayReport();
            endOfDayReport.Show();
            this.Close();
        }

        private void benchmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BenchmarkReport benchmarkReport = new BenchmarkReport();
            benchmarkReport.Show();
            this.Close();
        }

        private void foodTypeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodTypeReport foodTypeReport = new FoodTypeReport();
            foodTypeReport.Show();
            this.Close();
        }

    }
}
