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

namespace WindowsFormsApp1
{
    internal interface IShape
    {
        GraphicsPath GetPath();
        bool HitTest(Point p);
        void Draw(Graphics g);
        void Move(Point d);
    }
}
