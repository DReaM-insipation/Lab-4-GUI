using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4_1
{
    internal class Circle : Figure
    {
        public int Radius;
        public Circle(int x, int y, int radius )
        {
            this.xCenter = x;
            this.yCenter = y;
            this.Radius = radius;
        }

        public override void DrawBlack()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            gr.FillEllipse(brush, this.xCenter - this.Radius, this.yCenter - this.Radius, 2 * this.Radius, 2 * this.Radius);
        }
        public override void HideDrawingBackGround()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Figure.form1.BackColor);
            gr.FillEllipse(brush, this.xCenter - this.Radius, this.yCenter - this.Radius, 2 * this.Radius, 2 * this.Radius);
        }
    }
}
