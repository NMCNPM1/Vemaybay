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

        private static ConnectToSQL connection;

        internal static ConnectToSQL Connection { get => connection; set => connection = value; }

        public LoginForm()
        {
            Connection = new ConnectToSQL();
            Connection.OpenConn();
            InitializeComponent();
            tbPassword.isPassword = true;
        }

        private void closeBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btLogin_Click(object sender, EventArgs e)
        {
            string username = tbUser.Text;
            string password = tbPassword.Text;
          

            string sql = "SELECT TENNGUOIDUNG, MATKHAU, LOAINGUOIDUNG FROM NGUOIDUNG WHERE TENNGUOIDUNG = '"
                + username + "' AND MATKHAU = '" + password + "'";

            DataTable dataTable = new DataTable();
            SqlDataAdapter data = new SqlDataAdapter(sql, Connection.Connection);

            data.Fill(dataTable);

            if (dataTable.Rows.Count == 0)
                MessageBox.Show("Incorrect username or password !", "Warning",  MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                this.Visible = false;
                Form1 form = new Form1();
                form.ShowDialog();
                Application.Exit();
            }
            

        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }

        private void LoginForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                MessageBox.Show("sadasd");
          
                
           

        }
    }
}
