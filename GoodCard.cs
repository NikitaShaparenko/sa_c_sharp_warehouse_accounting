using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace WarehouseAccounting
{
    public partial class GoodCard : Form
    {

        string mui;
        string lcl_prefix = "{ Карточка товара }";

        public GoodCard(string mui_data)
        {
            InitializeComponent();
            mui = mui_data;
            Program.log.setToLog(lcl_prefix, 2, "0xgc", "Открываем карточку товаров", "ok");
        }


        public string MUIParser(string req)
        {
            return XMLParser(mui, req);
        }

        public string XMLParser(string source, string rq)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(source);
                string searching = xmlDoc.GetElementsByTagName(rq)[0].InnerText;
                return searching;
            }
            catch
            {
                return "";
            }
        }

        private void GoodCard_Load(object sender, EventArgs e)
        {
           this.Text = MUIParser("gc_fh");
            //goodcard_header_1.Text = MUIParser("gc_h1");
            //goodcard_header_2.Text = MUIParser("gc_h2");
            //goodcard_header_3.Text = MUIParser("gc_h3");
            //goodcard_header_4.Text = MUIParser("gc_h4");
            //goodcard_header_5.Text = MUIParser("gc_h5");
            //goodcard_header_6.Text = MUIParser("gc_h6");
            //goodcard_header_7.Text = MUIParser("gc_h7");
            //goodcard_header_8.Text = MUIParser("gc_h8");
            //goodcard_header_9.Text = MUIParser("gc_h9");
            bSave.Text = MUIParser("gc_b1");
            bClose.Text = MUIParser("gc_b2");

            txtGroup = Program.mathProcessor.GBG_ComboBox_Selector();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            //(MainForm)this.Tag).setGoodCardData(txtCode.Text,txtName.Text, txtShortName.Text, txtTags.Text, txtBarcode.Text, txtMinReq.Text, txtBarcode.Text, txtBuying.Text, txtUpcoming.Text, txtGroup.Text,txtDefaultEnter.Text, cbFast.Checked.ToString(),cbNotForSelling.Checked.ToString(), cbNotForBuying.Checked.ToString(), cbInvisiblePrice.Checked.ToString());
            Program.gbs.setGoodCardData(txtCode.Text, txtName.Text, txtShortName.Text, txtTags.Text, txtBarcode.Text, txtMinReq.Text,  txtBuying.Text, txtUpcoming.Text, txtGroup.Text, txtDefaultEnter.Text, cbFast.Checked, cbNotForSelling.Checked, cbNotForBuying.Checked, cbConstPrice.Checked, cbInvisiblePrice.Checked);
            //Program.mainform.switcherPages.dgvGoods.Rows.Clear();
            //foreach (DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            //{
            //    Program.mainform.switcherPages.dgvGoods.Rows.Add(dgvr);
            //}
            Close();
        }

        private void BClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Goodcard_header_1_Click(object sender, EventArgs e)
        {

        }

        private void Txth9_TextChanged(object sender, EventArgs e)
        {

        }

        private void Txth1_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbNotForSelling_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BMakeNext_Click(object sender, EventArgs e)
        {
            txtName.Text = "";
            txtBarcode.Text = "";
            txtBuying.Text = "";
            txtCode.Text = "";
            txtDefaultEnter.Text = "";
            txtGroup.Text = "";
            txtMinReq.Text = "";
            txtShortName.Text = "";
            txtTags.Text = "";
            txtUpcoming.Text = "";
            cbConstPrice.Checked = false;
            cbFast.Checked = false;
            cbInvisiblePrice.Checked = false;
            cbNotForBuying.Checked = false;
            cbNotForSelling.Checked = false;
        }
    }
}
