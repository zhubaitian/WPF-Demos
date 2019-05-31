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

namespace WrapPanelLayout
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            WrapPanel wp = new WrapPanel();

            //把wp添加为窗体的子控件

            this.Content = wp;

            wp.Margin = new Thickness(0, 0, 0, 0);

            wp.Background = new SolidColorBrush(Colors.White);

            //遍历增加TextBlock

            TextBlock block;

            for (int i = 0; i <= 10; i++)

            {

                block = new TextBlock();

                block.Text = "后台代码添加控件：" + i.ToString();

                block.Margin = new Thickness(10, 10, 10, 10);

                block.Width = 160;

                block.Height = 30;

                wp.Children.Add(block);

            }
        }
    }
}
