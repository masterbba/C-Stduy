using System;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using System.Text;

namespace RecordKeystrokes
{
    public class RecordKeystrokes : Window
    {
        string str = "";
        StringBuilder builder = new StringBuilder("text");
        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new RecordKeystrokes());
        }

        public RecordKeystrokes()
        {
            Title = "RecordKeystrokes";
            //Content = str;
            Content = builder;
        }

        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            base.OnTextInput(e);

            /*string str = Content as string;            

            if (e.Text == "\b")
            {
                if (str.Length > 0)
                    str = str.Substring(0, str.Length - 1);
            }
            else
            {
                str += e.Text;
            }

            Content = str;*/

            //str += e.Text;

            if (e.Text == "\b")
            {
                if (builder.Length > 0)
                    builder.Remove(builder.Length - 1, 1);
            }
            else
            {
                builder.Append(e.Text);
            }

            Content = null;
            Content = builder;
        }
    }
}