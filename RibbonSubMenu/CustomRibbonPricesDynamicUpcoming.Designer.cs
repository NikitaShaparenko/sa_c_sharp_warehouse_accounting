namespace WarehouseAccounting.RibbonSubMenu
{
    partial class CustomRibbonPricesDynamicUpcoming
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
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.pic_header_1 = new System.Windows.Forms.PictureBox();
            this.lbl_header_1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.BackColor = System.Drawing.Color.White;
            this.tlp.ColumnCount = 10;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 149F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tlp.Controls.Add(this.pic_header_1, 0, 0);
            this.tlp.Controls.Add(this.lbl_header_1, 0, 1);
            this.tlp.Controls.Add(this.panel1, 1, 0);
            this.tlp.Location = new System.Drawing.Point(3, 3);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Size = new System.Drawing.Size(720, 77);
            this.tlp.TabIndex = 31;
            // 
            // pic_header_1
            // 
            this.pic_header_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_header_1.BackgroundImage = global::WarehouseAccounting.Properties.Resources.close41px;
            this.pic_header_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_1.Location = new System.Drawing.Point(11, 3);
            this.pic_header_1.Name = "pic_header_1";
            this.pic_header_1.Size = new System.Drawing.Size(41, 37);
            this.pic_header_1.TabIndex = 4;
            this.pic_header_1.TabStop = false;
            this.pic_header_1.Click += new System.EventHandler(this.Pic_header_1_Click);
            // 
            // lbl_header_1
            // 
            this.lbl_header_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_header_1.AutoSize = true;
            this.lbl_header_1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header_1.Location = new System.Drawing.Point(3, 43);
            this.lbl_header_1.Name = "lbl_header_1";
            this.lbl_header_1.Size = new System.Drawing.Size(58, 13);
            this.lbl_header_1.TabIndex = 10;
            this.lbl_header_1.Text = "Закрыть";
            this.lbl_header_1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox2);
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(67, 3);
            this.panel1.Name = "panel1";
            this.tlp.SetRowSpan(this.panel1, 2);
            this.panel1.Size = new System.Drawing.Size(143, 71);
            this.panel1.TabIndex = 11;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 26);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Только вверх";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(133, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Округлять результат";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // CustomRibbonPricesDynamicUpcoming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlp);
            this.Name = "CustomRibbonPricesDynamicUpcoming";
            this.Size = new System.Drawing.Size(728, 81);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        public System.Windows.Forms.PictureBox pic_header_1;
        public System.Windows.Forms.Label lbl_header_1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
