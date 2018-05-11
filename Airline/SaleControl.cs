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
using Airline.DTO;

namespace Airline
{
    public partial class SaleControl : UserControl
    {
        public SaleControl()
        {
            InitializeComponent();
        }
        ConnectToSQL DA = new ConnectToSQL();
        KhachHang KH = new KhachHang();

       void dis_en(bool e)
        {
            contactName.Enabled = e;
            phoneNumber.Enabled = e;
            cMND.Enabled = e;
            eMail.Enabled = e;
        }
        void Gandulieu(KhachHang KH)
        {
            KH.HOTEN = contactName.Text.Trim();
            KH.SDT = phoneNumber.Text.Trim();
            KH.CMND = cMND.Text.Trim();
            KH.EMAIL = eMail.Text.Trim();

           
                
        }
        void Listsex()
        {
            contactDrD.AddItem("Mr");
            contactDrD.AddItem("Mrs");
        }
        private void bookBt_Click(object sender, EventArgs e)
        {
            Listsex();
            Gandulieu(KH);
            dis_en(true);   
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
