namespace Airline
{
    partial class ReportControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportControl));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthRp = new Bunifu.Framework.UI.BunifuDropdown();
            this.yearRp = new Bunifu.Framework.UI.BunifuDropdown();
            this.reportBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.listView = new System.Windows.Forms.DataGridView();
            this.MAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACHUYENBAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIAVE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.listView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(201, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month:";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Year:";
            // 
            // monthRp
            // 
            this.monthRp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.monthRp.BackColor = System.Drawing.Color.Transparent;
            this.monthRp.BorderRadius = 3;
            this.monthRp.DisabledColor = System.Drawing.Color.Gray;
            this.monthRp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthRp.ForeColor = System.Drawing.Color.White;
            this.monthRp.Items = new string[] {
        "1",
        "2",
        "3",
        "4",
        "5",
        "6",
        "7",
        "8",
        "9",
        "10",
        "11",
        "12"};
            this.monthRp.Location = new System.Drawing.Point(314, 180);
            this.monthRp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monthRp.Name = "monthRp";
            this.monthRp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.monthRp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.monthRp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.monthRp.selectedIndex = 0;
            this.monthRp.Size = new System.Drawing.Size(64, 31);
            this.monthRp.TabIndex = 7;
            // 
            // yearRp
            // 
            this.yearRp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.yearRp.BackColor = System.Drawing.Color.Transparent;
            this.yearRp.BorderRadius = 3;
            this.yearRp.DisabledColor = System.Drawing.Color.Gray;
            this.yearRp.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearRp.ForeColor = System.Drawing.Color.White;
            this.yearRp.Items = new string[] {
        "2017",
        "2018",
        "2019",
        "2020",
        "2021",
        "2022",
        "2023",
        "2024",
        "2025",
        "2026",
        "2027",
        "2028",
        "2029",
        "2030"};
            this.yearRp.Location = new System.Drawing.Point(291, 230);
            this.yearRp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearRp.Name = "yearRp";
            this.yearRp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.yearRp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.yearRp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearRp.selectedIndex = 0;
            this.yearRp.Size = new System.Drawing.Size(87, 31);
            this.yearRp.TabIndex = 8;
            // 
            // reportBt
            // 
            this.reportBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.reportBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reportBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportBt.BorderRadius = 7;
            this.reportBt.ButtonText = "  Export";
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
            this.reportBt.Location = new System.Drawing.Point(241, 295);
            this.reportBt.Name = "reportBt";
            this.reportBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reportBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.reportBt.OnHoverTextColor = System.Drawing.Color.White;
            this.reportBt.selected = false;
            this.reportBt.Size = new System.Drawing.Size(112, 53);
            this.reportBt.TabIndex = 9;
            this.reportBt.Text = "  Export";
            this.reportBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBt.Textcolor = System.Drawing.Color.White;
            this.reportBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBt.Click += new System.EventHandler(this.reportBt_Click);
            // 
            // listView
            // 
            this.listView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAVE,
            this.MACHUYENBAY,
            this.HANGVE,
            this.GIAVE});
            this.listView.Location = new System.Drawing.Point(51, 368);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(443, 73);
            this.listView.TabIndex = 10;
            this.listView.Visible = false;
            // 
            // MAVE
            // 
            this.MAVE.DataPropertyName = "MAVE";
            this.MAVE.HeaderText = "MAVE";
            this.MAVE.Name = "MAVE";
            // 
            // MACHUYENBAY
            // 
            this.MACHUYENBAY.DataPropertyName = "MACHUYENBAY";
            this.MACHUYENBAY.HeaderText = "MACHUYENBAY";
            this.MACHUYENBAY.Name = "MACHUYENBAY";
            // 
            // HANGVE
            // 
            this.HANGVE.DataPropertyName = "HANGVE";
            this.HANGVE.HeaderText = "HANGVE";
            this.HANGVE.Name = "HANGVE";
            // 
            // GIAVE
            // 
            this.GIAVE.DataPropertyName = "GIAVE";
            this.GIAVE.HeaderText = "GIAVE";
            this.GIAVE.Name = "GIAVE";
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.reportBt);
            this.Controls.Add(this.yearRp);
            this.Controls.Add(this.monthRp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(617, 550);
            this.Load += new System.EventHandler(this.ReportControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.listView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown monthRp;
        private Bunifu.Framework.UI.BunifuDropdown yearRp;
        private Bunifu.Framework.UI.BunifuFlatButton reportBt;
        private System.Windows.Forms.DataGridView listView;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACHUYENBAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGVE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIAVE;
    }
}
