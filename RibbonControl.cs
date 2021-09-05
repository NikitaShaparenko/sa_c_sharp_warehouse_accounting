using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WarehouseAccounting
{
    public partial class RibbonControl : UserControl
    {
        public RibbonControl()
        {
            InitializeComponent();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            TabHeader1.ChangeColorMouseHC = false;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader1.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader1.ShowBorder = true;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader1.Location.X, 
                                            TabHeader1.Location.X + TabHeader1.Width);

            Program.core.ShowHeaderFromCache(0);

            Program.core.ShowNameOfTheTab(Core.Core.Headers.MainStaticHeader);
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            TabHeader2.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader2.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader2.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader2.Location.X,
                                            TabHeader2.Location.X + TabHeader2.Width);

            Program.core.ShowHeaderFromCache(1);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header1);
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            TabHeader3.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader3.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader3.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader3.Location.X,
                                            TabHeader3.Location.X + TabHeader3.Width);

            Program.core.ShowHeaderFromCache(2);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header2);
        }

        private void TransitionsButton_Click(object sender, EventArgs e)
        {
            TabHeader4.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader4.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader4.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader4.Location.X,
                                                        TabHeader4.Location.X + TabHeader4.Width);

            Program.core.ShowHeaderFromCache(3);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header3);
        }

        private void AnimationsButton_Click(object sender, EventArgs e)
        {
            TabHeader5.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader5.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader5.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader5.Location.X,
                                            TabHeader5.Location.X + TabHeader5.Width);

            Program.core.ShowHeaderFromCache(4);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header4);
        }

        private void SlideShowButton_Click(object sender, EventArgs e)
        {
            TabHeader6.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader6.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader6.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader6.Location.X,
                                            TabHeader6.Location.X + TabHeader6.Width);

            Program.core.ShowHeaderFromCache(5);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header5);
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            TabHeader7.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader7.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader7.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader7.Location.X,
                                            TabHeader7.Location.X + TabHeader7.Width);

            Program.core.ShowHeaderFromCache(6);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header6);
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            TabHeader8.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader8.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader8.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader9.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader8.Location.X,
                                            TabHeader8.Location.X + TabHeader8.Width);


            Program.core.ShowHeaderFromCache(7);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header7);
        }

        private void WordabControl_Load(object sender, EventArgs e)
        {
            HomeButton_Click(sender, e);
        }

        private void FileButton_Click(object sender, EventArgs e)
        {

        }

        private void TabPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        public void NamingFirstTab(string name)
        {
            
        }

        private void TabHeader9_Click(object sender, EventArgs e)
        {
            TabHeader9.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader10.ChangeColorMouseHC = true;

            TabHeader9.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader9.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader10.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader9.Location.X,
                                            TabHeader9.Location.X + TabHeader9.Width);


            Program.core.ShowHeaderFromCache(8);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header8);
        }

        private void TabHeader10_Click(object sender, EventArgs e)
        {
            TabHeader10.ChangeColorMouseHC = false;
            TabHeader1.ChangeColorMouseHC = true;
            TabHeader2.ChangeColorMouseHC = true;
            TabHeader3.ChangeColorMouseHC = true;
            TabHeader4.ChangeColorMouseHC = true;
            TabHeader5.ChangeColorMouseHC = true;
            TabHeader6.ChangeColorMouseHC = true;
            TabHeader7.ChangeColorMouseHC = true;
            TabHeader8.ChangeColorMouseHC = true;
            TabHeader9.ChangeColorMouseHC = true;

            TabHeader10.ForeColor = Color.FromArgb(220, 70, 40);
            TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);

            TabHeader10.ShowBorder = true;
            TabHeader1.ShowBorder = false;
            TabHeader2.ShowBorder = false;
            TabHeader3.ShowBorder = false;
            TabHeader4.ShowBorder = false;
            TabHeader5.ShowBorder = false;
            TabHeader6.ShowBorder = false;
            TabHeader7.ShowBorder = false;
            TabHeader8.ShowBorder = false;
            TabHeader9.ShowBorder = false;

            tabPanel.SkipXRange = new Point(TabHeader10.Location.X,
                                            TabHeader10.Location.X + TabHeader10.Width);


            Program.core.ShowHeaderFromCache(9);
            Program.core.ShowNameOfTheTab(Core.Core.Headers.Header9);
        }

        enum LabelMovingDirections
        {
            forward,
            backward,
        }

        LabelMovingDirections direction = LabelMovingDirections.backward;

        void MovingTextProvider(TabButton TabHeader)
        {
            int text_length = TabHeader.Text.Length;
            int left_border = 0;
            const int right_border = 10;
            const int header_size = 10;
            int difference = (TabHeader1.Text.Length + header_size) / 1;
            const int step = 1;

            if (TabHeader.Text.Length > header_size)
            {
                if (direction == LabelMovingDirections.forward)
                {
                    if (TabHeader.TextLocation_X + text_length < right_border + difference)
                    {
                        TabHeader.TextLocation_X += step;
                        return;
                    }
                    else
                    {
                        direction = LabelMovingDirections.backward;
                    }
                }
                else
                {
                    if (TabHeader.TextLocation_X + text_length > left_border - difference)
                    {
                        TabHeader.TextLocation_X -= step;
                        return;
                    }
                    else
                    {
                        direction = LabelMovingDirections.forward;
                    }
                }
            }
        }

        private void THeaderLengthAdapter_Tick(object sender, EventArgs e)
        {

            if (TabHeader1.ChangeColorMouseHC == false) MovingTextProvider(TabHeader1);
            if (TabHeader2.ChangeColorMouseHC == false) MovingTextProvider(TabHeader2);
            if (TabHeader3.ChangeColorMouseHC == false) MovingTextProvider(TabHeader3);
            if (TabHeader4.ChangeColorMouseHC == false) MovingTextProvider(TabHeader4);
            if (TabHeader5.ChangeColorMouseHC == false) MovingTextProvider(TabHeader5);
            if (TabHeader6.ChangeColorMouseHC == false) MovingTextProvider(TabHeader6);
            if (TabHeader7.ChangeColorMouseHC == false) MovingTextProvider(TabHeader7);
            if (TabHeader8.ChangeColorMouseHC == false) MovingTextProvider(TabHeader8);
            if (TabHeader9.ChangeColorMouseHC == false) MovingTextProvider(TabHeader9);
        }

        private void BwHeader1_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }
    }
}
