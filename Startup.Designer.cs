namespace WarehouseAccounting
{
    partial class Startup
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
            this.LogoText = new System.Windows.Forms.Label();
            this.txtLicensed = new System.Windows.Forms.Label();
            this.tpb = new System.Windows.Forms.Timer(this.components);
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtpb = new System.Windows.Forms.Label();
            this.bgwLicensed = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoText.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.LogoText.Location = new System.Drawing.Point(81, 170);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(314, 39);
            this.LogoText.TabIndex = 0;
            this.LogoText.Text = "Warehouse Accounting";
            // 
            // txtLicensed
            // 
            this.txtLicensed.AutoSize = true;
            this.txtLicensed.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicensed.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtLicensed.Location = new System.Drawing.Point(3, 471);
            this.txtLicensed.Name = "txtLicensed";
            this.txtLicensed.Size = new System.Drawing.Size(151, 31);
            this.txtLicensed.TabIndex = 2;
            this.txtLicensed.Text = "Licensed to:";
            // 
            // tpb
            // 
            this.tpb.Enabled = true;
            this.tpb.Tick += new System.EventHandler(this.Tpb_Tick);
            // 
            // bgw
            // 
            this.bgw.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Bgw_DoWork);
            // 
            // txtpb
            // 
            this.txtpb.AutoSize = true;
            this.txtpb.Font = new System.Drawing.Font("MV Boli", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpb.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.txtpb.Location = new System.Drawing.Point(214, 237);
            this.txtpb.Name = "txtpb";
            this.txtpb.Size = new System.Drawing.Size(57, 39);
            this.txtpb.TabIndex = 3;
            this.txtpb.Text = "0%";
            this.txtpb.Click += new System.EventHandler(this.Label1_Click);
            // 
            // bgwLicensed
            // 
            this.bgwLicensed.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwLicensed_DoWork);
            // 
            // Startup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(502, 570);
            this.ControlBox = false;
            this.Controls.Add(this.txtpb);
            this.Controls.Add(this.txtLicensed);
            this.Controls.Add(this.LogoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Startup";
            this.Load += new System.EventHandler(this.Startup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Label txtLicensed;
        private System.Windows.Forms.Timer tpb;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label txtpb;
        private System.ComponentModel.BackgroundWorker bgwLicensed;
    }
}