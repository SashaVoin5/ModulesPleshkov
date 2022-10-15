using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для zadacha2.xaml
    /// </summary>
    public partial class zadacha2 : Window
    {
        public zadacha2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string stroka = Convert.ToString(txt_Enter.Text);
            int rus = Regex.Matches(stroka, @"[(абвгдеёжзийклмнопрстуфхцчшщьыъэюя)]", RegexOptions.IgnoreCase).Count;
            


            
                int k1 = 0, k2 = 0;
                int failNumb = 0;
                int number = 0;
                
                foreach (char ch in stroka)
                {
                   
                   
                
                number += 1;
                    if (ch == '(') k1++;
                    if (ch == ')') k2++;
                    if (k2 == 1)

                    {
                       if (k1 == 1)
                       {
                          if (failNumb == 0)
                         {
                           failNumb = number;
                            txt_Out.Text = failNumb.ToString();
                          }




                        }




                    }
                    

               }
                if (failNumb == 0 )
                {
                   if (k1 == 0 && k2 == 0)
                  {
                     txt_Out.Text = ("Скобок нет");
                    if (rus != 0)
                    {
                        TextInfo upp = new CultureInfo("ru-RU", false).TextInfo;

                    }
                    else 
                    {
                        txt_Out.Text = "Введите строку на руссском языке!";


                       

                    }
                }
                    else if (k1 == k2)
                    {
                        txt_Out.Text = ("0");
                   }

                    else if (k1 > k2)
                    {
                       txt_Out.Text = ("-1");
                    }

                }






                // Привет Андрей ( ну как ( твои дела )
            
           

        }
    }
}
