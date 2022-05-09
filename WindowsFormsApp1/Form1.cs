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
    public partial class Form1 : Form
    {
        List<IShape> Shapes = new List<IShape>();
        Graphics gp;
        IShape selectedShape;
        bool moving;
        Point previousPoint = Point.Empty;
        Pen pen = new Pen(Color.Black, 10);


        public Form1()
        {
            InitializeComponent();
            
            gp = this.CreateGraphics();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Line line = new Line();
            line.LineColor = Color.Black;
            line.LineWidth = 10;
            line.Point1 = new Point(10, 10);
            line.Point2 = new Point(100, 100);
            Shapes.Add(line);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            for (var i = Shapes.Count - 1; i >= 0; i--)
                if (Shapes[i].HitTest(e.Location)) { selectedShape = Shapes[i]; break; }
            if (selectedShape != null) { moving = true; previousPoint = e.Location; }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                var d = new Point(e.X - previousPoint.X, e.Y - previousPoint.Y);
                selectedShape.Move(d);
                previousPoint = e.Location;
                this.Invalidate();
            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (moving) { selectedShape = null; moving = false; }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            foreach (var shape in Shapes)
                shape.Draw(e.Graphics);

        }
    }
}
