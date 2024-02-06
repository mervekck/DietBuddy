using DietBuddyApp.BLL.Concrete;
using DietBuddyApp.BLL.Contract;
using DietBuddyApp.DAL.Context;
using DietBuddyApp.DAL.Entities.Models;
using Microsoft.EntityFrameworkCore;
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

    public partial class BenchmarkReport : Form
    {
        private DietBuddyContext dBc = new DietBuddyContext();
        public BenchmarkReport()
        {
            InitializeComponent();

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }

        private List<FoodCatDate> FoodCatDateGetAll()
        {
            return dBc.FoodCatDates.ToList();
        }

        private List<DAL.Entities.Models.User> UserGetAll()
        {
            return dBc.Users.ToList();
        }
        private void FoodCategoryReport(string period)
        {
            DateTime startDate;
            DateTime endDate;

            if (period == "Weekly")
            {
                startDate = DateTime.Now.Date;
                endDate = startDate.AddDays(-7);
            }
            else
            {
                startDate = DateTime.Now.Date;
                endDate = startDate.AddMonths(-1);
            }

            List<FoodCatDate> foodCatDate = FoodCatDateGetAll().Where(x => DateTime.Parse(x.Date) <= startDate && DateTime.Parse(x.Date) >= endDate).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("UserName");
            dt.Columns.Add("FoodCategory");
            dt.Columns.Add("TotalCalories");
            dt.Columns.Add("TotalFat");
            dt.Columns.Add("TotalProtein");
            dt.Columns.Add("TotalCarbs");

            var groupData = foodCatDate
                .GroupBy(x => new { x.UserId, x.FoodCategory })
                .Select(g => new
                {
                    UserID = g.Key.UserId,
                    FoodCategory = g.Key.FoodCategory,
                    TotalCalories = g.Sum(x => Convert.ToDouble(x.TotalCalories)),
                    TotalFat = g.Sum(x => Convert.ToDouble(x.TotalFat)),
                    TotalProtein = g.Sum(x => Convert.ToDouble(x.TotalProtein)),
                    TotalCarbs = g.Sum(x => Convert.ToDouble(x.TotalCarbs))
                })
                .ToList();

            foreach (var reportRow in groupData)
            {
                DataRow row = dt.NewRow();

                DAL.Entities.Models.User user = UserGetAll().FirstOrDefault(u => u.ID == reportRow.UserID);
                if (user != null)
                {
                    row["UserName"] = $"{user.FirstName} {user.LastName}";
                }

                row["FoodCategory"] = reportRow.FoodCategory;
                row["TotalCalories"] = reportRow.TotalCalories.ToString("0.#");
                row["TotalFat"] = reportRow.TotalFat.ToString("0");
                row["TotalProtein"] = reportRow.TotalProtein.ToString("0");
                row["TotalCarbs"] = reportRow.TotalCarbs.ToString("0");

                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }
        private void MealReport(string period)
        {

            DateTime startDate;
            DateTime endDate;

            if (period == "Weekly")
            {
                startDate = DateTime.Now.Date;
                endDate = startDate.AddDays(-7);
            }
            else
            {
                startDate = DateTime.Now.Date;
                endDate = startDate.AddMonths(-1);
            }

            List<FoodCatDate> foodCatDate = FoodCatDateGetAll().Where(x => DateTime.Parse(x.Date) <= startDate && DateTime.Parse(x.Date) >= endDate).ToList();

            DataTable dt = new DataTable();
            dt.Columns.Add("UserName");
            dt.Columns.Add("Meal");
            dt.Columns.Add("TotalCalories");
            dt.Columns.Add("TotalFat");
            dt.Columns.Add("TotalProtein");
            dt.Columns.Add("TotalCarbs");

            var groupData = foodCatDate
                .GroupBy(x => new { x.UserId, x.Meal })
                .Select(g => new
                {
                    UserID = g.Key.UserId,
                    Meal = g.Key.Meal,
                    TotalCalories = g.Sum(x => Convert.ToDouble(x.TotalCalories)),
                    TotalFat = g.Sum(x => Convert.ToDouble(x.TotalFat)),
                    TotalProtein = g.Sum(x => Convert.ToDouble(x.TotalProtein)),
                    TotalCarbs = g.Sum(x => Convert.ToDouble(x.TotalCarbs))
                })
                .ToList();

            foreach (var reportRow in groupData)
            {
                DataRow row = dt.NewRow();

                DAL.Entities.Models.User user = UserGetAll().FirstOrDefault(u => u.ID == reportRow.UserID);
                if (user != null)
                {
                    row["UserName"] = $"{user.FirstName} {user.LastName}";
                }

                row["Meal"] = reportRow.Meal;
                row["TotalCalories"] = reportRow.TotalCalories.ToString("0,#");
                row["TotalFat"] = reportRow.TotalFat.ToString("0");
                row["TotalProtein"] = reportRow.TotalProtein.ToString("0");
                row["TotalCarbs"] = reportRow.TotalCarbs.ToString("0");

                dt.Rows.Add(row);
            }

            dataGridView1.DataSource = dt;
        }

        private void weeklyFoodCategories_Click(object sender, EventArgs e)
        {
            FoodCategoryReport("Weekly");
        }

        private void weeklyMeals_Click(object sender, EventArgs e)
        {
            MealReport("Weekly");
        }

        private void monthlyFoodCategories_Click(object sender, EventArgs e)
        {
            FoodCategoryReport("Monthly");
        }

        private void monthlyMeals_Click(object sender, EventArgs e)
        {
            MealReport("Monthly");
        }
    }
}
