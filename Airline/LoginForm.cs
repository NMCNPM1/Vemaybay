using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class LoginForm : Form
    {
        #region INIT
        public static string accountName;
        private static ConnectToSQL connection;

        internal static ConnectToSQL Connection { get => connection; set => connection = value; }
        public string AccountName { get => accountName; set => accountName = value; }

        public LoginForm()
        {
            Connection = new ConnectToSQL();
            Connection.OpenConn();
            InitializeComponent();
            tbPassword.isPassword = true;
        }

        #endregion

        #region Main Event      

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPassword.Text;
            accountName = tbUser.Text;

            string sql = "SELECT TENNGUOIDUNG, MATKHAU, LOAINGUOIDUNG FROM NGUOIDUNG WHERE TENNGUOIDUNG = '"
                + username + "' AND MATKHAU = '" + password + "'";

            DataTable dataTable = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(sql, Connection.Connection);

            data.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
                MessageBox.Show("Incorrect username or password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                this.Hide();
                Form1 form = new Form1();
                form.Show();
                 
            }
        }

        private void tbPassword_Leave(object sender, EventArgs e)
        {
            if (tbPassword.Text == "")
            {
                tbPassword.Text = "@@@@@@@@";
            }
        }

        private void tbPassword_Enter(object sender, EventArgs e)
        {
            if (tbPassword.Text == "@@@@@@@@")
                tbPassword.Text = "";
        }

        private void tbUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = tbUser.Text;
                string password = tbPassword.Text;
                accountName = username;

                string sql = "SELECT TENNGUOIDUNG, MATKHAU, LOAINGUOIDUNG FROM NGUOIDUNG WHERE TENNGUOIDUNG = '"
                    + username + "' AND MATKHAU = '" + password + "'";

                DataTable dataTable = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(sql, Connection.Connection);

                data.Fill(dataTable);

                if (dataTable.Rows.Count == 0)
                    MessageBox.Show("Incorrect username or password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    data.Dispose();
                    this.Hide();
                    Form1 form = new Form1();                    
                    form.Show();
                    
                }
            }

        }

        private void tbPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string username = tbUser.Text;
                string password = tbPassword.Text;
                accountName = username;

                string sql = "SELECT TENNGUOIDUNG, MATKHAU, LOAINGUOIDUNG FROM NGUOIDUNG WHERE TENNGUOIDUNG = '"
                    + username + "' AND MATKHAU = '" + password + "'";

                DataTable dataTable = new DataTable();
                SqlDataAdapter data = new SqlDataAdapter(sql, Connection.Connection);


                data.Fill(dataTable);


                if (dataTable.Rows.Count == 0)
                    MessageBox.Show("Incorrect username or password !", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    data.Dispose();
                    this.Hide();
                    Form1 form1 = new Form1();
                    form1.Show();
                    
                }
            }
        }

        #endregion

        #region ON - OFF

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void closeBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #endregion
    }
}
