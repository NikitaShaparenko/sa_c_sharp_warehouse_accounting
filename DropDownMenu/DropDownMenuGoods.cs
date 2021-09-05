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
    public partial class DropDownMenuGoods : Form
    {
        public DropDownMenuGoods()
        {
            InitializeComponent();
        }

        public void LocalizeIt(System.Drawing.Point lcn)
        {
            this.Location = lcn;
        }

        private void DropDownMenuGoods_Load(object sender, EventArgs e)
        {

        }

        private void BBarcode_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetBarcode();
            this.Close();
        }

        private void BReduction_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetReduction();
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[2]);
            this.Close();
        }

        private void BImages_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetImages();
            this.Close();
        }

        private void PProviders_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetProviders();
            this.Close();
        }

        private void BTags_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetTags();
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[6]);
            this.Close();
        }

        private void BGroups_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetGroups();
            //Program.mainform.switcherPages.tabC.TabPages.Add("tabGroups");
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[3]);
            this.Close();
        }

        private void BDefault_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetDefault();
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[5]);
            this.Close();
        }

        private void BLinks_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetLinks();
            this.Close();
        }

        private void BMinBalance_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetMinBalance();
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[7]);
            this.Close();
        }

        private void BMaxBalance_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetMaxBalance();
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[8]);
            this.Close();
        }

        private void BMinRequest_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Goods_SetMinRequest();
            Program.mainform.switcherPages.EnablePage(Program.mainform.switcherPages.allPages[9]);
            this.Close();
        }

        private void TFocus_Tick(object sender, EventArgs e)
        {
            if (Program.mainform.Focused)
            {
                this.Close();
            }

  
        }

        private void DropDownMenuGoods_MouseLeave(object sender, EventArgs e)
        {
             this.Close();
        }

        private void DropDownMenuGoods_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
