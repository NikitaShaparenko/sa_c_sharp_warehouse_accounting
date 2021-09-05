namespace WarehouseAccounting
{
    partial class LoadingForm
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtLicensed = new System.Windows.Forms.Label();
            this.buttonZ1 = new WarehouseAccounting.ButtonZ();
            this.buttonZ2 = new WarehouseAccounting.ButtonZ();
            this.txtpb = new System.Windows.Forms.Label();
            this.LogoText = new System.Windows.Forms.Label();
            this.BuildText = new System.Windows.Forms.Label();
            this.tpb = new System.Windows.Forms.Timer(this.components);
            this.bgw = new System.ComponentModel.BackgroundWorker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bgwLicensed = new System.ComponentModel.BackgroundWorker();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(445, 239);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            this.mainPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseDown);
            this.mainPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseMove);
            this.mainPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainPanel_MouseUp);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.txtLicensed);
            this.panel1.Controls.Add(this.buttonZ1);
            this.panel1.Controls.Add(this.buttonZ2);
            this.panel1.Controls.Add(this.txtpb);
            this.panel1.Controls.Add(this.LogoText);
            this.panel1.Controls.Add(this.BuildText);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 239);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // txtLicensed
            // 
            this.txtLicensed.AutoSize = true;
            this.txtLicensed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtLicensed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtLicensed.Location = new System.Drawing.Point(11, 180);
            this.txtLicensed.Name = "txtLicensed";
            this.txtLicensed.Size = new System.Drawing.Size(87, 19);
            this.txtLicensed.TabIndex = 6;
            this.txtLicensed.Text = "Licensed to:";
            // 
            // buttonZ1
            // 
            this.buttonZ1.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ1.DisplayText = "X";
            this.buttonZ1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ1.ForeColor = System.Drawing.Color.White;
            this.buttonZ1.Location = new System.Drawing.Point(415, 4);
            this.buttonZ1.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ1.Name = "buttonZ1";
            this.buttonZ1.Size = new System.Drawing.Size(27, 23);
            this.buttonZ1.TabIndex = 3;
            this.buttonZ1.Text = "X";
            this.buttonZ1.TextLocation_X = 6;
            this.buttonZ1.TextLocation_Y = 0;
            this.buttonZ1.UseVisualStyleBackColor = true;
            this.buttonZ1.Click += new System.EventHandler(this.buttonZ1_Click);
            // 
            // buttonZ2
            // 
            this.buttonZ2.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.buttonZ2.DisplayText = "_";
            this.buttonZ2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonZ2.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonZ2.ForeColor = System.Drawing.Color.White;
            this.buttonZ2.Location = new System.Drawing.Point(392, 3);
            this.buttonZ2.MouseClickColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ2.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.buttonZ2.Name = "buttonZ2";
            this.buttonZ2.Size = new System.Drawing.Size(27, 23);
            this.buttonZ2.TabIndex = 4;
            this.buttonZ2.Text = "_";
            this.buttonZ2.TextLocation_X = 6;
            this.buttonZ2.TextLocation_Y = -2;
            this.buttonZ2.UseVisualStyleBackColor = true;
            this.buttonZ2.Click += new System.EventHandler(this.buttonZ2_Click);
            // 
            // txtpb
            // 
            this.txtpb.AutoSize = true;
            this.txtpb.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtpb.ForeColor = System.Drawing.Color.White;
            this.txtpb.Location = new System.Drawing.Point(11, 209);
            this.txtpb.Name = "txtpb";
            this.txtpb.Size = new System.Drawing.Size(0, 19);
            this.txtpb.TabIndex = 2;
            // 
            // LogoText
            // 
            this.LogoText.AutoSize = true;
            this.LogoText.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogoText.ForeColor = System.Drawing.Color.White;
            this.LogoText.Location = new System.Drawing.Point(35, 69);
            this.LogoText.Name = "LogoText";
            this.LogoText.Size = new System.Drawing.Size(367, 45);
            this.LogoText.TabIndex = 1;
            this.LogoText.Text = "Warehouse Accounting";
            // 
            // BuildText
            // 
            this.BuildText.AutoSize = true;
            this.BuildText.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildText.ForeColor = System.Drawing.Color.White;
            this.BuildText.Location = new System.Drawing.Point(10, 9);
            this.BuildText.Name = "BuildText";
            this.BuildText.Size = new System.Drawing.Size(104, 26);
            this.BuildText.TabIndex = 0;
            this.BuildText.Text = "build 1109";
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
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // bgwLicensed
            // 
            this.bgwLicensed.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgwLicensed_DoWork);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 239);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word";
            this.Activated += new System.EventHandler(this.LoadingForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LoadingForm_Closed);
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private ButtonZ buttonZ1;
        private ButtonZ buttonZ2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtLicensed;
        private System.Windows.Forms.Label txtpb;
        private System.Windows.Forms.Label LogoText;
        private System.Windows.Forms.Label BuildText;
        private System.Windows.Forms.Timer tpb;
        private System.ComponentModel.BackgroundWorker bgw;
        private System.Windows.Forms.Timer timer1;
        private System.ComponentModel.BackgroundWorker bgwLicensed;
    }
}