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
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLineSize = new System.Windows.Forms.TrackBar();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnPolygon = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.color = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.btnSquare = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
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
            this.pnMenu.Controls.Add(this.button13);
            this.pnMenu.Controls.Add(this.button14);
            this.pnMenu.Controls.Add(this.button15);
            this.pnMenu.Controls.Add(this.button16);
            this.pnMenu.Controls.Add(this.button3);
            this.pnMenu.Controls.Add(this.button12);
            this.pnMenu.Controls.Add(this.button11);
            this.pnMenu.Controls.Add(this.label4);
            this.pnMenu.Controls.Add(this.button2);
            this.pnMenu.Controls.Add(this.label3);
            this.pnMenu.Controls.Add(this.label2);
            this.pnMenu.Controls.Add(this.label1);
            this.pnMenu.Controls.Add(this.btnLineSize);
            this.pnMenu.Controls.Add(this.button4);
            this.pnMenu.Controls.Add(this.btnSelect);
            this.pnMenu.Controls.Add(this.btnPolygon);
            this.pnMenu.Controls.Add(this.btnLine);
            this.pnMenu.Controls.Add(this.color);
            this.pnMenu.Controls.Add(this.btnEllipse);
            this.pnMenu.Controls.Add(this.btnRectangle);
            this.pnMenu.Controls.Add(this.button9);
            this.pnMenu.Controls.Add(this.btnSquare);
            this.pnMenu.Controls.Add(this.btnCircle);
            this.pnMenu.Controls.Add(this.button1);
            this.pnMenu.Controls.Add(this.button5);
            this.pnMenu.Location = new System.Drawing.Point(12, 9);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(1189, 103);
            this.pnMenu.TabIndex = 0;
            this.pnMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1018, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Colors";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(944, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 35);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(765, 77);
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
            this.btnLineSize.Location = new System.Drawing.Point(728, 23);
            this.btnLineSize.Margin = new System.Windows.Forms.Padding(4);
            this.btnLineSize.Name = "btnLineSize";
            this.btnLineSize.Size = new System.Drawing.Size(108, 56);
            this.btnLineSize.TabIndex = 16;
            this.btnLineSize.Scroll += new System.EventHandler(this.btnLineSize_Scroll);
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_pen;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Location = new System.Drawing.Point(202, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(55, 51);
            this.button4.TabIndex = 17;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_select;
            this.btnSelect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSelect.Location = new System.Drawing.Point(14, 19);
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
            this.btnPolygon.Location = new System.Drawing.Point(646, 18);
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
            this.btnLine.Location = new System.Drawing.Point(283, 18);
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
            this.color.Location = new System.Drawing.Point(1106, 14);
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
            this.btnEllipse.Location = new System.Drawing.Point(339, 18);
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
            this.btnRectangle.Location = new System.Drawing.Point(453, 18);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(56, 51);
            this.btnRectangle.TabIndex = 2;
            this.btnRectangle.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // button9
            // 
            this.button9.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_delte;
            this.button9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button9.Location = new System.Drawing.Point(83, 19);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(52, 51);
            this.button9.TabIndex = 13;
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // btnSquare
            // 
            this.btnSquare.BackgroundImage = global::Chapter3_Paint.Properties.Resources.square;
            this.btnSquare.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSquare.Location = new System.Drawing.Point(515, 18);
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
            this.btnCircle.Location = new System.Drawing.Point(397, 18);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(50, 51);
            this.btnCircle.TabIndex = 5;
            this.btnCircle.UseVisualStyleBackColor = true;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::Chapter3_Paint.Properties.Resources.curve;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.Location = new System.Drawing.Point(584, 18);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 51);
            this.button1.TabIndex = 6;
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::Chapter3_Paint.Properties.Resources.icon_brush;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Location = new System.Drawing.Point(141, 19);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 51);
            this.button5.TabIndex = 9;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Black;
            this.button11.Location = new System.Drawing.Point(944, 44);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(35, 35);
            this.button11.TabIndex = 22;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Location = new System.Drawing.Point(983, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(35, 35);
            this.button3.TabIndex = 24;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Black;
            this.button12.Location = new System.Drawing.Point(983, 6);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(33, 35);
            this.button12.TabIndex = 23;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Black;
            this.button13.Location = new System.Drawing.Point(1060, 44);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(35, 35);
            this.button13.TabIndex = 29;
            this.button13.UseVisualStyleBackColor = false;
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.Black;
            this.button14.Location = new System.Drawing.Point(1060, 6);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(33, 35);
            this.button14.TabIndex = 28;
            this.button14.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.Black;
            this.button15.Location = new System.Drawing.Point(1021, 44);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(35, 35);
            this.button15.TabIndex = 27;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.Black;
            this.button16.Location = new System.Drawing.Point(1021, 6);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(33, 35);
            this.button16.TabIndex = 25;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1213, 621);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnMain);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            this.pnMenu.ResumeLayout(false);
            this.pnMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnLineSize)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button color;
        private System.Windows.Forms.TrackBar btnLineSize;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
    }
}

