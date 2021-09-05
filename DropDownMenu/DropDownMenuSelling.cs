using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting.DropDownMenu
{
    public partial class DropDownMenuSelling : Form
    {
        public DropDownMenuSelling()
        {
            InitializeComponent();
        }

        private void BBackClient_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Selling_SetBackClient();
            this.Close();
        }

        private void DropDownMenuSelling_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DropDownMenuSelling_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
