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
    public partial class DropDownMenuProvider : Form
    {
        public DropDownMenuProvider()
        {
            InitializeComponent();
        }

        private void DropDownMenuProvider_Load(object sender, EventArgs e)
        {
            base.OnLoad(e);
            this.Activate();
        }
    }
}
