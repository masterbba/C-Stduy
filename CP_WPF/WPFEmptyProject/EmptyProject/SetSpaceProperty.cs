using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace DrawCircles
{
    public class DrawCircles : Window
    {
        Canvas canv;

        bool isDrawing;
        Ellipse elips;
        Point ptCenter;

        bool isDragging;
        FrameworkElement elDragging;
        Point ptMouseStart, ptElementsSatrt;

        [STAThread]
        public static void Main()
        {
            Application app = new Application();
            app.Run(new DrawCircles());
        }

        public DrawCircles()
        {
            Title = "Draw Circles";
            Content = canv = new Canvas();
        }

        protected override void OnMouseLeftButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseLeftButtonDown(e);

            if (isDragging)
                return;

            ptCenter = e.GetPosition(canv);
            elips = new Ellipse();
            elips.Stroke = SystemColors.WindowTextBrush;
            elips.StrokeThickness = 1;
            elips.Width = 0;
            elips.Height = 0;
            canv.Children.Add(elips);
            Canvas.SetLeft(elips, ptCenter.X);
            Canvas.SetTop(elips, ptCenter.Y);

            CaptureMouse();
            isDrawing = true;
        }

        protected override void OnMouseRightButtonDown(MouseButtonEventArgs e)
        {
            base.OnMouseRightButtonDown(e);

            if(isDrawing)
                return;

            ptMouseStart = e.GetPosition(canv);
            elDragging = canv.InputHitTest(ptMouseStart) as FrameworkElement;

            if( elDragging != null )
            {
                ptElementsSatrt = new Point( Canvas.GetLeft(elDragging), Canvas.GetTop(elDragging) );
                isDragging = true;
            }
        }

        protected override void OnMouseDown(MouseButtonEventArgs e)
        {
            base.OnMouseDown(e);

            if( e.ChangedButton == MouseButton.Middle )
            {
                Shape shape =
                    canv.InputHitTest(e.GetPosition(canv)) as Shape;

                if( shape != null )
                {
                    shape.Fill = (shape.Fill == Brushes.Red ?
                        Brushes.Transparent : Brushes.Red);
                }
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);

            Point ptMouse = e.GetPosition(canv);

            if (isDrawing)
            {
                double dRadius =
                    Math.Sqrt( Math.Pow( ptCenter.X - ptMouse.X, 2 ) + Math.Pow(ptCenter.Y-ptMouse.Y,2));
                Canvas.SetLeft(elips, ptCenter.X - dRadius);
                Canvas.SetTop(elips, ptCenter.Y - dRadius);
                elips.Width = 2 * dRadius;
                elips.Height = 2 * dRadius;
            }
            else if (isDragging)
            {
                Canvas.SetLeft(elDragging, ptElementsSatrt.X + ptMouse.X - ptMouseStart.X);
                Canvas.SetTop(elDragging, ptElementsSatrt.Y + ptMouse.Y - ptMouseStart.Y);
            }
        }

        protected override void OnMouseUp(MouseButtonEventArgs e)
        {
            base.OnMouseUp(e);

            if( isDrawing && e.ChangedButton == MouseButton.Left )
            {
                elips.Stroke = Brushes.Blue;
                elips.StrokeThickness = Math.Min(24, elips.Width / 2);
                elips.Fill = Brushes.Red;
                isDrawing = false;
                ReleaseMouseCapture();
            }
            else if( isDragging && e.ChangedButton == MouseButton.Right )
            {
                isDragging = false;
            }
        }

        protected override void OnTextInput(TextCompositionEventArgs e)
        {
            base.OnTextInput(e);

            if (e.Text.IndexOf('\x1b') != -1)
            {
                if (isDrawing)
                    ReleaseMouseCapture();
                else if (isDragging)
                {
                    Canvas.SetLeft(elDragging, ptElementsSatrt.X);
                    Canvas.SetTop(elDragging, ptElementsSatrt.Y);
                    isDragging = false;
                }
            }
        }

        protected override void OnLostMouseCapture(MouseEventArgs e)
        {
            base.OnLostMouseCapture(e);

            if(isDrawing)
            {
                canv.Children.Remove(elips);
                isDrawing = false;
            }
        }


    }
}