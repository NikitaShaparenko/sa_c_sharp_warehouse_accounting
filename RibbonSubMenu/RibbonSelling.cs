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
    public partial class RibbonSelling : UserControl
    {
        public RibbonSelling()
        {
            InitializeComponent();
        }

        private void Pic_header_1_Click(object sender, EventArgs e)
        {
            Program.core.CloseHeader(Core.Core.Header_Functions.Selling_BackClient);
        }
    }
}
