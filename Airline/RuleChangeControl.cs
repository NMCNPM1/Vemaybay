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
    public partial class RuleChangeControl : UserControl
    {

        ConnectToSQL con = new ConnectToSQL();
        SqlCommand cmd = new SqlCommand();
        private int value;
        private int index;


        public RuleChangeControl()
        {
            InitializeComponent();
            
           

        }

        private void updateRuleBt_Click(object sender, EventArgs e)
        {
            value = Int32.Parse(newValue.Text);
            index = listSex.selectedIndex;
            UpdateNumberAirport();
            UpdateMinimunFlying();
            UpdateImmeAirport();
            Update1stTickets();
            UpdateCancellationBooking();
            UpdateMaxStopTime();
            UpdateMinStopTime();
            Update2ndTickets();



        }
        void UpdateNumberAirport()
        {
            if (index == 0 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOLUONGSANBAY = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update số lượng sân bay thành công");
            }
        }
        void UpdateMinimunFlying()
        {
            if (index == 1 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANBAYTOITHIEU = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update thời gian bay tối thiểu thành công");
            }
        }
        void UpdateImmeAirport()
        {
            if (index == 2 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOSANBAYTRUNGGIANTOIDA = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update số lượng sân bay trung gian tối đa thành công");
            }
        }

        void UpdateMinStopTime()
        {
            if (index == 3 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANDUNGTOITHIEU = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update thời gian dừng tối thiểu thành công");
            }
        }
        void UpdateMaxStopTime()
        {
            if (index == 4 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOOIGIANDUNGTOIDA = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update thời gian dừng tối đa thành công");
            }
        }
        void Update1stTickets()
        {
            if (index == 5 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOLUONGVEHANG1 = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update số lượng vé hạng 1 thành công");
            }
        }
        void Update2ndTickets()
        {
            if (index == 6 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOLUONGVEHANG2 = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update số lượng vé hạng 2 thành công");
            }

        }
        void UpdateSlowestBooking()
        {
            if (index == 7 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANDATVECHAMNHAT = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update thời gian đặt vé chậm nhất thành công");
            }
        }
        void UpdateCancellationBooking()
        {
            if (index == 8 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANHUYDATVE = " + value;
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
                    string mes = ex.Message;
                    cmd.Dispose();
                    con.CloseConn();
                }
                MessageBox.Show("Update thời gian hủy đặt vé thành công");
            }
        }
    }
}