using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAccounting.Core;
using WarehouseAccounting.DropDownMenu;
using WarehouseAccounting.RibbonSubMenu;

namespace WarehouseAccounting
{
    static class Program
    {
        public static bool isMinimize = false;
        /// <summary>
        /// The main entry point for the application.
        /// 

        /// </summary>
        public static LoadingForm st;
        public static Log log;
        public static FileHeader fh;
        public static MainForm mainform;
        public static InputBox inputbox;
        public static SMS sms;
        public static MathProcessor mathProcessor;
        public static Core.Core core;
        public static Core.GlobalBaseHistory gbh;
        public static Core.GlobalBaseSignature gbs;
        public static Core.GlobalBaseActions gba;
        public static Core.GlobalBaseContragents gbc;
        public static Core.GlobalBaseGroups gbg;
        public static Core.GlobalBaseProvider gbp;
        public static Core.GlobalBaseVerification gbv;

        public static RibbonSubMenu.RibbonAvaliableEnteringBalance ribbonsub_aval_entering_balance;
        public static RibbonSubMenu.RibbonAvaliableForgottenGood ribbonsub_aval_forgotten_good;
        public static RibbonSubMenu.RibbonAvaliableRevizion ribbonsub_aval_revizion;
        public static RibbonSubMenu.RibbonAvaliableSorting ribbonsub_aval_sorting;
        public static RibbonSubMenu.RibbonContragents ribbonsub_contragents;
        public static RibbonSubMenu.RibbonGoodsBarcode ribbonsub_goods_barcode;
        public static RibbonSubMenu.RibbonGoodsDefault ribbonsub_goods_default;
        public static RibbonSubMenu.RibbonGoodsGroups ribbonsub_goods_groups;
        public static RibbonSubMenu.RibbonGoodsImages ribbonsub_goods_images;
        public static RibbonSubMenu.RibbonGoodsLinks ribbonsub_goods_links;
        public static RibbonSubMenu.RibbonGoodsMaxBalance ribbonsub_goods_max_balance;
        public static RibbonSubMenu.RibbonGoodsMinBalance ribbonsub_goods_min_balance;
        public static RibbonSubMenu.RibbonGoodsMinRequest ribbonsub_goods_min_req;
        public static RibbonSubMenu.RibbonGoodsProviders ribbonsub_goods_providers;
        public static RibbonSubMenu.RibbonGoodsReduction ribbonsub_goods_reduction;
        public static RibbonSubMenu.RibbonGoodsTags ribbonsub_goods_tags;
        public static RibbonSubMenu.RibbonPricesDependences ribbonsub_prices_dependences;
        public static RibbonSubMenu.RibbonPriceSettings ribbonsub_prices_settings;
        public static RibbonSubMenu.RibbonPricesPriceList ribbonsub_prices_pricelist;
        public static RibbonSubMenu.RibbonPricesPriceProviders ribbonsub_prices_priceproviders;
        public static RibbonSubMenu.RibbonBuying ribbonsub_buying;
        public static RibbonSubMenu.RibbonSelling ribbonsub_selling;

        public static RibbonSubMenu.CustomContragentsClients ribbonsub_custom_contragents;
        public static RibbonSubMenu.CustomRibbonContragentsChecking ribbonsub_contragents_checking;
        public static RibbonSubMenu.CustomRibbonGoods ribbonsub_custom_goods;
        public static RibbonSubMenu.CustomRibbonGoodsBarcodes ribbonsub_custom_goods_barcode;
        public static RibbonSubMenu.CustomRibbonGoodsBarcodeSettingsPreview ribbonsub_custom_goods_barcodes_preview;
        public static RibbonSubMenu.CustomRibbonGoodsShortName ribbonsub_custom_goods_shortname;
        public static RibbonSubMenu.CustomRibbonHistory ribbonsub_custom_goods_history;
        public static RibbonSubMenu.CustomRibbonOrders ribbonsub_custom_orders;
        public static RibbonSubMenu.CustomRibbonOrders2 ribbonsub_custom_orders2;
        public static RibbonSubMenu.CustomRibbonPrices ribbonsub_custom_prices;
        public static RibbonSubMenu.CustomRibbonPricesDynamicUpcoming ribbonsub_custom_prices_dynamic_upcoming;
        public static RibbonSubMenu.CustomRibbonPricesStaticUpcoming ribbonsub_custom_prices_static_upcoming;
        public static RibbonSubMenu.CustomRibbonRequests ribbonsub_custom_requests;
        public static RibbonSubMenu.CustomRibbonRequests2 ribbonsub_custom_requests2;

        public static RibbonSubMenu.CustomRibbonGoodsGroupList ribbonsub_custom_group_list;

