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
using DependencyPropertyValidationDemo.Controls;

namespace DependencyPropertyValidationDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            myValiDP1.CurrentValue = 100;
        }

        private void sliderMin_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            //设置Current的值
            myValiDP1.CurrentValue = (int)sliderMin.Value;
        }

        private void sliderMax_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            //设置Current的值
            myValiDP1.CurrentValue = (int)sliderMax.Value;

        }
    }
}
