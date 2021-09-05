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
    public partial class DropDownMenuBuying : Form
    {
        public DropDownMenuBuying()
        {
            InitializeComponent();
        }

        private void BOutCart_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Buying_SetOutCart();
            this.Close();
        }

        private void DropDownMenuBuying_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DropDownMenuBuying_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
