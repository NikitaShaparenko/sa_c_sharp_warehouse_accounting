using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarehouseAccounting
{
    public partial class InputBox : Form
    {

        bool isOK = false;
        string frm_name = "";
        string frm_message = "";
        public string text = "";

        public InputBox(string FormHeader, string FormText)
        {
            frm_name = FormHeader;
            frm_message = FormText;
            InitializeComponent();
        }

        private void BOK_Click(object sender, EventArgs e)
        {
            text = nudInfo.Value.ToString();
            isOK = true;
            Close();
        }

        private void BCancel_Click(object sender, EventArgs e)
        {
            text = nudInfo.Value.ToString();
            isOK = false;
            Close();
        }

        public void SetData(string frmHeader,string frmText)
        {
            frm_name = frmHeader;
            frm_message = frmText;
        }

        public bool getStatus()
        {
            return isOK;
        }

        private void InputBox_Load(object sender, EventArgs e)
        {
            this.Text = frm_name;
            this.txtMessage.Text = frm_message;
        }
    }
}
