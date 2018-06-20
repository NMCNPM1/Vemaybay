using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Form1 : Form
    {
        #region INIT

        public Form1()
        {
            InitializeComponent();       
        }

        #endregion

        #region Main button
        
        private void saleBt_Click(object sender, EventArgs e)
        {
            searchControl1.Visible = true;
            searchControl1.LoadData();
            searchControl1.BringToFront();
        }

        private void dataBt_Click(object sender, EventArgs e)
        {
            databaseControl1.Visible = true;
            databaseControl1.BringToFront();
        }

        private void reportBt_Click(object sender, EventArgs e)
        {
            reportControl1.Visible = true;
            reportControl1.BringToFront();
        }

        private void changeBt_Click(object sender, EventArgs e)
        {
            ruleChangeControl1.Visible = true;
            ruleChangeControl1.BringToFront();
        }

        #endregion

        #region Phím chức năng

        private void closeBt_Click(object sender, EventArgs e)
        {
            LoginForm.Connection.CloseConn();
            this.Close();
        }

        private void minimizeBt_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        #endregion
    }
   
}
