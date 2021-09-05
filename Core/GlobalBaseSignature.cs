using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting.Core
{

    public partial class GlobalBaseSignature : Form
    {

        const string table_name = "GBS";
        public GlobalBaseSignature()
        {
            InitializeComponent();
            GBS[0, 0].Value = "int";
            GBS[1, 0].Value = "string";
        }

        public void SaveXSD()
        {
            try
            {

                for (int r = 0; r < GBS.Rows.Count; r++)
                {
                    for (int c = 0; c < GBS.Columns.Count; c++)
                    {
                        if (GBS[c, r].Value != null)
                        {
                            if (GBS[c, r].Value.ToString() == "") GBS[c, r].Value = " ";
                        }
                    }
                }

                if (File.Exists(Program.prj_var_prj_path + "\\" + table_name + ".db"))
                {
                    try
                    {
                        if (File.Exists(Program.prj_var_prj_path + "\\" + table_name + ".db")) File.Delete(AppDomain.CurrentDomain.BaseDirectory + "\\" + table_name + ".xml");
                        File.Move(Program.prj_var_prj_path + "\\" + table_name + ".db", Program.prj_var_prj_path + "\\" + table_name + ".bak");
                    }
                    catch (Exception ex)
                    {
                        //ErrorShow("0x3a", "Не удалось создать резервную копию файла подкачки (Код 1)! " + ex.Message);

                    }
                    finally
                    {
                        DataTable dt = new DataTable();
                        foreach (DataGridViewColumn col in GBS.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in GBS.Rows)
                        {
                            DataRow dRow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(dRow);
                        }

                        foreach (DataRow DataRow in dt.Rows)
                        {
                            for (int j = 0; j < DataRow.ItemArray.Length; j++)
                            {
                                if (DataRow.ItemArray[j] == DBNull.Value)
                                    DataRow.SetField(j, string.Empty);
                            }
                        }

                        dt.TableName = table_name;
                        dt.WriteXml(Program.prj_var_prj_path + "\\" + table_name + ".db");
                    }
                }
                else
                {
                    try
                    {
                        DataTable dt = new DataTable();
                        foreach (DataGridViewColumn col in GBS.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in GBS.Rows)
                        {
                            DataRow dRow = dt.NewRow();
                            foreach (DataGridViewCell cell in row.Cells)
                            {
                                dRow[cell.ColumnIndex] = cell.Value;
                            }
                            dt.Rows.Add(dRow);
                        }

                        foreach (DataRow DataRow in dt.Rows)
                        {
                            for (int j = 0; j < DataRow.ItemArray.Length; j++)
                            {
                                if (DataRow.ItemArray[j] == DBNull.Value)
                                    DataRow.SetField(j, string.Empty);
                            }
                        }
                        dt.TableName = table_name;
                        dt.WriteXml(Program.prj_var_prj_path + "\\" + table_name + ".db", XmlWriteMode.WriteSchema);

                    }
                    catch (Exception ex)
                    {
                        //ErrorShow("0x3b", "Не удалось создать резервную копию файла подкачки! (Код 2)! " + ex.Message);
                    }

                }
            }
            catch (Exception ex)
            {
                //ErrorShow("0x3c", "Произошла ошибка во время импорта таблицы из файла подкачки  (Код 3)! " + ex.Message);
            }
        }

        public void setGoodCardData(string code, string name, string shortname, string tags, string barcode, string minreq, string buying, string upcoming, string group, string defaultenter, bool fast, bool notforselling, bool notforbuying, bool constprice,bool invisiblePrice)
        {
            GBS.Rows.Add();
            int lastRow = GBS.Rows.Count-1;

            if (code != null) GBS["GBSCode", lastRow].Value = code;
            if (name != null) GBS["GBSName", lastRow].Value = name;
            if (shortname != null) GBS["GBSShortNameColumn", lastRow].Value = shortname;
            if (tags != null) GBS["GBSTagsColumn", lastRow].Value = tags;
            if (barcode != null) GBS["GBSBarcodeColumn", lastRow].Value = barcode;
            if (minreq != null) GBS["GBSMinReqColumn", lastRow].Value = minreq;
            if (buying != null) GBS["GBSBuyingColumn", lastRow].Value = buying;
           // if (upcoming != null) GBS[7, lastRow].Value = upcoming;
            if (group != null) GBS["GBSGroupColumn", lastRow].Value = group;
            if (defaultenter != null) GBS["GBDDefaultEnterColumn", lastRow].Value = defaultenter;

            GBS["boolGBSFast", lastRow].Value = fast;
            GBS["boolGBSNotSelling", lastRow].Value = notforbuying;
            GBS["boolGBSNotBuying", lastRow].Value = notforselling;
            GBS["boolGBSConstPrice", lastRow].Value = constprice;
            GBS["boolGBSInvisible", lastRow].Value = invisiblePrice;

            GBS["GBSLengthColumn", lastRow].Value = shortname.Length;
            //string buying, string upcoming, string group, string defaultenter, bool fast, bool notforselling, bool notforbuying, bool invisiblePrice)
        }

        public void UpdateMinBalanceByID(string ID, string new_data)
        {
           int index =  Program.mathProcessor.GetGBSRowByID(ID);
            GBS["GBSMinBalance", index].Value = new_data;
        }

        public void UpdateMaxBalanceByID(string ID, string new_data)
        {
            int index = Program.mathProcessor.GetGBSRowByID(ID);
            GBS["GBSMaxBalance", index].Value = new_data;
        }

    }

}