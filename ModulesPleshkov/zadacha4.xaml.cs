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
    
    public partial class zadacha4 : Window
    {
        public zadacha4()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(txt_input.Text);
                int First = 0;
                int Last = 0;
                int Check;
                int next=0;
                int Vozrast = 0;
                int ubivanie=0;
                
                if (n > 0)
                {
                    int[] numbers = new int [n];
                    Random r = new Random();
                    for (int i = 0; i < n; i++)
                    {
                        numbers[i] = r.Next(1, 255);
                    }
                    for (int i = 0; i < n; i++)
                    {
                        Check = numbers[i];
                        First = numbers[0];
                        Last = numbers[i];
                        

                                                    
                          if (Check > next)
                          {
                                next = Check;
                                Vozrast += 1;
                          }
                          else if (Check <next)
                          {
                            next = Check;
                            ubivanie += 1;
                          }
                                                 
                            
                        

                    }

                    int g = n - 1;
                        numbers[0] = Last;
                        numbers[g] = First;



                    //Это уже цикл для проверки значений массива.
                    //Никакую функциональную роль в основной программе он не несет
                    for (int i = 0; i < n; i++)
                    {
                        int Check1 = numbers[i]; //Можно было писать значения в "Check", но так нагляднее
                        if (Check1>0) //чтобы просмотреть последнее значение массива.Иначе в дебаге его не видно
                        {

                        }
                    }









                    txt_out.Text = (" " + Vozrast.ToString() + " " + "промежутка возрастания и "+ " " + ubivanie.ToString() + " " + "промежутка убывания " +"А  также первый элемент "+ First.ToString() + " с последним " +Last.ToString()+ " " +" поменял местами" );


                }
                else
                {
                    txt_out.Text = ("Введите положительное число");
                }
            }

            catch
            {
                txt_out.Text = ("Введите число");
            }
            

        }
    }
}
