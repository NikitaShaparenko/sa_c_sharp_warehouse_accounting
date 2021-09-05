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
    public partial class RibbonGoodsReduction : UserControl
    {
        public RibbonGoodsReduction()
        {
            InitializeComponent();
        }

        private void RibbonGoodsReduction_Load(object sender, EventArgs e)
        {

        }

        private void Pic_header_1_Click(object sender, EventArgs e)
        {
            if (Program.mainform.switcherPages.tabC.Contains(Program.mainform.switcherPages.allPages[2])) Program.mainform.switcherPages.DisablePage(Program.mainform.switcherPages.allPages[2]);
            Program.core.CloseHeader(Core.Core.Header_Functions.Goods_Reduction);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow dgvr in Program.mainform.switcherPages.dgvShortNames.SelectedRows)
            {
                if (dgvr.Cells["ShortnameSPCodeColumn"].Value != null)
                {
                    string req = dgvr.Cells["ShortnameSPCodeColumn"].Value.ToString();
                    int num = Program.mathProcessor.GetGBSRowByID(req);

                    Program.gbs.GBS["GBSShortNameColumn", num].Value = Program.gbs.GBS["GBSName",num].Value;

                }
            }
        }
    }
}
