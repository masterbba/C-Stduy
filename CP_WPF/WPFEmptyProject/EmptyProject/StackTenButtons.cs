using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace StackTenButtons
{
    public class StackTenButtons : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new StackTenButtons());
        }

        public StackTenButtons()
        {
            Title = "Stack Ten Buttons";

            StackPanel stack = new StackPanel();
            Content = stack;

            Random rand = new Random();

            for( int i = 0; i < 10; i++ )
            {
                Button btn = new Button();

                btn.Name = ((char)('A' + i)).ToString();
                btn.FontSize += rand.Next(10);
                btn.Content = "Button " + btn.Name + " say 'Click me'";
                //btn.Click += ButtonOnClick;

                stack.Children.Add(btn);

                //extra code
                //btn.HorizontalAlignment = HorizontalAlignment.Center;
                btn.Margin = new Thickness(5);
            }

            //extra Code

            //stack.Background = Brushes.Aquamarine;
            stack.Orientation = Orientation.Vertical;
            stack.HorizontalAlignment = HorizontalAlignment.Center;

            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.CanMinimize;
            stack.Margin = new Thickness(5);
            AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonOnClick));
            stack.AddHandler(Button.ClickEvent, new RoutedEventHandler(ButtonOnClick));
        }

        void ButtonOnClick( object sender, RoutedEventArgs args )
        {
            Button btn = args.Source as Button;

            MessageBox.Show("Button " + btn.Name + " has been Clicked", "Button Click");
        }
    }
}