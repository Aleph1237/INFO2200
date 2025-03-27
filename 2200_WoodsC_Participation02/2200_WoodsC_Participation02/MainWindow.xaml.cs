//Name: Corbin Woods
//Class: INFO 2200
//Section: 001
//Professor: sharp, 1/23/25
//Participation or Assignment #: participation 02
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

namespace _2200_WoodsC_Participation02
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // create a Dictionary where the key is a string and the value is an object of the Phone class

        Dictionary<string, Phone> phoneDict = new Dictionary<string, Phone>(); //creates the dictionary, an object called phoneDict

        public MainWindow()
        {
            InitializeComponent(); //contstructor that makes something
            // call to the method

            LoadPhoneDetails();
        }

        private void LoadPhoneDetails() //LoadPhoneDetails method
        {
            StreamReader inputFile;
            //const string PHONES_FILE = "phones.txt"; // not required
            string[] tempPhone; //an array of strings called tempPhone
            //
            try //to handle any exceptions that may occur
            {   //
                inputFile = File.OpenText("phones.txt");
                // inputFile = File.OpenText(PHONES_FILE); not required
                inputFile.ReadLine(); //reads in the first line of data to consume it, then processes the rest of the data below        priming read
                while (!inputFile.EndOfStream)
                {
                    //
                    tempPhone = inputFile.ReadLine().Split(','); //split method returns the phone array
                    //
                    cboPhones.Items.Add(tempPhone[0]);
                    //
                    phoneDict.Add(tempPhone[0], new Phone(tempPhone));
                }
                inputFile.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPhoneDetails_Click(object sender, RoutedEventArgs e)
        {
            PhoneDetailsWindow pdw = new PhoneDetailsWindow(); //makes a new window called pdw (phone details window)

            string key = cboPhones.SelectedItem.ToString(); //combo box with makes of phones, converted to strings

            Phone phone; //makes a phone in the phone class

            if (phoneDict.TryGetValue(key, out phone))
            {
                //pdw.lblDisplay.Content = phone.DisplaySize; // not required

                pdw.UpdateGUI(phone);
                pdw.Show();
            }
            else
            {
                MessageBox.Show($"Could not find {key} in the database.");
            }
        }
    }
}
