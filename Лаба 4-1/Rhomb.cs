using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4_1
{
    internal class Rhomb : Figure
    {
        public int horDiagLen;
        public int vertDiagLen;
        public Rhomb(int x, int y, int hD, int vD)
        {
            this.xCenter = x;
            this.yCenter = y;
            this.horDiagLen = hD;
            this.vertDiagLen = vD;
        }
        public override void DrawBlack()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            Point[] points =
            {
                new Point(this.xCenter+this.horDiagLen/2, this.yCenter),
                new Point(this.xCenter, this.yCenter+this.vertDiagLen/2),
                new Point(this.xCenter-this.horDiagLen/2, this.yCenter),
                new Point(this.xCenter, this.yCenter-this.vertDiagLen/2),
            };
            gr.FillPolygon(brush, points);
        }
        public override void HideDrawingBackGround()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Figure.form1.BackColor);
            Point[] points =
            {
                new Point(this.xCenter+this.horDiagLen/2, this.yCenter),
                new Point(this.xCenter, this.yCenter+this.vertDiagLen/2),
                new Point(this.xCenter-this.horDiagLen/2, this.yCenter),
                new Point(this.xCenter, this.yCenter-this.vertDiagLen/2),
            };
            gr.FillPolygon(brush, points);
        }
    }
}
