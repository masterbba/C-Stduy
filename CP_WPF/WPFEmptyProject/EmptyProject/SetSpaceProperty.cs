using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace SetSpaceProperty
{
    public class SetSpaceProperty : SpaceWindow
    {
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new SetSpaceProperty());
        }

        public SetSpaceProperty()
        {
            Title = "Set Space Property";
            SizeToContent = SizeToContent.WidthAndHeight;
            ResizeMode = ResizeMode.CanMinimize;
            int[] iSpace = { 0, 1, 2 };

            Grid grid = new Grid();
            Content = grid;

            for (int i = 0; i < 2; i++)
            {
                RowDefinition row = new RowDefinition();
                row.Height = GridLength.Auto;
                grid.RowDefinitions.Add(row);
            }

            for (int i = 0; i < iSpace.Length; i++)
            {
                ColumnDefinition col = new ColumnDefinition();
                col.Width = GridLength.Auto;
                grid.ColumnDefinitions.Add(col);
            }

            for (int i = 0; i < iSpace.Length; i++)
            {
                SpaceButton btn = new SpaceButton();
                btn.Text = "Set WIndow Space to " + iSpace[i];
                btn.Tag = iSpace[i];
                btn.HorizontalAlignment = HorizontalAlignment.Center;
                btn.VerticalAlignment = VerticalAlignment.Center;
                btn.Click += WindowPropertyOnClick;
                grid.Children.Add(btn);
                Grid.SetRow(btn, 0);
                Grid.SetColumn(btn, i);

                btn = new SpaceButton();
                btn.Text = "Set button Space to " + iSpace[i];
                btn.Tag = iSpace[i];
                btn.HorizontalAlignment = HorizontalAlignment.Center;
                btn.VerticalAlignment = VerticalAlignment.Center;
                btn.Click += ButtonPropertyOnClcik;
                grid.Children.Add(btn);
                Grid.SetRow(btn, 1);
                Grid.SetColumn(btn, i);
            }
        }

        void WindowPropertyOnClick(object sender, RoutedEventArgs args)
        {
            SpaceButton btn = args.Source as SpaceButton;
            Space = (int)btn.Tag;
        }

        void ButtonPropertyOnClcik(object sender, RoutedEventArgs args)
        {
            SpaceButton btn = args.Source as SpaceButton;
            btn.Space = (int)btn.Tag;
        }
    }
}