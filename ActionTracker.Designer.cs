namespace WarehouseAccounting
{
    partial class ActionTracker
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
            this.dgvActionTracker = new System.Windows.Forms.DataGridView();
            this.DateColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActionColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WasColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BecameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionTracker)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActionTracker
            // 
            this.dgvActionTracker.BackgroundColor = System.Drawing.Color.White;
            this.dgvActionTracker.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActionTracker.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateColumn,
            this.NameColumn,
            this.ActionColumn,
            this.WasColumn,
            this.BecameColumn});
            this.dgvActionTracker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvActionTracker.Location = new System.Drawing.Point(0, 0);
            this.dgvActionTracker.Name = "dgvActionTracker";
            this.dgvActionTracker.RowHeadersVisible = false;
            this.dgvActionTracker.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dgvActionTracker.Size = new System.Drawing.Size(273, 424);
            this.dgvActionTracker.TabIndex = 2;
            // 
            // DateColumn
            // 
            this.DateColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.DateColumn.Frozen = true;
            this.DateColumn.HeaderText = "Дата";
            this.DateColumn.Name = "DateColumn";
            this.DateColumn.ReadOnly = true;
            this.DateColumn.Visible = false;
            this.DateColumn.Width = 39;
            // 
            // NameColumn
            // 
            this.NameColumn.Frozen = true;
            this.NameColumn.HeaderText = "Наименование";
            this.NameColumn.Name = "NameColumn";
            this.NameColumn.ReadOnly = true;
            this.NameColumn.Visible = false;
            // 
            // ActionColumn
            // 
            this.ActionColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.ActionColumn.Frozen = true;
            this.ActionColumn.HeaderText = "Действие";
            this.ActionColumn.Name = "ActionColumn";
            this.ActionColumn.ReadOnly = true;
            this.ActionColumn.Width = 82;
            // 
            // WasColumn
            // 
            this.WasColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.WasColumn.Frozen = true;
            this.WasColumn.HeaderText = "Кол-во";
            this.WasColumn.Name = "WasColumn";
            this.WasColumn.ReadOnly = true;
            this.WasColumn.Width = 66;
            // 
            // BecameColumn
            // 
            this.BecameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BecameColumn.Frozen = true;
            this.BecameColumn.HeaderText = "Стало";
            this.BecameColumn.Name = "BecameColumn";
            this.BecameColumn.ReadOnly = true;
            this.BecameColumn.Width = 62;
            // 
            // ActionTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvActionTracker);
            this.Name = "ActionTracker";
            this.Size = new System.Drawing.Size(273, 424);
            this.Load += new System.EventHandler(this.ActionTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActionTracker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActionTracker;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActionColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn WasColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn BecameColumn;
    }
}
