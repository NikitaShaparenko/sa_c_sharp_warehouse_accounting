using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Xml;

namespace WarehouseAccounting
{

    public partial class Startup : Form
    {
        string lcl_prefix = "{ Окно загрузки }";

        bool step1 = false; //Проверка наличия всех файлов в каталоге
        bool step2 = false; //Определяем язык и работаем с ним
        bool step3 = false; //Подготавливаем ресуры
        bool step4 = false; //Прогрузка 

        int lst_percents = -1;

        public string curdir = Directory.GetCurrentDirectory();

        public string mui_data;
        int percs = 0;

        public Startup()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
            Program.log.setToLog(lcl_prefix,2, "0xm0", "Старт программы", "ok");
        }

        private void Startup_Load(object sender, EventArgs e)
        {
            bgw.RunWorkerAsync();
            bgwLicensed.RunWorkerAsync();
        }

        private void Tpb_Tick(object sender, EventArgs e)
        {
            
            txtpb.Text = percs + "%";
            if (lst_percents != percs) Program.log.setToLog(lcl_prefix,2, "0xp0", "Загрузка..." + txtpb.Text, "ok");
            lst_percents = percs;
        }

        private void Bgw_DoWork(object sender, DoWorkEventArgs e)
        {
            //step 1

            var culture = System.Globalization.CultureInfo.CurrentCulture;

            try
            {
                if (!File.Exists(curdir + "\\baze.xml")) ErrorShow("0x01a", "Не найден файл: baze.xml");
                if (!File.Exists(curdir + "\\lang\\default.lang")) ErrorShow("0x01a", "Не найден файл: default.lang");

                System.Threading.Thread.Sleep(2000);
                percs = 20;
                step1 = true;
            }
            catch (Exception ex)
            {
                ErrorShow("0x01a", ex.Message);
            }
            finally
            {
                try
                {
                    if (culture.ToString() == "ru-RU")
                    {
                        if (File.Exists(curdir + "\\lang\\russian.lang"))
                        {
                            LoadMUILang(curdir + "\\lang\\russian.lang");
                        }
                        else
                        {
                            if (File.Exists(curdir + "\\lang\\default.lang"))
                            {
                                LoadMUILang(curdir + "\\lang\\default.lang");
                            }
                            else
                            {
                                ErrorShow("0x01b", "Невозможно загрузить текущий язык");
                            }
                        }
                    }
                    else if (culture.ToString() == "uk-UA")
                    {
                        if (File.Exists(curdir + "\\lang\\ukraine.lang"))
                        {
                            LoadMUILang(curdir + "\\lang\\ukraine.lang");
                        }
                        else
                        {
                            if (File.Exists(curdir + "\\lang\\default.lang"))
                            {
                                LoadMUILang(curdir + "\\lang\\default.lang");
                            }
                            else
                            {
                                ErrorShow("0x01b", "Невозможно загрузить текущий язык");
                            }
                        }
                    }
                    else
                    {
                        if (File.Exists(curdir + "\\lang\\english.lang"))
                        {
                            LoadMUILang(curdir + "\\lang\\english.lang");
                        }
                        else
                        {
                            if (File.Exists(curdir + "\\lang\\default.lang"))
                            {
                                LoadMUILang(curdir + "\\lang\\default.lang");
                            }
                            else
                            {
                                ErrorShow("0x01b", "Невозможно загрузить текущий язык");
                            }
                        }
                    }
                    percs = 50;
                    step2 = true;

                }
                catch (Exception exa)
                {
                    ErrorShow("0x01b", exa.Message);
                }
                finally
                {
                    try
                    {
                        if (culture.ToString() == "ru-RU")
                        {
                            if (File.Exists(curdir + "\\lang\\russian.mui"))
                            {
                                LoadMUI(curdir + "\\lang\\russian.mui");
                            }
                            else
                            {
                                if (File.Exists(curdir + "\\lang\\default.mui"))
                                {
                                    LoadMUI(curdir + "\\lang\\default.mui");
                                }
                                else
                                {
                                    ErrorShow("0x01b", "Невозможно загрузить текущий язык");
                                }
                            }
                        }
                        else if (culture.ToString() == "uk-UA")
                        {
                            if (File.Exists(curdir + "\\lang\\ukraine.mui"))
                            {
                                LoadMUI(curdir + "\\lang\\ukraine.mui");
                            }
                            else
                            {
                                if (File.Exists(curdir + "\\lang\\default.mui"))
                                {
                                    LoadMUI(curdir + "\\lang\\default.mui");
                                }
                                else
                                {
                                    ErrorShow("0x01b", "Невозможно загрузить текущий язык");
                                }
                            }
                        }
                        else
                        {
                            if (File.Exists(curdir + "\\lang\\english.mui"))
                            {
                                LoadMUI(curdir + "\\lang\\english.mui");
                            }
                            else
                            {
                                if (File.Exists(curdir + "\\lang\\default.mui"))
                                {
                                    LoadMUI(curdir + "\\lang\\default.mui");
                                }
                                else
                                {
                                    ErrorShow("0x01b", "Невозможно загрузить текущий язык");
                                }
                            }
                        }
                        percs = 75;
                        step3 = true;
                    }
                    catch (Exception exb)
                    {
                        ErrorShow("0x01c", exb.Message);
                    }
                    finally
                    {
                        try
                        {
                            System.Threading.Thread.Sleep(2000);
                            percs = 100;
                            step4 = true;
                        }
                        catch (Exception exc)
                        {
                            ErrorShow("0x01d", exc.Message);
                        }

                        finally
                        {
                            if (step1 && step2 && step3 && step4)
                            {
                                Close();
                            }
                        }
                    }
                }
            }

        }

       




