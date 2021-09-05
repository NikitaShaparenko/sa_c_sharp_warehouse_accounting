﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WarehouseAccounting.Core
{
    public partial class GlobalBaseGroups : Form
    {
        public GlobalBaseGroups()
        {
            InitializeComponent();
            GBG.Rows.Add();
            cur_row = GBG.Rows.Count - 1;
        }

        int cur_row = 0;

        public void GBGAddToTable(string str)
        {
            GBG.Rows.Add(str);
        }

        private void GBG_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        const string table_name = "GBG";

        public void SaveXSD()
        {
            try
            {

                for (int r = 0; r < GBG.Rows.Count; r++)
                {
                    for (int c = 0; c < GBG.Columns.Count; c++)
                    {
                        if (GBG[c, r].Value != null)
                        {
                            if (GBG[c, r].Value.ToString() == "") GBG[c, r].Value = " ";
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
                        foreach (DataGridViewColumn col in GBG.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in GBG.Rows)
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
                        foreach (DataGridViewColumn col in GBG.Columns)
                        {
                            dt.Columns.Add(col.Name);
                        }

                        foreach (DataGridViewRow row in GBG.Rows)
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