using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HelloApp.Classes;

namespace HelloApp
{
    /// <summary>
    /// Логика взаимодействия для WindowDataGrid.xaml
    /// </summary>
    public partial class WindowDataGrid : Window
    {
        Color color;
        List<Phone1> phones = new List<Phone1>
        {
            new Phone1{Name="tel1", Price=12000},
            new Phone1{Name="tel2", Price=14000}
        };
        public WindowDataGrid()
        {
            InitializeComponent();
            dataGridExample1.ItemsSource = phones;
            phonesGrid.ItemsSource = phones;
            gridPhone.DataContext = new PhoneDependency { Name = "white telephon", Price = 30000.5 };
            //gridPhone.DataContext = new Phone { Name = "white telephon", Price = 30000 };

            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 30;
            myButton.Content = "Пользовательская Кнопка";
            myButton.HorizontalAlignment = HorizontalAlignment.Center;
            myButton.VerticalAlignment = VerticalAlignment.Bottom;
            myButton.Margin = new Thickness(10);
            myButton.Background = new SolidColorBrush(Colors.Aqua);

            gridPhone.Children.Add(myButton);
            Grid.SetRow(myButton, 3);
            Grid.SetColumn(myButton, 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phone1 phone = (Phone1)phonesGrid.CurrentItem;
            MessageBox.Show(phone.Name);
        }

        private void sliderExample_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
            //MessageBox.Show(e.NewValue.ToString());
        }

        private void ColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            color = Color.FromRgb((byte)slColorR.Value, (byte)slColorG.Value, (byte)slColorB.Value);
            spColor.Background = new SolidColorBrush(color);
        }

        private void calendarExample_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            foreach (var item in calendarExample.SelectedDates)
            {
                MessageBox.Show(item.Date.ToShortDateString().ToString());
            }    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            PhoneDependency phone = (PhoneDependency)gridPhone.DataContext;
            //Phone phone = (Phone)gridPhone.DataContext;
            MessageBox.Show(phone.Price.ToString());
        }
    }
}
