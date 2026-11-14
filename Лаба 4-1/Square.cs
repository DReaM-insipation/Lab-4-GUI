using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4_1
{
    internal class Square:Figure
    {
        public int sideLength;

        public override void DrawBlack()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Color.Black);
            gr.FillRectangle(brush, this.xCenter-this.sideLength/2, this.yCenter - this.sideLength / 2,this.sideLength,this.sideLength);
        }
        public override void HideDrawingBackGround()
        {
            Graphics gr = Figure.form1.CreateGraphics();
            SolidBrush brush = new SolidBrush(Figure.form1.BackColor);
            gr.FillRectangle(brush, this.xCenter - this.sideLength / 2, this.yCenter - this.sideLength / 2, this.sideLength, this.sideLength);

        }
    }
}
