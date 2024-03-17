using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace HelloApp.Classes
{
    public class Phone
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Image ImagePhone { get; set; }
        public Phone()
        {
            ImagePhone = new Image();
            var uriSource = new Uri("/Images/microscope.png", UriKind.RelativeOrAbsolute);
            ImagePhone.Source = new BitmapImage(uriSource);
            //Image.Source =  "/Images/microscope.png";
        }
        public override string ToString()
        {
            return $"Смартфон {Name}, цена: {Price}";
        }
    }
}
