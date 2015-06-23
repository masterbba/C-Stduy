using Microsoft.Win32;
using System;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;

namespace EditSomeRichText
{
    public class EditSomeRichText : Window
    {
        RichTextBox txtBox;
        string strFilter = "Document Files(*.xaml)|*.xaml|All files (*.*)|*.*";

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new EditSomeRichText());
        }

        public EditSomeRichText()
        {
            Title = "Edit Some Rich Text";

            txtBox = new RichTextBox();
            txtBox.VerticalScrollBarVisibility = ScrollBarVisibility.Auto;
            Content = txtBox;
        }

        protected override void OnPreviewTextInput(TextCompositionEventArgs e)
        {
            if (e.ControlText.Length > 0 && e.ControlText[0] == '\x0f')
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.CheckFileExists = true;
                dlg.Filter = strFilter;

                if( (bool)dlg.ShowDialog(this))
                {
                    FlowDocument flow = txtBox.Document;
                    TextRange range = new TextRange(flow.ContentStart, flow.ContentEnd);
                    Stream strm = null;

                    try
                    {
                        strm = new FileStream(dlg.FileName, FileMode.Open);
                        range.Load(strm, DataFormats.Xaml);
                    }
                    catch(Exception exc)
                    {
                        MessageBox.Show(exc.Message, Title);
                    }
                    finally
                    {
                        if (strm != null)
                            strm.Close();
                    }

                    e.Handled = true;
                }
            }

            if (e.ControlText.Length > 0 && e.ControlText[0] == '\x13')
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = strFilter;

                if ((bool)dlg.ShowDialog(this))
                {
                    FlowDocument flow = txtBox.Document;
                    TextRange range = new TextRange(flow.ContentStart, flow.ContentEnd);
                    Stream strm = null;

                    try
                    {
                        strm = new FileStream(dlg.FileName, FileMode.Create);
                        range.Save(strm, DataFormats.Xaml);
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message, Title);
                    }
                    finally
                    {
                        if (strm != null)
                            strm.Close();
                    }
                }

                e.Handled = true;
            }

            base.OnPreviewTextInput(e);
        }
    }
}
