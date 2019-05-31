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

//https://www.cnblogs.com/chillsrc/p/4585630.html

namespace StackPanelLayout
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
            stackPanel.Orientation = Orientation.Horizontal;

        }

        private void StackPanels()

        {

            StackPanel sp = new StackPanel();

            //把sp添加为窗体的子控件

            this.Content = sp;

            sp.Margin = new Thickness(0, 0, 0, 0);

            sp.Background = new SolidColorBrush(Colors.White);

            sp.Orientation = Orientation.Vertical;

            //Button1

            Button b1 = new Button();

            b1.Content = "后台代码，第一个";

            sp.Children.Add(b1);



            //Button2

            Button b2 = new Button();

            b2.Content = "后台代码，第二个";

            sp.Children.Add(b2);



            //Button3

            Button b3 = new Button();

            b3.Content = "后台代码，第三个";

            sp.Children.Add(b3);



        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            StackPanels();
        }
    }
}
