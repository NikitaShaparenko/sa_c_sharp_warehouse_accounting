using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Data.OleDb;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace WarehouseAccounting.Core
{
    public partial class ImportExcelUC : UserControl
    {
        public ImportExcelUC()
        {
            InitializeComponent();
        }

       public string pathName = "";

        void bgwLoadData(string file)
        {
            BackgroundWorker bgw_d = new BackgroundWorker();
            bgw_d.DoWork += Bgw_d_DoWork;
            bgw_d.RunWorkerAsync();
        }

        private void Bgw_d_DoWork(object sender, DoWorkEventArgs e)
        {
            LoadData();
        }

        private void PnlWorkspace_Paint(object sender, PaintEventArgs e)
        {

        }

        public void SetPath(string input)
        {
            pathName = input;
        }

        public void LoadData()
        {
            try
            {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook;
            Excel.Worksheet NwSheet;
            Excel.Range ShtRange;
            DataTable dt = new DataTable();
          
      workbook = app.Workbooks.Open(pathName, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value, Missing.Value, Missing.Value, Missing.Value,
                Missing.Value);

                //Устанавливаем номер листа из котрого будут извлекаться данные
                //Листы нумеруются от 1
                NwSheet = (Excel.Worksheet)workbook.Sheets.get_Item(1);
                ShtRange = NwSheet.UsedRange;
                for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                {
                    dt.Columns.Add(
                    new DataColumn((ShtRange.Cells[1, Cnum] as Excel.Range).Value2.ToString()));
                }
                dt.AcceptChanges();

                string[] columnNames = new String[dt.Columns.Count];
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    columnNames[0] = dt.Columns[i].ColumnName;
                }

                for (int Rnum = 2; Rnum <= ShtRange.Rows.Count; Rnum++)
                {
                    DataRow dr = dt.NewRow();
                    for (int Cnum = 1; Cnum <= ShtRange.Columns.Count; Cnum++)
                    {
                        if ((ShtRange.Cells[Rnum, Cnum] as Excel.Range).Value2 != null)
                        {
                            dr[Cnum - 1] =
                            (ShtRange.Cells[Rnum, Cnum] as Excel.Range).Value2.ToString();
                        }
                    }
                    dt.Rows.Add(dr);
                    dt.AcceptChanges();
                }

                dgvImport.DataSource = dt;
                app.Quit();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Невозможно связаться с установленным Microsoft Office Excel! Может быть он нелицензионный\\невалидный или требует ввода данных в промежуточные окна?");
            }
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

        public void SetWorkBookPath()
        {
            try
            {
                if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\excel.exe", "Path", null) == null)
                {
                    pnlWorkspace2.Controls.Clear();
                    pnlWorkspace2.Controls.Add(Program.error_excel);
                    pnlWorkspace2.Dock = DockStyle.Fill;
                }
                else
                {
                    //pnlWorkspace2.Controls.Clear();
                    //pnlWorkspace2.Controls.Add(Program.import_excel_dgv);
                    //pnlWorkspace2.Dock = DockStyle.Fill;
                }
            }
            catch
            {
                pnlWorkspace2.Controls.Clear();
                pnlWorkspace2.Controls.Add(Program.error_excel);
                pnlWorkspace2.Dock = DockStyle.Fill;
            }
        }

        private void DgvImport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ImportExcelUC_Load(object sender, EventArgs e)
        {
            
        }

        public void ImportExcelDo()
        {
            bgw.RunWorkerAsync();
        }
    }
}
