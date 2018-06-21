﻿namespace Airline
{
    partial class SearchControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker = new Bunifu.Framework.UI.BunifuDatepicker();
            this.searchBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flightInfo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fromStation = new Bunifu.Framework.UI.BunifuDropdown();
            this.toStation = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.gioKhoiHanh = new Bunifu.Framework.UI.BunifuDropdown();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From: ";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(120, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "To: ";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(38, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date:";
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.datePicker.BorderRadius = 3;
            this.datePicker.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(189, 166);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(246, 31);
            this.datePicker.TabIndex = 3;
            this.datePicker.Value = new System.DateTime(2018, 6, 1, 0, 1, 18, 460);
            // 
            // searchBt
            // 
            this.searchBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.searchBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBt.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.searchBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.searchBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.searchBt.BorderRadius = 7;
            this.searchBt.ButtonText = "Search";
            this.searchBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBt.DisabledColor = System.Drawing.Color.Gray;
            this.searchBt.Iconcolor = System.Drawing.Color.Transparent;
            this.searchBt.Iconimage = ((System.Drawing.Image)(resources.GetObject("searchBt.Iconimage")));
            this.searchBt.Iconimage_right = null;
            this.searchBt.Iconimage_right_Selected = null;
            this.searchBt.Iconimage_Selected = null;
            this.searchBt.IconMarginLeft = 0;
            this.searchBt.IconMarginRight = 0;
            this.searchBt.IconRightVisible = true;
            this.searchBt.IconRightZoom = 0D;
            this.searchBt.IconVisible = true;
            this.searchBt.IconZoom = 65D;
            this.searchBt.IsTab = true;
            this.searchBt.Location = new System.Drawing.Point(189, 278);
            this.searchBt.Name = "searchBt";
            this.searchBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.searchBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.searchBt.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBt.selected = false;
            this.searchBt.Size = new System.Drawing.Size(93, 35);
            this.searchBt.TabIndex = 7;
            this.searchBt.Text = "Search";
            this.searchBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBt.Textcolor = System.Drawing.Color.White;
            this.searchBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBt.Click += new System.EventHandler(this.searchBt_Click);
            // 
            // flightInfo
            // 
            this.flightInfo.AllowUserToAddRows = false;
            this.flightInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flightInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.flightInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.flightInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightInfo.BackgroundColor = System.Drawing.Color.White;
            this.flightInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.flightInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.from,
            this.to,
            this.time,
            this.cl1,
            this.price,
            this.Column1,
            this.price2});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flightInfo.DefaultCellStyle = dataGridViewCellStyle6;
            this.flightInfo.DoubleBuffered = true;
            this.flightInfo.EnableHeadersVisualStyles = false;
            this.flightInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.flightInfo.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.flightInfo.HeaderForeColor = System.Drawing.Color.White;
            this.flightInfo.Location = new System.Drawing.Point(15, 346);
            this.flightInfo.Name = "flightInfo";
            this.flightInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.flightInfo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.flightInfo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.flightInfo.Size = new System.Drawing.Size(583, 188);
            this.flightInfo.TabIndex = 8;
            this.flightInfo.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.flightInfo_RowHeaderMouseDoubleClick);
            this.flightInfo.SelectionChanged += new System.EventHandler(this.flightInfo_SelectionChanged);
            // 
            // stt
            // 
            this.stt.DataPropertyName = "MACHUYENBAY";
            this.stt.HeaderText = "Flight Code";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // from
            // 
            this.from.DataPropertyName = "SANBAYDI";
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.DataPropertyName = "SANBAYDEN";
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // time
            // 
            this.time.DataPropertyName = "GIO";
            this.time.HeaderText = "Departure Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // cl1
            // 
            this.cl1.DataPropertyName = "HANG1CONLAI";
            this.cl1.HeaderText = "No. 1st class";
            this.cl1.Name = "cl1";
            this.cl1.ReadOnly = true;
            // 
            // price
            // 
            this.price.DataPropertyName = "GIAVEHANG1";
            this.price.HeaderText = "Price 1st Class";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "HANG2CONLAI";
            this.Column1.HeaderText = "No. 2nd class";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // price2
            // 
            this.price2.DataPropertyName = "GIAVEHANG2";
            this.price2.HeaderText = "Price 2nd Class";
            this.price2.Name = "price2";
            this.price2.ReadOnly = true;
            // 
            // fromStation
            // 
            this.fromStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fromStation.BackColor = System.Drawing.Color.Transparent;
            this.fromStation.BorderRadius = 3;
            this.fromStation.Cursor = System.Windows.Forms.Cursors.Default;
            this.fromStation.DisabledColor = System.Drawing.Color.Gray;
            this.fromStation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fromStation.ForeColor = System.Drawing.Color.White;
            this.fromStation.Items = new string[] {
        "..."};
            this.fromStation.Location = new System.Drawing.Point(189, 60);
            this.fromStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromStation.Name = "fromStation";
            this.fromStation.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.fromStation.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.fromStation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fromStation.selectedIndex = 0;
            this.fromStation.Size = new System.Drawing.Size(246, 31);
            this.fromStation.TabIndex = 10;
            this.fromStation.onItemSelected += new System.EventHandler(this.fromStation_onItemSelected);
            // 
            // toStation
            // 
            this.toStation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.toStation.BackColor = System.Drawing.Color.Transparent;
            this.toStation.BorderRadius = 3;
            this.toStation.DisabledColor = System.Drawing.Color.Gray;
            this.toStation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toStation.ForeColor = System.Drawing.Color.White;
            this.toStation.Items = new string[] {
        "..."};
            this.toStation.Location = new System.Drawing.Point(189, 110);
            this.toStation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toStation.Name = "toStation";
            this.toStation.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.toStation.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.toStation.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toStation.selectedIndex = 0;
            this.toStation.Size = new System.Drawing.Size(246, 31);
            this.toStation.TabIndex = 10;
            this.toStation.onItemSelected += new System.EventHandler(this.toStation_onItemSelected);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(40, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Departure Time:";
            // 
            // gioKhoiHanh
            // 
            this.gioKhoiHanh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gioKhoiHanh.BackColor = System.Drawing.Color.Transparent;
            this.gioKhoiHanh.BorderRadius = 3;
            this.gioKhoiHanh.Cursor = System.Windows.Forms.Cursors.Default;
            this.gioKhoiHanh.DisabledColor = System.Drawing.Color.Gray;
            this.gioKhoiHanh.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gioKhoiHanh.ForeColor = System.Drawing.Color.White;
            this.gioKhoiHanh.Items = new string[] {
        "..."};
            this.gioKhoiHanh.Location = new System.Drawing.Point(189, 217);
            this.gioKhoiHanh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gioKhoiHanh.Name = "gioKhoiHanh";
            this.gioKhoiHanh.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.gioKhoiHanh.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.gioKhoiHanh.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.gioKhoiHanh.selectedIndex = 0;
            this.gioKhoiHanh.Size = new System.Drawing.Size(246, 31);
            this.gioKhoiHanh.TabIndex = 12;
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.gioKhoiHanh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.toStation);
            this.Controls.Add(this.fromStation);
            this.Controls.Add(this.flightInfo);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(617, 550);
            ((System.ComponentModel.ISupportInitialize)(this.flightInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker datePicker;
        private Bunifu.Framework.UI.BunifuFlatButton searchBt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid flightInfo;
        private Bunifu.Framework.UI.BunifuDropdown fromStation;
        private Bunifu.Framework.UI.BunifuDropdown toStation;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown gioKhoiHanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn price2;
    }
}