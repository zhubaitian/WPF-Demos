using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace DispatcherAndUIThread
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }


        private void ModifyUIDirectly()

        {

            // 模拟一些工作正在进行

            Thread.Sleep(TimeSpan.FromSeconds(2));

            lblHello.Content = "欢迎你光临WPF的世界,Dispatcher";


        }

        private void ModifyUIByDispatcher()

        {

            // 模拟一些工作正在进行

            Thread.Sleep(TimeSpan.FromSeconds(2));

            //lblHello.Content = "欢迎你光临WPF的世界,Dispatcher";

            this.Dispatcher.Invoke(DispatcherPriority.Normal, (ThreadStart)delegate () {

                lblHello.Content = "欢迎你光临WPF的世界,Dispatche  同步方法 ！！";

            });

        }

        private void BtnThread_Click(object sender, RoutedEventArgs e)
        {
            Thread threadModifyUIDirectly = new Thread(ModifyUIDirectly);
            threadModifyUIDirectly.Start();
        }

        private void BtnInvoke_Click(object sender, RoutedEventArgs e)
        {

            Thread threadModifyUIByDispatcher = new Thread(ModifyUIByDispatcher);
            threadModifyUIByDispatcher.Start();
        }

        private void BtnBeginInvoke_Click(object sender, RoutedEventArgs e)
        {
            new Thread(() =>
            {
                Application.Current.Dispatcher.BeginInvoke(DispatcherPriority.Normal, new Action(() => {
                        Thread.Sleep(TimeSpan.FromSeconds(2));
                        this.lblHello.Content = "欢迎你光临WPF的世界,Dispatche 异步方法！！" + DateTime.Now.ToString();

                    }));

            }).Start();

        }
    }
}
