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
            this.sex = new Bunifu.Framework.UI.BunifuDropdown();
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
            this.label1 = new System.Windows.Forms.Label();
            this.maCB = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tinhDi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tinhDen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.classInfo = new Bunifu.Framework.UI.BunifuDropdown();
            this.price = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // contactName
            // 
            this.contactName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contactName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contactName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.contactName.ForeColor = System.Drawing.Color.Black;
            this.contactName.HintForeColor = System.Drawing.Color.Empty;
            this.contactName.HintText = "FULL NAME";
            this.contactName.isPassword = false;
            this.contactName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.contactName.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.contactName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.contactName.LineThickness = 3;
            this.contactName.Location = new System.Drawing.Point(237, 197);
            this.contactName.Margin = new System.Windows.Forms.Padding(4);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(260, 33);
            this.contactName.TabIndex = 2;
            this.contactName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phoneNumber
            // 
            this.phoneNumber.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.phoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneNumber.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.phoneNumber.ForeColor = System.Drawing.Color.Black;
            this.phoneNumber.HintForeColor = System.Drawing.Color.Empty;
            this.phoneNumber.HintText = "PHONE NUMBER";
            this.phoneNumber.isPassword = false;
            this.phoneNumber.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.phoneNumber.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.phoneNumber.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.phoneNumber.LineThickness = 3;
            this.phoneNumber.Location = new System.Drawing.Point(237, 238);
            this.phoneNumber.Margin = new System.Windows.Forms.Padding(4);
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(260, 33);
            this.phoneNumber.TabIndex = 7;
            this.phoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // eMail
            // 
            this.eMail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eMail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.eMail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.eMail.ForeColor = System.Drawing.Color.Black;
            this.eMail.HintForeColor = System.Drawing.Color.Empty;
            this.eMail.HintText = "EMAIL";
            this.eMail.isPassword = false;
            this.eMail.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.eMail.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.eMail.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.eMail.LineThickness = 3;
            this.eMail.Location = new System.Drawing.Point(237, 361);
            this.eMail.Margin = new System.Windows.Forms.Padding(4);
            this.eMail.Name = "eMail";
            this.eMail.Size = new System.Drawing.Size(260, 33);
            this.eMail.TabIndex = 8;
            this.eMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bookBt
            // 
            this.bookBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.bookBt.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.bookBt.Location = new System.Drawing.Point(237, 422);
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
            // sex
            // 
            this.sex.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.sex.BackColor = System.Drawing.Color.Transparent;
            this.sex.BorderRadius = 3;
            this.sex.DisabledColor = System.Drawing.Color.Gray;
            this.sex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sex.ForeColor = System.Drawing.Color.White;
            this.sex.Items = new string[] {
        "Mr.",
        "Mrs."};
            this.sex.Location = new System.Drawing.Point(129, 197);
            this.sex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sex.Name = "sex";
            this.sex.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.sex.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.sex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.sex.selectedIndex = 0;
            this.sex.Size = new System.Drawing.Size(87, 31);
            this.sex.TabIndex = 6;
            this.sex.onItemSelected += new System.EventHandler(this.sex_onItemSelected);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 153);
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
            this.ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ID.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ID.ForeColor = System.Drawing.Color.Black;
            this.ID.HintForeColor = System.Drawing.Color.Empty;
            this.ID.HintText = "ID";
            this.ID.isPassword = false;
            this.ID.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ID.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.ID.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ID.LineThickness = 3;
            this.ID.Location = new System.Drawing.Point(237, 320);
            this.ID.Margin = new System.Windows.Forms.Padding(4);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(260, 33);
            this.ID.TabIndex = 11;
            this.ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Address
            // 
            this.Address.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Address.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Address.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.Address.ForeColor = System.Drawing.Color.Black;
            this.Address.HintForeColor = System.Drawing.Color.Empty;
            this.Address.HintText = "ADDRESS";
            this.Address.isPassword = false;
            this.Address.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Address.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.Address.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Address.LineThickness = 3;
            this.Address.Location = new System.Drawing.Point(237, 279);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(260, 33);
            this.Address.TabIndex = 12;
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // backSearch
            // 
            this.backSearch.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.backSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.backSearch.Location = new System.Drawing.Point(385, 422);
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
            this.backSearch.Click += new System.EventHandler(this.backBt_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(503, 206);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel1.TabIndex = 14;
            this.bunifuCustomLabel1.Text = "*";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(503, 245);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel2.TabIndex = 15;
            this.bunifuCustomLabel2.Text = "*";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(503, 286);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel3.TabIndex = 16;
            this.bunifuCustomLabel3.Text = "*";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(503, 327);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel4.TabIndex = 17;
            this.bunifuCustomLabel4.Text = "*";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(482, 488);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(15, 20);
            this.bunifuCustomLabel5.TabIndex = 18;
            this.bunifuCustomLabel5.Text = "*";
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.Red;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(503, 488);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(80, 20);
            this.bunifuCustomLabel6.TabIndex = 19;
            this.bunifuCustomLabel6.Text = "Obligatory";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 21);
            this.label1.TabIndex = 20;
            this.label1.Text = "Flight Infomation:";
            // 
            // maCB
            // 
            this.maCB.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maCB.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.maCB.Enabled = false;
            this.maCB.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maCB.ForeColor = System.Drawing.Color.Black;
            this.maCB.HintForeColor = System.Drawing.Color.Empty;
            this.maCB.HintText = "FLIGHT CODE";
            this.maCB.isPassword = false;
            this.maCB.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.maCB.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.maCB.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.maCB.LineThickness = 3;
            this.maCB.Location = new System.Drawing.Point(38, 29);
            this.maCB.Margin = new System.Windows.Forms.Padding(4);
            this.maCB.Name = "maCB";
            this.maCB.Size = new System.Drawing.Size(260, 33);
            this.maCB.TabIndex = 21;
            this.maCB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tinhDi
            // 
            this.tinhDi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tinhDi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tinhDi.Enabled = false;
            this.tinhDi.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhDi.ForeColor = System.Drawing.Color.Black;
            this.tinhDi.HintForeColor = System.Drawing.Color.Empty;
            this.tinhDi.HintText = "FROM";
            this.tinhDi.isPassword = false;
            this.tinhDi.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tinhDi.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.tinhDi.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tinhDi.LineThickness = 3;
            this.tinhDi.Location = new System.Drawing.Point(38, 70);
            this.tinhDi.Margin = new System.Windows.Forms.Padding(4);
            this.tinhDi.Name = "tinhDi";
            this.tinhDi.Size = new System.Drawing.Size(260, 33);
            this.tinhDi.TabIndex = 22;
            this.tinhDi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tinhDen
            // 
            this.tinhDen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tinhDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tinhDen.Enabled = false;
            this.tinhDen.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tinhDen.ForeColor = System.Drawing.Color.Black;
            this.tinhDen.HintForeColor = System.Drawing.Color.Empty;
            this.tinhDen.HintText = "TO";
            this.tinhDen.isPassword = false;
            this.tinhDen.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tinhDen.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.tinhDen.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tinhDen.LineThickness = 3;
            this.tinhDen.Location = new System.Drawing.Point(38, 111);
            this.tinhDen.Margin = new System.Windows.Forms.Padding(4);
            this.tinhDen.Name = "tinhDen";
            this.tinhDen.Size = new System.Drawing.Size(260, 33);
            this.tinhDen.TabIndex = 23;
            this.tinhDen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classInfo
            // 
            this.classInfo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.classInfo.BackColor = System.Drawing.Color.Transparent;
            this.classInfo.BorderRadius = 3;
            this.classInfo.DisabledColor = System.Drawing.Color.Gray;
            this.classInfo.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.classInfo.ForeColor = System.Drawing.Color.White;
            this.classInfo.Items = new string[] {
        "1st Class",
        "2nd Class"};
            this.classInfo.Location = new System.Drawing.Point(323, 31);
            this.classInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.classInfo.Name = "classInfo";
            this.classInfo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.classInfo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.classInfo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.classInfo.selectedIndex = 0;
            this.classInfo.Size = new System.Drawing.Size(122, 31);
            this.classInfo.TabIndex = 24;
            this.classInfo.onItemSelected += new System.EventHandler(this.classInfo_onItemSelected);
            // 
            // price
            // 
            this.price.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.price.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.price.Enabled = false;
            this.price.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.ForeColor = System.Drawing.Color.Black;
            this.price.HintForeColor = System.Drawing.Color.Empty;
            this.price.HintText = "PRICE";
            this.price.isPassword = false;
            this.price.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.price.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.price.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.price.LineThickness = 3;
            this.price.Location = new System.Drawing.Point(323, 70);
            this.price.Margin = new System.Windows.Forms.Padding(4);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(260, 33);
            this.price.TabIndex = 25;
            this.price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.price);
            this.Controls.Add(this.classInfo);
            this.Controls.Add(this.tinhDen);
            this.Controls.Add(this.tinhDi);
            this.Controls.Add(this.maCB);
            this.Controls.Add(this.label1);
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
            this.Controls.Add(this.sex);
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
        private Bunifu.Framework.UI.BunifuDropdown sex;
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
        private System.Windows.Forms.Label label1;
        private BunifuMaterialTextbox maCB;
        private BunifuMaterialTextbox tinhDi;
        private BunifuMaterialTextbox tinhDen;
        private BunifuDropdown classInfo;
        private BunifuMaterialTextbox price;

        public BunifuFlatButton BackSearch { get => backSearch; set => backSearch = value; }
        public BunifuMaterialTextbox MaCB { get => maCB; set => maCB = value; }
        public BunifuMaterialTextbox TinhDi { get => tinhDi; set => tinhDi = value; }
        public BunifuMaterialTextbox TinhDen { get => tinhDen; set => tinhDen = value; }
    }
}
