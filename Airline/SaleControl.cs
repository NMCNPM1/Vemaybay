﻿using System;
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
                ConnectToSQL con = new ConnectToSQL();
                con.OpenConn();
                string sql = " insert into KhachHang values ('" + rdIDKH + "','" + this.contactName.Text + "','" + this.contactDrD.selectedIndex.ToString() + "','" + this.phoneNumber.Text + "','" + this.Address.Text + "','" + this.ID.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, con.Connection);
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

                con.CloseConn();
            }
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
