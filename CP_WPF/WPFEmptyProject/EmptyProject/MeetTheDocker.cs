using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using System.Windows.Media;

namespace MeetTheDocker
{
    public class MeetTheDocekr : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new MeetTheDocekr());
        }

        public MeetTheDocekr()
        {
            Title = "Meet The Docker";

            Grid grid = new Grid();
            Content = grid;
            grid.ShowGridLines = true;

            RowDefinition rowdef = new RowDefinition();
            rowdef.Height = GridLength.Auto;
            grid.RowDefinitions.Add(rowdef);

            rowdef = new RowDefinition();
            rowdef.Height = new GridLength(33, GridUnitType.Star);
            grid.RowDefinitions.Add(rowdef);

            rowdef = new RowDefinition();
            rowdef.Height = new GridLength(150);
            grid.RowDefinitions.Add(rowdef);

            rowdef = new RowDefinition();
            rowdef.Height = new GridLength(67, GridUnitType.Star);
            grid.RowDefinitions.Add(rowdef);
        }
    }
}