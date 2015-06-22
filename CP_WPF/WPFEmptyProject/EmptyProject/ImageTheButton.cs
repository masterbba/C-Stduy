using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace ImageTheButton
{
    public class ImageTheButton : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new ImageTheButton());
        }

        public ImageTheButton()
        {
            Title = "Image The Button";

            //Uri uri = new Uri("pack://application,,/Image/testImg.jpg");
            Uri uri = new Uri("E:\\Study\\BrainC#\\GitHub\\CP_WPF\\WPFEmptyProject\\EmptyProject\\Image\\testImg.jpg");

            BitmapImage bitmap = new BitmapImage(uri);

            Image img = new Image();
            img.Source = bitmap;
            img.Stretch = Stretch.None;

            Button btn = new Button();
            btn.Content = img;
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;

            Content = btn;
        }
    }
}