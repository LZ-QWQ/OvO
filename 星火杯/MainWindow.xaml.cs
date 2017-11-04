﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
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
        #region Button
        private void _0_Click(object sender, RoutedEventArgs e)
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
        private void Button_plus_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "+";
        }
        private void Buttom_subtraction_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "-";
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
            textBox1.Text += "e";
        }
        private void π_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "π";
        }
        private void ln___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "ln(";
        }
        private void log_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "log(";
        }
        private void lg_Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "lg(";
        }
        private void sin___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "sin(";
        }
        private void cos___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "cos(";
        }
        private void tan___Click(object sender, RoutedEventArgs e)
        {
            textBox1.Text += "tan(";
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
            textBox1.Text += "%";
        }
        #endregion
        class Polynomial:IComparable<Polynomial>
        { 
            public int exponent;
            public double coefficient;
            public string expression;

            int IComparable<Polynomial>.CompareTo(Polynomial other)
            {
                return other.exponent.CompareTo(exponent);
            }

        }
        static Queue<object> Transform (string expression)//中缀转后缀
        {
            Dictionary<char, int> operators_judge = new Dictionary<char, int>();
            operators_judge.Add('+', 0);
            operators_judge.Add('-', 0);
            operators_judge.Add('*', 1);
            operators_judge.Add('%', 1);
            operators_judge.Add('/', 1);
            operators_judge.Add('^', 2);
            Queue<object> result = new Queue<object>();
            Stack<char> operators = new Stack<char>();
            char temp_1, temp_2, temp_3,temp_4;
            string tempnum ;
            for (int i = 0; i < expression.Length;)//逐字读取
            {
                int j = i;
                temp_1 = expression[i];
                if (operators.Count != 0)
                    temp_2 = operators.Peek();
                else
                    temp_2 =' ';
                if (temp_1 == '(')
                {
                    operators.Push(temp_1);
                }
                else
                {
                    if (Isoperator(temp_1))
                    {
                        while (Isoperator(temp_2) && operators_judge[temp_1] <= operators_judge[temp_2])
                        {
                            result.Enqueue(operators.Pop());
                            if (operators.Count == 0)
                                break;
                            else
                                temp_2 = operators.Peek();
                        }
                        operators.Push(temp_1);
                    }
                    else if (temp_1 == ')')
                    {
                        while (operators.Count > 0 && (temp_3 = operators.Pop()) != '(')
                        {
                            result.Enqueue(temp_3);
                        }
                    }
                    else
                    {
                        tempnum = "";
                        while (j < expression.Length && (expression[j] == '.' || 
                            expression[j] == 'E' && expression[j + 1]=='-'|| 
                            expression[j] == 'E' && expression[j + 1] == '+'||
                            expression[j] == '+' && expression[j - 1] == 'E'||
                            expression[j] == '-' && expression[j - 1] == 'E'||
                            expression[j] >= '0' && expression[j] <= '9'))
                        {
                            temp_4 = expression[j];
                            tempnum = tempnum + temp_4.ToString();
                            j++;
                            i = j - 1;
                        }
                        result.Enqueue(Convert.ToDouble(tempnum));
                    }
                }
                i++;
            }
            while (operators.Count > 0)
            {
                temp_1 = operators.Pop();
                result.Enqueue(temp_1);
            }
            return result;
        }
        static double Calculate(string expression)
        {
            Queue<object> result_ = Transform(expression);
            Stack<double> operand=new Stack<double>();
            double leftnum = 0, rightnum = 0;
            object temp=0;
            while (result_.Count > 0)
            {
                temp = result_.Dequeue();
                if (temp is char)
                {
                    rightnum = operand.Pop();
                    leftnum = operand.Pop();
                    operand.Push(Compute(leftnum, rightnum, (char)temp));
                }
                else
                {
                    operand.Push(Convert.ToDouble(temp));
                }
            }
            return operand.Pop();
        }//计算！！！
        public static double Compute(double leftnum, double rightnum, char temp)//逆波兰表达式计算
        {
            switch (temp)
            {
                case '+': return leftnum + rightnum;
                case '-': return leftnum - rightnum;
                case '*': return leftnum * rightnum;
                case '/': return leftnum / rightnum;
                case '%': return leftnum % rightnum;
                case '^': return Math.Pow(leftnum, rightnum);
                default:
                    return 0;
            }
        }
        public static double Factorial(long i)//阶乘
        {
            double j = 1;
            for (; i > 1;)
            {
                j *= i;
                i--;
            }
            return j;
        }
        static bool Isoperator(char op)//判断是否为操作符
        {
            if (op == '+' || op == '-' || op == '*' || op == '/' || op == '%' || op == '^')
                return true;
            else
                return false;
        }
        private void Equal_Click(object sender, RoutedEventArgs e)//等于
        {
            string expression;
            expression = textBox1.Text;

            if (expression.IndexOf("X") >= 0)//多项式
            {
                List<Polynomial> expressions = new List<Polynomial>();
                List<Polynomial> expressions_1 = new List<Polynomial>();
                List<Polynomial> expressions_2 = new List<Polynomial>();
                int temp_0 = new int(),temp_0_0;
                double temp_0_d = new double(),temp_0_0_d;
                string temp_0_s = null, temp_1_s = null,temp_2_s=null,temp_0_0_s=null;
                int i = 0, j = 0, r = 0, x = 0, y = 0, k = 0, l = 0;
                bool Hi=true,Hii=true,Hiii=true,Hiiii=true,kao=false;           
                //Hi判断相同次数项，Hii判断系数符号，Hiii判断乘还是加减，Hiiii判断常数项
                for (i = 0; i < expression.Length;)
                {
                    if (expression[i] == '(')
                        y++;
                    else if (expression[i] == ')')
                    {
                        y--;
                        if (y == 0 && i + 1 < expression.Length && ((expression[i + 1] == '*' &&
                            expression[i + 2] == '(') || expression[i + 1] == '('))
                        {
                            Hiii = false;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("输入有误请重新输入(￢︿̫̿￢☆)", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                            expression = null;
                            kao = true;
                            break;
                        }
                    }
                    i++;
                }
                if (Hiii)
                {
                    for (i = 0; expression!=null&&i < expression.Length;)
                    {
                        if (Isoperator(expression[i]))
                        {
                            if (expression[i] == '+')
                                Hii = true;
                            else if (expression[i] == '-')
                                Hii = false;
                            else
                            {
                                kao = true;
                                expression = null;
                                MessageBox.Show("输入有误请重新输入(￢︿̫̿￢☆)", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                                break;
                            }
                            i++;
                        }//判断运算符以处理系数符号
                        if (expression[i] == 'X')
                        {
                            if (Hii)
                                temp_0_d = 1;
                            else if (Hii == false)
                                temp_0_d = -1;
                            j = i;
                        }//系数
                        else
                        {
                            for (j = i; expression[j] >= '0' && expression[j] <= '9' || expression[j] == '.';)
                            {
                                temp_0_s += expression[j];
                                j++;
                                if (j == expression.Length)
                                {
                                    if (Hii)
                                        temp_0_d = Convert.ToDouble(temp_0_s);
                                    else
                                    {
                                        temp_0_d = Convert.ToDouble(temp_0_s);
                                        temp_0_d = -temp_0_d;
                                    }
                                    temp_0_s = null;
                                    Hiiii = false;
                                    break;
                                }
                                else if (Isoperator(expression[j]))
                                {
                                    if (Hii)
                                        temp_0_d = Convert.ToDouble(temp_0_s);
                                    else
                                    {
                                        temp_0_d = Convert.ToDouble(temp_0_s);
                                        temp_0_d = -temp_0_d;
                                    }
                                    temp_0_s = null;
                                    Hiiii = false;
                                    break;
                                }
                                else if (expression[j] == 'X')
                                {
                                    if (Hii)
                                        temp_0_d = Convert.ToDouble(temp_0_s);
                                    else
                                    {
                                        temp_0_d = Convert.ToDouble(temp_0_s);
                                        temp_0_d = -temp_0_d;
                                    }
                                    temp_0_s = null;
                                    break;
                                }
                            }
                        }
                        if (Hiiii == false)
                        {
                            temp_0 = 0;
                            r = j;
                            Hiiii = true;
                        }//次数
                        else if (j + 1 < expression.Length && expression[j + 1] == '^')
                        {
                            for (r = j + 2; r < expression.Length && (expression[r] >= '0' || expression[r] <= '9');)
                            {
                                temp_1_s += expression[r];
                                r++;
                                if (r < expression.Length && Isoperator(expression[r]))
                                {
                                    temp_0 = Convert.ToInt32(temp_1_s);
                                    temp_1_s = null;
                                    break;
                                }
                                else if (r == expression.Length)
                                {
                                    temp_0 = Convert.ToInt32(temp_1_s);
                                    temp_1_s = null;
                                    break;
                                }
                            }
                        }
                        else if (j + 1 <= expression.Length && (j + 1 == expression.Length || Isoperator(expression[j + 1])))
                        {
                            r = j;
                            temp_0 = 1;
                            r++;
                        }
                        foreach (Polynomial s in expressions)
                        {
                            if (s.exponent == temp_0)
                            {
                                x = expressions.IndexOf(s);
                                temp_0_d = expressions[x].coefficient + temp_0_d;
                                if (temp_0_d != 1&&temp_0_d!=-1)
                                {
                                    if (Hiiii == false)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else if (temp_0 == 1)
                                        temp_2_s = Math.Abs(temp_0_d).ToString() + "X";
                                    else if (temp_0 == 0)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else
                                        temp_2_s = Math.Abs(temp_0_d).ToString() + "X^" + temp_0.ToString();
                                    Hi = false;
                                }
                                else
                                {
                                    if (Hiiii == false)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else if (temp_0 == 1)
                                        temp_2_s = "X";
                                    else if (temp_0 == 0)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else
                                        temp_2_s = "X^" + temp_0.ToString();
                                    Hi = false;
                                }
                            }
                        }//合并同类项
                        if (Hi)
                        {
                            expressions.Add(new Polynomial
                            {
                                exponent = temp_0,
                                coefficient = temp_0_d,
                                expression = expression.Substring(i, r - i)
                            });
                        }//加入项
                        else
                        {
                            expressions.Add(new Polynomial
                            {
                                exponent = temp_0,
                                coefficient = temp_0_d,
                                expression = temp_2_s
                            });
                            expressions.RemoveAt(x);
                        }
                        expressions.Sort();//排序
                        i = r;
                        Hi = true;
                        Hii = true;
                    }
                }
                else if (Hiii == false)
                {
                    i = 0;
                    if (i<expression.Length && expression[i] == '(')
                    {
                        i++;
                        for (; i < expression.Length;)
                        {
                            if (Isoperator(expression[i]))
                            {
                                if (expression[i] == '+')
                                    Hii = true;
                                else if (expression[i] == '-')
                                    Hii = false;
                                else
                                {
                                    kao = true;
                                    expression = null;
                                    MessageBox.Show("输入有误请重新输入(￢︿̫̿￢☆)", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                                    break;
                                }
                                i++;
                            }
                            if (expression[i] == 'X')
                            {
                                if (Hii)
                                    temp_0_d = 1;
                                else if (Hii == false)
                                    temp_0_d = -1;
                                j = i;
                            }
                            else
                            {
                                for (j = i; expression[j] >= '0' && expression[j] <= '9' || expression[j] == '.';)
                                {
                                    temp_0_s += expression[j];
                                    j++;
                                    if (j == expression.Length)
                                    {
                                        if (Hii)
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                        else
                                        {
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                            temp_0_d = -temp_0_d;
                                        }
                                        temp_0_s = null;
                                        Hiiii = false;
                                        break;
                                    }
                                    else if (Isoperator(expression[j])||expression[j]==')')
                                    {
                                        if (Hii)
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                        else
                                        {
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                            temp_0_d = -temp_0_d;
                                        }
                                        temp_0_s = null;
                                        Hiiii = false;
                                        break;
                                    }
                                    else if (expression[j] == 'X')
                                    {
                                        if (Hii)
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                        else
                                        {
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                            temp_0_d = -temp_0_d;
                                        }
                                        temp_0_s = null;
                                        break;
                                    }
                                }
                            }
                            if (Hiiii == false)
                            {
                                temp_0 = 0;
                                r = j;
                                Hiiii = true;
                            }
                            else if (j + 1 < expression.Length && expression[j + 1] == '^')
                            {
                                for (r = j + 2; r < expression.Length && (expression[r] >= '0' || expression[r] <= '9');)
                                {
                                    temp_1_s += expression[r];
                                    r++;
                                    if (r < expression.Length && (Isoperator(expression[r])||expression[r]==')'))
                                    {
                                        temp_0 = Convert.ToInt32(temp_1_s);
                                        temp_1_s = null;
                                        break;
                                    }
                                    else if (r == expression.Length)
                                    {
                                        temp_0 = Convert.ToInt32(temp_1_s);
                                        temp_1_s = null;
                                        break;
                                    }
                                }
                            }
                            else if (j + 1 <= expression.Length && (expression[j+1]==')'||Isoperator(expression[j + 1])))
                            {
                                r = j;
                                temp_0 = 1;
                                r++;
                            }
                            foreach (Polynomial s in expressions)
                            {
                                if (s.exponent == temp_0)
                                {
                                    x = expressions.IndexOf(s);
                                    temp_0_d = expressions[x].coefficient + temp_0_d;
                                    if (Hiiii == false)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else if (temp_0 == 1)
                                        temp_2_s = Math.Abs(temp_0_d).ToString() + "X";
                                    else if (temp_0 == 0)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else
                                        temp_2_s = Math.Abs(temp_0_d).ToString() + "X^" + temp_0.ToString();
                                    Hi = false;
                                }
                            }
                            if (Hi)
                            {
                                expressions.Add(new Polynomial
                                {
                                    exponent = temp_0,
                                    coefficient = temp_0_d,
                                    expression = expression.Substring(i, r - i)
                                });
                            }
                            else
                            {
                                expressions.Add(new Polynomial
                                {
                                    exponent = temp_0,
                                    coefficient = temp_0_d,
                                    expression = temp_2_s
                                });
                                expressions.RemoveAt(x);
                            }
                            i = r;
                            Hi = true;
                            Hii = true;
                            if (expression[i] == ')')
                            {
                                i++;
                                break;
                            }
                        }
                        expressions.Sort();
                        if (expression[i] == '*' && expression[i + 1] == '(')
                            i = i + 2;
                        else if (expression[i] == '(')
                            i = i + 1;
                        for (; i < expression.Length && expression[i] != ')';)
                        {
                            if (Isoperator(expression[i]))
                            {
                                if (expression[i] == '+')
                                    Hii = true;
                                else if (expression[i] == '-')
                                    Hii = false;
                                else
                                {
                                    kao = true;
                                    expression = null;
                                    MessageBox.Show("输入有误请重新输入(￢︿̫̿￢☆)", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
                                    break;
                                }
                                i++;
                            }//判断运算符以处理系数符号
                            if (expression[i] == 'X')
                            {
                                if (Hii)
                                    temp_0_d = 1;
                                else if (Hii == false)
                                    temp_0_d = -1;
                                j = i;
                            }//系数
                            else
                            {
                                for (j = i; expression[j] >= '0' && expression[j] <= '9' || expression[j] == '.';)
                                {
                                    temp_0_s += expression[j];
                                    j++;
                                    if (j == expression.Length)
                                    {
                                        if (Hii)
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                        else
                                        {
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                            temp_0_d = -temp_0_d;
                                        }
                                        temp_0_s = null;
                                        Hiiii = false;
                                        break;
                                    }
                                    else if (Isoperator(expression[j])||expression[j]==')')
                                    {
                                        if (Hii)
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                        else
                                        {
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                            temp_0_d = -temp_0_d;
                                        }
                                        temp_0_s = null;
                                        Hiiii = false;
                                        break;
                                    }
                                    else if (expression[j] == 'X')
                                    {
                                        if (Hii)
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                        else
                                        {
                                            temp_0_d = Convert.ToDouble(temp_0_s);
                                            temp_0_d = -temp_0_d;
                                        }
                                        temp_0_s = null;
                                        break;
                                    }
                                }
                            }
                            if (Hiiii == false)
                            {
                                temp_0 = 0;
                                r = j;
                                Hiiii = true;
                            }//次数
                            else if (j + 1 < expression.Length && expression[j + 1] == '^')
                            {
                                for (r = j + 2; r < expression.Length && (expression[r] >= '0' || expression[r] <= '9');)
                                {
                                    temp_1_s += expression[r];
                                    r++;
                                    if (r < expression.Length && (Isoperator(expression[r])||expression[r]==')'))
                                    {
                                        temp_0 = Convert.ToInt32(temp_1_s);
                                        temp_1_s = null;
                                        break;
                                    }
                                    else if (r == expression.Length)
                                    {
                                        temp_0 = Convert.ToInt32(temp_1_s);
                                        temp_1_s = null;
                                        break;
                                    }
                                }
                            }
                            else if (j + 1 <= expression.Length && (j + 1 == expression.Length || Isoperator(expression[j + 1])||expression[j+1]==')'))
                            {
                                r = j;
                                temp_0 = 1;
                                r++;
                            }
                            foreach (Polynomial s in expressions_1)
                            {
                                if (s.exponent == temp_0)
                                {
                                    x = expressions_1.IndexOf(s);
                                    temp_0_d = expressions_1[x].coefficient + temp_0_d;
                                    if (Hiiii == false)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else if (temp_0 == 1)
                                        temp_2_s = Math.Abs(temp_0_d).ToString() + "X";
                                    else if (temp_0 == 0)
                                        temp_2_s = Math.Abs(temp_0_d).ToString();
                                    else
                                        temp_2_s = Math.Abs(temp_0_d).ToString() + "X^" + temp_0.ToString();
                                    Hi = false;
                                }
                            }//合并同类项
                            if (Hi)
                            {
                                expressions_1.Add(new Polynomial
                                {
                                    exponent = temp_0,
                                    coefficient = temp_0_d,
                                    expression = expression.Substring(i, r - i)
                                });
                            }//加入项
                            else
                            {
                                expressions_1.Add(new Polynomial
                                {
                                    exponent = temp_0,
                                    coefficient = temp_0_d,
                                    expression = temp_2_s
                                });
                                expressions_1.RemoveAt(x);
                            }
                            i = r;
                            Hi = true;
                            Hii = true;
                        }
                        expressions_1.Sort();
                        foreach (Polynomial s_ in expressions_1)
                        {
                            temp_0 = s_.exponent;
                            temp_0_d = s_.coefficient;
                            foreach (Polynomial s__ in expressions)
                            {
                                temp_0_0 = temp_0 + s__.exponent;
                                temp_0_0_d = temp_0_d*s__.coefficient;
                                if (temp_0_0_d != 1&&temp_0_0_d != -1)
                                {
                                    if (temp_0_0 == 0)
                                        temp_0_0_s = Math.Abs(temp_0_0_d).ToString();
                                    else if (temp_0_0 == 1)
                                        temp_0_0_s = Math.Abs(temp_0_0_d).ToString() + "X";
                                    else if (temp_0_0 == 0)
                                        temp_0_0_s = Math.Abs(temp_0_d).ToString();
                                    else
                                        temp_0_0_s = Math.Abs(temp_0_0_d).ToString() + "X^" + temp_0_0.ToString();
                                }
                                else
                                {
                                    if (temp_0_0 == 0)
                                        temp_0_0_s = Math.Abs(temp_0_0_d).ToString();
                                    else if (temp_0_0 == 1)
                                        temp_0_0_s = "X";
                                    else if (temp_0_0 == 0)
                                        temp_0_0_s = Math.Abs(temp_0_d).ToString();
                                    else
                                        temp_0_0_s = "X^" + temp_0_0.ToString();
                                }
                                foreach (Polynomial s in expressions_2)
                                {
                                    if (s.exponent == temp_0_0)
                                    {
                                        x = expressions_2.IndexOf(s);
                                        temp_0_0_d = s.coefficient + temp_0_0_d;
                                        if (temp_0_0_d != 1&&temp_0_0_d!=-1)
                                        {
                                            if (temp_0_0 == 0)
                                                temp_2_s = Math.Abs(temp_0_0_d).ToString();
                                            else if (temp_0_0 == 1)
                                                temp_2_s = Math.Abs(temp_0_0_d).ToString() + "X";
                                            else if (temp_0_0 == 0)
                                                temp_2_s = Math.Abs(temp_0_d).ToString();
                                            else
                                                temp_2_s = Math.Abs(temp_0_0_d).ToString() + "X^" + temp_0_0.ToString();
                                        }
                                        else
                                        {
                                            if (temp_0_0 == 0)
                                                temp_2_s = Math.Abs(temp_0_0_d).ToString();
                                            else if (temp_0_0 == 1)
                                                temp_2_s = "X";
                                            else if (temp_0_0 == 0)
                                                temp_2_s = Math.Abs(temp_0_d).ToString();
                                            else
                                                temp_2_s = "X^" + temp_0_0.ToString();
                                        }
                                        Hi = false;
                                    }
                                }
                                if (Hi)
                                    expressions_2.Add(new Polynomial
                                    {
                                        exponent = temp_0_0,
                                        coefficient = temp_0_0_d,
                                        expression = temp_0_0_s,
                                    });
                                else
                                {
                                    expressions_2.Add(new Polynomial
                                    {
                                        exponent = temp_0_0,
                                        coefficient = temp_0_0_d,
                                        expression = temp_2_s
                                    });
                                    expressions_2.RemoveAt(x);
                                }
                                Hi = true;
                            }
                        }
                    }
                    expressions_2.Sort();//排序
                }
                if (Hiii)
                {
                    string temp__ = null;
                    foreach (Polynomial s in expressions)//输出，考虑符号
                    {
                        if (s.coefficient > 0)
                        {
                            if (expressions.IndexOf(s) == 0)
                                temp__ += s.expression;
                            else
                                temp__ += "+" + s.expression;
                        }
                        else if (s.coefficient < 0)
                            temp__ += "-" + s.expression;
                        else if (s.coefficient == 0)
                            ;
                    }
                    if (kao)
                        textBox2.Text = "乘法请用括号,暂不支持多重括号，暂不支持除法运算";
                    else if (temp__ == null)
                        textBox2.Text = "0";
                    else
                        textBox2.Text = temp__;
                }
                else if (Hiii == false)
                {
                    string temp__ = null;
                    foreach (Polynomial s in expressions_2)//输出，考虑符号
                    {
                        if (s.coefficient > 0)
                        {
                            if (expressions_2.IndexOf(s) == 0)
                                temp__ += s.expression;
                            else
                                temp__ += "+" + s.expression;
                        }
                        else if (s.coefficient < 0)
                            temp__ += "-" + s.expression;
                        else if (s.coefficient == 0)
                            ;
                    }
                    if (kao)
                        textBox2.Text = "乘法请用括号括起来计算/(ㄒoㄒ)/~~暂不支持除法运算";
                    else if (temp__ == null)
                        textBox2.Text = "0";
                    else
                        textBox2.Text = temp__;
                }
               
            }//多项式
            else
            {
                for (; expression.IndexOf("e") >= 0;)
                {
                    expression = expression.Replace("e", Math.E.ToString());
                }//转换E
                for (; expression.IndexOf("π") >= 0;)
                {
                    expression = expression.Replace("π", Math.PI.ToString());
                }//转换π
                for (; expression.IndexOf("sin") >= 0;)
                {
                    string temp_1, temp_3;
                    double temp_2;
                    int temp = expression.IndexOf("sin");
                    int x = new int(), j = temp + 3;
                    while (j < expression.Length)
                    {
                        if (expression[j] == '(')
                            x++;
                        else if (expression[j] == ')')
                            x--;
                        if (x == 0)
                            break;
                        j++;
                    }
                    temp_1 = expression.Substring(temp + 3, j - temp - 2);
                    temp_2 = Math.Sin(Calculate(temp_1));
                    temp_3 = expression.Substring(temp, j - temp + 1);
                    expression = expression.Replace(temp_3, temp_2.ToString());
                }//sin函数   这里有个很大很大的问题！！！！！
                for (; expression.IndexOf("cos") >= 0;)
                {
                    string temp_1, temp_3;
                    double temp_2;
                    int temp = expression.IndexOf("cos");
                    int x = new int(), j = temp + 3;
                    while (j < expression.Length)
                    {
                        if (expression[j] == '(')
                            x++;
                        else if (expression[j] == ')')
                            x--;
                        if (x == 0)
                            break;
                        j++;
                    }
                    temp_1 = expression.Substring(temp + 3, j - temp - 2);
                    temp_2 = Math.Cos(Calculate(temp_1));
                    temp_3 = expression.Substring(temp, j - temp + 1);
                    expression = expression.Replace(temp_3, temp_2.ToString());
                }//cos函数
                for (; expression.IndexOf("tan") >= 0;)
                {
                    string temp_1, temp_3;
                    double temp_2;
                    int temp = expression.IndexOf("tan");
                    int x = new int(), j = temp + 3;
                    while (j < expression.Length)
                    {
                        if (expression[j] == '(')
                            x++;
                        else if (expression[j] == ')')
                            x--;
                        if (x == 0)
                            break;
                        j++;
                    }
                    temp_1 = expression.Substring(temp + 3, j - temp - 2);
                    temp_2 = Math.Tan(Calculate(temp_1));
                    temp_3 = expression.Substring(temp, j - temp + 1);
                    expression = expression.Replace(temp_3, temp_2.ToString());
                }//tan函数
                for (; expression.IndexOf("!") >= 0;)//判断阶乘并计算再丢回去
                {
                    int i;
                    double temp_2;
                    string temp_1, temp_3;
                    int temp = expression.IndexOf("!");
                    if (expression[temp - 1] == ')')
                    {
                        int x = new int(), j = temp - 1;
                        while (j < expression.Length)
                        {
                            if (expression[j] == ')')
                                x++;
                            else if (expression[j] == '(')
                                x--;
                            if (x == 0)
                                break;
                            j--;
                        }
                        temp_1 = expression.Substring(j + 1, temp - j - 2);
                        temp_2 = Factorial(Convert.ToInt64(Calculate(temp_1)));
                        temp_3 = expression.Substring(j, temp - j + 1);
                        expression = expression.Replace(temp_3, temp_2.ToString());
                    }
                    else
                    {
                        for (i = temp - 1; i >= 0 && (expression[i] == '.' || expression[i] >= '0' && expression[i] <= '9'); i--) ;
                        i++;
                        temp_1 = expression.Substring(i, temp - i);
                        temp_2 = Factorial(Convert.ToInt64(temp_1));
                        expression = expression.Replace(temp_1 + "!", temp_2.ToString());
                    }
                }//阶乘
                for (; expression.IndexOf("√") >= 0;)//开根
                {
                    int i;
                    double temp_2;
                    string temp_1, temp_3;
                    int temp = expression.IndexOf("√");
                    if (expression[temp + 1] == '(')
                    {
                        int x = 0, j = temp + 1;
                        while (j < expression.Length)
                        {
                            if (expression[j] == '(')
                                x++;
                            else if (expression[j] == ')')
                                x--;
                            if (x == 0)
                                break;
                            j++;
                        }
                        temp_1 = expression.Substring(temp + 1, j - temp);
                        temp_2 = Math.Sqrt((Convert.ToDouble(Calculate(temp_1))));
                        temp_3 = expression.Substring(temp, j - temp);
                        expression = expression.Replace(temp_3, temp_2.ToString());
                    }
                    else
                    {
                        for (i = temp + 1; i < expression.Length && (expression[i] == '.' || expression[i] >= '0' && expression[i] <= '9');)
                            i++;
                        temp_1 = expression.Substring(temp + 1, i - temp - 1);
                        temp_2 = Math.Sqrt((Convert.ToDouble(temp_1)));
                        temp_3 = expression.Substring(temp, i - temp);
                        expression = expression.Replace(temp_3, temp_2.ToString());
                    }
                }//开根
                for (; expression.IndexOf("lg") >= 0;)
                {
                    string temp_1, temp_3;
                    double temp_2;
                    int temp = expression.IndexOf("lg");
                    int x = new int(), j = temp + 2;
                    while (j < expression.Length)
                    {
                        if (expression[j] == '(')
                            x++;
                        else if (expression[j] == ')')
                            x--;
                        if (x == 0)
                            break;
                        j++;
                    }
                    temp_1 = expression.Substring(temp + 2, j - temp - 1);
                    temp_2 = Math.Log10(Calculate(temp_1));
                    temp_3 = expression.Substring(temp, j - temp);
                    expression = expression.Replace(temp_3, temp_2.ToString());
                }//lg函数
                for (; expression.IndexOf("ln") >= 0;)
                {
                    string temp_1, temp_3;
                    double temp_2;
                    int temp = expression.IndexOf("ln");
                    int x = new int(), j = temp + 2;
                    while (j < expression.Length)
                    {
                        if (expression[j] == '(')
                            x++;
                        else if (expression[j] == ')')
                            x--;
                        if (x == 0)
                            break;
                        j++;
                    }
                    temp_1 = expression.Substring(temp + 2, j - temp - 1);
                    temp_2 = Math.Log(Calculate(temp_1));
                    temp_3 = expression.Substring(temp, j - temp);
                    expression = expression.Replace(temp_3, temp_2.ToString());
                }//ln函数
                for (; expression.IndexOf("log") >= 0;)
                {
                    string temp_1, temp_3, temp_4;
                    double temp_2;
                    int temp = expression.IndexOf("log");
                    int x = new int(), j = temp + 3;
                    while (j < expression.Length)
                    {
                        if (expression[j] == '(')
                            x++;
                        else if (expression[j] == ')')
                            x--;
                        if (x == 0)
                            break;
                        j++;
                    }
                    int i = j + 1;
                    while (i < expression.Length)
                    {
                        if (expression[i] == '(')
                            x++;
                        else if (expression[i] == ')')
                            x--;
                        if (x == 0)
                            break;
                        i++;
                    }
                    temp_1 = expression.Substring(temp + 3, j - temp - 2);
                    temp_4 = expression.Substring(j + 1, i - j);
                    temp_2 = Math.Log(Calculate(temp_1), Calculate(temp_4));
                    temp_3 = expression.Substring(temp, i - temp + 1);
                    expression = expression.Replace(temp_3, temp_2.ToString());
                }//log函数
                if (expression.IndexOf("-") >= 0)
                {
                    if (expression.IndexOf("-") == 0)
                        expression = "0" + expression;
                    for (int i = 0; expression.IndexOf("-", i) > 0;)
                    {
                        if (Isoperator(expression[expression.IndexOf("-", i) - 1]))
                        {
                            char temp = expression[expression.IndexOf("-", i) - 1];
                            switch (temp)
                            {
                                case '+':
                                    expression = expression.Insert(expression.IndexOf("-", i), "0");
                                    break;
                                case '(':
                                    expression = expression.Insert(expression.IndexOf("-", i), "0");
                                    break;
                                case '-':
                                    expression = expression.Replace("--", "+");
                                    break;
                                case '*':
                                    expression = expression.Insert(expression.IndexOf("-", i), "(0");
                                    int j = expression.IndexOf("-", i) + 1;
                                    while (true)
                                    {
                                        j++;
                                        if ((j >= expression.Length) || Isoperator(expression[j]))
                                            break;
                                    }
                                    expression = expression.Insert(j, ")");
                                    break;
                                case '/':
                                    expression = expression.Insert(expression.IndexOf("-", i), "(0");
                                    int r = expression.IndexOf("-", i) + 1;
                                    while (true)
                                    {
                                        r++;
                                        if ((r >= expression.Length) || Isoperator(expression[r]))
                                            break;
                                    }
                                    expression = expression.Insert(r, ")");
                                    break;
                                default:
                                    break;
                            }
                        }
                        i = expression.IndexOf('-', i) + 1;
                    }
                }//干掉那些负号的影响！
                textBox2.Text = Calculate(expression).ToString();
            }//常规计算
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyStates == Keyboard.GetKeyStates(Key.D6) && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                ___Click(sender, null);
            }
            if (e.KeyStates == Keyboard.GetKeyStates(Key.D5) && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                __5_Click(sender, null);
            }
            if (e.KeyStates == Keyboard.GetKeyStates(Key.D9) && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                __1_Click(sender, null);
            }
            if (e.KeyStates == Keyboard.GetKeyStates(Key.D0) && Keyboard.Modifiers == ModifierKeys.Shift)
            {
                __2_Click(sender, null);
            }
            switch (e.Key)
            {
                case Key.Delete:
                    Delete_Click(sender, null);
                    break;
                case Key.Back:
                    Backspace_Click(sender, null);
                    break;
                case Key.Enter:
                    Equal_Click(sender, null);
                    break;
                case Key.NumPad0:
                    _0_Click(sender, null);
                    break;
                case Key.NumPad1:
                    Button1_Click(sender, null);
                    break;
                case Key.NumPad2:
                    Button2_Click(sender, null);
                    break;
                case Key.NumPad3:
                    Button3_Click(sender, null);
                    break;
                case Key.NumPad4:
                    Button4_Click(sender, null);
                    break;
                case Key.NumPad5:
                    Button5_Click(sender, null);
                    break;
                case Key.NumPad6:
                    Button6_Click(sender, null);
                    break;
                case Key.NumPad7:
                    Button7_Click(sender, null);
                    break;
                case Key.NumPad8:
                    Button8_Click(sender, null);
                    break;
                case Key.NumPad9:
                    Button9_Click(sender, null);
                    break;
                case Key.Add:
                    Button_plus_Click(sender, null);
                    break;
                case Key.Subtract:
                    Buttom_subtraction_Click(sender, null);
                    break;
                case Key.Multiply:
                    CHENGFA_Click(sender, null);
                    break;
                case Key.Divide:
                    CHUFA_Click(sender, null);
                    break;
                case Key.X:
                    X_Click(sender, null);
                    break;
                case Key.Decimal:
                    Point_Click(sender, null);
                    break;
                default:
                    break;
            }
        }//键盘输入 有个超级大的问题！！

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("作者~~~杜渡~李政~（磊博士！)\n\t\t\t\t2017 O(∩_∩)O", "( •̀ ω •́ )y", MessageBoxButton.OK, MessageBoxImage.Information);
        }//我就是搞事情
    }
}
    
