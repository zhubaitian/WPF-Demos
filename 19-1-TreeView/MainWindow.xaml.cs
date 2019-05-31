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

namespace TreeView
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



            Jobs jobs1 = new Jobs();

            jobs1.Add(new Job() { Id = 1, Name = "CEO1" });

            jobs1.Add(new Job() { Id = 2, Name = "CEO2" });

            jobs1.Add(new Job() { Id = 3, Name = "CEO3" });



            Jobs jobs2 = new Jobs();

            jobs2.Add(new Job() { Id = 1, Name = "CEO1" });

            jobs2.Add(new Job() { Id = 2, Name = "CEO2" });

            jobs2.Add(new Job() { Id = 3, Name = "CEO3" });



            Dictionary<string, Jobs> allJob = new Dictionary<string, Jobs>();

            allJob.Add("CEO one", jobs1);

            allJob.Add("CEO two", jobs2);

            //dictree.DataContext = allJob;
            dictree.ItemsSource = allJob;
            //dictree.ItemsSource = jobs1;
        }
    }

    public class Job

    {

        public int Id

        { get; set; }

        public string Name

        { get; set; }

        public string Status

        { get; set; }

    }



    public class Jobs : System.Collections.ObjectModel.ObservableCollection<Job> { }
}
