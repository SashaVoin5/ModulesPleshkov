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

namespace ModulesPleshkov
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
            zadacha1 Form1 = new zadacha1();
            Form1.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            zadacha2 Form1 = new zadacha2();
            Form1.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Zadacha3 Form1 = new Zadacha3();
            Form1.Show();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            zadacha4 Form1 = new zadacha4();
            Form1.Show();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            zadacha5 Form1 = new zadacha5();
            Form1.Show();
        }
    }
}
