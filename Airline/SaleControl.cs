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
        #region INIT

        private string sanBayDen, sanBayDi, maChuyenBay;

        public SaleControl()
        {
            InitializeComponent();
        }

        public SaleControl(string sanBayDen, string sanBayDi, string maChuyenBay)
        {
            InitializeComponent();
            MaCB.Text = "FLIGHT CODE: " + sanBayDen;
            TinhDi.Text = "FROM: " + sanBayDi;
            TinhDen.Text = "TO: " + maChuyenBay;
            MaCB.IsAccessible = false;
            TinhDi.IsAccessible = false;
            TinhDen.IsAccessible = false;
        }

        #endregion

        #region Main button

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
                string sql = "INSERT INTO KHACHHANG VALUES ('" + rdIDKH + "','" + this.contactName.Text + "','" + this.sex.selectedIndex.ToString() + "','" + this.phoneNumber.Text + "','" + this.Address.Text + "','" + this.ID.Text + "','"+this.eMail.Text+"')";
                SqlCommand cmd = new SqlCommand(sql, LoginForm.Connection.Connection);
                SqlDataReader myReader;
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booked!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Book Failed");
                }
            }
        }

        private void backBt_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }

        #endregion
    }
}