        public static Core.ImportExcelUC import_excel;
        public static Core.ErrorExcelMessage error_excel;
        public static GoodCard gc;

        public static HomeControl hc;

        public static RecentProjectsControl recent_proj;

        public static string prj_var_prj_name = "";
        public static string prj_var_prj_path = "";
        public static string prj_var_crypto_passwd = "";
        public static bool prj_var_crypto_ispasswd = false;
        public static bool prj_var_crypto_export = false;
        public static bool prj_var_source_control = false;
        public static bool prj_var_autosave = false;
        public static int prj_var_autosave_time = -1;
        public static bool prj_var_autoinform = false;
        public static bool prj_var_autoinform_sns = false;
        public static bool prj_var_autoinform_email = false;
        public static bool prj_var_autoinform_telegram = false;
        public static bool prj_var_autoinform_whatsapp = false;
        public static bool prj_var_autoinform_viber = false;
        public static string prj_var_email_sender_address = "";
        public static string prj_var_email_sender_password = "";
        public static string prj_var_email_receiver_address = "";
        public static bool prj_var_socks5 = false;
        public static string prj_var_socks5_ip = "";
        public static int prj_var_socks5_port = -1;
    

        [STAThread]
        static void Main()
        {
            log = new Log();
            IntPtr dummy = log.Handle;
            fh = new FileHeader();
            IntPtr dummy2 = fh.Handle;
            Application.Run(st = new LoadingForm());

            mainform = new MainForm();
            IntPtr dummy3 = mainform.Handle;

            inputbox = new InputBox("Переучёт","Введите наличие");
            IntPtr dummy4 = inputbox.Handle;

            gbs = new GlobalBaseSignature();
            IntPtr dummy5 = gbs.Handle;

            gbh = new GlobalBaseHistory();
            IntPtr dummy6 = gbh.Handle;

            sms = new SMS("","","","","");
            core = new Core.Core();
            mathProcessor = new MathProcessor();

            ribbonsub_aval_entering_balance = new RibbonAvaliableEnteringBalance();
            IntPtr dummy7 = ribbonsub_aval_entering_balance.Handle;

            ribbonsub_aval_forgotten_good = new RibbonAvaliableForgottenGood();
            IntPtr dummy8 = ribbonsub_aval_forgotten_good.Handle;

            ribbonsub_aval_sorting = new RibbonAvaliableSorting();
            IntPtr dummy9 = ribbonsub_aval_sorting.Handle;

            ribbonsub_aval_revizion = new RibbonAvaliableRevizion();
            IntPtr dummy10 = ribbonsub_aval_revizion.Handle;

            ribbonsub_contragents = new RibbonContragents();
            IntPtr dummy11 = ribbonsub_contragents.Handle;

            ribbonsub_goods_barcode = new RibbonGoodsBarcode();
            IntPtr dummy12 = ribbonsub_goods_barcode.Handle;

            ribbonsub_goods_default = new RibbonGoodsDefault();
            IntPtr dummy13 = ribbonsub_goods_default.Handle;

            ribbonsub_goods_groups = new RibbonGoodsGroups();
            IntPtr dummy14 = ribbonsub_goods_groups.Handle;

            ribbonsub_goods_images = new RibbonGoodsImages();
            IntPtr dummy15 = ribbonsub_goods_images.Handle;

            ribbonsub_goods_links = new RibbonGoodsLinks();
            IntPtr dummy16 = ribbonsub_goods_links.Handle;

            ribbonsub_goods_max_balance = new RibbonGoodsMaxBalance();
            IntPtr dummy17 = ribbonsub_goods_max_balance.Handle;

            ribbonsub_goods_min_balance = new RibbonGoodsMinBalance();
            IntPtr dummy18 = ribbonsub_goods_min_balance.Handle;

            ribbonsub_goods_min_req = new RibbonGoodsMinRequest();
            IntPtr dummy19 = ribbonsub_goods_min_req.Handle;

            ribbonsub_goods_providers = new RibbonGoodsProviders();
            IntPtr dummy20 = ribbonsub_goods_providers.Handle;

            ribbonsub_goods_reduction = new RibbonGoodsReduction();
            IntPtr dummy21 = ribbonsub_goods_reduction.Handle;

            ribbonsub_goods_tags = new RibbonGoodsTags();
            IntPtr dummy22 = ribbonsub_goods_tags.Handle;

            ribbonsub_prices_dependences = new RibbonPricesDependences();
            IntPtr dummy23 = ribbonsub_prices_dependences.Handle;

            ribbonsub_prices_settings = new RibbonPriceSettings();
            IntPtr dummy24 = ribbonsub_prices_settings.Handle;

            ribbonsub_prices_pricelist = new RibbonPricesPriceList();
            IntPtr dummy25 = ribbonsub_prices_pricelist.Handle;

            ribbonsub_prices_priceproviders = new RibbonPricesPriceProviders();
            IntPtr dummy26 = ribbonsub_prices_priceproviders.Handle;

            ribbonsub_custom_contragents = new RibbonSubMenu.CustomContragentsClients();
            IntPtr dummy27 = ribbonsub_custom_contragents.Handle;

            ribbonsub_contragents_checking = new RibbonSubMenu.CustomRibbonContragentsChecking();
            IntPtr dummy28 = ribbonsub_contragents_checking.Handle;

            ribbonsub_custom_goods = new RibbonSubMenu.CustomRibbonGoods();
            IntPtr dummy29 = ribbonsub_custom_goods.Handle;

            ribbonsub_custom_goods_barcode = new RibbonSubMenu.CustomRibbonGoodsBarcodes();
            IntPtr dummy30 = ribbonsub_custom_goods_barcode.Handle;

            ribbonsub_custom_goods_barcodes_preview = new RibbonSubMenu.CustomRibbonGoodsBarcodeSettingsPreview();
            IntPtr dummy31 = ribbonsub_custom_goods_barcodes_preview.Handle;

            ribbonsub_custom_goods_shortname = new RibbonSubMenu.CustomRibbonGoodsShortName();
            IntPtr dummy32 = ribbonsub_custom_goods_shortname.Handle;

            ribbonsub_custom_goods_history = new RibbonSubMenu.CustomRibbonHistory();
            IntPtr dummy33 = ribbonsub_custom_goods_history.Handle;

            ribbonsub_custom_orders = new RibbonSubMenu.CustomRibbonOrders();
            IntPtr dummy34 = ribbonsub_custom_orders.Handle;

            ribbonsub_custom_orders2 = new RibbonSubMenu.CustomRibbonOrders2();
            IntPtr dummy35 = ribbonsub_custom_orders2.Handle;

            ribbonsub_custom_prices = new RibbonSubMenu.CustomRibbonPrices();
            IntPtr dummy36 = ribbonsub_custom_prices.Handle;

            ribbonsub_custom_prices_dynamic_upcoming = new RibbonSubMenu.CustomRibbonPricesDynamicUpcoming();
            IntPtr dummy37 = ribbonsub_custom_prices_dynamic_upcoming.Handle;

            ribbonsub_custom_prices_static_upcoming = new RibbonSubMenu.CustomRibbonPricesStaticUpcoming();
            IntPtr dummy38 = ribbonsub_custom_prices_dynamic_upcoming.Handle;

            ribbonsub_custom_requests = new CustomRibbonRequests();
            IntPtr dummy39 = ribbonsub_custom_requests.Handle;

            ribbonsub_custom_requests2 = new CustomRibbonRequests2();
            IntPtr dummy40 = ribbonsub_custom_requests2.Handle;

            hc = new HomeControl();
            IntPtr dummy41 = hc.Handle;

            ribbonsub_selling = new RibbonSelling();
            IntPtr dummy42 = ribbonsub_selling.Handle;

            ribbonsub_buying = new RibbonBuying();
            IntPtr dummy43 = ribbonsub_selling.Handle;

            gba = new GlobalBaseActions();
            IntPtr dummy44 = gba.Handle;

            gbc = new GlobalBaseContragents();
            IntPtr dummy45 = gbc.Handle;

            gbg = new GlobalBaseGroups();
            IntPtr dummy46 = gbg.Handle;

            gbp = new GlobalBaseProvider();
            IntPtr dummy47 = gbp.Handle;

            gbv = new GlobalBaseVerification();
            IntPtr dummy48 = gbv.Handle;

            gc = new GoodCard(Program.mainform.mui);
            IntPtr dummy49 = gc.Handle;

            import_excel = new ImportExcelUC();
            IntPtr dummy50 = import_excel.Handle;

            error_excel = new ErrorExcelMessage();
            IntPtr dummy51 = error_excel.Handle;

            mainform.LeftTopItemsPanel.Visible = false;
            mainform.actionTracker.Visible = false;
            mainform.wordTabControl.Visible = false;
            mainform.switcherPages.Visible = false;
            mainform.StatusPanel.Visible = false;
            mainform.TopPanel.Separator = 280;
            mainform.FormText.Text = "";

            TemplatesControl templatesControl = new TemplatesControl(mainform);
            templatesControl.Location = new Point(0, 0);
            templatesControl.Height = mainform.MainPanel.Height;
            templatesControl.Dock = DockStyle.Fill;
            mainform.MainPanel.Controls.Add(templatesControl);

            templatesControl.SetTemplatesControlObject = templatesControl;

            

            Application.Run(mainform) ;
            //Application.Run(new WorkMenu());
        }

       

      
    }
}
