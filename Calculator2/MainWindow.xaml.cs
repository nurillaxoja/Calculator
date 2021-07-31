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
using System.Windows.Media;

namespace Calculator2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string op = "+";
        double firstNumber = 0;
        double secondNumber = 0;
        double total = 0;
        public MainWindow()
        {
            InitializeComponent();
        }
        bool flag = false;
        private void ButtonOne_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "1";
            
        }

        private void ButtonTwo_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "2";
            
        }

        private void ButtonThree_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "3";
            
        }

        private void ButtonFoure_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "4";
            
        }

        private void ButtonFive_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "5";
            
        }

        private void ButtonSix_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "6";
            
        }

        private void ButtonSeven_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "7";
            
        }

        private void ButtonEight_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "8";
            
        }

        private void ButtonNine_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "9";
            
        }

        private void ButtonZero_Click(object sender, RoutedEventArgs e)
        {
            if (flag == true)
            {
                TextBox.Clear();
                flag = false;

            }
            TextBox.Text += "0";
            
        }

        private void ButtonResult_Click(object sender, RoutedEventArgs e)
        {
            if (op == "+")
            {
                secondNumber = double.Parse(TextBox.Text);
                total = firstNumber + secondNumber;
                TextBox.Text = total.ToString();
            }
            else if (op == "-")
            {
                secondNumber = double.Parse(TextBox.Text);
                total = firstNumber - secondNumber;
                TextBox.Text = total.ToString();
            }
            else if (op == "/")
            {
                secondNumber = double.Parse(TextBox.Text);
                total = firstNumber / secondNumber;
                TextBox.Text = total.ToString();
            }
            else if (op == "*")
            {
                secondNumber = double.Parse(TextBox.Text);
                total = firstNumber * secondNumber;
                TextBox.Text = total.ToString();
            }
        }

        private void ButtonAyirish_Click(object sender, RoutedEventArgs e)
        {
            op = "-";
            firstNumber = double.Parse(TextBox.Text);
            flag = true;
        }

        private void ButtonAdd_Click(object sender, RoutedEventArgs e)
        {
            op = "+";
            firstNumber = double.Parse(TextBox.Text);
            flag = true;
        }

        private void ButtonDivide_Click(object sender, RoutedEventArgs e)
        {
            op = "/";
            firstNumber = double.Parse(TextBox.Text);
            flag = true;

        }

        private void ButtonMultiply_Click(object sender, RoutedEventArgs e)
        {
            op = "*";
            firstNumber = double.Parse(TextBox.Text);
            flag = true;

        }

        private void ButtonClear_Click(object sender, RoutedEventArgs e)
        {
            TextBox.Clear();
            firstNumber = secondNumber = total = 0;
        }

        private void MemoryAdd_Click(object sender, RoutedEventArgs e)
        {
            //CalculatorHelper.AddSaved();
            secondNumber = 0;
            secondNumber = secondNumber+ double.Parse(TextBox.Text);
            CalculatorModule calcModel = CalculatorHelper.Get();
            double savedTotal = calcModel.Total; // 97
            total = secondNumber + savedTotal;
            TextBox.Text = total.ToString();
        }

        private void MemoryStore_Click(object sender, RoutedEventArgs e)
        {
            CalculatorHelper.CalculatorInsert(firstNumber ,secondNumber,total);
        }

        private void MemoryRecall_Click(object sender, RoutedEventArgs e)
        {

            CalculatorModule calcModel = CalculatorHelper.Get();
            double savedTotal = calcModel.Total;
            TextBox.Text = savedTotal.ToString();
        }

        private void MemoryClear_Click(object sender, RoutedEventArgs e)
        {
            CalculatorHelper.DeleteAll();
        }

        private void DarkTheme(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Color.FromArgb(0, 0, 0, 0));
        }

        private void WhiteTheme(object sender, RoutedEventArgs e)
        {
            Window.Background = new SolidColorBrush(Color.FromArgb(255, 255, 255, 255));
        }

        private void ChangeWindow(object sender, RoutedEventArgs e)
        {
            AboutUs aboutUsWindow = new AboutUs();
            aboutUsWindow.Show();

        }

       
        
    }
}
