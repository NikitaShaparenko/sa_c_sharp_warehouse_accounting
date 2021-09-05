using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class Account : UserControl
    {
        public Account()
        {
            InitializeComponent();
        }

        private void Account_Load(object sender, EventArgs e)
        {
            txtAccount.Text = Environment.UserName.ToString();
            txtLicenseWhom.Text = txtAccount.Text;
            txtLicenseStatus.Text = "Действительна";
            txtLicenseCode.Text = "1125P-SFA2R-R32RM-3RSNW-12AFP";
            txtLicenseExpires.Text = "Бессрочная (альфа тест)";
        }
    }
}
