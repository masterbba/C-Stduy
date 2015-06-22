using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Controls;

namespace ClickTheButton
{
    public class ClickTheButton : Window
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ClickTheButton());
        }

        public ClickTheButton()
        {
            Title = "Click The Button";

            Button btn = new Button();
            btn.Content = "_Click me, please!";
            btn.Click += ButtonOnClick;

            Content = btn;

            //extra code 

            //btn.Focus();
            //btn.IsDefault = true;
            //btn.IsCancel = true;
            //btn.ClickMode = ClickMode.Hover;
            btn.Margin = new Thickness(96);
            //btn.HorizontalContentAlignment = HorizontalAlignment.Right;
            //btn.VerticalContentAlignment = VerticalAlignment.Bottom;
            //btn.Padding = new Thickness(96);
            //btn.HorizontalAlignment = HorizontalAlignment.Center;
            //btn.VerticalAlignment = VerticalAlignment.Center;
            //btn.Height = 100;
            //btn.Width = 100;

            SizeToContent = SizeToContent.WidthAndHeight;

            btn.FontSize = 48;
            btn.FontFamily = new FontFamily("Times New Roman");
            btn.Background = Brushes.AliceBlue;
            btn.Foreground = Brushes.DarkSalmon;
            btn.BorderBrush = Brushes.Magenta;
        }

        void ButtonOnClick( object sender, RoutedEventArgs e )
        {
            MessageBox.Show("The Button has been Clicked and all is well.", Title);
        }
    }
}