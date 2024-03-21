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
    /// Логика взаимодействия для WindowListBox.xaml
    /// </summary>
    public partial class WindowListBox : Window
    {
        List<Phone1> phones = new List<Phone1>
            {
                new Phone1{Name="tel1", Price=12000},
                new Phone1{Name="tel2", Price=10000},
                new Phone1{Name="tel3", Price=15000}
            };
        public WindowListBox()
        {
            InitializeComponent();
            
            listViewPhones.ItemsSource = phones;
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxLeft.SelectedIndex>-1)
            {
                //listBoxRight.Items.Add(listBoxLeft.SelectedValue);
                for (int i = 0; i < listBoxLeft.SelectedItems.Count; i++)
                {
                    listBoxRight.Items.Add(listBoxLeft.SelectedItems[i]);
                }
                
            }
        }

        private void buttonAddToRight1_Click(object sender, RoutedEventArgs e)
        {
            img.Source = new Phone().ImagePhone.Source;
            
        }

        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            MessageBox.Show(comboBox.SelectedIndex.ToString());
            //MessageBox.Show(((TextBlock)comboBox.SelectedItem).Text);

        }

        private void butNextTab_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                tabControlExample.SelectedItem = tabControlExample.Items[tabControlExample.SelectedIndex + 1];
            }
            catch (ArgumentOutOfRangeException)
            {
                tabControlExample.SelectedIndex = 0;
            }
            
        }

        private void butClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void butNewTab_Click(object sender, RoutedEventArgs e)
        {
            ListBox listBox = new ListBox();
            listBox.ItemsSource = phones;
            tabControlExample.Items.Add(new TabItem
            {
                Header = new TextBlock { Text = "Телефоны"},
                Content = listBox
            });
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem menuItem = (MenuItem)sender;
            MessageBox.Show(menuItem.Header.ToString());
        }

        private void menuCopy_Click(object sender, RoutedEventArgs e)
        {
            Clipboard.SetText(listBoxLeft.SelectedValue.ToString());
        }

        private void menuPaste_Click(object sender, RoutedEventArgs e)
        {
            listBoxLeft.Items.Add(Clipboard.GetText());
        }

        private void menuDelete_Click(object sender, RoutedEventArgs e)
        {
            listBoxLeft.Items.Remove(listBoxLeft.SelectedValue);
        }

        private void butCut_Click(object sender, RoutedEventArgs e)
        {
            menuCopy_Click(sender, e);
            menuDelete_Click(sender, e);
        }

        private void textBoxTelephone_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Space)
            {
                e.Handled = true;
            }
        }

        private void textBoxTelephone_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            int i;
            if (!int.TryParse(e.Text, out i) && e.Text !="-")
            {
                e.Handled = true;
            }
        }

        private void listBoxLeft_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(listBoxLeft, listBoxLeft.Items.CurrentItem.ToString(), DragDropEffects.Copy);
            MessageBox.Show(listBoxLeft.Items.CurrentItem.ToString());
        }

        private void listBoxRight_Drop(object sender, DragEventArgs e)
        {
            listBoxRight.Items.Add(e.Data.GetData(DataFormats.Text));
        }

        private void TextBox_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(textBoxSearch, textBoxSearch.Text, DragDropEffects.Copy);
        }

        private void butNextTab_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(butNextTab, butNextTab.Content, DragDropEffects.Copy);
        }

        private void sp1_Drop(object sender, DragEventArgs e)
        {
            TextBlock textBlock = new TextBlock();
            textBlock.Text = (string)e.Data.GetData(DataFormats.Text);
            sp1.Children.Add(textBlock);

        }

        private void butNextTab_Drop(object sender, DragEventArgs e)
        {
            butNextTab.Content = e.Data.GetData(DataFormats.Text);
        }

        private void img_MouseDown(object sender, MouseButtonEventArgs e)
        {
            DragDrop.DoDragDrop(img, img.Source.ToString(), DragDropEffects.Copy);
        }

        private void imgDrop_Drop(object sender, DragEventArgs e)
        {
            Uri uri = new Uri((string)e.Data.GetData(DataFormats.Text));
            imgDrop.Source = new BitmapImage(uri);
            MessageBox.Show((string)e.Data.GetData(DataFormats.Text));
        }

        private void ComboBox_GotFocus(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(sender.ToString() + "\n" + e.Source.ToString());
        }

       
    }
}
