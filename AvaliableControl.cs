using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class AvaliableControl : UserControl
    {
        public AvaliableControl()
        {
            InitializeComponent();
        }

        private void Pic_header_1_Click(object sender, EventArgs e)
        {
            Program.mainform.printDocument1.Print();
        }

        private void Pic_header_2_Click(object sender, EventArgs e)
        {
            Program.mainform.DoExportExcel();
        }
    }
}
