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

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double FirstNumber;
        string Operation;

        public MainWindow()
        {
            InitializeComponent();
        }


        private void button_1_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "1";
            }
            else
            {
                textbox1.Text = textbox1.Text + "1";
            }
        }

        private void button_2_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "2";
            }
            else
            {
                textbox1.Text = textbox1.Text + "2";
            }
        }

        private void button_3_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "3";
            }
            else
            {
                textbox1.Text = textbox1.Text + "3";
            }
        }

        private void button_4_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "4";
            }
            else
            {
                textbox1.Text = textbox1.Text + "4";
            }
        }

        private void button_5_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "5";
            }
            else
            {
                textbox1.Text = textbox1.Text + "5";
            }
        }

        private void button_6_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "6";
            }
            else
            {
                textbox1.Text = textbox1.Text + "6";
            }
        }

        private void button_7_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "7";
            }
            else
            {
                textbox1.Text = textbox1.Text + "7";
            }
        }

        private void button_8_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "8";
            }
            else
            {
                textbox1.Text += "8";
            }
        }

        private void button_9_Click(object sender, RoutedEventArgs e)
        {
            if (textbox1.Text == "0" && textbox1.Text != null)
            {
                textbox1.Text = "9";
            }
            else
            {
                textbox1.Text += "9";
            }
        }

        private void button_0_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += "0";
        }
        private void button_dot_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text += ".";
        }

        private void C_Click(object sender, RoutedEventArgs e)
        {
            textbox1.Text = "0";
        }

        private void button_div_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textbox1.Text);
            textbox1.Text = "0";
            Operation = "/";
        }

        private void button_mul_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textbox1.Text);
            textbox1.Text = "0";
            Operation = "*";
        }

        private void button_sub_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textbox1.Text);
            textbox1.Text = "0";
            Operation = "-";
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            FirstNumber = Convert.ToDouble(textbox1.Text);
            textbox1.Text = "0";
            Operation = "+";
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            InitializeComponent();
        }
        private void button_eq_Click(object sender, RoutedEventArgs e)
        {
            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textbox1.Text);

            if (Operation == "+")
            {
                Result = FirstNumber + SecondNumber;
                textbox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "-")
            {
                Result = FirstNumber - SecondNumber;
                textbox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "*")
            {
                Result = FirstNumber * SecondNumber;
                textbox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    textbox1.Text = "can not divide by zero";
                }
                else
                {
                    Result = FirstNumber / SecondNumber;
                    textbox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
                
            }
        }

        
    }
}
