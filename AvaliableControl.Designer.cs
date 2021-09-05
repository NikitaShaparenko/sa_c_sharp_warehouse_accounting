namespace WarehouseAccounting
{
    partial class AvaliableControl
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
            this.tlpAval = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_header_1 = new System.Windows.Forms.Label();
            this.lbl_header_2 = new System.Windows.Forms.Label();
            this.pic_header_2 = new System.Windows.Forms.PictureBox();
            this.pic_header_1 = new System.Windows.Forms.PictureBox();
            this.tlpAval.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).BeginInit();
            this.SuspendLayout();
            // 
            // tlpAval
            // 
            this.tlpAval.BackColor = System.Drawing.Color.White;
            this.tlpAval.ColumnCount = 2;
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.Controls.Add(this.pic_header_1, 0, 0);
            this.tlpAval.Controls.Add(this.lbl_header_1, 0, 1);
            this.tlpAval.Controls.Add(this.lbl_header_2, 1, 1);
            this.tlpAval.Controls.Add(this.pic_header_2, 1, 0);
            this.tlpAval.Location = new System.Drawing.Point(15, 2);
            this.tlpAval.Name = "tlpAval";
            this.tlpAval.RowCount = 2;
            this.tlpAval.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tlpAval.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpAval.Size = new System.Drawing.Size(866, 77);
            this.tlpAval.TabIndex = 28;
            // 
            // lbl_header_1
            // 
            this.lbl_header_1.AutoSize = true;
            this.lbl_header_1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header_1.Location = new System.Drawing.Point(3, 43);
            this.lbl_header_1.Name = "lbl_header_1";
            this.lbl_header_1.Size = new System.Drawing.Size(45, 13);
            this.lbl_header_1.TabIndex = 10;
            this.lbl_header_1.Text = "Печать";
            // 
            // lbl_header_2
            // 
            this.lbl_header_2.AutoSize = true;
            this.lbl_header_2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_header_2.Location = new System.Drawing.Point(83, 43);
            this.lbl_header_2.Name = "lbl_header_2";
            this.lbl_header_2.Size = new System.Drawing.Size(51, 13);
            this.lbl_header_2.TabIndex = 11;
            this.lbl_header_2.Text = "Экспорт";
            // 
            // pic_header_2
            // 
            this.pic_header_2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pic_header_2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_2.Image = global::WarehouseAccounting.Properties.Resources.excel41px;
            this.pic_header_2.Location = new System.Drawing.Point(83, 3);
            this.pic_header_2.Name = "pic_header_2";
            this.pic_header_2.Size = new System.Drawing.Size(41, 37);
            this.pic_header_2.TabIndex = 0;
            this.pic_header_2.TabStop = false;
            this.pic_header_2.Click += new System.EventHandler(this.Pic_header_2_Click);
            // 
            // pic_header_1
            // 
            this.pic_header_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pic_header_1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_header_1.Image = global::WarehouseAccounting.Properties.Resources.printer41px;
            this.pic_header_1.Location = new System.Drawing.Point(19, 3);
            this.pic_header_1.Name = "pic_header_1";
            this.pic_header_1.Size = new System.Drawing.Size(41, 37);
            this.pic_header_1.TabIndex = 4;
            this.pic_header_1.TabStop = false;
            this.pic_header_1.Click += new System.EventHandler(this.Pic_header_1_Click);
            // 
            // AvaliableControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tlpAval);
            this.MaximumSize = new System.Drawing.Size(896, 80);
            this.MinimumSize = new System.Drawing.Size(896, 80);
            this.Name = "AvaliableControl";
            this.Size = new System.Drawing.Size(896, 80);
            this.tlpAval.ResumeLayout(false);
            this.tlpAval.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_header_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlpAval;
        public System.Windows.Forms.PictureBox pic_header_2;
        public System.Windows.Forms.PictureBox pic_header_1;
        public System.Windows.Forms.Label lbl_header_1;
        public System.Windows.Forms.Label lbl_header_2;
    }
}
