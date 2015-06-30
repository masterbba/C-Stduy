using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace EnterTheGird
{
    class EnterTheGrid : Window
    {
        [STAThread]
        static public void Main()
        {
            Application app = new Application();
            app.Run(new EnterTheGrid());
        }

        public EnterTheGrid()
        {
            Title = "Enter The Grid";
            MinWidth = 300;
            SizeToContent = SizeToContent.WidthAndHeight;

            //Make StackPanel and Set Content
            StackPanel stack = new StackPanel();
            Content = stack;

            Grid grid1 = new Grid();
            grid1.Margin = new Thickness(5);
            stack.Children.Add(grid1);

            for( int i = 0; i < 5; i++ )
            {
                RowDefinition rowdef = new RowDefinition();
                rowdef.Height = GridLength.Auto;
                grid1.RowDefinitions.Add(rowdef);
            }

            ColumnDefinition coldef = new ColumnDefinition();
            coldef.Width = GridLength.Auto;
            grid1.ColumnDefinitions.Add(coldef);

            coldef = new ColumnDefinition();
            coldef.Width = new GridLength(100, GridUnitType.Star);
            grid1.ColumnDefinitions.Add(coldef);
            
            string[] strLabels = { "_First Name : ", "_Last Name : ",
                                      "_Social security number : ",
                                      "_Credit card number : ",
                                      "_Ohter personal stuff : " };

            for( int i = 0; i < strLabels.Length; i++ )
            {
                Label lbl = new Label();
                lbl.Content = strLabels[i];
                lbl.VerticalContentAlignment = VerticalAlignment.Center;
                grid1.Children.Add(lbl);
                Grid.SetRow(lbl, i);
                Grid.SetColumn(lbl, 0);
                TextBox txtBox = new TextBox();
                txtBox.Margin = new Thickness(5);
                grid1.Children.Add(txtBox);
                Grid.SetRow(txtBox, i);
                Grid.SetColumn(txtBox, 1);
            }

            Grid grid2 = new Grid();
            grid2.Margin = new Thickness(10);
            stack.Children.Add(grid2);

            grid2.ColumnDefinitions.Add( new ColumnDefinition() );
            grid2.ColumnDefinitions.Add( new ColumnDefinition() );

            Button btn = new Button();
            btn.Content = "Submit";
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.IsDefault = true;
            btn.Click += delegate { Close(); };
            grid2.Children.Add(btn);

            btn = new Button();
            btn.Content = "Cancel";
            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.IsCancel = true;
            btn.Click += delegate { Close(); };
            grid2.Children.Add(btn);
            Grid.SetColumn(btn, 1);

            (stack.Children[0] as Panel).Children[1].Focus();
        }
    }
}