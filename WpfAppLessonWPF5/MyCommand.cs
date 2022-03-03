using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfAppLessonWPF5
{
    internal class MyCommand
    {
        public static RoutedUICommand Exit { get; set; }
        static MyCommand()
        {
            InputGestureCollection input = new InputGestureCollection();
            input.Add( new KeyGesture(Key.E, ModifierKeys.Control, "Ctrl+E") );
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCommand), input);
        }
    }
}
