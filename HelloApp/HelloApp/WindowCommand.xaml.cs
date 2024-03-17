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
using HelloApp.Classes;

namespace HelloApp
{
    /// <summary>
    /// Логика взаимодействия для WindowCommand.xaml
    /// </summary>
    public partial class WindowCommand : Window
    {
        public WindowCommand()
        {
            InitializeComponent();
            ButtonExit.Background = Brushes.Coral;
        }
        private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
            {
                writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
                DateTime.Now.ToLongTimeString());
                writer.Flush();
            }

            Close();
        }

        private void TextBoxLeft_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
