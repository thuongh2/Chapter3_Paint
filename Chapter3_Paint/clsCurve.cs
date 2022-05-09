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
    internal class clsCurve: clsDrawObject
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
                path.AddCurve(points.ToArray(), 0, points.ToArray().Length - 1, 0.8f);
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
            for (int i = 0; i < points.Count; i++)
            {
                points[i] = new Point(points[i].X + d.X, points[i].Y + d.Y);
            }
        }

        public override void DrawSelect(Graphics g)
        {
            var path = this.GetPath();
            Pen penSelect = new Pen(Color.BlueViolet, 3);
            penSelect.DashStyle = DashStyle.Dot;
            g.DrawPath(penSelect, path);
        }


    }
}
