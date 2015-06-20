using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;

namespace DisplaySomeText
{
    public class DisplaySomeText : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new DisplaySomeText());
        }

        public DisplaySomeText()
        {
            Title = "DisplaySomeText";
            //Content = "Content can be simple text!";
            Content = "\nContent can be simple text!";

            //FontFamily = new FontFamily("Comic Sans MS");
            //FontSize = 43;

            //FontFamily = new FontFamily("Times New Roman Bold Italic");
            //FontSize = 32;

            /*FontFamily = new FontFamily("Times New Roman");
            FontSize = 32;
            FontStyle = FontStyles.Italic;
            FontWeight = FontWeights.Bold;*/

            FontFamily = new FontFamily("Times New Roman");
            FontSize = 32;
            FontStyle = FontStyles.Oblique;
            FontWeight = FontWeights.Bold;

            Brush brush = new LinearGradientBrush(Colors.Black, Colors.White, new Point(0, 0), new Point(1, 1));
            //Background = brush;
            Foreground = brush;

            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.NoResize;

            BorderBrush = Brushes.SaddleBrown;
            BorderThickness = new Thickness(25, 50, 75, 100);

            Content = Math.PI;
            Content = DateTime.Now;
            Content = EventArgs.Empty;
            Content = new int[57];
        }
    }
}