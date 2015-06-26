using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DesignAButton
{
    class DesignAButton : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new DesignAButton());
        }

        public DesignAButton()
        {
            Title = "Design a Button";

            //Make Button, set Content
            Button btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.Click += ButtonOnClick;
            Content = btn;

            //Make StackPanel, Set Content to Button
            StackPanel stack = new StackPanel();
            btn.Content = stack;

            //Add Polyline in StackPanel
            stack.Children.Add(ZigZag(10));

            //Add Image In StackPanel
            /*Uri uri = new Uri("pack://application:,,BOOK06.ICO");
            BitmapImage bitmap = new BitmapImage(uri);
            Image img = new Image();
            img.Margin = new Thickness(0, 10, 0, 0);
            img.Source = bitmap;
            img.Stretch = Stretch.None;
            stack.Children.Add(img);*/

            //Add Label in StackPanel
            Label lbl = new Label();
            lbl.Content = "_Read book!";
            lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
            stack.Children.Add(lbl);

            //add another PolyLine in StackPanel
            stack.Children.Add(ZigZag(0));
        }

        Polyline ZigZag( int offset )
        {
            Polyline poly = new Polyline();
            poly.Stroke = SystemColors.ControlTextBrush;
            poly.Points = new PointCollection();

            for( int x = 0; x <= 100; x += 10)
            {
                poly.Points.Add(new Point(x, (x+offset)%20));
            }

            return poly;
        }

        void ButtonOnClick( object sender, RoutedEventArgs args )
        {
            MessageBox.Show("This button has been clicked", Title);
        }
    }
}