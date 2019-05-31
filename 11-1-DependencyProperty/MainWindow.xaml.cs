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

namespace DependencyPropertyDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //实例化类
            Student stu = new Student();
            //给依赖属性赋值
            //stu.SetValue(Student.NameProperty, "dfsdfsd");
            //获取依赖属性的值
            //testTB.Text = stu.GetValue(Student.NameProperty).ToString();

            this.DataContext = stu;
        }
    }

    public class Student : DependencyObject
    {
        //声明一个静态只读的DependencyProperty字段
        public static readonly DependencyProperty NameProperty;

        static Student()
        {
            //注册我们定义的依赖属性Name
            NameProperty = DependencyProperty.Register("NameProp", typeof(string), typeof(Student),
                new PropertyMetadata("名称", OnValueChanged));
        }
        private static void OnValueChanged(DependencyObject o, DependencyPropertyChangedEventArgs e)
        {
            //当值改变时，我们可以在此做一些逻辑处理
            Console.WriteLine("Value changes, new Name:" + e.NewValue);
        }

        //属性包装器，通过它来读取和设置我们刚才注册的依赖属性
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
    }
}
