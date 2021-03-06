using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;

namespace WarehouseAccounting
{
    public partial class Import : UserControl
    {
        public Import()
        {
            InitializeComponent();
        }

        private void PbComputer_Click(object sender, EventArgs e)
        {

        }

        private void Import_Load(object sender, EventArgs e)
        {
            //pnlImport.Controls.Clear();
            //pnlImport.Controls.Add(Program.import_excel);
            //pnlImport.Dock = DockStyle.Fill;
        }


        private void optionButton1_Click(object sender, EventArgs e)
        {
            optionButton1.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton1.ChangeColorMouseHC = false;
            optionButton2.BZBackColor = Color.White;
            optionButton3.BZBackColor = Color.White;
            optionButton4.BZBackColor = Color.White;
            optionButton2.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void optionButton2_Click(object sender, EventArgs e)
        {
            optionButton2.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton2.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.White;
            optionButton3.BZBackColor = Color.White;
            optionButton4.BZBackColor = Color.White;
            optionButton1.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
            optionButton4.ChangeColorMouseHC = true;
        }

        private void optionButton3_Click(object sender, EventArgs e)
        {
            string file_path = "";

            optionButton3.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton3.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.White;
            optionButton2.BZBackColor = Color.White;
            optionButton4.BZBackColor = Color.White;
            optionButton1.ChangeColorMouseHC = true;
            optionButton2.ChangeColorMouseHC = true;
            optionButton4.ChangeColorMouseHC = true;

            OpenFileDialog ofd = new OpenFileDialog();

            ofd.InitialDirectory = "c:\\";
            ofd.Filter = "Книга xlsx (*.xlsx)|*.xlsx|Все файлы (*.*)|*.*";
            ofd.FilterIndex = 0;
            ofd.RestoreDirectory = true;
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                file_path = ofd.FileName;
                try
                {
                    if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\excel.exe", "Path", null) == null)
                    {
                        MessageBox.Show("Необходим установленный Microsoft Office Excel 2007 и старше");
                        pnlImport.Controls.Clear();
                        pnlImport.Controls.Add(Program.error_excel);
                       
                    }
                    else
                    {
                        Program.import_excel.pathName = ofd.FileName;
                        pnlImport.Controls.Clear();
                        pnlImport.Controls.Add(Program.import_excel);
                        Program.import_excel.ImportExcelDo();
                       // pnlImport.Dock = DockStyle.Fill;
                    }
                }
                catch
                {
                    pnlImport.Controls.Clear();
                    pnlImport.Controls.Add(Program.error_excel);
                    //pnlImport.Dock = DockStyle.Fill;
                }
                
            }
        }

        private void optionButton4_Click(object sender, EventArgs e)
        {
            optionButton4.BZBackColor = Color.FromArgb(255, 192, 128);
            optionButton4.ChangeColorMouseHC = false;
            optionButton1.BZBackColor = Color.White;
            optionButton2.BZBackColor = Color.White;
            optionButton3.BZBackColor = Color.White;
            optionButton1.ChangeColorMouseHC = true;
            optionButton2.ChangeColorMouseHC = true;
            optionButton3.ChangeColorMouseHC = true;
        }

        private void NFolderLookup1_Click(object sender, EventArgs e)
        {

        }
    }
}
