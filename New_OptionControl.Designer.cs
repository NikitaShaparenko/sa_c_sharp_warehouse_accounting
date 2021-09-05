namespace WarehouseAccounting
{
    partial class New_OptionControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NewText = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PathText = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.cbPasswd = new System.Windows.Forms.CheckBox();
            this.cbAutoSend = new System.Windows.Forms.CheckBox();
            this.cbSNS = new System.Windows.Forms.CheckBox();
            this.cbAutoSave = new System.Windows.Forms.CheckBox();
            this.cbSourceControl = new System.Windows.Forms.CheckBox();
            this.txtpasswd = new System.Windows.Forms.MaskedTextBox();
            this.rbAutoSave5 = new System.Windows.Forms.RadioButton();
            this.rbAutoSave30 = new System.Windows.Forms.RadioButton();
            this.rbAutoSave10 = new System.Windows.Forms.RadioButton();
            this.rbAutoSave60 = new System.Windows.Forms.RadioButton();
            this.rbAutoSaveCustom = new System.Windows.Forms.RadioButton();
            this.cbCryptoExport = new System.Windows.Forms.CheckBox();
            this.cbemail = new System.Windows.Forms.CheckBox();
            this.gbSender = new System.Windows.Forms.GroupBox();
            this.txtSenderPassword = new System.Windows.Forms.MaskedTextBox();
            this.SenderEmailPasswordText = new System.Windows.Forms.Label();
            this.SenderEmailText = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.ReceiverEmailText = new System.Windows.Forms.Label();
            this.txtReceiverEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEmailStandart = new System.Windows.Forms.RadioButton();
            this.gbEmailFeatures = new System.Windows.Forms.GroupBox();
            this.txtSOCKSPort = new System.Windows.Forms.TextBox();
            this.txtSOCKSIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbProxySOCKS5 = new System.Windows.Forms.RadioButton();
            this.bClose = new System.Windows.Forms.Button();
            this.bCreate = new System.Windows.Forms.Button();
            this.cbTelegram = new System.Windows.Forms.CheckBox();
            this.cbWhatsApp = new System.Windows.Forms.CheckBox();
            this.cbViber = new System.Windows.Forms.CheckBox();
            this.picViber = new System.Windows.Forms.PictureBox();
            this.picWhatsApp = new System.Windows.Forms.PictureBox();
            this.picTelegram = new System.Windows.Forms.PictureBox();
            this.tAutoCustom = new System.Windows.Forms.Timer(this.components);
            this.nudAutoSaveCustom = new System.Windows.Forms.NumericUpDown();
            this.gbSender.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbEmailFeatures.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSaveCustom)).BeginInit();
            this.SuspendLayout();
            // 
            // NewText
            // 
            this.NewText.AutoSize = true;
            this.NewText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.NewText.Location = new System.Drawing.Point(40, 0);
            this.NewText.Name = "NewText";
            this.NewText.Size = new System.Drawing.Size(232, 45);
            this.NewText.TabIndex = 1;
            this.NewText.Text = "Новый проект";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(48, 92);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(549, 25);
            this.txtName.TabIndex = 2;
            this.txtName.Text = "New Warehouse";
            this.txtName.TextChanged += new System.EventHandler(this.TxtName_TextChanged);
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(45, 67);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(120, 17);
            this.NameText.TabIndex = 3;
            this.NameText.Text = "Название проекта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(45, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Особенности проекта:";
            // 
            // PathText
            // 
            this.PathText.AutoSize = true;
            this.PathText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathText.Location = new System.Drawing.Point(45, 133);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(152, 17);
            this.PathText.TabIndex = 7;
            this.PathText.Text = "Рабочая папка проекта:";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPath.Location = new System.Drawing.Point(48, 158);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(549, 25);
            this.txtPath.TabIndex = 6;
            this.txtPath.Text = "C:\\Warehouse Accounting\\";
            // 
            // cbPasswd
            // 
            this.cbPasswd.AutoSize = true;
            this.cbPasswd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPasswd.Location = new System.Drawing.Point(48, 235);
            this.cbPasswd.Name = "cbPasswd";
            this.cbPasswd.Size = new System.Drawing.Size(140, 21);
            this.cbPasswd.TabIndex = 8;
            this.cbPasswd.Text = "Защитить паролем";
            this.cbPasswd.UseVisualStyleBackColor = true;
            this.cbPasswd.CheckedChanged += new System.EventHandler(this.CbPasswd_CheckedChanged);
            // 
            // cbAutoSend
            // 
            this.cbAutoSend.AutoSize = true;
            this.cbAutoSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAutoSend.Location = new System.Drawing.Point(48, 339);
            this.cbAutoSend.Name = "cbAutoSend";
            this.cbAutoSend.Size = new System.Drawing.Size(111, 21);
            this.cbAutoSend.TabIndex = 10;
            this.cbAutoSend.Text = "Авторассылка";
            this.cbAutoSend.UseVisualStyleBackColor = true;
            // 
            // cbSNS
            // 
            this.cbSNS.AutoSize = true;
            this.cbSNS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSNS.Location = new System.Drawing.Point(48, 395);
            this.cbSNS.Name = "cbSNS";
            this.cbSNS.Size = new System.Drawing.Size(105, 21);
            this.cbSNS.TabIndex = 11;
            this.cbSNS.Text = "Месседжеры";
            this.cbSNS.UseVisualStyleBackColor = true;
            this.cbSNS.CheckedChanged += new System.EventHandler(this.CbSNS_CheckedChanged);
            // 
            // cbAutoSave
            // 
            this.cbAutoSave.AutoSize = true;
            this.cbAutoSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAutoSave.Location = new System.Drawing.Point(48, 281);
            this.cbAutoSave.Name = "cbAutoSave";
            this.cbAutoSave.Size = new System.Drawing.Size(125, 21);
            this.cbAutoSave.TabIndex = 12;
            this.cbAutoSave.Text = "Автосохранение";
            this.cbAutoSave.UseVisualStyleBackColor = true;
            this.cbAutoSave.CheckedChanged += new System.EventHandler(this.CbAutoSave_CheckedChanged);
            // 
            // cbSourceControl
            // 
            this.cbSourceControl.AutoSize = true;
            this.cbSourceControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSourceControl.Location = new System.Drawing.Point(48, 258);
            this.cbSourceControl.Name = "cbSourceControl";
            this.cbSourceControl.Size = new System.Drawing.Size(131, 21);
            this.cbSourceControl.TabIndex = 13;
            this.cbSourceControl.Text = "Контроль версий";
            this.cbSourceControl.UseVisualStyleBackColor = true;
            // 
            // txtpasswd
            // 
            this.txtpasswd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpasswd.Location = new System.Drawing.Point(194, 231);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.Size = new System.Drawing.Size(226, 25);
            this.txtpasswd.TabIndex = 14;
            // 
            // rbAutoSave5
            // 
            this.rbAutoSave5.AutoSize = true;
            this.rbAutoSave5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave5.Location = new System.Drawing.Point(176, 282);
            this.rbAutoSave5.Name = "rbAutoSave5";
            this.rbAutoSave5.Size = new System.Drawing.Size(122, 21);
            this.rbAutoSave5.TabIndex = 15;
            this.rbAutoSave5.TabStop = true;
            this.rbAutoSave5.Text = "Каждые 5 минут";
            this.rbAutoSave5.UseVisualStyleBackColor = true;
            this.rbAutoSave5.CheckedChanged += new System.EventHandler(this.RbAutoSave5_CheckedChanged);
            // 
            // rbAutoSave30
            // 
            this.rbAutoSave30.AutoSize = true;
            this.rbAutoSave30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave30.Location = new System.Drawing.Point(337, 283);
            this.rbAutoSave30.Name = "rbAutoSave30";
            this.rbAutoSave30.Size = new System.Drawing.Size(129, 21);
            this.rbAutoSave30.TabIndex = 16;
            this.rbAutoSave30.TabStop = true;
            this.rbAutoSave30.Text = "Каждые 30 минут";
            this.rbAutoSave30.UseVisualStyleBackColor = true;
            this.rbAutoSave30.CheckedChanged += new System.EventHandler(this.RbAutoSave30_CheckedChanged);
            // 
            // rbAutoSave10
            // 
            this.rbAutoSave10.AutoSize = true;
            this.rbAutoSave10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave10.Location = new System.Drawing.Point(176, 306);
            this.rbAutoSave10.Name = "rbAutoSave10";
            this.rbAutoSave10.Size = new System.Drawing.Size(129, 21);
            this.rbAutoSave10.TabIndex = 17;
            this.rbAutoSave10.TabStop = true;
            this.rbAutoSave10.Text = "Каждые 10 минут";
            this.rbAutoSave10.UseVisualStyleBackColor = true;
            this.rbAutoSave10.CheckedChanged += new System.EventHandler(this.RbAutoSave10_CheckedChanged);
            // 
            // rbAutoSave60
            // 
            this.rbAutoSave60.AutoSize = true;
            this.rbAutoSave60.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave60.Location = new System.Drawing.Point(337, 308);
            this.rbAutoSave60.Name = "rbAutoSave60";
            this.rbAutoSave60.Size = new System.Drawing.Size(97, 21);
            this.rbAutoSave60.TabIndex = 18;
            this.rbAutoSave60.TabStop = true;
            this.rbAutoSave60.Text = "Каждый час";
            this.rbAutoSave60.UseVisualStyleBackColor = true;
            this.rbAutoSave60.CheckedChanged += new System.EventHandler(this.RbAutoSave60_CheckedChanged);
            // 
            // rbAutoSaveCustom
            // 
            this.rbAutoSaveCustom.AutoSize = true;
            this.rbAutoSaveCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSaveCustom.Location = new System.Drawing.Point(504, 283);
            this.rbAutoSaveCustom.Name = "rbAutoSaveCustom";
            this.rbAutoSaveCustom.Size = new System.Drawing.Size(137, 21);
            this.rbAutoSaveCustom.TabIndex = 19;
            this.rbAutoSaveCustom.TabStop = true;
            this.rbAutoSaveCustom.Text = "Каждые {00} минут";
            this.rbAutoSaveCustom.UseVisualStyleBackColor = true;
            this.rbAutoSaveCustom.CheckedChanged += new System.EventHandler(this.RbAutoSaveCustom_CheckedChanged);
            // 
            // cbCryptoExport
            // 
            this.cbCryptoExport.AutoSize = true;
            this.cbCryptoExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCryptoExport.Location = new System.Drawing.Point(426, 233);
            this.cbCryptoExport.Name = "cbCryptoExport";
            this.cbCryptoExport.Size = new System.Drawing.Size(148, 21);
            this.cbCryptoExport.TabIndex = 23;
            this.cbCryptoExport.Text = "Шифровать экспорт";
            this.cbCryptoExport.UseVisualStyleBackColor = true;
            this.cbCryptoExport.CheckedChanged += new System.EventHandler(this.CbCryptoExport_CheckedChanged);
            // 
            // cbemail
            // 
            this.cbemail.AutoSize = true;
            this.cbemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbemail.Location = new System.Drawing.Point(48, 366);
            this.cbemail.Name = "cbemail";
            this.cbemail.Size = new System.Drawing.Size(142, 21);
            this.cbemail.TabIndex = 24;
            this.cbemail.Text = "Электронная почта";
            this.cbemail.UseVisualStyleBackColor = true;
            this.cbemail.CheckedChanged += new System.EventHandler(this.Cbemail_CheckedChanged);
            // 
            // gbSender
            // 
            this.gbSender.Controls.Add(this.txtSenderPassword);
            this.gbSender.Controls.Add(this.SenderEmailPasswordText);
            this.gbSender.Controls.Add(this.SenderEmailText);
            this.gbSender.Controls.Add(this.txtSenderEmail);
            this.gbSender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSender.Location = new System.Drawing.Point(194, 366);
            this.gbSender.Name = "gbSender";
            this.gbSender.Size = new System.Drawing.Size(297, 96);
            this.gbSender.TabIndex = 25;
            this.gbSender.TabStop = false;
            this.gbSender.Text = "Данные отправителя";
            // 
            // txtSenderPassword
            // 
            this.txtSenderPassword.Location = new System.Drawing.Point(132, 56);
            this.txtSenderPassword.Name = "txtSenderPassword";
            this.txtSenderPassword.Size = new System.Drawing.Size(159, 25);
            this.txtSenderPassword.TabIndex = 37;
            // 
            // SenderEmailPasswordText
            // 
            this.SenderEmailPasswordText.AutoSize = true;
            this.SenderEmailPasswordText.Location = new System.Drawing.Point(22, 58);
            this.SenderEmailPasswordText.Name = "SenderEmailPasswordText";
            this.SenderEmailPasswordText.Size = new System.Drawing.Size(57, 17);
            this.SenderEmailPasswordText.TabIndex = 35;
            this.SenderEmailPasswordText.Text = "Пароль:";
            // 
            // SenderEmailText
            // 
            this.SenderEmailText.AutoSize = true;
            this.SenderEmailText.Location = new System.Drawing.Point(19, 28);
            this.SenderEmailText.Name = "SenderEmailText";
            this.SenderEmailText.Size = new System.Drawing.Size(86, 17);
            this.SenderEmailText.TabIndex = 34;
            this.SenderEmailText.Text = "E-mail адрес:";
            this.SenderEmailText.Click += new System.EventHandler(this.SenderEmailText_Click);
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(132, 23);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(159, 25);
            this.txtSenderEmail.TabIndex = 31;
            // 
            // ReceiverEmailText
            // 
            this.ReceiverEmailText.AutoSize = true;
            this.ReceiverEmailText.Location = new System.Drawing.Point(22, 29);
            this.ReceiverEmailText.Name = "ReceiverEmailText";
            this.ReceiverEmailText.Size = new System.Drawing.Size(47, 17);
            this.ReceiverEmailText.TabIndex = 36;
            this.ReceiverEmailText.Text = "E-mail:";
            // 
            // txtReceiverEmail
            // 
            this.txtReceiverEmail.Location = new System.Drawing.Point(99, 26);
            this.txtReceiverEmail.Name = "txtReceiverEmail";
            this.txtReceiverEmail.Size = new System.Drawing.Size(159, 25);
            this.txtReceiverEmail.TabIndex = 33;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReceiverEmailText);
            this.groupBox1.Controls.Add(this.txtReceiverEmail);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(210, 468);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 57);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные получателя";
            // 
            // rbEmailStandart
            // 
            this.rbEmailStandart.AutoSize = true;
            this.rbEmailStandart.Checked = true;
            this.rbEmailStandart.Location = new System.Drawing.Point(6, 28);
            this.rbEmailStandart.Name = "rbEmailStandart";
            this.rbEmailStandart.Size = new System.Drawing.Size(69, 21);
            this.rbEmailStandart.TabIndex = 27;
            this.rbEmailStandart.TabStop = true;
            this.rbEmailStandart.Text = "Ничего";
            this.rbEmailStandart.UseVisualStyleBackColor = true;
            // 
            // gbEmailFeatures
            // 
            this.gbEmailFeatures.Controls.Add(this.txtSOCKSPort);
            this.gbEmailFeatures.Controls.Add(this.txtSOCKSIP);
            this.gbEmailFeatures.Controls.Add(this.label3);
            this.gbEmailFeatures.Controls.Add(this.label1);
            this.gbEmailFeatures.Controls.Add(this.rbProxySOCKS5);
            this.gbEmailFeatures.Controls.Add(this.rbEmailStandart);
            this.gbEmailFeatures.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEmailFeatures.Location = new System.Drawing.Point(497, 366);
            this.gbEmailFeatures.Name = "gbEmailFeatures";
            this.gbEmailFeatures.Size = new System.Drawing.Size(178, 148);
            this.gbEmailFeatures.TabIndex = 28;
            this.gbEmailFeatures.TabStop = false;
            this.gbEmailFeatures.Text = "Особенности";
            // 
            // txtSOCKSPort
            // 
            this.txtSOCKSPort.Location = new System.Drawing.Point(56, 115);
            this.txtSOCKSPort.Name = "txtSOCKSPort";
            this.txtSOCKSPort.Size = new System.Drawing.Size(116, 25);
            this.txtSOCKSPort.TabIndex = 32;
            // 
            // txtSOCKSIP
            // 
            this.txtSOCKSIP.Location = new System.Drawing.Point(41, 88);
            this.txtSOCKSIP.Name = "txtSOCKSIP";
            this.txtSOCKSIP.Size = new System.Drawing.Size(131, 25);
            this.txtSOCKSIP.TabIndex = 31;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 30;
            this.label3.Text = "Порт:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "IP:";
            // 
            // rbProxySOCKS5
            // 
            this.rbProxySOCKS5.AutoSize = true;
            this.rbProxySOCKS5.Location = new System.Drawing.Point(7, 58);
            this.rbProxySOCKS5.Name = "rbProxySOCKS5";
            this.rbProxySOCKS5.Size = new System.Drawing.Size(114, 21);
            this.rbProxySOCKS5.TabIndex = 28;
            this.rbProxySOCKS5.Text = "Прокси SOCKS";
            this.rbProxySOCKS5.UseVisualStyleBackColor = true;
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.Location = new System.Drawing.Point(560, 537);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(115, 33);
            this.bClose.TabIndex = 29;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = true;
            // 
            // bCreate
            // 
            this.bCreate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCreate.Location = new System.Drawing.Point(436, 537);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(117, 34);
            this.bCreate.TabIndex = 30;
            this.bCreate.Text = "Создать";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // cbTelegram
            // 
            this.cbTelegram.AutoSize = true;
            this.cbTelegram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTelegram.Location = new System.Drawing.Point(27, 436);
            this.cbTelegram.Name = "cbTelegram";
            this.cbTelegram.Size = new System.Drawing.Size(15, 14);
            this.cbTelegram.TabIndex = 34;
            this.cbTelegram.UseVisualStyleBackColor = true;
            this.cbTelegram.CheckedChanged += new System.EventHandler(this.CbTelegram_CheckedChanged);
            // 
            // cbWhatsApp
            // 
            this.cbWhatsApp.AutoSize = true;
            this.cbWhatsApp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWhatsApp.Location = new System.Drawing.Point(27, 497);
            this.cbWhatsApp.Name = "cbWhatsApp";
            this.cbWhatsApp.Size = new System.Drawing.Size(15, 14);
            this.cbWhatsApp.TabIndex = 35;
            this.cbWhatsApp.UseVisualStyleBackColor = true;
            this.cbWhatsApp.CheckedChanged += new System.EventHandler(this.CbWhatsApp_CheckedChanged);
            // 
            // cbViber
            // 
            this.cbViber.AutoSize = true;
            this.cbViber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbViber.Location = new System.Drawing.Point(108, 433);
            this.cbViber.Name = "cbViber";
            this.cbViber.Size = new System.Drawing.Size(15, 14);
            this.cbViber.TabIndex = 36;
            this.cbViber.UseVisualStyleBackColor = true;
            this.cbViber.CheckedChanged += new System.EventHandler(this.CbViber_CheckedChanged);
            // 
            // picViber
            // 
            this.picViber.Image = global::WarehouseAccounting.Properties.Resources.Viber50px;
            this.picViber.Location = new System.Drawing.Point(129, 419);
            this.picViber.Name = "picViber";
            this.picViber.Size = new System.Drawing.Size(50, 50);
            this.picViber.TabIndex = 33;
            this.picViber.TabStop = false;
            // 
            // picWhatsApp
            // 
            this.picWhatsApp.Image = global::WarehouseAccounting.Properties.Resources.WhatsApp50px;
            this.picWhatsApp.Location = new System.Drawing.Point(48, 481);
            this.picWhatsApp.Name = "picWhatsApp";
            this.picWhatsApp.Size = new System.Drawing.Size(50, 50);
            this.picWhatsApp.TabIndex = 32;
            this.picWhatsApp.TabStop = false;
            // 
            // picTelegram
            // 
            this.picTelegram.Image = global::WarehouseAccounting.Properties.Resources.Telegram_Messenger50px;
            this.picTelegram.Location = new System.Drawing.Point(48, 419);
            this.picTelegram.Name = "picTelegram";
            this.picTelegram.Size = new System.Drawing.Size(50, 50);
            this.picTelegram.TabIndex = 31;
            this.picTelegram.TabStop = false;
            // 
            // tAutoCustom
            // 
            this.tAutoCustom.Enabled = true;
            this.tAutoCustom.Tick += new System.EventHandler(this.TAutoCustom_Tick);
            // 
            // nudAutoSaveCustom
            // 
            this.nudAutoSaveCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudAutoSaveCustom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudAutoSaveCustom.Location = new System.Drawing.Point(507, 310);
            this.nudAutoSaveCustom.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nudAutoSaveCustom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoSaveCustom.Name = "nudAutoSaveCustom";
            this.nudAutoSaveCustom.Size = new System.Drawing.Size(120, 25);
            this.nudAutoSaveCustom.TabIndex = 37;
            this.nudAutoSaveCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAutoSaveCustom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudAutoSaveCustom.ValueChanged += new System.EventHandler(this.NudAutoSaveCustom_ValueChanged);
            // 
            // New_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.nudAutoSaveCustom);
            this.Controls.Add(this.cbViber);
            this.Controls.Add(this.cbWhatsApp);
            this.Controls.Add(this.cbTelegram);
            this.Controls.Add(this.picViber);
            this.Controls.Add(this.picWhatsApp);
            this.Controls.Add(this.picTelegram);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.gbEmailFeatures);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbSender);
            this.Controls.Add(this.cbemail);
            this.Controls.Add(this.cbCryptoExport);
            this.Controls.Add(this.rbAutoSaveCustom);
            this.Controls.Add(this.rbAutoSave60);
            this.Controls.Add(this.rbAutoSave10);
            this.Controls.Add(this.rbAutoSave30);
            this.Controls.Add(this.rbAutoSave5);
            this.Controls.Add(this.txtpasswd);
            this.Controls.Add(this.cbSourceControl);
            this.Controls.Add(this.cbAutoSave);
            this.Controls.Add(this.cbSNS);
            this.Controls.Add(this.cbAutoSend);
            this.Controls.Add(this.cbPasswd);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.NewText);
            this.Name = "New_OptionControl";
            this.Size = new System.Drawing.Size(687, 581);
            this.Load += new System.EventHandler(this.New_OptionControl_Load);
            this.gbSender.ResumeLayout(false);
            this.gbSender.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbEmailFeatures.ResumeLayout(false);
            this.gbEmailFeatures.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picViber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSaveCustom)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NewText;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label PathText;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.CheckBox cbPasswd;
        private System.Windows.Forms.CheckBox cbAutoSend;
        private System.Windows.Forms.CheckBox cbSNS;
        private System.Windows.Forms.CheckBox cbAutoSave;
        private System.Windows.Forms.CheckBox cbSourceControl;
        private System.Windows.Forms.MaskedTextBox txtpasswd;
        private System.Windows.Forms.RadioButton rbAutoSave5;
        private System.Windows.Forms.RadioButton rbAutoSave30;
        private System.Windows.Forms.RadioButton rbAutoSave10;
        private System.Windows.Forms.RadioButton rbAutoSave60;
        private System.Windows.Forms.RadioButton rbAutoSaveCustom;
        private System.Windows.Forms.CheckBox cbCryptoExport;
        private System.Windows.Forms.CheckBox cbemail;
        private System.Windows.Forms.GroupBox gbSender;
        private System.Windows.Forms.MaskedTextBox txtSenderPassword;
        private System.Windows.Forms.Label SenderEmailPasswordText;
        private System.Windows.Forms.Label SenderEmailText;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.Label ReceiverEmailText;
        private System.Windows.Forms.TextBox txtReceiverEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmailStandart;
        private System.Windows.Forms.GroupBox gbEmailFeatures;
        private System.Windows.Forms.TextBox txtSOCKSPort;
        private System.Windows.Forms.TextBox txtSOCKSIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbProxySOCKS5;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.PictureBox picTelegram;
        private System.Windows.Forms.PictureBox picWhatsApp;
        private System.Windows.Forms.PictureBox picViber;
        private System.Windows.Forms.CheckBox cbTelegram;
        private System.Windows.Forms.CheckBox cbWhatsApp;
        private System.Windows.Forms.CheckBox cbViber;
        private System.Windows.Forms.Timer tAutoCustom;
        private System.Windows.Forms.NumericUpDown nudAutoSaveCustom;
    }
}
