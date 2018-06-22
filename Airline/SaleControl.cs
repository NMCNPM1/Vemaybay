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
        private static int idTicket;
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
        private long GiaVe()
        {
            if (classInfo.selectedIndex == 1)
                return _giaVeHang2;
            else
                return _giaVeHang1;
        }
        private void price_OnValueChanged(object sender, EventArgs e)
        {

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
            string IDTK = "TK" + idTicket.ToString();
            string IDKH = "KH00" + idTicket.ToString();
            if ((this.contactName.Text == "") || (this.phoneNumber.Text == "") || (Address.Text == "") || (ID.Text == ""))
            {
                MessageBox.Show("Please fill information");
            }
            else
            {
                string sqlVe = @"INSERT INTO VE VALUES ('" + IDTK + "','" + _maChuyenBay + "','" + IDKH + "','" + classInfo.selectedIndex.ToString() + "','" + GiaVe().ToString() + "')";
                string sql = @"INSERT INTO KHACHHANG VALUES ('" + IDKH + "','" + this.contactName.Text + "','" + this.sex.selectedIndex.ToString() + "','" + this.phoneNumber.Text + "','" + this.Address.Text + "','" + this.ID.Text + "','"+this.eMail.Text+"')";
                SqlCommand cmd = new SqlCommand(sql, LoginForm.Connection.Connection);
                SqlCommand cmd1 = new SqlCommand(sqlVe, LoginForm.Connection.Connection);
                cmd.CommandType = CommandType.Text;
                cmd1.CommandType = CommandType.Text;

                try
                {
                    cmd.ExecuteNonQuery();
                    cmd1.ExecuteNonQuery();
                    MessageBox.Show("Booked !");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Book Failed !");
                    cmd.Dispose();
                    cmd1.Dispose();
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
