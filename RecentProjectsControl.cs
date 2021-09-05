using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WarehouseAccounting.Properties;
using System.IO;
using System.Xml;

namespace WarehouseAccounting
{
    public partial class RecentProjectsControl : UserControl
    {
        string curdir = Directory.GetCurrentDirectory();
        string bin_dir = Directory.GetCurrentDirectory() + "\\bin";
        string recent_file1_text = "";
        string recent_file2_text = "";
        string recent_file3_text = "";
        string recent_file4_text = "";
        string recent_file5_text = "";
        string recent_file6_text = "";
        string recent_file7_text = "";

        string path_file1 = "";
        string path_file2 = "";
        string path_file3 = "";
        string path_file4 = "";
        string path_file5 = "";
        string path_file6 = "";
        string path_file7 = "";

        bool is_file1_protected = false;
        bool is_file2_protected = false;
        bool is_file3_protected = false;
        bool is_file4_protected = false;
        bool is_file5_protected = false;
        bool is_file6_protected = false;
        bool is_file7_protected = false;


        public enum Project_list
        {
            Project1,
            Project2,
            Project3,
            Project4,
            Project5,
            Project6,
            Project7,
        }

        bool ConvertStringToBool(string input)
        {
            switch(input)
            {
                case "true":
                    return true;
                case "false":
                    return false;
                default:
                    return false;
            }
        }
        bool ReadRecentFile()
        {
            try
            {
                if (!Directory.Exists(bin_dir))
                {
                    Directory.CreateDirectory(bin_dir);
                    return false;
                }
                else if (!File.Exists(bin_dir + "\\recent_proj_1.dat"))
                {
                    return false;
                }
                else
                {
                    try
                    {
                        recent_file1_text = File.ReadAllText(bin_dir + "\\recent_proj_1.dat");
                        recent_file2_text = File.ReadAllText(bin_dir + "\\recent_proj_2.dat");
                        recent_file3_text = File.ReadAllText(bin_dir + "\\recent_proj_3.dat");
                        recent_file4_text = File.ReadAllText(bin_dir + "\\recent_proj_4.dat");
                        recent_file5_text = File.ReadAllText(bin_dir + "\\recent_proj_5.dat");
                        recent_file6_text = File.ReadAllText(bin_dir + "\\recent_proj_6.dat");
                        recent_file7_text = File.ReadAllText(bin_dir + "\\recent_proj_7.dat");
                    }
                    catch
                    {

                    }

                    if (recent_file1_text != "")
                    {
                        txtHeader1.Text = RecentFileXMLParser(Project_list.Project1, Project_list_action.name);
                        is_file1_protected = ConvertStringToBool(RecentFileXMLParser(Project_list.Project1, Project_list_action.isProtected));
                        path_file1 = RecentFileXMLParser(Project_list.Project1, Project_list_action.path);
                        if (is_file1_protected)
                        {
                            MakeItProtected(Project_list.Project1);
                        }
                        else
                        {
                            MakeItUnProtected(Project_list.Project1);
                        }
                        txtHeader1.Visible = true;
                        txtSubHeader1.Visible = true;

                    }
                    if (recent_file2_text != "")
                    {
                        txtHeader2.Text = RecentFileXMLParser(Project_list.Project2, Project_list_action.name);
                        is_file2_protected = ConvertStringToBool(RecentFileXMLParser(Project_list.Project2, Project_list_action.isProtected));
                        path_file2 = RecentFileXMLParser(Project_list.Project2, Project_list_action.path);

                        if (is_file2_protected)
                        {
                            MakeItProtected(Project_list.Project2);
                        }
                        else
                        {
                            MakeItUnProtected(Project_list.Project2);
                        }
                        txtHeader2.Visible = true;
                        txtSubHeader2.Visible = true;

                    }
                    if (recent_file3_text != "")
                    {
                        txtHeader3.Text = RecentFileXMLParser(Project_list.Project3, Project_list_action.name);
                        is_file3_protected = ConvertStringToBool(RecentFileXMLParser(Project_list.Project3, Project_list_action.isProtected));
                        path_file3 = RecentFileXMLParser(Project_list.Project3, Project_list_action.path);

                        if (is_file3_protected)
                        {
                            MakeItProtected(Project_list.Project3);
                        }
                        else
                        {
                            MakeItUnProtected(Project_list.Project3);
                        }
                        txtHeader3.Visible = true;
                        txtSubHeader3.Visible = true;

                    }
                    if (recent_file4_text != "")
                    {
                        txtHeader4.Text = RecentFileXMLParser(Project_list.Project4, Project_list_action.name);
                        is_file4_protected = ConvertStringToBool(RecentFileXMLParser(Project_list.Project4, Project_list_action.isProtected));
                        path_file4 = RecentFileXMLParser(Project_list.Project4, Project_list_action.path);

                        if (is_file4_protected)
                        {
                            MakeItProtected(Project_list.Project4);
                        }
                        else
                        {
                            MakeItUnProtected(Project_list.Project4);
                        }

                        txtHeader4.Visible = true;
                        txtSubHeader4.Visible = true;

                    }
                    if (recent_file5_text != "")
                    {
                        txtHeader5.Text = RecentFileXMLParser(Project_list.Project5, Project_list_action.name);
                        is_file5_protected = ConvertStringToBool(RecentFileXMLParser(Project_list.Project5, Project_list_action.isProtected));
                        path_file5 = RecentFileXMLParser(Project_list.Project5, Project_list_action.path);

                        if (is_file5_protected)
                        {
                            MakeItProtected(Project_list.Project5);
                        }
                        else
                        {
                            MakeItUnProtected(Project_list.Project5);
                        }
                        txtHeader5.Visible = true;
                        txtSubHeader5.Visible = true;

                    }
                    if (recent_file6_text != "")
                    {
                        txtHeader6.Text = RecentFileXMLParser(Project_list.Project6, Project_list_action.name);
                        is_file6_protected = ConvertStringToBool(RecentFileXMLParser(Project_list.Project6, Project_list_action.isProtected));
                        path_file6 = RecentFileXMLParser(Project_list.Project6, Project_list_action.path);

                        if (is_file6_protected)
                        {
                            MakeItProtected(Project_list.Project6);
                        }
                        else
                        {
                            MakeItUnProtected(Project_list.Project6);
                        }
                        txtHeader6.Visible = true;
                        txtSubHeader6.Visible = true;

                    }
                    if (recent_file7_text != "")
                    {
                        txtHeader7.Text = RecentFileXMLParser(Project_list.Project7, Project_list_action.name);
                        is_file7_protected = ConvertStringToBool(RecentFileXMLParser(Project_list.Project7, Project_list_action.isProtected));
                        path_file7 = RecentFileXMLParser(Project_list.Project7, Project_list_action.path);

                        if (is_file7_protected)
                        {
                            MakeItProtected(Project_list.Project7);
                        }
                        else
                        {
                            MakeItUnProtected(Project_list.Project7);
                        }
                        txtHeader7.Visible = true;
                        txtSubHeader7.Visible = true;
                    }

                    return true;


                }

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public RecentProjectsControl()
        {
            InitializeComponent();
            tlp.Size = this.Size;
            txtHeader1.Text = "";
            txtHeader2.Text = "";
            txtHeader3.Text = "";
            txtHeader4.Text = "";
            txtHeader5.Text = "";
            txtHeader6.Text = "";
            txtHeader7.Text = "";

            txtSubHeader1.Text = "";
            txtSubHeader2.Text = "";
            txtSubHeader3.Text = "";
            txtSubHeader4.Text = "";
            txtSubHeader5.Text = "";
            txtSubHeader6.Text = "";
            txtSubHeader7.Text = "";

            pic1.Visible = true;
            pic2.Visible = true;
            pic3.Visible = true;
            pic4.Visible = true;
            pic5.Visible = true;
            pic6.Visible = true;
            pic7.Visible = true;
        }

        void MakeItUnProtected(Project_list prj_val)
        {
            switch (prj_val)
            {
                case Project_list.Project1:
                    pic1.Image = Resources.unprotected_db44px;
                    txtSubHeader1.Text = "Незащищённый";
                    break;

                case Project_list.Project2:
                    pic2.Image = Resources.unprotected_db44px;
                    txtSubHeader2.Text = "Незащищённый";
                    break;

                case Project_list.Project3:
                    pic3.Image = Resources.unprotected_db44px;
                    txtSubHeader3.Text = "Незащищённый";
                    break;

                case Project_list.Project4:
                    pic4.Image = Resources.unprotected_db44px;
                    txtSubHeader4.Text = "Незащищённый";
                    break;

                case Project_list.Project5:
                    pic5.Image = Resources.unprotected_db44px;
                    txtSubHeader5.Text = "Незащищённый";
                    break;

                case Project_list.Project6:
                    pic6.Image = Resources.unprotected_db44px;
                    txtSubHeader6.Text = "Незащищённый";
                    break;

                case Project_list.Project7:
                    pic7.Image = Resources.unprotected_db44px;
                    txtSubHeader7.Text = "Незащищённый";
                    break;
            }
        }

        void MakeItProtected(Project_list prj_val)
        {
            switch (prj_val)
            {
                case Project_list.Project1:
                    pic1.Image = Resources.protected_db44px;
                    txtSubHeader1.Text = "Защищён паролем";
                    break;

                case Project_list.Project2:
                    pic2.Image = Resources.protected_db44px;
                    txtSubHeader2.Text = "Защищён паролем";
                    break;

                case Project_list.Project3:
                    pic3.Image = Resources.protected_db44px;
                    txtSubHeader3.Text = "Защищён паролем";
                    break;

                case Project_list.Project4:
                    pic4.Image = Resources.protected_db44px;
                    txtSubHeader4.Text = "Защищён паролем";
                    break;

                case Project_list.Project5:
                    pic5.Image = Resources.protected_db44px;
                    txtSubHeader5.Text = "Защищён паролем";
                    break;

                case Project_list.Project6:
                    pic6.Image = Resources.protected_db44px;
                    txtSubHeader6.Text = "Защищён паролем";
                    break;

                case Project_list.Project7:
                    pic7.Image = Resources.protected_db44px;
                    txtSubHeader7.Text = "Защищён паролем";
                    break;
            }
        }

        private void RecentProjectsControl_Load(object sender, EventArgs e)
        {
            if (ReadRecentFile()==false)
            {
                pic1.Visible = false;
                pic2.Visible = false;
                pic3.Visible = false;
                pic4.Visible = false;
                pic5.Visible = false;
                pic6.Visible = false;
                pic7.Visible = false;

                txtSubHeader1.Visible = false;
                txtSubHeader2.Visible = false;
                txtSubHeader3.Visible = false;
                txtSubHeader4.Visible = false;
                txtSubHeader5.Visible = false;
                txtSubHeader6.Visible = false;
                txtSubHeader7.Visible = false;

                txtHeader1.Visible = false;
                txtHeader2.Visible = false;
                txtHeader3.Visible = false;
                txtHeader4.Visible = false;
                txtHeader5.Visible = false;
                txtHeader6.Visible = false;
                txtHeader7.Visible = false;
            }
        }

        private void Tlp_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

       public enum Project_list_action
        {
            name,
            path,
            isProtected,
        }


        string RecentFileXMLParser(Project_list rq, Project_list_action rq_sub)
        {
            switch (rq)
            {
                case Project_list.Project1:
                    switch(rq_sub)
                    {
                        case Project_list_action.path:
                            return XMLParser(recent_file1_text, "prj1_path");
                        case Project_list_action.name:
                            return XMLParser(recent_file1_text, "prj1_name");
                        case Project_list_action.isProtected:
                            return XMLParser(recent_file1_text, "prj1_isProtected");
                    }
                break;
                case Project_list.Project2:
                    switch (rq_sub)
                    {
                        case Project_list_action.path:
                            return XMLParser(recent_file2_text, "prj2_path");
                        case Project_list_action.name:
                            return XMLParser(recent_file2_text, "prj2_name");
                        case Project_list_action.isProtected:
                            return XMLParser(recent_file2_text, "prj2_isProtected");
                    }
                    break;
                case Project_list.Project3:
                    switch (rq_sub)
                    {
                        case Project_list_action.path:
                            return XMLParser(recent_file3_text, "prj3_path");
                        case Project_list_action.name:
                            return XMLParser(recent_file3_text, "prj3_name");
                        case Project_list_action.isProtected:
                            return XMLParser(recent_file3_text, "prj3_isProtected");
                    }
                    break;
                case Project_list.Project4:
                    switch (rq_sub)
                    {
                        case Project_list_action.path:
                            return XMLParser(recent_file4_text, "prj4_path");
                        case Project_list_action.name:
                            return XMLParser(recent_file4_text, "prj4_name");
                        case Project_list_action.isProtected:
                            return XMLParser(recent_file4_text, "prj4_isProtected");
                    }
                    break;
                case Project_list.Project5:
                    switch (rq_sub)
                    {
                        case Project_list_action.path:
                            return XMLParser(recent_file5_text, "prj5_path");
                        case Project_list_action.name:
                            return XMLParser(recent_file5_text, "prj5_name");
                        case Project_list_action.isProtected:
                            return XMLParser(recent_file5_text, "prj5_isProtected");
                    }
                    break;
                case Project_list.Project6:
                    switch (rq_sub)
                    {
                        case Project_list_action.path:
                            return XMLParser(recent_file6_text, "prj6_path");
                        case Project_list_action.name:
                            return XMLParser(recent_file6_text, "prj6_name");
                        case Project_list_action.isProtected:
                            return XMLParser(recent_file6_text, "prj6_isProtected");
                    }
                    break;
                case Project_list.Project7:
                    switch (rq_sub)
                    {
                        case Project_list_action.path:
                            return XMLParser(recent_file7_text, "prj7_path");
                        case Project_list_action.name:
                            return XMLParser(recent_file7_text, "prj7_name");
                        case Project_list_action.isProtected:
                            return XMLParser(recent_file7_text, "prj7_isProtected");
                    }
                    break;
            }
            return "";
        }

        string XMLParser(string source, string rq)
        {
            try
            {
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(source);
                string searching = xmlDoc.GetElementsByTagName(rq)[0].InnerText;
                return searching;
            }
            catch (Exception ex)
            {
                return "";
            }
        }

        public void AddWizardToRecentMenu(string name, string path, bool isProtected)
        {
            if (path_file1 != "")
            {
                if (path_file2 != "")
                {
                    if (path_file3 != "")
                    {
                        if (path_file4 != "")
                        {
                            if (path_file5 != "")
                            {
                                if (path_file6 != "")
                                {
                                    AddToRecentMenu(Project_list.Project7, name, path, isProtected);
                                    WriteFile(Project_list.Project7);
                                    return;
                                }
                                else
                                {
                                    AddToRecentMenu(Project_list.Project6, name, path, isProtected);
                                    WriteFile(Project_list.Project6);
                                    return;
                                }
                            }
                            else
                            {
                                AddToRecentMenu(Project_list.Project5, name, path, isProtected);
                                WriteFile(Project_list.Project5);
                                return;
                            }
                        }
                        else
                        {
                            AddToRecentMenu(Project_list.Project4, name, path, isProtected);
                            WriteFile(Project_list.Project4);
                            return;
                        }
                    }
                    else
                    {
                        AddToRecentMenu(Project_list.Project3, name, path, isProtected);
                        WriteFile(Project_list.Project3);
                        return;
                    }
                }
                else
                {
                    AddToRecentMenu(Project_list.Project2, name, path, isProtected);
                    WriteFile(Project_list.Project2);
                    return;
                }
            }
            else
            {
                AddToRecentMenu(Project_list.Project1, name, path, isProtected);
                WriteFile(Project_list.Project1);
                return;
            }
        }

        public void AddToRecentMenu(Project_list pl, string name, string path, bool isProtected)
        {
            switch(pl)
            {

                case Project_list.Project1:
                    is_file1_protected = isProtected;
                    path_file1 = path;
                    txtHeader1.Text = name;
                    if (isProtected)
                    {
                        MakeItProtected(Project_list.Project1);
                    }
                    else
                    {
                        MakeItUnProtected(Project_list.Project1);
                    }
                    txtHeader1.Visible = true;
                    txtSubHeader1.Visible = true;
                    break;

                case Project_list.Project2:
                    is_file2_protected = isProtected;
                    path_file2 = path;
                    txtHeader2.Text = name;
                    if (isProtected)
                    {
                        MakeItProtected(Project_list.Project2);
                    }
                    else
                    {
                        MakeItUnProtected(Project_list.Project2);
                    }
                    txtHeader2.Visible = true;
                    txtSubHeader2.Visible = true;
                    break;

                case Project_list.Project3:
                    is_file3_protected = isProtected;
                    path_file3 = path;
                    txtHeader3.Text = name;
                    if (isProtected)
                    {
                        MakeItProtected(Project_list.Project3);
                    }
                    else
                    {
                        MakeItUnProtected(Project_list.Project3);
                    }
                    txtHeader3.Visible = true;
                    txtSubHeader3.Visible = true;
                    break;
                case Project_list.Project4:
                    is_file4_protected = isProtected;
                    path_file4 = path;
                    txtHeader4.Text = name;
                    if (isProtected)
                    {
                        MakeItProtected(Project_list.Project4);
                    }
                    else
                    {
                        MakeItUnProtected(Project_list.Project4);
                    }
                    txtHeader4.Visible = true;
                    txtSubHeader4.Visible = true;
                    break;
                case Project_list.Project5:
                    is_file5_protected = isProtected;
                    path_file5 = path;
                    txtHeader5.Text = name;
                    if (isProtected)
                    {
                        MakeItProtected(Project_list.Project5);
                    }
                    else
                    {
                        MakeItUnProtected(Project_list.Project5);
                    }
                    txtHeader5.Visible = true;
                    txtSubHeader5.Visible = true;
                    break;
                case Project_list.Project6:
                    is_file6_protected = isProtected;
                    path_file6 = path;
                    txtHeader6.Text = name;
                    if (isProtected)
                    {
                        MakeItProtected(Project_list.Project6);
                    }
                    else
                    {
                        MakeItUnProtected(Project_list.Project6);
                    }
                    txtHeader6.Visible = true;
                    txtSubHeader6.Visible = true;
                    break;
                case Project_list.Project7:
                    is_file7_protected = isProtected;
                    path_file7 = path;
                    txtHeader7.Text = name;
                    if (isProtected)
                    {
                        MakeItProtected(Project_list.Project7);
                    }
                    else
                    {
                        MakeItUnProtected(Project_list.Project7);
                    }
                    txtHeader7.Visible = true;
                    txtSubHeader7.Visible = true;
                    break;

            }
        }

        private void Pic1_Click(object sender, EventArgs e)
        {
            if (path_file1 != "")
            {
                if (is_file1_protected)
                {
                    Program.core.CoreOpenProject(path_file1, true) ;
                }
                else
                {
                    Program.core.CoreOpenProject(path_file1,false);
                }
            }
        }

        private void Pic2_Click(object sender, EventArgs e)
        {
            if (path_file2 != "")
            {
                if (is_file2_protected)
                {
                    Program.core.CoreOpenProject(path_file2, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file2, false);
                }
            }
        }

        private void Pic4_Click(object sender, EventArgs e)
        {
            if (path_file4 != "")
            {
                if (is_file4_protected)
                {
                    Program.core.CoreOpenProject(path_file4, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file4, false);
                }
            }
        }

        private void Pic7_Click(object sender, EventArgs e)
        {
            if (path_file7 != "")
            {
                if (is_file7_protected)
                {
                    Program.core.CoreOpenProject(path_file7, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file7, false);
                }
            }
        }

        private void TxtHeader1_Click(object sender, EventArgs e)
        {
            if (path_file1 != "")
            {
                if (is_file1_protected)
                {
                    Program.core.CoreOpenProject(path_file1, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file1, false);
                }
            }
        }

        private void TxtHeader2_Click(object sender, EventArgs e)
        {
           if (is_file2_protected)
                {
                    Program.core.CoreOpenProject(path_file2, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file2, false);
                }
        }

        private void TxtHeader3_Click(object sender, EventArgs e)
        {
            if (is_file3_protected)
            {
                Program.core.CoreOpenProject(path_file3, true);
            }
            else
            {
                Program.core.CoreOpenProject(path_file3, false);
            }
        }

        private void TxtHeader4_Click(object sender, EventArgs e)
        {
            if (is_file4_protected)
            {
                Program.core.CoreOpenProject(path_file4, true);
            }
            else
            {
                Program.core.CoreOpenProject(path_file4, false);
            }
        }

        private void TxtHeader5_Click(object sender, EventArgs e)
        {
            if (path_file5 != "")
            {
                if (is_file5_protected)
                {
                    Program.core.CoreOpenProject(path_file5, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file5, false);
                }
            }
        }

        private void TxtHeader6_Click(object sender, EventArgs e)
        {
            if (path_file6 != "")
            {
                if (is_file6_protected)
                {
                    Program.core.CoreOpenProject(path_file6, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file6, false);
                }
            }
        }

        private void TxtHeader7_Click(object sender, EventArgs e)
        {
            if (path_file7 != "")
            {
                if (is_file7_protected)
                {
                    Program.core.CoreOpenProject(path_file7, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file7, false);
                }
            }
        }

        private void pic3_Click(object sender, EventArgs e)
        {
            if (path_file3 != "")
            {
                if (is_file3_protected)
                {
                    Program.core.CoreOpenProject(path_file3, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file3, false);
                }
            }
        }

        private void pic5_CLick(object sender, EventArgs e)
        {
            if (path_file5 != "")
            {
                if (is_file5_protected)
                {
                    Program.core.CoreOpenProject(path_file5, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file5, false);
                }
            }
        }

        private void pic6_Click(object sender, EventArgs e)
        {
            if (path_file6 != "")
            {
                if (is_file6_protected)
                {
                    Program.core.CoreOpenProject(path_file6, true);
                }
                else
                {
                    Program.core.CoreOpenProject(path_file6, false);
                }
            }
        }

        bool isProtected(string input)
        {
            if (input == "Защищён паролем")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void WriteFile(Project_list prj_num)
        {
            string file_text = "";

            switch(prj_num)
            {
                case Project_list.Project1:
                    file_text = "<DocumentElement> \n <prj1_path>" + path_file1 + "</prj1_path> \n <prj1_name>" + txtHeader1.Text + "</prj1_name> \n <prj1_isProtected>";
                    if (isProtected(txtSubHeader1.Text))
                    {
                        file_text += "true";
                    }
                    else
                    {
                        file_text += "false";
                    }
                    file_text += "</prj1_isProtected> \n </DocumentElement>";

                    recent_file1_text = file_text;
                    File.WriteAllText(bin_dir + "\\\\recent_proj_1.dat", file_text, Encoding.Default);
                    break;
                case Project_list.Project2:
                    file_text = "<DocumentElement> \n <prj2_path>" + path_file1 + "</prj2_path> \n <prj2_name>" + txtHeader2.Text + "</prj2_name> \n <prj2_isProtected>";
                    if (isProtected(txtSubHeader2.Text))
                    {
                        file_text += "true";
                    }
                    else
                    {
                        file_text += "false";
                    }
                    file_text += "</prj2_isProtected> \n </DocumentElement>";

                    recent_file2_text = file_text;
                    File.WriteAllText(bin_dir + "\\\\recent_proj_2.dat", file_text, Encoding.Default);
                    break;
                case Project_list.Project3:
                    file_text = "<DocumentElement> \n <prj3_path>" + path_file3 + "</prj3_path> \n <prj3_name>" + txtHeader3.Text + "</prj3_name> \n <prj3_isProtected>";
                    if (isProtected(txtSubHeader3.Text))
                    {
                        file_text += "true";
                    }
                    else
                    {
                        file_text += "false";
                    }
                    file_text += "</prj3_isProtected> \n </DocumentElement>";

                    recent_file3_text = file_text;
                    File.WriteAllText(bin_dir + "\\\\recent_proj_3.dat", file_text, Encoding.Default);
                    break;
                case Project_list.Project4:
                    file_text = "<DocumentElement> \n <prj4_path>" + path_file4 + "</prj4_path> \n <prj4_name>" + txtHeader4.Text + "</prj4_name> \n <prj4_isProtected>";
                    if (isProtected(txtSubHeader4.Text))
                    {
                        file_text += "true";
                    }
                    else
                    {
                        file_text += "false";
                    }
                    file_text += "</prj4_isProtected> \n </DocumentElement>";

                    recent_file4_text = file_text;
                    File.WriteAllText(bin_dir + "\\\\recent_proj_4.dat", file_text, Encoding.Default);

                    break;
                case Project_list.Project5:
                    file_text = "<DocumentElement> \n <prj5_path>" + path_file5 + "</prj5_path> \n <prj5_name>" + txtHeader5.Text + "</prj5_name> \n <prj5_isProtected>";
                    if (isProtected(txtSubHeader5.Text))
                    {
                        file_text += "true";
                    }
                    else
                    {
                        file_text += "false";
                    }
                    file_text += "</prj5_isProtected> \n </DocumentElement>";

                    recent_file5_text = file_text;
                    File.WriteAllText(bin_dir + "\\\\recent_proj_5.dat", file_text, Encoding.Default);
                    break;
                case Project_list.Project6:
                    file_text = "<DocumentElement> \n <prj6_path>" + path_file6 + "</prj6_path> \n <prj6_name>" + txtHeader6.Text + "</prj6_name> \n <prj6_isProtected>";
                    if (isProtected(txtSubHeader6.Text))
                    {
                        file_text += "true";
                    }
                    else
                    {
                        file_text += "false";
                    }
                    file_text += "</prj6_isProtected> \n </DocumentElement>";

                    recent_file6_text = file_text;
                    File.WriteAllText(bin_dir + "\\\\recent_proj_6.dat", file_text, Encoding.Default);
                    break;
                case Project_list.Project7:
                    file_text = "<DocumentElement> \n <prj7_path>" + path_file7 + "</prj7_path> \n <prj7_name>" + txtHeader7.Text + "</prj7_name> \n <prj7_isProtected>";
                    if (isProtected(txtSubHeader7.Text))
                    {
                        file_text += "true";
                    }
                    else
                    {
                        file_text += "false";
                    }
                    file_text += "</prj7_isProtected> \n </DocumentElement>";

                    recent_file7_text = file_text;
                    File.WriteAllText(bin_dir + "\\\\recent_proj_7.dat", file_text, Encoding.Default);
                    break;

            }
        }
    }
}
