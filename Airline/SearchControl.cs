﻿using System;
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
    public partial class SearchControl : UserControl
    {
        #region INIT

        SqlCommand cmd = new SqlCommand();

        public SearchControl()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
        }

        public void LoadData()
        {
            // load sân bay đến và sân bay đi
            string sql = "SELECT TINH FROM dbo.SANBAY ORDER BY MASANBAY ASC";
            cmd.Connection = LoginForm.Connection.Connection;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sql;


            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();

                if (myReader.HasRows)
                {
                    if (fromStation.selectedValue == "...")
                    {
                        fromStation.RemoveItem("...");
                        fromStation.AddItem("Select Station");
                        fromStation.selectedIndex = 0;
                        while (myReader.Read())
                        {
                            string sName = myReader[0].ToString();
                            fromStation.AddItem(sName);
                        }
                        myReader.Close();

                    }
                    if (toStation.selectedValue == "...")
                    {
                        myReader = cmd.ExecuteReader();

                        toStation.RemoveItem("...");
                        toStation.AddItem("Select Station");
                        toStation.selectedIndex = 0;
                        while (myReader.Read())
                        {
                            string sName = myReader[0].ToString();
                            toStation.AddItem(sName);
                        }
                        myReader.Close();
                    }
                }
            }
            catch { }
            // Load giờ bay
            sql = "SELECT DISTINCT GIO FROM dbo.CHUYENBAY ORDER BY GIO ASC";
            cmd = new SqlCommand(sql, LoginForm.Connection.Connection);
            try
            {
                myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    if (gioKhoiHanh.selectedValue == "...")
                    {
                        gioKhoiHanh.RemoveItem("...");
                        gioKhoiHanh.AddItem("Any Time");
                        gioKhoiHanh.selectedIndex = 0;
                        while (myReader.Read())
                        {
                            string sName = myReader[0].ToString();
                            gioKhoiHanh.AddItem(sName);
                        }
                    }
                }
                myReader.Close();
            }
            catch { }
        }

        #endregion

        #region Main button

        private void searchBt_Click(object sender, EventArgs e)
        {
            if ((fromStation.selectedIndex == 0) || (toStation.selectedIndex == 0))
                return;
            string sql = "SELECT MACHUYENBAY, SB1.TENSANBAY AS SANBAYDI, SB2.TENSANBAY AS SANBAYDEN, GIO, HANG1CONLAI, GIAVEHANG1, HANG2CONLAI, GIAVEHANG2 " +
                "FROM CHUYENBAY, SANBAY SB1, SANBAY SB2 " +
                "WHERE CHUYENBAY.SANBAYDEN=SB2.MASANBAY AND CHUYENBAY.SANBAYDI= SB1.MASANBAY" +
                " AND SB1.TINH=N'" + fromStation.selectedValue +
                "' AND SB2.TINH=N'" + toStation.selectedValue +
                "' AND NGAY='" + datePicker.Value.ToString() + "'";
            if (gioKhoiHanh.selectedValue != "Any Time")
                sql += "AND GIO='" + gioKhoiHanh.selectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, LoginForm.Connection.Connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            flightInfo.DataSource = dt;
        }

        #endregion        

        #region Event      

        private void flightInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                string maChuyenBay = Form1.ChuanHoaMaCuoi(flightInfo.CurrentRow.Cells[0].Value.ToString());
                string tinhDi = fromStation.selectedValue;
                string tinhDen = toStation.selectedValue;
                string giaVeHang1 = flightInfo.CurrentRow.Cells[5].Value.ToString();
                string giaVeHang2 = flightInfo.CurrentRow.Cells[7].Value.ToString();
                SaleControl saleControl = new SaleControl(tinhDi, tinhDen, maChuyenBay, giaVeHang1, giaVeHang2);// truyền tỉnh đến, tỉnh đi, mã chuyến bay vào
                saleControl.BackColor = Color.Transparent;
                saleControl.Visible = true;
                saleControl.BackSearch.Visible = true;
                saleControl.Size = new Size(856, 523);
                saleControl.Location = new Point(66, 117);
                saleControl.BringToFront();
            }
            catch { }
           
        }

        private void flightInfo_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                flightInfo.CurrentRow.Selected = true;
            }
            catch
            {
            }
        }

        

        #region Xử lí trùng from & to

        private void fromStation_onItemSelected(object sender, EventArgs e)
        {
            if (fromStation.selectedValue == toStation.selectedValue && toStation.selectedIndex != 0)
            {
                MessageBox.Show("Airport departure must be another airport arrival !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fromStation.selectedIndex = 0;
            }
        }

        private void toStation_onItemSelected(object sender, EventArgs e)
        {
            if (toStation.selectedValue == fromStation.selectedValue && toStation.selectedIndex != 0 )
            {
                MessageBox.Show("Airport departure must be another airport arrival !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                toStation.selectedIndex = 0;
            }
        }

        #endregion

        #endregion


    }
}