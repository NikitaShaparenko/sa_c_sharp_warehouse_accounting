namespace WarehouseAccounting.DropDownMenu
{
    partial class DropDownMenuBuying
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
            this.bOutCart = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bOutCart
            // 
            this.bOutCart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bOutCart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bOutCart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bOutCart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOutCart.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOutCart.Image = global::WarehouseAccounting.Properties.Resources.outcart41px;
            this.bOutCart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bOutCart.Location = new System.Drawing.Point(0, 0);
            this.bOutCart.Name = "bOutCart";
            this.bOutCart.Size = new System.Drawing.Size(235, 50);
            this.bOutCart.TabIndex = 7;
            this.bOutCart.Text = "Возврат поставщику";
            this.bOutCart.UseVisualStyleBackColor = true;
            this.bOutCart.Click += new System.EventHandler(this.BOutCart_Click);
            // 
            // DropDownMenuBuying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(235, 50);
            this.Controls.Add(this.bOutCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "DropDownMenuBuying";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "DropDownMenuBuying";
            this.MouseLeave += new System.EventHandler(this.DropDownMenuBuying_MouseLeave);
            this.MouseHover += new System.EventHandler(this.DropDownMenuBuying_MouseHover);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bOutCart;
    }
}