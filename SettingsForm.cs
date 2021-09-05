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
    public partial class SettingsForm : UserControl
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            txtPath.Text = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "\\WarehouseAcc\\" + txtName.Text;
            cbAutoSave.CheckedChanged += new EventHandler(this.CbAutoSave_CheckedChanged);
            cbSNS.CheckedChanged += new EventHandler(this.CbSNS_CheckedChanged);
            cbemail.CheckedChanged += new EventHandler(this.Cbemail_CheckedChanged);
            cbPasswd.CheckedChanged += new EventHandler(this.CbPasswd_CheckedChanged);
            cbViber.CheckedChanged += new EventHandler(this.CbViber_CheckedChanged);
            cbWhatsApp.CheckedChanged += new EventHandler(this.CbWhatsApp_CheckedChanged);
            cbTelegram.CheckedChanged += new EventHandler(this.CbTelegram_CheckedChanged);
            rbAutoSave5.CheckedChanged += new EventHandler(this.RbAutoSave5_CheckedChanged);
            rbAutoSave10.CheckedChanged += new EventHandler(this.RbAutoSave10_CheckedChanged);
            rbAutoSave30.CheckedChanged += new EventHandler(this.RbAutoSave30_CheckedChanged);
            rbAutoSave60.CheckedChanged += new EventHandler(this.RbAutoSave60_CheckedChanged);
            rbAutoSaveCustom.CheckedChanged += new EventHandler(this.RbAutoSaveCustom_CheckedChanged);
            nudAutoSaveCustom.ValueChanged += new EventHandler(this.NudAutoSaveCustom_ValueChanged);

            LoadSettings();
        }

        private void LoadSettings()
        {
            cbPasswd.Checked = Program.prj_var_autosave;
            cbCryptoExport.Checked = Program.prj_var_crypto_export;
            cbSourceControl.Checked = Program.prj_var_source_control;
            cbAutoSave.Checked = Program.prj_var_autosave;
            cbAutoSend.Checked = Program.prj_var_autoinform;
            cbemail.Checked = Program.prj_var_autoinform_email;
            cbSNS.Checked = Program.prj_var_autoinform_sns;
            cbTelegram.Checked = Program.prj_var_autoinform_telegram;
            cbWhatsApp.Checked = Program.prj_var_autoinform_whatsapp;
            cbViber.Checked = Program.prj_var_autoinform_viber;
            rbSOCKS5.Checked = Program.prj_var_socks5;
            

            if (Program.prj_var_autosave_time != -1)
            {
                switch (Program.prj_var_autosave_time)
                {
                    case 5: rbAutoSave5.Checked = true;
                        break;
                    case 10: rbAutoSave10.Checked = true;
                        break;
                    case 30: rbAutoSave30.Checked = true;
                        break;
                    case 60: rbAutoSave60.Checked = true;
                        break;
                    default:
                        rbAutoSaveCustom.Checked = true;
                        nudAutoSaveCustom.Value = Program.prj_var_autosave_time;
                    break;

                }
            }



        }

        private void TAutoCustom_Tick(object sender, EventArgs e)
        {
            rbAutoSaveCustom.Text = "Каждые " + nudAutoSaveCustom.Value.ToString() + " минут";
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

        private void NudAutoSaveCustom_ValueChanged(object sender, EventArgs e)
        {
            rbAutoSaveCustom.Checked = true;
        }

        private void BChange_Click(object sender, EventArgs e)
        {
            
        }
    }
}
