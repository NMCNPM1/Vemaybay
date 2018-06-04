using Bunifu.Framework.UI;

namespace Airline
{
    partial class SaleControl
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleControl));
            this.contactName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.phoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bookBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.contactDrD = new Bunifu.Framework.UI.BunifuDropdown();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.backSearch = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SuspendLayout();
            // 
            // contactName
            // 
            this.contactName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactName.ForeColor = System.Drawing.Color.Black;
            this.contactName.HintForeColor = System.Drawing.Color.DimGray;
            this.contactName.HintText = "FULL NAME";
            this.contactName.isPassword = false;
            this.contactName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.contactName.LineIdleColor = System.Drawing.Color.Gray;
            this.contactName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.contactName.LineThickness = 3;
            this.contactName.Location = new System.Drawing.Point(247, 163);
            this.contactName.Margin = new System.Windows.Forms.Padding(4);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(260, 33);
            this.contactName.TabIndex = 2;
            this.contactName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneNumber.ForeColor = System.Drawing.Color.Black;
            this.phoneNumber.HintForeColor = System.Drawing.Color.DimGray;
            this.phoneNumber.HintText = "PHONE NUMBER";
            this.phoneNumber.isPassword = false;
            this.phoneNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.phoneNumber.LineIdleColor = System.Drawing.Color.Gray;
            this.phoneNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.phoneNumber.LineThickness = 3;
            this.phoneNumber.Location = new System.Drawing.Point(247, 204);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(260, 33);
            this.phoneNumber.TabIndex = 7;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eMail
            // 
            this.eMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.eMail.ForeColor = System.Drawing.Color.Black;
            this.eMail.HintForeColor = System.Drawing.Color.DimGray;
            this.eMail.HintText = "EMAIL";
            this.eMail.isPassword = false;
            this.eMail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.eMail.LineIdleColor = System.Drawing.Color.Gray;
            this.eMail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.eMail.LineThickness = 3;
            this.eMail.Location = new System.Drawing.Point(247, 327);
            this.eMail.Margin = new System.Windows.Forms.Padding(4);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(260, 33);
            this.eMail.TabIndex = 8;
            this.eMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookBt
            // 
            this.bookBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bookBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bookBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bookBt.BorderRadius = 7;
            this.bookBt.ButtonText = "  Book";
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
            this.bookBt.Location = new System.Drawing.Point(247, 383);
            this.bookBt.Name = "bookBt";
            this.bookBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bookBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bookBt.OnHoverTextColor = System.Drawing.Color.White;
            this.bookBt.selected = false;
            this.bookBt.Size = new System.Drawing.Size(112, 52);
            this.bookBt.TabIndex = 9;
            this.bookBt.Text = "  Book";
            this.bookBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bookBt.Textcolor = System.Drawing.Color.White;
            this.bookBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookBt.Click += new System.EventHandler(this.bookBt_Click);
            // 
            // contactDrD
            // 
            this.contactDrD.BackColor = System.Drawing.Color.Transparent;
            this.contactDrD.BorderRadius = 3;
            this.contactDrD.DisabledColor = System.Drawing.Color.Gray;
            this.contactDrD.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactDrD.ForeColor = System.Drawing.Color.White;
            this.contactDrD.Items = new string[] {
        "Mr.",
        "Mrs."};
            this.contactDrD.Location = new System.Drawing.Point(140, 165);
            this.contactDrD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contactDrD.Name = "contactDrD";
            this.contactDrD.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.contactDrD.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.contactDrD.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.contactDrD.selectedIndex = 0;
            this.contactDrD.Size = new System.Drawing.Size(87, 31);
            this.contactDrD.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passenger Infomation:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ID
            // 
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.HintForeColor = System.Drawing.Color.DimGray;
            this.ID.HintText = "ID";
            this.ID.isPassword = false;
            this.ID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.ID.LineIdleColor = System.Drawing.Color.Gray;
            this.ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.ID.LineThickness = 3;
            this.ID.Location = new System.Drawing.Point(247, 286);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(260, 33);
            this.ID.TabIndex = 11;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address
            // 
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Address.ForeColor = System.Drawing.Color.Black;
            this.Address.HintForeColor = System.Drawing.Color.DimGray;
            this.Address.HintText = "ADDRESS";
            this.Address.isPassword = false;
            this.Address.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.Address.LineIdleColor = System.Drawing.Color.Gray;
            this.Address.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.Address.LineThickness = 3;
            this.Address.Location = new System.Drawing.Point(247, 245);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(260, 33);
            this.Address.TabIndex = 12;
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backSearch
            // 
            this.backSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.backSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.backSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.backSearch.BorderRadius = 7;
            this.backSearch.ButtonText = "Back to Search";
            this.backSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backSearch.DisabledColor = System.Drawing.Color.Gray;
            this.backSearch.Iconcolor = System.Drawing.Color.Transparent;
            this.backSearch.Iconimage = ((System.Drawing.Image)(resources.GetObject("backSearch.Iconimage")));
            this.backSearch.Iconimage_right = null;
            this.backSearch.Iconimage_right_Selected = null;
            this.backSearch.Iconimage_Selected = null;
            this.backSearch.IconMarginLeft = 0;
            this.backSearch.IconMarginRight = 0;
            this.backSearch.IconRightVisible = true;
            this.backSearch.IconRightZoom = 0D;
            this.backSearch.IconVisible = true;
            this.backSearch.IconZoom = 70D;
            this.backSearch.IsTab = true;
            this.backSearch.Location = new System.Drawing.Point(382, 383);
            this.backSearch.Name = "backSearch";
            this.backSearch.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.backSearch.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.backSearch.OnHoverTextColor = System.Drawing.Color.White;
            this.backSearch.selected = false;
            this.backSearch.Size = new System.Drawing.Size(112, 52);
            this.backSearch.TabIndex = 13;
            this.backSearch.Text = "Back to Search";
            this.backSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.backSearch.Textcolor = System.Drawing.Color.White;
            this.backSearch.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backSearch.Visible = false;
            this.backSearch.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(515, 165);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "*";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(515, 204);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "*";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(515, 245);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "*";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(515, 286);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "*";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(494, 507);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel5.TabIndex = 18;
            this.bunifuCustomLabel5.Text = "*";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(515, 507);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(80, 20);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Obligatory";
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuCustomLabel6);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.backSearch);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.bookBt);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.contactDrD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactName);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(617, 550);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox contactName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eMail;
        private Bunifu.Framework.UI.BunifuFlatButton bookBt;
        private Bunifu.Framework.UI.BunifuDropdown contactDrD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Address;
        private Bunifu.Framework.UI.BunifuFlatButton backSearch;
        private SearchControl backToSearch;
        private BunifuCustomLabel bunifuCustomLabel1;
        private BunifuCustomLabel bunifuCustomLabel2;
        private BunifuCustomLabel bunifuCustomLabel3;
        private BunifuCustomLabel bunifuCustomLabel4;
        private BunifuCustomLabel bunifuCustomLabel5;
        private BunifuCustomLabel bunifuCustomLabel6;

        public BunifuFlatButton BackSearch { get => backSearch; set => backSearch = value; }
    }
}
