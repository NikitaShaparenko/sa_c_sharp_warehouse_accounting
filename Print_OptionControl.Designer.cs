namespace WarehouseAccounting
{
    partial class Print_OptionControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PrintText = new System.Windows.Forms.Label();
            this.bPrint = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.PrinterLowerText = new System.Windows.Forms.Label();
            this.cmbPrinters = new System.Windows.Forms.ComboBox();
            this.SettingsText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintText
            // 
            this.PrintText.AutoSize = true;
            this.PrintText.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.PrintText.Location = new System.Drawing.Point(40, 0);
            this.PrintText.Name = "PrintText";
            this.PrintText.Size = new System.Drawing.Size(123, 45);
            this.PrintText.TabIndex = 8;
            this.PrintText.Text = "Печать";
            // 
            // bPrint
            // 
            this.bPrint.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.bPrint.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.bPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bPrint.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPrint.Image = global::WarehouseAccounting.Properties.Resources.printer50px;
            this.bPrint.Location = new System.Drawing.Point(48, 79);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(96, 87);
            this.bPrint.TabIndex = 9;
            this.bPrint.Text = "Печать";
            this.bPrint.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bPrint.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(161, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Copies:";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(214, 79);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(77, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PrinterLowerText
            // 
            this.PrinterLowerText.AutoSize = true;
            this.PrinterLowerText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrinterLowerText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.PrinterLowerText.Location = new System.Drawing.Point(43, 180);
            this.PrinterLowerText.Name = "PrinterLowerText";
            this.PrinterLowerText.Size = new System.Drawing.Size(96, 30);
            this.PrinterLowerText.TabIndex = 12;
            this.PrinterLowerText.Text = "Принтер";
            // 
            // cmbPrinters
            // 
            this.cmbPrinters.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrinters.FormattingEnabled = true;
            this.cmbPrinters.Location = new System.Drawing.Point(48, 214);
            this.cmbPrinters.Name = "cmbPrinters";
            this.cmbPrinters.Size = new System.Drawing.Size(243, 28);
            this.cmbPrinters.TabIndex = 13;
            this.cmbPrinters.Text = "Microsoft Print to PDF";
            // 
            // SettingsText
            // 
            this.SettingsText.AutoSize = true;
            this.SettingsText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingsText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.SettingsText.Location = new System.Drawing.Point(43, 265);
            this.SettingsText.Name = "SettingsText";
            this.SettingsText.Size = new System.Drawing.Size(116, 30);
            this.SettingsText.TabIndex = 14;
            this.SettingsText.Text = "Настройки";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(297, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1, 232);
            this.panel1.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(326, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 382);
            this.panel2.TabIndex = 16;
            // 
            // Print_OptionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SettingsText);
            this.Controls.Add(this.cmbPrinters);
            this.Controls.Add(this.PrinterLowerText);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.PrintText);
            this.Name = "Print_OptionControl";
            this.Size = new System.Drawing.Size(771, 482);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PrintText;
        private System.Windows.Forms.Button bPrint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label PrinterLowerText;
        private System.Windows.Forms.ComboBox cmbPrinters;
        private System.Windows.Forms.Label SettingsText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
