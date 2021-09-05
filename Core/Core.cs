using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Compression;

namespace WarehouseAccounting.Core
{
    class Core
    {
        private List<Headers> HeadersAllocation = new List<Headers>();
        private List<Header_Functions> HeadersFunctionAllocation = new List<Header_Functions>();

        public string ExcelImportPath = "";
        public Core()
        {
            HeadersAllocation.Add(Headers.MainStaticHeader);
            HeadersFunctionAllocation.Add(Header_Functions.Main);
        }

        public enum Headers
        {
            MainStaticHeader,
            Header1,
            Header2,
            Header3,
            Header4,
            Header5,
            Header6,
            Header7,
            Header8,
            Header9
        }

        public enum Header_Functions
        {
            Contragents,
            Avaliable_ForgottenGood,
            Avaliable_EnteringPreorder,
            Avaliable_Revizion,
            Avaliable_Sorting,
            Goods_Barcode,
            Goods_Reduction,
            Goods_Images,
            Goods_Providers,
            Goods_Tags,
            Goods_Groups,
            Goods_Default,
            Goods_Links,
            Goods_MinBalance,
            Goods_MaxBalance,
            Goods_MinRequest,
            Prices_PriceLists,
            Prices_Dependence,
            Prices_PriceProviders,
            Price_Settings,
            Buying_OutCart,
            Selling_BackClient,
            Main,

            Custom_Contragent,
            Custom_Contragent_Checking,
            Custom_Goods,
            Custom_Goods_Barcodes,
            Custom_Goods_Barcodes_Settings_Preview,
            Custom_Goods_Short_Name,
            Custom_History,
            Custom_Orders,
            Custom_Orders_2,
            Custom_Prices,
            Custom_Prices_Dynamic_Upcoming,
            Custom_Prices_Static_Upcoming,
            Custom_Requests,
            Custom_Requests2,

        }

        public void CoreOpenProject(string path, bool isProtected)
        {
            // TODO: OpenProject

            if (isProtected)
            {
                PasswordEntering pe = new PasswordEntering(path, Path.GetFileName(Path.GetDirectoryName(path)) + "\\" + Path.GetFileName(path));
                if (pe.ShowDialog() != DialogResult.OK)
                {
                    return;
                }
            }
            else
            {
                  if (IsZipValid(path))
                {
                    if (Directory.Exists((Path.GetDirectoryName(path))))
                    {
                       DirectoryInfo di = new DirectoryInfo((Path.GetDirectoryName(path)));

                        foreach (FileInfo file in di.GetFiles())
                        {
                            if (file.Name != Path.GetFileName(path)) file.Delete();
                        }
                        foreach (DirectoryInfo dir in di.GetDirectories())
                        {
                            dir.Delete(true);
                        }

                    }
                    System.IO.Compression.ZipFile.ExtractToDirectory(path, Path.GetDirectoryName(path),Encoding.Default);
                }
            }

            AwaitingForm af = new AwaitingForm(Path.GetDirectoryName(path));
            af.ShowDialog();
        }

       

        public static bool IsZipValid(string path)
        {
            try
            {
                using (var zipFile = System.IO.Compression.ZipFile.OpenRead(path))
                {
                    var entries = zipFile.Entries;
                    return true;
                }
            }
            catch (Exception Ex)
            {
                return false;
            }
        }

      
        public void UI_Mode_Goods_SetBarcode()
        {
            AddHeader(Header_Functions.Goods_Barcode);
        }

        public void UI_Mode_Goods_SetImages()
        {
            AddHeader(Header_Functions.Goods_Images);
        }

        public void UI_Mode_Selling_SetBackClient()
        {
            AddHeader(Header_Functions.Selling_BackClient);
        }

        public void UI_Mode_Buying_SetOutCart()
        {
            AddHeader(Header_Functions.Buying_OutCart);
        }

        public void UI_Mode_Goods_SetReduction()
        {
            AddHeader(Header_Functions.Goods_Reduction);
        }

        public void UI_Mode_Goods_SetProviders()
        {
            AddHeader(Header_Functions.Goods_Providers);
        }

        public void UI_Mode_Goods_SetTags()
        {
            AddHeader(Header_Functions.Goods_Tags);
        }

        public void UI_Mode_Goods_Set()
        {

        }

        public void UI_Mode_Goods_SetGroups()
        {
            ComboBox temp = Program.mathProcessor.GBG_ComboBox_Selector();
            AddHeader(Header_Functions.Goods_Groups);
            //Program.mainform.switcherPages.tabC.SelectedIndex = 5;
            //(Program.mainform.switcherPages.dgvGroups.Columns[0] as DataGridViewComboBoxColumn).Items.AddRange(temp.Items);
            //Program.mainform.switcherPages.dgvGroupList.Columns[0].DatasSource = temp.Items;

            foreach(var cmb_item in temp.Items)
            {
                (Program.gbs.GBS.Columns["GBSGroupColumn"] as DataGridViewComboBoxColumn).Items.Add(cmb_item);
                (Program.mainform.switcherPages.dgvGroups.Columns[3] as DataGridViewComboBoxColumn).Items.Add(cmb_item);
                Program.gc.txtGroup.Items.Add(cmb_item);
            }
           
           // Program.mainform.switcherPages.dgvGroups.Column
        }

        public void UI_Mode_Goods_SetDefault()
        {
            Program.mainform.switcherPages.tabC.SelectedIndex = 5;
            AddHeader(Header_Functions.Goods_Default);
        }

        public void UI_Mode_Goods_SetLinks()
        {

            AddHeader(Header_Functions.Goods_Links);
        }

        public void UI_Mode_Prices_SetPriceProviders()
        {
            AddHeader(Header_Functions.Prices_PriceProviders);
        }

        public void UI_Mode_Goods_SetMinRequest()
        {
            Program.mainform.switcherPages.tabC.SelectedIndex =9;
            AddHeader(Header_Functions.Goods_MinRequest);
        }

        public void UI_Mode_Goods_SetMinBalance()
        {
            Program.mainform.switcherPages.tabC.SelectedIndex = 7;
            AddHeader(Header_Functions.Goods_MinBalance);
        } 

        public void UI_Mode_Goods_SetMaxBalance()
        {
            Program.mainform.switcherPages.tabC.SelectedIndex = 8;
            AddHeader(Header_Functions.Goods_MaxBalance);
        }

        public void UI_Mode_Prices_SetSettings()
        {
            AddHeader(Header_Functions.Price_Settings);
        }

        public void UI_Mode_Prices_SetDependence()
        {
            AddHeader(Header_Functions.Prices_Dependence);
        }
        public void UI_Mode_Prices_SetPriceLists()
        {
            AddHeader(Header_Functions.Prices_PriceLists);

        }

        public void UI_Mode_Avaliable_EnteringPreorder()
        {
            AddHeader(Header_Functions.Avaliable_EnteringPreorder);
        }

        public void UI_Mode_Avaliable_ForgottenGood()
        {
            AddHeader(Header_Functions.Avaliable_ForgottenGood);
        }

