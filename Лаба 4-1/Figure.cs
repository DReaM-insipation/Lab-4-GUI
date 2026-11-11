using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Лаба_4_1
{
    abstract class Figure
    {
        public double xCenter;
        public double yCenter;
        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            while (true)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                this.xCenter += 1;
            }
        }
    }
}
