using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;

namespace BindTheButton
{
    public class BindTheButton : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new BindTheButton());
        }

        public BindTheButton()
        {
            Title = "Bind The Button";

            ToggleButton btn = new ToggleButton();
            btn.Content = "Make _Topmost";
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            //btn.SetBinding(ToggleButton.IsCheckedProperty, "Topmost");
            //btn.DataContext = this;
            Binding bind = new Binding("Topmost");
            bind.Source = this;
            btn.SetBinding(ToggleButton.IsCheckedProperty, bind);

            Content = btn;

            ToolTip tip = new ToolTip();
            tip.Content = "Toggle The Button on to Make " +
                "the window Topmost on the desktop";

            btn.ToolTip = tip;
            /*
            Label lbl = new Label();
            lbl.Content = "File _name";
            Content = lbl;
            */
        }
    }
}