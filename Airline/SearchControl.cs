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
            InitializeComponent();
        }

        public void LoadData()
        {
            // load sân bay đến và sân bay đi
            string sql = "SELECT MASANBAY FROM dbo.SANBAY ORDER BY MASANBAY ASC";
            cmd.Connection = Form1.Connection.Connection;
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
            sql = "SELECT GIO FROM dbo.CHUYENBAY ORDER BY GIO ASC";
            cmd = new SqlCommand(sql, Form1.Connection.Connection);
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
            }
            catch { }
        }

        #endregion

        #region Main button

        private void searchBt_Click(object sender, EventArgs e)
        {
            if ((fromStation.selectedIndex == -1) || (toStation.selectedIndex == -1) || (gioKhoiHanh.selectedIndex == -1))
                return;
            string sql = "SELECT MACHUYENBAY, SANBAYDI, SANBAYDEN, GIO, HANG1CONLAI, GIAVEHANG1, HANG2CONLAI, GIAVEHANG2 " +
                "FROM dbo.CHUYENBAY " +
                "WHERE SANBAYDI='" + fromStation.selectedValue +
                "' AND SANBAYDEN='" + toStation.selectedValue +
                "' AND NGAY='" + datePicker.Value.ToString() + "'";
            if ((gioKhoiHanh.selectedValue != "Any Time") && (gioKhoiHanh.selectedValue != "..."))
                sql += "AND GIO='" + gioKhoiHanh.selectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, Form1.Connection.Connection);
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
                SaleControl saleControl = new SaleControl("", "", "");// truyền tỉnh đến, tỉnh đi, mã chuyến bay vào
                this.Controls.Add(saleControl);
                saleControl.Visible = true;
                saleControl.Size = new Size(807, 602);
                saleControl.Location = new Point(200, 28);
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

        #region Xử lí trùng chuyến bay

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

        private void SearchControl_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SaleControl saleControl = new SaleControl("", "", "");
            this.Controls.Add(saleControl);
            saleControl.Visible = true;
            saleControl.Size = new Size(807, 602);
            saleControl.Location = new Point(0, 0);
            saleControl.BringToFront();
        }
    }
}