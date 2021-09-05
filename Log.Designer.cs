namespace WarehouseAccounting
{
    partial class Log
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
            this.bCopy = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.rtfLog = new System.Windows.Forms.RichTextBox();
            this.bClear = new System.Windows.Forms.Button();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bCopy
            // 
            this.bCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bCopy.BackColor = System.Drawing.Color.Transparent;
            this.bCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bCopy.Location = new System.Drawing.Point(560, 411);
            this.bCopy.Name = "bCopy";
            this.bCopy.Size = new System.Drawing.Size(110, 33);
            this.bCopy.TabIndex = 13;
            this.bCopy.Text = "Скопировать";
            this.bCopy.UseVisualStyleBackColor = false;
            this.bCopy.Click += new System.EventHandler(this.BCopy_Click);
            // 
            // bClose
            // 
            this.bClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClose.BackColor = System.Drawing.Color.Transparent;
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.Location = new System.Drawing.Point(676, 411);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(103, 33);
            this.bClose.TabIndex = 11;
            this.bClose.Text = "Закрыть";
            this.bClose.UseVisualStyleBackColor = false;
            this.bClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // rtfLog
            // 
            this.rtfLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtfLog.Location = new System.Drawing.Point(12, 7);
            this.rtfLog.Name = "rtfLog";
            this.rtfLog.ReadOnly = true;
            this.rtfLog.Size = new System.Drawing.Size(757, 398);
            this.rtfLog.TabIndex = 10;
            this.rtfLog.Text = "";
            // 
            // bClear
            // 
            this.bClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bClear.BackColor = System.Drawing.Color.Transparent;
            this.bClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClear.Location = new System.Drawing.Point(444, 411);
            this.bClear.Name = "bClear";
            this.bClear.Size = new System.Drawing.Size(110, 33);
            this.bClear.TabIndex = 15;
            this.bClear.Text = "Очистить";
            this.bClear.UseVisualStyleBackColor = false;
            this.bClear.Click += new System.EventHandler(this.BClear_Click);
            // 
            // bSave
            // 
            this.bSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.bSave.BackColor = System.Drawing.Color.Transparent;
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(22, 411);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(143, 33);
            this.bSave.TabIndex = 14;
            this.bSave.Text = "Экспорт в файл";
            this.bSave.UseVisualStyleBackColor = false;
            this.bSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bCopy);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.rtfLog);
            this.Controls.Add(this.bClear);
            this.Controls.Add(this.bSave);
            this.Name = "Log";
            this.Text = "Журнал";
            this.Load += new System.EventHandler(this.Log_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bCopy;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.RichTextBox rtfLog;
        private System.Windows.Forms.Button bClear;
        private System.Windows.Forms.Button bSave;
    }
}