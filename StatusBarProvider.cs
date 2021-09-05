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
    public partial class StatusBarProvider : Form
    {
        const int panelW = 600;
        const int panelH = 200;

        const int width_step = 6;
        const int height_step = width_step / 3;

        int st_width = 0;
        int st_height = 0;

        int en_width = 0;
        int en_height = 0;

        public StatusBarProvider()
        {
            Size Window_Size = Screen.PrimaryScreen.Bounds.Size;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Window_Size);

            st_width = Window_Size.Width;
            st_height = Window_Size.Height;

            en_width = Window_Size.Width - panelW;
            en_height = Window_Size.Height - panelH;

            InitializeComponent();
        }

        private void PnlSBP_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TAppear_Tick(object sender, EventArgs e)
        {
            if (this.Location.X < en_width && this.Location.Y < en_height)
            {
                this.Location = new Point(en_width, en_height);
                tAppear.Stop();
            }
            else if (this.Location.X > st_width && this.Location.Y > st_height)
            {
                this.Location = new Point(st_width, st_height);
            }
            else this.Location = new Point(this.Location.X - width_step, this.Location.Y - height_step);

        }
    }
}
