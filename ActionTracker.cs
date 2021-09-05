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
    public partial class ActionTracker : UserControl
    {
        public ActionTracker()
        {
            InitializeComponent();
        }

        private void ActionTracker_Load(object sender, EventArgs e)
        {
            //newAction(DateTime.Now, "Продажа", -1, 1);
            //newAction(DateTime.Now, "Покупка", 0, 1);
            //newAction(DateTime.Now, "Продажа", 2, 1);
            //newAction(DateTime.Now, "Продажа", 4, 1);
            //newAction(DateTime.Now, "Продажа", 5, 1);
            //newAction(DateTime.Now, "Продажа", 6, 1);
            //newAction(DateTime.Now, "Продажа", -2, 1);
        }
       
        public void newAction(DateTime When, string Who,string What, int Was, int Became)
        {
            dgvActionTracker.Rows.Add();
            int lastRow = dgvActionTracker.Rows.Count-1;
            dgvActionTracker[0, lastRow].Value = When.ToString();
            dgvActionTracker[1, lastRow].Value = Who.ToString();
            dgvActionTracker[2, lastRow].Value = What.ToString();
            dgvActionTracker[3, lastRow].Value = Was.ToString();
            dgvActionTracker[4, lastRow].Value = Became.ToString();

            Program.mainform.switcherPages.dgvHistory.Rows.Add();
            Program.mainform.switcherPages.dgvHistory[0, lastRow].Value = When.ToString();
            Program.mainform.switcherPages.dgvHistory[1, lastRow].Value = Who.ToString();
            Program.mainform.switcherPages.dgvHistory[2, lastRow].Value = What.ToString();
            Program.mainform.switcherPages.dgvHistory[3, lastRow].Value = Was.ToString();
            Program.mainform.switcherPages.dgvHistory[4, lastRow].Value = Became.ToString();
        }

        private void DgvActionTracker_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
