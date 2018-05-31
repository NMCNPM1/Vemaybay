using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Airline
{
    public partial class SaleControl : UserControl
    {
        public SaleControl()
        {
            InitializeComponent();
        }
 
        private void bookBt_Click(object sender, EventArgs e)
        {
            
            ConnectToSQL con = new ConnectToSQL();
            con.OpenConn();
            string sql = " insert into KhachHang values ('" + this.contactName.Text + "','" + this.contactDrD.selectedValue.ToString() + "','" + this.CMND.Text + "','" + this.phoneNumber.Text + "','" + this.Address.Text + "','" + this.eMail.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            SqlDataReader myReader;
            try
            {           
                myReader = cmd.ExecuteReader();
                MessageBox.Show("Booked!");
                while (myReader.Read())
                {
                    string Gender = myReader[0].ToString();
                    contactDrD.AddItem(Gender);
                }
                con.CloseConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Book failed!");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            backToSearch = new SearchControl();
            this.Controls.Add(this.backToSearch);
            backToSearch.Visible = true;
            backToSearch.BringToFront();
        }
    }
}
