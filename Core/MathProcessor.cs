using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting.Core
{
    class MathProcessor
    {

        #region GBA - GlobalBaseActions
        int GBA_LastRow()
        {
            return Program.gba.GBA.Rows.Count;
        }

        int GBA_getRowByID(string ID)
        {
            foreach (DataGridViewRow dgvr in Program.gba.GBA.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    if (dgvr.Cells[0].Value.ToString() == ID) return dgvr.Index;
                }
            }
            return -1;
        }

       
        #endregion

        #region GBC - GlobalBaseContragents
        int GBC_LastRow()
        {
            return Program.gbc.GBC.Rows.Count;
        }

        int GBC_getRowByID(string ID)
        {
            foreach (DataGridViewRow dgvr in Program.gbc.GBC.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    if (dgvr.Cells[0].Value.ToString() == ID) return dgvr.Index;
                }
            }
            return -1;
        }

       public ComboBox GBC_ComboBox_ContrAgents_Selector()
        {
            ComboBox cmb = new ComboBox();

            foreach (DataGridViewRow dgvr in Program.gbc.GBC.Rows)
            {
                if (dgvr.Cells[1].Value != null)
                {
                    cmb.Items.Add(dgvr.Cells[1].Value.ToString());
                }
            }

            return cmb;
        }

        #endregion

        #region GBG - GlobalBaseGroups
        int GBG_LastRow()
        {
            return Program.gbg.GBG.Rows.Count; 
        }

  

        string GBG_ContentFromRow(int row)
        {
            if (Program.gbg.GBG[0, row].Value != null)
            {
                return Program.gbg.GBG[0, row].Value.ToString();
            }
            else
            {
                return "";
            }
        }

        public ComboBox GBG_ComboBox_Selector()
        {
            ComboBox cmb = new ComboBox();
            
            foreach (DataGridViewRow dgvr in Program.gbg.GBG.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    cmb.Items.Add(dgvr.Cells[0].Value.ToString());
                }
            }

            return cmb;

        }

        public void WaybackGBG()
        {
            //  BackgroundWorker bw = new BackgroundWorker();
            // bw.DoWork += bw_waybackgbg;
            // bw.RunWorkerAsync();
            //  bw.Dispose();
            bw_waybackgbg();
        }

        //private void bw_waybackgbg(object sender, DoWorkEventArgs e)
        private void bw_waybackgbg()
        {
            bw_waybackgbg_func();
        }

        public void bw_waybackgbg_func()
        {
            //Object locker = new Object();
            //int lastRow = Program.gbg.GBG.Rows.Count;
            ////lock (locker)
            ////{
            //    Program.gbg.GBG.Rows.Clear();
            //    foreach (DataGridViewRow dgvr in Program.mainform.switcherPages.dgvGroupList.Rows)
            //    {
            //        Program.gbg.GBG.Rows.Add();
            //        lastRow = Program.gbg.GBG.Rows.Count-1;
            //    if (dgvr.Cells[0].Value != null)
            //    {
            //        Program.gbg.GBG.Rows[lastRow].Cells[0].Value = dgvr.Cells[0].Value;
            //    }
            //}
            ////}
            ///

            Program.gbg.GBG.Rows.Clear();
            foreach (DataGridViewRow dgvr in Program.mainform.switcherPages.dgvGroupList.Rows)
            {
                if (dgvr.Cells[0].Value != null)
                {
                    Program.gbg.GBGAddToTable(dgvr.Cells[0].Value.ToString());
                }
            }
            Debug.Write("Pause");

        }
        #endregion

        #region GBH - GlobalBaseHistory
        int GBH_LastRow()
        {
            return Program.gbh.GBH.Rows.Count;
        }
        #endregion

        #region GBP - GlobalBaseProvider
        int GBP_LastRow()
        {
            return Program.gbp.GBP.Rows.Count;
        }
        #endregion

        #region GBS - GlobalBaseSignature
        int GBS_LastRow()
        {
            return Program.gbs.GBS.Rows.Count;
        }

        public int GetGBSRowByID(string code)
        {
            foreach(DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            {
                if (dgvr.Cells["GBSCode"].Value != null)
                {
                    if (dgvr.Cells["GBSCode"].Value.ToString() == code)
                    {
                        return dgvr.Cells["GBSCode"].RowIndex;
                    }
                }
                else
                {
                    return -1;
                }
            }
            return -1;
        }

        public void bgwMathProcessor_Sync_Goods_Group_List()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += BgwGBG_DoWork;
            bgw.RunWorkerAsync();
            bgw.Dispose();
        }

        public void bgwMathProcessor_Sync_Goods_MinBalance()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += BgwMinBalance_DoWork;
            bgw.RunWorkerAsync();
            bgw.Dispose();
        }

        public void bgwMathProcessor_Sync_Goods_MaxBalance()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += BgwMaxBalance_DoWork;
            bgw.RunWorkerAsync();
            bgw.Dispose();
        }

        public void bgwMathProcessor_Sync_Goods_MinRequest()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += BgwMinRequest_DoWork;
            bgw.RunWorkerAsync();
            bgw.Dispose();
        }

        private void BgwMinRequest_DoWork(object sender, DoWorkEventArgs e)
        {
            GBS_Sync_Goods_MinRequests();
        }

        private void BgwMinBalance_DoWork(object sender, DoWorkEventArgs e)
        {
            GBS_Sync_Goods_MinBalance();
        }
        private void BgwMaxBalance_DoWork(object sender, DoWorkEventArgs e)
        {
            GBS_Sync_Goods_MaxBalance();
        }

        private void BgwGBG_DoWork(object sender, DoWorkEventArgs e)
        {
            GBS_Sync_Goods_Group_List();
        }

        public void GBS_Sync_Goods_Tags()
        {
            string temp_code = "";
            string temp_name = "";
            string temp_length = "";

            Program.mainform.switcherPages.dgvTags.Rows.Clear();

            int lastRow = Program.mainform.switcherPages.dgvTags.RowCount;

            foreach (DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            {
                Program.mainform.switcherPages.dgvTags.Rows.Add();
                if (dgvr.Cells["GBSCode"].Value != null) temp_code = dgvr.Cells["GBSCode"].Value.ToString();
                Program.mainform.switcherPages.dgvTags["TagsCode", lastRow].Value = temp_code;
                if (dgvr.Cells["GBSName"].Value != null) temp_name = dgvr.Cells["GBSName"].Value.ToString();
                Program.mainform.switcherPages.dgvTags["TagsNameColumn", lastRow].Value = temp_name;
                if (dgvr.Cells["GBSTagsColumn"].Value != null) temp_length = dgvr.Cells["GBSTagsColumn"].Value.ToString();
                Program.mainform.switcherPages.dgvTags["TagsTagsColumn", lastRow].Value = temp_length;
                lastRow++;
            }
        }

        public void GBS_Sync_Goods_MinRequests()
        {
            string temp_code = "";
            string temp_name = "";
            string temp_length = "";

            Program.mainform.switcherPages.dgvMinRequest.Rows.Clear();

            int lastRow = Program.mainform.switcherPages.dgvMinRequest.RowCount;

            foreach (DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            {
                Program.mainform.switcherPages.dgvMinRequest.Rows.Add();
                if (dgvr.Cells["GBSCode"].Value != null) temp_code = dgvr.Cells["GBSCode"].Value.ToString();
                Program.mainform.switcherPages.dgvMinRequest["MinReqCodeColumn", lastRow].Value = temp_code;
                if (dgvr.Cells["GBSName"].Value != null) temp_name = dgvr.Cells["GBSName"].Value.ToString();
                Program.mainform.switcherPages.dgvMinRequest["MinReqNameColumn", lastRow].Value = temp_name;
                if (dgvr.Cells["GBSMinReqColumn"].Value != null) temp_length = dgvr.Cells["GBSMinReqColumn"].Value.ToString();
                Program.mainform.switcherPages.dgvMinRequest["MinReqNumbers", lastRow].Value = temp_length;
                lastRow++;
            }
        }

        public void GBS_Sync_Goods_MinBalance()
        {
            string temp_code = "";
            string temp_name = "";
            string temp_length = "";

            Program.mainform.switcherPages.dgvMinBalance.Rows.Clear();

            int lastRow = Program.mainform.switcherPages.dgvMinBalance.RowCount;

            foreach (DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            {
                Program.mainform.switcherPages.dgvMinBalance.Rows.Add();
                if (dgvr.Cells["GBSCode"].Value != null) temp_code = dgvr.Cells["GBSCode"].Value.ToString();
                Program.mainform.switcherPages.dgvMinBalance["MinBalanceCode", lastRow].Value = temp_code;
                if (dgvr.Cells["GBSName"].Value != null) temp_name = dgvr.Cells["GBSName"].Value.ToString();
                Program.mainform.switcherPages.dgvMinBalance["MinBalanceName", lastRow].Value = temp_name;
                if (dgvr.Cells["GBSMinBalance"].Value != null) temp_length = dgvr.Cells["GBSMinBalance"].Value.ToString();
                Program.mainform.switcherPages.dgvMinBalance["MinBalanceNumber", lastRow].Value = temp_length;
                lastRow++;
            }   
        }
        public void GBS_Sync_Goods_MaxBalance()
        {
            string temp_code = "";
            string temp_name = "";
            string temp_length = "";

            Program.mainform.switcherPages.dgvMaxBalance.Rows.Clear();

            int lastRow = Program.mainform.switcherPages.dgvMaxBalance.RowCount;

            foreach (DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            {
                Program.mainform.switcherPages.dgvMaxBalance.Rows.Add();
                if (dgvr.Cells["GBSCode"].Value != null) temp_code = dgvr.Cells["GBSCode"].Value.ToString();
                Program.mainform.switcherPages.dgvMaxBalance["SPMaxBalanceCode", lastRow].Value = temp_code;
                if (dgvr.Cells["GBSName"].Value != null) temp_name = dgvr.Cells["GBSName"].Value.ToString();
                Program.mainform.switcherPages.dgvMaxBalance["SPMaxBalanceName", lastRow].Value = temp_name;
                if (dgvr.Cells["GBSMaxBalance"].Value != null) temp_length = dgvr.Cells["GBSMaxBalance"].Value.ToString();
                Program.mainform.switcherPages.dgvMaxBalance["SPMaxNumbers", lastRow].Value = temp_length;
                lastRow++;
            }
        }

        public void GBS_Sync_Goods_Default()
        {
            string temp_code = "";
            string temp_name = "";
            string temp_length = "";

            Program.mainform.switcherPages.dgvDefault.Rows.Clear();

            int lastRow = Program.mainform.switcherPages.dgvDefault.RowCount;

            foreach (DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            {
                Program.mainform.switcherPages.dgvDefault.Rows.Add();
                if (dgvr.Cells["GBSCode"].Value != null) temp_code = dgvr.Cells["GBSCode"].Value.ToString();
                Program.mainform.switcherPages.dgvDefault["SPDefaultCode", lastRow].Value = temp_code;
                if (dgvr.Cells["GBSName"].Value != null) temp_name = dgvr.Cells["GBSName"].Value.ToString();
                Program.mainform.switcherPages.dgvDefault["SPDefaultName", lastRow].Value = temp_name;
                if (dgvr.Cells["GBDDefaultEnterColumn"].Value != null) temp_length = dgvr.Cells["GBDDefaultEnterColumn"].Value.ToString();
                Program.mainform.switcherPages.dgvDefault["SPDefaultNumber", lastRow].Value = temp_length;
                lastRow++;
            }
        }

        public void GBS_Sync_Goods_Group_List()
        {
            string temp = "";

            Program.mainform.switcherPages.dgvGroupList.Rows.Clear();

            int lastRow = Program.mainform.switcherPages.dgvGroupList.RowCount;

            foreach (DataGridViewRow dgvr in Program.gbg.GBG.Rows)
            {
                Program.mainform.switcherPages.dgvGroupList.Rows.Add();
                if (dgvr.Cells["GBGGroupNames"].Value != null) Program.mainform.switcherPages.dgvGroupList["GBG", lastRow].Value.ToString(); 
                lastRow++;
            }
        }

        public void GBS_Sync_Goods_Shortname()
        {      
            string temp_code = "";
            string temp_name = "";
            string temp_length = "";

            Program.mainform.switcherPages.dgvShortNames.Rows.Clear();

            int lastRow = Program.mainform.switcherPages.dgvShortNames.RowCount;

            foreach (DataGridViewRow dgvr in Program.gbs.GBS.Rows)
            {
                Program.mainform.switcherPages.dgvShortNames.Rows.Add();
                if (dgvr.Cells["GBSCode"].Value != null) temp_code = dgvr.Cells["GBSCode"].Value.ToString();
                Program.mainform.switcherPages.dgvShortNames["ShortnameSPCodeColumn", lastRow].Value = temp_code;
                if (dgvr.Cells["GBSShortNameColumn"].Value != null) temp_name = dgvr.Cells["GBSShortNameColumn"].Value.ToString();
                Program.mainform.switcherPages.dgvShortNames["ShortnameNameColumn", lastRow].Value = temp_name;
                if (dgvr.Cells["GBSLengthColumn"].Value != null) temp_length = dgvr.Cells["GBSLengthColumn"].Value.ToString();
                Program.mainform.switcherPages.dgvShortNames["LengthSPColumn", lastRow].Value = temp_length;
                lastRow++;
            }
        }

        public void bgwMathProcessor_Sync_Goods_Shortname()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += Bgw_DoWork;
            bgw.RunWorkerAsync();
            bgw.Dispose();
        }
        public void bgwMathProcessor_Sync_Goods_Tags()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += BgwTags_DoWork;
            bgw.RunWorkerAsync();
            bgw.Dispose();
        }

        private void BgwTags_DoWork(object sender, DoWorkEventArgs e)
        {
            GBS_Sync_Goods_Tags();
        }

        public void bgwMathProcessor_Sync_Goods_Default()
        {
            BackgroundWorker bgw = new BackgroundWorker();
            bgw.DoWork += Bgw_DoWorkDefault;
            bgw.RunWorkerAsync();
            bgw.Dispose();
        }

        private void Bgw_DoWorkDefault(object sender, DoWorkEventArgs e)
        {
            GBS_Sync_Goods_Default();
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            GBS_Sync_Goods_Shortname();
        }
        #endregion

        #region GBV - GlobalBaseVerification
        int GBV_LastRow()
        {
            return Program.gbv.GBV.Rows.Count;
        }

        int GBV_getRowByID(string ID)
        {
            foreach (DataGridViewRow dgvr in Program.gbv.GBV.Rows)
            {
                if (dgvr.Cells[1].Value != null)
                {
                    if (dgvr.Cells[1].Value.ToString() == ID) return dgvr.Index;
                }
            }
            return -1;
        }
        #endregion

    }
}
