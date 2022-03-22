using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace szgui_lab4
{
    public class Display : FrameworkElement
    {
        private double areaW;
        private double areaH;

        public void Resize(double w, double h)
        {
            areaW = w;
            areaH = h;
            this.InvalidateVisual();
        }

        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);

            drawingContext.DrawLine(new Pen(Brushes.Black, 1), new Point(100, 1), new Point(100, 300));
            drawingContext.DrawLine(new Pen(Brushes.Black, 1), new Point(200, 1), new Point(200, 300));
            drawingContext.DrawLine(new Pen(Brushes.Black, 1), new Point(1, 100), new Point(300, 100));
            drawingContext.DrawLine(new Pen(Brushes.Black, 1), new Point(1, 200), new Point(300, 200));

            //drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(1, 1, 200, 200));
            //drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(201, 1, 200, 200));
            //drawingContext.DrawRectangle(Brushes.Transparent, new Pen(Brushes.Black, 1), new Rect(402, 1, 200, 200));

            //drawingContext.DrawEllipse(Brushes.Transparent, new Pen(Brushes.Black, 1), new Point(100, 100), 200, 100);
        }
    }
}
