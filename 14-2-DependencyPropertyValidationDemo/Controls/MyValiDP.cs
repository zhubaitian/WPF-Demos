using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows;

namespace DependencyPropertyValidationDemo.Controls
{
    // 因为需要在xaml中用到MyValiDP，所以不能直接从DependencyObject继承。 
    class MyValiDP : System.Windows.Controls.Control

    {

        //注册Current依赖属性，并添加PropertyChanged、CoerceValue、ValidateValue的回调委托
        public static readonly DependencyProperty CurrentValueProperty = DependencyProperty.Register(
            "CurrentValue",
            typeof(double),
            typeof(MyValiDP),
            new FrameworkPropertyMetadata(

                Double.NaN,

                FrameworkPropertyMetadataOptions.None,

                new PropertyChangedCallback(OnCurrentValueChanged),

                new CoerceValueCallback(CoerceCurrentValue)

            ),

            new ValidateValueCallback(IsValidValue)

        );



        //属性包装器，通过它来暴露Current的值

        public double CurrentValue

        {

            get { return (double)GetValue(CurrentValueProperty); }

            set { SetValue(CurrentValueProperty, value); }

        }



        //注册Min依赖属性，并添加PropertyChanged、CoerceValue、ValidateValue的回调委托

        public static readonly DependencyProperty MinValueProperty = DependencyProperty.Register(

        "MinValue",

        typeof(double),

        typeof(MyValiDP),

        new FrameworkPropertyMetadata(

            double.NaN,

            FrameworkPropertyMetadataOptions.None,

            new PropertyChangedCallback(OnMinValueChanged),

            new CoerceValueCallback(CoerceMinValue)

        ),

        new ValidateValueCallback(IsValidValue));



        //属性包装器，通过它来暴露Min的值

        public double MinValue

        {

            get { return (double)GetValue(MinValueProperty); }

            set { SetValue(MinValueProperty, value); }

        }



        //注册Max依赖属性，并添加PropertyChanged、CoerceValue、ValidateValue的回调委托

        public static readonly DependencyProperty MaxValueProperty = DependencyProperty.Register(

            "MaxValue",

            typeof(double),

            typeof(MyValiDP),

            new FrameworkPropertyMetadata(

                double.NaN,

                FrameworkPropertyMetadataOptions.None,

                new PropertyChangedCallback(OnMaxValueChanged),

                new CoerceValueCallback(CoerceMaxValue)

            ),

            new ValidateValueCallback(IsValidValue)

        );



        //属性包装器，通过它来暴露Max的值

        public double MaxValue

        {

            get { return (double)GetValue(MaxValueProperty); }

            set { SetValue(MaxValueProperty, value); }

        }



        //在CoerceCurrent加入强制判断赋值

        private static object CoerceCurrentValue(DependencyObject d, object value)

        {

            MyValiDP g = (MyValiDP)d;

            double current = (double)value;

            if (current < g.MinValue) current = g.MinValue;

            if (current > g.MaxValue) current = g.MaxValue;

            return current;

        }





        //当Current值改变的时候，调用Min和Max的CoerceValue回调委托

        private static void OnCurrentValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)

        {

            d.CoerceValue(MinValueProperty);

            d.CoerceValue(MaxValueProperty);

        }



        //当OnMin值改变的时候，调用Current和Max的CoerceValue回调委托

        private static void OnMinValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)

        {

            d.CoerceValue(MaxValueProperty);

            d.CoerceValue(CurrentValueProperty);

        }



        //在CoerceMin加入强制判断赋值

        private static object CoerceMinValue(DependencyObject d, object value)

        {

            MyValiDP g = (MyValiDP)d;

            double min = (double)value;

            if (min > g.MaxValue) min = g.MaxValue;

            return min;

        }



        //在CoerceMax加入强制判断赋值

        private static object CoerceMaxValue(DependencyObject d, object value)

        {

            MyValiDP g = (MyValiDP)d;

            double max = (double)value;

            if (max < g.MinValue) max = g.MinValue;

            return max;

        }

        //当Max值改变的时候，调用Min和Current的CoerceValue回调委托

        private static void OnMaxValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            d.CoerceValue(MinValueProperty);

            d.CoerceValue(CurrentValueProperty);

        }



        //验证value是否有效，如果返回True表示验证通过，否则会提示异常

        public static bool IsValidValue(object value)

        {

            Double v = (Double)value;

            return (!v.Equals(Double.NegativeInfinity) && !v.Equals(Double.PositiveInfinity));

        }

    }
}
