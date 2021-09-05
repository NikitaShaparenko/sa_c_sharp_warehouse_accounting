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
    public partial class TemplatesControl : UserControl
    {
        MainForm mainForm;
        TemplatesControl templatesControl;
        public TemplatesControl(MainForm mainfrm)
        {
            InitializeComponent();
            mainForm = mainfrm;
        }

        public TemplatesControl SetTemplatesControlObject
        {
            get { return templatesControl; }
            set { templatesControl = value; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mainForm.LeftTopItemsPanel.Visible = true;
            //mainForm.wordTabControl.Visible = true;
            //mainForm.StatusPanel.Visible = true;
            //mainForm.TopPanel.Separator = 0;
            //mainForm.FormText.Text = "Presentation 1 - Microsoft WarehouseAccounting";
            //mainForm.MainPanel.Controls.Remove(templatesControl);
            pnlForNewProject.Visible = true;
            New_OptionControl newprj = new New_OptionControl(templatesControl,true);
            newprj.Dock = DockStyle.Fill;
            pnlForNewProject.Controls.Clear();
            pnlForNewProject.Controls.Add(newprj);
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void RecentText_Click(object sender, EventArgs e)
        {

        }

        private void TemplatesControl_Load(object sender, EventArgs e)
        {
            AccountText.Text = "Аккаунт: " + Environment.UserName.ToString();
            Program.recent_proj = new RecentProjectsControl();
            Program.recent_proj.Dock = DockStyle.Fill;
            pnlRecentProj.Controls.Clear();
            pnlRecentProj.Controls.Add(Program.recent_proj);
        }

        private void Panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
       
        private void OpenProjectText_Click(object sender, EventArgs e)
        {
            OpenFileDialog opd1 = new OpenFileDialog();
            opd1.InitialDirectory = System.Environment.GetFolderPath(System.Environment.SpecialFolder.UserProfile);
            opd1.Filter = "Проект Warehouse Accounting (*.whaprj) |*.whaprj";
            opd1.FilterIndex = 0;
            opd1.CheckFileExists = true;
            opd1.Multiselect = false;
            if (opd1.ShowDialog() == DialogResult.OK)
            {
                Program.core.CoreOpenProject(opd1.FileName,AnalyzeForPassword(opd1.FileName));
            }
        }

        bool AnalyzeForPassword(string path)
        {
            try
            {
                using (var zipFile = System.IO.Compression.ZipFile.OpenRead(path))
                {
                    var entries = zipFile.Entries;
                    return false;
                }
            }
            catch (Exception ex)
            {
                return true;
            }
        }
    }
}
