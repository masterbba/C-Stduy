using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace FollowTheRainbow
{
    class FollowTheRainbow : Window
    {
        [STAThread]
        static void Main()
        {
            Application app = new Application();
            app.Run(new FollowTheRainbow());
        }
    }
}