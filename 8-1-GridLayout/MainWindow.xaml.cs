using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GridLayout
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

        private void btnAddByCode_Click(object sender, RoutedEventArgs e)
        {
            UniformGrid wp = new UniformGrid();

            //把wp添加为窗体的子控件

            this.Content = wp;

            wp.Margin = new Thickness(0, 0, 0, 0);

            wp.Background = new SolidColorBrush(Colors.Red);

            //遍历增加Rectangles

            TextBlock block;

            for (int i = 0; i <= 10; i++)

            {

                block = new TextBlock();

                block.Text = string.Format("第{0}个", i);

                wp.Children.Add(block);

            }



        }
   
    }
}
