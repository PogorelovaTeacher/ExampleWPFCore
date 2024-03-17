using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;

namespace HelloApp.Classes
{
    public class PhoneDependency: DependencyObject
    {
        public static readonly DependencyProperty NameProperty;
        public static readonly DependencyProperty PriceProperty;

        static PhoneDependency()
        {
            NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(PhoneDependency));
            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            //PriceProperty = DependencyProperty.Register("Price", 
            //                                            typeof(double), 
            //                                            typeof(PhoneDependency), 
            //                                            metadata, 
            //                                            new ValidateValueCallback(ValidateValue));
            PriceProperty = DependencyProperty.Register("Price",
                                                       typeof(double),
                                                       typeof(PhoneDependency),
                                                       metadata);
        }

        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            double currencyValue = (double)baseValue;
            if (currencyValue>500000.0)
            {
                return 500000.0;
            }
            if (currencyValue<0.0)
            {
                return 0.0;
            }
            return currencyValue;
        }

        private static bool ValidateValue(object value)
        {
            double currentValue = (double)value;
            return currentValue >= 0;
        }

        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public double Price
        {
            get { return (double)GetValue(PriceProperty); }
            set { SetValue(PriceProperty, value); }
        }
    }
}
