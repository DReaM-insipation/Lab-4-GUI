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
        public Square(int x, int y, int sL)
        {
            this.xCenter = x; 
            this.yCenter = y;
            this.sideLength = sL;
        }
        public override void DrawBlack()
        {
            using Graphics gr = Figure.form1.CreateGraphics();
            using SolidBrush brush = new SolidBrush(Color.Black);
            gr.FillRectangle(brush, this.xCenter-this.sideLength/2, this.yCenter - this.sideLength / 2,this.sideLength,this.sideLength);
        }
        public override void HideDrawingBackGround()
        {
            using Graphics gr = Figure.form1.CreateGraphics();
            using SolidBrush brush = new SolidBrush(Figure.form1.BackColor);
            gr.FillRectangle(brush, this.xCenter - this.sideLength / 2, this.yCenter - this.sideLength / 2, this.sideLength, this.sideLength);

        }
    }
}
