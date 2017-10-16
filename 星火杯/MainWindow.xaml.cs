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
using System.Numerics;
using System.Windows.Forms;
using System.Numerics;

namespace 星火杯
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private Stack<decimal> Opnumber = new Stack<decimal>();
        private Stack<char> opre = new Stack<char>();
        #region
        private void Button_0_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "0";
        }
          public void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "1";
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "2";
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "3";
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text +="4";
        }
        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "5";
        }
        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "6";
        }
        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "7";
        }
        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "8";
        }
        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "9";
        }
        private void CHUFA_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "/";
        }
        private void CHENGFA_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "*";
        }
        private void Button_decreas_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "-";
        }
        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "+";
        }
        private void Point_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += ".";
        }
        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox1.Text = "";
        }
        private void TextBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox2.Text = "";
        }
        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void Backspace_Click(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "") ;
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }

        }

        private void X_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "X";
        }

        private void ___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "^";
        }
        private void e_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += Math.E;
        }

        private void π_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += Math.PI;
        }

        private void ln___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "ln()";
        }

        private void log_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "log()()";
        }

        private void lg_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "lg()";
        }

        private void sin___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "sin()";
        }

        private void cos___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "cos()";
        }

        private void tan___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "tan()";
        }

        private void __4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "√";
        }

        private void __1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "(";
        }

        private void __2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += ")";
        }

        private void __3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "!";
        }
        #endregion
        private void Buuton_equal_Click(object sender, RoutedEventArgs e)
        {
            
            string x = textBox1.Text;
            string a = "";
            string b = "";
            string c = "";
            string d = "";
            
            for (int i=0; i<x.Length; i++)
            {

                if (x.Substring(i, 1) == ("+") || x.Substring(i, 1) == ("-") || x.Substring(i, 1) == ("*") ||
                    x.Substring(i, 1) == ("/"))
                {
                    b = a;
                    a = "";
                    c += x.Substring(i, 1);
                }

                else
                {
                    a += x.Substring(i, 1);
                }

                if(x.Contains("."))
                {
                    d = ".";
                }
                
                if ((x.Contains("+") || x.Contains("-") || x.Contains("*") || x.Contains("/")))
                    ;

                else
                {
                    b = a;
                }
            }

            for (int i = 0; i < x.Length; i++)
            {                
                if (d == "."||x.Contains("/"))
                {
                    double A_d, B_d;
                    if (a != "" & b != "")
                    {
                        A_d = Convert.ToDouble(b);
                        B_d = Convert.ToDouble(a);
                    }
                    else
                    {
                        A_d = Convert.ToDouble(b);
                        B_d = 0;
                    }
                    switch (c)
                    {
                        case "+":
                            textBox2.Text = (System.Windows.Application.Current as App).Add_d(A_d, B_d).ToString();
                            break;
                        case "-":
                            textBox2.Text = (System.Windows.Application.Current as App).Minus_d(A_d, B_d).ToString();
                            break;
                        case "*":
                            textBox2.Text = (System.Windows.Application.Current as App).Multiply_d(A_d, B_d).ToString();
                            break;
                        case "/":
                            textBox2.Text = (System.Windows.Application.Current as App).Divide_d(A_d, B_d).ToString();
                            break;
                        case "":
                            textBox2.Text = (System.Windows.Application.Current as App).Nothing_d(A_d).ToString();
                            break;
                    }
                }
                else
                {
                    long A, B;
                    if (a != "" & b != "")
                    {
                        A = Convert.ToInt64(b);
                        B = Convert.ToInt64(a);
                    }
                    else
                    {
                        A = Convert.ToInt64(b);
                        B = 0;
                    }

                    switch (c)
                    {
                        case "+":
                            textBox2.Text = (System.Windows.Application.Current as App).Add(A, B).ToString();
                            break;
                        case "-":
                            textBox2.Text = (System.Windows.Application.Current as App).Minus(A, B).ToString();
                            break;
                        case "*":
                            textBox2.Text = (System.Windows.Application.Current as App).Multiply(A, B).ToString();
                            break;
                        case "":
                            textBox2.Text = (System.Windows.Application.Current as App).Nothing(A).ToString();
                            break;
                    }                      

                }
            }
        }

       
    }
}
    
