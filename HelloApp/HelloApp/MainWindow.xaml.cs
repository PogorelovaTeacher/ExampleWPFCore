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

namespace HelloApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Key> _illegallyKeys = new List<Key> { Key.D0, Key.D1, Key.D2, Key.D3, Key.D4, Key.D5, Key.D6, Key.D7, Key.D8, Key.D9,
                                   Key.NumPad0, Key.NumPad1, Key.NumPad2, Key.NumPad3, Key.NumPad4, Key.NumPad5, Key.NumPad6, Key.NumPad7,
                                   Key.NumPad8, Key.NumPad9, Key.Multiply, Key.Add, Key.Subtract, Key.Decimal, Key.Divide, Key.OemBackslash,
                                   Key.Oem1, Key.Oem3, Key.Oem5, Key.Oem6, Key.OemMinus, Key.OemPlus, Key.OemOpenBrackets, Key.OemQuestion,
                                   Key.OemQuotes, Key.OemComma, Key.OemPeriod};
        char passwordSymbol;
        public MainWindow()
        {
            InitializeComponent();
            Button myButton = new Button();
            myButton.Width = 200;
            myButton.Height = 30;
            myButton.Content = "Пользовательская Кнопка";
            myButton.HorizontalAlignment = HorizontalAlignment.Center;
            myButton.VerticalAlignment = VerticalAlignment.Top;
            myButton.Margin = new Thickness(10);
            myButton.Background = new SolidColorBrush(Colors.Aqua);
            //stackPanelExample.Children.Add(myButton);
            uniformGridExample.Children.Add(myButton);
            //MainGrid.Children.Add(myButton);
            //Grid.SetRow(myButton, 3);
            //Grid.SetColumn(myButton, 1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("First project on WPF-Core");
            Classes.Phone phone = new Classes.Phone();
        }

        private void TextBoxButton_Click(object sender, RoutedEventArgs e)
        {
            string text = MessageTextBox.Text;
            if (text!="")
            {
                MessageBox.Show(text);
            }
            
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("wow");
        }

        private void MessageTextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (Char.IsDigit(e.Text, 0) || Char.IsSymbol(e.Text, 0) || Char.IsPunctuation(e.Text, 0)) e.Handled = true;
        }

        private void LetterTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.Key.ToString());
            KeyValidate(_illegallyKeys, ref e);
        }

        private void KeyValidate(IEnumerable<Key> illegallyKeys, ref KeyEventArgs keyToValidate) =>
            keyToValidate.Handled = illegallyKeys.Contains(keyToValidate.Key);

        private void checkBoxShowPassword_Click(object sender, RoutedEventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox.IsChecked.Value)
            {
                passwordTextBox.Text = rightPasswordBox.Password;
                rightPasswordBox.Visibility = Visibility.Hidden;
                passwordTextBox.Visibility = Visibility.Visible;
            }
            else
            {
                rightPasswordBox.Password = passwordTextBox.Text;
                passwordTextBox.Visibility = Visibility.Hidden;
                rightPasswordBox.Visibility = Visibility.Visible;
            }
        }
    }

    public class Phone2
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return $"Смартфон {this.Name}; цена: {this.Price}";
        }
    }
}
