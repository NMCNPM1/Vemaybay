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

        int hangVe = 1;
        bool gioiTinh = true;
        long _price = 0;

        public SaleControl()
        {
            InitializeComponent();
        }

        private void classInfo_onItemSelected(object sender, EventArgs e)
        {
            if (classInfo.selectedIndex == 1)
            {
                price.Text = "PRICE: " + _giaVeHang2.ToString() + " VND";
                _price = _giaVeHang2;
                hangVe = 2;
            }

            else
            {
                price.Text = "PRICE: " + _giaVeHang1.ToString() + " VND";
                _price = _giaVeHang1;
                hangVe = 1;
            }
        }

        private void sex_onItemSelected(object sender, EventArgs e)
        {
            if (sex.selectedIndex == 1) gioiTinh = false;
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
            _price = _giaVeHang1;
            MaCB.IsAccessible = false;
            TinhDi.IsAccessible = false;
            TinhDen.IsAccessible = false;
            price.IsAccessible = false;
        }

        #endregion

        #region Main button

        private void bookBt_Click(object sender, EventArgs e)
        {
            if ((this.contactName.Text == "") || (this.phoneNumber.Text == "") || (Address.Text == "") || (ID.Text == ""))
            {
                MessageBox.Show("Please fill information");
            }
            else
            {
                string sql = "SELECT COUNT(MAVE) FROM VE";

                //string sql = @"INSERT INTO KHACHHANG VALUES ('" + IDKH + "','" + this.contactName.Text + "','" + this.sex.selectedIndex.ToString() + "','" + this.phoneNumber.Text + "','" + this.Address.Text + "','" + this.ID.Text + "','" + this.eMail.Text + "')";
                //string sqlVe = @"INSERT INTO VE VALUES ('" + IDTK + "','" + _maChuyenBay + "','" + IDKH + "','" + classInfo.selectedIndex.ToString() + "','" + GiaVe().ToString() + "')";
                #region Lấy số lượng vé hiện tại
                SqlCommand cmd = new SqlCommand(sql, LoginForm.Connection.Connection);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                DataRow row = dt.Select()[0];
                string soLuong = row[0].ToString();
                int soLuongVe = int.Parse(soLuong);
                da.Dispose();
                dt.Dispose();
                #endregion

                sql = "SELECT MAKHACHHANG FROM KHACHHANG WHERE HOTEN = N'" + contactName.Text
                    + "' AND SDT = '" + phoneNumber.Text + "'";

                cmd.CommandText = sql;

                da = new SqlDataAdapter(cmd);
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    da.Dispose();
                    sql = "SELECT COUNT(MAKHACHHANG) FROM KHACHHANG";
                    cmd.CommandText = sql;
                    da = new SqlDataAdapter(cmd);
                    dt.Dispose();
                    da.Fill(dt);
                    row = dt.Select()[0];
                    soLuong = row[0].ToString();
                    int soLuongKhachHang = int.Parse(soLuong);
                    string code = (Form1.ChuanHoaMa(soLuongKhachHang));
                    string maKhachHang = "KH" + code;
                    sql = "INSERT INTO KHACHHANG VALUES('" + maKhachHang + "', '" + contactName.Text
                        + "', " + "0, '" + phoneNumber.Text + "', '" + Address.Text + "', '"
                        + ID.Text + "', '" + eMail.Text + "')";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    sql = "INSERT INTO VE VALUES('VE" + code + "', '" + _maChuyenBay
                        + "', '" + maKhachHang + "', " + hangVe.ToString()
                        + ", " + _price.ToString() + ")";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booked !");
                }
                else
                {
                    row = dt.Select()[1];
                    string maKhachHang = row[1].ToString();
                    string code = Form1.ChuanHoaMa(soLuongVe);
                    sql = "INSERT INTO VE VALUES('VE" + code + "', '" + _maChuyenBay
                        + "', '" + maKhachHang + "', " + hangVe.ToString()
                        + ", " + _price.ToString() + ")";
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Booked 1 !");
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
