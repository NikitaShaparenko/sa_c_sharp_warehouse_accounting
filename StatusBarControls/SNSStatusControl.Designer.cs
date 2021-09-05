namespace WarehouseAccounting.StatusBarControls
{
    partial class SNSStatusControl
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
            this.TelegramText = new System.Windows.Forms.Label();
            this.WhatsAppText = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.Label();
            this.ViberText = new System.Windows.Forms.Label();
            this.SMSText = new System.Windows.Forms.Label();
            this.pb = new System.Windows.Forms.ProgressBar();
            this.txtpb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.picTelegramOK = new System.Windows.Forms.PictureBox();
            this.picSMS = new System.Windows.Forms.PictureBox();
            this.picViber = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picWhatsApp = new System.Windows.Forms.PictureBox();
            this.picTelegram = new System.Windows.Forms.PictureBox();
            this.picViberError = new System.Windows.Forms.PictureBox();
            this.picViberOK = new System.Windows.Forms.PictureBox();
            this.picWhatsAppError = new System.Windows.Forms.PictureBox();
            this.picWhatsAppOK = new System.Windows.Forms.PictureBox();
            this.picTelegramError = new System.Windows.Forms.PictureBox();
            this.picSMSError = new System.Windows.Forms.PictureBox();
            this.picSMSOK = new System.Windows.Forms.PictureBox();
            this.picEmailOK = new System.Windows.Forms.PictureBox();
            this.picEmailError = new System.Windows.Forms.PictureBox();
            this.bwTelegramSend = new System.ComponentModel.BackgroundWorker();
            this.bwWhatsAppSend = new System.ComponentModel.BackgroundWorker();
            this.bwViberSend = new System.ComponentModel.BackgroundWorker();
            this.bwEmailSend = new System.ComponentModel.BackgroundWorker();
            this.bwSMSSend = new System.ComponentModel.BackgroundWorker();
            this.buttonZ_SMS = new WarehouseAccounting.ButtonZ();
            this.buttonZ_Email = new WarehouseAccounting.ButtonZ();
            this.buttonZ_Viber = new WarehouseAccounting.ButtonZ();
            this.buttonZ_WhatsApp = new WarehouseAccounting.ButtonZ();
            this.buttonZ_Telegram = new WarehouseAccounting.ButtonZ();
            this.tProgressBar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picTelegramOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsApp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViberError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViberOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsAppError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsAppOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegramError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSMSError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSMSOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailOK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailError)).BeginInit();
            this.SuspendLayout();
            // 
            // TelegramText
            // 
            this.TelegramText.AutoSize = true;
            this.TelegramText.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TelegramText.ForeColor = System.Drawing.Color.White;
            this.TelegramText.Location = new System.Drawing.Point(44, 50);
            this.TelegramText.Name = "TelegramText";
            this.TelegramText.Size = new System.Drawing.Size(72, 18);
            this.TelegramText.TabIndex = 0;
            this.TelegramText.Text = "Telegram";
            this.TelegramText.Click += new System.EventHandler(this.TelegramText_Click);
            // 
            // WhatsAppText
            // 
            this.WhatsAppText.AutoSize = true;
            this.WhatsAppText.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhatsAppText.ForeColor = System.Drawing.Color.White;
            this.WhatsAppText.Location = new System.Drawing.Point(164, 48);
            this.WhatsAppText.Name = "WhatsAppText";
            this.WhatsAppText.Size = new System.Drawing.Size(81, 18);
            this.WhatsAppText.TabIndex = 2;
            this.WhatsAppText.Text = "WhatsApp";
            this.WhatsAppText.Click += new System.EventHandler(this.WhatsAppText_Click);
            // 
            // EmailText
            // 
            this.EmailText.AutoSize = true;
            this.EmailText.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EmailText.ForeColor = System.Drawing.Color.White;
            this.EmailText.Location = new System.Drawing.Point(398, 50);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(48, 18);
            this.EmailText.TabIndex = 4;
            this.EmailText.Text = "Email";
            this.EmailText.Click += new System.EventHandler(this.EmailText_Click);
            // 
            // ViberText
            // 
            this.ViberText.AutoSize = true;
            this.ViberText.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViberText.ForeColor = System.Drawing.Color.White;
            this.ViberText.Location = new System.Drawing.Point(297, 50);
            this.ViberText.Name = "ViberText";
            this.ViberText.Size = new System.Drawing.Size(46, 18);
            this.ViberText.TabIndex = 4;
            this.ViberText.Text = "Viber";
            this.ViberText.Click += new System.EventHandler(this.ViberText_Click);
            // 
            // SMSText
            // 
            this.SMSText.AutoSize = true;
            this.SMSText.Font = new System.Drawing.Font("Helvetica", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMSText.ForeColor = System.Drawing.Color.White;
            this.SMSText.Location = new System.Drawing.Point(501, 50);
            this.SMSText.Name = "SMSText";
            this.SMSText.Size = new System.Drawing.Size(43, 18);
            this.SMSText.TabIndex = 6;
            this.SMSText.Text = "SMS";
            this.SMSText.Click += new System.EventHandler(this.SMSText_Click);
            // 
            // pb
            // 
            this.pb.Location = new System.Drawing.Point(16, 156);
            this.pb.Name = "pb";
            this.pb.Size = new System.Drawing.Size(567, 30);
            this.pb.TabIndex = 8;
            // 
            // txtpb
            // 
            this.txtpb.AutoSize = true;
            this.txtpb.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txtpb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpb.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtpb.Location = new System.Drawing.Point(282, 160);
            this.txtpb.Name = "txtpb";
            this.txtpb.Size = new System.Drawing.Size(33, 21);
            this.txtpb.TabIndex = 11;
            this.txtpb.Text = "0%";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 37);
            this.label1.TabIndex = 20;
            this.label1.Text = "Отправка автоматических уведомлений";
            // 
            // picTelegramOK
            // 
            this.picTelegramOK.BackColor = System.Drawing.Color.Transparent;
            this.picTelegramOK.Image = global::WarehouseAccounting.Properties.Resources.ok3_41px;
            this.picTelegramOK.Location = new System.Drawing.Point(46, 96);
            this.picTelegramOK.Name = "picTelegramOK";
            this.picTelegramOK.Size = new System.Drawing.Size(41, 41);
            this.picTelegramOK.TabIndex = 21;
            this.picTelegramOK.TabStop = false;
            // 
            // picSMS
            // 
            this.picSMS.BackColor = System.Drawing.Color.White;
            this.picSMS.Image = global::WarehouseAccounting.Properties.Resources.sms50px;
            this.picSMS.Location = new System.Drawing.Point(494, 71);
            this.picSMS.Name = "picSMS";
            this.picSMS.Size = new System.Drawing.Size(50, 50);
            this.picSMS.TabIndex = 7;
            this.picSMS.TabStop = false;
            this.picSMS.Click += new System.EventHandler(this.PicSMS_Click);
            // 
            // picViber
            // 
            this.picViber.BackColor = System.Drawing.Color.White;
            this.picViber.Image = global::WarehouseAccounting.Properties.Resources.Viber50px;
            this.picViber.Location = new System.Drawing.Point(295, 71);
            this.picViber.Name = "picViber";
            this.picViber.Size = new System.Drawing.Size(50, 50);
            this.picViber.TabIndex = 5;
            this.picViber.TabStop = false;
            this.picViber.Click += new System.EventHandler(this.PicViber_Click);
            // 
            // picEmail
            // 
            this.picEmail.BackColor = System.Drawing.Color.White;
            this.picEmail.Image = global::WarehouseAccounting.Properties.Resources.email50px;
            this.picEmail.Location = new System.Drawing.Point(394, 71);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(50, 50);
            this.picEmail.TabIndex = 5;
            this.picEmail.TabStop = false;
            this.picEmail.Click += new System.EventHandler(this.PictureBox2_Click);
            // 
            // picWhatsApp
            // 
            this.picWhatsApp.BackColor = System.Drawing.Color.White;
            this.picWhatsApp.Image = global::WarehouseAccounting.Properties.Resources.WhatsApp50px;
            this.picWhatsApp.Location = new System.Drawing.Point(179, 71);
            this.picWhatsApp.Name = "picWhatsApp";
            this.picWhatsApp.Size = new System.Drawing.Size(50, 50);
            this.picWhatsApp.TabIndex = 3;
            this.picWhatsApp.TabStop = false;
            this.picWhatsApp.Click += new System.EventHandler(this.PicWhatsApp_Click);
            // 
            // picTelegram
            // 
            this.picTelegram.BackColor = System.Drawing.Color.White;
            this.picTelegram.Image = global::WarehouseAccounting.Properties.Resources.Telegram_Messenger50px;
            this.picTelegram.Location = new System.Drawing.Point(66, 71);
            this.picTelegram.Name = "picTelegram";
            this.picTelegram.Size = new System.Drawing.Size(50, 50);
            this.picTelegram.TabIndex = 1;
            this.picTelegram.TabStop = false;
            this.picTelegram.Click += new System.EventHandler(this.PicTelegram_Click);
            // 
            // picViberError
            // 
            this.picViberError.BackColor = System.Drawing.Color.Transparent;
            this.picViberError.Image = global::WarehouseAccounting.Properties.Resources.no41px;
            this.picViberError.Location = new System.Drawing.Point(322, 96);
            this.picViberError.Name = "picViberError";
            this.picViberError.Size = new System.Drawing.Size(41, 41);
            this.picViberError.TabIndex = 22;
            this.picViberError.TabStop = false;
            // 
            // picViberOK
            // 
            this.picViberOK.BackColor = System.Drawing.Color.Transparent;
            this.picViberOK.Image = global::WarehouseAccounting.Properties.Resources.ok3_41px;
            this.picViberOK.Location = new System.Drawing.Point(275, 96);
            this.picViberOK.Name = "picViberOK";
            this.picViberOK.Size = new System.Drawing.Size(41, 41);
            this.picViberOK.TabIndex = 23;
            this.picViberOK.TabStop = false;
            // 
            // picWhatsAppError
            // 
            this.picWhatsAppError.BackColor = System.Drawing.Color.Transparent;
            this.picWhatsAppError.Image = global::WarehouseAccounting.Properties.Resources.no41px;
            this.picWhatsAppError.Location = new System.Drawing.Point(209, 96);
            this.picWhatsAppError.Name = "picWhatsAppError";
            this.picWhatsAppError.Size = new System.Drawing.Size(41, 41);
            this.picWhatsAppError.TabIndex = 24;
            this.picWhatsAppError.TabStop = false;
            // 
            // picWhatsAppOK
            // 
            this.picWhatsAppOK.BackColor = System.Drawing.Color.Transparent;
            this.picWhatsAppOK.Image = global::WarehouseAccounting.Properties.Resources.ok3_41px;
            this.picWhatsAppOK.Location = new System.Drawing.Point(159, 96);
            this.picWhatsAppOK.Name = "picWhatsAppOK";
            this.picWhatsAppOK.Size = new System.Drawing.Size(41, 41);
            this.picWhatsAppOK.TabIndex = 25;
            this.picWhatsAppOK.TabStop = false;
            // 
            // picTelegramError
            // 
            this.picTelegramError.BackColor = System.Drawing.Color.Transparent;
            this.picTelegramError.Image = global::WarehouseAccounting.Properties.Resources.no41px1;
            this.picTelegramError.Location = new System.Drawing.Point(96, 96);
            this.picTelegramError.Name = "picTelegramError";
            this.picTelegramError.Size = new System.Drawing.Size(41, 41);
            this.picTelegramError.TabIndex = 26;
            this.picTelegramError.TabStop = false;
            // 
            // picSMSError
            // 
            this.picSMSError.BackColor = System.Drawing.Color.Transparent;
            this.picSMSError.Image = global::WarehouseAccounting.Properties.Resources.no41px;
            this.picSMSError.Location = new System.Drawing.Point(524, 96);
            this.picSMSError.Name = "picSMSError";
            this.picSMSError.Size = new System.Drawing.Size(41, 41);
            this.picSMSError.TabIndex = 27;
            this.picSMSError.TabStop = false;
            // 
            // picSMSOK
            // 
            this.picSMSOK.BackColor = System.Drawing.Color.Transparent;
            this.picSMSOK.Image = global::WarehouseAccounting.Properties.Resources.ok3_41px;
            this.picSMSOK.Location = new System.Drawing.Point(474, 96);
            this.picSMSOK.Name = "picSMSOK";
            this.picSMSOK.Size = new System.Drawing.Size(41, 41);
            this.picSMSOK.TabIndex = 28;
            this.picSMSOK.TabStop = false;
            // 
            // picEmailOK
            // 
            this.picEmailOK.BackColor = System.Drawing.Color.Transparent;
            this.picEmailOK.Image = global::WarehouseAccounting.Properties.Resources.ok3_41px;
            this.picEmailOK.Location = new System.Drawing.Point(374, 96);
            this.picEmailOK.Name = "picEmailOK";
            this.picEmailOK.Size = new System.Drawing.Size(41, 41);
            this.picEmailOK.TabIndex = 29;
            this.picEmailOK.TabStop = false;
            // 
            // picEmailError
            // 
            this.picEmailError.BackColor = System.Drawing.Color.Transparent;
            this.picEmailError.Image = global::WarehouseAccounting.Properties.Resources.no41px;
            this.picEmailError.Location = new System.Drawing.Point(424, 96);
            this.picEmailError.Name = "picEmailError";
            this.picEmailError.Size = new System.Drawing.Size(41, 41);
            this.picEmailError.TabIndex = 30;
            this.picEmailError.TabStop = false;
            // 
            // bwTelegramSend
            // 
            this.bwTelegramSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwTelegramSend_DoWork);
            // 
            // bwWhatsAppSend
            // 
            this.bwWhatsAppSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwWhatsAppSend_DoWork);
            // 
            // bwViberSend
            // 
            this.bwViberSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwViberSend_DoWork);
            // 
            // bwEmailSend
            // 
            this.bwEmailSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwEmailSend_DoWork);
            // 
            // bwSMSSend
            // 
            this.bwSMSSend.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwSMSSend_DoWork);
            // 
            // buttonZ_SMS
            // 
            this.buttonZ_SMS.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ_SMS.DisplayText = "X";
            this.buttonZ_SMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ_SMS.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ_SMS.ForeColor = System.Drawing.Color.White;
            this.buttonZ_SMS.Location = new System.Drawing.Point(550, 48);
            this.buttonZ_SMS.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_SMS.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_SMS.Name = "buttonZ_SMS";
            this.buttonZ_SMS.Size = new System.Drawing.Size(27, 23);
            this.buttonZ_SMS.TabIndex = 31;
            this.buttonZ_SMS.Text = "X";
            this.buttonZ_SMS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonZ_SMS.TextLocation_X = 6;
            this.buttonZ_SMS.TextLocation_Y = 0;
            this.buttonZ_SMS.UseVisualStyleBackColor = true;
            this.buttonZ_SMS.Click += new System.EventHandler(this.ButtonZ_SMS_Click);
            // 
            // buttonZ_Email
            // 
            this.buttonZ_Email.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ_Email.DisplayText = "X";
            this.buttonZ_Email.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ_Email.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ_Email.ForeColor = System.Drawing.Color.White;
            this.buttonZ_Email.Location = new System.Drawing.Point(452, 48);
            this.buttonZ_Email.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_Email.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_Email.Name = "buttonZ_Email";
            this.buttonZ_Email.Size = new System.Drawing.Size(27, 23);
            this.buttonZ_Email.TabIndex = 32;
            this.buttonZ_Email.Text = "X";
            this.buttonZ_Email.TextLocation_X = 6;
            this.buttonZ_Email.TextLocation_Y = 0;
            this.buttonZ_Email.UseVisualStyleBackColor = true;
            this.buttonZ_Email.Click += new System.EventHandler(this.ButtonZ_Email_Click);
            // 
            // buttonZ_Viber
            // 
            this.buttonZ_Viber.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ_Viber.DisplayText = "X";
            this.buttonZ_Viber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ_Viber.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ_Viber.ForeColor = System.Drawing.Color.White;
            this.buttonZ_Viber.Location = new System.Drawing.Point(347, 48);
            this.buttonZ_Viber.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_Viber.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_Viber.Name = "buttonZ_Viber";
            this.buttonZ_Viber.Size = new System.Drawing.Size(27, 23);
            this.buttonZ_Viber.TabIndex = 33;
            this.buttonZ_Viber.Text = "X";
            this.buttonZ_Viber.TextLocation_X = 6;
            this.buttonZ_Viber.TextLocation_Y = 0;
            this.buttonZ_Viber.UseVisualStyleBackColor = true;
            this.buttonZ_Viber.Click += new System.EventHandler(this.ButtonZ_Viber_Click);
            // 
            // buttonZ_WhatsApp
            // 
            this.buttonZ_WhatsApp.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ_WhatsApp.DisplayText = "X";
            this.buttonZ_WhatsApp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ_WhatsApp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ_WhatsApp.ForeColor = System.Drawing.Color.White;
            this.buttonZ_WhatsApp.Location = new System.Drawing.Point(243, 48);
            this.buttonZ_WhatsApp.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_WhatsApp.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_WhatsApp.Name = "buttonZ_WhatsApp";
            this.buttonZ_WhatsApp.Size = new System.Drawing.Size(27, 23);
            this.buttonZ_WhatsApp.TabIndex = 34;
            this.buttonZ_WhatsApp.Text = "X";
            this.buttonZ_WhatsApp.TextLocation_X = 6;
            this.buttonZ_WhatsApp.TextLocation_Y = 0;
            this.buttonZ_WhatsApp.UseVisualStyleBackColor = true;
            this.buttonZ_WhatsApp.Click += new System.EventHandler(this.ButtonZ_WhatsApp_Click);
            // 
            // buttonZ_Telegram
            // 
            this.buttonZ_Telegram.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ_Telegram.DisplayText = "X";
            this.buttonZ_Telegram.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ_Telegram.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ_Telegram.ForeColor = System.Drawing.Color.White;
            this.buttonZ_Telegram.Location = new System.Drawing.Point(122, 48);
            this.buttonZ_Telegram.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_Telegram.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ_Telegram.Name = "buttonZ_Telegram";
            this.buttonZ_Telegram.Size = new System.Drawing.Size(27, 23);
            this.buttonZ_Telegram.TabIndex = 35;
            this.buttonZ_Telegram.Text = "X";
            this.buttonZ_Telegram.TextLocation_X = 6;
            this.buttonZ_Telegram.TextLocation_Y = 0;
            this.buttonZ_Telegram.UseVisualStyleBackColor = true;
            this.buttonZ_Telegram.Click += new System.EventHandler(this.ButtonZ_Telegram_Click);
            // 
            // tProgressBar
            // 
            this.tProgressBar.Enabled = true;
            this.tProgressBar.Tick += new System.EventHandler(this.TProgressBar_Tick);
            // 
            // SNSStatusControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkCyan;
            this.Controls.Add(this.buttonZ_Telegram);
            this.Controls.Add(this.buttonZ_WhatsApp);
            this.Controls.Add(this.buttonZ_Viber);
            this.Controls.Add(this.buttonZ_Email);
            this.Controls.Add(this.buttonZ_SMS);
            this.Controls.Add(this.picEmailError);
            this.Controls.Add(this.picEmailOK);
            this.Controls.Add(this.picSMSOK);
            this.Controls.Add(this.picSMSError);
            this.Controls.Add(this.picTelegramError);
            this.Controls.Add(this.picWhatsAppOK);
            this.Controls.Add(this.picWhatsAppError);
            this.Controls.Add(this.picViberOK);
            this.Controls.Add(this.picViberError);
            this.Controls.Add(this.picTelegramOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpb);
            this.Controls.Add(this.pb);
            this.Controls.Add(this.picSMS);
            this.Controls.Add(this.SMSText);
            this.Controls.Add(this.picViber);
            this.Controls.Add(this.ViberText);
            this.Controls.Add(this.picEmail);
            this.Controls.Add(this.EmailText);
            this.Controls.Add(this.picWhatsApp);
            this.Controls.Add(this.WhatsAppText);
            this.Controls.Add(this.picTelegram);
            this.Controls.Add(this.TelegramText);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SNSStatusControl";
            this.Size = new System.Drawing.Size(600, 200);
            this.Load += new System.EventHandler(this.SNSStatusControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picTelegramOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsApp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViberError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picViberOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsAppError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhatsAppOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTelegramError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSMSError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSMSOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailOK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmailError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TelegramText;
        private System.Windows.Forms.PictureBox picTelegram;
        private System.Windows.Forms.PictureBox picWhatsApp;
        private System.Windows.Forms.Label WhatsAppText;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.Label EmailText;
        private System.Windows.Forms.Label ViberText;
        private System.Windows.Forms.PictureBox picViber;
        private System.Windows.Forms.PictureBox picSMS;
        private System.Windows.Forms.Label SMSText;
        private System.Windows.Forms.ProgressBar pb;
        private System.Windows.Forms.Label txtpb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picTelegramOK;
        private System.Windows.Forms.PictureBox picViberError;
        private System.Windows.Forms.PictureBox picViberOK;
        private System.Windows.Forms.PictureBox picWhatsAppError;
        private System.Windows.Forms.PictureBox picWhatsAppOK;
        private System.Windows.Forms.PictureBox picTelegramError;
        private System.Windows.Forms.PictureBox picSMSError;
        private System.Windows.Forms.PictureBox picSMSOK;
        private System.Windows.Forms.PictureBox picEmailOK;
        private System.Windows.Forms.PictureBox picEmailError;
        private System.ComponentModel.BackgroundWorker bwTelegramSend;
        private System.ComponentModel.BackgroundWorker bwWhatsAppSend;
        private System.ComponentModel.BackgroundWorker bwViberSend;
        private System.ComponentModel.BackgroundWorker bwEmailSend;
        private System.ComponentModel.BackgroundWorker bwSMSSend;
        private ButtonZ buttonZ_SMS;
        private ButtonZ buttonZ_Email;
        private ButtonZ buttonZ_Viber;
        private ButtonZ buttonZ_WhatsApp;
        private ButtonZ buttonZ_Telegram;
        private System.Windows.Forms.Timer tProgressBar;
    }
}
