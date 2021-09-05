namespace WarehouseAccounting.Core
{
    partial class GlobalBaseProvider
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
            this.GBP = new System.Windows.Forms.DataGridView();
            this.GBPProviderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBPPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBPDiaposone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBPSale = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GBP)).BeginInit();
            this.SuspendLayout();
            // 
            // GBP
            // 
            this.GBP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GBP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GBPProviderName,
            this.GBPPrice,
            this.GBPDiaposone,
            this.GBPSale});
            this.GBP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBP.Location = new System.Drawing.Point(0, 0);
            this.GBP.Name = "GBP";
            this.GBP.Size = new System.Drawing.Size(800, 450);
            this.GBP.TabIndex = 0;
            // 
            // GBPProviderName
            // 
            this.GBPProviderName.HeaderText = "Поставщик";
            this.GBPProviderName.Name = "GBPProviderName";
            // 
            // GBPPrice
            // 
            this.GBPPrice.HeaderText = "Прайс";
            this.GBPPrice.Name = "GBPPrice";
            // 
            // GBPDiaposone
            // 
            this.GBPDiaposone.HeaderText = "Диапазон";
            this.GBPDiaposone.Name = "GBPDiaposone";
            // 
            // GBPSale
            // 
            this.GBPSale.HeaderText = "Скидка";
            this.GBPSale.Name = "GBPSale";
            // 
            // GlobalBaseProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBP);
            this.Name = "GlobalBaseProvider";
            this.Text = "Глобальная База Поставщиков";
            ((System.ComponentModel.ISupportInitialize)(this.GBP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn GBPProviderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBPPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBPDiaposone;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBPSale;
        public System.Windows.Forms.DataGridView GBP;
    }
}