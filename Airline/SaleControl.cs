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

        private string _sanBayDen, _sanBayDi, _maChuyenBay;
        private long _giaVeHang1, _giaVeHang2;

        public SaleControl()
        {
            InitializeComponent();
        }

        private void classInfo_onItemSelected(object sender, EventArgs e)
        {
            if (classInfo.selectedIndex == 1)
                price.Text = "PRICE: " + _giaVeHang2.ToString() + " VND";
            else
                price.Text = "PRICE: " + _giaVeHang1.ToString() + " VND";
        }

        public SaleControl(string sanBayDen, string sanBayDi, string maChuyenBay, string giaVeHang1, string giaVeHang2)
        {
            _sanBayDen = sanBayDen;
            _sanBayDi = sanBayDi;
            _maChuyenBay = maChuyenBay;
            _giaVeHang1 = long.Parse(giaVeHang1.Split('.')[0]);
            _giaVeHang2 = long.Parse(giaVeHang2.Split('.')[0]);
            InitializeComponent();
            price.Text = "PRICE: " + _giaVeHang1.ToString() + " VND";
            MaCB.Text = "CODE: " + maChuyenBay;
            TinhDi.Text = "FROM: " + sanBayDi;
            TinhDen.Text = "TO: " + sanBayDen;
            MaCB.IsAccessible = false;
            TinhDi.IsAccessible = false;
            TinhDen.IsAccessible = false;
            price.IsAccessible = false;
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
            this.Parent.Controls.Remove(this);
        }

        #endregion
    }
}
