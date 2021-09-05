namespace WarehouseAccounting.Core
{
    partial class GlobalBaseContragents
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
            this.GBC = new System.Windows.Forms.DataGridView();
            this.IDCodeGBCColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCContrAgentsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCContrAgentsDebts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCPriceColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCContragentPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCContrAgentsEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCContrAgentsFirm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCContragentsAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBCContragentNote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GBC)).BeginInit();
            this.SuspendLayout();
            // 
            // GBC
            // 
            this.GBC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GBC.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCodeGBCColumn,
            this.GBCContrAgentsName,
            this.GBCContrAgentsDebts,
            this.GBCPriceColumn,
            this.GBCContragentPhone,
            this.GBCContrAgentsEmail,
            this.GBCContrAgentsFirm,
            this.GBCContragentsAddress,
            this.GBCContragentNote});
            this.GBC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBC.Location = new System.Drawing.Point(0, 0);
            this.GBC.Name = "GBC";
            this.GBC.Size = new System.Drawing.Size(1132, 450);
            this.GBC.TabIndex = 0;
            // 
            // IDCodeGBCColumn
            // 
            this.IDCodeGBCColumn.HeaderText = "ID";
            this.IDCodeGBCColumn.Name = "IDCodeGBCColumn";
            // 
            // GBCContrAgentsName
            // 
            this.GBCContrAgentsName.HeaderText = "Контрагент";
            this.GBCContrAgentsName.Name = "GBCContrAgentsName";
            // 
            // GBCContrAgentsDebts
            // 
            this.GBCContrAgentsDebts.HeaderText = "Долги";
            this.GBCContrAgentsDebts.Name = "GBCContrAgentsDebts";
            // 
            // GBCPriceColumn
            // 
            this.GBCPriceColumn.HeaderText = "Расценка";
            this.GBCPriceColumn.Name = "GBCPriceColumn";
            // 
            // GBCContragentPhone
            // 
            this.GBCContragentPhone.HeaderText = "Телефон";
            this.GBCContragentPhone.Name = "GBCContragentPhone";
            // 
            // GBCContrAgentsEmail
            // 
            this.GBCContrAgentsEmail.HeaderText = "Почта";
            this.GBCContrAgentsEmail.Name = "GBCContrAgentsEmail";
            // 
            // GBCContrAgentsFirm
            // 
            this.GBCContrAgentsFirm.HeaderText = "Фирма";
            this.GBCContrAgentsFirm.Name = "GBCContrAgentsFirm";
            // 
            // GBCContragentsAddress
            // 
            this.GBCContragentsAddress.HeaderText = "Адрес";
            this.GBCContragentsAddress.Name = "GBCContragentsAddress";
            // 
            // GBCContragentNote
            // 
            this.GBCContragentNote.HeaderText = "Заметки";
            this.GBCContragentNote.Name = "GBCContragentNote";
            // 
            // GlobalBaseContragents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 450);
            this.Controls.Add(this.GBC);
            this.Name = "GlobalBaseContragents";
            this.Text = "Глобальная база контрагентов";
            ((System.ComponentModel.ISupportInitialize)(this.GBC)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCodeGBCColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCContrAgentsName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCContrAgentsDebts;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCPriceColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCContragentPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCContrAgentsEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCContrAgentsFirm;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCContragentsAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBCContragentNote;
        public System.Windows.Forms.DataGridView GBC;
    }
}