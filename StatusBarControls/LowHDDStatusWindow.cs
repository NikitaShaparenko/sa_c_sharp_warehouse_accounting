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
using System.IO;

namespace WarehouseAccounting
{
    public partial class LowHDDStatusWindow : UserControl
    {
        string local_drive = "";
        const double needHDD = 150;
        public LowHDDStatusWindow(string local_drive_path)
        {
            local_drive = local_drive_path;
            InitializeComponent();
        }

        private void TRuntime_Tick(object sender, EventArgs e)
        {
            DriveInfo di = new DriveInfo(local_drive);
            double HDDFree = (di.AvailableFreeSpace / 1024) / 1024;
            double needSpace = needHDD - HDDFree;

           if (needSpace > 0)
            {
                ErrorText.Text = "Нехватка места на жёстком диске!";
                txtEstimatedHDD.Text = "Осталось всего " +  HDDFree.ToString("#,##") + " мб";
                txtHowMuchINeed.Text = "Нужно освободить ещё " + needSpace.ToString("#,##") + " мб";
                this.BackColor = Color.DarkRed;
            }
           else
            {
                ErrorText.Text = "Сведения о места на жёстком диске!";
                txtEstimatedHDD.Text = "Осталось всего " + HDDFree.ToString("#,##") + " мб";
                txtHowMuchINeed.Text = "Программе хватает " +  needHDD +" мб";
                this.BackColor = Color.DarkGoldenrod;
            }
        }
    }
}
