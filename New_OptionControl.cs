using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WarehouseAccounting
{
    public partial class New_OptionControl : UserControl
    {

        UserControl templateC_local;
        bool isFirstCreation_local;

        public New_OptionControl(UserControl templateC, bool isFirstCreation)
        {
            templateC_local = templateC;
            isFirstCreation_local = isFirstCreation;
            InitializeComponent();
        }

        private void New_OptionControl_Load(object sender, EventArgs e)
        {
            txtPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\WarehouseAcc\\" + txtName.Text;
        }

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            txtPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\WarehouseAcc\\" + txtName.Text;
        }

        private void SenderEmailText_Click(object sender, EventArgs e)
        {

        }

        private bool ConvertStringToBool(string input)
        {
            switch(input)
            {
                case "true": return true;
                default: return false;
            }
        }

        private int ConvertStringToInt(string input)
        {
            try
            {
                int num = 0;
                bool status = Int32.TryParse(input, out num);
                if (status)
                {
                    return Int32.Parse(input);
                }
                else
                {
                    return -1;
                }
            }
            catch
            {
                return -1;
            }
        }

        private void BCreate_Click(object sender, EventArgs e)
        {
            if (isFirstCreation_local)
            {

                Program.prj_var_prj_name = txtName.Text;
                Program.prj_var_prj_path = txtPath.Text;
                Program.prj_var_crypto_ispasswd = cbPasswd.Checked;
                Program.prj_var_crypto_passwd = txtpasswd.Text;
                Program.prj_var_crypto_export = cbCryptoExport.Checked;
                Program.prj_var_source_control = cbSourceControl.Checked;
                Program.prj_var_autosave = cbAutoSave.Checked;
                if (rbAutoSave5.Checked)
                {
                    Program.prj_var_autosave_time = 5;
                }
                else if (rbAutoSave10.Checked)
                {
                    Program.prj_var_autosave_time = 10;
                }
                else if (rbAutoSave30.Checked)
                {
                    Program.prj_var_autosave_time = 30;
                }
                else if (rbAutoSave60.Checked)
                {
                    Program.prj_var_autosave_time = 60;
                }
                else
                {
                    Program.prj_var_autosave_time = Convert.ToInt32(nudAutoSaveCustom.Value);
                }

                Program.prj_var_autoinform = cbAutoSend.Checked;
                Program.prj_var_autoinform_sns = cbSNS.Checked;
                Program.prj_var_autoinform_email = cbemail.Checked;
                Program.prj_var_autoinform_telegram = cbTelegram.Checked;
                Program.prj_var_autoinform_whatsapp = cbWhatsApp.Checked;
                Program.prj_var_autoinform_viber = cbViber.Checked;
                Program.prj_var_email_sender_address = txtSenderEmail.Text;
                Program.prj_var_email_sender_password = txtSenderPassword.Text;
                Program.prj_var_email_receiver_address = txtReceiverEmail.Text;
                Program.prj_var_socks5 = rbProxySOCKS5.Checked;
                Program.prj_var_socks5_ip = txtSOCKSIP.Text;
                Program.prj_var_socks5_port = ConvertStringToInt(txtSOCKSPort.Text);

                Program.mainform.GlobalVarVerificator();

                Program.mainform.LeftTopItemsPanel.Visible = true;
                Program.mainform.wordTabControl.Visible = true;
                Program.mainform.actionTracker.Visible = true;
                Program.mainform.StatusPanel.Visible = true;
                Program.mainform.switcherPages.Visible = true;
                Program.mainform.TopPanel.Separator = 0;
                Program.mainform.FormText.Text = "Warehouse Accounting - " + txtName.Text;
                Program.mainform.MainPanel.Controls.Remove(templateC_local);

                Program.recent_proj.AddWizardToRecentMenu(txtName.Text, txtPath.Text +".whaprj" , cbPasswd.Checked);

                try
                {
                    if (!Directory.Exists(Program.prj_var_prj_path))
                    {
                        Directory.CreateDirectory(Program.prj_var_prj_path);
                    }
                }
                catch
                {
                    MessageBox.Show("Не удалось создать папку проекта!");
                }
            }


        }

        private void CbAutoSave_CheckedChanged(object sender, EventArgs e)
        {
            if (cbAutoSave.Checked)
            {
                rbAutoSave5.Checked = true;
            }
            else
            {
                rbAutoSave5.Checked = false;
                rbAutoSave10.Checked = false;
                rbAutoSave30.Checked = false;
                rbAutoSave60.Checked = false;
                rbAutoSaveCustom.Checked = false;
            }
        }

        private void CbSNS_CheckedChanged(object sender, EventArgs e)
        {
            if (cbemail.Checked || cbSNS.Checked)
            {
                cbAutoSend.Checked = true;
            }
            if (!cbSNS.Checked)
            {
                cbTelegram.Checked = false;
                cbWhatsApp.Checked = false;
                cbViber.Checked = false;
            }
        }

        private void Cbemail_CheckedChanged(object sender, EventArgs e)
        {
            if (cbemail.Checked || cbSNS.Checked)
            {
                cbAutoSend.Checked = true;
            }
        }

        private void CbPasswd_CheckedChanged(object sender, EventArgs e)
        {
            if (!cbPasswd.Checked) cbCryptoExport.Checked = false;
        }

        private void CbViber_CheckedChanged(object sender, EventArgs e)
        {
            if (cbViber.Checked == true) cbSNS.Checked = true;
            if (!cbViber.Checked && !cbTelegram.Checked && !cbWhatsApp.Checked) cbSNS.Checked = false;
        }

        private void CbTelegram_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTelegram.Checked == true) cbSNS.Checked = true;
            if (!cbViber.Checked && !cbTelegram.Checked && !cbWhatsApp.Checked) cbSNS.Checked = false;
        }

        private void CbWhatsApp_CheckedChanged(object sender, EventArgs e)
        {
            if (cbWhatsApp.Checked == true) cbSNS.Checked = true;
            if (!cbViber.Checked && !cbTelegram.Checked && !cbWhatsApp.Checked) cbSNS.Checked = false;
        }

        private void CbCryptoExport_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCryptoExport.Checked) cbPasswd.Checked = true;
        }

        private void RbAutoSave5_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoSave5.Checked) cbAutoSave.Checked = true;
        }

        private void RbAutoSave10_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoSave10.Checked) cbAutoSave.Checked = true;
        }

        private void RbAutoSave30_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoSave30.Checked) cbAutoSave.Checked = true;
        }

        private void RbAutoSave60_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoSave60.Checked) cbAutoSave.Checked = true;
        }

        private void RbAutoSaveCustom_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAutoSaveCustom.Checked) cbAutoSave.Checked = true;
        }

        private void TAutoCustom_Tick(object sender, EventArgs e)
        {
            rbAutoSaveCustom.Text = "Каждые " + nudAutoSaveCustom.Value.ToString() + " минут";
        }

        private void NudAutoSaveCustom_ValueChanged(object sender, EventArgs e)
        {
            rbAutoSaveCustom.Checked = true;
        }
    }
}
