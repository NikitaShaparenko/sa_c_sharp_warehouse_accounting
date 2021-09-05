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
    public partial class RibbonGoodsGroups : UserControl
    {
        public RibbonGoodsGroups()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Program.mathProcessor.bgwMathProcessor_Sync_Goods_Group_List();
            if (Program.mainform.switcherPages.tabC.Contains(Program.mainform.switcherPages.allPages[3])) Program.mainform.switcherPages.DisablePage(Program.mainform.switcherPages.allPages[3]);
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[4]);
        }

        private void Pic_header_1_Click(object sender, EventArgs e)
        {
            Program.core.CloseHeader(Core.Core.Header_Functions.Goods_Groups);

            if (Program.mainform.switcherPages.tabC.Contains(Program.mainform.switcherPages.allPages[3])) Program.mainform.switcherPages.DisablePage(Program.mainform.switcherPages.allPages[3]);
            if (Program.mainform.switcherPages.tabC.Contains(Program.mainform.switcherPages.allPages[4])) Program.mainform.switcherPages.DisablePage(Program.mainform.switcherPages.allPages[4]);

        }
    }
}
