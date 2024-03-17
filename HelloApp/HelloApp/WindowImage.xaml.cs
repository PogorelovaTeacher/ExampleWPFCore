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
    /// Логика взаимодействия для WindowImage.xaml
    /// </summary>
    public partial class WindowImage : Window
    {
        public WindowImage()
        {
            InitializeComponent();
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //grayImage.Source = ((Image)sender).Source;
            var uriSource = new Uri(((Image)sender).Source.ToString(), UriKind.RelativeOrAbsolute);
            FormatConvertedBitmap fcb = new FormatConvertedBitmap(new BitmapImage(uriSource), PixelFormats.Gray32Float, null, 0);
            grayImage.Source = fcb;
            //MessageBox.Show(((Image)sender).Source.ToString());
        }
    }
}
