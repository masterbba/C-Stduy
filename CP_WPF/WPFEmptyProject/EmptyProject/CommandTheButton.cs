using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace CommandTheButton
{
    public class CommandTheButton : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new CommandTheButton());
        }

        public CommandTheButton()
        {
            Title = "Command The Button";

            Button btn = new Button();
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;
            btn.Command = ApplicationCommands.Paste;
            btn.Content = ApplicationCommands.Paste.Text;
            Content = btn;

            CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, PasteOnExecute, PasetCanExecute));
        }

        void PasteOnExecute( object sender, ExecutedRoutedEventArgs args)
        {
            Title = Clipboard.GetText();
        }

        void PasetCanExecute( object sender, CanExecuteRoutedEventArgs args )
        {
            args.CanExecute = Clipboard.ContainsText();
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);
            Title = "Command The Button";
        }
    }
}