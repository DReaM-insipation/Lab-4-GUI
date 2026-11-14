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
        public override void DrawBlack()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            Point[] points =
            {
                new Point(this.xCenter+this.horDiagLen, this.yCenter),
                new Point(this.xCenter, this.yCenter+this.vertDiagLen),
                new Point(this.xCenter-this.horDiagLen, this.yCenter),
                new Point(this.xCenter, this.yCenter-this.vertDiagLen),
            };
            gr.FillPolygon(brush, points);
        }
        public override void HideDrawingBackGround()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.White);
            Point[] points =
            {
                new Point(this.xCenter+this.horDiagLen, this.yCenter),
                new Point(this.xCenter, this.yCenter+this.vertDiagLen),
                new Point(this.xCenter-this.horDiagLen, this.yCenter),
                new Point(this.xCenter, this.yCenter-this.vertDiagLen),
            };
            gr.FillPolygon(brush, points);
        }
    }
}
