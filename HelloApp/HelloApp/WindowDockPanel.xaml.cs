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
    /// Логика взаимодействия для WindowDockPanel.xaml
    /// </summary>
    public partial class WindowDockPanel : Window
    {
        public WindowDockPanel()
        {
            InitializeComponent();

            RadioButton rb = new RadioButton { IsChecked = true, GroupName = "Languages", Content = "JavaScript" };
            rb.Checked += RadioButton_Checked;
            myCanvas.Children.Add(rb);

            ToolTip toolTip = new ToolTip();
            StackPanel stackPanel = new StackPanel();
            stackPanel.Children.Add(new TextBlock { Text = "Это вторая кнопка", FontSize = 16 });
            stackPanel.Children.Add(new TextBlock { Text = ":-)", FontSize = 18, FontWeight = FontWeights.Bold });
            toolTip.Content = stackPanel;
            ButtonNumberTwo.ToolTip = toolTip;
        }

        private void MessageButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Press MessageButton");
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CB1.Content.ToString() + " выбран");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CB1.Content.ToString() + " не выбран");
        }

        private void CheckBox_Indeterminate(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(CB1.Content.ToString() + " в промежуточном состоянии");
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            MessageBox.Show(radioButton.Content.ToString() + " checked");
        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {
            RadioButton radioButton = (RadioButton)sender;
            MessageBox.Show(radioButton.Content.ToString() + " checked group: "+ radioButton.GroupName.ToString());
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            testPopup.IsOpen = true;
        }

        private void Expander_Expanded(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Выберите ткани");
        }

        private void Expander_Collapsed(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Заказ отправлен на обработку");
        }
    }
}
