namespace WarehouseAccounting.DropDownMenu
{
    partial class DropDownMenuAvaliable
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
            this.pProviders = new System.Windows.Forms.Button();
            this.bEnteringPreorder = new System.Windows.Forms.Button();
            this.bImages = new System.Windows.Forms.Button();
            this.bForgottenGood = new System.Windows.Forms.Button();
            this.tFocus = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pProviders
            // 
            this.pProviders.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.pProviders.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.pProviders.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.pProviders.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pProviders.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pProviders.Image = global::WarehouseAccounting.Properties.Resources.sorting41px;
            this.pProviders.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pProviders.Location = new System.Drawing.Point(2, 138);
            this.pProviders.Name = "pProviders";
            this.pProviders.Size = new System.Drawing.Size(235, 50);
            this.pProviders.TabIndex = 9;
            this.pProviders.Text = "Пересортица";
            this.pProviders.UseVisualStyleBackColor = true;
            this.pProviders.Click += new System.EventHandler(this.PSorting_Click);
            // 
            // bEnteringPreorder
            // 
            this.bEnteringPreorder.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bEnteringPreorder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bEnteringPreorder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bEnteringPreorder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEnteringPreorder.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnteringPreorder.Image = global::WarehouseAccounting.Properties.Resources.EnteringPreorder41px;
            this.bEnteringPreorder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEnteringPreorder.Location = new System.Drawing.Point(2, 46);
            this.bEnteringPreorder.Name = "bEnteringPreorder";
            this.bEnteringPreorder.Size = new System.Drawing.Size(235, 50);
            this.bEnteringPreorder.TabIndex = 8;
            this.bEnteringPreorder.Text = "Ввод остатков";
            this.bEnteringPreorder.UseVisualStyleBackColor = true;
            this.bEnteringPreorder.Click += new System.EventHandler(this.bEnteringPreorder_Click);
            // 
            // bImages
            // 
            this.bImages.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bImages.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bImages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bImages.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bImages.Image = global::WarehouseAccounting.Properties.Resources.revision41px;
            this.bImages.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bImages.Location = new System.Drawing.Point(2, 92);
            this.bImages.Name = "bImages";
            this.bImages.Size = new System.Drawing.Size(235, 50);
            this.bImages.TabIndex = 7;
            this.bImages.Text = "Ревизия";
            this.bImages.UseVisualStyleBackColor = true;
            this.bImages.Click += new System.EventHandler(this.BRevizion_Click);
            // 
            // bForgottenGood
            // 
            this.bForgottenGood.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bForgottenGood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bForgottenGood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bForgottenGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bForgottenGood.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bForgottenGood.Image = global::WarehouseAccounting.Properties.Resources.forgottengood41px;
            this.bForgottenGood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bForgottenGood.Location = new System.Drawing.Point(2, 0);
            this.bForgottenGood.Name = "bForgottenGood";
            this.bForgottenGood.Size = new System.Drawing.Size(235, 50);
            this.bForgottenGood.TabIndex = 6;
            this.bForgottenGood.Text = "Списание";
            this.bForgottenGood.UseVisualStyleBackColor = true;
            this.bForgottenGood.Click += new System.EventHandler(this.BForgottenGood_Click);
            // 
            // tFocus
            // 
            this.tFocus.Enabled = true;
            this.tFocus.Tick += new System.EventHandler(this.TFocus_Tick);
            // 
            // DropDownMenuAvaliable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(237, 190);
            this.Controls.Add(this.pProviders);
            this.Controls.Add(this.bEnteringPreorder);
            this.Controls.Add(this.bImages);
            this.Controls.Add(this.bForgottenGood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DropDownMenuAvaliable";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DropDownMenuAvaliable";
            this.MouseLeave += new System.EventHandler(this.DropDownMenuAvaliable_MouseLeave);
            this.MouseHover += new System.EventHandler(this.DropDownMenuAvaliable_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pProviders;
        private System.Windows.Forms.Button bEnteringPreorder;
        private System.Windows.Forms.Button bImages;
        private System.Windows.Forms.Button bForgottenGood;
        private System.Windows.Forms.Timer tFocus;
    }
}