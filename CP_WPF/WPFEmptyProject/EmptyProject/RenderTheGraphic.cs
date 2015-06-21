using System;
using System.Windows;

namespace RenderTheGraphic
{
    class RenderToGraphic : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new RenderToGraphic());
        }

        public RenderToGraphic()
        {
            Title = "Render The Graphic";
            SimpleEllipse elips = new SimpleEllipse();
            Content = elips;
            elips.Height = 200;
            elips.Width = 300;
            elips.HorizontalAlignment = HorizontalAlignment.Right;
            elips.VerticalAlignment = VerticalAlignment.Bottom;
        }
    }
}