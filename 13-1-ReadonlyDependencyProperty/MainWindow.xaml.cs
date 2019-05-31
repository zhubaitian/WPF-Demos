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
using System.Windows.Threading;

namespace ReadonlyDependencyProperty
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //用SetValue的方法来设置值
            DispatcherTimer timer =
                new DispatcherTimer(TimeSpan.FromSeconds(1),
                                    DispatcherPriority.Normal,
                                    (object sender, EventArgs e) =>
                                    {
                                        int newValue = Counter == int.MaxValue ? 0 : Counter + 1;
                                        SetValue(counterKey, newValue);
                                    },
                                    Dispatcher);
        }

        //属性包装器，只提供GetValue
        public int Counter
        {
            get { return (int)GetValue(counterKey.DependencyProperty); }
        }

        //用RegisterReadOnly来代替Register来注册一个只读的依赖属性
        private static readonly DependencyPropertyKey counterKey =
            DependencyProperty.RegisterReadOnly("Counter",
                                                typeof(int),
                                                typeof(MainWindow),
                                                new PropertyMetadata(0));
    }
}
