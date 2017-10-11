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
        float temp1 = -1;
        int pos = 0;
        public void addNum(int num)
        {
            textBox1.Text = TextBox.TextAlignmentProperty + num.ToString();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            addNum(2);
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            addNum(3);
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            addNum(4);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            addNum(5);
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            addNum(6);
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            addNum(7);
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            addNum(8);
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            addNum(9);
        }

        private void CHUFA_Click(object sender, RoutedEventArgs e)
        {
            pos = 4;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void CHENGFA_Click(object sender, RoutedEventArgs e)
        {
            pos = 3;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button_decreas_Click(object sender, RoutedEventArgs e)
        {
            pos = 2;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void button_plus_Click(object sender, RoutedEventArgs e)
        {
            pos = 1;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void buuton_equal_Click(object sender, RoutedEventArgs e)
        {
            float temp2 = Convert.ToInt64(textBox1.Text);
            switch (pos)

            {
                case 1:
                    textBox1.Text = (temp1 + temp2).ToString();
                    break;
                case 2:
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
        }
    