       void ErrorShow(string err_code, string ex_data)
       {
            MessageBox.Show("Произошла ошибка во время загрузки программы:" + Environment.NewLine + "Код ошибки: " + err_code + Environment.NewLine + "Детали:" + ex_data);
            Application.Exit();
       }

        void LoadMUILang(string path)
        {
            try
            {
                mui_data = File.ReadAllText(path);
            }
            catch (Exception ex_mui)
            {
                ErrorShow("0x11", "Ошибка загрузки текста LoadMUILang" + ex_mui.Message);
            }
        }

        void LoadMUI(string path)
        {
            try
            {
                System.IO.DirectoryInfo di = new DirectoryInfo(curdir + "\\lang\\default_mui");

                if (Directory.Exists(curdir + "\\lang\\default_mui"))
                {
                    foreach (FileInfo file in di.EnumerateFiles())
                    {
                        file.Delete();
                    }
                    foreach (DirectoryInfo dir in di.EnumerateDirectories())
                    {
                        dir.Delete(true);
                    }
                }

                if (IsZipValid(path))
                {
                    ZipFile.ExtractToDirectory(path, curdir + "\\lang\\default_mui");

                    if (!File.Exists(curdir + "\\lang\\default_mui\\manifest.mf")) ErrorShow("0x22b", "Ошибка! Языковой пакет повреждён или является неполным!");

                }
                else
                {
                    ErrorShow("0x22c", "Языковой пакет повреждён или имеет неверный формат!");
                }


            }
            catch (Exception ex_mui)
            {
                ErrorShow("0x22a", "Ошибка загрузки текста LoadMUI" + ex_mui.Message);
            }
        }

        public static bool IsZipValid(string path)
        {
            try
            {
                using (var zipFile = ZipFile.OpenRead(path))
                {
                    var entries = zipFile.Entries;
                    return true;
                }
            }
            catch (InvalidDataException)
            {
                return false;
            }
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void BgwLicensed_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
               if (File.Exists(curdir + "\\license.lfu"))
               {
                    string licenser = File.ReadAllText(curdir + "\\license.lfu");
                    txtLicensed.Text = "Licensed to: " + licenser;
                    Program.log.setToLog(lcl_prefix,2, "0xl0", "Лицензия проверена для " + licenser, "ok");
                }
               else
                {
                    txtLicensed.Text = "UNLICENSED VERSION";
                    Program.log.setToLog(lcl_prefix, 0,"0xl1", "Лицензия НЕ валидна", "abort");
                }
            }
            catch
            {
                txtLicensed.Text = "UNLICENSED VERSION";
                Program.log.setToLog(lcl_prefix,0, "0xl1", "Лицензия НЕ валидна", "abort");
            }
        }
    }
}