        public void UI_Mode_Avaliable_Sorting()
        {
            AddHeader(Header_Functions.Avaliable_Sorting);
        }

        public void UI_Mode_Avaliable_Revizion()
        {
            AddHeader(Header_Functions.Avaliable_Revizion);
        }

        public void ShowHeaderFromCache(int input)
        {
            if (HeadersFunctionAllocation.Count > input) ShowHeader(HeadersFunctionAllocation[input],true);
        }

        public void CloseHeader(Header_Functions input)
        {
            if (!HeadersFunctionAllocation.Contains(input)) return;
            int hdr = 0;
            hdr = HeadersFunctionAllocation.IndexOf(input);

            #region  OldRibbonCode
            //if (hdr == 9)
            //{
            //    Program.mainform.wordTabControl.TabHeader10.Text = "";
            //    Program.mainform.wordTabControl.TabHeader10.Visible = false ;
            //    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //}
            //else if (HeadersFunctionAllocation.Count == 10 && hdr != 9)
            //{
            //    switch(hdr)
            //    {
            //        case 8:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 7:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 6:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 5:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 4:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 3:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 2:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader3, ref Program.mainform.wordTabControl.TabHeader4);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 1:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader2, ref Program.mainform.wordTabControl.TabHeader3);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader3, ref Program.mainform.wordTabControl.TabHeader4);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        case 0:
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader1, ref Program.mainform.wordTabControl.TabHeader2);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader2, ref Program.mainform.wordTabControl.TabHeader3);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader3, ref Program.mainform.wordTabControl.TabHeader4);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //            SwapHeaders(ref Program.mainform.wordTabControl.TabHeader9, ref Program.mainform.wordTabControl.TabHeader10);
            //            break;
            //        default:
            //            Program.mainform.wordTabControl.TabHeader10.Text = "";
            //            Program.mainform.wordTabControl.TabHeader10.Visible = false;
            //            Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            break;
            //    }

            //}
            //else if (HeadersFunctionAllocation.Count < 10)
            //{
            //    int hfac = HeadersFunctionAllocation.Count;
            //    switch (hdr)
            //    {
            //        case 8:
            //            Program.mainform.wordTabControl.TabHeader9.Text = ""; //hfac == hdr
            //            Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //            Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            break;
            //        case 7:
            //            if (hfac == 8)
            //                {
            //                    SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                    Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                    Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //                }

            //            break;
            //        case 6:

            //                if (hfac == 7)
            //                {
            //                    SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //                    Program.mainform.wordTabControl.TabHeader8.Text = "";
            //                    Program.mainform.wordTabControl.TabHeader8.Visible = false;
            //                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //                }
            //               else if (hfac == 8)
            //                {
            //                    SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                    Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                    Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //                 }
            //            break;
            //        case 5:
            //            if (hfac == 6)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //                Program.mainform.wordTabControl.TabHeader7.Text = "";
            //                Program.mainform.wordTabControl.TabHeader7.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 7)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //                Program.mainform.wordTabControl.TabHeader8.Text = "";
            //                Program.mainform.wordTabControl.TabHeader8.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 8)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            break;
            //        case 4:
            //            if (hfac == 5)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //                Program.mainform.wordTabControl.TabHeader6.Text = "";
            //                Program.mainform.wordTabControl.TabHeader6.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //           else if (hfac == 6)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //                Program.mainform.wordTabControl.TabHeader7.Text = "";
            //                Program.mainform.wordTabControl.TabHeader7.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 7)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //                Program.mainform.wordTabControl.TabHeader8.Text = "";
            //                Program.mainform.wordTabControl.TabHeader8.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 8)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            break;
            //        case 3:
            //            if (hfac == 4)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //                Program.mainform.wordTabControl.TabHeader5.Text = "";
            //                Program.mainform.wordTabControl.TabHeader5.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 5)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //                Program.mainform.wordTabControl.TabHeader6.Text = "";
            //                Program.mainform.wordTabControl.TabHeader6.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 6)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //                Program.mainform.wordTabControl.TabHeader7.Text = "";
            //                Program.mainform.wordTabControl.TabHeader7.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 7)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //                Program.mainform.wordTabControl.TabHeader8.Text = "";
            //                Program.mainform.wordTabControl.TabHeader8.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 8)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            break;
            //        case 2:
            //             if (hfac == 3)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader3, ref Program.mainform.wordTabControl.TabHeader4);
            //                Program.mainform.wordTabControl.TabHeader4.Text = "";
            //                Program.mainform.wordTabControl.TabHeader4.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //           else if (hfac == 4)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //                Program.mainform.wordTabControl.TabHeader5.Text = "";
            //                Program.mainform.wordTabControl.TabHeader5.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 5)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //                Program.mainform.wordTabControl.TabHeader6.Text = "";
            //                Program.mainform.wordTabControl.TabHeader6.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 6)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //                Program.mainform.wordTabControl.TabHeader7.Text = "";
            //                Program.mainform.wordTabControl.TabHeader7.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 7)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //                Program.mainform.wordTabControl.TabHeader8.Text = "";
            //                Program.mainform.wordTabControl.TabHeader8.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 8)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            break;
            //        case 1:
            //            if (hfac == 2)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader2, ref Program.mainform.wordTabControl.TabHeader3);
            //                Program.mainform.wordTabControl.TabHeader3.Text = "";
            //                Program.mainform.wordTabControl.TabHeader3.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 3)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader3, ref Program.mainform.wordTabControl.TabHeader4);
            //                Program.mainform.wordTabControl.TabHeader4.Text = "";
            //                Program.mainform.wordTabControl.TabHeader4.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 4)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //                Program.mainform.wordTabControl.TabHeader5.Text = "";
            //                Program.mainform.wordTabControl.TabHeader5.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 5)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //                Program.mainform.wordTabControl.TabHeader6.Text = "";
            //                Program.mainform.wordTabControl.TabHeader6.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 6)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //                Program.mainform.wordTabControl.TabHeader7.Text = "";
            //                Program.mainform.wordTabControl.TabHeader7.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 7)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //                Program.mainform.wordTabControl.TabHeader8.Text = "";
            //                Program.mainform.wordTabControl.TabHeader8.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 8)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            break;
            //        case 0:
            //            if (hfac == 1)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader1, ref Program.mainform.wordTabControl.TabHeader2);
            //                Program.mainform.wordTabControl.TabHeader2.Text = "";
            //                Program.mainform.wordTabControl.TabHeader2.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 2)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader2, ref Program.mainform.wordTabControl.TabHeader3);
            //                Program.mainform.wordTabControl.TabHeader3.Text = "";
            //                Program.mainform.wordTabControl.TabHeader3.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 3)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader3, ref Program.mainform.wordTabControl.TabHeader4);
            //                Program.mainform.wordTabControl.TabHeader4.Text = "";
            //                Program.mainform.wordTabControl.TabHeader4.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 4)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader4, ref Program.mainform.wordTabControl.TabHeader5);
            //                Program.mainform.wordTabControl.TabHeader5.Text = "";
            //                Program.mainform.wordTabControl.TabHeader5.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 5)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader5, ref Program.mainform.wordTabControl.TabHeader6);
            //                Program.mainform.wordTabControl.TabHeader6.Text = "";
            //                Program.mainform.wordTabControl.TabHeader6.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 6)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader6, ref Program.mainform.wordTabControl.TabHeader7);
            //                Program.mainform.wordTabControl.TabHeader7.Text = "";
            //                Program.mainform.wordTabControl.TabHeader7.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 7)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader7, ref Program.mainform.wordTabControl.TabHeader8);
            //                Program.mainform.wordTabControl.TabHeader8.Text = "";
            //                Program.mainform.wordTabControl.TabHeader8.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            else if (hfac == 8)
            //            {
            //                SwapHeaders(ref Program.mainform.wordTabControl.TabHeader8, ref Program.mainform.wordTabControl.TabHeader9);
            //                Program.mainform.wordTabControl.TabHeader9.Text = "";
            //                Program.mainform.wordTabControl.TabHeader9.Visible = false;
            //                Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            }
            //            break;
            //        default:
            //            Program.mainform.wordTabControl.TabHeader10.Text = "";
            //            Program.mainform.wordTabControl.TabHeader10.Visible = false;
            //            Program.mainform.wordTabControl.tabPanel.Controls.Clear();
            //            break;
            //    }
            //}
            #endregion

            HeadersFunctionAllocation.Remove(input);

            Program.mainform.wordTabControl.TabHeader1.Visible = true;

            Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = false;
            Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
            Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

            Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(220, 70, 40);
            Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
            Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

            Program.mainform.wordTabControl.TabHeader1.ShowBorder = true;
            Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
            Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

            Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader1.Location.X,
                                            Program.mainform.wordTabControl.TabHeader1.Location.X + Program.mainform.wordTabControl.TabHeader1.Width);
            ShowHeader(Header_Functions.Main);
            UpdateUIRibbon();

        }

        void UpdateUIRibbon()
        {
            if (HeadersFunctionAllocation.Count < 1) return;
            int nums = HeadersFunctionAllocation.Count;
            Program.mainform.wordTabControl.TabHeader1.Text = "";
            Program.mainform.wordTabControl.TabHeader2.Text = "";
            Program.mainform.wordTabControl.TabHeader3.Text = "";
            Program.mainform.wordTabControl.TabHeader4.Text = "";
            Program.mainform.wordTabControl.TabHeader5.Text = "";
            Program.mainform.wordTabControl.TabHeader6.Text = "";
            Program.mainform.wordTabControl.TabHeader7.Text = "";
            Program.mainform.wordTabControl.TabHeader8.Text = "";
            Program.mainform.wordTabControl.TabHeader9.Text = "";
            Program.mainform.wordTabControl.TabHeader10.Text = "";
            for (int i = 0; i<nums;i++)
            {
                ShowHeader(HeadersFunctionAllocation[i], true, true);
            }
        }

        void SwapHeaders(ref WarehouseAccounting.TabButton hdr_s, ref WarehouseAccounting.TabButton hdr_d)
        {
            WarehouseAccounting.TabButton tmp;
            tmp = hdr_d;
            hdr_d = hdr_s;
            hdr_s = tmp;
        }


        public void ShowHeader(Header_Functions input)
        {
            switch (input)
            {
                case Header_Functions.Avaliable_EnteringPreorder:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_entering_balance.Location = new Point(1, 1);
                    Program.ribbonsub_aval_entering_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_entering_balance);
                    NameNewTab("Ввод остатков");

                    break;

                case Header_Functions.Avaliable_ForgottenGood:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_forgotten_good.Location = new Point(1, 1);
                    Program.ribbonsub_aval_forgotten_good.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_forgotten_good);
                    NameNewTab("Списание");
                    break;
                case Header_Functions.Avaliable_Revizion:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_revizion.Location = new Point(1, 1);
                    Program.ribbonsub_aval_revizion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_revizion);
                    NameNewTab("Ревизия");
                    break;
                case Header_Functions.Avaliable_Sorting:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_sorting.Location = new Point(1, 1);
                    Program.ribbonsub_aval_sorting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_sorting);
                    NameNewTab("Пересортица");
                    break;
                case Header_Functions.Contragents:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_contragents.Location = new Point(1, 1);
                    Program.ribbonsub_contragents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_contragents);
                    NameNewTab("Контрагенты");
                    break;
                case Header_Functions.Goods_Barcode:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_barcode.Location = new Point(1, 1);
                    Program.ribbonsub_goods_barcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_barcode);
                    NameNewTab("Штрих-код");
                    break;
                case Header_Functions.Goods_Default:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_default.Location = new Point(1, 1);
                    Program.ribbonsub_goods_default.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_default);
                    NameNewTab("Ввод по умолчанию");
                    break;
                case Header_Functions.Goods_Groups:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_groups.Location = new Point(1, 1);
                    Program.ribbonsub_goods_groups.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_groups);
                    NameNewTab("Группы");
                    break;
                case Header_Functions.Goods_Images:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_images.Location = new Point(1, 1);
                    Program.ribbonsub_goods_images.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_images);
                    NameNewTab("Рисунки");
                    break;
                case Header_Functions.Goods_Links:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_links.Location = new Point(1, 1);
                    Program.ribbonsub_goods_links.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_links);
                    NameNewTab("Связи");
                    break;
                case Header_Functions.Goods_MaxBalance:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_max_balance.Location = new Point(1, 1);
                    Program.ribbonsub_goods_max_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_max_balance);
                    NameNewTab("Максимальный остаток");
                    break;
                case Header_Functions.Goods_MinBalance:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_min_balance.Location = new Point(1, 1);
                    Program.ribbonsub_goods_min_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_min_balance);
                    NameNewTab("Минимальный остаток");
                    break;
                case Header_Functions.Goods_MinRequest:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_min_req.Location = new Point(1, 1);
                    Program.ribbonsub_goods_min_req.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_min_req);
                    NameNewTab("Минимальная завка");
                    break;
                case Header_Functions.Goods_Providers:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_providers.Location = new Point(1, 1);
                    Program.ribbonsub_goods_providers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_providers);
                    NameNewTab("Коды поставщиков");
                    break;
                case Header_Functions.Goods_Reduction:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_reduction.Location = new Point(1, 1);
                    Program.ribbonsub_goods_reduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_reduction);
                    NameNewTab("Сокращения");
                    break;
                case Header_Functions.Goods_Tags:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_tags.Location = new Point(1, 1);
                    Program.ribbonsub_goods_tags.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_tags);
                    NameNewTab("Теги");
                    break;

                case Header_Functions.Buying_OutCart:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_buying.Location = new Point(1, 1);
                    Program.ribbonsub_buying.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_buying);
                    NameNewTab("Возрат поставщику");
                    break;

                case Header_Functions.Selling_BackClient:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_selling.Location = new Point(1, 1);
                    Program.ribbonsub_selling.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_selling);
                    NameNewTab("Возрат клиенту");
                    break;

                case Header_Functions.Main:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.hc.Location = new Point(1, 1);
                    Program.hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.hc);
                    NameNewTab("Главная");
                    break;

                case Header_Functions.Price_Settings:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_settings.Location = new Point(1, 1);
                    Program.ribbonsub_prices_settings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_settings);
                    NameNewTab("Настройки");
                    break;

                case Header_Functions.Prices_PriceLists:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_pricelist.Location = new Point(1, 1);
                    Program.ribbonsub_prices_pricelist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_pricelist);
                    NameNewTab("Ценники");
                    break;

                case Header_Functions.Prices_Dependence:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_dependences.Location = new Point(1, 1);
                    Program.ribbonsub_prices_dependences.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_dependences);
                    NameNewTab("Зависимости");
                    break;

                case Header_Functions.Prices_PriceProviders:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_priceproviders.Location = new Point(1, 1);
                    Program.ribbonsub_prices_priceproviders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_priceproviders);
                    NameNewTab("Цены поставщиков");
                    break;
               case Header_Functions.Custom_Contragent:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_contragents.Location = new Point(1, 1);
                    Program.ribbonsub_custom_contragents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_contragents);
                    NameNewTab("Контрагенты");
                    break;
                case Header_Functions.Custom_Contragent_Checking:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_contragents_checking.Location = new Point(1, 1);
                    Program.ribbonsub_contragents_checking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_contragents_checking);
                    NameNewTab("Контрагенты");
                    break;
                case Header_Functions.Custom_Goods:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods);
                    NameNewTab("Товары");
                    break;
                case Header_Functions.Custom_Goods_Barcodes:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_barcode.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_barcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_barcode);
                    NameNewTab("Штрих-коды");
                    break;
                case Header_Functions.Custom_Goods_Barcodes_Settings_Preview:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_barcodes_preview.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_barcodes_preview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_barcodes_preview);
                    NameNewTab("Штрих-коды");
                    break;
                case Header_Functions.Custom_Goods_Short_Name:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_shortname.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_shortname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_shortname);
                    NameNewTab("Сокращения");
                    break;
                case Header_Functions.Custom_History:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_history.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_history.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_history);
                    NameNewTab("История");
                    break;
                case Header_Functions.Custom_Orders:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_orders.Location = new Point(1, 1);
                    Program.ribbonsub_custom_orders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_orders);
                    NameNewTab("Заказы");
                    break;
                case Header_Functions.Custom_Orders_2:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_orders2.Location = new Point(1, 1);
                    Program.ribbonsub_custom_orders2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_orders2);
                    NameNewTab("Заказы");
                    break;
                case Header_Functions.Custom_Prices:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices);
                    NameNewTab("Цены");
                    break;
                case Header_Functions.Custom_Prices_Dynamic_Upcoming:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices_dynamic_upcoming.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices_dynamic_upcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices_dynamic_upcoming);
                    NameNewTab("Накрутка");
                    break;
                case Header_Functions.Custom_Prices_Static_Upcoming:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices_static_upcoming.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices_static_upcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices_static_upcoming);
                    NameNewTab("Наценка");
                    break;
                case Header_Functions.Custom_Requests:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_requests.Location = new Point(1, 1);
                    Program.ribbonsub_custom_requests.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_requests);
                    NameNewTab("Заказы");
                    break;
                case Header_Functions.Custom_Requests2:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_requests2);
                    NameNewTab("Цены");
                    break;
                default:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.hc.Location = new Point(1, 1);
                    Program.hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.hc);
                    NameNewTab("Главная");
                    break;
            }
        }

        void ListReplace(Header_Functions input, Header_Functions input2)
        {
            if (!HeadersFunctionAllocation.Contains(input)) return;
            int num1 = HeadersFunctionAllocation.IndexOf(input);
            HeadersFunctionAllocation.RemoveAt(num1);
            HeadersFunctionAllocation.Insert(num1, input2);
        }

        public void ShowInto(Header_Functions input)
        {
            switch (input)
            {
                case Header_Functions.Custom_Contragent:
                    ListReplace(Header_Functions.Contragents,input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Contragent_Checking:
                    ListReplace(Header_Functions.Contragents,input);
                    ShowHeader(input, true, true);
                    break;
                
                case Header_Functions.Custom_Goods:
                    ListReplace(Header_Functions.Main,input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Goods_Barcodes:
                    ListReplace(Header_Functions.Goods_Barcode, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Goods_Barcodes_Settings_Preview:
                    ListReplace(Header_Functions.Goods_Barcode,input);
                    ShowHeader(input, true, true);
                    break;

                case Header_Functions.Custom_Goods_Short_Name:
                    ListReplace(Header_Functions.Goods_Reduction, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_History:
                    ListReplace(Header_Functions.Main,input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Orders:
                    ListReplace( Header_Functions.Main, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Orders_2:
                    ListReplace( Header_Functions.Main, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Prices:
                    ListReplace( Header_Functions.Main, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Prices_Dynamic_Upcoming:
                    ListReplace(Header_Functions.Main, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Prices_Static_Upcoming:
                    ListReplace(Header_Functions.Main, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Requests:
                    ListReplace(Header_Functions.Main, input);
                    ShowHeader(input, true, true);
                    break;
                case Header_Functions.Custom_Requests2:
                    ListReplace(Header_Functions.Main, input);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;

                default:
                    ListReplace(Header_Functions.Main, input);
                    ShowHeader(input, true, true);
                    break;
            }
        }

        public void InsertInto(Header_Functions input)
        {
            switch(input)
            {
                case Header_Functions.Custom_Contragent:
                    ListReplace(input, Header_Functions.Contragents);
                    ShowHeader(Header_Functions.Contragents, true, true);
                break;
                case Header_Functions.Custom_Contragent_Checking:
                    ListReplace(input, Header_Functions.Contragents);
                    ShowHeader(Header_Functions.Contragents, true, true);
                    break;
                case Header_Functions.Custom_Goods:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Goods_Barcodes:
                    ListReplace(input, Header_Functions.Goods_Barcode);
                    ShowHeader(Header_Functions.Goods_Barcode, true, true);
                    break;
                case Header_Functions.Custom_Goods_Barcodes_Settings_Preview:
                    ListReplace(input, Header_Functions.Goods_Barcode);
                    ShowHeader(Header_Functions.Goods_Barcode, true, true);
                    break;

                case Header_Functions.Custom_Goods_Short_Name:
                    ListReplace(input, Header_Functions.Goods_Reduction);
                    ShowHeader(Header_Functions.Contragents, true, true);
                    break;
                case Header_Functions.Custom_History:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Orders:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Orders_2:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Prices:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Prices_Dynamic_Upcoming:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Prices_Static_Upcoming:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Requests:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
                case Header_Functions.Custom_Requests2:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;

                default:
                    ListReplace(input, Header_Functions.Main);
                    ShowHeader(Header_Functions.Main, true, true);
                    break;
            }
        }

        void NameExists(string name, int input)
        {
            switch(input)
            {
                case 0: Program.mainform.wordTabControl.TabHeader1.Text = name;
                    break;
                case 1: Program.mainform.wordTabControl.TabHeader2.Text = name;
                    break;
                case 2: Program.mainform.wordTabControl.TabHeader3.Text = name;
                    break;
                case 3: Program.mainform.wordTabControl.TabHeader4.Text = name;
                    break;
                case 4: Program.mainform.wordTabControl.TabHeader5.Text = name;
                    break;
                case 5: Program.mainform.wordTabControl.TabHeader6.Text = name;
                    break;
                case 6: Program.mainform.wordTabControl.TabHeader7.Text = name;
                    break;
                case 7: Program.mainform.wordTabControl.TabHeader8.Text = name;
                    break;
                case 8: Program.mainform.wordTabControl.TabHeader9.Text = name;
                    break;
                case 9: Program.mainform.wordTabControl.TabHeader10.Text = name;
                    break;
            }
        }

        public void ShowHeader(Header_Functions input, bool noName, bool name_ex)
        {

            int place = HeadersFunctionAllocation.IndexOf(input);

            switch (input)
            {
                case Header_Functions.Avaliable_EnteringPreorder:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_entering_balance.Location = new Point(1, 1);
                    Program.ribbonsub_aval_entering_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_entering_balance);
                    NameExists("Ввод остатков", place);
                    break;

                case Header_Functions.Avaliable_ForgottenGood:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_forgotten_good.Location = new Point(1, 1);
                    Program.ribbonsub_aval_forgotten_good.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_forgotten_good);
                    NameExists("Списание", place);
                    break;

                case Header_Functions.Avaliable_Revizion:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_revizion.Location = new Point(1, 1);
                    Program.ribbonsub_aval_revizion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_revizion);
                    NameExists("Ревизия", place);
                    break;
                case Header_Functions.Avaliable_Sorting:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_sorting.Location = new Point(1, 1);
                    Program.ribbonsub_aval_sorting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_sorting);
                    NameExists("Пересортица", place);
                    break;
                case Header_Functions.Contragents:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_contragents.Location = new Point(1, 1);
                    Program.ribbonsub_contragents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_contragents);
                    NameExists("Контрагенты", place);
                    break;
                case Header_Functions.Goods_Barcode:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_barcode.Location = new Point(1, 1);
                    Program.ribbonsub_goods_barcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_barcode);
                    NameExists("Штрих-код", place);
                    break;
                case Header_Functions.Goods_Default:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_default.Location = new Point(1, 1);
                    Program.ribbonsub_goods_default.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_default);
                    NameExists("Ввод по умолчанию", place);
                    break;
                case Header_Functions.Goods_Groups:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_groups.Location = new Point(1, 1);
                    Program.ribbonsub_goods_groups.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_groups);
                    NameExists("Группы", place);
                    break;
                case Header_Functions.Goods_Images:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_images.Location = new Point(1, 1);
                    Program.ribbonsub_goods_images.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_images);
                    NameExists("Рисунки", place);
                    break;
                case Header_Functions.Goods_Links:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_links.Location = new Point(1, 1);
                    Program.ribbonsub_goods_links.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_links);
                    NameExists("Связи", place);
                    break;
                case Header_Functions.Goods_MaxBalance:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_max_balance.Location = new Point(1, 1);
                    Program.ribbonsub_goods_max_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_max_balance);
                    NameExists("Максимальный остаток", place);
                    break;
                case Header_Functions.Goods_MinBalance:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_min_balance.Location = new Point(1, 1);
                    Program.ribbonsub_goods_min_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_min_balance);
                    NameExists("Минимальный остаток", place);
                    break;
                case Header_Functions.Goods_MinRequest:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_min_req.Location = new Point(1, 1);
                    Program.ribbonsub_goods_min_req.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_min_req);
                    NameExists("Минимальная завка", place);
                    break;
                case Header_Functions.Goods_Providers:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_providers.Location = new Point(1, 1);
                    Program.ribbonsub_goods_providers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_providers);
                    NameExists("Коды поставщиков", place);
                    break;
                case Header_Functions.Goods_Reduction:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_reduction.Location = new Point(1, 1);
                    Program.ribbonsub_goods_reduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_reduction);
                    NameExists("Сокращения", place);
                    break;
                case Header_Functions.Goods_Tags:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_tags.Location = new Point(1, 1);
                    Program.ribbonsub_goods_tags.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_tags);
                    NameExists("Теги", place);
                    break;

                case Header_Functions.Buying_OutCart:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_buying.Location = new Point(1, 1);
                    Program.ribbonsub_buying.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_buying);
                    NameExists("Возрат поставщику", place);
                    break;

                case Header_Functions.Selling_BackClient:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_selling.Location = new Point(1, 1);
                    Program.ribbonsub_selling.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_selling);
                    NameExists("Возрат клиенту", place);
                    break;

                case Header_Functions.Main:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.hc.Location = new Point(1, 1);
                    Program.hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.hc);
                    NameExists("Главная", place);
                    break;

                case Header_Functions.Price_Settings:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_settings.Location = new Point(1, 1);
                    Program.ribbonsub_prices_settings.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_settings);
                    NameExists("Настройки", place);
                    break;

                case Header_Functions.Prices_PriceLists:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_pricelist.Location = new Point(1, 1);
                    Program.ribbonsub_prices_pricelist.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_pricelist);
                    NameExists("Ценники", place);
                    break;

                case Header_Functions.Prices_Dependence:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_dependences.Location = new Point(1, 1);
                    Program.ribbonsub_prices_dependences.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_dependences);
                    NameExists("Зависимости", place);
                    break;

                case Header_Functions.Prices_PriceProviders:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_prices_priceproviders.Location = new Point(1, 1);
                    Program.ribbonsub_prices_priceproviders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_prices_priceproviders);
                    NameExists("Цены поставщиков", place);
                    break;

                case Header_Functions.Custom_Contragent:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_contragents.Location = new Point(1, 1);
                    Program.ribbonsub_custom_contragents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_contragents);
                    NameExists("Контрагенты", place);
                    break;
                case Header_Functions.Custom_Contragent_Checking:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_contragents_checking.Location = new Point(1, 1);
                    Program.ribbonsub_contragents_checking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_contragents_checking);
                    NameExists("Контрагенты", place);
                    break;
                case Header_Functions.Custom_Goods:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods);
                    NameExists("Товары", place);
                    break;
                case Header_Functions.Custom_Goods_Barcodes:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_barcode.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_barcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_barcode);
                    NameExists("Товары", place);
                    break;
                case Header_Functions.Custom_Goods_Barcodes_Settings_Preview:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_barcodes_preview.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_barcodes_preview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_barcodes_preview);
                    NameExists("Штрих-коды", place);
                    break;
                case Header_Functions.Custom_Goods_Short_Name:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_shortname.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_shortname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_shortname);
                    NameExists("Сокращения", place);
                    break;
                case Header_Functions.Custom_History:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_history.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_history.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_history);
                    NameExists("История", place);
                    break;
                case Header_Functions.Custom_Orders:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_orders.Location = new Point(1, 1);
                    Program.ribbonsub_custom_orders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_orders);
                    NameExists("Заказы", place);
                    break;
                case Header_Functions.Custom_Orders_2:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_orders2.Location = new Point(1, 1);
                    Program.ribbonsub_custom_orders2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_orders2);
                    NameExists("Заказы", place);
                    break;
                case Header_Functions.Custom_Prices:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices);
                    NameExists("Цены", place); ;
                    break;
                case Header_Functions.Custom_Prices_Dynamic_Upcoming:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices_dynamic_upcoming.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices_dynamic_upcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices_dynamic_upcoming);
                    NameExists("Накрутка", place);
                    break;
                case Header_Functions.Custom_Prices_Static_Upcoming:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices_static_upcoming.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices_static_upcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices_static_upcoming);
                    NameExists("Наценка", place);
                    break;
                case Header_Functions.Custom_Requests:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_requests.Location = new Point(1, 1);
                    Program.ribbonsub_custom_requests.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_requests);
                    NameExists("Запросы", place);
                    break;
                case Header_Functions.Custom_Requests2:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_requests2);
                    NameExists("Запросы", place);
                    break;

                default:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.hc.Location = new Point(1, 1);
                    Program.hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.hc);
                    NameExists("Главная",place);
                    break;
            }
        }
        

        public void ShowHeader(Header_Functions input,bool noName)
        {
            switch (input)
            {
                case Header_Functions.Avaliable_EnteringPreorder:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_entering_balance.Location = new Point(1, 1);
                    Program.ribbonsub_aval_entering_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_entering_balance);
                    //NameNewTab("Ввод остатков");

                    break;

                case Header_Functions.Avaliable_ForgottenGood:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_forgotten_good.Location = new Point(1, 1);
                    Program.ribbonsub_aval_forgotten_good.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_forgotten_good);
                    //NameNewTab("Списание");
                    break;
                case Header_Functions.Avaliable_Revizion:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_revizion.Location = new Point(1, 1);
                    Program.ribbonsub_aval_revizion.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_revizion);
                    //NameNewTab("Ревизия");
                    break;
                case Header_Functions.Avaliable_Sorting:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_aval_sorting.Location = new Point(1, 1);
                    Program.ribbonsub_aval_sorting.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_aval_sorting);
                    //NameNewTab("Пересортица");
                    break;
                case Header_Functions.Contragents:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_contragents.Location = new Point(1, 1);
                    Program.ribbonsub_contragents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_contragents);
                    //NameNewTab("Контрагенты");
                    break;
                case Header_Functions.Goods_Barcode:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_barcode.Location = new Point(1, 1);
                    Program.ribbonsub_goods_barcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_barcode);
                    //NameNewTab("Штрих-код");
                    break;
                case Header_Functions.Goods_Default:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_default.Location = new Point(1, 1);
                    Program.ribbonsub_goods_default.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_default);
                    //NameNewTab("Ввод по умолчанию");
                    break;
                case Header_Functions.Goods_Groups:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_groups.Location = new Point(1, 1);
                    Program.ribbonsub_goods_groups.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_groups);
                    //NameNewTab("Группы");
                    break;
                case Header_Functions.Goods_Images:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_images.Location = new Point(1, 1);
                    Program.ribbonsub_goods_images.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_images);
                    //NameNewTab("Рисунки");
                    break;
                case Header_Functions.Goods_Links:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_links.Location = new Point(1, 1);
                    Program.ribbonsub_goods_links.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_links);
                    //NameNewTab("Связи");
                    break;
                case Header_Functions.Goods_MaxBalance:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_max_balance.Location = new Point(1, 1);
                    Program.ribbonsub_goods_max_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_max_balance);
                    //NameNewTab("Максимальный остаток");
                    break;
                case Header_Functions.Goods_MinBalance:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_min_balance.Location = new Point(1, 1);
                    Program.ribbonsub_goods_min_balance.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_min_balance);
                    //NameNewTab("Минимальный остаток");
                    break;
                case Header_Functions.Goods_MinRequest:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_min_req.Location = new Point(1, 1);
                    Program.ribbonsub_goods_min_req.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_min_req);
                    //NameNewTab("Минимальная завка");
                    break;
                case Header_Functions.Goods_Providers:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_providers.Location = new Point(1, 1);
                    Program.ribbonsub_goods_providers.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_providers);
                    //NameNewTab("Коды поставщиков");
                    break;
                case Header_Functions.Goods_Reduction:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_reduction.Location = new Point(1, 1);
                    Program.ribbonsub_goods_reduction.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_reduction);
                    //NameNewTab("Сокращения");
                    break;
                case Header_Functions.Goods_Tags:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_goods_tags.Location = new Point(1, 1);
                    Program.ribbonsub_goods_tags.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_goods_tags);
                    //NameNewTab("Теги");
                    break;

                case Header_Functions.Buying_OutCart:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_buying.Location = new Point(1, 1);
                    Program.ribbonsub_buying.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_buying);
                    //NameNewTab("Возрат поставщику");
                    break;

                case Header_Functions.Selling_BackClient:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_selling.Location = new Point(1, 1);
                    Program.ribbonsub_selling.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_selling);
                    //NameNewTab("Возрат поставщику");
                    break;

                case Header_Functions.Main:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.hc.Location = new Point(1, 1);
                    Program.hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.hc);
                    //NameNewTab("Главная");
                    break;

                case Header_Functions.Custom_Contragent:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_contragents.Location = new Point(1, 1);
                    Program.ribbonsub_custom_contragents.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_contragents);
                    //NameNewTab("Контрагенты");
                    break;
                case Header_Functions.Custom_Contragent_Checking:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_contragents_checking.Location = new Point(1, 1);
                    Program.ribbonsub_contragents_checking.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_contragents_checking);
                    //NameNewTab("Контрагенты");
                    break;
                case Header_Functions.Custom_Goods:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods);
                    //NameNewTab("Товары");
                    break;
                case Header_Functions.Custom_Goods_Barcodes:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_barcode.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_barcode.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_barcode);
                    //NameNewTab("Штрих-коды");
                    break;
                case Header_Functions.Custom_Goods_Barcodes_Settings_Preview:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_barcodes_preview.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_barcodes_preview.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_barcodes_preview);
                    //NameNewTab("Штрих-коды");
                    break;
                case Header_Functions.Custom_Goods_Short_Name:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_shortname.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_shortname.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_shortname);
                    //NameNewTab("Сокращения");
                    break;
                case Header_Functions.Custom_History:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_goods_history.Location = new Point(1, 1);
                    Program.ribbonsub_custom_goods_history.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_goods_history);
                    //NameNewTab("История");
                    break;
                case Header_Functions.Custom_Orders:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_orders.Location = new Point(1, 1);
                    Program.ribbonsub_custom_orders.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_orders);
                    //NameNewTab("Заказы");
                    break;
                case Header_Functions.Custom_Orders_2:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_orders2.Location = new Point(1, 1);
                    Program.ribbonsub_custom_orders2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_orders2);
                    //NameNewTab("Заказы");
                    break;
                case Header_Functions.Custom_Prices:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices);
                    //NameNewTab("Цены");
                    break;
                case Header_Functions.Custom_Prices_Dynamic_Upcoming:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices_dynamic_upcoming.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices_dynamic_upcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices_dynamic_upcoming);
                    //NameNewTab("Накрутка");
                    break;
                case Header_Functions.Custom_Prices_Static_Upcoming:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices_static_upcoming.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices_static_upcoming.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_prices_static_upcoming);
                    //NameNewTab("Наценка");
                    break;
                case Header_Functions.Custom_Requests:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_requests.Location = new Point(1, 1);
                    Program.ribbonsub_custom_requests.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_requests);
                    //NameNewTab("Заказы");
                    break;
                case Header_Functions.Custom_Requests2:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.ribbonsub_custom_prices.Location = new Point(1, 1);
                    Program.ribbonsub_custom_prices.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.ribbonsub_custom_requests2);
                    //NameNewTab("Цены");
                    break;

                default:
                    Program.mainform.wordTabControl.tabPanel.Controls.Clear();
                    Program.hc.Location = new Point(1, 1);
                    Program.hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                    Program.mainform.wordTabControl.tabPanel.Controls.Add(Program.hc);

                    //NameNewTab("Главная");
                    break;
            }
        }

        public bool AddHeader(Header_Functions input)
        {
            if (HeadersFunctionAllocation.Contains(input))
            {
                int number_of_header = HeadersFunctionAllocation.IndexOf(input);

                number_of_header++;

                switch(number_of_header)
                {
                    case 1:

                        Program.mainform.wordTabControl.TabHeader1.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader1.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader1.Location.X + Program.mainform.wordTabControl.TabHeader1.Width);
                        break;

                    case 2:

                        Program.mainform.wordTabControl.TabHeader2.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader2.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader2.Location.X + Program.mainform.wordTabControl.TabHeader2.Width);

                        break;

                    case 3:

                        Program.mainform.wordTabControl.TabHeader3.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader3.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader3.Location.X + Program.mainform.wordTabControl.TabHeader3.Width);

                        break;

                    case 4:

                        Program.mainform.wordTabControl.TabHeader4.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader4.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader4.Location.X + Program.mainform.wordTabControl.TabHeader4.Width);


                        break;

                    case 5:

                        Program.mainform.wordTabControl.TabHeader5.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader5.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader5.Location.X + Program.mainform.wordTabControl.TabHeader5.Width);


                        break;

                    case 6:

                        Program.mainform.wordTabControl.TabHeader6.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader6.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader6.Location.X + Program.mainform.wordTabControl.TabHeader6.Width);

                        break;

                    case 7:

                        Program.mainform.wordTabControl.TabHeader7.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(220,70,40);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader7.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader7.Location.X + Program.mainform.wordTabControl.TabHeader7.Width);

                        break;

                    case 8:

                        Program.mainform.wordTabControl.TabHeader8.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(220,70,40);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader8.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader8.Location.X + Program.mainform.wordTabControl.TabHeader8.Width);

                        break;

                    case 9:

                        Program.mainform.wordTabControl.TabHeader9.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30,30,30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(220,70,40);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader9.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader9.Location.X + Program.mainform.wordTabControl.TabHeader9.Width);

                        break;

                    case 10:

                        Program.mainform.wordTabControl.TabHeader10.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = false;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(220, 70, 40);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = true;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader10.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader10.Location.X + Program.mainform.wordTabControl.TabHeader10.Width);
                        break;

                }

                ShowHeader(input, true);

            }
            else
            {
                if (HeadersFunctionAllocation.Count >= 10) return false;

                HeadersFunctionAllocation.Add(input);

                int number_of_header = HeadersFunctionAllocation.IndexOf(input);

                number_of_header++;

                switch (number_of_header)
                {
                    case 1:

                        Program.mainform.wordTabControl.TabHeader1.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader1.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader1.Location.X + Program.mainform.wordTabControl.TabHeader1.Width);
                        break;

                    case 2:

                        Program.mainform.wordTabControl.TabHeader2.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader2.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader2.Location.X + Program.mainform.wordTabControl.TabHeader2.Width);

                        break;

                    case 3:

                        Program.mainform.wordTabControl.TabHeader3.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader3.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader3.Location.X + Program.mainform.wordTabControl.TabHeader3.Width);

                        break;

                    case 4:

                        Program.mainform.wordTabControl.TabHeader4.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader4.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader4.Location.X + Program.mainform.wordTabControl.TabHeader4.Width);


                        break;

                    case 5:

                        Program.mainform.wordTabControl.TabHeader5.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader5.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader5.Location.X + Program.mainform.wordTabControl.TabHeader5.Width);


                        break;

                    case 6:

                        Program.mainform.wordTabControl.TabHeader6.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader6.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader6.Location.X + Program.mainform.wordTabControl.TabHeader6.Width);

                        break;

                    case 7:

                        Program.mainform.wordTabControl.TabHeader7.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader7.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader7.Location.X + Program.mainform.wordTabControl.TabHeader7.Width);

                        break;

                    case 8:

                        Program.mainform.wordTabControl.TabHeader8.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader8.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader8.Location.X + Program.mainform.wordTabControl.TabHeader8.Width);

                        break;

                    case 9:

                        Program.mainform.wordTabControl.TabHeader9.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = false;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = true;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(220, 70, 40);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(30, 30, 30);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = true;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = false;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader9.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader9.Location.X + Program.mainform.wordTabControl.TabHeader9.Width);

                        break;

                    case 10:

                        Program.mainform.wordTabControl.TabHeader10.Visible = true;

                        Program.mainform.wordTabControl.TabHeader1.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader2.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader3.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader4.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader5.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader6.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader7.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader8.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader9.ChangeColorMouseHC = true;
                        Program.mainform.wordTabControl.TabHeader10.ChangeColorMouseHC = false;

                        Program.mainform.wordTabControl.TabHeader1.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader2.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader3.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader4.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader5.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader6.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader7.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader8.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader9.ForeColor = Color.FromArgb(30, 30, 30);
                        Program.mainform.wordTabControl.TabHeader10.ForeColor = Color.FromArgb(220, 70, 40);

                        Program.mainform.wordTabControl.TabHeader1.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader2.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader3.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader4.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader5.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader6.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader7.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader8.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader9.ShowBorder = false;
                        Program.mainform.wordTabControl.TabHeader10.ShowBorder = true;

                        Program.mainform.wordTabControl.tabPanel.SkipXRange = new Point(Program.mainform.wordTabControl.TabHeader10.Location.X,
                                                        Program.mainform.wordTabControl.TabHeader10.Location.X + Program.mainform.wordTabControl.TabHeader10.Width);
                        break;

                }


                ShowHeader(input);
            }
            

            return false;
        }

        public void ShowNameOfTheTab(Headers hdr)
        {
            switch(hdr)
            {
                case Headers.MainStaticHeader:
                    if (HeadersFunctionAllocation.Count > 0) Program.mainform.wordTabControl.TabHeader1.Text = "Главная";
                    break;
                case Headers.Header1:
                    if (HeadersFunctionAllocation.Count > 1) Program.mainform.wordTabControl.TabHeader2.Text = TabNaming(HeadersFunctionAllocation[1]);
                    break;
                case Headers.Header2:
                    if (HeadersFunctionAllocation.Count > 2) Program.mainform.wordTabControl.TabHeader3.Text = TabNaming(HeadersFunctionAllocation[2]);
                    break;
                case Headers.Header3:
                    if (HeadersFunctionAllocation.Count > 3) Program.mainform.wordTabControl.TabHeader4.Text = TabNaming(HeadersFunctionAllocation[3]);
                    break;
                case Headers.Header4:
                    if (HeadersFunctionAllocation.Count > 4) Program.mainform.wordTabControl.TabHeader5.Text = TabNaming(HeadersFunctionAllocation[4]);
                    break;
                case Headers.Header5:
                    if (HeadersFunctionAllocation.Count > 5) Program.mainform.wordTabControl.TabHeader6.Text = TabNaming(HeadersFunctionAllocation[5]);
                    break;
                case Headers.Header6:
                    if (HeadersFunctionAllocation.Count > 6) Program.mainform.wordTabControl.TabHeader7.Text = TabNaming(HeadersFunctionAllocation[6]);
                    break;
                case Headers.Header7:
                    if (HeadersFunctionAllocation.Count > 7) Program.mainform.wordTabControl.TabHeader8.Text = TabNaming(HeadersFunctionAllocation[7]);
                    break;
                case Headers.Header8:
                    if (HeadersFunctionAllocation.Count > 8) Program.mainform.wordTabControl.TabHeader9.Text = TabNaming(HeadersFunctionAllocation[8]);
                    break;
                case Headers.Header9:
                    if (HeadersFunctionAllocation.Count > 9) Program.mainform.wordTabControl.TabHeader10.Text = TabNaming(HeadersFunctionAllocation[9]);
                    break;
            }
        }

       string TabNaming(Header_Functions hf)
        {
            switch (hf)
            {
                case Header_Functions.Avaliable_EnteringPreorder:
                    return "Ввод остатков";

                case Header_Functions.Avaliable_ForgottenGood:
                    return "Списание";
                    
                case Header_Functions.Avaliable_Revizion:
                    return "Ревизия";
            
                case Header_Functions.Avaliable_Sorting:
                    return "Пересортица";

                case Header_Functions.Contragents:
                    return "Контрагенты";
                   
                case Header_Functions.Goods_Barcode:
                    return "Штрих-код";

                case Header_Functions.Goods_Default:
                    return "Ввод по умолчанию";

                case Header_Functions.Goods_Groups:
                    return "Группы";

                case Header_Functions.Goods_Images:
                    return "Рисунки";

                case Header_Functions.Goods_Links:
                    return "Связи";

                case Header_Functions.Goods_MaxBalance:
                    return "Максимальный остаток";

                case Header_Functions.Goods_MinBalance:
                    return "Минимальный остаток";

                case Header_Functions.Goods_MinRequest:
                    return "Минимальная завка";

                case Header_Functions.Goods_Providers:
                    return "Коды поставщиков";

                case Header_Functions.Goods_Reduction:
                  return "Сокращения";

                case Header_Functions.Goods_Tags:
                  return "Теги";

                case Header_Functions.Buying_OutCart:
                    return "Возрат поставщику";

                case Header_Functions.Selling_BackClient:
                    return "Возрат поставщику";

                case Header_Functions.Main:
                    return "Главная";

                default:
                    return "Главная";
            }
        }

        private void NameNewTab(string name)
        {
            int number = HeadersFunctionAllocation.Count;
            switch (number)
            {
                case 1:
                    Program.mainform.wordTabControl.TabHeader1.Text = name;
                    Program.mainform.wordTabControl.TabHeader1.Visible = true;
                    break;
                case 2:
                    Program.mainform.wordTabControl.TabHeader2.Text = name;
                    Program.mainform.wordTabControl.TabHeader2.Visible = true;
                    break;
                case 3:
                    Program.mainform.wordTabControl.TabHeader3.Text = name;
                    Program.mainform.wordTabControl.TabHeader3.Visible = true;
                    break;
                case 4:
                    Program.mainform.wordTabControl.TabHeader4.Text = name;
                    Program.mainform.wordTabControl.TabHeader4.Visible = true;
                    break;
                case 5:
                    Program.mainform.wordTabControl.TabHeader5.Text = name;
                    Program.mainform.wordTabControl.TabHeader5.Visible = true;
                    break;
                case 6:
                    Program.mainform.wordTabControl.TabHeader6.Text = name;
                    Program.mainform.wordTabControl.TabHeader6.Visible = true;
                    break;
                case 7:
                    Program.mainform.wordTabControl.TabHeader7.Text = name;
                    Program.mainform.wordTabControl.TabHeader7.Visible = true;
                    break;
                case 8:
                    Program.mainform.wordTabControl.TabHeader8.Text = name;
                    Program.mainform.wordTabControl.TabHeader8.Visible = true;
                    break;
                case 9:
                    Program.mainform.wordTabControl.TabHeader9.Text = name;
                    Program.mainform.wordTabControl.TabHeader9.Visible = true;
                    break;
                case 10:
                    Program.mainform.wordTabControl.TabHeader10.Text = name;
                    Program.mainform.wordTabControl.TabHeader10.Visible = true;
                    break;
            }
        }

        public bool isFirstHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header1);
        }
        public bool isSecondHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header2);
        }
        public bool isThirdHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header3);
        }
        public bool isFourthHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header4);
        }
        public bool isFifthHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header5);
        }
        public bool isSixthHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header6);
        }
        public bool isSeventhHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header7);
        }
        public bool isEighthHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header8);
        }
        public bool isNinthHeaderAllocated()
        {
            return HeadersAllocation.Contains(Headers.Header9);
        }
        public bool isTenthHeaderAllocated()
        {
            // return HeadersAllocation.Contains(Headers.Header10);
            return true;
        }

        public bool PrjFilePack(string path,string password = "")
        {
           try
           {

                if (File.Exists(path + ".whaprj"))
                {
                    File.Delete(path + ".whaprj");
                }

                System.IO.Compression.ZipFile.CreateFromDirectory(path, path +  ".whaprj",CompressionLevel.Fastest,false);
                return true;
            }
           catch (Exception ex)
            {
               return false;
            }
        }

        public bool DeleteCachedFiles(string path)
        {
            try
            {
                File.Delete(path + "\\gba.db");
                File.Delete(path + "\\gbc.db");
                File.Delete(path + "\\gbg.db");
                File.Delete(path + "\\gbh.db");
                File.Delete(path + "\\gbp.db");
                File.Delete(path + "\\gbs.db");
                File.Delete(path + "\\gbv.db");

                File.Delete(path + "\\settings.cfg");
               return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }



    }
}
