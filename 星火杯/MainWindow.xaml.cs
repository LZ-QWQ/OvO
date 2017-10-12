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
        public void AddNum(int num)
        {
            textBox1.Text = TextBox.TextAlignmentProperty + num.ToString();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            AddNum(1);
        }
        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            AddNum(2);
        }




        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            AddNum(3);
        }

        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            AddNum(4);
        }

        private void Button5_Click(object sender, RoutedEventArgs e)
        {
            AddNum(5);
        }

        private void Button6_Click(object sender, RoutedEventArgs e)
        {
            AddNum(6);
        }

        private void Button7_Click(object sender, RoutedEventArgs e)
        {
            AddNum(7);
        }

        private void Button8_Click(object sender, RoutedEventArgs e)
        {
            AddNum(8);
        }

        private void Button9_Click(object sender, RoutedEventArgs e)
        {
            AddNum(9);
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
            temp1 = Convert.ToInt64("textBox1.Text");
            textBox1.Text = "";
        }

        private void Button_decreas_Click(object sender, RoutedEventArgs e)
        {
            pos = 2;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            pos = 1;
            temp1 = Convert.ToInt64(textBox1.Text);
            textBox1.Text = "";
        }

        private void Buuton_equal_Click(object sender, RoutedEventArgs e)
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
            {
            }
        }
    }
}
    
