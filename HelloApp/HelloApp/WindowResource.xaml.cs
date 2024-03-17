using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace HelloApp
{
    /// <summary>
    /// Логика взаимодействия для WindowResource.xaml
    /// </summary>
    public partial class WindowResource : Window
    {
        int CountClick = 0;
        public WindowResource()
        {
            InitializeComponent();
            mainGrid.Background = (Brush)TryFindResource("RedStyle");

            
            LinearGradientBrush linearGradient = new LinearGradientBrush();
            linearGradient.GradientStops.Add(new GradientStop(Colors.Red, 0.5));
            linearGradient.GradientStops.Add(new GradientStop(Colors.Yellow, 0));
            linearGradient.GradientStops.Add(new GradientStop(Colors.Blue, 1));
            Resources.Add("BRYStyle", linearGradient);
            Resources.MergedDictionaries.Add(new ResourceDictionary() { Source = new Uri("pack://application:,,,/Resources/DictionaryBrushStyles.xaml") });
        }

        private void but1_Click(object sender, RoutedEventArgs e)
        {
            but1.Foreground = (Brush)TryFindResource("LineGragietnStyle");
            //but1.Background = (Brush)TryFindResource("Redtyle");
            but1.SetResourceReference(Button.BackgroundProperty, "BRYStyle");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show(sender.ToString() + "\n" + e.Source.ToString());
            
            Button button = (Button)sender;
            
            button.Content = ++CountClick;
        }

        private void btClearBinding_Click(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearBinding(TextBoxRecipient, TextBox.TextProperty);
        }

        private void btSetBinding_Click(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.ElementName = "textBoxSource";
            binding.Path = new PropertyPath("Text");
            binding.UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged;
            TextBoxRecipient.SetBinding(TextBox.TextProperty, binding);
        }

        private void btChangeSource_Click(object sender, RoutedEventArgs e)
        {
            Phone1 phone = (Phone1)Resources["Telephon"];
            phone.Name = "ASUS";
        }
    }
}
