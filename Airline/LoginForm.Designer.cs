namespace Airline
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.closeBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tbUser = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btLogin = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeBt
            // 
            this.closeBt.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.closeBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.closeBt.BorderRadius = 0;
            this.closeBt.ButtonText = " x";
            this.closeBt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeBt.DisabledColor = System.Drawing.Color.Gray;
            this.closeBt.Iconcolor = System.Drawing.Color.Transparent;
            this.closeBt.Iconimage = null;
            this.closeBt.Iconimage_right = null;
            this.closeBt.Iconimage_right_Selected = null;
            this.closeBt.Iconimage_Selected = null;
            this.closeBt.IconMarginLeft = 0;
            this.closeBt.IconMarginRight = 0;
            this.closeBt.IconRightVisible = true;
            this.closeBt.IconRightZoom = 0D;
            this.closeBt.IconVisible = true;
            this.closeBt.IconZoom = 90D;
            this.closeBt.IsTab = false;
            this.closeBt.Location = new System.Drawing.Point(328, 1);
            this.closeBt.Name = "closeBt";
            this.closeBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.closeBt.OnHovercolor = System.Drawing.Color.Red;
            this.closeBt.OnHoverTextColor = System.Drawing.Color.White;
            this.closeBt.selected = false;
            this.closeBt.Size = new System.Drawing.Size(56, 29);
            this.closeBt.TabIndex = 0;
            this.closeBt.Text = " x";
            this.closeBt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.closeBt.Textcolor = System.Drawing.Color.White;
            this.closeBt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeBt.Click += new System.EventHandler(this.closeBt_Click);
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = " _";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(291, 1);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.LightGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(38, 29);
            this.bunifuFlatButton1.TabIndex = 1;
            this.bunifuFlatButton1.Text = " _";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.CornflowerBlue;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // tbUser
            // 
            this.tbUser.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbUser.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbUser.ForeColor = System.Drawing.Color.Black;
            this.tbUser.HintForeColor = System.Drawing.Color.Empty;
            this.tbUser.HintText = "USERNAME";
            this.tbUser.isPassword = false;
            this.tbUser.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbUser.LineIdleColor = System.Drawing.Color.CornflowerBlue;
            this.tbUser.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbUser.LineThickness = 3;
            this.tbUser.Location = new System.Drawing.Point(68, 164);
            this.tbUser.Margin = new System.Windows.Forms.Padding(4);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(236, 33);
            this.tbUser.TabIndex = 4;
            this.tbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbUser.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbUser_KeyDown);
            // 
            // tbPassword
            // 
            this.tbPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tbPassword.ForeColor = System.Drawing.Color.Black;
            this.tbPassword.HintForeColor = System.Drawing.Color.Empty;
            this.tbPassword.HintText = "";
            this.tbPassword.isPassword = true;
            this.tbPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbPassword.LineIdleColor = System.Drawing.Color.CornflowerBlue;
            this.tbPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.tbPassword.LineThickness = 3;
            this.tbPassword.Location = new System.Drawing.Point(68, 207);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(236, 33);
            this.tbPassword.TabIndex = 5;
            this.tbPassword.Text = "@@@@@@@@";
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.Enter += new System.EventHandler(this.tbPassword_Enter);
            this.tbPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPassword_KeyDown);
            this.tbPassword.Leave += new System.EventHandler(this.tbPassword_Leave);
            // 
            // btLogin
            // 
            this.btLogin.Activecolor = System.Drawing.Color.MidnightBlue;
            this.btLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btLogin.BorderRadius = 2;
            this.btLogin.ButtonText = "Login";
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.DisabledColor = System.Drawing.Color.Gray;
            this.btLogin.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Iconcolor = System.Drawing.Color.Transparent;
            this.btLogin.Iconimage = null;
            this.btLogin.Iconimage_right = null;
            this.btLogin.Iconimage_right_Selected = null;
            this.btLogin.Iconimage_Selected = null;
            this.btLogin.IconMarginLeft = 0;
            this.btLogin.IconMarginRight = 0;
            this.btLogin.IconRightVisible = true;
            this.btLogin.IconRightZoom = 0D;
            this.btLogin.IconVisible = true;
            this.btLogin.IconZoom = 90D;
            this.btLogin.IsTab = false;
            this.btLogin.Location = new System.Drawing.Point(152, 258);
            this.btLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btLogin.Name = "btLogin";
            this.btLogin.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btLogin.OnHovercolor = System.Drawing.Color.DarkSlateBlue;
            this.btLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btLogin.selected = false;
            this.btLogin.Size = new System.Drawing.Size(70, 36);
            this.btLogin.TabIndex = 6;
            this.btLogin.Text = "Login";
            this.btLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btLogin.Textcolor = System.Drawing.Color.White;
            this.btLogin.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(124, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(130, 130);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(312, 299);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(64, 16);
            this.name.TabIndex = 8;
            this.name.Text = "© SE Airline";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(384, 321);
            this.Controls.Add(this.name);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUser);
            this.Controls.Add(this.closeBt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton closeBt;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbUser;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbPassword;
        private Bunifu.Framework.UI.BunifuFlatButton btLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label name;
    }
}