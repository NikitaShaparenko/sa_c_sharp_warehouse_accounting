using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.OleDb;

namespace WarehouseAccounting.Core
{
    public partial class ImportExcelDGV : UserControl
    {
        public int ver_count = 0;

        public ImportExcelDGV()
        {
            InitializeComponent();
        }

        public DataGridViewSelectedRowCollection selectedRows()
        {
            return this.dgvExcel.SelectedRows;
        }

        public DataGridViewSelectedCellCollection selectedCells()
        {
            return this.dgvExcel.SelectedCells;
        }

    }
}
