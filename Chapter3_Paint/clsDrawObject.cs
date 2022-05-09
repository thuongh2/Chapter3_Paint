using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace Chapter3_Paint
{
    public abstract class clsDrawObject
    {
        // diem dau
        public Point p1;
        // diem cuoi
        public Point p2;

        public Pen myPen;

        public Brush myBrush;
        // do dai
        public int width;
        // mau sac
        public Color color;
        // duoc chon
        public bool isSelect;
        // ve bang pen hoac bang Brush
        public bool isBrush = false;

        // list cac diem
        public List<PointF> points = new List<PointF>();
        // ve hinh
        public abstract void Draw(Graphics g);
        // tao tao do
        public abstract GraphicsPath GetPath();
        //kiem tra select
        public abstract bool HitTest(Point p);
        // di chuyen
        public abstract void Move(Point d);

        public Rectangle getRectangle(Point p1, Point p2)
        {
            Rectangle rectXY = new Rectangle();

            rectXY.X = Math.Min(p1.X, p2.X);
            rectXY.Y = Math.Min(p1.Y, p2.Y);
            rectXY.Width = Math.Abs(p2.X - p1.X);
            rectXY.Height = Math.Abs(p2.Y - p1.Y);

            return rectXY;
        }

        public Rectangle getSquare(Point p1, Point p2)
        {
            Rectangle rectXY = new Rectangle();

            rectXY.X = Math.Min(p1.X, p2.X);
            rectXY.Y = Math.Min(p1.Y, p2.Y);
            rectXY.Width = Math.Abs(p2.X - p1.X);
            rectXY.Height = Math.Abs(p2.X - p1.X);

            return rectXY;
        }


        
    }
}
