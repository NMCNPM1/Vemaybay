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

            Random rdKH = new Random();
            int rdNum = rdKH.Next(1, 1000);
            string rdIDKH = "KH00" + rdNum.ToString();
            if ((this.contactName.Text == "") || (this.phoneNumber.Text == "") || (Address.Text == "") || (ID.Text == ""))
            {
                MessageBox.Show("Please fill information");
            }
            else
            {
                string sql = "insert into KhachHang values ('" + rdIDKH + "','" + this.contactName.Text + "','" + this.contactDrD.selectedIndex.ToString() + "','" + this.phoneNumber.Text + "','" + this.Address.Text + "','" + this.ID.Text + "','"+this.eMail.Text+"')";
                SqlCommand cmd = new SqlCommand(sql, Form1.Connection.Connection);
                SqlDataReader myReader;
                try
                {
                    myReader = cmd.ExecuteReader();
                    MessageBox.Show("Booked!");


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Book Failed");
                }
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            backToSearch = new SearchControl();
            this.Controls.Add(this.backToSearch);
            backToSearch.Visible = true;
            backToSearch.BringToFront();
        }

        private void bunifuCustomLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
