namespace WarehouseAccounting
{
    partial class FileOptionsControl
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mainFilePanel = new System.Windows.Forms.Panel();
            this.OptionsButton = new WarehouseAccounting.OptionButton();
            this.AccountButton = new WarehouseAccounting.OptionButton();
            this.CloseButton = new WarehouseAccounting.OptionButton();
            this.ExportButton = new WarehouseAccounting.OptionButton();
            this.ShareButton = new WarehouseAccounting.OptionButton();
            this.PrintButton = new WarehouseAccounting.OptionButton();
            this.SaveAsButton = new WarehouseAccounting.OptionButton();
            this.SaveButton = new WarehouseAccounting.OptionButton();
            this.OpenButton = new WarehouseAccounting.OptionButton();
            this.NewButton = new WarehouseAccounting.OptionButton();
            this.InfoButton = new WarehouseAccounting.OptionButton();
            this.backButton1 = new WarehouseAccounting.BackButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.OptionsButton);
            this.panel1.Controls.Add(this.AccountButton);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.CloseButton);
            this.panel1.Controls.Add(this.ExportButton);
            this.panel1.Controls.Add(this.ShareButton);
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.SaveAsButton);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.OpenButton);
            this.panel1.Controls.Add(this.NewButton);
            this.panel1.Controls.Add(this.InfoButton);
            this.panel1.Controls.Add(this.backButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 517);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(130)))), ((int)(((byte)(70)))));
            this.panel2.Location = new System.Drawing.Point(27, 396);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(78, 1);
            this.panel2.TabIndex = 11;
            // 
            // mainFilePanel
            // 
            this.mainFilePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFilePanel.Location = new System.Drawing.Point(125, 0);
            this.mainFilePanel.Name = "mainFilePanel";
            this.mainFilePanel.Size = new System.Drawing.Size(675, 517);
            this.mainFilePanel.TabIndex = 5;
            // 
            // OptionsButton
            // 
            this.OptionsButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.OptionsButton.ChangeColorMouseHC = true;
            this.OptionsButton.DisplayText = "Настройки";
            this.OptionsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OptionsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OptionsButton.ForeColor = System.Drawing.Color.White;
            this.OptionsButton.Location = new System.Drawing.Point(0, 439);
            this.OptionsButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.OptionsButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(122, 35);
            this.OptionsButton.TabIndex = 13;
            this.OptionsButton.Text = "Настройки";
            this.OptionsButton.TextLocation_X = 25;
            this.OptionsButton.TextLocation_Y = 8;
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // AccountButton
            // 
            this.AccountButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.AccountButton.ChangeColorMouseHC = true;
            this.AccountButton.DisplayText = "Аккаунт";
            this.AccountButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AccountButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccountButton.ForeColor = System.Drawing.Color.White;
            this.AccountButton.Location = new System.Drawing.Point(0, 404);
            this.AccountButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.AccountButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.AccountButton.Name = "AccountButton";
            this.AccountButton.Size = new System.Drawing.Size(122, 35);
            this.AccountButton.TabIndex = 12;
            this.AccountButton.Text = "Аккаунт";
            this.AccountButton.TextLocation_X = 25;
            this.AccountButton.TextLocation_Y = 8;
            this.AccountButton.UseVisualStyleBackColor = true;
            this.AccountButton.Click += new System.EventHandler(this.AccountButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.CloseButton.ChangeColorMouseHC = true;
            this.CloseButton.DisplayText = "Закрыть";
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(0, 355);
            this.CloseButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.CloseButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(122, 35);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.TextLocation_X = 25;
            this.CloseButton.TextLocation_Y = 8;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.ExportButton.ChangeColorMouseHC = true;
            this.ExportButton.DisplayText = "Экспорт";
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExportButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExportButton.ForeColor = System.Drawing.Color.White;
            this.ExportButton.Location = new System.Drawing.Point(0, 320);
            this.ExportButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ExportButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(122, 35);
            this.ExportButton.TabIndex = 9;
            this.ExportButton.Text = "Экспорт";
            this.ExportButton.TextLocation_X = 25;
            this.ExportButton.TextLocation_Y = 8;
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // ShareButton
            // 
            this.ShareButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.ShareButton.ChangeColorMouseHC = true;
            this.ShareButton.DisplayText = "Импорт";
            this.ShareButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShareButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareButton.ForeColor = System.Drawing.Color.White;
            this.ShareButton.Location = new System.Drawing.Point(0, 285);
            this.ShareButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ShareButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.ShareButton.Name = "ShareButton";
            this.ShareButton.Size = new System.Drawing.Size(122, 35);
            this.ShareButton.TabIndex = 8;
            this.ShareButton.Text = "Импорт";
            this.ShareButton.TextLocation_X = 25;
            this.ShareButton.TextLocation_Y = 8;
            this.ShareButton.UseVisualStyleBackColor = true;
            this.ShareButton.Click += new System.EventHandler(this.ShareButton_Click);
            // 
            // PrintButton
            // 
            this.PrintButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.PrintButton.ChangeColorMouseHC = true;
            this.PrintButton.DisplayText = "Печать";
            this.PrintButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrintButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.ForeColor = System.Drawing.Color.White;
            this.PrintButton.Location = new System.Drawing.Point(0, 250);
            this.PrintButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.PrintButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(122, 35);
            this.PrintButton.TabIndex = 7;
            this.PrintButton.Text = "Печать";
            this.PrintButton.TextLocation_X = 25;
            this.PrintButton.TextLocation_Y = 8;
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // SaveAsButton
            // 
            this.SaveAsButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.SaveAsButton.ChangeColorMouseHC = true;
            this.SaveAsButton.DisplayText = "Сохранить как";
            this.SaveAsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveAsButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAsButton.ForeColor = System.Drawing.Color.White;
            this.SaveAsButton.Location = new System.Drawing.Point(1, 215);
            this.SaveAsButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.SaveAsButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.SaveAsButton.Name = "SaveAsButton";
            this.SaveAsButton.Size = new System.Drawing.Size(122, 35);
            this.SaveAsButton.TabIndex = 6;
            this.SaveAsButton.Text = "Сохранить как";
            this.SaveAsButton.TextLocation_X = 25;
            this.SaveAsButton.TextLocation_Y = 8;
            this.SaveAsButton.UseVisualStyleBackColor = true;
            this.SaveAsButton.Click += new System.EventHandler(this.SaveAsButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.SaveButton.ChangeColorMouseHC = true;
            this.SaveButton.DisplayText = "Сохранить";
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(0, 180);
            this.SaveButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.SaveButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(122, 35);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.TextLocation_X = 25;
            this.SaveButton.TextLocation_Y = 8;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OpenButton
            // 
            this.OpenButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.OpenButton.ChangeColorMouseHC = true;
            this.OpenButton.DisplayText = "Открыть";
            this.OpenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenButton.ForeColor = System.Drawing.Color.White;
            this.OpenButton.Location = new System.Drawing.Point(0, 145);
            this.OpenButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.OpenButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.OpenButton.Name = "OpenButton";
            this.OpenButton.Size = new System.Drawing.Size(125, 35);
            this.OpenButton.TabIndex = 4;
            this.OpenButton.Text = "Открыть";
            this.OpenButton.TextLocation_X = 25;
            this.OpenButton.TextLocation_Y = 8;
            this.OpenButton.UseVisualStyleBackColor = true;
            this.OpenButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // NewButton
            // 
            this.NewButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.NewButton.ChangeColorMouseHC = true;
            this.NewButton.DisplayText = "Новый";
            this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.ForeColor = System.Drawing.Color.White;
            this.NewButton.Location = new System.Drawing.Point(0, 110);
            this.NewButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.NewButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(125, 35);
            this.NewButton.TabIndex = 3;
            this.NewButton.Text = "Новый";
            this.NewButton.TextLocation_X = 25;
            this.NewButton.TextLocation_Y = 8;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // InfoButton
            // 
            this.InfoButton.BZBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.InfoButton.ChangeColorMouseHC = true;
            this.InfoButton.DisplayText = "О проекте";
            this.InfoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoButton.ForeColor = System.Drawing.Color.White;
            this.InfoButton.Location = new System.Drawing.Point(0, 75);
            this.InfoButton.MouseClickColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.InfoButton.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(50)))), ((int)(((byte)(20)))));
            this.InfoButton.Name = "InfoButton";
            this.InfoButton.Size = new System.Drawing.Size(125, 35);
            this.InfoButton.TabIndex = 2;
            this.InfoButton.Text = "О проекте";
            this.InfoButton.TextLocation_X = 25;
            this.InfoButton.TextLocation_Y = 8;
            this.InfoButton.UseVisualStyleBackColor = true;
            this.InfoButton.Click += new System.EventHandler(this.InfoButton_Click);
            // 
            // backButton1
            // 
            this.backButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton1.ForeColor = System.Drawing.Color.White;
            this.backButton1.Location = new System.Drawing.Point(17, 3);
            this.backButton1.MouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(160)))), ((int)(((byte)(140)))));
            this.backButton1.Name = "backButton1";
            this.backButton1.Size = new System.Drawing.Size(50, 45);
            this.backButton1.TabIndex = 1;
            this.backButton1.Text = "backButton1";
            this.backButton1.UseVisualStyleBackColor = true;
            this.backButton1.Click += new System.EventHandler(this.backButton1_Click);
            // 
            // FileOptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainFilePanel);
            this.Controls.Add(this.panel1);
            this.Name = "FileOptionsControl";
            this.Size = new System.Drawing.Size(800, 517);
            this.Load += new System.EventHandler(this.FileOptionsControl_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private BackButton backButton1;
        private OptionButton InfoButton;
        private OptionButton NewButton;
        private System.Windows.Forms.Panel panel2;
        private OptionButton CloseButton;
        private OptionButton ExportButton;
        private OptionButton ShareButton;
        private OptionButton PrintButton;
        private OptionButton SaveAsButton;
        private OptionButton SaveButton;
        private OptionButton OpenButton;
        private OptionButton OptionsButton;
        private OptionButton AccountButton;
        private System.Windows.Forms.Panel mainFilePanel;
    }
}
