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
            this.btnDashDot = new System.Windows.Forms.Button();
            this.btnDash = new System.Windows.Forms.Button();
            this.btnSolid = new System.Windows.Forms.Button();
            this.btnPurple = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnLightGreen = new System.Windows.Forms.Button();
            this.btnBrown = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBlack = new System.Windows.Forms.Button();
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
            this.lbLocation = new System.Windows.Forms.Label();
            this.pnMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnMain.Location = new System.Drawing.Point(12, 118);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(1189, 490);
            this.pnMain.TabIndex = 0;
            this.pnMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnMain_Paint);
            this.pnMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseDown);
            this.pnMain.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseMove);
            this.pnMain.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnMain_MouseUp);
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.pnMenu.Controls.Add(this.btnDashDot);
            this.pnMenu.Controls.Add(this.btnDash);
            this.pnMenu.Controls.Add(this.btnSolid);
            this.pnMenu.Controls.Add(this.btnPurple);
            this.pnMenu.Controls.Add(this.btnYellow);
            this.pnMenu.Controls.Add(this.btnBlue);
            this.pnMenu.Controls.Add(this.btnRed);
            this.pnMenu.Controls.Add(this.btnLightGreen);
            this.pnMenu.Controls.Add(this.btnBrown);
            this.pnMenu.Controls.Add(this.btnGreen);
            this.pnMenu.Controls.Add(this.label4);
            this.pnMenu.Controls.Add(this.btnBlack);
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
            this.pnMenu.Location = new System.Drawing.Point(12, 9);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1189, 103);
            this.pnMenu.TabIndex = 0;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnDashDot
            // 
            this.btnDashDot.BackgroundImage = global::Chapter3_Paint.Properties.Resources.dash_dot;
            this.btnDashDot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDashDot.Location = new System.Drawing.Point(800, 59);
            this.btnDashDot.Name = "btnDashDot";
            this.btnDashDot.Size = new System.Drawing.Size(134, 25);
            this.btnDashDot.TabIndex = 32;
            this.btnDashDot.UseVisualStyleBackColor = true;
            // 
            // btnDash
            // 
            this.btnDash.BackgroundImage = global::Chapter3_Paint.Properties.Resources.dash_dot1;
            this.btnDash.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDash.Location = new System.Drawing.Point(800, 33);
            this.btnDash.Name = "btnDash";
            this.btnDash.Size = new System.Drawing.Size(134, 25);
            this.btnDash.TabIndex = 31;
            this.btnDash.UseVisualStyleBackColor = true;
            // 
            // btnSolid
            // 
            this.btnSolid.BackgroundImage = global::Chapter3_Paint.Properties.Resources.solid1;
            this.btnSolid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSolid.Location = new System.Drawing.Point(800, 6);
            this.btnSolid.Name = "btnSolid";
            this.btnSolid.Size = new System.Drawing.Size(134, 25);
            this.btnSolid.TabIndex = 30;
            this.btnSolid.UseVisualStyleBackColor = true;
            // 
            // btnPurple
            // 
            this.btnPurple.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnPurple.Location = new System.Drawing.Point(1060, 44);
            this.btnPurple.Name = "btnPurple";
            this.btnPurple.Size = new System.Drawing.Size(35, 35);
            this.btnPurple.TabIndex = 29;
            this.btnPurple.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(1060, 6);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(33, 35);
            this.btnYellow.TabIndex = 28;
            this.btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnBlue.Location = new System.Drawing.Point(1021, 44);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(35, 35);
            this.btnBlue.TabIndex = 27;
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.Red;
            this.btnRed.Location = new System.Drawing.Point(1021, 6);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(33, 35);
            this.btnRed.TabIndex = 25;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnLightGreen
            // 
            this.btnLightGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLightGreen.Location = new System.Drawing.Point(983, 44);
            this.btnLightGreen.Name = "btnLightGreen";
            this.btnLightGreen.Size = new System.Drawing.Size(35, 35);
            this.btnLightGreen.TabIndex = 24;
            this.btnLightGreen.UseVisualStyleBackColor = false;
            // 
            // btnBrown
            // 
            this.btnBrown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnBrown.Location = new System.Drawing.Point(983, 6);
            this.btnBrown.Name = "btnBrown";
            this.btnBrown.Size = new System.Drawing.Size(33, 35);
            this.btnBrown.TabIndex = 23;
            this.btnBrown.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGreen.Location = new System.Drawing.Point(944, 44);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(35, 35);
            this.btnGreen.TabIndex = 22;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(954, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Colors and Styles";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(944, 6);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(33, 35);
            this.btnBlack.TabIndex = 1;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.button2_Click);
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
            this.color.Location = new System.Drawing.Point(1106, 11);
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
            // 
            // lbLocation
            // 
            this.lbLocation.AutoSize = true;
            this.lbLocation.Location = new System.Drawing.Point(15, 611);
            this.lbLocation.Name = "lbLocation";
            this.lbLocation.Size = new System.Drawing.Size(27, 16);
            this.lbLocation.TabIndex = 0;
            this.lbLocation.Text = "0, 0";
            this.lbLocation.Click += new System.EventHandler(this.lbLocation_Click);
            this.lbLocation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.label5_MouseMove);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1213, 637);
            this.Controls.Add(this.lbLocation);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnMain);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).EndInit();
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
        private System.Windows.Forms.Button btnBlack;
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
        private System.Windows.Forms.Button btnPurple;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnLightGreen;
        private System.Windows.Forms.Button btnBrown;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnSolid;
        private System.Windows.Forms.Button btnDashDot;
        private System.Windows.Forms.Button btnDash;
        private System.Windows.Forms.Label lbLocation;
    }
}

