using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace ToggleBoldAndItalic
{
    public class ToggleBoldAndItalic : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new ToggleBoldAndItalic());
        }

        public ToggleBoldAndItalic()
        {
            Title = "Toggle Bold & Italic";
            TextBlock text = new TextBlock();
            text.FontSize = 32;
            text.HorizontalAlignment = HorizontalAlignment.Center;
            text.VerticalAlignment = VerticalAlignment.Center;
            Content = text;

            string strQoute = "To bo, or not to be, this is the question";
            string[] strWord = strQoute.Split();

            foreach( string str in strWord )
            {
                Run run = new Run(str);
                run.MouseDown += RunOnMouseDown;
                text.Inlines.Add(run);
                text.Inlines.Add(" ");
            }
        }

        void RunOnMouseDown( object sender, MouseButtonEventArgs e )
        {
            Run run = sender as Run;

            if (e.ChangedButton == MouseButton.Left)
                run.FontStyle = run.FontStyle == FontStyles.Italic ? FontStyles.Normal : FontStyles.Italic;

            if( e.ChangedButton == MouseButton.Right )
                run.FontWeight = run.FontWeight == FontWeights.Bold ? FontWeights.Normal : FontWeights.Bold;
        }
    }
}