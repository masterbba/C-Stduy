using System;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EditSomeText
{
    class EditSomeText : Window
    {
        static string strFileName = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "EditSomeText\\EidtSomeText.txt");

        TextBox txtbox;

        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new EditSomeText());
        }

        public EditSomeText()
        {
            Title = "Edit Some Text";

            txtbox = new TextBox();
            txtbox.AcceptsReturn = true;
            txtbox.TextWrapping = TextWrapping.Wrap;
            txtbox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            txtbox.KeyDown += TextBoxKeyDown;
            Content = txtbox;

            try
            {
                txtbox.Text = File.ReadAllText(strFileName);
            }
            catch
            {

            }

            txtbox.CaretIndex = txtbox.Text.Length;
            txtbox.Focus();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(strFileName));
                File.WriteAllText(strFileName, txtbox.Text);
            }

            catch(Exception exc)
            {
                MessageBoxResult result = MessageBox.Show(
                    "File could not be Saved: " + exc.Message + "\nClose program anway?", Title,
                    MessageBoxButton.YesNo, MessageBoxImage.Exclamation);

                e.Cancel = (result == MessageBoxResult.No);
            }
        }

        void TextBoxKeyDown( object sender, KeyEventArgs args)
        {
            if( args.Key == Key.F5 )
            {
                txtbox.SelectedText = DateTime.Now.ToString();
                txtbox.CaretIndex = txtbox.SelectionStart + txtbox.SelectionLength;
            }
        }

    }
}