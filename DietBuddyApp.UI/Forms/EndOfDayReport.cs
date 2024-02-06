using DietBuddyApp.BLL.Concrete;
using DietBuddyApp.DAL.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DietBuddyApp.UI.Forms
{
    public partial class EndOfDayReport : Form
    {
        public EndOfDayReport()
        {
            InitializeComponent();
            DateTime today = DateTime.Today;
            date.Value = today;
        }

        private void Meals_Load(object sender, EventArgs e)
        {

        }

        private void ıconButton1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }



        private void date_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = date.Value.Date;


            FoodCatDateRepository foodCatDateRepository = new FoodCatDateRepository();
            List<FoodCatDate> entriesForDate = foodCatDateRepository.GetAll()
                .Where(entry => DateTime.Parse(entry.Date) == selectedDate && entry.UserId == UserManager.CurrentUser.ID)
                .ToList();

            //Tarih seçince Toplam Calori hesaplasın ve labela yazsın
            double totalCalories = entriesForDate.Sum(entry => Convert.ToDouble(entry.TotalCalories));
            lbltoplam.Text = $"{totalCalories} kcal";

            //Tarih seçince Toplam Carbs hesaplasın ve labela yazsın
            double totalCarbs = entriesForDate.Sum(entry => Convert.ToDouble(entry.TotalCarbs));
            lblCarbs.Text = $"{totalCarbs.ToString("0")} gr";

            //Tarih seçince Toplam Protein hesaplasın ve labela yazsın
            double totalProtein = entriesForDate.Sum(entry => Convert.ToDouble(entry.TotalProtein));
            lblProtein.Text = $"{totalProtein.ToString("0")} gr";

            //Tarih seçince Toplam Fat hesaplasın ve labela yazsın
            double totalFat = entriesForDate.Sum(entry => Convert.ToDouble(entry.TotalFat));
            lblTotalFat.Text = $"{totalFat.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Calori hesaplasın ve labela yazsın
            double breakfastCalories = entriesForDate.Where(entry => entry.Meal == "Breakfast").Sum(entry => Convert.ToDouble(entry.TotalCalories));
            lblBCalorie.Text = $"{breakfastCalories.ToString("0.#")} kcal";

            //Tarih seçince Öğüne göre Toplam Carbs hesaplasın ve labela yazsın
            double breakfastCarbs = entriesForDate.Where(entry => entry.Meal == "Breakfast").Sum(entry => Convert.ToDouble(entry.TotalCarbs));
            lblBCarbs.Text = $"{breakfastCarbs.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Protein hesaplasın ve labela yazsın
            double breakfastProtein = entriesForDate.Where(entry => entry.Meal == "Breakfast").Sum(entry => Convert.ToDouble(entry.TotalProtein));
            lblBProtein.Text = $"{breakfastProtein.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Fat hesaplasın ve labela yazsın
            double breakfastFat = entriesForDate.Where(entry => entry.Meal == "Breakfast").Sum(entry => Convert.ToDouble(entry.TotalFat));
            lblBFat.Text = $"{breakfastFat.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Calori hesaplasın ve labela yazsın
            double lunchCalories = entriesForDate.Where(entry => entry.Meal == "Lunch").Sum(entry => Convert.ToDouble(entry.TotalCalories));
            lblLCalorie.Text = $"{lunchCalories.ToString("0.#")} kcal";

            //Tarih seçince Öğüne göre Toplam Carbs hesaplasın ve labela yazsın
            double lunchCarbs = entriesForDate.Where(entry => entry.Meal == "Lunch").Sum(entry => Convert.ToDouble(entry.TotalCarbs));
            lblLCarbs.Text = $"{lunchCarbs.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Protein hesaplasın ve labela yazsın
            double lunchProtein = entriesForDate.Where(entry => entry.Meal == "Lunch").Sum(entry => Convert.ToDouble(entry.TotalProtein));
            lblLProtein.Text = $"{lunchProtein.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Fat hesaplasın ve labela yazsın
            double lunchFat = entriesForDate.Where(entry => entry.Meal == "Lunch").Sum(entry => Convert.ToDouble(entry.TotalFat));
            lblLFat.Text = $"{lunchFat.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Calori hesaplasın ve labela yazsın
            double snackCalories = entriesForDate.Where(entry => entry.Meal == "Snack").Sum(entry => Convert.ToDouble(entry.TotalCalories));
            lblSCalorie.Text = $"{snackCalories.ToString("0.#")} kcal";

            //Tarih seçince Öğüne göre Toplam Carbs hesaplasın ve labela yazsın
            double snackCarbs = entriesForDate.Where(entry => entry.Meal == "Snack").Sum(entry => Convert.ToDouble(entry.TotalCarbs));
            lblSCarbs.Text = $"{snackCarbs.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Protein hesaplasın ve labela yazsın
            double snackProtein = entriesForDate.Where(entry => entry.Meal == "Snack").Sum(entry => Convert.ToDouble(entry.TotalProtein));
            lblSProtein.Text = $"{snackProtein.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Fat hesaplasın ve labela yazsın
            double snackFat = entriesForDate.Where(entry => entry.Meal == "Snack").Sum(entry => Convert.ToDouble(entry.TotalFat));
            lblSFat.Text = $"{snackFat.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Calori hesaplasın ve labela yazsın
            double dinnerCalories = entriesForDate.Where(entry => entry.Meal == "Dinner").Sum(entry => Convert.ToDouble(entry.TotalCalories));
            lblDCalorie.Text = $"{dinnerCalories.ToString("0.#")} kcal";

            //Tarih seçince Öğüne göre Toplam Carbs hesaplasın ve labela yazsın
            double dinnerCarbs = entriesForDate.Where(entry => entry.Meal == "Dinner").Sum(entry => Convert.ToDouble(entry.TotalCarbs));
            lblDCarbs.Text = $"{dinnerCarbs.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Protein hesaplasın ve labela yazsın
            double dinnerProtein = entriesForDate.Where(entry => entry.Meal == "Dinner").Sum(entry => Convert.ToDouble(entry.TotalProtein));
            lblDProtein.Text = $"{dinnerProtein.ToString("0")} gr";

            //Tarih seçince Öğüne göre Toplam Fat hesaplasın ve labela yazsın
            double dinnerFat = entriesForDate.Where(entry => entry.Meal == "Dinner").Sum(entry => Convert.ToDouble(entry.TotalFat));
            lblDFat.Text = $"{dinnerFat.ToString("0")} gr";


        }

    }
}
