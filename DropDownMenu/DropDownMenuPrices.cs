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
    public partial class DropDownMenuPrices : Form
    {
        public DropDownMenuPrices()
        {
            InitializeComponent();
        }

        private void BPriceLists_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Prices_SetPriceLists();
            this.Close();
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Activate();
        }
        public void LocalizeIt(System.Drawing.Point lcn)
        {
            this.Location = lcn;
        }

        private void BDependence_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Prices_SetDependence();
            this.Close();
        }

        private void BPriceProviders_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Prices_SetPriceProviders();
            this.Close();
        }

        private void PSettings_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Prices_SetSettings();
            this.Close();
        }

        private void BSettings_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Prices_SetSettings();
            this.Close();
        }

        private void TFocus_Tick(object sender, EventArgs e)
        {
            if (Program.mainform.Focused)
            {
                this.Close();
            }

        }

        private void DropDownMenuPrices_MouseLeave(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DropDownMenuPrices_MouseHover(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
