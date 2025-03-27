//Name: Corbin Woods
//Class: INFO 2200
//Section: 001
//Professor: Sharp
//Date: 2/4/2024
//Participation or Assignment #: Assn 02
//By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.

using System;
using System.Collections.Generic;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2200_WoodsC_Assignment02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create a Dictionary

        Dictionary<string, Food> foodDict = new Dictionary<string, Food>();

        public MainWindow()
        {
            InitializeComponent();

            // call LoadNutritionalValues() method

            LoadNutritionalValues();
        }

        private void LoadNutritionalValues()
        {
            const string NUTRITION_FILE = "nutrition.txt"; // declare constant to store the name of the data file
            StreamReader inputFile; // create reference variable (object) of the StreamReader class            
            string[] tempFood; // declare array of string          

            try
            {
                inputFile = File.OpenText(NUTRITION_FILE); // call the OpenText method and assign value to inputFile

                // skip the first line (record) in the text file containing header information
                inputFile.ReadLine();

                // loop for reading in records until end of file
                while (!inputFile.EndOfStream)
                {
                    // read in each record separating each field with tab

                    tempFood = inputFile.ReadLine().Split('\t');

                    // add array value to the Items collection of combo box

                    cbFoods.Items.Add(tempFood[0]);

                    // add key and value to dictionary 

                    foodDict.Add(tempFood[0], new Food(tempFood));
                }

                inputFile.Close(); // close file
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); // display system error message in Message Box
            }
        }
 

        private void cbFoods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                // event handler when selection from combo box is made

                
                // create an instance of the form

                NutritionDetailsWindow ndw = new NutritionDetailsWindow();

                // assign selected item of combo box to key variable

                string key = cbFoods.SelectedItem.ToString();

                // declare a reference variable (object) of the Food class

                Food food;

                // check to see if the key is contained in the dictionary, if so set the value to the output variable
                if ( foodDict.TryGetValue(key, out food)) 
                {                           
                    // call the SetNutritionalValues method pass the reference to the food object

                    ndw.SetNutritionalValues(food);

                    // display the form in modal fashion

                    ndw.ShowDialog();
                }
                else // false path
                {
                    // display error message
                    MessageBox.Show($"Could not find {key} in the database.");                                      
                }
        }
    }
}