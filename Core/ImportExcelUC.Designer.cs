namespace WarehouseAccounting.Core
{
    partial class ImportExcelUC
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
            this.rbImportSelected = new System.Windows.Forms.RadioButton();
            this.tlpImport = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWorkspace = new System.Windows.Forms.Panel();
            this.gb = new System.Windows.Forms.GroupBox();
            this.cbBarcode = new System.Windows.Forms.CheckBox();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbCode = new System.Windows.Forms.CheckBox();
            this.rbGenNumber = new System.Windows.Forms.RadioButton();
            this.pnlWorkspace2 = new System.Windows.Forms.Panel();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.tlpImport.SuspendLayout();
            this.pnlWorkspace.SuspendLayout();
            this.gb.SuspendLayout();
            this.pnlWorkspace2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.SuspendLayout();
            // 
            // rbImportSelected
            // 
            this.rbImportSelected.AutoSize = true;
            this.rbImportSelected.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rbImportSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbImportSelected.Location = new System.Drawing.Point(9, 39);
            this.rbImportSelected.Name = "rbImportSelected";
            this.rbImportSelected.Size = new System.Drawing.Size(232, 20);
            this.rbImportSelected.TabIndex = 26;
            this.rbImportSelected.Text = "Использовать выбранные коды";
            this.rbImportSelected.UseVisualStyleBackColor = true;
            this.rbImportSelected.CheckedChanged += new System.EventHandler(this.RbUseSelected_CheckedChanged);
            // 
            // tlpImport
            // 
            this.tlpImport.ColumnCount = 1;
            this.tlpImport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpImport.Controls.Add(this.pnlWorkspace, 0, 0);
            this.tlpImport.Controls.Add(this.pnlWorkspace2, 0, 1);
            this.tlpImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImport.Location = new System.Drawing.Point(0, 0);
            this.tlpImport.Name = "tlpImport";
            this.tlpImport.RowCount = 2;
            this.tlpImport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpImport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpImport.Size = new System.Drawing.Size(738, 404);
            this.tlpImport.TabIndex = 2;
            // 
            // pnlWorkspace
            // 
            this.pnlWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlWorkspace.Controls.Add(this.rbImportSelected);
            this.pnlWorkspace.Controls.Add(this.gb);
            this.pnlWorkspace.Controls.Add(this.rbGenNumber);
            this.pnlWorkspace.Location = new System.Drawing.Point(3, 3);
            this.pnlWorkspace.Name = "pnlWorkspace";
            this.pnlWorkspace.Size = new System.Drawing.Size(732, 61);
            this.pnlWorkspace.TabIndex = 0;
            // 
            // gb
            // 
            this.gb.Controls.Add(this.cbBarcode);
            this.gb.Controls.Add(this.cbPrice);
            this.gb.Controls.Add(this.cbNumber);
            this.gb.Controls.Add(this.cbName);
            this.gb.Controls.Add(this.cbCode);
            this.gb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gb.Location = new System.Drawing.Point(248, 1);
            this.gb.Name = "gb";
            this.gb.Size = new System.Drawing.Size(481, 67);
            this.gb.TabIndex = 20;
            this.gb.TabStop = false;
            this.gb.Text = "Выбрать столбцы для импорта";
            // 
            // cbBarcode
            // 
            this.cbBarcode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBarcode.AutoSize = true;
            this.cbBarcode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbBarcode.Location = new System.Drawing.Point(295, 31);
            this.cbBarcode.Name = "cbBarcode";
            this.cbBarcode.Size = new System.Drawing.Size(92, 27);
            this.cbBarcode.TabIndex = 24;
            this.cbBarcode.Text = "Штрих-коды";
            this.cbBarcode.UseVisualStyleBackColor = true;
            // 
            // cbPrice
            // 
            this.cbPrice.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbPrice.AutoSize = true;
            this.cbPrice.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrice.Location = new System.Drawing.Point(238, 31);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(51, 27);
            this.cbPrice.TabIndex = 23;
            this.cbPrice.Text = "Цены";
            this.cbPrice.UseVisualStyleBackColor = true;
            // 
            // cbNumber
            // 
            this.cbNumber.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbNumber.AutoSize = true;
            this.cbNumber.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumber.Location = new System.Drawing.Point(144, 31);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(88, 27);
            this.cbNumber.TabIndex = 22;
            this.cbNumber.Text = "Количество";
            this.cbNumber.UseVisualStyleBackColor = true;
            // 
            // cbName
            // 
            this.cbName.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbName.AutoSize = true;
            this.cbName.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbName.Location = new System.Drawing.Point(63, 31);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(75, 27);
            this.cbName.TabIndex = 21;
            this.cbName.Text = "Название";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // cbCode
            // 
            this.cbCode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCode.AutoSize = true;
            this.cbCode.BackColor = System.Drawing.SystemColors.Control;
            this.cbCode.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cbCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbCode.Location = new System.Drawing.Point(7, 31);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(50, 27);
            this.cbCode.TabIndex = 20;
            this.cbCode.Text = "Коды";
            this.cbCode.UseVisualStyleBackColor = false;
            // 
            // rbGenNumber
            // 
            this.rbGenNumber.AutoSize = true;
            this.rbGenNumber.Checked = true;
            this.rbGenNumber.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.rbGenNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbGenNumber.Location = new System.Drawing.Point(9, 13);
            this.rbGenNumber.Name = "rbGenNumber";
            this.rbGenNumber.Size = new System.Drawing.Size(189, 20);
            this.rbGenNumber.TabIndex = 25;
            this.rbGenNumber.TabStop = true;
            this.rbGenNumber.Text = "Создать коды продуктов";
            this.rbGenNumber.UseVisualStyleBackColor = true;
            this.rbGenNumber.CheckedChanged += new System.EventHandler(this.RbGenNumber_CheckedChanged);
            // 
            // pnlWorkspace2
            // 
            this.pnlWorkspace2.Controls.Add(this.dgvImport);
            this.pnlWorkspace2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkspace2.Location = new System.Drawing.Point(3, 70);
            this.pnlWorkspace2.Name = "pnlWorkspace2";
            this.pnlWorkspace2.Size = new System.Drawing.Size(732, 331);
            this.pnlWorkspace2.TabIndex = 1;
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_d_DoWork);
            // 
            // dgvImport
            // 
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport.Location = new System.Drawing.Point(0, 0);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.Size = new System.Drawing.Size(732, 331);
            this.dgvImport.TabIndex = 0;
            // 
            // ImportExcelUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlpImport);
            this.Name = "ImportExcelUC";
            this.Size = new System.Drawing.Size(738, 404);
            this.Load += new System.EventHandler(this.ImportExcelUC_Load);
            this.tlpImport.ResumeLayout(false);
            this.pnlWorkspace.ResumeLayout(false);
            this.pnlWorkspace.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.pnlWorkspace2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbImportSelected;
        private System.Windows.Forms.TableLayoutPanel tlpImport;
        private System.Windows.Forms.Panel pnlWorkspace;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.CheckBox cbBarcode;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.CheckBox cbNumber;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbCode;
        private System.Windows.Forms.RadioButton rbGenNumber;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Panel pnlWorkspace2;
        private System.Windows.Forms.DataGridView dgvImport;
    }
}
