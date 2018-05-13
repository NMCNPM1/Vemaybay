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
        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        public void GanDuLieu()
        {         
            string HoTen = contactName.Text;
            string Phonenumber = phoneNumber.Text;
            string Addr = Address.Text;
            string Cmnd = CMND.Text;
            string Email = eMail.Text;
        }
        // void Listsex()
        //{    
        //    contactDrD.AddItem("Mr");
        //    contactDrD.AddItem("Mrs");
        //}
        // làm sao để insert giới tình từ dropdown đổ vào sql?
             
        private void bookBt_Click(object sender, EventArgs e)
        {
            GanDuLieu();
            //Listsex();
            cmd.CommandText = " insert into KhachHang values ('" + contactName.Text +"','" + phoneNumber.Text + "','" + Address.Text + "','" + CMND.Text + "','" + eMail.Text + "')";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con.Connection;
            try
            {
                con.OpenConn();
                cmd.ExecuteNonQuery();
                con.CloseConn();
                
            }
            catch (Exception ex)
            {
                string mex = ex.Message;
                cmd.Dispose();
                con.CloseConn();
            }
            MessageBox.Show("Bạn Book vé thành công!");
         
        }
        //public string SinhMA1()
        //{
        //    string maKH;
        //    DataTable myTB = DA.TbView("select MaKhachHang From KhachHang");
        //    if (myTB.Rows.Count == 0) { return maKH = "MKH000"; }
        //    if (myTB.Rows.Count > 0)
        //    {
        //        int temp = Int32.Parse(myTB.Rows[(myTB.Rows.Count - 1)]["MaKhachHang"].ToString().Substring(3, 3)) + 2;
        //        if (temp < 10) { return maKH = "MKH00" + temp.ToString(); };
        //        if (10 <= temp && temp < 100) { return maKH = "MKH0" + temp.ToString(); };
        //    }
        //    myTB = null;
        //    return null;
        //}
    }
}
