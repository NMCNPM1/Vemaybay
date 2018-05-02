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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleControl));
            this.label1 = new System.Windows.Forms.Label();
            this.contactName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.listSex = new Bunifu.Framework.UI.BunifuDropdown();
            this.phoneNumber = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.eMail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bookBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDropdown1 = new Bunifu.Framework.UI.BunifuDropdown();
            this.passengerName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.flightCode = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(95, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Passenger Infomation:";
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
            this.contactName.Location = new System.Drawing.Point(251, 163);
            this.contactName.Margin = new System.Windows.Forms.Padding(4);
            this.contactName.Name = "contactName";
            this.contactName.Size = new System.Drawing.Size(260, 33);
            this.contactName.TabIndex = 2;
            this.contactName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listSex
            // 
            this.listSex.BackColor = System.Drawing.Color.Transparent;
            this.listSex.BorderRadius = 3;
            this.listSex.DisabledColor = System.Drawing.Color.Gray;
            this.listSex.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSex.ForeColor = System.Drawing.Color.White;
            this.listSex.Items = new string[] {
        "Mr.",
        "Mrs."};
            this.listSex.Location = new System.Drawing.Point(115, 95);
            this.listSex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listSex.Name = "listSex";
            this.listSex.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.listSex.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.listSex.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.listSex.selectedIndex = 0;
            this.listSex.Size = new System.Drawing.Size(87, 31);
            this.listSex.TabIndex = 5;
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
            this.phoneNumber.Location = new System.Drawing.Point(251, 204);
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
            this.eMail.Location = new System.Drawing.Point(251, 245);
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
            this.bookBt.Location = new System.Drawing.Point(251, 296);
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
            // 
            // bunifuDropdown1
            // 
            this.bunifuDropdown1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuDropdown1.BorderRadius = 3;
            this.bunifuDropdown1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDropdown1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuDropdown1.ForeColor = System.Drawing.Color.White;
            this.bunifuDropdown1.Items = new string[] {
        "Mr.",
        "Mrs."};
            this.bunifuDropdown1.Location = new System.Drawing.Point(115, 165);
            this.bunifuDropdown1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuDropdown1.Name = "bunifuDropdown1";
            this.bunifuDropdown1.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuDropdown1.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.bunifuDropdown1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuDropdown1.selectedIndex = 0;
            this.bunifuDropdown1.Size = new System.Drawing.Size(87, 31);
            this.bunifuDropdown1.TabIndex = 6;
            // 
            // passengerName
            // 
            this.passengerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.passengerName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.passengerName.ForeColor = System.Drawing.Color.Black;
            this.passengerName.HintForeColor = System.Drawing.Color.DimGray;
            this.passengerName.HintText = "FULL NAME";
            this.passengerName.isPassword = false;
            this.passengerName.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.passengerName.LineIdleColor = System.Drawing.Color.Gray;
            this.passengerName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.passengerName.LineThickness = 3;
            this.passengerName.Location = new System.Drawing.Point(251, 93);
            this.passengerName.Margin = new System.Windows.Forms.Padding(4);
            this.passengerName.Name = "passengerName";
            this.passengerName.Size = new System.Drawing.Size(260, 33);
            this.passengerName.TabIndex = 0;
            this.passengerName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(95, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contact Infomation:";
            // 
            // flightCode
            // 
            this.flightCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.flightCode.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.flightCode.ForeColor = System.Drawing.Color.Black;
            this.flightCode.HintForeColor = System.Drawing.Color.DimGray;
            this.flightCode.HintText = "FLIGHT CODE";
            this.flightCode.isPassword = false;
            this.flightCode.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.flightCode.LineIdleColor = System.Drawing.Color.Gray;
            this.flightCode.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.flightCode.LineThickness = 3;
            this.flightCode.Location = new System.Drawing.Point(251, 31);
            this.flightCode.Margin = new System.Windows.Forms.Padding(4);
            this.flightCode.Name = "flightCode";
            this.flightCode.Size = new System.Drawing.Size(260, 33);
            this.flightCode.TabIndex = 10;
            this.flightCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SaleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flightCode);
            this.Controls.Add(this.bookBt);
            this.Controls.Add(this.eMail);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.bunifuDropdown1);
            this.Controls.Add(this.listSex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contactName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passengerName);
            this.Name = "SaleControl";
            this.Size = new System.Drawing.Size(684, 462);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox contactName;
        private Bunifu.Framework.UI.BunifuDropdown listSex;
        private Bunifu.Framework.UI.BunifuMaterialTextbox phoneNumber;
        private Bunifu.Framework.UI.BunifuMaterialTextbox eMail;
        private Bunifu.Framework.UI.BunifuFlatButton bookBt;
        private Bunifu.Framework.UI.BunifuDropdown bunifuDropdown1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox passengerName;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox flightCode;
    }
}
