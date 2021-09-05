using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class Indicator : System.Windows.Forms.Button
    {
        public Indicator()
        {
            InitializeComponent();
        }
        Color clr1;
        private Color back_color = Color.White;
        private Color m_hoverforecolor = Color.FromArgb(0, 0, 140);
        private Color border_color = Color.FromArgb(80, 80, 80);
        private int textX = 15;
        private int textY = 5;
        private String text = "init";
        private bool isChanged = true;
        private bool showBorder = true;

        public String DisplayText
        {
            get { return text; }
            set { text = value; Invalidate(); }
        }

        public Color BackColorTB
        {
            get { return back_color; }
            set { back_color = value; Invalidate(); }
        }

        public Color MouseHoverForeColor
        {
            get { return m_hoverforecolor; }
            set { m_hoverforecolor = value; Invalidate(); }
        }

        public bool ChangeColorMouseHC
        {
            get { return isChanged; }
            set { isChanged = value; Invalidate(); }
        }

        public Color BorderColor
        {
            get { return border_color; }
            set { border_color = value; Invalidate(); }
        }

        public bool ShowBorder
        {
            get { return showBorder; }
            set { showBorder = value; Invalidate(); }
        }

        public void SetIndicatorOn()
        {
            this.Enabled = false;
            this.back_color = m_hoverforecolor;
        }

        public void SetIndicatorOff()
        {
            this.Enabled = true;
            this.back_color = Color.White;
        }

        public int TextLocation_X
        {
            get { return textX; }
            set { textX = value; Invalidate(); }
        }
        public int TextLocation_Y
        {
            get { return textY; }
            set { textY = value; Invalidate(); }
        }

        public Indicator(IContainer container)
        {
            container.Add(this);
            this.Size = new System.Drawing.Size(100, 30);
            this.ForeColor = Color.Black;
            this.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Text = "init";
            text = this.Text;
            InitializeComponent();
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            base.OnMouseEnter(e);
            if (isChanged)
            {
                clr1 = this.ForeColor;
                this.ForeColor = m_hoverforecolor;
            }

        }

        //method mouse leave
        protected override void OnMouseLeave(EventArgs e)
        {
            //base.OnMouseLeave(e);
            //if (isChanged)
            //{
            //    this.ForeColor = clr1;
            //}

        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
        }




        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
            text = this.Text;
            //if (textX == 100 && textY == 25)
            //{
            //    textX = ((this.Width) / 3) + 10;
            //    textY = (this.Height / 2) - 1;
            //}

            //Point p = new Point(textX, textY);
            //pe.Graphics.FillRectangle(new SolidBrush(back_color), ClientRectangle);
            //if (showBorder)
            //{
            //    pe.Graphics.DrawLine(new Pen(border_color), 0, 0, 0, this.Height);
            //    pe.Graphics.DrawLine(new Pen(border_color), 0, 0, this.Width, 0);
            //    pe.Graphics.DrawLine(new Pen(border_color), this.Width - 1, 0, this.Width - 1, this.Height);
            //}
            //pe.Graphics.DrawString(text, this.Font, new SolidBrush(this.ForeColor), p);
        }


    }
}
