namespace Airline
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.searchBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bookBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.changeBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.closeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.reportControl1 = new Airline.ReportControl();
            this.ruleChangeControl1 = new Airline.RuleChangeControl();
            this.databaseControl1 = new Airline.DatabaseControl();
            this.saleControl1 = new Airline.SaleControl();
            this.searchControl1 = new Airline.SearchControl();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 630);
            this.panel1.TabIndex = 0;
            this.panel1.MouseLeave += new System.EventHandler(this.panel1_MouseLeave);
            this.panel1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // searchBt
            // 
            this.searchBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.searchBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.searchBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBt.BorderRadius = 0;
            this.searchBt.ButtonText = "  Flight Info";
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
            this.searchBt.IconZoom = 70D;
            this.searchBt.IsTab = true;
            this.searchBt.Location = new System.Drawing.Point(0, 178);
            this.searchBt.Name = "searchBt";
            this.searchBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.searchBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.searchBt.OnHoverTextColor = System.Drawing.Color.White;
            this.searchBt.selected = false;
            this.searchBt.Size = new System.Drawing.Size(200, 53);
            this.searchBt.TabIndex = 1;
            this.searchBt.Text = "  Flight Info";
            this.searchBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchBt.Textcolor = System.Drawing.Color.White;
            this.searchBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBt.Click += new System.EventHandler(this.saleBt_Click);
            this.searchBt.MouseHover += new System.EventHandler(this.searchBt_MouseHover);
            // 
            // bookBt
            // 
            this.bookBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bookBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bookBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookBt.BorderRadius = 0;
            this.bookBt.ButtonText = "  Book Trip";
            this.bookBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookBt.DisabledColor = System.Drawing.Color.Gray;
            this.bookBt.Iconcolor = System.Drawing.Color.Transparent;
            this.bookBt.Iconimage = ((System.Drawing.Image)(resources.GetObject("bookBt.Iconimage")));
            this.bookBt.Iconimage_right = null;
            this.bookBt.Iconimage_right_Selected = null;
            this.bookBt.Iconimage_Selected = null;
            this.bookBt.IconMarginLeft = 0;
            this.bookBt.IconMarginRight = 0;
            this.bookBt.IconRightVisible = true;
            this.bookBt.IconRightZoom = 0D;
            this.bookBt.IconVisible = true;
            this.bookBt.IconZoom = 70D;
            this.bookBt.IsTab = true;
            this.bookBt.Location = new System.Drawing.Point(0, 231);
            this.bookBt.Name = "bookBt";
            this.bookBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bookBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bookBt.OnHoverTextColor = System.Drawing.Color.White;
            this.bookBt.selected = false;
            this.bookBt.Size = new System.Drawing.Size(200, 53);
            this.bookBt.TabIndex = 2;
            this.bookBt.Text = "  Book Trip";
            this.bookBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookBt.Textcolor = System.Drawing.Color.White;
            this.bookBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBt.Click += new System.EventHandler(this.bookBt_Click);
            // 
            // dataBt
            // 
            this.dataBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.dataBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.dataBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataBt.BorderRadius = 0;
            this.dataBt.ButtonText = "  Database Update";
            this.dataBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataBt.DisabledColor = System.Drawing.Color.Gray;
            this.dataBt.Iconcolor = System.Drawing.Color.Transparent;
            this.dataBt.Iconimage = ((System.Drawing.Image)(resources.GetObject("dataBt.Iconimage")));
            this.dataBt.Iconimage_right = null;
            this.dataBt.Iconimage_right_Selected = null;
            this.dataBt.Iconimage_Selected = null;
            this.dataBt.IconMarginLeft = 0;
            this.dataBt.IconMarginRight = 0;
            this.dataBt.IconRightVisible = true;
            this.dataBt.IconRightZoom = 0D;
            this.dataBt.IconVisible = true;
            this.dataBt.IconZoom = 70D;
            this.dataBt.IsTab = true;
            this.dataBt.Location = new System.Drawing.Point(0, 284);
            this.dataBt.Name = "dataBt";
            this.dataBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.dataBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.dataBt.OnHoverTextColor = System.Drawing.Color.White;
            this.dataBt.selected = false;
            this.dataBt.Size = new System.Drawing.Size(200, 53);
            this.dataBt.TabIndex = 3;
            this.dataBt.Text = "  Database Update";
            this.dataBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBt.Textcolor = System.Drawing.Color.White;
            this.dataBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBt.Click += new System.EventHandler(this.dataBt_Click);
            // 
            // reportBt
            // 
            this.reportBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.reportBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.reportBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportBt.BorderRadius = 0;
            this.reportBt.ButtonText = " Revenue Report";
            this.reportBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.reportBt.DisabledColor = System.Drawing.Color.Gray;
            this.reportBt.Iconcolor = System.Drawing.Color.Transparent;
            this.reportBt.Iconimage = ((System.Drawing.Image)(resources.GetObject("reportBt.Iconimage")));
            this.reportBt.Iconimage_right = null;
            this.reportBt.Iconimage_right_Selected = null;
            this.reportBt.Iconimage_Selected = null;
            this.reportBt.IconMarginLeft = 0;
            this.reportBt.IconMarginRight = 0;
            this.reportBt.IconRightVisible = true;
            this.reportBt.IconRightZoom = 0D;
            this.reportBt.IconVisible = true;
            this.reportBt.IconZoom = 70D;
            this.reportBt.IsTab = true;
            this.reportBt.Location = new System.Drawing.Point(0, 337);
            this.reportBt.Name = "reportBt";
            this.reportBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.reportBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.reportBt.OnHoverTextColor = System.Drawing.Color.White;
            this.reportBt.selected = false;
            this.reportBt.Size = new System.Drawing.Size(200, 53);
            this.reportBt.TabIndex = 4;
            this.reportBt.Text = " Revenue Report";
            this.reportBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBt.Textcolor = System.Drawing.Color.White;
            this.reportBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBt.Click += new System.EventHandler(this.reportBt_Click);
            // 
            // changeBt
            // 
            this.changeBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.changeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.changeBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.changeBt.BorderRadius = 0;
            this.changeBt.ButtonText = "  Rules Change";
            this.changeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.changeBt.DisabledColor = System.Drawing.Color.Gray;
            this.changeBt.Iconcolor = System.Drawing.Color.Transparent;
            this.changeBt.Iconimage = ((System.Drawing.Image)(resources.GetObject("changeBt.Iconimage")));
            this.changeBt.Iconimage_right = null;
            this.changeBt.Iconimage_right_Selected = null;
            this.changeBt.Iconimage_Selected = null;
            this.changeBt.IconMarginLeft = 0;
            this.changeBt.IconMarginRight = 0;
            this.changeBt.IconRightVisible = true;
            this.changeBt.IconRightZoom = 0D;
            this.changeBt.IconVisible = true;
            this.changeBt.IconZoom = 70D;
            this.changeBt.IsTab = true;
            this.changeBt.Location = new System.Drawing.Point(0, 390);
            this.changeBt.Name = "changeBt";
            this.changeBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.changeBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.changeBt.OnHoverTextColor = System.Drawing.Color.White;
            this.changeBt.selected = false;
            this.changeBt.Size = new System.Drawing.Size(200, 53);
            this.changeBt.TabIndex = 5;
            this.changeBt.Text = "  Rules Change";
            this.changeBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeBt.Textcolor = System.Drawing.Color.White;
            this.changeBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeBt.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "_";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 1;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.bunifuThinButton21.Location = new System.Drawing.Point(927, -7);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.bunifuThinButton21.Size = new System.Drawing.Size(34, 35);
            this.bunifuThinButton21.TabIndex = 13;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // closeBt
            // 
            this.closeBt.ActiveBorderThickness = 1;
            this.closeBt.ActiveCornerRadius = 1;
            this.closeBt.ActiveFillColor = System.Drawing.Color.Red;
            this.closeBt.ActiveForecolor = System.Drawing.Color.White;
            this.closeBt.ActiveLineColor = System.Drawing.Color.Red;
            this.closeBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.closeBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBt.BackgroundImage")));
            this.closeBt.ButtonText = "x  ";
            this.closeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.closeBt.IdleBorderThickness = 1;
            this.closeBt.IdleCornerRadius = 1;
            this.closeBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.closeBt.IdleForecolor = System.Drawing.Color.White;
            this.closeBt.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.closeBt.Location = new System.Drawing.Point(954, -6);
            this.closeBt.Margin = new System.Windows.Forms.Padding(5);
            this.closeBt.Name = "closeBt";
            this.closeBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.closeBt.Size = new System.Drawing.Size(54, 35);
            this.closeBt.TabIndex = 12;
            this.closeBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBt.Click += new System.EventHandler(this.closeBt_Click);
            // 
            // reportControl1
            // 
            this.reportControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reportControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportControl1.Cursor = System.Windows.Forms.Cursors.No;
            this.reportControl1.Location = new System.Drawing.Point(304, 113);
            this.reportControl1.Name = "reportControl1";
            this.reportControl1.Size = new System.Drawing.Size(587, 496);
            this.reportControl1.TabIndex = 9;
            this.reportControl1.Visible = false;
            this.reportControl1.Load += new System.EventHandler(this.reportControl1_Load);
            // 
            // ruleChangeControl1
            // 
            this.ruleChangeControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ruleChangeControl1.Location = new System.Drawing.Point(304, 100);
            this.ruleChangeControl1.Name = "ruleChangeControl1";
            this.ruleChangeControl1.Size = new System.Drawing.Size(599, 494);
            this.ruleChangeControl1.TabIndex = 11;
            this.ruleChangeControl1.Visible = false;
            // 
            // databaseControl1
            // 
            this.databaseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.databaseControl1.Location = new System.Drawing.Point(304, 100);
            this.databaseControl1.Name = "databaseControl1";
            this.databaseControl1.Size = new System.Drawing.Size(599, 494);
            this.databaseControl1.TabIndex = 8;
            this.databaseControl1.Visible = false;
            // 
            // saleControl1
            // 
            this.saleControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.saleControl1.Location = new System.Drawing.Point(304, 100);
            this.saleControl1.Name = "saleControl1";
            this.saleControl1.Size = new System.Drawing.Size(599, 494);
            this.saleControl1.TabIndex = 7;
            this.saleControl1.Visible = false;
            // 
            // searchControl1
            // 
            this.searchControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.searchControl1.Location = new System.Drawing.Point(304, 100);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(599, 494);
            this.searchControl1.TabIndex = 6;
            this.searchControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1007, 630);
            this.Controls.Add(this.bunifuThinButton21);
            this.Controls.Add(this.closeBt);
            this.Controls.Add(this.reportControl1);
            this.Controls.Add(this.ruleChangeControl1);
            this.Controls.Add(this.databaseControl1);
            this.Controls.Add(this.saleControl1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.changeBt);
            this.Controls.Add(this.reportBt);
            this.Controls.Add(this.dataBt);
            this.Controls.Add(this.bookBt);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton searchBt;
        private Bunifu.Framework.UI.BunifuFlatButton bookBt;
        private Bunifu.Framework.UI.BunifuFlatButton dataBt;
        private Bunifu.Framework.UI.BunifuFlatButton reportBt;
        private Bunifu.Framework.UI.BunifuFlatButton changeBt;
        private SearchControl searchControl1;
        private SaleControl saleControl1;
        private DatabaseControl databaseControl1;
        private ReportControl reportControl1;
        private RuleChangeControl ruleChangeControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 closeBt;
    }
}

