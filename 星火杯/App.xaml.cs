using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;

namespace 星火杯
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public BigInteger Add(BigInteger a, BigInteger b)
        {
            return a + b;
        }

        public BigInteger Minus(BigInteger a, BigInteger b)
        {
            if (b == 1)
                b = 0;
            return a - b;
        }

        public BigInteger Multiply(BigInteger a, BigInteger b)
        {
            return a * b;
        }

        public double Add_d(double a, double b)
        {
            return a + b;
        }

        public double Minus_d(double a, double b)
        {
            if (b == 1)
                b = 0;
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
