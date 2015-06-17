using System;
using System.Windows;

namespace SayHello
{
    class SayHello
    {
        [STAThread]
        public static void Main()
        {
            Window win = new Window();
            win.Title = "sayHello";
            win.Show();

            Application app = new Application();
            app.Run();
        }
    }
}