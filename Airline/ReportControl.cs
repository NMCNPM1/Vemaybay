using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;
namespace Airline
{
    public partial class ReportControl : UserControl
    {
        #region INIT

        public ReportControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Main button
        
        private void reportBt_Click(object sender, EventArgs e)
        {
            if(countMoney()=="0 VNĐ")
            {
                MessageBox.Show("Tháng này không có thu nhập !", "Thông báo");
                return;
            }
            string sql = "SELECT VE.MAVE, VE.MACHUYENBAY, VE.HANGVE, VE.GIAVE FROM VE , CHUYENBAY WHERE VE.MACHUYENBAY=CHUYENBAY.MACHUYENBAY AND month(CHUYENBAY.NGAY)=" +
                monthRp.selectedValue + " AND YEAR(NGAY)=" + yearRp.selectedValue;
            SqlCommand cmd = new SqlCommand(sql, LoginForm.Connection.Connection);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            listView.DataSource = dt;

            //excel
            string title = "Báo cáo tháng " + monthRp.selectedValue + "-" + yearRp.selectedValue;

            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "(Tất cả các tệp)|*.*|(Các tệp excel)|*.xlsx";
            save.ShowDialog();
            if (save.FileName != "")
            {
                Excel.Application app = new Excel.Application();
                Excel.Workbook wb = app.Workbooks.Add(Type.Missing);
                Excel.Worksheet sheet = null;
                try
                {
                    sheet = wb.ActiveSheet;
                    sheet.Name = title;
                    sheet.Range[sheet.Cells[1, 1], sheet.Cells[1, listView.Columns.Count]].Merge();
                    sheet.Cells[1, 1].Value = title;
                    sheet.Cells[1, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[1, 1].Font.Size = 20;
                    sheet.Cells[1, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;

                    //tính tổng
                    
                    for (int i = 1; i <= 10; i++) 
                    {
                        sheet.Columns[i].ColumnWidth = 18;
                    }
                    sheet.Cells[2, 1].Value = "STT";
                    sheet.Cells[2, 1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[2, 1].Font.Bold = true;
                    sheet.Cells[2, 1].Borders.Weight = Excel.XlBorderWeight.xlMedium;
                    for (int i = 1; i <= listView.Columns.Count; i++)
                    {
                        sheet.Cells[2, i+1].Value = listView.Columns[i - 1].Name.ToString();
                        sheet.Cells[2, i+1].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                        sheet.Cells[2, i+1].Font.Bold = true;
                        sheet.Cells[2, i+1].Borders.Weight = Excel.XlBorderWeight.xlMedium;
                    }
                    for (int i = 1; i < listView.Rows.Count; i++)
                    {
                        sheet.Cells[i + 2, 1] = i.ToString();
                        sheet.Cells[i + 2, 1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                        sheet.Cells[i + 2, 2] = listView[0, i - 1].Value.ToString();
                        sheet.Cells[i + 2, 2].Borders.Weight = Excel.XlBorderWeight.xlThin;
                        for (int j = 1; j <= listView.Columns.Count; j++)
                        {
                            sheet.Cells[i + 2, j+1] = listView[j - 1, i - 1].Value.ToString();
                            sheet.Cells[i + 2, j+1].Borders.Weight = Excel.XlBorderWeight.xlThin;
                        }
                    }
                    sheet.Cells[listView.Rows.Count+3, 3].Value = "Tổng doanh thu :" + countMoney();
                    sheet.Cells[listView.Rows.Count + 3, 3].HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    sheet.Cells[listView.Rows.Count + 3, 3].Font.Size = 20;
                    sheet.Cells[listView.Rows.Count + 3, 3].Borders.Weight = Excel.XlBorderWeight.xlThin;
                    wb.SaveAs(save.FileName);
                    MessageBox.Show("Xuất thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    app.Quit();
                    wb = null;
                }
            }

        }

        #endregion

        #region Support Methods

        private string money(string str)
        {
            string str1 = "";
            int j = 0;
            for (int i = str.Length - 1; i >= 0; i--)
            {
                str1 = str[i] + str1;
                j++;
                if (j == 3)
                {
                    str1 = " " + str1;
                    j = 0;
                }
            }
            return str1;
        }

        private string countMoney()
        {
            string sql = "SELECT sum(VE.GIAVE) FROM VE , CHUYENBAY WHERE VE.MACHUYENBAY=CHUYENBAY.MACHUYENBAY AND month(CHUYENBAY.NGAY)=" +
                monthRp.selectedValue + " AND YEAR(NGAY)=" + yearRp.selectedValue;

            SqlCommand cmd = new SqlCommand(sql, LoginForm.Connection.Connection);
            SqlDataReader myReader;

            myReader = cmd.ExecuteReader();
            myReader.Read();
            string revenue = myReader[0].ToString();
            if (revenue == "") revenue = "0 VNĐ";
            else revenue = money(float.Parse(revenue).ToString()) + " VNĐ";
            return revenue;
        }

        #endregion
    }
}
