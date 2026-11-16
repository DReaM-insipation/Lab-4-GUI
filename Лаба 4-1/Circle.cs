using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4_1
{
    internal class Circle : Figure
    {
        public int radius;
        public Circle(int x, int y, int radius )
        {
            this.xCenter = x;
            this.yCenter = y;
            this.radius = radius;
        }

        public override void DrawBlack()
        {
            using Graphics gr = Figure.form1.CreateGraphics();
            using SolidBrush brush = new SolidBrush(Color.Black);
            gr.FillEllipse(brush, this.xCenter - this.radius, this.yCenter - this.radius, 2 * this.radius, 2 * this.radius);
        }
        public override void HideDrawingBackGround()
        {
            using Graphics gr = Figure.form1.CreateGraphics();
            using SolidBrush brush = new SolidBrush(Figure.form1.BackColor);
            gr.FillEllipse(brush, this.xCenter - this.radius, this.yCenter - this.radius, 2 * this.radius, 2 * this.radius);
        }
    }
}
