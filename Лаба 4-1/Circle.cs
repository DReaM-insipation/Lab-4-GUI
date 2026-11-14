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
        public Circle(int radius, int x, int y)
        {
            this.xCenter = x;
            this.yCenter = y;
            this.Radius = radius;
        }

        public override void DrawBlack()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            gr.FillEllipse(brush, this.xCenter, this.yCenter, this.Radius, this.Radius);
        }
        public override void HideDrawingBackGround()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Figure.form1.BackColor);
            gr.FillEllipse(brush, this.xCenter, this.yCenter, this.Radius, this.Radius);
        }
    }
}
