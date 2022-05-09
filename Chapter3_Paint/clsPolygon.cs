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
        public override void Move(Point distance)
        {
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + distance.X, points[i].Y + distance.Y);
            }
        }
    }
}
