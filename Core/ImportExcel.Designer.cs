namespace WarehouseAccounting.Core
{
    partial class ImportExcel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvImport = new System.Windows.Forms.DataGridView();
            this.tlpImport = new System.Windows.Forms.TableLayoutPanel();
            this.pnlWorkspace = new System.Windows.Forms.Panel();
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.gb = new System.Windows.Forms.GroupBox();
            this.cbCode = new System.Windows.Forms.CheckBox();
            this.cbName = new System.Windows.Forms.CheckBox();
            this.cbNumber = new System.Windows.Forms.CheckBox();
            this.cbBarcode = new System.Windows.Forms.CheckBox();
            this.cbPrice = new System.Windows.Forms.CheckBox();
            this.rbGenNumber = new System.Windows.Forms.RadioButton();
            this.rbImportSelected = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).BeginInit();
            this.tlpImport.SuspendLayout();
            this.pnlWorkspace.SuspendLayout();
            this.gb.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvImport
            // 
            this.dgvImport.BackgroundColor = System.Drawing.Color.White;
            this.dgvImport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImport.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvImport.Location = new System.Drawing.Point(3, 77);
            this.dgvImport.Name = "dgvImport";
            this.dgvImport.Size = new System.Drawing.Size(794, 370);
            this.dgvImport.TabIndex = 0;
            // 
            // tlpImport
            // 
            this.tlpImport.ColumnCount = 1;
            this.tlpImport.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpImport.Controls.Add(this.pnlWorkspace, 0, 0);
            this.tlpImport.Controls.Add(this.dgvImport, 0, 1);
            this.tlpImport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpImport.Location = new System.Drawing.Point(0, 0);
            this.tlpImport.Name = "tlpImport";
            this.tlpImport.RowCount = 2;
            this.tlpImport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpImport.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.tlpImport.Size = new System.Drawing.Size(800, 450);
            this.tlpImport.TabIndex = 1;
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
            this.pnlWorkspace.Size = new System.Drawing.Size(794, 68);
            this.pnlWorkspace.TabIndex = 0;
            this.pnlWorkspace.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlWorkspace_Paint);
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
            this.gb.Size = new System.Drawing.Size(549, 67);
            this.gb.TabIndex = 20;
            this.gb.TabStop = false;
            this.gb.Text = "Выбрать столбцы для импорта";
            // 
            // cbCode
            // 
            this.cbCode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbCode.AutoSize = true;
            this.cbCode.BackColor = System.Drawing.SystemColors.Control;
            this.cbCode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbCode.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cbCode.Location = new System.Drawing.Point(7, 31);
            this.cbCode.Name = "cbCode";
            this.cbCode.Size = new System.Drawing.Size(50, 27);
            this.cbCode.TabIndex = 20;
            this.cbCode.Text = "Коды";
            this.cbCode.UseVisualStyleBackColor = false;
            // 
            // cbName
            // 
            this.cbName.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbName.AutoSize = true;
            this.cbName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbName.Location = new System.Drawing.Point(63, 31);
            this.cbName.Name = "cbName";
            this.cbName.Size = new System.Drawing.Size(75, 27);
            this.cbName.TabIndex = 21;
            this.cbName.Text = "Название";
            this.cbName.UseVisualStyleBackColor = true;
            // 
            // cbNumber
            // 
            this.cbNumber.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbNumber.AutoSize = true;
            this.cbNumber.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbNumber.Location = new System.Drawing.Point(144, 31);
            this.cbNumber.Name = "cbNumber";
            this.cbNumber.Size = new System.Drawing.Size(88, 27);
            this.cbNumber.TabIndex = 22;
            this.cbNumber.Text = "Количество";
            this.cbNumber.UseVisualStyleBackColor = true;
            // 
            // cbBarcode
            // 
            this.cbBarcode.Appearance = System.Windows.Forms.Appearance.Button;
            this.cbBarcode.AutoSize = true;
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
            this.cbPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbPrice.Location = new System.Drawing.Point(238, 31);
            this.cbPrice.Name = "cbPrice";
            this.cbPrice.Size = new System.Drawing.Size(51, 27);
            this.cbPrice.TabIndex = 23;
            this.cbPrice.Text = "Цены";
            this.cbPrice.UseVisualStyleBackColor = true;
            // 
            // rbGenNumber
            // 
            this.rbGenNumber.AutoSize = true;
            this.rbGenNumber.Checked = true;
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
            // rbImportSelected
            // 
            this.rbImportSelected.AutoSize = true;
            this.rbImportSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbImportSelected.Location = new System.Drawing.Point(9, 39);
            this.rbImportSelected.Name = "rbImportSelected";
            this.rbImportSelected.Size = new System.Drawing.Size(232, 20);
            this.rbImportSelected.TabIndex = 26;
            this.rbImportSelected.Text = "Использовать выбранные коды";
            this.rbImportSelected.UseVisualStyleBackColor = true;
            this.rbImportSelected.CheckedChanged += new System.EventHandler(this.RbUseSelected_CheckedChanged);
            // 
            // ImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tlpImport);
            this.Name = "ImportExcel";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Импорт таблицы товаров";
            ((System.ComponentModel.ISupportInitialize)(this.dgvImport)).EndInit();
            this.tlpImport.ResumeLayout(false);
            this.pnlWorkspace.ResumeLayout(false);
            this.pnlWorkspace.PerformLayout();
            this.gb.ResumeLayout(false);
            this.gb.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvImport;
        private System.Windows.Forms.TableLayoutPanel tlpImport;
        private System.Windows.Forms.Panel pnlWorkspace;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.GroupBox gb;
        private System.Windows.Forms.RadioButton rbImportSelected;
        private System.Windows.Forms.CheckBox cbBarcode;
        private System.Windows.Forms.CheckBox cbPrice;
        private System.Windows.Forms.CheckBox cbNumber;
        private System.Windows.Forms.CheckBox cbName;
        private System.Windows.Forms.CheckBox cbCode;
        private System.Windows.Forms.RadioButton rbGenNumber;
    }
}