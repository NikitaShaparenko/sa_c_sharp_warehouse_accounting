﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting.RibbonSubMenu
{
    public partial class CustomRibbonPricesStaticUpcoming : UserControl
    {
        public CustomRibbonPricesStaticUpcoming()
        {
            InitializeComponent();
        }

        private void Lbl_header_1_Click(object sender, EventArgs e)
        {

        }

        private void Pic_header_1_Click(object sender, EventArgs e)
        {
            Program.core.InsertInto(Core.Core.Header_Functions.Custom_Prices_Static_Upcoming);
        }
    }
}
