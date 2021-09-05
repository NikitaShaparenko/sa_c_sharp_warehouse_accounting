namespace WarehouseAccounting
{
    partial class StatusBarProvider
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
            this.pnlSBP = new System.Windows.Forms.Panel();
            this.tAppear = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pnlSBP
            // 
            this.pnlSBP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSBP.Location = new System.Drawing.Point(0, 0);
            this.pnlSBP.Name = "pnlSBP";
            this.pnlSBP.Size = new System.Drawing.Size(600, 200);
            this.pnlSBP.TabIndex = 0;
            this.pnlSBP.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlSBP_Paint);
            // 
            // tAppear
            // 
            this.tAppear.Enabled = true;
            this.tAppear.Tick += new System.EventHandler(this.TAppear_Tick);
            // 
            // StatusBarProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 200);
            this.Controls.Add(this.pnlSBP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusBarProvider";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSBP;
        private System.Windows.Forms.Timer tAppear;
    }
}