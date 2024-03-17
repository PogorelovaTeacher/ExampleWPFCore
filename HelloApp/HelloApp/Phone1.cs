using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloApp
{
    public class Phone1: INotifyPropertyChanged
    {
        private string name;
        private int price;

        public string Name 
        { 
            get => name; 
            set
            {
                name = value;
                OnPropertyChanged("Name");
            }
        }

        public int Price
        {
            get => price;
            set
            {
                price = value;
                OnPropertyChanged("Price");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public override string ToString()
        {
            return $"Смартфон {Name}, цена: {Price}";
        }
        private void OnPropertyChanged([CallerMemberName] string v = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(v));
            }
        }
    }
}
