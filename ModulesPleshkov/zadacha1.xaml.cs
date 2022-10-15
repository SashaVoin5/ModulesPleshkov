using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModulesPleshkov
{
    /// <summary>
    /// Логика взаимодействия для zadacha1.xaml
    /// </summary>
    public partial class zadacha1 : Window
    {
        public zadacha1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
          try
           {
                int Year = Convert.ToInt32(txt_Enter.Text);
                
                if (Year > 0)
                {

                    Year = (Year - 1) / 100 + 1;
                    txt_out.Text = (Year.ToString() + " Столетие");
                }
                else
                {
                    txt_out.Text = ("Введите положительное число");
                }
           }
           catch
           {
             txt_out.Text = ("Введите  число");
           }

        }
    }
}
