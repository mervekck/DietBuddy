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
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DietBuddyApp.UI.Forms
{
    public partial class HowManyCalories : Form
    {
        private DietBuddyContext dBc = new DietBuddyContext();

        public HowManyCalories()
        {
            InitializeComponent();

            cbFoodCategories.DisplayMember = "Name";
            cbFoodCategories.DataSource = FoodCategoryGetAll();

            cbFood.DisplayMember = "Name";
            cbFood.DataSource = FoodGetAll();
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
        private void ıconButton1_Click(object sender, EventArgs e)
        {
            HomePage homePage = new HomePage();
            homePage.Show();
            this.Hide();
        }
        private void cbFood_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFood.SelectedItem != null)
            {
                string fileName = ((Food)cbFood.SelectedItem).Picture;
                pictureBox1.Image = Image.FromFile($"..\\..\\..{fileName}");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            FoodCategory selectedFoodCategory = (FoodCategory)cbFoodCategories.SelectedItem;
            Food selectedFood = (Food)cbFood.SelectedItem;


            double totalMeasure = Convert.ToDouble(nudMeasure.Value);

            double totalCalories = selectedFood.Calory * totalMeasure;
            double totalFat = selectedFood.Fat * totalMeasure;
            double totalProtein = selectedFood.Protein * totalMeasure;
            double totalCarbs = selectedFood.Carbohydrate * totalMeasure;

            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("TotalCalories", "TotalCalories");
            dataGridView1.Columns.Add("TotalFat", "TotalFat");
            dataGridView1.Columns.Add("TotalProtein", "TotalProtein");
            dataGridView1.Columns.Add("TotalCarbs", "TotalCarbs");

            dataGridView1.Rows.Add(

                totalCalories.ToString(),
                totalFat.ToString(),
                totalProtein.ToString(),
                totalCarbs.ToString()
            );
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
    }
}
