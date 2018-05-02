namespace Airline
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.searchBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.flightInfo = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.from = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.to = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearRp = new Bunifu.Framework.UI.BunifuDropdown();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.label4 = new System.Windows.Forms.Label();
            this.bunifuDropdown2 = new Bunifu.Framework.UI.BunifuDropdown();
            this.cl1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.flightInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(133, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "From: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(151, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "To: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label3.Location = new System.Drawing.Point(72, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Departure Date";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuDatepicker1.BorderRadius = 7;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(227, 195);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(255, 29);
            this.bunifuDatepicker1.TabIndex = 3;
            this.bunifuDatepicker1.Value = new System.DateTime(2018, 4, 9, 0, 1, 18, 460);
            // 
            // searchBt
            // 
            this.searchBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
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
            this.searchBt.Location = new System.Drawing.Point(227, 305);
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
            // 
            // flightInfo
            // 
            this.flightInfo.AllowUserToAddRows = false;
            this.flightInfo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.flightInfo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.flightInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightInfo.BackgroundColor = System.Drawing.Color.White;
            this.flightInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.flightInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.flightInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.from,
            this.to,
            this.time,
            this.price,
            this.cl1,
            this.Column1});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flightInfo.DefaultCellStyle = dataGridViewCellStyle3;
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
            this.flightInfo.Size = new System.Drawing.Size(745, 155);
            this.flightInfo.TabIndex = 8;
            this.flightInfo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // stt
            // 
            this.stt.HeaderText = "Flight Code";
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            // 
            // from
            // 
            this.from.HeaderText = "From";
            this.from.Name = "from";
            this.from.ReadOnly = true;
            // 
            // to
            // 
            this.to.HeaderText = "To";
            this.to.Name = "to";
            this.to.ReadOnly = true;
            // 
            // time
            // 
            this.time.HeaderText = "Departure Time";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            // 
            // price
            // 
            this.price.HeaderText = "Price";
            this.price.Name = "price";
            this.price.ReadOnly = true;
            // 
            // yearRp
            // 
            this.yearRp.BackColor = System.Drawing.Color.Transparent;
            this.yearRp.BorderRadius = 3;
            this.yearRp.Cursor = System.Windows.Forms.Cursors.Default;
            this.yearRp.DisabledColor = System.Drawing.Color.Gray;
            this.yearRp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearRp.ForeColor = System.Drawing.Color.White;
            this.yearRp.Items = new string[] {
        "HCM",
        "HN"};
            this.yearRp.Location = new System.Drawing.Point(227, 91);
            this.yearRp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearRp.Name = "yearRp";
            this.yearRp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.yearRp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.yearRp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearRp.selectedIndex = 0;
            this.yearRp.Size = new System.Drawing.Size(187, 31);
            this.yearRp.TabIndex = 9;
            this.yearRp.onItemSelected += new System.EventHandler(this.yearRp_onItemSelected);
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "HCM",
        "HN"};
            this.bunifuDropdown1.Location = new System.Drawing.Point(227, 141);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuDropdown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuDropdown1.selectedIndex = 1;
            this.bunifuDropdown1.Size = new System.Drawing.Size(187, 31);
            this.bunifuDropdown1.TabIndex = 10;
            this.bunifuDropdown1.onItemSelected += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label4.Location = new System.Drawing.Point(75, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Departure Time";
            // 
            // bunifuDropdown2
            // 
            this.bunifuDropdown2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown2.BorderRadius = 3;
            this.bunifuDropdown2.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuDropdown2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown2.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown2.Items = new string[0];
            this.bunifuDropdown2.Location = new System.Drawing.Point(227, 248);
            this.bunifuDropdown2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdown2.Name = "bunifuDropdown2";
            this.bunifuDropdown2.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuDropdown2.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuDropdown2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuDropdown2.selectedIndex = -1;
            this.bunifuDropdown2.Size = new System.Drawing.Size(187, 31);
            this.bunifuDropdown2.TabIndex = 12;
            // 
            // cl1
            // 
            this.cl1.HeaderText = "No. 1st class tickets left";
            this.cl1.Name = "cl1";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "No. 2nd class tickets left";
            this.Column1.Name = "Column1";
            // 
            // SearchControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuDropdown2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.yearRp);
            this.Controls.Add(this.flightInfo);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SearchControl";
            this.Size = new System.Drawing.Size(775, 593);
            this.Load += new System.EventHandler(this.SearchControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flightInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private Bunifu.Framework.UI.BunifuFlatButton searchBt;
        private Bunifu.Framework.UI.BunifuCustomDataGrid flightInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn from;
        private System.Windows.Forms.DataGridViewTextBoxColumn to;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private Bunifu.Framework.UI.BunifuDropdown yearRp;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cl1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}
