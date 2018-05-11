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
    public partial class SearchControl : UserControl
    {

        public SearchControl()
        {
            InitializeComponent();
        }


        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ConnectToSQL con = new ConnectToSQL();
            con.OpenConn();
            string sql = "SELECT MACHUYENBAY, SANBAYDI, SANBAYDEN, GIO, HANG1CONLAI, GIAVE*1.05 as price1, HANG2CONLAI, GIAVE " +
                "FROM dbo.CHUYENBAY";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.CloseConn();
            flightInfo.DataSource = dt;

        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {
            ConnectToSQL con = new ConnectToSQL();
            con.OpenConn();
            string sql = "SELECT MASANBAY FROM dbo.SANBAY ORDER BY MASANBAY ASC";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        bunifuDropdown1.AddItem(myReader[0].ToString());
                    }
                }
            }
            catch { }
            con.CloseConn();

        }

        private void yearRp_onItemSelected(object sender, EventArgs e)
        {
            ConnectToSQL con = new ConnectToSQL();
            con.OpenConn();
            string sql = "SELECT MASANBAY FROM dbo.SANBAY ORDER BY MASANBAY ASC";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        string sName = myReader[0].ToString();
                        yearRp.AddItem(sName);
                    }
                }
            }
            catch { }
            con.CloseConn();
        }
       
        private void SearchControl_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker1_onValueChanged(object sender, EventArgs e)
        {

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

        private void bunifuDropdown2_onItemSelected(object sender, EventArgs e)
        {
            ConnectToSQL con = new ConnectToSQL();
            con.OpenConn();
            string sql = "SELECT GIO FROM dbo.CHUYENBAY ORDER BY GIO ASC ";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    while (myReader.Read())
                    {
                        bunifuDropdown2.AddItem(myReader[0].ToString());
                    }
                }
            }
            catch { }
            con.CloseConn();
        }

        private void searchBt_Click(object sender, EventArgs e)
        {
            ConnectToSQL con = new ConnectToSQL();
            con.OpenConn();
            string sql = "SELECT MACHUYENBAY, SANBAYDI, SANBAYDEN, GIO, HANG1CONLAI, GIAVE*1.05 as price1, HANG2CONLAI, GIAVE " +
                "FROM dbo.CHUYENBAY " +
                "WHERE SANBAYDI='" + yearRp.selectedValue +
                "' AND SANBAYDEN='" + bunifuDropdown1.selectedValue +
                "' AND NGAY='" + bunifuDatepicker1.Value.ToString() + "'";
            if(bunifuDropdown2.selectedValue!="Any Time")
                sql+="AND GIO='" + bunifuDropdown2.selectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.CloseConn();
            flightInfo.DataSource = dt;
        }
    }
}
