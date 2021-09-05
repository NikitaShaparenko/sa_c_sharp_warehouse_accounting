using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Ionic.Zip;
//using System.IO.Compression;

namespace WarehouseAccounting.Core
{

    public partial class PasswordEntering : Form
    {

        string prj_file = "";
        string prj_dir = "";

        public PasswordEntering(string ProjectFile,string ProjectDir)
        {
            prj_file = ProjectFile;
            prj_dir = ProjectDir;
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PasswordEntering_Load(object sender, EventArgs e)
        {

        }

        private void bDone_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (File.Exists(prj_file))
                {
                    if (IsZipPasswordValid(prj_file,prj_dir))
                    {
                        Button bDone = new System.Windows.Forms.Button();
                        bDone.DialogResult = DialogResult.OK;
                        bDone.Click += new EventHandler(bDone_Click);
                        bDone_Click(sender, e);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show(this, "Неверный пароль! \n Попробуйте попытку снова", "Ошибка!", MessageBoxButtons.OK);
                    }
                }
            }
            catch
            {
                MessageBox.Show(this,"Неверный пароль! \n Попробуйте попытку снова", "Ошибка!", MessageBoxButtons.OK);
            }
        }

      
        public bool IsZipPasswordValid(string path,string password)
        {
            try
            {
                using (ZipFile archive = new ZipFile(path))
                {
                    archive.Password = password;
                    archive.Encryption = EncryptionAlgorithm.PkzipWeak; // the default: you might need to select the proper value here
                    archive.StatusMessageTextWriter = Console.Out;

                    archive.ExtractAll(prj_dir, ExtractExistingFileAction.Throw);
                }
                return true;
            }
            catch (InvalidDataException)
            {
                return false;
            }
        }
    }
}
