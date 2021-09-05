namespace WarehouseAccounting.Core
{
    partial class GlobalBaseVerification
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
            this.GBV = new System.Windows.Forms.DataGridView();
            this.GBPSelector = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GBVCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBVName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDateChanged = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGVDayVerificated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GPVLink = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GBV)).BeginInit();
            this.SuspendLayout();
            // 
            // GBV
            // 
            this.GBV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GBV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GBPSelector,
            this.GBVCode,
            this.GBVName,
            this.DGVPrice,
            this.DGVDateChanged,
            this.DGVDayVerificated,
            this.GPVLink});
            this.GBV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBV.Location = new System.Drawing.Point(0, 0);
            this.GBV.Name = "GBV";
            this.GBV.Size = new System.Drawing.Size(800, 450);
            this.GBV.TabIndex = 0;
            // 
            // GBPSelector
            // 
            this.GBPSelector.HeaderText = "";
            this.GBPSelector.Name = "GBPSelector";
            // 
            // GBVCode
            // 
            this.GBVCode.HeaderText = "Код";
            this.GBVCode.Name = "GBVCode";
            // 
            // GBVName
            // 
            this.GBVName.HeaderText = "Наименование";
            this.GBVName.Name = "GBVName";
            // 
            // DGVPrice
            // 
            this.DGVPrice.HeaderText = "Цена";
            this.DGVPrice.Name = "DGVPrice";
            // 
            // DGVDateChanged
            // 
            this.DGVDateChanged.HeaderText = "Изменена";
            this.DGVDateChanged.Name = "DGVDateChanged";
            // 
            // DGVDayVerificated
            // 
            this.DGVDayVerificated.HeaderText = "Проверена";
            this.DGVDayVerificated.Name = "DGVDayVerificated";
            // 
            // GPVLink
            // 
            this.GPVLink.HeaderText = "Ссылка";
            this.GPVLink.Name = "GPVLink";
            // 
            // GlobalBaseVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBV);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "GlobalBaseVerification";
            this.Text = "Глобальная База Сверки Цен Поставщиков";
            ((System.ComponentModel.ISupportInitialize)(this.GBV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewCheckBoxColumn GBPSelector;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBVCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBVName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVDateChanged;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGVDayVerificated;
        private System.Windows.Forms.DataGridViewTextBoxColumn GPVLink;
        public System.Windows.Forms.DataGridView GBV;
    }
}