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
        #region INIT

        SqlCommand cmd = new SqlCommand();
        private int value;
        private int index;
        public RuleChangeControl()
        {
            this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            this.BackColor = Color.Transparent;   
            InitializeComponent();
      
        }

        #endregion

        #region Main button

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

        #endregion

        #region Update methods

        void UpdateNumberAirport()
        {
            if (index == 0 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOLUONGSANBAY = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        void UpdateMinimunFlying()
        {
            if (index == 1 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANBAYTOITHIEU = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        void UpdateImmeAirport()
        {
            if (index == 2 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOSANBAYTRUNGGIANTOIDA = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        void UpdateMinStopTime()
        {
            if (index == 3 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANDUNGTOITHIEU = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        void UpdateMaxStopTime()
        {
            if (index == 4 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOOIGIANDUNGTOIDA = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        void Update1stTickets()
        {
            if (index == 5 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOLUONGVEHANG1 = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        void Update2ndTickets()
        {
            if (index == 6 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set SOLUONGVEHANG2 = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }

        }

        void UpdateSlowestBooking()
        {
            if (index == 7 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANDATVECHAMNHAT = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        void UpdateCancellationBooking()
        {
            if (index == 8 && newValue.Text != null)
            {
                cmd.CommandText = "Update dbo.QUYDINH6 set THOIGIANHUYDATVE = " + value;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = LoginForm.Connection.Connection;
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    string mes = ex.Message;
                    cmd.Dispose();
                }
                MessageBox.Show("Update successfull !");
            }
        }

        #endregion
    }
}