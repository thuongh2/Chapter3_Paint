using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Chapter3_Paint
{
    internal class clsCircle: clsDrawObject
    {
        public override GraphicsPath GetPath()
        {
            var path = new GraphicsPath();
            path.AddEllipse(getSquare(p1, p2));
            return path;
        }

        public override bool HitTest(Point p)
        {
            var result = false;
            var path = GetPath();
            result = path.IsVisible(p);
            return result;
        }

        public override void Draw(Graphics g)
        {
            var path = GetPath();

            if (isSelect == true)
            {
                g.DrawPath(myPen, path);
            }    
            else
            {
                g.FillPath(myBrush, path); 
            }    

        }
        public override void Move(Point d)
        {
            p1 = new Point(p1.X + d.X, p1.Y + d.Y);
            p2 = new Point(p2.X + d.X, p2.Y + d.Y);
        }


    }
}
