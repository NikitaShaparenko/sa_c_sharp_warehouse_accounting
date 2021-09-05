namespace WarehouseAccounting
{
    partial class TemplatesControl
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlRecentProj = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.OpenProjectText = new System.Windows.Forms.Label();
            this.RecentText = new System.Windows.Forms.Label();
            this.AccountText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.NewText = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pnlForNewProject = new System.Windows.Forms.Panel();
            this.picWh = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picWh)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(13, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 106);
            this.label2.TabIndex = 2;
            this.label2.Text = "Warehouse\r\nAccounting";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pnlRecentProj);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.OpenProjectText);
            this.panel1.Controls.Add(this.RecentText);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 429);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pnlRecentProj
            // 
            this.pnlRecentProj.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlRecentProj.Location = new System.Drawing.Point(22, 150);
            this.pnlRecentProj.Name = "pnlRecentProj";
            this.pnlRecentProj.Size = new System.Drawing.Size(242, 205);
            this.pnlRecentProj.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(23, 361);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(241, 2);
            this.panel2.TabIndex = 5;
            // 
            // OpenProjectText
            // 
            this.OpenProjectText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenProjectText.AutoSize = true;
            this.OpenProjectText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenProjectText.ForeColor = System.Drawing.Color.White;
            this.OpenProjectText.Location = new System.Drawing.Point(19, 377);
            this.OpenProjectText.Name = "OpenProjectText";
            this.OpenProjectText.Size = new System.Drawing.Size(190, 21);
            this.OpenProjectText.TabIndex = 4;
            this.OpenProjectText.Text = "Открыть проект с диска";
            this.OpenProjectText.Click += new System.EventHandler(this.OpenProjectText_Click);
            // 
            // RecentText
            // 
            this.RecentText.AutoSize = true;
            this.RecentText.Font = new System.Drawing.Font("Segoe UI Semilight", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RecentText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RecentText.Location = new System.Drawing.Point(16, 106);
            this.RecentText.Name = "RecentText";
            this.RecentText.Size = new System.Drawing.Size(145, 40);
            this.RecentText.TabIndex = 3;
            this.RecentText.Text = "Недавние";
            this.RecentText.Click += new System.EventHandler(this.RecentText_Click);
            // 
            // AccountText
            // 
            this.AccountText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AccountText.AutoSize = true;
            this.AccountText.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.AccountText.Location = new System.Drawing.Point(530, 31);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(89, 25);
            this.AccountText.TabIndex = 6;
            this.AccountText.Text = "Аккаунт:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PeachPuff;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(342, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(259, 180);
            this.button1.TabIndex = 7;
            this.toolTip1.SetToolTip(this.button1, "Blank Presentation");
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.picWh);
            this.panel3.Location = new System.Drawing.Point(354, 96);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(237, 105);
            this.panel3.TabIndex = 8;
            this.toolTip1.SetToolTip(this.panel3, "Blank Presentation");
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // NewText
            // 
            this.NewText.AutoSize = true;
            this.NewText.BackColor = System.Drawing.Color.PeachPuff;
            this.NewText.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
            this.NewText.Location = new System.Drawing.Point(351, 216);
            this.NewText.Name = "NewText";
            this.NewText.Size = new System.Drawing.Size(87, 15);
            this.NewText.TabIndex = 9;
            this.NewText.Text = "Новый проект";
            // 
            // pnlForNewProject
            // 
            this.pnlForNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlForNewProject.Location = new System.Drawing.Point(286, 59);
            this.pnlForNewProject.Name = "pnlForNewProject";
            this.pnlForNewProject.Size = new System.Drawing.Size(529, 367);
            this.pnlForNewProject.TabIndex = 10;
            this.pnlForNewProject.Visible = false;
            // 
            // picWh
            // 
            this.picWh.Image = global::WarehouseAccounting.Properties.Resources.WarehouseIcon70px;
            this.picWh.Location = new System.Drawing.Point(84, 10);
            this.picWh.Name = "picWh";
            this.picWh.Size = new System.Drawing.Size(70, 70);
            this.picWh.TabIndex = 0;
            this.picWh.TabStop = false;
            // 
            // TemplatesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlForNewProject);
            this.Controls.Add(this.NewText);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AccountText);
            this.Controls.Add(this.panel1);
            this.Name = "TemplatesControl";
            this.Size = new System.Drawing.Size(818, 429);
            this.Load += new System.EventHandler(this.TemplatesControl_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picWh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label OpenProjectText;
        private System.Windows.Forms.Label RecentText;
        private System.Windows.Forms.Label AccountText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label NewText;
        private System.Windows.Forms.PictureBox picWh;
        private System.Windows.Forms.Panel pnlForNewProject;
        private System.Windows.Forms.Panel pnlRecentProj;
    }
}
