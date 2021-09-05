namespace WarehouseAccounting.Core
{
    partial class GlobalBaseGroups
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
            this.GBG = new System.Windows.Forms.DataGridView();
            this.GBGGroupNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.GBG)).BeginInit();
            this.SuspendLayout();
            // 
            // GBG
            // 
            this.GBG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GBG.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.GBGGroupNames});
            this.GBG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GBG.Location = new System.Drawing.Point(0, 0);
            this.GBG.Name = "GBG";
            this.GBG.Size = new System.Drawing.Size(701, 450);
            this.GBG.TabIndex = 0;
            this.GBG.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GBG_KeyDown);
            // 
            // GBGGroupNames
            // 
            this.GBGGroupNames.HeaderText = "Группа";
            this.GBGGroupNames.Name = "GBGGroupNames";
            // 
            // GlobalBaseGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 450);
            this.Controls.Add(this.GBG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GlobalBaseGroups";
            this.Text = "Глобальная база групп (селектор)";
            ((System.ComponentModel.ISupportInitialize)(this.GBG)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn GBGGroupNames;
        public System.Windows.Forms.DataGridView GBG;
    }
}