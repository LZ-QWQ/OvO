using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Numerics;
using System.Windows.Controls;
namespace 星火杯
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>

    public partial class App : System.Windows.Application
    {

    }
    public partial class App : Application
    {
        public App()
        {
            Current.DispatcherUnhandledException += Current_DispatcherUnhandledException;
            AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
        }
        void Current_DispatcherUnhandledException(object sender, System.Windows.Threading.DispatcherUnhandledExceptionEventArgs e)
        {
            MessageBox.Show("当前应用程序遇到一些问题", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
            e.Handled = true;//告诉运行时，该异常被处理了，不再作为UnhandledException抛出了。 
        }
        void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            MessageBox.Show("当前应用程序遇到一些问题，操作已经终止", "提示", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
