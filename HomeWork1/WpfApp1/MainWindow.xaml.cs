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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            label.Content = double.Parse(textbox1.Text) * double.Parse(textbox2.Text);
        }

        private void ___无名称__Click(object sender, RoutedEventArgs e)
        {
            label.Content = double.Parse(textbox1.Text) + double.Parse(textbox2.Text);
        }

        private void ___sub_Click(object sender, RoutedEventArgs e)
        {
            label.Content = double.Parse(textbox1.Text) - double.Parse(textbox2.Text);
        }

        private void __divide_Click(object sender, RoutedEventArgs e)
        {
            label.Content = double.Parse(textbox1.Text) / double.Parse(textbox2.Text);
        }
    }
}
