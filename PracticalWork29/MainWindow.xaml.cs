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
    public partial class MainWindow : Window
    {
        

        //ку
        public MainWindow()
        {
            InitializeComponent();
            AppTheme.ChangeTheme(new Uri("Theme/Light.xaml", UriKind.Relative));
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput1.Text))
            {
                txtbl1.Visibility = Visibility.Visible;
            }
            else txtbl1.Visibility= Visibility.Hidden;
        }

        private void txtInput2_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(txtInput2.Text))
            {
                txtbl2.Visibility = Visibility.Visible;
            }
            else txtbl2.Visibility= Visibility.Hidden;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AppTheme.ChangeTheme(new Uri("Theme/Light.xaml", UriKind.Relative));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppTheme.ChangeTheme(new Uri("Theme/Dark.xaml", UriKind.Relative));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            AppTheme.ChangeTheme(new Uri("Theme/Red.xaml", UriKind.Relative));
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            AppTheme.ChangeTheme(new Uri("Theme/Green.xaml", UriKind.Relative));
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            AppTheme.ChangeTheme(new Uri("Theme/Blue.xaml", UriKind.Relative));
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Поздравляем, Вы создали аккаунт!", "Создание аккаунта", MessageBoxButton.OK);
        }
    }
}
