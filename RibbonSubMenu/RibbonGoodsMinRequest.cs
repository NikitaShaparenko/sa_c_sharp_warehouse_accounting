using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting.RibbonSubMenu
{
    public partial class RibbonGoodsMinRequest : UserControl
    {
        public RibbonGoodsMinRequest()
        {
            InitializeComponent();
        }

        private void Pic_header_1_Click(object sender, EventArgs e)
        {
            if (Program.mainform.switcherPages.tabC.Contains(Program.mainform.switcherPages.allPages[9])) Program.mainform.switcherPages.DisablePage(Program.mainform.switcherPages.allPages[9]);
            Program.core.CloseHeader(Core.Core.Header_Functions.Goods_MinRequest);
        }
    }
}
