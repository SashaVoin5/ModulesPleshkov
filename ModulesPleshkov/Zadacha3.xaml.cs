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
    /// Логика взаимодействия для Zadacha3.xaml
    /// </summary>
    public partial class Zadacha3 : Window
    {
        public Zadacha3()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           try
            {
                int n = Convert.ToInt32(txt_input.Text);
                if (n > 3)
                {
                    int[] numbers = new int[n];
                    Random r = new Random();
                    int check;
                    int max1 = -1;
                    int max2 = -1;
                    int max3 = -1;
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] = r.Next(1, 255);
                    }
                    for (int i = 0; i < n; i++)
                    {
                        check = numbers[i];
                        if (check > max1)
                        {
                            max1 = check;
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        check = numbers[i];

                        if (check > max2 && check != max1)
                        {
                            max2 = check;
                        }
                    }
                    for (int i = 0; i < n; i++)
                    {
                        check = numbers[i];

                        if (check > max3 && check != max2 && check != max1)
                        {
                            max3 = check;
                        }
                    }
                    int itog = max1 * max2 * max3;
                    txt_output.Text = ("Произведение чисел" + " " + max1.ToString() + " " + max2.ToString() + " " + max3.ToString() + " " + "равно" + " " + itog.ToString());
                }
                else
                {
                    txt_output.Text = ("Введите N >3");
                }
                
            }
            catch
            {
                txt_output.Text = ("Введите число");
            }
            
        }
    }
}
