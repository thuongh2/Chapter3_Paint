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
     class clsPolygon: clsDrawObject
    {

        public override GraphicsPath GetPath()
        {
             
            GraphicsPath path = new GraphicsPath();
            if (points.Count < 3)
            {
                path.AddLine(points[0], points[1]);
            }
            else
            {
                path.AddPolygon(points.ToArray());
            }

            return path;
        }

        public override bool HitTest(Point p)
        {
            var result = false;
            var path = GetPath();
            result = path.IsOutlineVisible(p, myPen);
            return result;
        }

        public override void Draw(Graphics g)
        {
            var path = this.GetPath();
            g.DrawPath(myPen, path);
        }
        // set tat ca cac diem
        public override void Move(Point d)
        {
            p1 = new Point(p1.X + d.X, p1.Y + d.Y);
            p2 = new Point(p2.X + d.X, p2.Y + d.Y);
        }
    }
}
