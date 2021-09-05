namespace WarehouseAccounting.DropDownMenu
{
    partial class DropDownMenuSelling
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
            this.bBackClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bBackClient
            // 
            this.bBackClient.BackColor = System.Drawing.Color.White;
            this.bBackClient.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bBackClient.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bBackClient.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bBackClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBackClient.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBackClient.Image = global::WarehouseAccounting.Properties.Resources.back_arrow_41px;
            this.bBackClient.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bBackClient.Location = new System.Drawing.Point(0, 0);
            this.bBackClient.Name = "bBackClient";
            this.bBackClient.Size = new System.Drawing.Size(235, 50);
            this.bBackClient.TabIndex = 8;
            this.bBackClient.Text = "Возврат клиенту";
            this.bBackClient.UseVisualStyleBackColor = false;
            this.bBackClient.Click += new System.EventHandler(this.BBackClient_Click);
            // 
            // DropDownMenuSelling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 50);
            this.ControlBox = false;
            this.Controls.Add(this.bBackClient);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DropDownMenuSelling";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DropDownMenuSellings";
            this.MouseLeave += new System.EventHandler(this.DropDownMenuSelling_MouseLeave);
            this.MouseHover += new System.EventHandler(this.DropDownMenuSelling_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bBackClient;
    }
}