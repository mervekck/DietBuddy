using DietBuddyApp.DAL.Context;
using DietBuddyApp.DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DietBuddyApp.UI.Forms
{
    public partial class FoodTypeReport : Form
    {
        public FoodTypeReport()
        {
            InitializeComponent();
        }
        private DietBuddyContext dBc = new DietBuddyContext();
        private List<FoodCatDate> FoodCatDateGetAll()
        {
            return dBc.FoodCatDates.ToList();
        }
        private void btnBreakfast_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dBc.FoodCatDates
                .Where(x => x.UserId == UserManager.CurrentUser.ID && x.Meal == "Breakfast")
                .GroupBy(x => x.Food)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Measure))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dBc.FoodCatDates
                .Where(x => x.UserId == UserManager.CurrentUser.ID && x.Meal == "Lunch")
                .GroupBy(x => x.Food)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Measure))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;
        }

        private void btnSnack_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dBc.FoodCatDates
                .Where(x => x.UserId == UserManager.CurrentUser.ID && x.Meal == "Snack")
                .GroupBy(x => x.Food)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Measure))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;
        }

        private void btnDinner_Click(object sender, EventArgs e)
        {
            var mostConsumedFoods = dBc.FoodCatDates
                .Where(x => x.UserId == UserManager.CurrentUser.ID && x.Meal == "Dinner")
                .GroupBy(x => x.Food)
                .Select(group => new
                {
                    FoodName = group.Key,
                    TotalConsumed = group.Sum(x => Convert.ToDouble(x.Measure))
                })
                .OrderByDescending(x => x.TotalConsumed)
                .ToList();

            dataGridView1.DataSource = mostConsumedFoods;
        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            HomePage homePages = new HomePage();
            homePages.Show();
            this.Close();
        }
    }
}
