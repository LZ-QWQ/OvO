using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;
using System.Windows.Controls;
using System.Windows.Forms;

namespace 星火杯
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : System.Windows.Application
    {
        public long Add(long a, long b)
        {
            return a + b;
        }

        public long Minus(long a, long b)
        {
            return a - b;
        }

        public long Multiply(long a, long b)
        {
            return a * b;
        }

        public double Add_d(double a, double b)
        {
            return a + b;
        }

        public double Minus_d(double a, double b)
        {
            return a - b;
        }

        public double Multiply_d(double a, double b)
        {
            return a * b;
        }

        public double Divide_d(double a, double b)
        {
            return a / b;
        }

        public double Nothing_d(double a)
        {
            return a;
        }

        public long Nothing(long a)
        {
            return a;
        }

    } 
}
