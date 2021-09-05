using System;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Xml;
using System.IO;
using Microsoft.Win32;
using System.Drawing.Printing;

namespace WarehouseAccounting
{
    public partial class MainForm : Form
    {
        const int buildNumber = 1109;

        public string mui = Program.st.mui_data;
        string curdir = Directory.GetCurrentDirectory();

        public string XMLParser(string source, string rq)
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
                Log(0, "0xm1", "Ошибка разбора XML Parser: " + ex.Data, "kernel panic");
                return "";
            }
        }

        public string MUIParser(string req)
        {
            return XMLParser(mui, req);
        }

        public MainForm()
        {
            InitializeComponent();
            
        }

        public void GlobalVarVerificator()
        {
            if (Program.prj_var_autoinform_sns)
            {
                if ((Program.prj_var_autoinform_whatsapp == false) && (Program.prj_var_autoinform_telegram == false) && (Program.prj_var_autoinform_viber == false))
                {
                    Program.prj_var_autoinform_sns = false;
                }
            }
            else
            {
                if ((Program.prj_var_autoinform_whatsapp) || (Program.prj_var_autoinform_telegram) || (Program.prj_var_autoinform_viber))
                {
                    Program.prj_var_autoinform_sns = true;
                }
            }

            if (Program.prj_var_autosave)
            {
                if (Program.prj_var_autosave_time == -1) Program.prj_var_autosave = false;
            }

            if (Program.prj_var_socks5)
            {
                if ((Program.prj_var_socks5_ip == "") || (Program.prj_var_socks5_port == -1))
                {
                    Program.prj_var_socks5 = false;
                }
            }

            if (!Program.prj_var_autoinform)
            {
                if ((Program.prj_var_autoinform_email) || (Program.prj_var_autoinform_sns))
                {
                    Program.prj_var_autoinform = true;
                }
            }
            else
            {
                if ((Program.prj_var_autoinform_email == false) && (Program.prj_var_autoinform_sns == false))
                {
                    Program.prj_var_autoinform = true;
                }
            }

            if (Program.prj_var_crypto_ispasswd)
            {
                if (Program.prj_var_crypto_passwd == "") Program.prj_var_crypto_ispasswd = false;
                Program.prj_var_crypto_export = false;
            }

        }

        string XMLSubCreator(string header, string body)
        {
           return "<" + header + ">" + body + "</" + header + ">" + Environment.NewLine;
        }


        public bool SaveSettingsToFile(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    File.WriteAllText(path + "\\settings.cfg", GenerateSettingFile(), Encoding.Default);
                }
                else
                {
                    return false;
                }

                return true;
            }
            catch
            {
                return false;
            }
        }

        public string ConvertBoolToString(bool input)
        {
            if (input)
            {
                return "true";
            }
            else
            {
                return "false";
            }
        }

        string GenerateSettingFile()
        {
            string file_data = "<file_id>settings</file_id>" + Environment.NewLine;
            file_data += XMLSubCreator("prj_name", Program.prj_var_prj_name);
            file_data += XMLSubCreator("prj_path", Program.prj_var_prj_path);
            //file_data += XMLSubCreator("crypto_passwd", Program.prj_var_crypto_passwd);
            file_data += XMLSubCreator("crypto_export", ConvertBoolToString(Program.prj_var_crypto_export));
            file_data += XMLSubCreator("source_control", ConvertBoolToString(Program.prj_var_source_control));
            file_data += XMLSubCreator("autosave", ConvertBoolToString(Program.prj_var_autosave));
            file_data += XMLSubCreator("autosave_time",Program.prj_var_autosave_time.ToString());
            file_data += XMLSubCreator("autoinform", ConvertBoolToString(Program.prj_var_autoinform));
            file_data += XMLSubCreator("autoinform_telegram", ConvertBoolToString(Program.prj_var_autoinform_telegram));
            file_data += XMLSubCreator("autoinform_whatsapp", ConvertBoolToString(Program.prj_var_autoinform_whatsapp));
            file_data += XMLSubCreator("autoinform_viber", ConvertBoolToString(Program.prj_var_autoinform_viber));
            file_data += XMLSubCreator("autoinform_email",ConvertBoolToString(Program.prj_var_autoinform_email));
            file_data += XMLSubCreator("email_sender_address", Program.prj_var_email_sender_address);
            file_data += XMLSubCreator("email_sender_password",Program.prj_var_email_sender_password);
            file_data += XMLSubCreator("email_receiver_address", Program.prj_var_email_receiver_address);
            file_data += XMLSubCreator("socks5", ConvertBoolToString(Program.prj_var_socks5));
            file_data += XMLSubCreator("socks5_ip", Program.prj_var_socks5_ip.ToString());
            file_data += XMLSubCreator("socks5_port", Program.prj_var_socks5_port.ToString());

            return file_data;
        }

        bool isTopPanelDragged = false;
        bool isLeftPanelDragged = false;
        bool isRightPanelDragged = false;
        bool isBottomPanelDragged = false;
        bool isTopBorderPanelDragged = false;

        bool isRightBottomPanelDragged = false;
        bool isLeftBottomPanelDragged = false;
        bool isRightTopPanelDragged = false;
        bool isLeftTopPanelDragged = false;

        bool isWindowMaximized = false;
        Point offset;
        Size _normalWindowSize;
        Point _normalWindowLocation = Point.Empty;

        HomeControl hc = new HomeControl();
        AvaliableControl ac = new AvaliableControl();


        //********************************************************************
        // TopBorderPanel
        private void TopBorderPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopBorderPanelDragged = true;
            }
            else
            {
                isTopBorderPanelDragged = false;
            }
        }

        private void TopBorderPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y)
            {
                if (isTopBorderPanelDragged)
                {
                    if (this.Height < 50)
                    {
                        this.Height = 50;
                        isTopBorderPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                    }
                }
            }
        }

        private void TopBorderPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopBorderPanelDragged = false;
        }


        //********************************************************************
        // TopPanel
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isTopPanelDragged = true;
                Point pointStartPosition = this.PointToScreen(new Point(e.X, e.Y));
                offset = new Point();
                offset.X = this.Location.X - pointStartPosition.X;
                offset.Y = this.Location.Y - pointStartPosition.Y;
            }
            else
            {
                isTopPanelDragged = false;
            }
            if (e.Clicks == 2)
            {
                isTopPanelDragged = false;
                minMaxButton_Click(sender, e);
            }
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isTopPanelDragged)
            {
                Point newPoint = TopPanel.PointToScreen(new Point(e.X, e.Y));
                newPoint.Offset(offset);
                this.Location = newPoint;

                if (this.Location.X > 2 || this.Location.Y > 2)
                {
                    if (this.WindowState == FormWindowState.Maximized)
                    {
                        this.Location = _normalWindowLocation;
                        this.Size = _normalWindowSize;
                        toolTip1.SetToolTip(minMaxButton, "Maximize");
                        minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                        isWindowMaximized = false;
                    }
                }
            }
        }

        private void TopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isTopPanelDragged = false;
            if (this.Location.Y <= 5)
            {
                if (!isWindowMaximized)
                {
                    _normalWindowSize = this.Size;
                    _normalWindowLocation = this.Location;

                    Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                    this.Location = new Point(0, 0);
                    this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                    toolTip1.SetToolTip(minMaxButton, "Restore Down");
                    minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                    isWindowMaximized = true;
                }
            }
        }


        //********************************************************************
        // LeftPanel
        private void LeftPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.Location.X <= 0 || e.X < 0)
            {
                isLeftPanelDragged = false;
                this.Location = new Point(10, this.Location.Y);
            }
            else
            {
                if (e.Button == MouseButtons.Left)
                {
                    isLeftPanelDragged = true;
                }
                else
                {
                    isLeftPanelDragged = false;
                }
            }
        }

        private void LeftPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftPanelDragged)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        isLeftPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }
        }

        private void LeftPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftPanelDragged = false;
        }


        //********************************************************************
        // RightPanel
        private void RightPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isRightPanelDragged = true;
            }
            else
            {
                isRightPanelDragged = false;
            }
        }

        private void RightPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightPanelDragged)
            {
                if (this.Width < 100)
                {
                    this.Width = 100;
                    isRightPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                }
            }
        }

        private void RightPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isRightPanelDragged = false;
        }


        //********************************************************************
        // BottomPanel
        private void BottomPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isBottomPanelDragged = true;
            }
            else
            {
                isBottomPanelDragged = false;
            }
        }

        private void BottomPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (isBottomPanelDragged)
            {
                if (this.Height < 50)
                {
                    this.Height = 50;
                    isBottomPanelDragged = false;
                }
                else
                {
                    this.Height = this.Height + e.Y;
                }
            }
        }

        private void BottomPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isBottomPanelDragged = false;
        }


        //********************************************************************
        // RightBottomPanel 1
        private void RightBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = true;
        }

        private void RightBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isRightBottomPanelDragged)
            {
                if (this.Width < 100 || this.Height < 50)
                {
                    this.Width = 100;
                    this.Height = 50;
                    isRightBottomPanelDragged = false;
                }
                else
                {
                    this.Width = this.Width + e.X;
                    this.Height = this.Height + e.Y;
                    FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                }
            }
        }

        private void RightBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightBottomPanelDragged = false;
        }

        //********************************************************************
        // RightBottomPanel 2
        private void RightBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseDown(sender, e);
        }

        private void RightBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseMove(sender, e);
        }

        private void RightBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightBottomPanel_1_MouseUp(sender, e);
        }


        //********************************************************************
        // LeftBottomPanel 1
        private void LeftBottomPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = true;
        }

        private void LeftBottomPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X)
            {
                if (isLeftBottomPanelDragged || this.Height < 50)
                {
                    if (this.Width < 100)
                    {
                        this.Width = 100;
                        this.Height = 50;
                        isLeftBottomPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Height = this.Height + e.Y;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }
        }

        private void LeftBottomPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftBottomPanelDragged = false;
        }


        //********************************************************************
        // LeftBottomPanel 2
        private void LeftBottomPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseDown(sender, e);
        }

        private void LeftBottomPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseMove(sender, e);
        }

        private void LeftBottomPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftBottomPanel_1_MouseUp(sender, e);
        }



        //********************************************************************
        // RightTopPanel 1
        private void RightTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = true;
        }

        private void RightTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Y < this.Location.Y || e.X < this.Location.X)
            {
                if (isRightTopPanelDragged)
                {
                    if (this.Height < 50 || this.Width < 100)
                    {
                        this.Height = 50;
                        this.Width = 100;
                        isRightTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        this.Width = this.Width + e.X;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }
        }

        private void RightTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isRightTopPanelDragged = false;
        }

        //********************************************************************
        // RightTopPanel 2
        private void RightTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseDown(sender, e);
        }

        private void RightTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseMove(sender, e);
        }

        private void RightTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            RightTopPanel_1_MouseUp(sender, e);
        }


        //********************************************************************
        // LeftTopPanel 1
        private void LeftTopPanel_1_MouseDown(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = true;
        }

        private void LeftTopPanel_1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.X < this.Location.X || e.Y < this.Location.Y)
            {
                if (isLeftTopPanelDragged)
                {
                    if (this.Width < 100 || this.Height < 50)
                    {
                        this.Width = 100;
                        this.Height = 100;
                        isLeftTopPanelDragged = false;
                    }
                    else
                    {
                        this.Location = new Point(this.Location.X + e.X, this.Location.Y);
                        this.Width = this.Width - e.X;
                        this.Location = new Point(this.Location.X, this.Location.Y + e.Y);
                        this.Height = this.Height - e.Y;
                        FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
                    }
                }
            }

        }

        private void LeftTopPanel_1_MouseUp(object sender, MouseEventArgs e)
        {
            isLeftTopPanelDragged = false;
        }


        //********************************************************************
        // LeftTopPanel 2
        private void LeftTopPanel_2_MouseDown(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseDown(sender, e);
        }

        private void LeftTopPanel_2_MouseMove(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseMove(sender, e);
        }

        private void LeftTopPanel_2_MouseUp(object sender, MouseEventArgs e)
        {
            LeftTopPanel_1_MouseUp(sender, e);
        }

        //FormText
        private void FormText_MouseDown(object sender, MouseEventArgs e)
        {
            TopPanel_MouseDown(sender, e);
        }

        private void FormText_MouseMove(object sender, MouseEventArgs e)
        {
            TopPanel_MouseMove(sender, e);
        }

        private void FormText_MouseUp(object sender, MouseEventArgs e)
        {
            TopPanel_MouseUp(sender, e);
        }

        //buttons actions
        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minMaxButton_Click(object sender, EventArgs e)
        {
            if (isWindowMaximized)
            {
                this.Location = _normalWindowLocation;
                this.Size = _normalWindowSize;
                toolTip1.SetToolTip(minMaxButton, "Maximize");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Normal;
                isWindowMaximized = false;

                FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2,
                                            9);
            }
            else
            {
                _normalWindowSize = this.Size;
                _normalWindowLocation = this.Location;

                Rectangle rect = Screen.PrimaryScreen.WorkingArea;
                this.Location = new Point(0, 0);
                this.Size = new System.Drawing.Size(rect.Width, rect.Height);
                toolTip1.SetToolTip(minMaxButton, "Restore Down");
                minMaxButton.CFormState = MinMaxButton.CustomFormState.Maximize;
                isWindowMaximized = true;

                FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length,
                                            9);
            }
        }

        private void minButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void helpButton_Click(object sender, EventArgs e)
        {

        }

        public void CreatePage()
        {
            TabPage tp = new TabPage();
            DataGridView dgv = new DataGridView();
            tp.Text = "Новая страница";
            tp.Controls.Add(dgv);
            tabControl.TabPages.Add(tp);


        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //LeftTopItemsPanel.Visible = true;
            //wordTabControl.Visible = true;
            //StatusPanel.Visible = true;
            //TopPanel.Separator = 0;
            FormText.Location = new Point((TopPanel.Width / 2) - FormText.Text.Length * 2, 9);
            wordTabControl.FileButton.Click += new EventHandler(this.FileButton_Click);
            //wordTabControl.TabHeader1.Click += new EventHandler(this.TabHeader1_Click);
            //wordTabControl.TabHeader2.Click += new EventHandler(this.TabHeader2_Click);
            //wordTabControl.TabHeader3.Click += new EventHandler(this.TabHeader3_Click);
            //wordTabControl.TabHeader4.Click += new EventHandler(this.TabHeader4_Click);
            //wordTabControl.TabHeader5.Click += new EventHandler(this.TabHeader5_Click);
            //wordTabControl.TabHeader6.Click += new EventHandler(this.TabHeader6_Click);
            //wordTabControl.TabHeader7.Click += new EventHandler(this.TabHeader7_Click);
            //wordTabControl.TabHeader8.Click += new EventHandler(this.TabHeader8_Click);

            hc.lbl_header_1.Text = MUIParser("lbl_h1");
            hc.lbl_header_2.Text = MUIParser("lbl_h2");
            hc.lbl_header_3.Text = MUIParser("lbl_h3");
            hc.lbl_header_4.Text = MUIParser("lbl_h4");
            hc.lbl_header_5.Text = MUIParser("lbl_h5");
            hc.lbl_header_6.Text = MUIParser("lbl_h6");

            hc.lbl_header_7.Text = "";
            hc.lbl_header_8.Text = "";
            hc.lbl_header_9.Text = "";
            hc.lbl_header_10.Text = "";

            Program.fh.lbl_file_header_1.Text = MUIParser("lbl_file_h1");
            Program.fh.lbl_file_header_2.Text = MUIParser("lbl_file_h2");
            Program.fh.lbl_file_header_3.Text = MUIParser("lbl_file_h3");
            Program.fh.lbl_file_header_4.Text = MUIParser("lbl_file_h4");
            Program.fh.lbl_file_header_5.Text = MUIParser("lbl_file_h5");

            Program.fh.lbl_file_header_right_1.Text = MUIParser("lbl_file_hr1");
            Program.fh.lbl_file_header_right_2.Text = MUIParser("lbl_file_hr2");
            Program.fh.lbl_file_header_right_3.Text = MUIParser("lbl_file_hr3");
            Program.fh.lbl_file_header_right_4.Text = MUIParser("lbl_file_hr4");

            Program.fh.bFHR1.Text = MUIParser("b_fhr1");
            Program.fh.bFHR2.Text = MUIParser("b_fhr2");
            Program.fh.bFHR3.Text = MUIParser("b_fhr3");

            Program.fh.cb_file_header_right_1.Text = MUIParser("cb_file_hr1");

            DataGridViewColumn col1 = new DataGridViewColumn();
            DataGridViewColumn col2 = new DataGridViewColumn();
            DataGridViewColumn col3 = new DataGridViewColumn();
            DataGridViewColumn col1_g = new DataGridViewColumn();
            DataGridViewColumn col2_g = new DataGridViewColumn();

            col1.HeaderText = MUIParser("tb_c");
            col1.Width = 10;
            col1.Name = "table_code";
            col1.ReadOnly = true;
            col1.Frozen = false;
            col1.CellTemplate = new DataGridViewTextBoxCell();
            col1.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            col2.HeaderText = MUIParser("tb_n");
            col2.Width = 150;
            col2.Name = "table_name";
            col2.ReadOnly = true;
            col2.Frozen = false;
            col2.CellTemplate = new DataGridViewTextBoxCell();
            col2.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            col3.HeaderText = MUIParser("tb_p");
            col3.Width = 200;
            col3.Name = "table_price";
            col3.ReadOnly = true;
            col3.Frozen = false;
            col3.CellTemplate = new DataGridViewTextBoxCell();
            col3.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            col1_g.HeaderText = MUIParser("tb_c");
            col1_g.Width = 10;
            col1_g.Name = "table_code_2";
            col1_g.ReadOnly = true;
            col1_g.Frozen = false;
            col1_g.CellTemplate = new DataGridViewTextBoxCell();
            col1_g.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            col2_g.HeaderText = MUIParser("tb_n");
            col2_g.Width = 150;
            col2_g.Name = "table_name_2";
            col2_g.ReadOnly = true;
            col2_g.Frozen = false;
            col2_g.CellTemplate = new DataGridViewTextBoxCell();
            col2_g.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            dgv_prices.Columns.Add(col1);
            dgv_prices.Columns.Add(col2);
            dgv_prices.Columns.Add(col3);

            dgv_goods.Columns.Add(col1_g);
            dgv_goods.Columns.Add(col2_g);


            bwHeader1.RunWorkerAsync();
            Program.mainform.switcherPages.bgwTabCProvider();

            HomeButton_Click(sender, e);

            //for (int i = 0; i< 15; i++)
            //{
            //    switcherPages.dgvAvaliable.Rows.Add();
            //}

            //switcherPages.dgvAvaliable[1, 0].Value = "1194";
            //switcherPages.dgvAvaliable[1, 1].Value = "1468";
            //switcherPages.dgvAvaliable[1, 2].Value = "1466";
            //switcherPages.dgvAvaliable[1, 3].Value = "1758";
            //switcherPages.dgvAvaliable[1, 4].Value = "1757";
            //switcherPages.dgvAvaliable[1, 5].Value = "2117";
            //switcherPages.dgvAvaliable[1, 6].Value = "0939";
            //switcherPages.dgvAvaliable[1, 7].Value = "0351";
            //switcherPages.dgvAvaliable[1, 8].Value = "0938";
            //switcherPages.dgvAvaliable[1, 9].Value = "0352";
            //switcherPages.dgvAvaliable[1, 10].Value = "0951";
            //switcherPages.dgvAvaliable[1, 11].Value = "0347";
            //switcherPages.dgvAvaliable[1, 12].Value = "0348";
            //switcherPages.dgvAvaliable[1, 13].Value = "0953";

            //switcherPages.dgvAvaliable[3, 0].Value = "Кофе llly зерновой 250 г";
            //switcherPages.dgvAvaliable[3, 1].Value = "Кофе llly молотый Espresso 250 г";
            //switcherPages.dgvAvaliable[3, 2].Value = "Кофе Isla зерновой SL 200 г";
            //switcherPages.dgvAvaliable[3, 3].Value = "Кофе Isla молотый SL 200 г";
            //switcherPages.dgvAvaliable[3, 4].Value = "Кофе Jacobs 3в1 Amaretto 12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 5].Value = "Кофе Jacobs 3в1 Amaretto 24x12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 6].Value = "Кофе Jacobs 3в1 Amaretto 56x12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 7].Value = "Кофе Jacobs 3в1 Cappucino 12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 8].Value = "Кофе Jacobs 3в1 Cappucino 24x12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 9].Value = "Кофе Jacobs 3в1 Caramel Latte 12,3г ШТ";
            //switcherPages.dgvAvaliable[3, 10].Value = "Кофе Jacobs 3в1 Caramel Latte 24x12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 11].Value = "Кофе Jacobs 3в1 Dynamix 12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 12].Value = "Кофе Jacobs 3в1 Dynamix 24x12,5г ШТ";
            //switcherPages.dgvAvaliable[3, 13].Value = "Кофе Jacobs 3в1 Dynamix 56x12,5г ШТ";

            //switcherPages.dgvAvaliable[4, 0].Value = "1";
            //switcherPages.dgvAvaliable[4, 1].Value = "2";
            //switcherPages.dgvAvaliable[4, 2].Value = "2";
            //switcherPages.dgvAvaliable[4, 3].Value = "9";
            //switcherPages.dgvAvaliable[4, 4].Value = "2";
            //switcherPages.dgvAvaliable[4, 5].Value = "1";
            //switcherPages.dgvAvaliable[4, 6].Value = "18";
            //switcherPages.dgvAvaliable[4, 7].Value = "2";
            //switcherPages.dgvAvaliable[4, 8].Value = "2";
            //switcherPages.dgvAvaliable[4, 9].Value = "6";
            //switcherPages.dgvAvaliable[4, 10].Value = "7";
            //switcherPages.dgvAvaliable[4, 11].Value = "3";
            //switcherPages.dgvAvaliable[4, 12].Value = "7";
            //switcherPages.dgvAvaliable[4, 13].Value = "20";
        }

        Timer timer = new Timer();
        FileOptionsControl fileOptionsControl;
        public static int width = 200;
        int count = 1;

        private void AddFileOptionsControl()
        {
            timer.Interval = 160;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
        }


        void timer_Tick(object sender, EventArgs e)

       {
            width += 100;
            count++;
            fileOptionsControl.Width = width;

            if (width >= MainPanel.Width - 100)
            {
                fileOptionsControl.Dock = DockStyle.Fill;
                timer.Stop();

            }
        }

        enum CTRLTypes
        {
            None,
            HomeType,
            InsertType,
            DesignType,
            PageLayoutType,
            ReferencesType,
            MailingsType,
            ReviewType,
            ViewType
        }

        Core.Core.Headers hdr = new Core.Core.Headers();

        public void TabHeader1_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.HomeType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                //HomeControl homectrl = new HomeControl();
                hc.Location = new Point(1, 1);
                hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                wordTabControl.tabPanel.Controls.Add(hc);
                addedControlType = CTRLTypes.HomeType;
            }
        }

        private void FileButton_Click(object sender, EventArgs e)
        {

            LeftTopItemsPanel.Visible = false;
            wordTabControl.Visible = false;
            StatusPanel.Visible = false;
            pnlWorkspace.Visible = false;
            switcherPages.Visible = false;
            actionTracker.Visible = false;
            TopPanel.Separator = 125;
            fileOptionsControl = new FileOptionsControl(fileOptionsControl, this);
            fileOptionsControl.Location = new Point(0, 0);
            fileOptionsControl.Height = MainPanel.Height;
            MainPanel.Controls.Add(fileOptionsControl);
            fileOptionsControl.SetFileOptionsObject = fileOptionsControl;
            AddFileOptionsControl();
            MainPanel.BringToFront();
        }


        public void EnteringHeaderOne()
        {
            
        }


        static CTRLTypes addedControlType = CTRLTypes.None;

        private void HomeButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.HomeType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                //HomeControl homectrl = new HomeControl();
                hc.Location = new Point(1, 1);
                hc.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                wordTabControl.tabPanel.Controls.Add(hc);
                addedControlType = CTRLTypes.HomeType;
            }
        }



        private void printDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            //Bitmap bmp = new Bitmap(switcherPages.dgvAvaliable.Size.Width + 10, switcherPages.dgvAvaliable.Size.Height + 10);
            //switcherPages.dgvAvaliable.DrawToBitmap(bmp, switcherPages.dgvAvaliable.Bounds);
            //e.Graphics.DrawImage(bmp, 0, 0);
            //printDocument1.Print();
            //e.Graphics.Dispose();
        }
        private void InsertButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.InsertType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.InsertType;
                ac.Location = new Point(1, 1);
               ac.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom;
                wordTabControl.tabPanel.Controls.Add(ac);
                addedControlType = CTRLTypes.InsertType;
                switcherPages.tabC.SelectedIndex = 2;
            }
        }

        private void DesignButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.DesignType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.DesignType;
            }
        }

        private void PageLayoutButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.PageLayoutType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.PageLayoutType;
            }
        }

        private void ReferencesButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.ReferencesType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.ReferencesType;
            }
        }

        private void MailingsButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.MailingsType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.MailingsType;
            }
        }

        private void ReviewButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.ReviewType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.ReviewType;
            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (addedControlType != CTRLTypes.ViewType)
            {
                wordTabControl.tabPanel.Controls.Clear();
                addedControlType = CTRLTypes.ViewType;
            }
        }

        private void WordTabControl_Load(object sender, EventArgs e)
        {

        }

        private void TRuntime_Tick(object sender, EventArgs e)
        {
            ComputerInfo ci = new ComputerInfo();
            BuildText.Text = "Warhouse Accounting - build " + buildNumber.ToString() + " - APM: " + ci.AvailablePhysicalMemory / 1024 / 1024 + " - AVM: " + ci.AvailableVirtualMemory / 1024 / 1024;
        }

        private void PnlWorkspace_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BwHeader1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                hc.pic_header_1.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\agents.png");
                hc.pic_header_2.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\goods.png");
                hc.pic_header_3.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\avaliable.png");
                hc.pic_header_4.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\price.png");
                hc.pic_header_5.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\sellings.png");
                hc.pic_header_6.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\bag.png");
                Program.fh.bFHR1.Image = Image.FromFile(curdir + "\\lang\\default_mui\\save_copy.png");
                Program.fh.bFHR2.Image = Image.FromFile(curdir + "\\lang\\default_mui\\restore_copy.png");
                Program.fh.bFHR3.Image = Image.FromFile(curdir + "\\lang\\default_mui\\delete_copy.png");

                Program.hc.pic_header_1.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\agents.png");
                Program.hc.pic_header_2.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\goods.png");
                Program.hc.pic_header_3.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\avaliable.png");
                Program.hc.pic_header_4.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\price.png");
                Program.hc.pic_header_5.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\sellings.png");
                Program.hc.pic_header_6.BackgroundImage = Image.FromFile(curdir + "\\lang\\default_mui\\bag.png");

                Program.fh.txtLocation.Text = curdir;

                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\prices.xml"))
                {
                    try
                    {

                        DataSet ds = new DataSet();
                        ds.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\prices.xml");
                        ds.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\prices.xml");
                        DataTable dt = new DataTable();

                        dt = ds.Tables[0];
                        dt.TableName = "tab1";

                        for (int r = 0; r < dt.Rows.Count; r++)
                        {
                            dgv_prices.Rows.Add();
                            for (int c = 0; c < dt.Columns.Count; c++)
                            {

                                if (dt.Rows[r].ItemArray[c] != null) dgv_prices.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                                string a;
                                if (dt.Rows[r].ItemArray[c] != null) a = dt.Rows[r].ItemArray[c].ToString();


                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorShow("0x4", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    }


                }

                if (File.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\goods.xml"))
                {
                    try
                    {

                        DataSet ds = new DataSet();
                        ds.ReadXmlSchema(AppDomain.CurrentDomain.BaseDirectory + "\\goods.xml");
                        ds.ReadXml(AppDomain.CurrentDomain.BaseDirectory + "\\goods.xml");
                        DataTable dt = new DataTable();

                        dt = ds.Tables[0];
                        dt.TableName = "tab2";

                        for (int r = 0; r < dt.Rows.Count; r++)
                        {
                            dgv_goods.Rows.Add();
                            for (int c = 0; c < dt.Columns.Count; c++)
                            {

                                if (dt.Rows[r].ItemArray[c] != null) dgv_goods.Rows[r].Cells[c].Value = dt.Rows[r].ItemArray[c];
                                string a;
                                if (dt.Rows[r].ItemArray[c] != null) a = dt.Rows[r].ItemArray[c].ToString();


                            }
                        }

                    }
                    catch (Exception ex)
                    {
                        ErrorShow("0x5", "Произошла ошибка во время импорта таблицы из файла подкачки " + ex.Message);
                    }


                }

            }
            catch (Exception ex)
            {
                Log(0, "0x4c", "Общая ошибка загрузки: " + ex.Data, "kernel panic");
            }
        }

        void ErrorShow(string err_code, string ex_data)
        {
            MessageBox.Show("Произошла ошибка во время загрузки программы:" + Environment.NewLine + "Код ошибки: " + err_code + Environment.NewLine + "Детали:" + ex_data);
            Application.Exit();
        }
        

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.gba.SaveXSD();
            Program.gbc.SaveXSD();
            Program.gbg.SaveXSD();
            Program.gbh.SaveXSD();
            Program.gbp.SaveXSD();
            Program.gbs.SaveXSD();
            Program.gbv.SaveXSD();
            SaveSettingsToFile(Program.prj_var_prj_path);
            Program.core.PrjFilePack(Program.prj_var_prj_path);
            Program.core.DeleteCachedFiles(Program.prj_var_prj_path);
        }

        public bool FileExists(string path)
        {
            if (File.Exists(curdir + path))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void DataGridView_empty(DataGridView data)
        {
            for (int i = data.Rows.Count - 1; i > -1; --i)
            {
                DataGridViewRow row = data.Rows[i];
                if (!row.IsNewRow && row.Cells[0].Value == null)
                {
                    data.Rows.RemoveAt(i);
                }
            }
        }

        public void DoExportExcel()
        {
            try
            {
                if (Registry.GetValue(@"HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\excel.exe", "Path", null) == null)
                {
                    MessageBox.Show("Необходим установленный Microsoft Office Excel 2007 и старше");
                }
                else
                {
                    //DataGridView_empty(switcherPages.dgvAvaliable);
                   // Form form2 = new OpenExcel(switcherPages.dgvAvaliable, true, mui);
                   // form2.Show();
                }
            }
            catch
            {
                MessageBox.Show("Необходим установленный Microsoft Office Excel 2007 и старше");
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.L)
            {
                if (e.Alt == true)
                {
                    Program.log.ShowDialog();
                }
            }
            if (e.KeyCode == Keys.M)
            {
                if (e.Alt == true)
                {
                    FileHeader fh = new FileHeader();
                    fh.Show();
                }
            }
            if (e.KeyCode == Keys.F12)
            {
                switcherPages.SwitchToHistory();
            }
            if (e.KeyCode == Keys.F11)
            {
                Program.gbv.ShowDialog();
            }
            if (e.KeyCode == Keys.F10)
            {
                Program.gbs.ShowDialog();
            }
            if (e.KeyCode == Keys.F9)
            {
                Program.gbp.ShowDialog();
            }
            if (e.KeyCode == Keys.F8)
            {
                Program.gbh.ShowDialog();
            }
            if (e.KeyCode == Keys.F7)
            {
                Program.gbg.ShowDialog();
            }
            if (e.KeyCode == Keys.F6)
            {
                Program.gbc.ShowDialog();
            }
            if (e.KeyCode == Keys.F5)
            {
                Program.gba.ShowDialog();
            }
            if (e.KeyCode == Keys.K)
            {
                Program.gc.ShowDialog();
            }
        }

        string t_price, t_name, t_code;

        private void Dgv_prices_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        public GoodCard gc;

        public void SyncTables()
        {
            int last_row = dgv_prices.Rows.Count - 1;
            for (int i = 0; i < last_row; i++)
            {
                dgv_goods.Rows.Add();
                if (dgv_prices[0, i].Value != null) dgv_goods[0, i].Value = dgv_prices[0, i].Value.ToString();
                if (dgv_prices[1, i].Value != null) dgv_goods[1, i].Value = dgv_prices[1, i].Value.ToString();

            }
        }
        #region TabControl - Hide - Show

        private TabControl _tabControl;
        private List<KeyValuePair<TabPage, int>> _pagesIndexed;
        public void TabControlProvider(TabControl tabControl)
        {
            _tabControl = tabControl;
            _pagesIndexed = new List<KeyValuePair<TabPage, int>>();

            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                _pagesIndexed.Add(new KeyValuePair<TabPage, int>(tabControl.TabPages[i], i));
            }
        }

        public void HideAllPages()
        {
            for (int i = 0; i < _pagesIndexed.Count; i++)
            {
                _tabControl.TabPages.Remove(_pagesIndexed[i].Key);
            }
        }

        public void ShowAllPages()
        {
            for (int i = 0; i < _pagesIndexed.Count; i++)
            {
                _tabControl.TabPages.Add(_pagesIndexed[i].Key);
            }
        }

        public void HidePage(TabPage tabpage)
        {
            if (!_tabControl.TabPages.Contains(tabpage)) return;
            _tabControl.TabPages.Remove(tabpage);
        }

        public void ShowPage(TabPage tabpage)
        {
            if (_tabControl.TabPages.Contains(tabpage)) return;
            InsertTabPage(GetTabPage(tabpage).Key, GetTabPage(tabpage).Value);
        }

        private void InsertTabPage(TabPage tabpage, int index)
        {
            if (index < 0 || index > _tabControl.TabCount)
                throw new ArgumentException("Index out of Range.");
            _tabControl.TabPages.Add(tabpage);
            if (index < _tabControl.TabCount - 1)
                do
                {
                    SwapTabPages(tabpage, (_tabControl.TabPages[_tabControl.TabPages.IndexOf(tabpage) - 1]));
                }
                while (_tabControl.TabPages.IndexOf(tabpage) != index);
            _tabControl.SelectedTab = tabpage;
        }

        private void SwapTabPages(TabPage tabpage1, TabPage tabpage2)
        {
            if (_tabControl.TabPages.Contains(tabpage1) == false || _tabControl.TabPages.Contains(tabpage2) == false)
                throw new ArgumentException("TabPages must be in the TabControls TabPageCollection.");

            int Index1 = _tabControl.TabPages.IndexOf(tabpage1);
            int Index2 = _tabControl.TabPages.IndexOf(tabpage2);
            _tabControl.TabPages[Index1] = tabpage2;
            _tabControl.TabPages[Index2] = tabpage1;
        }

        private void Tlp_Paint(object sender, PaintEventArgs e)
        {

        }

        Panel obj_fading;
        Panel obj_brighten;


        private void TFade_Tick(object sender, EventArgs e)
        {

        }

        private void ФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.fh.Show();

        }

        private void TlpFileLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Tlp_file_right_1_Paint(object sender, PaintEventArgs e)
        {

        }

        private KeyValuePair<TabPage, int> GetTabPage(TabPage tabpage)
        {
            return _pagesIndexed.Where(p => p.Key == tabpage).First();
        }

        #endregion

        private void Dgv_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Dgv_prices_MouseClick(object sender, MouseEventArgs e)
        {
            int currentMouseOverRow = dgv_prices.HitTest(e.X, e.Y).RowIndex;
            int currentMouseOverColumn = dgv_prices.HitTest(e.X, e.Y).ColumnIndex;

            dgv_prices.Rows[currentMouseOverRow].Selected = true;
            if (currentMouseOverRow >= 0)
            {
                gc = new GoodCard(mui);
                gc.Tag = this;
                gc.ShowDialog();


                dgv_prices[0, currentMouseOverRow].Value = t_code;
                dgv_prices[1, currentMouseOverRow].Value = t_name;
                dgv_prices[2, currentMouseOverRow].Value = t_price;

                t_code = "";
                t_name = "";
                t_price = "";

                int last_row = 0;
                last_row = dgv_prices.Rows.Count - 1;
                if (currentMouseOverRow >= last_row)
                {
                    dgv_prices.Rows.Add();
                }
            }
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SwitcherPages_Load(object sender, EventArgs e)
        {

        }

        private void WordTabControl_Load_1(object sender, EventArgs e)
        {

        }

        public void Log(int code, string snls, string phrase, string action)
        {
            Program.log.setToLog("{ Главная }", code, snls, phrase, action);

            /*
             * code: 0 - error, 1 - warning, 2 - message
             * snls: *x** code error
             * phrase: ex.data
             * action: abort, continue (wrng only), miss, hang, bypass (err only), ok (msg only), kernel panic
             * 
             * 1st error = exit = kernel panic, hang
             * 2nd error = abort, bypass
             * 3nd error = miss
             * 
             * warnings = continue
             * 
             * message = ok
             * 
             */
        }
        

       



    }
}
