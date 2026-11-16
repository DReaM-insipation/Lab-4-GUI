using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4_1
{
    abstract class Figure
    {
        public int xCenter;
        public int yCenter;
        public static Form1 form1;
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            Task.Run(() =>
            {
                while (this.xCenter <= Figure.form1.Width)
                {
                    DrawBlack();
                    System.Threading.Thread.Sleep(100);
                    HideDrawingBackGround();
                    this.xCenter += 1;
                }
            });
        }
    }
}
