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
using System.Xml;

namespace WarehouseAccounting.Core
{
    public partial class AwaitingForm : Form
    {

        int percs = 25;
        string prj_path_lcl;
        string prj_settings_file;

        public AwaitingForm(string prj_path)
        {
            prj_path_lcl = prj_path;
            InitializeComponent();
        }

        private void TProgress_Tick(object sender, EventArgs e)
        {
             pbAwaiting.Value = percs;
             if (percs == 100)
            {
                Program.mainform.LeftTopItemsPanel.Visible = true;
                Program.mainform.wordTabControl.Visible = true;
                Program.mainform.actionTracker.Visible = true;
                Program.mainform.StatusPanel.Visible = true;
                Program.mainform.switcherPages.Visible = true;
                Program.mainform.TopPanel.Separator = 0;
                this.Close();
            }

        }

        string XMLParser(string source, string rq)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(source);
                string searching = xmlDoc.GetElementsByTagName(rq)[0].InnerText;
                return searching;
            }
            catch (Exception ex)
            {
                //Log(0, "0xm1", "Ошибка разбора XML Parser: " + ex.Data, "kernel panic");
                return "";
            }
        }

        string XMLSettingsParser(string rq)
        {
            return XMLParser(prj_settings_file, rq);
        }

        bool StringToBoolean(string input)
        {
            if (input == "true")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        int StringToInteger(string input)
        {
            int temp;
           if (Int32.TryParse(input,out temp))
           {
                return Int32.Parse(input);
           }
           else
           {
                return -1;
           }
        }

        bool ReadFile_Settings()
        {
            try
            {
                if (File.Exists(prj_path_lcl + "\\settings.cfg"))
                {
                    prj_settings_file = File.ReadAllText(prj_path_lcl + "\\settings.cfg");
                    if (XMLSettingsParser("file_id") == "settings")
                    {
                        Program.prj_var_prj_name = XMLSettingsParser("prj_name");
                        Program.prj_var_prj_path = XMLSettingsParser("prj_path");
                        //file_data += XMLSubCreator("crypto_passwd", Program.prj_var_crypto_passwd);
                        Program.prj_var_crypto_export = StringToBoolean(XMLSettingsParser("crypto_export"));
                        Program.prj_var_source_control = StringToBoolean(XMLSettingsParser("source_control"));
                        Program.prj_var_autosave  = StringToBoolean(XMLSettingsParser("autosave"));
                        Program.prj_var_autosave_time = StringToInteger(XMLSettingsParser("autosave_time"));
                        Program.prj_var_autoinform = StringToBoolean(XMLSettingsParser("autoinform"));
                        Program.prj_var_autoinform_telegram  = StringToBoolean(XMLSettingsParser("autoinform_telegram"));
                        Program.prj_var_autoinform_whatsapp = StringToBoolean(XMLSettingsParser("autoinform_whatsapp"));
                        Program.prj_var_autoinform_viber = StringToBoolean(XMLSettingsParser("autoinform_viber"));
                        Program.prj_var_autoinform_email  = StringToBoolean(XMLSettingsParser("autoinform_email"));
                        Program.prj_var_email_sender_address = XMLSettingsParser("email_sender_address");
                        Program.prj_var_email_sender_password = XMLSettingsParser("email_sender_password");
                        Program.prj_var_email_receiver_address = XMLSettingsParser("email_receiver_address");
                        Program.prj_var_socks5 = StringToBoolean(XMLSettingsParser("socks5"));
                        Program.prj_var_socks5_ip = XMLSettingsParser("socks5_ip");
                        Program.prj_var_socks5_port = StringToInteger(XMLSettingsParser("autosave_time"));

                        percs += 25;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }


        bool ReadFile_GBA()
        {
            if (File.Exists(prj_path_lcl + "\\GBA.db"))
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(prj_path_lcl + "\\GBA.db");
                    ds.ReadXml(prj_path_lcl + "\\GBA.db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = "GBA";

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        Program.gba.GBA.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (dt.Rows[r].ItemArray[c] != null) Program.gba.GBA.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                        }
                    }
                    percs += 25;
                    return true;
                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        bool ReadFile_GBC()
        {
            if (File.Exists(prj_path_lcl + "\\GBC.db"))
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(prj_path_lcl + "\\GBC.db");
                    ds.ReadXml(prj_path_lcl + "\\GBC.db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = "GBC";

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        Program.gbc.GBC.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (dt.Rows[r].ItemArray[c] != null) Program.gbc.GBC.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                        }
                    }
                    percs += 25;
                    return true;
                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        bool ReadFile_GBG()
        {
            if (File.Exists(prj_path_lcl + "\\GBG.db"))
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(prj_path_lcl + "\\GBG.db");
                    ds.ReadXml(prj_path_lcl + "\\GBG.db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = "GBG";

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        Program.gbg.GBG.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (dt.Rows[r].ItemArray[c] != null) Program.gbg.GBG.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                        }
                    }
                    percs += 25;
                    return true;
                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        bool ReadFile_GBP()
        {
            if (File.Exists(prj_path_lcl + "\\GBP.db"))
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(prj_path_lcl + "\\GBP.db");
                    ds.ReadXml(prj_path_lcl + "\\GBP.db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = "GBP";

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        Program.gbp.GBP.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (dt.Rows[r].ItemArray[c] != null) Program.gbp.GBP.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                        }
                    }
                    percs += 25;
                    return true;
                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
        bool ReadFile_GBV()
        {
            if (File.Exists(prj_path_lcl + "\\GBV.db"))
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(prj_path_lcl + "\\GBV.db");
                    ds.ReadXml(prj_path_lcl + "\\GBV.db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = "GBV";

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        Program.gbv.GBV.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (dt.Rows[r].ItemArray[c] != null) Program.gbv.GBV.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                        }
                    }
                    percs += 25;
                    return true;
                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        bool ReadFile_GBH()
        {
            if (File.Exists(prj_path_lcl + "\\gbh.db"))
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(prj_path_lcl + "\\gbh.db");
                    ds.ReadXml(prj_path_lcl + "\\gbh.db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = "GBH";

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        Program.gbh.GBH.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (dt.Rows[r].ItemArray[c] != null) Program.gbh.GBH.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                        }
                    }

                    percs += 25;
                    return true;
                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        bool ReadFile_GBS()
        {
            if (File.Exists(prj_path_lcl + "\\GBS.db"))
            {
                try
                {
                    DataSet ds = new DataSet();
                    ds.ReadXmlSchema(prj_path_lcl + "\\GBS.db");
                    ds.ReadXml(prj_path_lcl + "\\GBS.db");
                    DataTable dt = new DataTable();

                    dt = ds.Tables[0];
                    dt.TableName = "GBS";

                    for (int r = 0; r < dt.Rows.Count; r++)
                    {
                        Program.gbs.GBS.Rows.Add();
                        for (int c = 0; c < dt.Columns.Count; c++)
                        {
                            if (dt.Rows[r].ItemArray[c] != null) Program.gbs.GBS.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                        }
                    }

                    percs += 25;
                    return true;
                }
                catch (Exception ex)
                {
                    //ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        private void BwLoadSettings_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ReadFile_Settings())
            {
                percs = 25;
            }
            else
            {
                MessageBox.Show(this, "Ошибка!", "Невозможно загрузить файлы настроек проекта!", MessageBoxButtons.OK);
            }
        }

        private void BwLoadGBH_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ReadFile_GBH() && ReadFile_GBA() && ReadFile_GBC() && ReadFile_GBG() && ReadFile_GBP() && ReadFile_GBS() && ReadFile_GBV())
            {
                percs += 25;
            }
            else
            {
                MessageBox.Show(this, "Ошибка!", "Невозможно загрузить файлы глобальной базы истории!", MessageBoxButtons.OK);
            }
        }

        private void BwLoadGBS_DoWork(object sender, DoWorkEventArgs e)
        {
            if (ReadFile_Settings())
            {
                percs += 25;
            }
            else
            {
                MessageBox.Show(this, "Ошибка!", "Невозможно загрузить файлы глобальной базы сигнатур!", MessageBoxButtons.OK);
            }
        }

        private void AwaitingForm_Load(object sender, EventArgs e)
        {
            //bwLoadSettings.RunWorkerAsync();
            //bwLoadGBH.RunWorkerAsync();
            //bwLoadGBS.RunWorkerAsync();

            percs += 25;
            ReadFile_GBH();
            ReadFile_GBS();
            ReadFile_Settings();
        }
    }
}
