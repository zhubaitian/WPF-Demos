using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using System.Windows;

 

namespace DependencyProperyValidation.Models

{

    public class SimpleDP : DependencyObject
    {

        public static readonly DependencyProperty ValidDPProperty =

            DependencyProperty.Register("ValidDP", typeof(int), typeof(SimpleDP),

                new FrameworkPropertyMetadata(0,

                    FrameworkPropertyMetadataOptions.None,

                    new PropertyChangedCallback(OnValueChanged),

                    new CoerceValueCallback(CoerceValue)),

                    new ValidateValueCallback(IsValidValue));



        public int ValidDP

        {

            get { return (int)GetValue(ValidDPProperty); }

            set { SetValue(ValidDPProperty, value); }

        }



        private static void OnValueChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)

        {

            Console.WriteLine("当属性值的OnValueChanged方法被调用，属性值为： {0}", e.NewValue);

        }



        private static object CoerceValue(DependencyObject d, object value)

        {
            if ((int)value > 10)
            {
                value = 10;
            }
            Console.WriteLine("当属性值的CoerceValue方法被调用，属性值强制为： {0}", value);
    
            return value;

        }



        private static bool IsValidValue(object value)

        {

            Console.WriteLine("当属性值的IsValidValue方法被调用，对属性值进行验证，返回bool值，如果返回True表示严重通过，否则会以异常的形式抛出： {0}", value);

            return true;

        }

    }

}