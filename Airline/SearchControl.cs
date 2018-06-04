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
            this.yearRp.Load += new System.EventHandler(this.yearRp_onItemSelected);
            this.bunifuDropdown1.Load += new System.EventHandler(this.bunifuDropdown1_onItemSelected);
            this.bunifuDropdown2.Load += new System.EventHandler(this.bunifuDropdown2_onItemSelected);

        }


        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

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
                    if (bunifuDropdown1.selectedValue == "...")
                    {
                        bunifuDropdown1.RemoveItem("...");
                        bunifuDropdown1.AddItem("---------Select Station--------");
                        while (myReader.Read())
                        {
                            string sName = myReader[0].ToString();
                            bunifuDropdown1.AddItem(sName);
                        }
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
                    if (yearRp.selectedValue == "...")
                    {
                        yearRp.RemoveItem("...");
                        yearRp.AddItem("---------Select Station--------");
                        while (myReader.Read())
                        {
                            string sName = myReader[0].ToString();
                            yearRp.AddItem(sName);
                        }
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
            string sql = "SELECT GIO FROM dbo.CHUYENBAY ORDER BY GIO ASC";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            SqlDataReader myReader;
            try
            {
                myReader = cmd.ExecuteReader();
                if (myReader.HasRows)
                {
                    if (bunifuDropdown2.selectedValue == "...")
                    {
                        bunifuDropdown2.RemoveItem("...");
                        bunifuDropdown2.AddItem("Any Time");
                        while (myReader.Read())
                        {
                            string sName = myReader[0].ToString();
                            bunifuDropdown2.AddItem(sName);
                        }
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
            if ((yearRp.selectedIndex == -1) || (bunifuDropdown1.selectedIndex == -1) || (bunifuDropdown2.selectedIndex == -1))
                return;
            string sql = "SELECT MACHUYENBAY, SANBAYDI, SANBAYDEN, GIO, HANG1CONLAI, GIAVEHANG1, HANG2CONLAI, GIAVEHANG2 " +
                "FROM dbo.CHUYENBAY " +
                "WHERE SANBAYDI='" + yearRp.selectedValue +
                "' AND SANBAYDEN='" + bunifuDropdown1.selectedValue +
                "' AND NGAY='" + bunifuDatepicker1.Value.ToString() + "'";
            if((bunifuDropdown2.selectedValue!="Any Time")&&(bunifuDropdown2.selectedValue!="..."))
                sql+="AND GIO='" + bunifuDropdown2.selectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, con.Connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.CloseConn();
            flightInfo.DataSource = dt;
        }

        private void bunifuDatepicker1_onValueChanged_1(object sender, EventArgs e)
        {
            
        }

        private void flightInfo_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                sale1 = new SaleControl();
                this.Controls.Add(this.sale1);
                sale1.Visible = true;
                sale1.BringToFront();
                sale1.BackSearch.Visible = true;
            }
            catch { }
           
        }
    }
}