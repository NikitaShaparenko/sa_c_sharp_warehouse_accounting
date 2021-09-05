namespace WarehouseAccounting.RibbonSubMenu
{
    partial class CustomRibbonHistory
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pic_header_1 = new System.Windows.Forms.PictureBox();
            this.pic_header_2 = new System.Windows.Forms.PictureBox();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_2)).BeginInit();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(83, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 34);
            this.label2.TabIndex = 19;
            this.label2.Text = "Последний\r\nперерасчёт";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 34);
            this.label6.TabIndex = 24;
            this.label6.Text = "Закрыть";
            // 
            // pic_header_1
            // 
            this.pic_header_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_header_1.BackgroundImage = global::WarehouseAccounting.Properties.Resources.close41px;
            this.pic_header_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_1.Location = new System.Drawing.Point(19, 3);
            this.pic_header_1.Name = "pic_header_1";
            this.pic_header_1.Size = new System.Drawing.Size(41, 37);
            this.pic_header_1.TabIndex = 4;
            this.pic_header_1.TabStop = false;
            this.pic_header_1.Click += new System.EventHandler(this.Pic_header_1_Click);
            // 
            // pic_header_2
            // 
            this.pic_header_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_header_2.BackgroundImage = global::WarehouseAccounting.Properties.Resources.lastdoc41px;
            this.pic_header_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_2.Location = new System.Drawing.Point(98, 3);
            this.pic_header_2.Name = "pic_header_2";
            this.pic_header_2.Size = new System.Drawing.Size(41, 37);
            this.pic_header_2.TabIndex = 0;
            this.pic_header_2.TabStop = false;
            // 
            // tlp
            // 
            this.tlp.BackColor = System.Drawing.Color.White;
            this.tlp.ColumnCount = 10;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 77F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 58F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 290F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Controls.Add(this.pic_header_2, 1, 0);
            this.tlp.Controls.Add(this.pic_header_1, 0, 0);
            this.tlp.Controls.Add(this.label6, 0, 1);
            this.tlp.Controls.Add(this.label2, 1, 1);
            this.tlp.Location = new System.Drawing.Point(0, 0);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 2;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp.Size = new System.Drawing.Size(904, 77);
            this.tlp.TabIndex = 31;
            // 
            // CustomRibbonHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tlp);
            this.Name = "CustomRibbonHistory";
            this.Size = new System.Drawing.Size(900, 77);
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_2)).EndInit();
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.PictureBox pic_header_1;
        public System.Windows.Forms.PictureBox pic_header_2;
        private System.Windows.Forms.TableLayoutPanel tlp;
    }
}
