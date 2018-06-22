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

        #region Form moving

        Boolean flag;
        int x;
        int y;
        private void TaskBar_MouseDown(object sender, MouseEventArgs e)
        {
            flag = true;
            x = e.X;
            y = e.Y;
        }

        private void TaskBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (flag == true)
            {
                this.SetDesktopLocation(Cursor.Position.X - x, Cursor.Position.Y - y);
            }
        }

        private void TaskBar_MouseUp(object sender, MouseEventArgs e)
        {
            flag = false;
        }

        #endregion

        #region Support Methods

        public static string ChuanHoaMa(int Code)
        {
            if (Code < 10)
            {
                return "00" + Code.ToString();
            }
            else
                if (Code < 100)
            {
                return "0" + Code.ToString();
            }
            else
                    if (Code < 1000)
            {
                return Code.ToString();
            }
            return "";
        }

        public static string ChuanHoaMaCuoi(string code)
        {
            return code.Split(' ')[0];
        }

        #endregion
    }

}
