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

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 1;
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 2;
        }

        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 3;
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 4;
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 5;
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 6;
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 7;
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 8;
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += 9;
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

        private void Buuton_equal_Click(object sender, RoutedEventArgs e)
        {
            string x = textBox1.Text;
            string a = "";
            string b = "";
            string c = "";
            for(int i=0; i<x.Length; i++)
            {
                if(x.Substring(i,1)==("+")|| x.Substring(i, 1) == ("-")|| x.Substring(i, 1) == ("*")|| x.Substring(i, 1) == ("/"))
                {
                    b = a;
                    a = "";
                    c += x.Substring(i, 1);
                }

                else
                {
                    a += x.Substring(i, 1);
                }
            }
            switch (c)

            {
                case "+":
                    textBox1.Text = Add(a,b).ToString();
                    break;
                case "-":
                    textBox1.Text = (temp1 - temp2).ToString();
                    break;
                case 3:
                    textBox1.Text = (temp1 * temp2).ToString();
                    break;
                case 4:
                    textBox1.Text = (temp1 / temp2).ToString();
                    break;
            }


        }

        private void DELETE_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "0";
            temp1 = 0;
            pos = 0;
            {
            }
        }

        private void textBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            textBox1.Text = "";
        }
    }

}
    
