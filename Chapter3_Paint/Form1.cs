using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter3_Paint
{
    public partial class Form1 : Form
    {
        Graphics gp;
        Color myColor = Color.Red;
        System.Drawing.Drawing2D.DashStyle dashStyle;
        Pen myPen;
        bool bLine = true;
        bool bRect = false;
        bool bEcllipse = false;
        bool bSquare = false;
        bool bPolygon = false;
        bool bCircle = false;
        bool bCurve = false;
        bool isDrawPolygon = false;
        int width = 5;
        bool isDraw = false;
        bool isDelete = false;
        SolidBrush myBrush;
        bool isPen = true;
        bool isBrush = true;
        bool isSl = false;
        clsDrawObject selectedShape;
        List<clsDrawObject> deleteShape = new List<clsDrawObject>();
        bool moving;
        Point previousPoint = Point.Empty;

        List<clsDrawObject> lstObject = new List<clsDrawObject>();
        bool isPress = false;

        public Form1()
        {
            InitializeComponent();
            this.pnMain.SetDoubleBuffered();
            gp = this.pnMain.CreateGraphics();
            myColor = Color.Red;
            myPen = new Pen(myColor, width);
            myBrush= new SolidBrush(myColor);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            this.bLine = true;
        }

        private void pnMain_MouseDown(object sender, MouseEventArgs e)
        {
            this.isPress = true;
            if(isSl)
            {
                for (var i = lstObject.Count - 1; i >= 0; i--)
                    if (lstObject[i].HitTest(e.Location)) 
                    { selectedShape = lstObject[i]; break; }
                if (selectedShape != null) 
                    { moving = true; previousPoint = e.Location; }
            }    
            if(isDelete)
            {
                for (var i = lstObject.Count - 1; i >= 0; i--)
                    if (lstObject[i].HitTest(e.Location))
                    {
                        lstObject.Remove(lstObject[i]);
                        isDelete = false;
                    }

            }   
            if(Form.ModifierKeys == Keys.Control)
            {
                for (var i = lstObject.Count - 1; i >= 0; i--)
                    if (lstObject[i].HitTest(e.Location))
                    {
                        deleteShape.Add(lstObject[i]);
                    }

            }
            if (isPress)
            {
                if (this.bLine == true)
                {
                    // Tao doi tuong duong thang
                    clsDrawObject myObj;
                    myObj = new clsLine();
                    // Tao myPen
                    myObj.myPen = new Pen(myColor, width);
                    myObj.myPen.DashStyle = dashStyle;
                    // gan toa do diem dau va cuoi
                    myObj.p1 = e.Location;
                    myObj.p2 = e.Location;

                    this.lstObject.Add(myObj);
                }
                if (this.bEcllipse == true)
                {
                    clsDrawObject myObj;
                    myObj = new clsEllipse();
                    myObj.myPen = new Pen(myColor, width);
                    myObj.myPen.DashStyle = dashStyle;
                    myObj.points.Add(e.Location);
                    myObj.points.Add(e.Location);
                    this.lstObject.Add(myObj);
                }
                if (this.bRect == true)
                {
                    clsDrawObject myObj;
                    myObj = new clsRectangle();
                    myObj.myPen = new Pen(myColor, width);
                    myObj.myPen.DashStyle = dashStyle;
                    myObj.p1 = e.Location;
                    this.lstObject.Add(myObj);
                }
                if (this.bSquare == true)
                {
                    clsDrawObject myObj;
                    myObj = new clsSquare();
                    myObj.myPen = new Pen(myColor, width);
                    myObj.myPen.DashStyle = dashStyle;
                    myObj.p1 = e.Location;
                    this.lstObject.Add(myObj);
                }
                if (this.bPolygon == true)
                {

                    clsDrawObject myObj;
                    myObj = new clsPolygon();
                    myObj.myPen = new Pen(myColor, width);
                    myObj.myPen.DashStyle = dashStyle;
                    if (isDrawPolygon == true)
                    {
                        this.lstObject[this.lstObject.Count - 1].points.Add(e.Location);
                    }
                    else
                    {
                        myObj.points.Add(e.Location);
                        myObj.points.Add(e.Location);
                        this.lstObject.Add(myObj);
                    }

                }
                if (this.bCircle == true)
                {
                    clsDrawObject myObj;
                    myObj = new clsCircle();
                    myObj.myPen = new Pen(myColor, width);
                    myObj.myPen.DashStyle = dashStyle;
                    myObj.p1 = e.Location;
                    myObj.p2 = e.Location;
                    this.lstObject.Add(myObj);
                }
                if (this.bCurve == true && isDraw == false)
                {
                    clsDrawObject myObj;
                    myObj = new clsCurve();
                    myObj.myPen = new Pen(myColor, width);
                    myObj.myPen.DashStyle = dashStyle;
                    myObj.points.Add(e.Location);
                    myObj.points.Add(e.Location);
                    this.lstObject.Add(myObj);
                }
            }
                
        }

        private void pnMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                var d = new Point(e.X - previousPoint.X, e.Y - previousPoint.Y);
                selectedShape.Move(d);
                previousPoint = e.Location;
                this.Invalidate();
            }

            if (this.isPress == true)
            {
                if(bCurve == true || bPolygon == true)
                {
                    isDraw = true;

                    clsDrawObject c  = this.lstObject[this.lstObject.Count - 1];

                    c.points[c.points.Count - 1] = e.Location;

                    this.pnMain.Refresh();

                }
                else
                {
                    this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
                    this.pnMain.Refresh();
                }
               
            }

            this.lbLocation.Text = e.Location.ToString();
        }

        private void pnMain_Paint(object sender, PaintEventArgs e)
        {
        
                for (int i = 0; i < this.lstObject.Count; i++)
                {
                    if (isPen == true)
                        this.lstObject[i].Draw(e.Graphics);
                }
   
        }

        private void pnMain_MouseUp(object sender, MouseEventArgs e)
        {
            this.isPress = false;

            if (e.Location != null)
            {
                this.lstObject[this.lstObject.Count - 1].p2 = e.Location;
                this.Refresh();
               
            }

            if (moving) { selectedShape = null; moving = false; }

            if (this.bPolygon == true)
            {
                this.lstObject[this.lstObject.Count - 1].points.Add(e.Location);

                this.isDrawPolygon = true;

                this.pnMain.Refresh();
      

            }
            if (this.bCurve == true)
            {
                this.lstObject[this.lstObject.Count - 1].points.Add(e.Location);

                this.pnMain.Refresh();
        
            }

            this.bLine = false;
            this.bEcllipse = false;
            this.bRect = false;
            this.bSquare = false;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            this.bEcllipse = true;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            this.bRect = true;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            this.bSquare = true;
        }

        private void btnPolygon_Click(object sender, EventArgs e)
        {
            this.bPolygon = !this.bPolygon;
         
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            this.bCircle = true;    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.bCurve = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.myColor = Color.Black;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.myColor = Color.Yellow;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.width = 10;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            dashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            isPen = false;
            isBrush = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            isSl = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.isDelete = true;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
            foreach(var de in deleteShape)
            {
                lstObject.Remove(de);
                this.Refresh();
            }
        }

        private void color_Click(object sender, EventArgs e)
        {
            ColorDialog dlg = new ColorDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                myColor = dlg.Color;
            }
        }


        private void btnLineSize_Scroll(object sender, EventArgs e)
        {
            width = (int)(btnLineSize.Value +1);
        }

        private void btnLine_MouseHover(object sender, EventArgs e)
        {
            ToolTip t1 = new ToolTip();
            t1.SetToolTip(this.btnLine, "Line");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseMove(object sender, MouseEventArgs e)
        {
           
        }

        private void lbLocation_Click(object sender, EventArgs e)
        {
            
        }
    }
}
