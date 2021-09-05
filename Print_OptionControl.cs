using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace WarehouseAccounting
{
    public partial class Print_OptionControl : UserControl
    {
        public Print_OptionControl()
        {
            InitializeComponent();
            PrinterSettings.StringCollection sc = PrinterSettings.InstalledPrinters;
            for (int i = 0; i < sc.Count; i++)
                cmbPrinters.Items.Add(sc[i].ToString());
        }
    }
}
