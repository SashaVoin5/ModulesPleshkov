using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ModulesPleshkov
{
    /// <summary>
    /// Логика взаимодействия для zadacha5.xaml
    /// </summary>
    public partial class zadacha5 : Window
    {
        //public int[,] mas;
        //public int[] a;
        public zadacha5()
        {
            InitializeComponent();
        }


        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txt_input1.Text);
                int m = Convert.ToInt32(txt_input2.Text);
                int[,] array = new int[n, m];
                int[] s = new int[n * m];
                int[] c = new int[n * m];
                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    string h = array[i, 0].ToString();
                    for (int j = 1; j < m; j++)
                    {
                        array[i, j] = rand.Next(-10, 10);
                        h += " " + array[i, j].ToString();
                    }
                    mass_lb.Items.Add(h);
                }

                int k = 0;
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        s[k] = array[i, j];
                        c[k] = array[i, j];
                        k++;
                    }
                }
                for (int i = 0; i < n * m - 1; i++)
                {
                    if (s[i] > s[i + 1])
                    {
                        int x = s[i];
                        s[i] = s[i + 1];
                        s[i + 1] = x;
                    }
                }
                for (int i = 0; i < n * m; i++)
                {
                    for (int j = 1; j < n * m; j++)
                    {
                        if (s[j] > s[j - 1])
                        {
                            int x = s[j];
                            s[j] = s[j - 1];
                            s[j - 1] = x;
                        }
                        if (c[j] < c[j - 1])
                        {
                            int x = c[j];
                            c[j] = c[j - 1];
                            c[j - 1] = x;
                        }
                    }
                }
                min_tb.Text += s[0].ToString();
                max_tb.Text += c[0].ToString();

                int p = 1;
                string line_d = s[0].ToString();
                string line_u = c[0].ToString();
                for (int i = 1; i < n * m; i++)
                {
                    if (p < m)
                    {
                        line_d += " " + s[i].ToString();
                        line_u += " " + c[i].ToString();
                        p++;
                    }
                    else
                    {
                        degrade_lb.Items.Add(line_d);
                        upgrade_lb.Items.Add(line_u);
                        line_d = s[i].ToString();
                        line_u = c[i].ToString();
                        p = 1;
                    }
                }
                degrade_lb.Items.Add(line_d);
                upgrade_lb.Items.Add(line_u);
            }
            catch (FormatException)
            {
                MessageBox.Show("Некорректный ввод данных. Введите числа.");
            }
        }


       

        private void clear_btn_Click(object sender, RoutedEventArgs e)
        {
            degrade_lb.Items.Clear();
            upgrade_lb.Items.Clear();
            mass_lb.Items.Clear();
            txt_input1.Clear();
            txt_input2.Clear();
            min_tb.Clear();
            max_tb.Clear();
        }
    }


}


    