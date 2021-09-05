using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;

namespace WarehouseAccounting
{
    public partial class LowRAMStatusWindowControl : UserControl
    {

        const int APM_needs = 200;
        const int AVM_needs = 500;

        public LowRAMStatusWindowControl()
        {
            InitializeComponent();
        }

        private void LowRAMStatusWindowControl_Load(object sender, EventArgs e)
        {

        }

        private void TRuntime_Tick(object sender, EventArgs e)
        {
            ComputerInfo ci = new ComputerInfo();
            //200 APM, 500 AVM;

            double APM_free = ci.AvailablePhysicalMemory;
            double AVM_free = ci.AvailableVirtualMemory;
            double APM_estimated = APM_needs - ci.AvailablePhysicalMemory;
            double AVM_estimated = AVM_needs - ci.AvailableVirtualMemory;

            if (APM_estimated > 0)
            {
                ErrorText.Text = "Нехватка оперативной памяти!";
                txtRAM.Text = "Осталось всего " + APM_free.ToString("#,##") + " мб";
                txtHowMuchINeed.Text = "Нужно освободить " + APM_estimated.ToString("#,##") + " мб";
                this.BackColor = Color.DarkRed;
            }
            else if (AVM_estimated > 0)
            {
                ErrorText.Text = "Нехватка оперативной памяти!";
                txtRAM.Text = "Осталось всего " + AVM_free.ToString("#,##") + " мб виртуальной памяти (подкачка)";
                txtHowMuchINeed.Text = "Нужно освободить " + AVM_estimated.ToString("#,##") + " мб виртуальной памяти (подкачки)";
                this.BackColor = Color.DarkRed;
            }
            else if (APM_estimated > 0 && AVM_estimated > 0)
            {
                ErrorText.Text = "Нехватка оперативной памяти!";
                txtRAM.Text = "Осталось всего " + APM_free.ToString("#,##") + "мб (Виртуальной " + AVM_free.ToString("#,##") + " мб)";
                txtHowMuchINeed.Text = "Нужно освободить " + APM_estimated.ToString("#,##") + " мб (Виртуальной " + AVM_estimated.ToString("#,##") + "мб)";
                this.BackColor = Color.DarkRed;
            }
            else
            {
                ErrorText.Text = "Сведения об оперативной памяти";
                txtRAM.Text = "Осталось всего " + APM_free.ToString("#,##") + "мб (Виртуальной " + AVM_free.ToString("#,##") + " мб)";
                txtHowMuchINeed.Text = "Приложению достаточно " + APM_needs + " мб (виртуальной " + AVM_needs + " мб)";
                this.BackColor = Color.DarkGoldenrod;
            }
       }
    }
}
