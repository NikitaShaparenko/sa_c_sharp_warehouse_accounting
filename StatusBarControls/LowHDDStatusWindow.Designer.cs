namespace WarehouseAccounting
{
    partial class LowHDDStatusWindow
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
            this.txtEstimatedHDD = new System.Windows.Forms.Label();
            this.tRuntime = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picHDD = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHDD)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorText
            // 
            this.ErrorText.AutoSize = true;
            this.ErrorText.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ErrorText.ForeColor = System.Drawing.Color.White;
            this.ErrorText.Location = new System.Drawing.Point(171, 40);
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(426, 32);
            this.ErrorText.TabIndex = 12;
            this.ErrorText.Text = "Нехватка места на жёстком диске!";
            this.ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtHowMuchINeed
            // 
            this.txtHowMuchINeed.AutoSize = true;
            this.txtHowMuchINeed.ForeColor = System.Drawing.Color.White;
            this.txtHowMuchINeed.Location = new System.Drawing.Point(248, 117);
            this.txtHowMuchINeed.Name = "txtHowMuchINeed";
            this.txtHowMuchINeed.Size = new System.Drawing.Size(247, 21);
            this.txtHowMuchINeed.TabIndex = 11;
            this.txtHowMuchINeed.Text = "Нужно освободить ещё 0,000 мб";
            this.txtHowMuchINeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtEstimatedHDD
            // 
            this.txtEstimatedHDD.AutoSize = true;
            this.txtEstimatedHDD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtEstimatedHDD.ForeColor = System.Drawing.Color.White;
            this.txtEstimatedHDD.Location = new System.Drawing.Point(276, 85);
            this.txtEstimatedHDD.Name = "txtEstimatedHDD";
            this.txtEstimatedHDD.Size = new System.Drawing.Size(200, 21);
            this.txtEstimatedHDD.TabIndex = 10;
            this.txtEstimatedHDD.Text = "Осталось всего 0,000 мб";
            this.txtEstimatedHDD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tRuntime
            // 
            this.tRuntime.Tick += new System.EventHandler(this.TRuntime_Tick);
            // 
            // picHDD
            // 
            this.picHDD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picHDD.Image = global::WarehouseAccounting.Properties.Resources.HardDrive150px;
            this.picHDD.Location = new System.Drawing.Point(22, 22);
            this.picHDD.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.picHDD.Name = "picHDD";
            this.picHDD.Size = new System.Drawing.Size(150, 150);
            this.picHDD.TabIndex = 0;
            this.picHDD.TabStop = false;
            // 
            // LowHDDStatusWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkRed;
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.txtHowMuchINeed);
            this.Controls.Add(this.txtEstimatedHDD);
            this.Controls.Add(this.picHDD);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(600, 200);
            this.MinimumSize = new System.Drawing.Size(600, 200);
            this.Name = "LowHDDStatusWindow";
            this.Size = new System.Drawing.Size(600, 200);
            ((System.ComponentModel.ISupportInitialize)(this.picHDD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picHDD;
        private System.Windows.Forms.Label ErrorText;
        private System.Windows.Forms.Label txtHowMuchINeed;
        private System.Windows.Forms.Label txtEstimatedHDD;
        private System.Windows.Forms.Timer tRuntime;
        private System.Windows.Forms.Timer timer1;
    }
}
