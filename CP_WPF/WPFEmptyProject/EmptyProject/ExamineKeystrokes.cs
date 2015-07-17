using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ExamineKeystrokes
{
    class ExamineKeystroke : Window
    {
        StackPanel stack;
        ScrollViewer scroll;
        string strHeader = "Event     Key               Sys-Key     Text    " +
                    "Ctrl-Text SysText  Ime     KeyState    " +
            "IsDown IsUp        IsToggled   isRepeat";
        string strFormatKey = "{0,-10}{1,-20}{2,-10}                 " +
            "   {3,-10}{4,-15}{5,-8}{6,-17}{7,-10}{8,-10}";
        string strFormatText = "{0,-10}                              " +
            "{1,-10}{2,-10}{3,-10}";

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new ExamineKeystroke());
        }

        public ExamineKeystroke()
        {
            Title = "Examine Keystrokes";
            FontFamily = new FontFamily("Courier New");

            Grid grid = new Grid();
            Content = grid;

            RowDefinition rowdef = new RowDefinition();
            rowdef.Height = GridLength.Auto;
            grid.RowDefinitions.Add(rowdef);
            grid.RowDefinitions.Add(new RowDefinition());

            TextBlock textHeader = new TextBlock();
            textHeader.FontWeight = FontWeights.Bold;
            textHeader.Text = strHeader;
            grid.Children.Add(textHeader);

            scroll = new ScrollViewer();
            grid.Children.Add(scroll);
            Grid.SetRow(scroll, 1);

            stack = new StackPanel();
            scroll.Content = stack;
        }

        void DisplayInfo(string str)
        {
            TextBlock text = new TextBlock();
            text.Text = str;
            stack.Children.Add(text);
            scroll.ScrollToBottom();
        }

        void DisplayKeyInfo(KeyEventArgs args)
        {
            string str =
                String.Format(strFormatKey, args.RoutedEvent.Name,
                args.Key, args.SystemKey, args.ImeProcessedKey,
                args.KeyStates, args.IsDown, args.IsUp, args.IsToggled, args.IsRepeat);
            DisplayInfo(str);
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            DisplayKeyInfo(e);
        }

        protected override void OnKeyUp(KeyEventArgs e)
        {
            base.OnKeyUp(e);
            DisplayKeyInfo(e);
        }

        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            base.OnTextInput(e);
            string str =
                String.Format(strFormatText, e.RoutedEvent.Name, e.Text, e.ControlText, e.SystemText);
            DisplayInfo(str);
        }
        
    }
}