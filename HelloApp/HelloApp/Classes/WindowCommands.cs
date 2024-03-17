using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace HelloApp.Classes
{
    public class WindowCommands
    {
        public static RoutedCommand Exit { get; set; }
        static WindowCommands()
        {
            Exit = new RoutedCommand("Exit", typeof(WindowCommand));
        }

        //public void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
        //{
        //    using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
        //    {
        //        writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
        //        DateTime.Now.ToLongTimeString());
        //        writer.Flush();
        //    }

        //    System.Windows.Application.Current.Windows[0].Close();
        //}
    }
}
