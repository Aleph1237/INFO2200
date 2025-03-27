using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace _2200_WoodsC_Assignment02
{
    /// <summary>
    /// Interaction logic for NutritionDetailsWindow.xaml
    /// </summary>
    public partial class NutritionDetailsWindow : Window
    {
        public NutritionDetailsWindow()
        {
            InitializeComponent();
        }

        // method to set the Content property of the output Label controls using the properties of the food object

        public void SetNutritionalValues(Food food)
        {
            /*
            lblFood.Content = food.FoodName;
            lblFoodType.Content = food.FoodType;
            lblServingSize.Content = food.ServingSize;
            lblWeight.Content = food.Weight;

            lblCholesterol.Content = food.Cholesterol;

            lblCalcium.Content = food.Calcium.ToString();
            lblZinc.Content = food.Zinc;
             */
        }
    }
}
