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
    public partial class DropDownMenuAvaliable : Form
    {
        public DropDownMenuAvaliable()
        {
            InitializeComponent();
        }

        public void LocalizeIt(System.Drawing.Point lcn)
        {
            this.Location = lcn;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            this.Activate();
        }

        private void BImages_Click(object sender, EventArgs e)
        {

        }

        private void PProviders_Click(object sender, EventArgs e)
        {

        }

        private void BForgottenGood_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Avaliable_ForgottenGood();
            this.Close();
        }

        private void bEnteringPreorder_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Avaliable_EnteringPreorder();
            this.Close();
        }

        private void BRevizion_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Avaliable_Revizion();
            this.Close();

        }

        private void PSorting_Click(object sender, EventArgs e)
        {
            Program.core.UI_Mode_Avaliable_Sorting();
            this.Close(); 
        }

        private void TFocus_Tick(object sender, EventArgs e)
        {
            if (Program.mainform.Focused)
            {
                this.Close();
            }

        }

        private void DropDownMenuAvaliable_MouseLeave(object sender, EventArgs e)
        {

            this.Close();
        }

        private void DropDownMenuAvaliable_MouseHover(object sender, EventArgs e)
        {

            this.Close();
        }
    }

   

}
