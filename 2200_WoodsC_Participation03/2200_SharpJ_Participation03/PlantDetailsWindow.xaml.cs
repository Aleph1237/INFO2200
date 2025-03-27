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

namespace _2200_SharpJ_Participation03
{
    /// <summary>
    /// Interaction logic for PlantDetailsWindow.xaml
    /// </summary>
    public partial class PlantDetailsWindow : Window
    {
        // create property

        public Plant SelectedPlant { get; set; }

        public PlantDetailsWindow()
        {
            InitializeComponent();
        }

        private void BtnSniff_Click(object sender, RoutedEventArgs e)
        {
            //display message for Sniff method
            MessageBox.Show(SelectedPlant.Sniff());
        }
    }
}
