namespace WarehouseAccounting
{
    partial class Temp
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
            this.pnlWorkTable = new System.Windows.Forms.Panel();
            this.tcWorktable = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.pnlWorkTable.SuspendLayout();
            this.tcWorktable.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlWorkTable
            // 
            this.pnlWorkTable.Controls.Add(this.tcWorktable);
            this.pnlWorkTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlWorkTable.Location = new System.Drawing.Point(0, 0);
            this.pnlWorkTable.Name = "pnlWorkTable";
            this.pnlWorkTable.Size = new System.Drawing.Size(1040, 688);
            this.pnlWorkTable.TabIndex = 9;
            // 
            // tcWorktable
            // 
            this.tcWorktable.Controls.Add(this.tabPage1);
            this.tcWorktable.Controls.Add(this.tabPage2);
            this.tcWorktable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcWorktable.Location = new System.Drawing.Point(0, 0);
            this.tcWorktable.Name = "tcWorktable";
            this.tcWorktable.SelectedIndex = 0;
            this.tcWorktable.Size = new System.Drawing.Size(1040, 688);
            this.tcWorktable.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1032, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1032, 182);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Temp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlWorkTable);
            this.Name = "Temp";
            this.Size = new System.Drawing.Size(1040, 688);
            this.pnlWorkTable.ResumeLayout(false);
            this.tcWorktable.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlWorkTable;
        private System.Windows.Forms.TabControl tcWorktable;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
