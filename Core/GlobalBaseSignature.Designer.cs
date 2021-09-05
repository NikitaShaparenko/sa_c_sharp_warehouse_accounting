namespace WarehouseAccounting.Core
{
    partial class GlobalBaseSignature
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
            this.GBS = new System.Windows.Forms.DataGridView();
            this.GBSCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSShortNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSTagsColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSBarcodeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSMinReqColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSBuyingColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSGroupColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GBDDefaultEnterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.boolGBSFast = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolGBSNotSelling = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolGBSNotBuying = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolGBSConstPrice = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.boolGBSInvisible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GBSMinBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSMaxBalance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBSLengthColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GBS)).BeginInit();
            this.SuspendLayout();
            // 
            // GBS
            // 
            this.GBS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GBS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GBSCode,
            this.GBSName,
            this.GBSShortNameColumn,
            this.GBSTagsColumn,
            this.GBSBarcodeColumn,
            this.GBSMinReqColumn,
            this.GBSBuyingColumn,
            this.GBSGroupColumn,
            this.GBDDefaultEnterColumn,
            this.boolGBSFast,
            this.boolGBSNotSelling,
            this.boolGBSNotBuying,
            this.boolGBSConstPrice,
            this.boolGBSInvisible,
            this.GBSMinBalance,
            this.GBSMaxBalance,
            this.GBSLengthColumn});
            this.GBS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBS.Location = new System.Drawing.Point(0, 0);
            this.GBS.Name = "GBS";
            this.GBS.Size = new System.Drawing.Size(1989, 450);
            this.GBS.TabIndex = 0;
            // 
            // GBSCode
            // 
            this.GBSCode.HeaderText = "Код";
            this.GBSCode.Name = "GBSCode";
            // 
            // GBSName
            // 
            this.GBSName.HeaderText = "Наименование";
            this.GBSName.Name = "GBSName";
            // 
            // GBSShortNameColumn
            // 
            this.GBSShortNameColumn.HeaderText = "Сокращение";
            this.GBSShortNameColumn.Name = "GBSShortNameColumn";
            // 
            // GBSTagsColumn
            // 
            this.GBSTagsColumn.HeaderText = "Теги";
            this.GBSTagsColumn.Name = "GBSTagsColumn";
            // 
            // GBSBarcodeColumn
            // 
            this.GBSBarcodeColumn.HeaderText = "Штрихкод";
            this.GBSBarcodeColumn.Name = "GBSBarcodeColumn";
            // 
            // GBSMinReqColumn
            // 
            this.GBSMinReqColumn.HeaderText = "Минимальная заявка";
            this.GBSMinReqColumn.Name = "GBSMinReqColumn";
            // 
            // GBSBuyingColumn
            // 
            this.GBSBuyingColumn.HeaderText = "Наценка";
            this.GBSBuyingColumn.Name = "GBSBuyingColumn";
            // 
            // GBSGroupColumn
            // 
            this.GBSGroupColumn.HeaderText = "Группы";
            this.GBSGroupColumn.Name = "GBSGroupColumn";
            this.GBSGroupColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.GBSGroupColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // GBDDefaultEnterColumn
            // 
            this.GBDDefaultEnterColumn.HeaderText = "Ввод по умолчанию";
            this.GBDDefaultEnterColumn.Name = "GBDDefaultEnterColumn";
            // 
            // boolGBSFast
            // 
            this.boolGBSFast.HeaderText = "Быстрый";
            this.boolGBSFast.Name = "boolGBSFast";
            // 
            // boolGBSNotSelling
            // 
            this.boolGBSNotSelling.HeaderText = "Не продажа";
            this.boolGBSNotSelling.Name = "boolGBSNotSelling";
            // 
            // boolGBSNotBuying
            // 
            this.boolGBSNotBuying.HeaderText = "Не покупка";
            this.boolGBSNotBuying.Name = "boolGBSNotBuying";
            this.boolGBSNotBuying.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boolGBSNotBuying.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // boolGBSConstPrice
            // 
            this.boolGBSConstPrice.HeaderText = "Постоянный ценник";
            this.boolGBSConstPrice.Name = "boolGBSConstPrice";
            this.boolGBSConstPrice.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.boolGBSConstPrice.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // boolGBSInvisible
            // 
            this.boolGBSInvisible.HeaderText = "Невидимый";
            this.boolGBSInvisible.Name = "boolGBSInvisible";
            // 
            // GBSMinBalance
            // 
            this.GBSMinBalance.HeaderText = "Минимальный остаток";
            this.GBSMinBalance.Name = "GBSMinBalance";
            // 
            // GBSMaxBalance
            // 
            this.GBSMaxBalance.HeaderText = "Максимальный остаток";
            this.GBSMaxBalance.Name = "GBSMaxBalance";
            // 
            // GBSLengthColumn
            // 
            this.GBSLengthColumn.HeaderText = "Длина";
            this.GBSLengthColumn.Name = "GBSLengthColumn";
            // 
            // GlobalBaseSignature
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1989, 450);
            this.Controls.Add(this.GBS);
            this.Name = "GlobalBaseSignature";
            this.Text = "Глобальная База Сигнатур";
            ((System.ComponentModel.ISupportInitialize)(this.GBS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GBS;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSShortNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSTagsColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSBarcodeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSMinReqColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSBuyingColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn GBSGroupColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBDDefaultEnterColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolGBSFast;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolGBSNotSelling;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolGBSNotBuying;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolGBSConstPrice;
        private System.Windows.Forms.DataGridViewCheckBoxColumn boolGBSInvisible;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSMinBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSMaxBalance;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBSLengthColumn;
    }
}