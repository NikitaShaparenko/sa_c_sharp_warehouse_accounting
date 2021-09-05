namespace WarehouseAccounting.RibbonSubMenu
{
    partial class CustomRibbonGoodsBarcodes
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
            this.pic_header_2 = new System.Windows.Forms.PictureBox();
            this.pic_header_3 = new System.Windows.Forms.PictureBox();
            this.pic_header_1 = new System.Windows.Forms.PictureBox();
            this.lbl_header_1 = new System.Windows.Forms.Label();
            this.lbl_header_2 = new System.Windows.Forms.Label();
            this.lbl_header_3 = new System.Windows.Forms.Label();
            this.tlp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlp
            // 
            this.tlp.BackColor = System.Drawing.Color.White;
            this.tlp.ColumnCount = 10;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 266F));
            this.tlp.Controls.Add(this.pic_header_2, 1, 0);
            this.tlp.Controls.Add(this.pic_header_3, 2, 0);
            this.tlp.Controls.Add(this.pic_header_1, 0, 0);
            this.tlp.Controls.Add(this.lbl_header_1, 0, 1);
            this.tlp.Controls.Add(this.lbl_header_2, 1, 1);
            this.tlp.Controls.Add(this.lbl_header_3, 2, 1);
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Size = new System.Drawing.Size(720, 77);
            this.tlp.TabIndex = 28;
            this.tlp.Paint += new System.Windows.Forms.PaintEventHandler(this.Tlp_Paint);
            // 
            // pic_header_2
            // 
            this.pic_header_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_header_2.BackgroundImage = global::WarehouseAccounting.Properties.Resources.delete41px;
            this.pic_header_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_2.Location = new System.Drawing.Point(92, 3);
            this.pic_header_2.Name = "pic_header_2";
            this.pic_header_2.Size = new System.Drawing.Size(41, 37);
            this.pic_header_2.TabIndex = 0;
            this.pic_header_2.TabStop = false;
            // 
            // pic_header_3
            // 
            this.pic_header_3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_header_3.BackgroundImage = global::WarehouseAccounting.Properties.Resources.close41px;
            this.pic_header_3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_3.Location = new System.Drawing.Point(164, 3);
            this.pic_header_3.Name = "pic_header_3";
            this.pic_header_3.Size = new System.Drawing.Size(41, 37);
            this.pic_header_3.TabIndex = 1;
            this.pic_header_3.TabStop = false;
            // 
            // pic_header_1
            // 
            this.pic_header_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_header_1.BackgroundImage = global::WarehouseAccounting.Properties.Resources.quit41px;
            this.pic_header_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_1.Location = new System.Drawing.Point(19, 3);
            this.pic_header_1.Name = "pic_header_1";
            this.pic_header_1.Size = new System.Drawing.Size(41, 37);
            this.pic_header_1.TabIndex = 4;
            this.pic_header_1.TabStop = false;
            this.pic_header_1.Click += new System.EventHandler(this.Pic_header_1_Click);
            // 
            // lbl_header_1
            // 
            this.lbl_header_1.AutoSize = true;
            this.lbl_header_1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header_1.Location = new System.Drawing.Point(3, 43);
            this.lbl_header_1.Name = "lbl_header_1";
            this.lbl_header_1.Size = new System.Drawing.Size(41, 13);
            this.lbl_header_1.TabIndex = 10;
            this.lbl_header_1.Text = "Выйти";
            // 
            // lbl_header_2
            // 
            this.lbl_header_2.AutoSize = true;
            this.lbl_header_2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header_2.Location = new System.Drawing.Point(83, 43);
            this.lbl_header_2.Name = "lbl_header_2";
            this.lbl_header_2.Size = new System.Drawing.Size(49, 13);
            this.lbl_header_2.TabIndex = 11;
            this.lbl_header_2.Text = "Удалить";
            // 
            // lbl_header_3
            // 
            this.lbl_header_3.AutoSize = true;
            this.lbl_header_3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header_3.Location = new System.Drawing.Point(148, 43);
            this.lbl_header_3.Name = "lbl_header_3";
            this.lbl_header_3.Size = new System.Drawing.Size(64, 13);
            this.lbl_header_3.TabIndex = 12;
            this.lbl_header_3.Text = "Перенести";
            // 
            // CustomRibbonGoodsBarcodes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp);
            this.MaximumSize = new System.Drawing.Size(723, 77);
            this.MinimumSize = new System.Drawing.Size(723, 77);
            this.Name = "CustomRibbonGoodsBarcodes";
            this.Size = new System.Drawing.Size(723, 77);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp;
        public System.Windows.Forms.PictureBox pic_header_2;
        public System.Windows.Forms.PictureBox pic_header_3;
        public System.Windows.Forms.PictureBox pic_header_1;
        public System.Windows.Forms.Label lbl_header_1;
        public System.Windows.Forms.Label lbl_header_2;
        public System.Windows.Forms.Label lbl_header_3;
    }
}
