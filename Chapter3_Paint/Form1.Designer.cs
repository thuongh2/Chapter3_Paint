namespace Chapter3_Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.ptbColor = new System.Windows.Forms.PictureBox();
            this.btnDashDot = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnSolid = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLineSize = new System.Windows.Forms.TrackBar();
            this.btnPen = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnCurve = new System.Windows.Forms.Button();
            this.btnBrush = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbLocation = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnMain.Location = new System.Drawing.Point(12, 118);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1301, 490);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            this.pnMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseDown);
            this.pnMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            this.pnMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseUp);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnMenu.Controls.Add(this.label5);
            this.pnMenu.Controls.Add(this.ptbColor);
            this.pnMenu.Controls.Add(this.btnDashDot);
            this.pnMenu.Controls.Add(this.btnDash);
            this.pnMenu.Controls.Add(this.btnSolid);
            this.pnMenu.Controls.Add(this.label4);
            this.pnMenu.Controls.Add(this.label3);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.btnLineSize);
            this.pnMenu.Controls.Add(this.btnPen);
            this.pnMenu.Controls.Add(this.btnSelect);
            this.pnMenu.Controls.Add(this.btnPolygon);
            this.pnMenu.Controls.Add(this.btnLine);
            this.pnMenu.Controls.Add(this.color);
            this.pnMenu.Controls.Add(this.btnEllipse);
            this.pnMenu.Controls.Add(this.btnRectangle);
            this.pnMenu.Controls.Add(this.btnDelete);
            this.pnMenu.Controls.Add(this.btnSquare);
            this.pnMenu.Controls.Add(this.btnCircle);
            this.pnMenu.Controls.Add(this.btnCurve);
            this.pnMenu.Controls.Add(this.btnBrush);
            this.pnMenu.Controls.Add(this.panel5);
            this.pnMenu.Location = new System.Drawing.Point(12, 9);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1301, 103);
            this.pnMenu.TabIndex = 0;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(847, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "Styles";
            // 
            // ptbColor
            // 
            this.ptbColor.BackColor = System.Drawing.Color.Red;
            this.ptbColor.Location = new System.Drawing.Point(967, 23);
            this.ptbColor.Margin = new System.Windows.Forms.Padding(4);
            this.ptbColor.Name = "ptbColor";
            this.ptbColor.Size = new System.Drawing.Size(50, 43);
            this.ptbColor.TabIndex = 34;
            this.ptbColor.TabStop = false;
            // 
            // btnDashDot
            // 
            this.btnDashDot.BackgroundImage = global::Chapter3_Paint.Properties.Resources.dash_dot;
            this.btnDashDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashDot.Location = new System.Drawing.Point(800, 56);
            this.btnDashDot.Name = "btnDashDot";
            this.btnDashDot.Size = new System.Drawing.Size(134, 25);
            this.btnDashDot.TabIndex = 32;
            this.btnDashDot.UseVisualStyleBackColor = true;
            this.btnDashDot.Click += new System.EventHandler(this.btnDashDot_Click);
            // 
            // btnDash
            // 
            this.btnDash.BackgroundImage = global::Chapter3_Paint.Properties.Resources.dash_dot1;
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDash.Location = new System.Drawing.Point(800, 30);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(134, 25);
            this.btnDash.TabIndex = 31;
            this.btnDash.UseVisualStyleBackColor = true;
            this.btnDash.Click += new System.EventHandler(this.btnDash_Click);
            // 
            // btnSolid
            // 
            this.btnSolid.BackgroundImage = global::Chapter3_Paint.Properties.Resources.solid1;
            this.btnSolid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolid.Location = new System.Drawing.Point(800, 4);
            this.btnSolid.Name = "btnSolid";
            this.btnSolid.Size = new System.Drawing.Size(134, 25);
            this.btnSolid.TabIndex = 30;
            this.btnSolid.UseVisualStyleBackColor = true;
            this.btnSolid.Click += new System.EventHandler(this.btnSolid_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1108, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Colors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(722, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Size";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(467, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Shapes";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tools";
            // 
            // btnLineSize
            // 
            this.btnLineSize.Location = new System.Drawing.Point(690, 23);
            this.btnLineSize.Margin = new System.Windows.Forms.Padding(4);
            this.btnLineSize.Name = "btnLineSize";
            this.btnLineSize.Size = new System.Drawing.Size(108, 56);
            this.btnLineSize.TabIndex = 16;
            this.btnLineSize.Scroll += new System.EventHandler(this.btnLineSize_Scroll);
            // 
            // btnPen
            // 
            this.btnPen.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_pen;
            this.btnPen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPen.Location = new System.Drawing.Point(188, 19);
            this.btnPen.Name = "btnPen";
            this.btnPen.Size = new System.Drawing.Size(55, 51);
            this.btnPen.TabIndex = 17;
            this.btnPen.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_select;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Location = new System.Drawing.Point(9, 19);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(63, 51);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.TabStop = false;
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnPolygon
            // 
            this.btnPolygon.BackgroundImage = global::Chapter3_Paint.Properties.Resources.poly;
            this.btnPolygon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPolygon.Location = new System.Drawing.Point(628, 18);
            this.btnPolygon.Name = "btnPolygon";
            this.btnPolygon.Size = new System.Drawing.Size(55, 51);
            this.btnPolygon.TabIndex = 4;
            this.btnPolygon.UseVisualStyleBackColor = true;
            this.btnPolygon.Click += new System.EventHandler(this.btnPolygon_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackgroundImage = global::Chapter3_Paint.Properties.Resources.line;
            this.btnLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLine.Location = new System.Drawing.Point(265, 18);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(50, 51);
            this.btnLine.TabIndex = 0;
            this.btnLine.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            this.btnLine.MouseHover += new System.EventHandler(this.btnLine_MouseHover);
            // 
            // color
            // 
            this.color.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_color;
            this.color.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.color.Location = new System.Drawing.Point(1218, 13);
            this.color.Name = "color";
            this.color.Size = new System.Drawing.Size(71, 61);
            this.color.TabIndex = 15;
            this.color.UseVisualStyleBackColor = true;
            this.color.Click += new System.EventHandler(this.color_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.BackgroundImage = global::Chapter3_Paint.Properties.Resources.eclip;
            this.btnEllipse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEllipse.Location = new System.Drawing.Point(321, 18);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(52, 51);
            this.btnEllipse.TabIndex = 1;
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackgroundImage = global::Chapter3_Paint.Properties.Resources.rectangle;
            this.btnRectangle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRectangle.Location = new System.Drawing.Point(435, 18);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(56, 51);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_delte;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Location = new System.Drawing.Point(74, 20);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(52, 51);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackgroundImage = global::Chapter3_Paint.Properties.Resources.square;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquare.Location = new System.Drawing.Point(497, 18);
            this.btnSquare.Name = "btnSquare";
            this.btnSquare.Size = new System.Drawing.Size(63, 51);
            this.btnSquare.TabIndex = 3;
            this.btnSquare.UseVisualStyleBackColor = true;
            this.btnSquare.Click += new System.EventHandler(this.btnSquare_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackgroundImage = global::Chapter3_Paint.Properties.Resources.circle;
            this.btnCircle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCircle.Location = new System.Drawing.Point(379, 18);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(50, 51);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnCurve
            // 
            this.btnCurve.BackgroundImage = global::Chapter3_Paint.Properties.Resources.curve;
            this.btnCurve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCurve.Location = new System.Drawing.Point(566, 18);
            this.btnCurve.Name = "btnCurve";
            this.btnCurve.Size = new System.Drawing.Size(56, 51);
            this.btnCurve.TabIndex = 6;
            this.btnCurve.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnCurve.UseVisualStyleBackColor = true;
            this.btnCurve.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnBrush
            // 
            this.btnBrush.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_brush;
            this.btnBrush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrush.Location = new System.Drawing.Point(131, 19);
            this.btnBrush.Name = "btnBrush";
            this.btnBrush.Size = new System.Drawing.Size(55, 51);
            this.btnBrush.TabIndex = 9;
            this.btnBrush.UseVisualStyleBackColor = true;
            this.btnBrush.Click += new System.EventHandler(this.btnBrush_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.pictureBox17);
            this.panel5.Controls.Add(this.pictureBox18);
            this.panel5.Controls.Add(this.pictureBox19);
            this.panel5.Controls.Add(this.pictureBox20);
            this.panel5.Controls.Add(this.pictureBox6);
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Location = new System.Drawing.Point(1048, 6);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 84);
            this.panel5.TabIndex = 33;
            // 
            // pictureBox17
            // 
            this.pictureBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pictureBox17.Location = new System.Drawing.Point(131, 50);
            this.pictureBox17.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(25, 25);
            this.pictureBox17.TabIndex = 31;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pictureBox18.Location = new System.Drawing.Point(90, 49);
            this.pictureBox18.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(25, 25);
            this.pictureBox18.TabIndex = 30;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.pictureBox19.Location = new System.Drawing.Point(48, 49);
            this.pictureBox19.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(25, 25);
            this.pictureBox19.TabIndex = 29;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox20.Location = new System.Drawing.Point(7, 49);
            this.pictureBox20.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(25, 25);
            this.pictureBox20.TabIndex = 28;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Yellow;
            this.pictureBox6.Location = new System.Drawing.Point(131, 7);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 25);
            this.pictureBox6.TabIndex = 21;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Red;
            this.pictureBox3.Location = new System.Drawing.Point(90, 7);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 25);
            this.pictureBox3.TabIndex = 20;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Location = new System.Drawing.Point(49, 7);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 25);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(7, 7);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(15, 611);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(27, 16);
            this.lbLocation.TabIndex = 0;
            this.lbLocation.Text = "0, 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1325, 637);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnMain);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnSquare;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Button btnPolygon;
        private System.Windows.Forms.Button btnCircle;
        private System.Windows.Forms.Button btnCurve;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.TrackBar btnLineSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPen;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnBrush;
        private System.Windows.Forms.Button btnSolid;
        private System.Windows.Forms.Button btnDashDot;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Label lbLocation;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox ptbColor;
        private System.Windows.Forms.Label label5;
    }
}

