//Name: Corbin Woods
//Class: INFO 2200
//Section: 01
//Professor: Sharp
//Date: Feburary 11 2025
//Participation or Assignment #: participation03
//By submitting this assignment, I declare that the source code contained in this assignment was written #solely by me, unless specifically provided in the assignment. I attest that no part of this assignment, #in whole or in part, was directly created by Generative AI, unless explicitly stated in the assignment #instructions, nor obtained from a subscription service. I understand that copying any source code, #in whole or in part, unless specifically provided in the assignment, constitutes cheating, and that #I will receive a zero on this project if I am found in violation of this policy.


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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2200_SharpJ_Participation03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create a dictionary

        Dictionary<string, Plant> plantDictionary = new Dictionary<string, Plant>();

        public MainWindow()
        {
            InitializeComponent();
            LoadValues();
        }

        // LoadValues() method

        private void LoadValues()
        {
            // add items to environment combo box

            CbEnvironment.Items.Add("Forest");
            CbEnvironment.Items.Add("Desert");
            CbEnvironment.Items.Add("Tropical");

            // add items to type combo box

            CbType.Items.Add("Flower");
            CbType.Items.Add("Tree");
            CbType.Items.Add("Shrub");
        }

        // ValidInput() method

        public bool ValidInput()
        {
            string errorMessage = "";

            if (TxtBoxName.Text == "") errorMessage += "Please enter a name for the plant.\n\n";
            if (CbEnvironment.SelectedIndex == -1) errorMessage += "Please select an environment.\n\n";
            if (CbType.SelectedIndex == -1) errorMessage += "Please select a plant type.\n\n";

            if (errorMessage == "")
            {
                return true;
            }
            else
            {
                MessageBox.Show(errorMessage);
                return false;
            }
        }

        private void CbEnvironment_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CbEnvironment.SelectedItem)
            {
                case "Forest":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/forest.png", UriKind.Relative));
                    break;
                case "Desert":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/desert.png", UriKind.Relative));
                    break;
                case "Tropical":
                    ImgEnvironment.Source = new BitmapImage(new Uri("/Images/tropical.jpg", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }

        private void CbType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (CbType.SelectedItem)
            {
                case "Flower":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/rose.png", UriKind.Relative));
                    break;
                case "Tree":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/tree.jpg", UriKind.Relative));
                    break;
                case "Shrub":
                    ImgPlant.Source = new BitmapImage(new Uri("/Images/shrub.png", UriKind.Relative));
                    break;
                default:
                    break;
            }
        }

        private void BtnAddPlant_Click(object sender, RoutedEventArgs e)
        {
            if (ValidInput())
            {
                Plant plant = null;

                switch (CbType.SelectedItem)
                {
                    case "Flower":
                        plant = new Flower(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                        break;
                    case "Tree":
                        plant = new Tree(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                        break;
                    case "Shrub":
                        plant = new Shrub(CbEnvironment.SelectedItem.ToString(), CbType.SelectedItem.ToString(), TxtBoxName.Text);
                        break;
                    default:
                        MessageBox.Show("I have know idea how we got here.");
                        break;
                }

                if (plant != null)
                {
                    // plantDictionary method for validation
                    plantDictionary.Add(plant.Name, plant);
                    LstBoxPlants.Items.Add(plant.Name);
                }

            }
        }

        private void BtnShowDetails_Click(object sender, RoutedEventArgs e)
        {
            if (LstBoxPlants.SelectedIndex > -1)
            {
                if
                (plantDictionary.TryGetValue(LstBoxPlants.SelectedItem.ToString(), out Plant
                slPlant))
                {
                    PlantDetailsWindow pdw = new PlantDetailsWindow();
                    pdw.LblNameResults.Content = slPlant.Name;
                    pdw.LblEnvironmentResults.Content = slPlant.Environment; //LblEnvironmentResults
                    pdw.LblTypeResults.Content = slPlant.Type;
                    pdw.SelectedPlant = slPlant;
                    pdw.Show();
                }
                else
                {
                    MessageBox.Show("Could not find that plant in the database.");
                }
            }
            else
            {
                MessageBox.Show("Please select a plant from the Plants Box.");
            }
        }
    }
}