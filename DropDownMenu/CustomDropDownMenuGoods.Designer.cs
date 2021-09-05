namespace WarehouseAccounting.DropDownMenu
{
    partial class CustomDropDownMenuGoods
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
            this.button1 = new System.Windows.Forms.Button();
            this.bForgottenGood = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::WarehouseAccounting.Properties.Resources.pics41px;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(2, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(235, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Рисунки";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bForgottenGood
            // 
            this.bForgottenGood.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bForgottenGood.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bForgottenGood.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(240)))), ((int)(((byte)(250)))));
            this.bForgottenGood.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bForgottenGood.Font = new System.Drawing.Font("Microsoft YaHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bForgottenGood.Image = global::WarehouseAccounting.Properties.Resources.barcode41px;
            this.bForgottenGood.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bForgottenGood.Location = new System.Drawing.Point(2, 0);
            this.bForgottenGood.Name = "bForgottenGood";
            this.bForgottenGood.Size = new System.Drawing.Size(235, 50);
            this.bForgottenGood.TabIndex = 7;
            this.bForgottenGood.Text = "Штрих коды";
            this.bForgottenGood.UseVisualStyleBackColor = true;
            // 
            // CustomDropDownMenuGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(237, 98);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.bForgottenGood);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomDropDownMenuGoods";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bForgottenGood;
        private System.Windows.Forms.Button button1;
    }
}