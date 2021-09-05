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
using Excel = Microsoft.Office.Interop.Excel;

namespace WarehouseAccounting
{
    public partial class OpenExcel : Form
    {
        DataGridView datagv;
        bool modePrice = true;
        string mui;
        public OpenExcel(DataGridView dgv,bool isPrices,string mui_data)
        {
            try
            {
                InitializeComponent();
                datagv = dgv;
                modePrice = isPrices;
                mui = mui_data;
            }
            catch
            {
                MessageBox.Show("Необходим установленный Microsoft Office Excel 2007 и старше" + Environment.NewLine + "Произошла ошиба экспорта информации. Проверьте, что ваш офисный пакет активирован!" + Environment.NewLine);
                Close();
            }
        }

        private void OpenExcel_Load(object sender, EventArgs e)
        {
            Excel.Application ex = new Excel.Application();
            ex.Visible = true;
            ex.SheetsInNewWorkbook = 1;
            Excel.Workbook workBook = ex.Workbooks.Add(Type.Missing);
            ex.DisplayAlerts = false;
            Excel.Worksheet sheet = (Excel.Worksheet)ex.Worksheets.get_Item(1);
            sheet.Name = "Отчёт";

            if (modePrice)
            {
                int last_row = datagv.Rows.Count - 1;

                sheet.Cells[1, 1] = "Код";
                sheet.Cells[1, 2] = "Резерв";
                sheet.Cells[1, 3] = "Наименование";
                sheet.Cells[1, 4] = "Количество";

                for (int i = 0; i < last_row; i++)
                {
                    if (datagv.Rows[i].Cells[1].Value != null) sheet.Cells[i + 2, 1] = datagv.Rows[i].Cells[1].Value.ToString();
                    if (datagv.Rows[i].Cells[2].Value != null) sheet.Cells[i + 2, 2] = datagv.Rows[i].Cells[2].Value.ToString();
                    if (datagv.Rows[i].Cells[3].Value != null) sheet.Cells[i + 2, 3] = datagv.Rows[i].Cells[3].Value.ToString();
                    if (datagv.Rows[i].Cells[4].Value != null) sheet.Cells[i + 2, 4] = datagv.Rows[i].Cells[4].Value.ToString();

                }
            }
          else
            {
                int last_row = datagv.Rows.Count - 1;
                sheet.Cells[1, 1] = MUIParser("tb_c");
                sheet.Cells[1, 2] = MUIParser("tb_n");
                for (int i = 0; i < last_row; i++)
                {
                    if (datagv.Rows[i].Cells[0].Value != null) sheet.Cells[i + 2, 1] = datagv.Rows[i].Cells[0].Value.ToString();
                    if (datagv.Rows[i].Cells[1].Value != null) sheet.Cells[i + 2, 2] = datagv.Rows[i].Cells[1].Value.ToString();
                    }
            }
            sheet.Columns.AutoFit();
            sheet.Select();
            sheet.Activate();

            Close();

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
    }
}
