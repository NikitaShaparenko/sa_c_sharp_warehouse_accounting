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
    public partial class RibbonGoodsBarcode : UserControl
    {
        public RibbonGoodsBarcode()
        {
            InitializeComponent();
        }

        private void Pic_header_2_Click(object sender, EventArgs e)
        {
            Program.core.CloseHeader(Core.Core.Header_Functions.Goods_Barcode);
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Program.core.ShowInto(Core.Core.Header_Functions.Custom_Goods_Barcodes);
        }
    }
}
