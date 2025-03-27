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

namespace _2200_WoodsC_Participation02
{
    /// <summary>
    /// Interaction logic for PhoneDetailsWindow.xaml
    /// </summary>
    public partial class PhoneDetailsWindow : Window
    {
        public PhoneDetailsWindow()
        {
            InitializeComponent();
        }
        public void UpdateGUI(Phone phone)
        {
            lblMake.Content = phone.Make;
            lblModel.Content = phone.Model;
            lblDisplay.Content = phone.DisplaySize;
            lblStorage.Content = phone.Storage;
            lblPrice.Content = phone.Price.ToString("c"); //converts the phone price (integer) to a string ("c" means currency). Then writes it to the content of lblPrice.
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); //close button
        }
    }
}
