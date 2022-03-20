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

namespace dsds
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
        string Num1;
        string Num2;
        string Symbol;
        int Number;

        private void plus(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            cos.Content = "+";
            Symbol = "+";
            Number = 1;
        }
        private void minus(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            cos.Content = "-";
            Symbol = "-";
            Number = 1;
        }
        private void multiplication(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            cos.Content = "*";
            Symbol = "*";
            Number = 1;
        }
        private void division(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            cos.Content = "÷";
            Symbol = "÷";
            Number = 1;
        }

        private void one(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
            Num1 = Num1 + "1";
            cos.Content = Num1;
            }
            else
            {
            Num2 = Num2 + "1";
            cos.Content = Num2;
            }



        }
        private void two(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "2";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "2";
                cos.Content = Num2;
            }



        }
        private void three(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "3";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "3";
                cos.Content = Num2;
            }



        }
        private void four(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "4";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "4";
                cos.Content = Num2;
            }



        }
        private void five(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "5";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "5";
                cos.Content = Num2;
            }



        }
        private void six(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "6";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "6";
                cos.Content = Num2;
            }



        }
        private void seven(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "7";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "7";
                cos.Content = Num2;
            }



        }
        private void eight(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "8";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "8";
                cos.Content = Num2;
            }



        }
        private void nine(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "9";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "9";
                cos.Content = Num2;
            }



        }
        private void zero(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Number == 0)
            {
                Num1 = Num1 + "0";
                cos.Content = Num1;
            }
            else
            {
                Num2 = Num2 + "0";
                cos.Content = Num2;
            }
            
        }
        
        private void equal(object sender, RoutedEventArgs e)
        {
            var Button = sender as TextBlock;
            if (Symbol == "+")
            {
                cos.Content = int.Parse(Num1) + int.Parse(Num2);
            }
            else if (Symbol == "-")
            {
                cos.Content = int.Parse(Num1) - int.Parse(Num2);
            }
            else if (Symbol == "÷")
            {
                cos.Content = int.Parse(Num1) / int.Parse(Num2);
            }
            else if (Symbol == "*")
            {
                cos.Content = int.Parse(Num1) * int.Parse(Num2);
            }
        }

    }
    }

