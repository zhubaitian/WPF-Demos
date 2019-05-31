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

namespace ViewBoxLayout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //定义cbStretch与cbStretchDirection的数据源 

        List<StretchHelper> cbStretchList = new List<StretchHelper>();

        List<StretchDirectionHelper> cbStretchDirectionList = new List<StretchDirectionHelper>();


        public MainWindow()
        {
            InitializeComponent();
        }

        private void BindDrp()

        { //填充各ComboBox内容 

            cbStretchList.Add(new StretchHelper() { StretchModeName = "Fill", theStretchMode = Stretch.Fill });

            cbStretchList.Add(new StretchHelper() { StretchModeName = "None", theStretchMode = Stretch.None });

            cbStretchList.Add(new StretchHelper() { StretchModeName = "Uniform", theStretchMode = Stretch.Uniform });

            cbStretchList.Add(new StretchHelper() { StretchModeName = "UniformToFill", theStretchMode = Stretch.UniformToFill });

            cbStretch.ItemsSource = cbStretchList;

            cbStretch.DisplayMemberPath = "StretchModeName";

            cbStretchDirectionList.Add(new StretchDirectionHelper() { StretchDirectionName = "DownOnly", theStretchDirection = StretchDirection.DownOnly });

            cbStretchDirectionList.Add(new StretchDirectionHelper() { StretchDirectionName = "UpOnly", theStretchDirection = StretchDirection.UpOnly });

            cbStretchDirectionList.Add(new StretchDirectionHelper() { StretchDirectionName = "Both", theStretchDirection = StretchDirection.Both });

            cbStretchDirection.ItemsSource = cbStretchDirectionList;

            cbStretchDirection.DisplayMemberPath = "StretchDirectionName";

        }



        private void cbStretchDirection_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {

            if (cbStretchDirection.SelectedItem != null)

            {

                viewBoxTest.StretchDirection = (cbStretchDirection.SelectedItem as StretchDirectionHelper).theStretchDirection;

            }

        }



        private void cbStretch_SelectionChanged(object sender, SelectionChangedEventArgs e)

        {

            if (cbStretch.SelectedItem != null)

            {

                viewBoxTest.Stretch = (cbStretch.SelectedItem as StretchHelper).theStretchMode;

            }

        }



        private void Window_Loaded(object sender, RoutedEventArgs e)

        {

            BindDrp();

        }
    }
    //辅助类StretchHelper 

    public class StretchHelper

    {

        public string StretchModeName { get; set; }

        public Stretch theStretchMode { get; set; }

    }

    //辅助类StretchDirectionHelper 

    public class StretchDirectionHelper

    {

        public string StretchDirectionName { get; set; }

        public StretchDirection theStretchDirection { get; set; }

    }
}
