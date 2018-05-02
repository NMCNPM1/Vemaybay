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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Month:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(224, 114);
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
            this.monthRp.Location = new System.Drawing.Point(337, 59);
            this.monthRp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.monthRp.Name = "monthRp";
            this.monthRp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.monthRp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
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
            this.yearRp.Location = new System.Drawing.Point(314, 109);
            this.yearRp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.yearRp.Name = "yearRp";
            this.yearRp.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.yearRp.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.yearRp.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.yearRp.selectedIndex = 0;
            this.yearRp.Size = new System.Drawing.Size(87, 31);
            this.yearRp.TabIndex = 8;
            // 
            // reportBt
            // 
            this.reportBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.reportBt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.reportBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
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
            this.reportBt.Location = new System.Drawing.Point(264, 174);
            this.reportBt.Name = "reportBt";
            this.reportBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.reportBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.reportBt.OnHoverTextColor = System.Drawing.Color.White;
            this.reportBt.selected = false;
            this.reportBt.Size = new System.Drawing.Size(112, 53);
            this.reportBt.TabIndex = 9;
            this.reportBt.Text = "  Export";
            this.reportBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reportBt.Textcolor = System.Drawing.Color.White;
            this.reportBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // ReportControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reportBt);
            this.Controls.Add(this.yearRp);
            this.Controls.Add(this.monthRp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportControl";
            this.Size = new System.Drawing.Size(599, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDropdown monthRp;
        private Bunifu.Framework.UI.BunifuDropdown yearRp;
        private Bunifu.Framework.UI.BunifuFlatButton reportBt;
    }
}
