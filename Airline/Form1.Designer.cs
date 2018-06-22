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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.searchBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dataBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.reportBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.changeBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.minimizeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.closeBt = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.TaskBar = new System.Windows.Forms.Panel();
            this.searchControl1 = new Airline.SearchControl();
            this.reportControl1 = new Airline.ReportControl();
            this.ruleChangeControl1 = new Airline.RuleChangeControl();
            this.databaseControl1 = new Airline.DatabaseControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.TaskBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.searchBt);
            this.panel1.Controls.Add(this.dataBt);
            this.panel1.Controls.Add(this.reportBt);
            this.panel1.Controls.Add(this.changeBt);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 630);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(197, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.searchBt.Location = new System.Drawing.Point(3, 178);
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
            this.dataBt.Location = new System.Drawing.Point(3, 237);
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
            this.reportBt.Location = new System.Drawing.Point(3, 296);
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
            this.changeBt.Location = new System.Drawing.Point(3, 355);
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
            this.changeBt.Click += new System.EventHandler(this.changeBt_Click);
            // 
            // minimizeBt
            // 
            this.minimizeBt.ActiveBorderThickness = 1;
            this.minimizeBt.ActiveCornerRadius = 20;
            this.minimizeBt.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.minimizeBt.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.minimizeBt.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.minimizeBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBt.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("minimizeBt.BackgroundImage")));
            this.minimizeBt.ButtonText = "_";
            this.minimizeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimizeBt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.minimizeBt.IdleBorderThickness = 1;
            this.minimizeBt.IdleCornerRadius = 1;
            this.minimizeBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.minimizeBt.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.minimizeBt.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.minimizeBt.Location = new System.Drawing.Point(899, 0);
            this.minimizeBt.Margin = new System.Windows.Forms.Padding(5);
            this.minimizeBt.Name = "minimizeBt";
            this.minimizeBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.minimizeBt.Size = new System.Drawing.Size(58, 34);
            this.minimizeBt.TabIndex = 13;
            this.minimizeBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.minimizeBt.Click += new System.EventHandler(this.minimizeBt_Click);
            // 
            // closeBt
            // 
            this.closeBt.ActiveBorderThickness = 1;
            this.closeBt.ActiveCornerRadius = 1;
            this.closeBt.ActiveFillColor = System.Drawing.Color.Red;
            this.closeBt.ActiveForecolor = System.Drawing.Color.White;
            this.closeBt.ActiveLineColor = System.Drawing.Color.Red;
            this.closeBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeBt.BackColor = System.Drawing.Color.Transparent;
            this.closeBt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("closeBt.BackgroundImage")));
            this.closeBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.closeBt.ButtonText = "x  ";
            this.closeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBt.ForeColor = System.Drawing.Color.SeaGreen;
            this.closeBt.IdleBorderThickness = 1;
            this.closeBt.IdleCornerRadius = 1;
            this.closeBt.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.closeBt.IdleForecolor = System.Drawing.Color.White;
            this.closeBt.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.closeBt.Location = new System.Drawing.Point(954, -5);
            this.closeBt.Margin = new System.Windows.Forms.Padding(5);
            this.closeBt.Name = "closeBt";
            this.closeBt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.closeBt.Size = new System.Drawing.Size(54, 43);
            this.closeBt.TabIndex = 12;
            this.closeBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBt.Click += new System.EventHandler(this.closeBt_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(200, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 602);
            this.panel2.TabIndex = 14;
            // 
            // TaskBar
            // 
            this.TaskBar.BackColor = System.Drawing.Color.Transparent;
            this.TaskBar.Controls.Add(this.closeBt);
            this.TaskBar.Controls.Add(this.minimizeBt);
            this.TaskBar.Location = new System.Drawing.Point(0, 0);
            this.TaskBar.Name = "TaskBar";
            this.TaskBar.Size = new System.Drawing.Size(1008, 34);
            this.TaskBar.TabIndex = 15;
            this.TaskBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TaskBar_MouseDown);
            this.TaskBar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TaskBar_MouseMove);
            this.TaskBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TaskBar_MouseUp);
            // 
            // searchControl1
            // 
            this.searchControl1.BackColor = System.Drawing.SystemColors.Control;
            this.searchControl1.Location = new System.Drawing.Point(200, 28);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Size = new System.Drawing.Size(807, 602);
            this.searchControl1.TabIndex = 16;
            this.searchControl1.Visible = false;
            // 
            // reportControl1
            // 
            this.reportControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.reportControl1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.reportControl1.Cursor = System.Windows.Forms.Cursors.No;
            this.reportControl1.Location = new System.Drawing.Point(200, 28);
            this.reportControl1.Name = "reportControl1";
            this.reportControl1.Size = new System.Drawing.Size(807, 602);
            this.reportControl1.TabIndex = 9;
            this.reportControl1.Visible = false;
            // 
            // ruleChangeControl1
            // 
            this.ruleChangeControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ruleChangeControl1.Location = new System.Drawing.Point(200, 28);
            this.ruleChangeControl1.Name = "ruleChangeControl1";
            this.ruleChangeControl1.Size = new System.Drawing.Size(807, 602);
            this.ruleChangeControl1.TabIndex = 11;
            this.ruleChangeControl1.Visible = false;
            // 
            // databaseControl1
            // 
            this.databaseControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.databaseControl1.Location = new System.Drawing.Point(200, 28);
            this.databaseControl1.Name = "databaseControl1";
            this.databaseControl1.Size = new System.Drawing.Size(807, 602);
            this.databaseControl1.TabIndex = 8;
            this.databaseControl1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(235)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1007, 630);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.reportControl1);
            this.Controls.Add(this.ruleChangeControl1);
            this.Controls.Add(this.databaseControl1);
            this.Controls.Add(this.TaskBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.TaskBar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton searchBt;
        private Bunifu.Framework.UI.BunifuFlatButton dataBt;
        private Bunifu.Framework.UI.BunifuFlatButton reportBt;
        private Bunifu.Framework.UI.BunifuFlatButton changeBt;
        private DatabaseControl databaseControl1;
        private ReportControl reportControl1;
        private RuleChangeControl ruleChangeControl1;
        private Bunifu.Framework.UI.BunifuThinButton2 minimizeBt;
        private Bunifu.Framework.UI.BunifuThinButton2 closeBt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel TaskBar;
        private SearchControl searchControl1;
    }
}

