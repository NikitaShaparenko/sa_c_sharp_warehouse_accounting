﻿namespace WarehouseAccounting
{
    partial class Import
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
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.picDrive = new System.Windows.Forms.PictureBox();
            this.pbComputer = new System.Windows.Forms.PictureBox();
            this.picOneDrive = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlImport = new System.Windows.Forms.Panel();
            this.optionButton4 = new WarehouseAccounting.OptionButton();
            this.optionButton3 = new WarehouseAccounting.OptionButton();
            this.optionButton2 = new WarehouseAccounting.OptionButton();
            this.optionButton1 = new WarehouseAccounting.OptionButton();
            ((System.ComponentModel.ISupportInitialize)(this.picDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOneDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.label3.Location = new System.Drawing.Point(49, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Источники импорта";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(325, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 232);
            this.panel1.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(44, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 45);
            this.label1.TabIndex = 14;
            this.label1.Text = "Импорт";
            // 
            // picDrive
            // 
            this.picDrive.Image = global::WarehouseAccounting.Properties.Resources.googledrive50px;
            this.picDrive.Location = new System.Drawing.Point(41, 260);
            this.picDrive.Name = "picDrive";
            this.picDrive.Size = new System.Drawing.Size(50, 50);
            this.picDrive.TabIndex = 24;
            this.picDrive.TabStop = false;
            // 
            // pbComputer
            // 
            this.pbComputer.Image = global::WarehouseAccounting.Properties.Resources.Computer50px;
            this.pbComputer.Location = new System.Drawing.Point(41, 209);
            this.pbComputer.Name = "pbComputer";
            this.pbComputer.Size = new System.Drawing.Size(50, 50);
            this.pbComputer.TabIndex = 23;
            this.pbComputer.TabStop = false;
            this.pbComputer.Click += new System.EventHandler(this.PbComputer_Click);
            // 
            // picOneDrive
            // 
            this.picOneDrive.Image = global::WarehouseAccounting.Properties.Resources.OneDrive50;
            this.picOneDrive.Location = new System.Drawing.Point(41, 158);
            this.picOneDrive.Name = "picOneDrive";
            this.picOneDrive.Size = new System.Drawing.Size(50, 50);
            this.picOneDrive.TabIndex = 22;
            this.picOneDrive.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WarehouseAccounting.Properties.Resources.RecentFiles50px;
            this.pictureBox1.Location = new System.Drawing.Point(41, 107);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 21;
            this.pictureBox1.TabStop = false;
            // 
            // pnlImport
            // 
            this.pnlImport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlImport.Location = new System.Drawing.Point(354, 92);
            this.pnlImport.Name = "pnlImport";
            this.pnlImport.Size = new System.Drawing.Size(434, 382);
            this.pnlImport.TabIndex = 26;
            // 
            // optionButton4
            // 
            this.optionButton4.BZBackColor = System.Drawing.Color.White;
            this.optionButton4.ChangeColorMouseHC = true;
            this.optionButton4.DisplayText = "Google Drive";
            this.optionButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton4.ForeColor = System.Drawing.Color.Black;
            this.optionButton4.Location = new System.Drawing.Point(54, 260);
            this.optionButton4.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton4.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton4.Name = "optionButton4";
            this.optionButton4.Size = new System.Drawing.Size(251, 45);
            this.optionButton4.TabIndex = 19;
            this.optionButton4.Text = "Google Drive";
            this.optionButton4.TextLocation_X = 45;
            this.optionButton4.TextLocation_Y = 10;
            this.optionButton4.UseVisualStyleBackColor = true;
            this.optionButton4.Click += new System.EventHandler(this.optionButton4_Click);
            // 
            // optionButton3
            // 
            this.optionButton3.BZBackColor = System.Drawing.Color.White;
            this.optionButton3.ChangeColorMouseHC = true;
            this.optionButton3.DisplayText = "Компьютер";
            this.optionButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton3.ForeColor = System.Drawing.Color.Black;
            this.optionButton3.Location = new System.Drawing.Point(54, 209);
            this.optionButton3.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton3.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton3.Name = "optionButton3";
            this.optionButton3.Size = new System.Drawing.Size(251, 45);
            this.optionButton3.TabIndex = 18;
            this.optionButton3.Text = "Компьютер";
            this.optionButton3.TextLocation_X = 45;
            this.optionButton3.TextLocation_Y = 10;
            this.optionButton3.UseVisualStyleBackColor = true;
            this.optionButton3.Click += new System.EventHandler(this.optionButton3_Click);
            // 
            // optionButton2
            // 
            this.optionButton2.BZBackColor = System.Drawing.Color.White;
            this.optionButton2.ChangeColorMouseHC = true;
            this.optionButton2.DisplayText = "One Drive";
            this.optionButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton2.ForeColor = System.Drawing.Color.Black;
            this.optionButton2.Location = new System.Drawing.Point(54, 158);
            this.optionButton2.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton2.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton2.Name = "optionButton2";
            this.optionButton2.Size = new System.Drawing.Size(251, 45);
            this.optionButton2.TabIndex = 17;
            this.optionButton2.Text = "One Drive";
            this.optionButton2.TextLocation_X = 45;
            this.optionButton2.TextLocation_Y = 10;
            this.optionButton2.UseVisualStyleBackColor = true;
            this.optionButton2.Click += new System.EventHandler(this.optionButton2_Click);
            // 
            // optionButton1
            // 
            this.optionButton1.BZBackColor = System.Drawing.Color.White;
            this.optionButton1.ChangeColorMouseHC = true;
            this.optionButton1.DisplayText = "Недавние файлы";
            this.optionButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.optionButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionButton1.ForeColor = System.Drawing.Color.Black;
            this.optionButton1.Location = new System.Drawing.Point(54, 107);
            this.optionButton1.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.optionButton1.Name = "optionButton1";
            this.optionButton1.Size = new System.Drawing.Size(251, 45);
            this.optionButton1.TabIndex = 15;
            this.optionButton1.Text = "Недавние файлы";
            this.optionButton1.TextLocation_X = 45;
            this.optionButton1.TextLocation_Y = 10;
            this.optionButton1.UseVisualStyleBackColor = true;
            this.optionButton1.Click += new System.EventHandler(this.optionButton1_Click);
            // 
            // Import
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlImport);
            this.Controls.Add(this.picDrive);
            this.Controls.Add(this.pbComputer);
            this.Controls.Add(this.picOneDrive);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.optionButton4);
            this.Controls.Add(this.optionButton3);
            this.Controls.Add(this.optionButton2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.optionButton1);
            this.Controls.Add(this.label1);
            this.Name = "Import";
            this.Size = new System.Drawing.Size(791, 488);
            this.Load += new System.EventHandler(this.Import_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOneDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private OptionButton optionButton4;
        private OptionButton optionButton3;
        private OptionButton optionButton2;
        private System.Windows.Forms.Panel panel1;
        private OptionButton optionButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picDrive;
        private System.Windows.Forms.PictureBox pbComputer;
        private System.Windows.Forms.PictureBox picOneDrive;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlImport;
    }
}
