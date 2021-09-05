namespace WarehouseAccounting
{
    partial class Account
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
            this.PathText = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.Label();
            this.NewText = new System.Windows.Forms.Label();
            this.txtAccount = new System.Windows.Forms.Label();
            this.txtLicenseStatus = new System.Windows.Forms.Label();
            this.LicenseCodeText = new System.Windows.Forms.Label();
            this.txtLicenseCode = new System.Windows.Forms.Label();
            this.gbLicense = new System.Windows.Forms.GroupBox();
            this.txtLicenseWhom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLicenseExpires = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbLicense.SuspendLayout();
            this.SuspendLayout();
            // 
            // PathText
            // 
            this.PathText.AutoSize = true;
            this.PathText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PathText.Location = new System.Drawing.Point(35, 83);
            this.PathText.Name = "PathText";
            this.PathText.Size = new System.Drawing.Size(107, 17);
            this.PathText.TabIndex = 12;
            this.PathText.Text = "Статус лицензии:";
            // 
            // NameText
            // 
            this.NameText.AutoSize = true;
            this.NameText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameText.Location = new System.Drawing.Point(20, 67);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(92, 17);
            this.NameText.TabIndex = 10;
            this.NameText.Text = "Имя аккаунта:";
            // 
            // NewText
            // 
            this.NewText.AutoSize = true;
            this.NewText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.NewText.Location = new System.Drawing.Point(15, 0);
            this.NewText.Name = "NewText";
            this.NewText.Size = new System.Drawing.Size(135, 45);
            this.NewText.TabIndex = 8;
            this.NewText.Text = "Аккаунт";
            // 
            // txtAccount
            // 
            this.txtAccount.AutoSize = true;
            this.txtAccount.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtAccount.Location = new System.Drawing.Point(150, 67);
            this.txtAccount.Name = "txtAccount";
            this.txtAccount.Size = new System.Drawing.Size(94, 17);
            this.txtAccount.TabIndex = 13;
            this.txtAccount.Text = "#имя аккаунта";
            // 
            // txtLicenseStatus
            // 
            this.txtLicenseStatus.AutoSize = true;
            this.txtLicenseStatus.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLicenseStatus.Location = new System.Drawing.Point(165, 83);
            this.txtLicenseStatus.Name = "txtLicenseStatus";
            this.txtLicenseStatus.Size = new System.Drawing.Size(94, 17);
            this.txtLicenseStatus.TabIndex = 14;
            this.txtLicenseStatus.Text = "#лицензионно";
            // 
            // LicenseCodeText
            // 
            this.LicenseCodeText.AutoSize = true;
            this.LicenseCodeText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LicenseCodeText.Location = new System.Drawing.Point(37, 57);
            this.LicenseCodeText.Name = "LicenseCodeText";
            this.LicenseCodeText.Size = new System.Drawing.Size(93, 17);
            this.LicenseCodeText.TabIndex = 15;
            this.LicenseCodeText.Text = "Код лицензии:";
            // 
            // txtLicenseCode
            // 
            this.txtLicenseCode.AutoSize = true;
            this.txtLicenseCode.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLicenseCode.Location = new System.Drawing.Point(167, 57);
            this.txtLicenseCode.Name = "txtLicenseCode";
            this.txtLicenseCode.Size = new System.Drawing.Size(96, 17);
            this.txtLicenseCode.TabIndex = 16;
            this.txtLicenseCode.Text = "#код лицензии";
            // 
            // gbLicense
            // 
            this.gbLicense.Controls.Add(this.txtLicenseExpires);
            this.gbLicense.Controls.Add(this.label3);
            this.gbLicense.Controls.Add(this.txtLicenseWhom);
            this.gbLicense.Controls.Add(this.label2);
            this.gbLicense.Controls.Add(this.txtLicenseStatus);
            this.gbLicense.Controls.Add(this.txtLicenseCode);
            this.gbLicense.Controls.Add(this.PathText);
            this.gbLicense.Controls.Add(this.LicenseCodeText);
            this.gbLicense.Location = new System.Drawing.Point(23, 118);
            this.gbLicense.Name = "gbLicense";
            this.gbLicense.Size = new System.Drawing.Size(491, 152);
            this.gbLicense.TabIndex = 17;
            this.gbLicense.TabStop = false;
            this.gbLicense.Text = "Информация о лицензии";
            // 
            // txtLicenseWhom
            // 
            this.txtLicenseWhom.AutoSize = true;
            this.txtLicenseWhom.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLicenseWhom.Location = new System.Drawing.Point(167, 31);
            this.txtLicenseWhom.Name = "txtLicenseWhom";
            this.txtLicenseWhom.Size = new System.Drawing.Size(92, 17);
            this.txtLicenseWhom.TabIndex = 18;
            this.txtLicenseWhom.Text = "#лицензиатор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(37, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Выдана:";
            // 
            // txtLicenseExpires
            // 
            this.txtLicenseExpires.AutoSize = true;
            this.txtLicenseExpires.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLicenseExpires.Location = new System.Drawing.Point(165, 109);
            this.txtLicenseExpires.Name = "txtLicenseExpires";
            this.txtLicenseExpires.Size = new System.Drawing.Size(102, 17);
            this.txtLicenseExpires.TabIndex = 20;
            this.txtLicenseExpires.Text = "#срок_действия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(35, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Срок действия:";
            // 
            // Account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.gbLicense);
            this.Controls.Add(this.txtAccount);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NewText);
            this.Name = "Account";
            this.Size = new System.Drawing.Size(664, 421);
            this.Load += new System.EventHandler(this.Account_Load);
            this.gbLicense.ResumeLayout(false);
            this.gbLicense.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PathText;
        private System.Windows.Forms.Label NameText;
        private System.Windows.Forms.Label NewText;
        private System.Windows.Forms.Label txtAccount;
        private System.Windows.Forms.Label txtLicenseStatus;
        private System.Windows.Forms.Label LicenseCodeText;
        private System.Windows.Forms.Label txtLicenseCode;
        private System.Windows.Forms.GroupBox gbLicense;
        private System.Windows.Forms.Label txtLicenseWhom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtLicenseExpires;
        private System.Windows.Forms.Label label3;
    }
}
