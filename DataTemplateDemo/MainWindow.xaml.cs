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

namespace DataTemplateDemo
{
    public class Task
    {
        public String TaskName { get; set; }
        public String Description { get; set; }
        public override string ToString()
        {
            return TaskName.ToString();
        }
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public List<Task> Tasks = new List<Task>();
        
        private void InitData()
        {
            Tasks.Add(new Task { TaskName = "Go Home", Description = "Go home tasks" });
            Tasks.Add(new Task { TaskName = "Go to school", Description = "Go to school tasks" });
            listBox1.ItemsSource = Tasks;
            listBox2.ItemsSource = Tasks;
            listBox3.ItemsSource = Tasks;
            listBox4.ItemsSource = Tasks;
        }
        public MainWindow()
        {
            InitializeComponent();
            InitData();
        }
    }
}
