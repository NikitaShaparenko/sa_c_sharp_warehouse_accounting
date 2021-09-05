using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;


namespace WarehouseAccounting.Core
{
    public partial class ImportExcel : Form
    {
        public ImportExcel()
        {
            InitializeComponent();
        }


        void LoadData(string file)
        {

        }

        void bgwLoadData(string file)
        {
            BackgroundWorker bgw_d = new BackgroundWorker();
            bgw_d.DoWork += Bgw_d_DoWork;
            bgw_d.RunWorkerAsync();
            bgw_d.Dispose();
        }

        private void Bgw_d_DoWork(object sender, DoWorkEventArgs e)
        {
            //LoadData();
        }

        private void PnlWorkspace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RbGenNumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenNumber.Checked)
            {
                cbCode.Enabled = false;
            }
            else
            {
                cbCode.Enabled = true;
            }
        }

        private void RbUseSelected_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGenNumber.Checked)
            {
                cbCode.Enabled = false;
            }
            else
            {
                cbCode.Enabled = true;
            }
        }
    }
}
