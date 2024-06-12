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

namespace PracticalWork29
{
    /// <summary>
    /// Логика взаимодействия для CheckBoxes.xaml
    /// </summary>
    public partial class CheckBoxes : UserControl
    {
        public CheckBoxes()
        {
            InitializeComponent();
        }

        private string setCat;

        public string SetCat
        {
            get { return setCat; }
            set 
            { 
                setCat = value;
                rb1.Content = setCat;
            }
        }


        private void rb1_Checked(object sender, RoutedEventArgs e)
        {
            brd1.Background = (Brush)FindResource("GreenButton");
        }

        private void rb1_Unchecked(object sender, RoutedEventArgs e)
        {
            brd1.Background = Brushes.Transparent;
        }
    }
}
