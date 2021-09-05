namespace WarehouseAccounting
{
    partial class GoodCard
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
            this.goodcard_header_1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.goodcard_header_2 = new System.Windows.Forms.Label();
            this.goodcard_header_3 = new System.Windows.Forms.Label();
            this.goodcard_header_4 = new System.Windows.Forms.Label();
            this.goodcard_header_5 = new System.Windows.Forms.Label();
            this.goodcard_header_6 = new System.Windows.Forms.Label();
            this.goodcard_header_7 = new System.Windows.Forms.Label();
            this.goodcard_header_8 = new System.Windows.Forms.Label();
            this.goodcard_header_9 = new System.Windows.Forms.Label();
            this.txtShortName = new System.Windows.Forms.TextBox();
            this.txtTags = new System.Windows.Forms.TextBox();
            this.txtBarcode = new System.Windows.Forms.TextBox();
            this.txtMinReq = new System.Windows.Forms.TextBox();
            this.txtBuying = new System.Windows.Forms.TextBox();
            this.txtUpcoming = new System.Windows.Forms.TextBox();
            this.txtDefaultEnter = new System.Windows.Forms.TextBox();
            this.bSave = new System.Windows.Forms.Button();
            this.bClose = new System.Windows.Forms.Button();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.cbFast = new System.Windows.Forms.CheckBox();
            this.cbNotForSelling = new System.Windows.Forms.CheckBox();
            this.cbNotForBuying = new System.Windows.Forms.CheckBox();
            this.cbConstPrice = new System.Windows.Forms.CheckBox();
            this.cbInvisiblePrice = new System.Windows.Forms.CheckBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bMakeNext = new System.Windows.Forms.Button();
            this.txtGroup = new System.Windows.Forms.ComboBox();
            this.tlp.SuspendLayout();
            this.SuspendLayout();
            // 
            // goodcard_header_1
            // 
            this.goodcard_header_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_1.AutoSize = true;
            this.goodcard_header_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_1.Location = new System.Drawing.Point(3, 105);
            this.goodcard_header_1.Name = "goodcard_header_1";
            this.goodcard_header_1.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_1.TabIndex = 0;
            this.goodcard_header_1.Text = "Наименование";
            this.goodcard_header_1.Click += new System.EventHandler(this.Goodcard_header_1_Click);
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtName.Location = new System.Drawing.Point(216, 103);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 26);
            this.txtName.TabIndex = 1;
            this.txtName.TextChanged += new System.EventHandler(this.Txth1_TextChanged);
            // 
            // goodcard_header_2
            // 
            this.goodcard_header_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_2.AutoSize = true;
            this.goodcard_header_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_2.Location = new System.Drawing.Point(3, 135);
            this.goodcard_header_2.Name = "goodcard_header_2";
            this.goodcard_header_2.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_2.TabIndex = 2;
            this.goodcard_header_2.Text = "Сокращение";
            // 
            // goodcard_header_3
            // 
            this.goodcard_header_3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_3.AutoSize = true;
            this.goodcard_header_3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_3.Location = new System.Drawing.Point(3, 165);
            this.goodcard_header_3.Name = "goodcard_header_3";
            this.goodcard_header_3.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_3.TabIndex = 3;
            this.goodcard_header_3.Text = "Теги";
            // 
            // goodcard_header_4
            // 
            this.goodcard_header_4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_4.AutoSize = true;
            this.goodcard_header_4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_4.Location = new System.Drawing.Point(3, 195);
            this.goodcard_header_4.Name = "goodcard_header_4";
            this.goodcard_header_4.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_4.TabIndex = 4;
            this.goodcard_header_4.Text = "Штрихкод";
            // 
            // goodcard_header_5
            // 
            this.goodcard_header_5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_5.AutoSize = true;
            this.goodcard_header_5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_5.Location = new System.Drawing.Point(3, 225);
            this.goodcard_header_5.Name = "goodcard_header_5";
            this.goodcard_header_5.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_5.TabIndex = 5;
            this.goodcard_header_5.Text = "Минимальная заявка";
            // 
            // goodcard_header_6
            // 
            this.goodcard_header_6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_6.AutoSize = true;
            this.goodcard_header_6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_6.Location = new System.Drawing.Point(3, 255);
            this.goodcard_header_6.Name = "goodcard_header_6";
            this.goodcard_header_6.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_6.TabIndex = 6;
            this.goodcard_header_6.Text = "Закупка";
            // 
            // goodcard_header_7
            // 
            this.goodcard_header_7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_7.AutoSize = true;
            this.goodcard_header_7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_7.Location = new System.Drawing.Point(3, 285);
            this.goodcard_header_7.Name = "goodcard_header_7";
            this.goodcard_header_7.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_7.TabIndex = 7;
            this.goodcard_header_7.Text = "Наценка";
            // 
            // goodcard_header_8
            // 
            this.goodcard_header_8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_8.AutoSize = true;
            this.goodcard_header_8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_8.Location = new System.Drawing.Point(3, 315);
            this.goodcard_header_8.Name = "goodcard_header_8";
            this.goodcard_header_8.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_8.TabIndex = 8;
            this.goodcard_header_8.Text = "Группа";
            // 
            // goodcard_header_9
            // 
            this.goodcard_header_9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.goodcard_header_9.AutoSize = true;
            this.goodcard_header_9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goodcard_header_9.Location = new System.Drawing.Point(3, 345);
            this.goodcard_header_9.Name = "goodcard_header_9";
            this.goodcard_header_9.Size = new System.Drawing.Size(207, 20);
            this.goodcard_header_9.TabIndex = 9;
            this.goodcard_header_9.Text = "Ввод по умолчанию";
            // 
            // txtShortName
            // 
            this.txtShortName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtShortName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtShortName.Location = new System.Drawing.Point(216, 133);
            this.txtShortName.Name = "txtShortName";
            this.txtShortName.Size = new System.Drawing.Size(207, 26);
            this.txtShortName.TabIndex = 11;
            // 
            // txtTags
            // 
            this.txtTags.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTags.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtTags.Location = new System.Drawing.Point(216, 163);
            this.txtTags.Name = "txtTags";
            this.txtTags.Size = new System.Drawing.Size(207, 26);
            this.txtTags.TabIndex = 12;
            // 
            // txtBarcode
            // 
            this.txtBarcode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBarcode.Location = new System.Drawing.Point(216, 193);
            this.txtBarcode.Name = "txtBarcode";
            this.txtBarcode.Size = new System.Drawing.Size(207, 26);
            this.txtBarcode.TabIndex = 13;
            // 
            // txtMinReq
            // 
            this.txtMinReq.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMinReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtMinReq.Location = new System.Drawing.Point(216, 223);
            this.txtMinReq.Name = "txtMinReq";
            this.txtMinReq.Size = new System.Drawing.Size(207, 26);
            this.txtMinReq.TabIndex = 14;
            // 
            // txtBuying
            // 
            this.txtBuying.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBuying.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBuying.Location = new System.Drawing.Point(216, 253);
            this.txtBuying.Name = "txtBuying";
            this.txtBuying.Size = new System.Drawing.Size(207, 26);
            this.txtBuying.TabIndex = 15;
            // 
            // txtUpcoming
            // 
            this.txtUpcoming.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUpcoming.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtUpcoming.Location = new System.Drawing.Point(216, 283);
            this.txtUpcoming.Name = "txtUpcoming";
            this.txtUpcoming.Size = new System.Drawing.Size(207, 26);
            this.txtUpcoming.TabIndex = 16;
            // 
            // txtDefaultEnter
            // 
            this.txtDefaultEnter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDefaultEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtDefaultEnter.Location = new System.Drawing.Point(216, 343);
            this.txtDefaultEnter.Name = "txtDefaultEnter";
            this.txtDefaultEnter.Size = new System.Drawing.Size(207, 26);
            this.txtDefaultEnter.TabIndex = 18;
            this.txtDefaultEnter.TextChanged += new System.EventHandler(this.Txth9_TextChanged);
            // 
            // bSave
            // 
            this.bSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bSave.Location = new System.Drawing.Point(160, 389);
            this.bSave.Name = "bSave";
            this.bSave.Size = new System.Drawing.Size(153, 36);
            this.bSave.TabIndex = 19;
            this.bSave.Text = "gc_b1";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.BSave_Click);
            // 
            // bClose
            // 
            this.bClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bClose.Location = new System.Drawing.Point(324, 389);
            this.bClose.Name = "bClose";
            this.bClose.Size = new System.Drawing.Size(153, 36);
            this.bClose.TabIndex = 20;
            this.bClose.Text = "gc_b2";
            this.bClose.UseVisualStyleBackColor = true;
            this.bClose.Click += new System.EventHandler(this.BClose_Click);
            // 
            // tlp
            // 
            this.tlp.ColumnCount = 3;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 150F));
            this.tlp.Controls.Add(this.cbFast, 2, 5);
            this.tlp.Controls.Add(this.cbNotForSelling, 2, 6);
            this.tlp.Controls.Add(this.cbNotForBuying, 2, 7);
            this.tlp.Controls.Add(this.cbConstPrice, 2, 8);
            this.tlp.Controls.Add(this.cbInvisiblePrice, 2, 9);
            this.tlp.Controls.Add(this.txtCode, 1, 0);
            this.tlp.Controls.Add(this.goodcard_header_1, 0, 1);
            this.tlp.Controls.Add(this.txtName, 1, 1);
            this.tlp.Controls.Add(this.txtShortName, 1, 2);
            this.tlp.Controls.Add(this.goodcard_header_9, 0, 9);
            this.tlp.Controls.Add(this.txtTags, 1, 3);
            this.tlp.Controls.Add(this.txtBarcode, 1, 4);
            this.tlp.Controls.Add(this.txtUpcoming, 1, 7);
            this.tlp.Controls.Add(this.goodcard_header_8, 0, 8);
            this.tlp.Controls.Add(this.txtMinReq, 1, 5);
            this.tlp.Controls.Add(this.goodcard_header_7, 0, 7);
            this.tlp.Controls.Add(this.txtBuying, 1, 6);
            this.tlp.Controls.Add(this.goodcard_header_2, 0, 2);
            this.tlp.Controls.Add(this.goodcard_header_3, 0, 3);
            this.tlp.Controls.Add(this.goodcard_header_6, 0, 6);
            this.tlp.Controls.Add(this.goodcard_header_4, 0, 4);
            this.tlp.Controls.Add(this.goodcard_header_5, 0, 5);
            this.tlp.Controls.Add(this.txtDefaultEnter, 1, 9);
            this.tlp.Controls.Add(this.label1, 0, 0);
            this.tlp.Controls.Add(this.bMakeNext, 2, 0);
            this.tlp.Controls.Add(this.txtGroup, 1, 8);
            this.tlp.Location = new System.Drawing.Point(12, 12);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 10;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tlp.Size = new System.Drawing.Size(576, 371);
            this.tlp.TabIndex = 21;
            // 
            // cbFast
            // 
            this.cbFast.AutoSize = true;
            this.cbFast.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbFast.Location = new System.Drawing.Point(429, 223);
            this.cbFast.Name = "cbFast";
            this.cbFast.Size = new System.Drawing.Size(92, 24);
            this.cbFast.TabIndex = 22;
            this.cbFast.Text = "быстрый";
            this.cbFast.UseVisualStyleBackColor = true;
            // 
            // cbNotForSelling
            // 
            this.cbNotForSelling.AutoSize = true;
            this.cbNotForSelling.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNotForSelling.Location = new System.Drawing.Point(429, 253);
            this.cbNotForSelling.Name = "cbNotForSelling";
            this.cbNotForSelling.Size = new System.Drawing.Size(125, 24);
            this.cbNotForSelling.TabIndex = 23;
            this.cbNotForSelling.Text = "не продавать";
            this.cbNotForSelling.UseVisualStyleBackColor = true;
            this.cbNotForSelling.CheckedChanged += new System.EventHandler(this.CbNotForSelling_CheckedChanged);
            // 
            // cbNotForBuying
            // 
            this.cbNotForBuying.AutoSize = true;
            this.cbNotForBuying.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbNotForBuying.Location = new System.Drawing.Point(429, 283);
            this.cbNotForBuying.Name = "cbNotForBuying";
            this.cbNotForBuying.Size = new System.Drawing.Size(116, 24);
            this.cbNotForBuying.TabIndex = 24;
            this.cbNotForBuying.Text = "не покупать";
            this.cbNotForBuying.UseVisualStyleBackColor = true;
            // 
            // cbConstPrice
            // 
            this.cbConstPrice.AutoSize = true;
            this.cbConstPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbConstPrice.Location = new System.Drawing.Point(429, 313);
            this.cbConstPrice.Name = "cbConstPrice";
            this.cbConstPrice.Size = new System.Drawing.Size(144, 24);
            this.cbConstPrice.TabIndex = 25;
            this.cbConstPrice.Text = "постоянный ценник";
            this.cbConstPrice.UseVisualStyleBackColor = true;
            // 
            // cbInvisiblePrice
            // 
            this.cbInvisiblePrice.AutoSize = true;
            this.cbInvisiblePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cbInvisiblePrice.Location = new System.Drawing.Point(429, 343);
            this.cbInvisiblePrice.Name = "cbInvisiblePrice";
            this.cbInvisiblePrice.Size = new System.Drawing.Size(144, 25);
            this.cbInvisiblePrice.TabIndex = 26;
            this.cbInvisiblePrice.Text = "не печатать ценник";
            this.cbInvisiblePrice.UseVisualStyleBackColor = true;
            // 
            // txtCode
            // 
            this.txtCode.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtCode.Location = new System.Drawing.Point(216, 3);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(207, 26);
            this.txtCode.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(170, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 21);
            this.label1.TabIndex = 19;
            this.label1.Text = "Код:";
            // 
            // bMakeNext
            // 
            this.bMakeNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bMakeNext.Location = new System.Drawing.Point(429, 3);
            this.bMakeNext.Name = "bMakeNext";
            this.bMakeNext.Size = new System.Drawing.Size(144, 52);
            this.bMakeNext.TabIndex = 21;
            this.bMakeNext.Text = "Создать следующий";
            this.bMakeNext.UseVisualStyleBackColor = true;
            this.bMakeNext.Click += new System.EventHandler(this.BMakeNext_Click);
            // 
            // txtGroup
            // 
            this.txtGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtGroup.FormattingEnabled = true;
            this.txtGroup.Location = new System.Drawing.Point(216, 313);
            this.txtGroup.Name = "txtGroup";
            this.txtGroup.Size = new System.Drawing.Size(207, 28);
            this.txtGroup.TabIndex = 27;
            // 
            // GoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 433);
            this.Controls.Add(this.tlp);
            this.Controls.Add(this.bClose);
            this.Controls.Add(this.bSave);
            this.MinimumSize = new System.Drawing.Size(484, 394);
            this.Name = "GoodCard";
            this.Text = "gc_fh$";
            this.Load += new System.EventHandler(this.GoodCard_Load);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label goodcard_header_1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label goodcard_header_2;
        private System.Windows.Forms.Label goodcard_header_3;
        private System.Windows.Forms.Label goodcard_header_4;
        private System.Windows.Forms.Label goodcard_header_5;
        private System.Windows.Forms.Label goodcard_header_6;
        private System.Windows.Forms.Label goodcard_header_7;
        private System.Windows.Forms.Label goodcard_header_8;
        private System.Windows.Forms.Label goodcard_header_9;
        private System.Windows.Forms.TextBox txtShortName;
        private System.Windows.Forms.TextBox txtTags;
        private System.Windows.Forms.TextBox txtBarcode;
        private System.Windows.Forms.TextBox txtMinReq;
        private System.Windows.Forms.TextBox txtBuying;
        private System.Windows.Forms.TextBox txtUpcoming;
        private System.Windows.Forms.TextBox txtDefaultEnter;
        private System.Windows.Forms.Button bSave;
        private System.Windows.Forms.Button bClose;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbNotForBuying;
        private System.Windows.Forms.CheckBox cbConstPrice;
        private System.Windows.Forms.CheckBox cbInvisiblePrice;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button bMakeNext;
        private System.Windows.Forms.CheckBox cbFast;
        private System.Windows.Forms.CheckBox cbNotForSelling;
        public System.Windows.Forms.ComboBox txtGroup;
    }
}