﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

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
        public static Dictionary<char, int> operators_judge = null;
        static void Calculator()
        {
            operators_judge = new Dictionary<char, int>();
            operators_judge.Add('+', 0);
            operators_judge.Add('-', 0);
            operators_judge.Add('*', 1);
            operators_judge.Add('%', 1);
            operators_judge.Add('/', 1);
            operators_judge.Add('^', 2);
        }
        public static double Compute(double leftnum,double rightnum,char temp)
        {
            switch (temp)
            {
                case '+': return leftnum + rightnum;
                case '-': return leftnum - rightnum;
                case '*': return leftnum * rightnum;
                case '/': return leftnum / rightnum;
                case '%': return leftnum % rightnum;
                case '^': return Math.Pow(leftnum, rightnum);
                default: return 0;
            }
        }
        static bool Isoperator(char op)
        {
            if (op == '+' || op == '-' || op == '*' || op == '/' || op == '%'||op=='^')
                return true;
            else
                return false;
        }
        #region Button
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

        private void __5_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text = "%";
        }
        #endregion
        private void Buuton_equal_Click(object sender, RoutedEventArgs e)
        {
            string expression;
            expression = textBox1.Text;
            textBox2.Text = Calculate(expression).ToString();

        }

        static Queue<object> Transform (string expression)
        {
            Queue<object> result = new Queue<object>();
            Stack<char> operators = new Stack<char>();
            char temp_1, temp_2, temp_3,temp_4;
            string tempnum = "";
            if (expression[0] == '-')
                expression = '0' + expression;
            for (int i = 0, j; i < expression.Length; i++)//逐字读取
            {
                temp_1 = expression[i];
                if (operators.Count != 0)
                    temp_2 = operators.Peek();
                else
                    temp_2 = new char();
                if (temp_1 == '(')
                {
                    operators.Push(temp_1);
                }
                else
                {
                    if (Isoperator(temp_1))
                    {
                        while (Isoperator(temp_2)&&operators_judge[temp_1] <= operators_judge[temp_2])
                        {
                            result.Enqueue(operators.Pop());
                            if (operators.Count==0)
                                break;
                            else
                                temp_2 = operators.Peek();
                        }
                        operators.Push(temp_1);
                    }
                    else if (temp_1 == ')')
                    {
                        while (operators.Count > 1 && (temp_3 = operators.Pop()) != '(')
                        {
                            result.Enqueue(temp_3);
                        }
                    }
                    else
                    {
                        tempnum = temp_1.ToString();
                        j = i;
                        while (j < expression.Length && (expression[j] == '.' ||
                            expression[j] == '0'|| expression[j] == '1'))
                        {
                            temp_4 = expression[j];
                            tempnum += temp_4.ToString();
                        }
                        result.Enqueue(tempnum);
                    }
                }
                while (operators.Count > 0)
                {
                    temp_1 = operators.Peek();
                    result.Enqueue(temp_1);              
                }
            }
            return result;
        }
        static double Calculate(string expression)
        {
            Queue<object> result = Transform(expression);
            Stack<double> operand = new Stack<double>();
            double leftnum, rightnum;
            object temp;
            while (result.Count > 0)
            {
                temp = result.Dequeue();
                if (temp is char)
                {
                    rightnum = operand.Pop();
                    leftnum = operand.Pop();
                    operand.Push(Compute(leftnum, rightnum, (char)temp));
                }
                else
                {
                    operand.Push(double.Parse(temp.ToString()));
                }
            }
            return operand.Pop();
        }
    }
}
    
