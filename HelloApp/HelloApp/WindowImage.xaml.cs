using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
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
        DrawingAttributes drawingAttributes;
        public WindowImage()
        {
            InitializeComponent();
            drawingAttributes = new DrawingAttributes
            {
                Color = Colors.Red,
                Width = 5,
                Height = 5,
                StylusTip = StylusTip.Ellipse, 
                FitToCurve = true,
                IsHighlighter = false,
                IgnorePressure = true,

            };
            inkCanvasExample.DefaultDrawingAttributes = drawingAttributes;

        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            //grayImage.Source = ((Image)sender).Source;
            var uriSource = new Uri(((Image)sender).Source.ToString(), UriKind.RelativeOrAbsolute);
            FormatConvertedBitmap fcb = new FormatConvertedBitmap(new BitmapImage(uriSource), PixelFormats.Gray32Float, null, 0);
            grayImage.Source = fcb;
            //MessageBox.Show(((Image)sender).Source.ToString());
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if ((sender as RadioButton) .Content.ToString() == "Рисовать")
            {
                inkCanvasExample.EditingMode = InkCanvasEditingMode.Ink;
            }

            else if ((sender as RadioButton) .Content.ToString() == "Удалить")
            {
                inkCanvasExample.EditingMode = InkCanvasEditingMode.EraseByPoint;
            }

            else if ((sender as RadioButton) .Content.ToString() == "Стереть")
            {
                inkCanvasExample.EditingMode = InkCanvasEditingMode.EraseByStroke;
            }

            else if ((sender as RadioButton).Content.ToString() == "Выбрать")
            {
                inkCanvasExample.EditingMode = InkCanvasEditingMode.Select;
            }

            else if ((sender as RadioButton).Content.ToString() == "Остановить операцию")
            {
                inkCanvasExample.EditingMode = InkCanvasEditingMode.None;
            }

        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {
            drawingAttributes.Color = ((SolidColorBrush)(sender as TextBlock).Background).Color;
        }
    }
}
