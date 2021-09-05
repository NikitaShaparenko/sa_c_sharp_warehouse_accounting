namespace WarehouseAccounting
{
    partial class LowRAMStatusWindowControl
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
            this.components = new System.ComponentModel.Container();
            this.ErrorText = new System.Windows.Forms.Label();
            this.txtHowMuchINeed = new System.Windows.Forms.Label();
            this.txtRAM = new System.Windows.Forms.Label();
            this.tRuntime = new System.Windows.Forms.Timer(this.components);
            this.picHDD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHDD)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorText.ForeColor = System.Drawing.Color.White;
            this.ErrorText.Location = new System.Drawing.Point(205, 29);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(337, 30);
            this.ErrorText.TabIndex = 9;
            this.ErrorText.Text = "Нехватка оперативной памяти!";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtHowMuchINeed
            // 
            this.txtHowMuchINeed.AutoSize = true;
            this.txtHowMuchINeed.ForeColor = System.Drawing.Color.White;
            this.txtHowMuchINeed.Location = new System.Drawing.Point(179, 114);
            this.txtHowMuchINeed.Name = "txtHowMuchINeed";
            this.txtHowMuchINeed.Size = new System.Drawing.Size(388, 21);
            this.txtHowMuchINeed.TabIndex = 8;
            this.txtHowMuchINeed.Text = "Нужно освободить 0,000 мб (Виртуальной 0,000 мб)";
            // 
            // txtRAM
            // 
            this.txtRAM.AutoSize = true;
            this.txtRAM.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtRAM.ForeColor = System.Drawing.Color.White;
            this.txtRAM.Location = new System.Drawing.Point(179, 82);
            this.txtRAM.Name = "txtRAM";
            this.txtRAM.Size = new System.Drawing.Size(390, 21);
            this.txtRAM.TabIndex = 6;
            this.txtRAM.Text = "Осталось всего 0,000 мб (Виртуальной 0,000 мб)";
            this.txtRAM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tRuntime
            // 
            this.tRuntime.Enabled = true;
            this.tRuntime.Tick += new System.EventHandler(this.TRuntime_Tick);
            // 
            // picHDD
            // 
            this.picHDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHDD.Image = global::WarehouseAccounting.Properties.Resources.Memory150px;
            this.picHDD.Location = new System.Drawing.Point(22, 19);
            this.picHDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHDD.Name = "picHDD";
            this.picHDD.Size = new System.Drawing.Size(150, 150);
            this.picHDD.TabIndex = 5;
            this.picHDD.TabStop = false;
            // 
            // LowRAMStatusWindowControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.txtHowMuchINeed);
            this.Controls.Add(this.txtRAM);
            this.Controls.Add(this.picHDD);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "LowRAMStatusWindowControl";
            this.Size = new System.Drawing.Size(600, 200);
            this.Load += new System.EventHandler(this.LowRAMStatusWindowControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picHDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label txtHowMuchINeed;
        private System.Windows.Forms.Label txtRAM;
        private System.Windows.Forms.PictureBox picHDD;
        private System.Windows.Forms.Timer tRuntime;
    }
}
