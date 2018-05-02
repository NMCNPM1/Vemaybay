namespace Airline
{
    partial class DatabaseControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DatabaseControl));
            this.dataBt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // dataBt
            // 
            this.dataBt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.dataBt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.dataBt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dataBt.BorderRadius = 7;
            this.dataBt.ButtonText = "        Upload ";
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
            this.dataBt.Location = new System.Drawing.Point(204, 145);
            this.dataBt.Name = "dataBt";
            this.dataBt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(88)))), ((int)(((byte)(173)))));
            this.dataBt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.dataBt.OnHoverTextColor = System.Drawing.Color.White;
            this.dataBt.selected = false;
            this.dataBt.Size = new System.Drawing.Size(150, 53);
            this.dataBt.TabIndex = 4;
            this.dataBt.Text = "        Upload ";
            this.dataBt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dataBt.Textcolor = System.Drawing.Color.White;
            this.dataBt.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataBt.Click += new System.EventHandler(this.dataBt_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "Database File";
            // 
            // DatabaseControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataBt);
            this.Name = "DatabaseControl";
            this.Size = new System.Drawing.Size(599, 349);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton dataBt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
