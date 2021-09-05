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
    public partial class HomeControl : UserControl
    {
        public HomeControl()
        {
            InitializeComponent();
        }

        private void HeaderText_Click(object sender, EventArgs e)
        {

        }

        private void Pic_header_3_Click(object sender, EventArgs e)
        {
            Program.mainform.switcherPages.tabC.SelectedIndex = 2;
            WarehouseAccounting.DropDownMenu.DropDownMenuAvaliable dma = new WarehouseAccounting.DropDownMenu.DropDownMenuAvaliable();
            dma.StartPosition = FormStartPosition.Manual;
            dma.Location = new Point(lbl_header_1.Location.X,Program.mainform.wordTabControl.Location.Y + Program.mainform.wordTabControl.Size.Height);
            dma.Show();
        }

        private void Pic_header_1_Click(object sender, EventArgs e)
        {
            Program.core.AddHeader(Core.Core.Header_Functions.Contragents);
        }

        private void Pic_header_2_Click(object sender, EventArgs e)
        {
            WarehouseAccounting.DropDownMenu.DropDownMenuGoods dmg = new WarehouseAccounting.DropDownMenu.DropDownMenuGoods();
            dmg.StartPosition = FormStartPosition.Manual;
            dmg.Location = new Point(lbl_header_2.Location.X, Program.mainform.wordTabControl.Location.Y + Program.mainform.wordTabControl.Size.Height);
            dmg.Show();
        }

        private void Pic_header_4_Click(object sender, EventArgs e)
        {
            WarehouseAccounting.DropDownMenu.DropDownMenuPrices dmp = new WarehouseAccounting.DropDownMenu.DropDownMenuPrices();
            dmp.StartPosition = FormStartPosition.Manual;
            dmp.Location = new Point(lbl_header_4.Location.X, Program.mainform.wordTabControl.Location.Y + Program.mainform.wordTabControl.Size.Height);
            dmp.Show();
        }

        private void Pic_header_5_Click(object sender, EventArgs e)
        {
            WarehouseAccounting.DropDownMenu.DropDownMenuBuying dms = new WarehouseAccounting.DropDownMenu.DropDownMenuBuying();
            dms.StartPosition = FormStartPosition.Manual;
            dms.Location = new Point(lbl_header_5.Location.X, Program.mainform.wordTabControl.Location.Y + Program.mainform.wordTabControl.Size.Height);
            dms.Show();
        }

        private void Tlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeControl_Load(object sender, EventArgs e)
        {
            lbl_header_1.Text = "Контрагенты";
            lbl_header_2.Text = "Товары";
            lbl_header_3.Text = "Наличие";
            lbl_header_4.Text = "Цены";
            lbl_header_5.Text = "Покупка";
            lbl_header_6.Text = "Продажа";

            lbl_header_7.Text = "";
            lbl_header_8.Text = "";
            lbl_header_9.Text = "";
            lbl_header_10.Text = "";
        }

        private void Pic_header_6_Click(object sender, EventArgs e)
        {
            WarehouseAccounting.DropDownMenu.DropDownMenuSelling dmb = new WarehouseAccounting.DropDownMenu.DropDownMenuSelling();
            dmb.StartPosition = FormStartPosition.Manual;
            dmb.Location = new Point(lbl_header_6.Location.X, Program.mainform.wordTabControl.Location.Y + Program.mainform.wordTabControl.Size.Height);
            dmb.Show();
        }
    }



}
