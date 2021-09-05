namespace WarehouseAccounting
{
    partial class SettingsForm
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.NewText = new System.Windows.Forms.Label();
            this.bChange = new System.Windows.Forms.Button();
            this.PathText = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.NameText = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.nudAutoSaveCustom = new System.Windows.Forms.NumericUpDown();
            this.cbViber = new System.Windows.Forms.CheckBox();
            this.cbWhatsApp = new System.Windows.Forms.CheckBox();
            this.cbTelegram = new System.Windows.Forms.CheckBox();
            this.picViber = new System.Windows.Forms.PictureBox();
            this.picWhatsApp = new System.Windows.Forms.PictureBox();
            this.picTelegram = new System.Windows.Forms.PictureBox();
            this.gbEmailFeatures = new System.Windows.Forms.GroupBox();
            this.txtSOCKSIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rbSOCKS5 = new System.Windows.Forms.RadioButton();
            this.rbEmailStandart = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ReceiverEmailText = new System.Windows.Forms.Label();
            this.txtReceiverEmail = new System.Windows.Forms.TextBox();
            this.gbSender = new System.Windows.Forms.GroupBox();
            this.txtSenderPassword = new System.Windows.Forms.MaskedTextBox();
            this.SenderEmailPasswordText = new System.Windows.Forms.Label();
            this.SenderEmailText = new System.Windows.Forms.Label();
            this.txtSenderEmail = new System.Windows.Forms.TextBox();
            this.cbemail = new System.Windows.Forms.CheckBox();
            this.cbCryptoExport = new System.Windows.Forms.CheckBox();
            this.rbAutoSaveCustom = new System.Windows.Forms.RadioButton();
            this.rbAutoSave60 = new System.Windows.Forms.RadioButton();
            this.rbAutoSave10 = new System.Windows.Forms.RadioButton();
            this.rbAutoSave30 = new System.Windows.Forms.RadioButton();
            this.rbAutoSave5 = new System.Windows.Forms.RadioButton();
            this.txtpasswd = new System.Windows.Forms.MaskedTextBox();
            this.cbSourceControl = new System.Windows.Forms.CheckBox();
            this.cbAutoSave = new System.Windows.Forms.CheckBox();
            this.cbSNS = new System.Windows.Forms.CheckBox();
            this.cbAutoSend = new System.Windows.Forms.CheckBox();
            this.cbPasswd = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tAutoCustom = new System.Windows.Forms.Timer(this.components);
            this.txtSOCKSPort = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSaveCustom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegram)).BeginInit();
            this.gbEmailFeatures.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbSender.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOCKSPort)).BeginInit();
            this.SuspendLayout();
            // 
            // NewText
            // 
            this.NewText.AutoSize = true;
            this.NewText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.NewText.Location = new System.Drawing.Point(3, 0);
            this.NewText.Name = "NewText";
            this.NewText.Size = new System.Drawing.Size(306, 45);
            this.NewText.TabIndex = 18;
            this.NewText.Text = "Настройки проекта";
            // 
            // bChange
            // 
            this.bChange.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bChange.Location = new System.Drawing.Point(536, 534);
            this.bChange.Name = "bChange";
            this.bChange.Size = new System.Drawing.Size(117, 34);
            this.bChange.TabIndex = 60;
            this.bChange.Text = "Изменить";
            this.bChange.UseVisualStyleBackColor = true;
            this.bChange.Click += new System.EventHandler(this.BChange_Click);
            // 
            // PathText
            // 
            this.PathText.AutoSize = true;
            this.PathText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathText.Location = new System.Drawing.Point(23, 122);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(152, 17);
            this.PathText.TabIndex = 41;
            this.PathText.Text = "Рабочая папка проекта:";
            // 
            // txtPath
            // 
            this.txtPath.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPath.Location = new System.Drawing.Point(26, 147);
            this.txtPath.Name = "txtPath";
            this.txtPath.ReadOnly = true;
            this.txtPath.Size = new System.Drawing.Size(549, 25);
            this.txtPath.TabIndex = 40;
            this.txtPath.Text = "C:\\Warehouse Accounting\\";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(23, 56);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(120, 17);
            this.NameText.TabIndex = 38;
            this.NameText.Text = "Название проекта:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(26, 81);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(549, 25);
            this.txtName.TabIndex = 37;
            this.txtName.Text = "New Warehouse";
            // 
            // nudAutoSaveCustom
            // 
            this.nudAutoSaveCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nudAutoSaveCustom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.nudAutoSaveCustom.Location = new System.Drawing.Point(488, 293);
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
            this.nudAutoSaveCustom.TabIndex = 84;
            this.nudAutoSaveCustom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudAutoSaveCustom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbViber
            // 
            this.cbViber.AutoSize = true;
            this.cbViber.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbViber.Location = new System.Drawing.Point(89, 416);
            this.cbViber.Name = "cbViber";
            this.cbViber.Size = new System.Drawing.Size(15, 14);
            this.cbViber.TabIndex = 83;
            this.cbViber.UseVisualStyleBackColor = true;
            // 
            // cbWhatsApp
            // 
            this.cbWhatsApp.AutoSize = true;
            this.cbWhatsApp.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbWhatsApp.Location = new System.Drawing.Point(8, 480);
            this.cbWhatsApp.Name = "cbWhatsApp";
            this.cbWhatsApp.Size = new System.Drawing.Size(15, 14);
            this.cbWhatsApp.TabIndex = 82;
            this.cbWhatsApp.UseVisualStyleBackColor = true;
            // 
            // cbTelegram
            // 
            this.cbTelegram.AutoSize = true;
            this.cbTelegram.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbTelegram.Location = new System.Drawing.Point(8, 419);
            this.cbTelegram.Name = "cbTelegram";
            this.cbTelegram.Size = new System.Drawing.Size(15, 14);
            this.cbTelegram.TabIndex = 81;
            this.cbTelegram.UseVisualStyleBackColor = true;
            // 
            // picViber
            // 
            this.picViber.Image = global::WarehouseAccounting.Properties.Resources.Viber50px;
            this.picViber.Location = new System.Drawing.Point(110, 402);
            this.picViber.Name = "picViber";
            this.picViber.Size = new System.Drawing.Size(50, 50);
            this.picViber.TabIndex = 80;
            this.picViber.TabStop = false;
            // 
            // picWhatsApp
            // 
            this.picWhatsApp.Image = global::WarehouseAccounting.Properties.Resources.WhatsApp50px;
            this.picWhatsApp.Location = new System.Drawing.Point(29, 464);
            this.picWhatsApp.Name = "picWhatsApp";
            this.picWhatsApp.Size = new System.Drawing.Size(50, 50);
            this.picWhatsApp.TabIndex = 79;
            this.picWhatsApp.TabStop = false;
            // 
            // picTelegram
            // 
            this.picTelegram.Image = global::WarehouseAccounting.Properties.Resources.Telegram_Messenger50px;
            this.picTelegram.Location = new System.Drawing.Point(29, 402);
            this.picTelegram.Name = "picTelegram";
            this.picTelegram.Size = new System.Drawing.Size(50, 50);
            this.picTelegram.TabIndex = 78;
            this.picTelegram.TabStop = false;
            // 
            // gbEmailFeatures
            // 
            this.gbEmailFeatures.Controls.Add(this.txtSOCKSPort);
            this.gbEmailFeatures.Controls.Add(this.txtSOCKSIP);
            this.gbEmailFeatures.Controls.Add(this.label3);
            this.gbEmailFeatures.Controls.Add(this.label1);
            this.gbEmailFeatures.Controls.Add(this.rbSOCKS5);
            this.gbEmailFeatures.Controls.Add(this.rbEmailStandart);
            this.gbEmailFeatures.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbEmailFeatures.Location = new System.Drawing.Point(478, 349);
            this.gbEmailFeatures.Name = "gbEmailFeatures";
            this.gbEmailFeatures.Size = new System.Drawing.Size(178, 148);
            this.gbEmailFeatures.TabIndex = 77;
            this.gbEmailFeatures.TabStop = false;
            this.gbEmailFeatures.Text = "Особенности";
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
            // rbSOCKS5
            // 
            this.rbSOCKS5.AutoSize = true;
            this.rbSOCKS5.Location = new System.Drawing.Point(7, 58);
            this.rbSOCKS5.Name = "rbSOCKS5";
            this.rbSOCKS5.Size = new System.Drawing.Size(114, 21);
            this.rbSOCKS5.TabIndex = 28;
            this.rbSOCKS5.Text = "Прокси SOCKS";
            this.rbSOCKS5.UseVisualStyleBackColor = true;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ReceiverEmailText);
            this.groupBox1.Controls.Add(this.txtReceiverEmail);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(191, 451);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 57);
            this.groupBox1.TabIndex = 76;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Данные получателя";
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
            // gbSender
            // 
            this.gbSender.Controls.Add(this.txtSenderPassword);
            this.gbSender.Controls.Add(this.SenderEmailPasswordText);
            this.gbSender.Controls.Add(this.SenderEmailText);
            this.gbSender.Controls.Add(this.txtSenderEmail);
            this.gbSender.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gbSender.Location = new System.Drawing.Point(175, 349);
            this.gbSender.Name = "gbSender";
            this.gbSender.Size = new System.Drawing.Size(297, 96);
            this.gbSender.TabIndex = 75;
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
            // 
            // txtSenderEmail
            // 
            this.txtSenderEmail.Location = new System.Drawing.Point(132, 23);
            this.txtSenderEmail.Name = "txtSenderEmail";
            this.txtSenderEmail.Size = new System.Drawing.Size(159, 25);
            this.txtSenderEmail.TabIndex = 31;
            // 
            // cbemail
            // 
            this.cbemail.AutoSize = true;
            this.cbemail.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbemail.Location = new System.Drawing.Point(29, 349);
            this.cbemail.Name = "cbemail";
            this.cbemail.Size = new System.Drawing.Size(142, 21);
            this.cbemail.TabIndex = 74;
            this.cbemail.Text = "Электронная почта";
            this.cbemail.UseVisualStyleBackColor = true;
            // 
            // cbCryptoExport
            // 
            this.cbCryptoExport.AutoSize = true;
            this.cbCryptoExport.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbCryptoExport.Location = new System.Drawing.Point(407, 216);
            this.cbCryptoExport.Name = "cbCryptoExport";
            this.cbCryptoExport.Size = new System.Drawing.Size(148, 21);
            this.cbCryptoExport.TabIndex = 73;
            this.cbCryptoExport.Text = "Шифровать экспорт";
            this.cbCryptoExport.UseVisualStyleBackColor = true;
            // 
            // rbAutoSaveCustom
            // 
            this.rbAutoSaveCustom.AutoSize = true;
            this.rbAutoSaveCustom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSaveCustom.Location = new System.Drawing.Point(485, 266);
            this.rbAutoSaveCustom.Name = "rbAutoSaveCustom";
            this.rbAutoSaveCustom.Size = new System.Drawing.Size(137, 21);
            this.rbAutoSaveCustom.TabIndex = 72;
            this.rbAutoSaveCustom.TabStop = true;
            this.rbAutoSaveCustom.Text = "Каждые {00} минут";
            this.rbAutoSaveCustom.UseVisualStyleBackColor = true;
            // 
            // rbAutoSave60
            // 
            this.rbAutoSave60.AutoSize = true;
            this.rbAutoSave60.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave60.Location = new System.Drawing.Point(318, 291);
            this.rbAutoSave60.Name = "rbAutoSave60";
            this.rbAutoSave60.Size = new System.Drawing.Size(97, 21);
            this.rbAutoSave60.TabIndex = 71;
            this.rbAutoSave60.TabStop = true;
            this.rbAutoSave60.Text = "Каждый час";
            this.rbAutoSave60.UseVisualStyleBackColor = true;
            // 
            // rbAutoSave10
            // 
            this.rbAutoSave10.AutoSize = true;
            this.rbAutoSave10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave10.Location = new System.Drawing.Point(157, 289);
            this.rbAutoSave10.Name = "rbAutoSave10";
            this.rbAutoSave10.Size = new System.Drawing.Size(129, 21);
            this.rbAutoSave10.TabIndex = 70;
            this.rbAutoSave10.TabStop = true;
            this.rbAutoSave10.Text = "Каждые 10 минут";
            this.rbAutoSave10.UseVisualStyleBackColor = true;
            // 
            // rbAutoSave30
            // 
            this.rbAutoSave30.AutoSize = true;
            this.rbAutoSave30.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave30.Location = new System.Drawing.Point(318, 266);
            this.rbAutoSave30.Name = "rbAutoSave30";
            this.rbAutoSave30.Size = new System.Drawing.Size(129, 21);
            this.rbAutoSave30.TabIndex = 69;
            this.rbAutoSave30.TabStop = true;
            this.rbAutoSave30.Text = "Каждые 30 минут";
            this.rbAutoSave30.UseVisualStyleBackColor = true;
            // 
            // rbAutoSave5
            // 
            this.rbAutoSave5.AutoSize = true;
            this.rbAutoSave5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbAutoSave5.Location = new System.Drawing.Point(157, 265);
            this.rbAutoSave5.Name = "rbAutoSave5";
            this.rbAutoSave5.Size = new System.Drawing.Size(122, 21);
            this.rbAutoSave5.TabIndex = 68;
            this.rbAutoSave5.TabStop = true;
            this.rbAutoSave5.Text = "Каждые 5 минут";
            this.rbAutoSave5.UseVisualStyleBackColor = true;
            // 
            // txtpasswd
            // 
            this.txtpasswd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpasswd.Location = new System.Drawing.Point(175, 214);
            this.txtpasswd.Name = "txtpasswd";
            this.txtpasswd.Size = new System.Drawing.Size(226, 25);
            this.txtpasswd.TabIndex = 67;
            // 
            // cbSourceControl
            // 
            this.cbSourceControl.AutoSize = true;
            this.cbSourceControl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSourceControl.Location = new System.Drawing.Point(29, 241);
            this.cbSourceControl.Name = "cbSourceControl";
            this.cbSourceControl.Size = new System.Drawing.Size(131, 21);
            this.cbSourceControl.TabIndex = 66;
            this.cbSourceControl.Text = "Контроль версий";
            this.cbSourceControl.UseVisualStyleBackColor = true;
            // 
            // cbAutoSave
            // 
            this.cbAutoSave.AutoSize = true;
            this.cbAutoSave.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAutoSave.Location = new System.Drawing.Point(29, 264);
            this.cbAutoSave.Name = "cbAutoSave";
            this.cbAutoSave.Size = new System.Drawing.Size(125, 21);
            this.cbAutoSave.TabIndex = 65;
            this.cbAutoSave.Text = "Автосохранение";
            this.cbAutoSave.UseVisualStyleBackColor = true;
            // 
            // cbSNS
            // 
            this.cbSNS.AutoSize = true;
            this.cbSNS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbSNS.Location = new System.Drawing.Point(29, 378);
            this.cbSNS.Name = "cbSNS";
            this.cbSNS.Size = new System.Drawing.Size(105, 21);
            this.cbSNS.TabIndex = 64;
            this.cbSNS.Text = "Месседжеры";
            this.cbSNS.UseVisualStyleBackColor = true;
            // 
            // cbAutoSend
            // 
            this.cbAutoSend.AutoSize = true;
            this.cbAutoSend.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbAutoSend.Location = new System.Drawing.Point(29, 322);
            this.cbAutoSend.Name = "cbAutoSend";
            this.cbAutoSend.Size = new System.Drawing.Size(111, 21);
            this.cbAutoSend.TabIndex = 63;
            this.cbAutoSend.Text = "Авторассылка";
            this.cbAutoSend.UseVisualStyleBackColor = true;
            // 
            // cbPasswd
            // 
            this.cbPasswd.AutoSize = true;
            this.cbPasswd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbPasswd.Location = new System.Drawing.Point(29, 218);
            this.cbPasswd.Name = "cbPasswd";
            this.cbPasswd.Size = new System.Drawing.Size(140, 21);
            this.cbPasswd.TabIndex = 62;
            this.cbPasswd.Text = "Защитить паролем";
            this.cbPasswd.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 61;
            this.label2.Text = "Особенности проекта:";
            // 
            // tAutoCustom
            // 
            this.tAutoCustom.Enabled = true;
            this.tAutoCustom.Tick += new System.EventHandler(this.TAutoCustom_Tick);
            // 
            // txtSOCKSPort
            // 
            this.txtSOCKSPort.Location = new System.Drawing.Point(53, 115);
            this.txtSOCKSPort.Name = "txtSOCKSPort";
            this.txtSOCKSPort.Size = new System.Drawing.Size(120, 25);
            this.txtSOCKSPort.TabIndex = 32;
            // 
            // SettingsForm
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
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bChange);
            this.Controls.Add(this.PathText);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.NewText);
            this.Name = "SettingsForm";
            this.Size = new System.Drawing.Size(687, 581);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSaveCustom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegram)).EndInit();
            this.gbEmailFeatures.ResumeLayout(false);
            this.gbEmailFeatures.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbSender.ResumeLayout(false);
            this.gbSender.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtSOCKSPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NewText;
        private System.Windows.Forms.Button bChange;
        private System.Windows.Forms.Label PathText;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nudAutoSaveCustom;
        private System.Windows.Forms.CheckBox cbViber;
        private System.Windows.Forms.CheckBox cbWhatsApp;
        private System.Windows.Forms.CheckBox cbTelegram;
        private System.Windows.Forms.PictureBox picViber;
        private System.Windows.Forms.PictureBox picWhatsApp;
        private System.Windows.Forms.PictureBox picTelegram;
        private System.Windows.Forms.GroupBox gbEmailFeatures;
        private System.Windows.Forms.TextBox txtSOCKSIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbSOCKS5;
        private System.Windows.Forms.RadioButton rbEmailStandart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label ReceiverEmailText;
        private System.Windows.Forms.TextBox txtReceiverEmail;
        private System.Windows.Forms.GroupBox gbSender;
        private System.Windows.Forms.MaskedTextBox txtSenderPassword;
        private System.Windows.Forms.Label SenderEmailPasswordText;
        private System.Windows.Forms.Label SenderEmailText;
        private System.Windows.Forms.TextBox txtSenderEmail;
        private System.Windows.Forms.CheckBox cbemail;
        private System.Windows.Forms.CheckBox cbCryptoExport;
        private System.Windows.Forms.RadioButton rbAutoSaveCustom;
        private System.Windows.Forms.RadioButton rbAutoSave60;
        private System.Windows.Forms.RadioButton rbAutoSave10;
        private System.Windows.Forms.RadioButton rbAutoSave30;
        private System.Windows.Forms.RadioButton rbAutoSave5;
        private System.Windows.Forms.MaskedTextBox txtpasswd;
        private System.Windows.Forms.CheckBox cbSourceControl;
        private System.Windows.Forms.CheckBox cbAutoSave;
        private System.Windows.Forms.CheckBox cbSNS;
        private System.Windows.Forms.CheckBox cbAutoSend;
        private System.Windows.Forms.CheckBox cbPasswd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tAutoCustom;
        private System.Windows.Forms.NumericUpDown txtSOCKSPort;
    }
}
