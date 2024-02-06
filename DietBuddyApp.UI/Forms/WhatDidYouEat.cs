using DietBuddyApp.DAL.Context;
using DietBuddyApp.DAL.Entities.Models;
using DietBuddyApp.DAL.Seed;
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
using DietBuddyApp.UI.Forms;
using DietBuddyApp.BLL.Concrete;
using System.Windows.Media;
using Microsoft.VisualBasic.ApplicationServices;
using DietBuddyApp.DAL.Entities.Enums;

namespace DietBuddyApp.UI.Forms
{

    public partial class WhatDidYouEat : Form
    {
        private DietBuddyContext dBc = new DietBuddyContext();
        private void DataGridView(DataGridView dataGridView1)//DataGridView ekranını nasıl göstereceği yazıyor
        {
            var foodCatDates = dBc.FoodCatDates
        .Where(x => x.UserId == UserManager.CurrentUser.ID && x.Date == date.Value.ToShortDateString())
        .ToList();

            dataGridView1.AutoGenerateColumns = false;

            // Define columns
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Date", "Date");
            dataGridView1.Columns.Add("Meal", "Meal");
            dataGridView1.Columns.Add("FoodCategory", "Food Category");
            dataGridView1.Columns.Add("Food", "Food");
            dataGridView1.Columns.Add("TotalCalories", "Calories");
            dataGridView1.Columns.Add("TotalCarbs", "Carbs");
            dataGridView1.Columns.Add("TotalProtein", "Protein");
            dataGridView1.Columns.Add("TotalFat", "Fat");

            // Bind data
            dataGridView1.DataSource = foodCatDates;

            // Set column data property bindings
            dataGridView1.Columns["Date"].DataPropertyName = "Date";
            dataGridView1.Columns["Meal"].DataPropertyName = "Meal";
            dataGridView1.Columns["FoodCategory"].DataPropertyName = "FoodCategory";
            dataGridView1.Columns["Food"].DataPropertyName = "Food";
            dataGridView1.Columns["TotalCalories"].DataPropertyName = "TotalCalories";
            dataGridView1.Columns["TotalCarbs"].DataPropertyName = "TotalCarbs";
            dataGridView1.Columns["TotalProtein"].DataPropertyName = "TotalProtein";
            dataGridView1.Columns["TotalFat"].DataPropertyName = "TotalFat";

        }
        private List<FoodFoodCategory> FoodFoodCategoryGetAll()
        {
            return dBc.FoodFoodCategorys.ToList();
        }
        private List<Food> FoodGetAll()
        {
            return dBc.Foods.ToList();
        }
        private List<FoodCategory> FoodCategoryGetAll()
        {
            return dBc.FoodCategorys.ToList();
        }
        public WhatDidYouEat()
        {
            InitializeComponent();
            DataGridView(dataGridView1);
            if (UserManager.CurrentUser != null)
            {
                // Kullanıcı bilgilerini kullanarak sayfayı güncelle
                lblUser.Text = $"{UserManager.CurrentUser.FirstName} {UserManager.CurrentUser.LastName}";
            }
            FoodRepository foodRepository = new FoodRepository();


            cbFoodCategories.DisplayMember = "Name";
            cbFoodCategories.DataSource = FoodCategoryGetAll();

            cbFood.DisplayMember = "Name";
            cbFood.DataSource = FoodGetAll();

            cbMeal.DataSource = Enum.GetNames(typeof(DietBuddyApp.DAL.Entities.Enums.Meals));
        }
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFood.SelectedItem != null)
            {
                string fileName = ((Food)cbFood.SelectedItem).Picture;
                pictureBox1.Image = Image.FromFile($"..\\..\\..{fileName}");
            }
        }
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            HomePage homePages = new HomePage();
            homePages.Show();
            this.Close();
        }
        private void cbFoodCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFoodCategories.SelectedItem != null)
            {
                FoodCategory selectedCategory = (FoodCategory)cbFoodCategories.SelectedItem;

                // FoodFoodCategories listesini alın
                List<FoodFoodCategory> foodFoodCategories = FoodFoodCategoryGetAll();

                // Seçilen kategoriye bağlı FoodFoodCategory listesini filtrele
                var foodsInCategory = foodFoodCategories
                    .Where(ff => ff.FoodCategoryID == selectedCategory.ID)
                    .Select(ff => ff.Food)
                    .ToList();

                // cmbFood ComboBox'ını güncelle
                cbFood.DisplayMember = "Name";
                cbFood.DataSource = foodsInCategory;
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            FoodCategory selectedFoodCategory = (FoodCategory)cbFoodCategories.SelectedItem;
            Food selectedFood = (Food)cbFood.SelectedItem;

            double totalMeasure = Convert.ToDouble(nudMeasure.Value);

            double totalCalories = selectedFood.Calory * totalMeasure;
            double totalFat = selectedFood.Fat * totalMeasure;
            double totalProtein = selectedFood.Protein * totalMeasure;
            double totalCarbs = selectedFood.Carbohydrate * totalMeasure;

            FoodCatDate foodCatDate = new FoodCatDate();
            foodCatDate.Date = date.Value.ToShortDateString();
            foodCatDate.Meal = cbMeal.SelectedItem?.ToString();
            foodCatDate.FoodCategory = selectedFoodCategory.Name;
            foodCatDate.Food = selectedFood.Name;
            foodCatDate.Measure = nudMeasure.Value.ToString();
            foodCatDate.TotalCalories = totalCalories.ToString();
            foodCatDate.TotalFat = totalFat.ToString();
            foodCatDate.TotalProtein = totalProtein.ToString();
            foodCatDate.TotalCarbs = totalCarbs.ToString();
            foodCatDate.UserId = UserManager.CurrentUser.ID;

            FoodCatDateRepository foodCatDateRepository = new FoodCatDateRepository();
            foodCatDateRepository.Add(foodCatDate);

            DataGridView(dataGridView1);
        }
        private List<FoodCatDate> FoodCatDateAll()
        {
            return dBc.FoodCatDates.ToList();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FoodCatDate selectedFoodCatDate = (FoodCatDate)dataGridView1.CurrentRow.DataBoundItem;

            FoodCategory selectedFoodCategory = (FoodCategory)cbFoodCategories.SelectedItem;
            Food selectedFood = (Food)cbFood.SelectedItem;

            double totalMeasure = Convert.ToDouble(nudMeasure.Value);

            selectedFoodCatDate.Meal = cbMeal.SelectedItem?.ToString();
            selectedFoodCatDate.FoodCategory = selectedFoodCategory.Name;
            selectedFoodCatDate.Food = selectedFood.Name;
            selectedFoodCatDate.Measure = nudMeasure.Value.ToString();
            selectedFoodCatDate.TotalCalories = (selectedFood.Calory * totalMeasure).ToString();
            selectedFoodCatDate.TotalFat = (selectedFood.Fat * totalMeasure).ToString();
            selectedFoodCatDate.TotalProtein = (selectedFood.Protein * totalMeasure).ToString();
            selectedFoodCatDate.TotalCarbs = (selectedFood.Carbohydrate * totalMeasure).ToString();
            selectedFoodCatDate.UserId = UserManager.CurrentUser.ID;

            FoodCatDateRepository foodCatDateRepository = new FoodCatDateRepository();
            foodCatDateRepository.Update(selectedFoodCatDate);

            DataGridView(dataGridView1);
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {

            FoodCatDate selectedFoodCatDate = (FoodCatDate)dataGridView1.CurrentRow.DataBoundItem;

            FoodCatDateRepository foodCatDateRepository = new FoodCatDateRepository();
            foodCatDateRepository.Delete(selectedFoodCatDate);

            DataGridView(dataGridView1);
        }
        private void date_ValueChanged(object sender, EventArgs e)
        {
            DataGridView(dataGridView1);
        }
    }
}

