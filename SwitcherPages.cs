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
    public partial class SwitcherPages : UserControl
    {
        public SwitcherPages()
        {
            InitializeComponent();
        }

        public void SwitchToHistory()
        {
            this.tabC.SelectedIndex = 1;
        }

        private void DgvAvaliable_MouseClick(object sender, MouseEventArgs e)
        {
            //TODO:

            //int currentMouseOverRow = dgvAvaliable.HitTest(e.X, e.Y).RowIndex;
            //int currentMouseOverColumn = dgvAvaliable.HitTest(e.X, e.Y).ColumnIndex;
            //int lastRow = dgvAvaliable.Rows.Count;

            //string expiredData;

            //if (currentMouseOverRow >= 0)
            //{
            //        dgvAvaliable.Rows[currentMouseOverRow].Selected = true;
            //        Program.inputbox.SetData("Переучёт", "Введите наличие");
            //    Program.inputbox.ShowDialog();
            //    if (Program.inputbox.getStatus())
            //    {
            //        if (dgvAvaliable[4, currentMouseOverRow].Value != null)
            //        {
            //            expiredData = dgvAvaliable[4, currentMouseOverRow].Value.ToString();
            //        }
            //        else
            //        {
            //            expiredData = "";
            //        }
            //        dgvAvaliable[4, currentMouseOverRow].Value = Program.inputbox.text;
            //        if (Program.inputbox.text != expiredData)
            //        {
            //            Program.mainform.actionTracker.newAction(DateTime.Now, dgvAvaliable[3, currentMouseOverRow].Value.ToString(), "Переучёт", Int32.Parse(expiredData), Int32.Parse(Program.inputbox.text));
            //        }
            //    }

            //    if (currentMouseOverRow >= lastRow)
            //    {
            //        dgvAvaliable.Rows.Add();
            //    }
            //}
        }

        private void TabC_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabC.SelectedIndex == 0)
            {
                //dgvGoods = Program.gbs.GBS;
            }
            else if (tabC.SelectedIndex == 2)
            {
                Program.mathProcessor.bgwMathProcessor_Sync_Goods_Shortname();
            }
            else if (tabC.SelectedIndex == 5)
            {
                //TODO:
            }
            else if (tabC.SelectedIndex == 5)
            {
                Program.mathProcessor.bgwMathProcessor_Sync_Goods_Default();
            }
            else if (tabC.SelectedIndex == 6)
            {
                Program.mathProcessor.bgwMathProcessor_Sync_Goods_Tags();
            }
            else if (tabC.SelectedIndex == 7)
            {
                Program.mathProcessor.bgwMathProcessor_Sync_Goods_MinBalance();
            }
            else if (tabC.SelectedIndex == 8)
            {
                Program.mathProcessor.bgwMathProcessor_Sync_Goods_MaxBalance();
            }
            else if (tabC.SelectedIndex == 9)
            {
                Program.mathProcessor.bgwMathProcessor_Sync_Goods_MinRequest();
            }

            if (tabC.SelectedIndex != 4)
            {
                Program.mathProcessor.WaybackGBG();
            }
        }

        private void DgvGroups_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvTags_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvGoods_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void DgvMinBalance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow n_v in dgvMinBalance.Rows)
            {
                if (n_v.Cells[3].Value != null && n_v.Cells[1].Value != null)
                {
                    if (n_v.Cells[3].Value.ToString() != "" && n_v.Cells[1].Value.ToString() != "")
                    {
                        Program.gbs.UpdateMinBalanceByID(n_v.Cells[1].Value.ToString(), n_v.Cells[3].Value.ToString());
                    }
                }
            }
        }

        private void DgvMaxBalance_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            foreach (DataGridViewRow n_v in dgvMaxBalance.Rows)
            {
                if (n_v.Cells[3].Value != null && n_v.Cells[1].Value != null)
                {
                    if (n_v.Cells[3].Value.ToString() != "" && n_v.Cells[1].Value.ToString() != "")
                    {
                        Program.gbs.UpdateMaxBalanceByID(n_v.Cells[1].Value.ToString(), n_v.Cells[3].Value.ToString());
                    }
                }
            }
        }

        private void DgvGoods_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void SwitcherPages_LocationChanged(object sender, EventArgs e)
        {

        }

        private void SwitcherPages_Load(object sender, EventArgs e)
        {
            pnlGBS.Controls.Add(Program.gbs.GBS);
            
        }

        public void bgwTabCProvider()
        {
            BackgroundWorker bgwTabC = new BackgroundWorker();
            bgwTabC.DoWork += BgwTabC_DoWork;
            bgwTabC.RunWorkerAsync();
        }

        private void BgwTabC_DoWork(object sender, DoWorkEventArgs e)
        {
            TabControlProvider(tabC);
            //HideAllPages();
            tabC.Visible = true;
           // ShowAllPages();
        }

        private void SwitcherPages_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        #region TabControl - Hide - Show

        public TabControl _tabControl;
        public List<KeyValuePair<TabPage, int>> _pagesIndexed;
        public void TabControlProvider(TabControl tabControl)
        {
            //_tabControl = tabControl;
            //_pagesIndexed = new List<KeyValuePair<TabPage, int>>();

            //for (int i = 0; i < tabControl.TabPages.Count; i++)
            //{
            //    _pagesIndexed.Add(new KeyValuePair<TabPage, int>(tabControl.TabPages[i], i));
            //}

            for (int i = 0; i<Program.mainform.switcherPages.tabC.TabPages.Count;i++)
            {
                hiddenPages.Add(Program.mainform.switcherPages.tabC.TabPages[i]);
            }

            for (int i = 0; i < Program.mainform.switcherPages.tabC.TabPages.Count; i++)
            {
                allPages.Add(Program.mainform.switcherPages.tabC.TabPages[i]);
            }


            for (int i = Program.mainform.switcherPages.tabC.TabPages.Count-1; i>=0; i--)
            {
                Program.mainform.switcherPages.tabC.TabPages.Remove(Program.mainform.switcherPages.tabC.TabPages[i]);
            }



        }

        private List<TabPage> hiddenPages = new List<TabPage>();
        public List<TabPage> allPages = new List<TabPage>();
        public void EnablePage(TabPage page)
        {
            tabC.TabPages.Add(page);
            hiddenPages.Remove(page);
        }

        public void DisablePage(TabPage page)
        {
            tabC.TabPages.Remove(page);
            hiddenPages.Add(page);
        }
        public void HideAllPages()
        {
            for (int i = 0; i < _pagesIndexed.Count; i++)
            {
                _tabControl.TabPages.Remove(_pagesIndexed[i].Key);
            }
        }

        public void ShowAllPages()
        {
            for (int i = 0; i < _pagesIndexed.Count; i++)
            {
                _tabControl.TabPages.Add(_pagesIndexed[i].Key);
            }
        }

        public void HidePage(TabPage tabpage)
        {
            if (!_tabControl.TabPages.Contains(tabpage)) return;
            _tabControl.TabPages.Remove(tabpage);
        }

        public void ShowPage(TabPage tabpage)
        {
            if (_tabControl.TabPages.Contains(tabpage)) return;
            InsertTabPage(GetTabPage(tabpage).Key, GetTabPage(tabpage).Value);
        }

        private void InsertTabPage(TabPage tabpage, int index)
        {
            if (index < 0 || index > _tabControl.TabCount)
                throw new ArgumentException("Index out of Range.");
            _tabControl.TabPages.Add(tabpage);
            if (index < _tabControl.TabCount - 1)
                do
                {
                    SwapTabPages(tabpage, (_tabControl.TabPages[_tabControl.TabPages.IndexOf(tabpage) - 1]));
                }
                while (_tabControl.TabPages.IndexOf(tabpage) != index);
            _tabControl.SelectedTab = tabpage;
        }

        private void SwapTabPages(TabPage tabpage1, TabPage tabpage2)
        {
            if (_tabControl.TabPages.Contains(tabpage1) == false || _tabControl.TabPages.Contains(tabpage2) == false)
                throw new ArgumentException("TabPages must be in the TabControls TabPageCollection.");

            int Index1 = _tabControl.TabPages.IndexOf(tabpage1);
            int Index2 = _tabControl.TabPages.IndexOf(tabpage2);
            _tabControl.TabPages[Index1] = tabpage2;
            _tabControl.TabPages[Index2] = tabpage1;
        }

        public KeyValuePair<TabPage, int> GetTabPage(TabPage tabpage)
        {
            return _pagesIndexed.Where(p => p.Key == tabpage).First();
        }

        #endregion


    }

}
