using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class FileHeader : Form
    {

        int w_step = 30;
        int h_step = 30;

        public FileHeader()
        {
            int WHeight = 0, WWidth = 0;
            WHeight = Screen.PrimaryScreen.Bounds.Size.Height;
            WWidth = Screen.PrimaryScreen.Bounds.Size.Width;
            //Opacity = 1;
            //Timer timer = new Timer();
            //timer.Tick += new EventHandler((sender, e) =>
            //{
            //    this.Width += 10;
            //    this.Height += 10;

            //    if (this.Width + w_step >= WWidth)
            //    { 
            //        if (this.Height + h_step >= WHeight)
            //        {
            //            this.Height = WHeight;
            //            this.Width = WWidth;
            //            timer.Stop();
            //        }

            //    }
            //});
            //timer.Interval = 1;
            //timer.Start();






            InitializeComponent();

            //tlpFileLeft.Size = new Size(105, WHeight - 77 - 24);
            //pnlFileLeft.Size = tlpFileLeft.Size;
            //tlpFileLeft.Location = new Point(0, 27);
            //pnlFileLeft.Location = tlpFileLeft.Location;

            //tlp_file_right_1.Size = new Size(WWidth - 105, WHeight - 24 - 77);
            //pnlFileLeft.Size = tlp_file_right_1.Size;
            //tlp_file_right_1.Location = new Point(104, 25);
            //pnlFileLeft.Location = tlp_file_right_1.Location;
            //InitializeComponent();
        }

        private void TOpacity_Tick(object sender, EventArgs e)
        {
           
        }

        private void FileHeader_Load(object sender, EventArgs e)
        {

        }

        private void PnlFileCommon_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tlp_file_right_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BFHR1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_right_2_Click(object sender, EventArgs e)
        {

        }

        private void BFHR2_Click(object sender, EventArgs e)
        {

        }

        private void BFHR3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_right_3_Click(object sender, EventArgs e)
        {

        }

        private void Cb_file_header_right_1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_right_1_Click(object sender, EventArgs e)
        {

        }

        private void TxtLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_right_4_Click(object sender, EventArgs e)
        {

        }

        private void TlpFileLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_file_header_1_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_2_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_3_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_4_Click(object sender, EventArgs e)
        {

        }

        private void Lbl_file_header_5_Click(object sender, EventArgs e)
        {

        }

        private void PnlFileLeft_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
