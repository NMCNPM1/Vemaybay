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
            this.flightCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CMND = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Address = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.contactName.Location = new System.Drawing.Point(251, 99);
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
            this.phoneNumber.Location = new System.Drawing.Point(251, 140);
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
            this.eMail.Location = new System.Drawing.Point(251, 263);
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
            this.bookBt.Location = new System.Drawing.Point(251, 319);
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
            this.contactDrD.Location = new System.Drawing.Point(118, 120);
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
            this.label2.Location = new System.Drawing.Point(76, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Passenger Infomation:";
            // 
            // flightCode
            // 
            this.flightCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.flightCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.flightCode.ForeColor = System.Drawing.Color.Black;
            this.flightCode.HintForeColor = System.Drawing.Color.DimGray;
            this.flightCode.HintText = "PASSENGER CODE";
            this.flightCode.isPassword = false;
            this.flightCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.flightCode.LineIdleColor = System.Drawing.Color.Gray;
            this.flightCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.flightCode.LineThickness = 3;
            this.flightCode.Location = new System.Drawing.Point(251, 58);
            this.flightCode.Margin = new System.Windows.Forms.Padding(4);
            this.flightCode.Name = "flightCode";
            this.flightCode.Size = new System.Drawing.Size(260, 33);
            this.flightCode.TabIndex = 10;
            this.flightCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // CMND
            // 
            this.CMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CMND.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CMND.ForeColor = System.Drawing.Color.Black;
            this.CMND.HintForeColor = System.Drawing.Color.DimGray;
            this.CMND.HintText = "ID";
            this.CMND.isPassword = false;
            this.CMND.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.CMND.LineIdleColor = System.Drawing.Color.Gray;
            this.CMND.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.CMND.LineThickness = 3;
            this.CMND.Location = new System.Drawing.Point(251, 222);
            this.CMND.Margin = new System.Windows.Forms.Padding(4);
            this.CMND.Name = "CMND";
            this.CMND.Size = new System.Drawing.Size(260, 33);
            this.CMND.TabIndex = 11;
            this.CMND.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.Address.Location = new System.Drawing.Point(251, 181);
            this.Address.Margin = new System.Windows.Forms.Padding(4);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(260, 33);
            this.Address.TabIndex = 12;
            this.Address.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Address);
            this.Controls.Add(this.CMND);
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.bookBt);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.contactDrD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactName);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(684, 462);
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
        private Bunifu.Framework.UI.BunifuMaterialTextbox flightCode;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CMND;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Address;
    }
}
