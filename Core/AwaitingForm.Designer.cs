namespace WarehouseAccounting.Core
{
    partial class AwaitingForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.BackgroundWorker bwLoadSettings;
            System.ComponentModel.BackgroundWorker bwLoadGBH;
            System.ComponentModel.BackgroundWorker bwLoadGBS;
            this.label1 = new System.Windows.Forms.Label();
            this.pbAwaiting = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tProgress = new System.Windows.Forms.Timer(this.components);
            bwLoadSettings = new System.ComponentModel.BackgroundWorker();
            bwLoadGBH = new System.ComponentModel.BackgroundWorker();
            bwLoadGBS = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Идёт загрузка проекта";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbAwaiting
            // 
            this.pbAwaiting.Location = new System.Drawing.Point(12, 122);
            this.pbAwaiting.Name = "pbAwaiting";
            this.pbAwaiting.Size = new System.Drawing.Size(370, 23);
            this.pbAwaiting.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbAwaiting.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 42);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пожалуйста, подождите...\r\nЭто не займёт много времени";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bwLoadSettings
            // 
            bwLoadSettings.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwLoadSettings_DoWork);
            // 
            // tProgress
            // 
            this.tProgress.Enabled = true;
            this.tProgress.Tick += new System.EventHandler(this.TProgress_Tick);
            // 
            // bwLoadGBH
            // 
            bwLoadGBH.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwLoadGBH_DoWork);
            // 
            // bwLoadGBS
            // 
            bwLoadGBS.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BwLoadGBS_DoWork);
            // 
            // AwaitingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(394, 158);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbAwaiting);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(396, 160);
            this.MinimumSize = new System.Drawing.Size(396, 160);
            this.Name = "AwaitingForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Load += new System.EventHandler(this.AwaitingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar pbAwaiting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer tProgress;
    }
}