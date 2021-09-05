namespace WarehouseAccounting.Core
{
    partial class GlobalBaseHistory
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
            this.GBH = new System.Windows.Forms.DataGridView();
            this.GBHDateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBHTimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBHName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGHAction = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGHNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGHBecame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGHDocument = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GBH)).BeginInit();
            this.SuspendLayout();
            // 
            // GBH
            // 
            this.GBH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GBH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GBHDateColumn,
            this.GBHTimeColumn,
            this.GBHName,
            this.DGHAction,
            this.DGHNumber,
            this.DGHBecame,
            this.DGHDocument});
            this.GBH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBH.Location = new System.Drawing.Point(0, 0);
            this.GBH.Name = "GBH";
            this.GBH.Size = new System.Drawing.Size(800, 450);
            this.GBH.TabIndex = 0;
            this.GBH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GBH_CellContentClick);
            // 
            // GBHDateColumn
            // 
            this.GBHDateColumn.HeaderText = "Дата события";
            this.GBHDateColumn.Name = "GBHDateColumn";
            // 
            // GBHTimeColumn
            // 
            this.GBHTimeColumn.HeaderText = "Время события";
            this.GBHTimeColumn.Name = "GBHTimeColumn";
            // 
            // GBHName
            // 
            this.GBHName.HeaderText = "Наименование";
            this.GBHName.Name = "GBHName";
            // 
            // DGHAction
            // 
            this.DGHAction.HeaderText = "Действие";
            this.DGHAction.Name = "DGHAction";
            // 
            // DGHNumber
            // 
            this.DGHNumber.HeaderText = "Количество";
            this.DGHNumber.Name = "DGHNumber";
            // 
            // DGHBecame
            // 
            this.DGHBecame.HeaderText = "Стало";
            this.DGHBecame.Name = "DGHBecame";
            // 
            // DGHDocument
            // 
            this.DGHDocument.HeaderText = "Документ";
            this.DGHDocument.Name = "DGHDocument";
            // 
            // GlobalBaseHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBH);
            this.Name = "GlobalBaseHistory";
            this.Text = "Глобальная База Истории";
            ((System.ComponentModel.ISupportInitialize)(this.GBH)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView GBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBHDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBHTimeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBHName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGHAction;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGHNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGHBecame;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGHDocument;
    }
}