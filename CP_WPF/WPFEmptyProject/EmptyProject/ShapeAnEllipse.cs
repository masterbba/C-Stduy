using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace ShapeAnEllipse
{
    public class ShapeAnEllipse : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new ShapeAnEllipse());
        }

        public ShapeAnEllipse()
        {
            Title = "Shape An Ellipse";

            Ellipse elips = new Ellipse();
            elips.Fill = Brushes.Black;
            elips.StrokeThickness = 24;
            elips.Stroke = new LinearGradientBrush(Colors.CadetBlue, Colors.Chocolate, new Point(1, 0), new Point(0, 1));

            Content = elips;

            //extra code

            elips.Width = 300;
            elips.Height = 300;

            elips.HorizontalAlignment = HorizontalAlignment.Left;
            elips.VerticalAlignment = VerticalAlignment.Top;
        }
    }
}