namespace WarehouseAccounting.Core
{
    partial class GlobalBaseActions
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
            this.GBA = new System.Windows.Forms.DataGridView();
            this.GBACodeOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBAContrAgentName = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.GBADateTimeOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBAActionOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBASumOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBANowOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GBANoteOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GBA)).BeginInit();
            this.SuspendLayout();
            // 
            // GBA
            // 
            this.GBA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GBA.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GBACodeOperation,
            this.GBAContrAgentName,
            this.GBADateTimeOperation,
            this.GBAActionOperation,
            this.GBASumOperation,
            this.GBANowOperation,
            this.GBANoteOperation});
            this.GBA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBA.Location = new System.Drawing.Point(0, 0);
            this.GBA.Name = "GBA";
            this.GBA.Size = new System.Drawing.Size(800, 450);
            this.GBA.TabIndex = 0;
            // 
            // GBACodeOperation
            // 
            this.GBACodeOperation.HeaderText = "Код";
            this.GBACodeOperation.Name = "GBACodeOperation";
            // 
            // GBAContrAgentName
            // 
            this.GBAContrAgentName.HeaderText = "Контрагент";
            this.GBAContrAgentName.Name = "GBAContrAgentName";
            // 
            // GBADateTimeOperation
            // 
            this.GBADateTimeOperation.HeaderText = "Дата и время";
            this.GBADateTimeOperation.Name = "GBADateTimeOperation";
            // 
            // GBAActionOperation
            // 
            this.GBAActionOperation.HeaderText = "Событие";
            this.GBAActionOperation.Name = "GBAActionOperation";
            // 
            // GBASumOperation
            // 
            this.GBASumOperation.HeaderText = "Сумма";
            this.GBASumOperation.Name = "GBASumOperation";
            // 
            // GBANowOperation
            // 
            this.GBANowOperation.HeaderText = "Стало";
            this.GBANowOperation.Name = "GBANowOperation";
            // 
            // GBANoteOperation
            // 
            this.GBANoteOperation.HeaderText = "Примечание";
            this.GBANoteOperation.Name = "GBANoteOperation";
            // 
            // GlobalBaseActions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GBA);
            this.Name = "GlobalBaseActions";
            this.Text = "Глобальная База Действия контрагентов";
            ((System.ComponentModel.ISupportInitialize)(this.GBA)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn GBACodeOperation;
        private System.Windows.Forms.DataGridViewComboBoxColumn GBAContrAgentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBADateTimeOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBAActionOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBASumOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBANowOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn GBANoteOperation;
        public System.Windows.Forms.DataGridView GBA;
    }
}