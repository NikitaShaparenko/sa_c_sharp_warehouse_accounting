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
    public partial class GlobalBaseActions : Form
    {
        public GlobalBaseActions()
        {
            InitializeComponent();
        }
        const string table_name = "GBA";
        public void SaveXSD()
        {
            try
            {

                for (int r = 0; r < GBA.Rows.Count; r++)
                {
                    for (int c = 0; c < GBA.Columns.Count; c++)
                    {
                        if (GBA[c, r].Value != null)
                        {
                            if (GBA[c, r].Value.ToString() == "") GBA[c, r].Value = " ";
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
                        foreach (DataGridViewColumn col in GBA.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in GBA.Rows)
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
                        foreach (DataGridViewColumn col in GBA.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in GBA.Rows)
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


    }



}
