﻿using System;
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
    public partial class DatabaseControl : UserControl
    {
        #region INIT

        public DatabaseControl()
        {
            InitializeComponent();
        }

        #endregion

        #region Main button

        private void dataBt_Click(object sender, EventArgs e)
        {

            openFileDialog1.Filter = "Excel | *.xlsx; *.xls| All File (*.*)|*.*";
            openFileDialog1.ShowDialog();
            if (openFileDialog1.FileName != "")
            {
                // tạo đối tượng excel
                Excel.Application excel = new Excel.Application();
                Form1.Connection.OpenConn();
                // mở tệp

                try
                {
                    Excel.Workbook workbook = excel.Workbooks.Open(openFileDialog1.FileName);
                    // mở sheet
                    for (int i = 1; i < 4; i++)
                    {                        
                        Excel.Worksheet sheet = workbook.Sheets[i];
                        Excel.Range range = sheet.UsedRange;
                        object[,] valueArray = (object[,])range.get_Value(Excel.XlRangeValueDataType.xlRangeValueDefault);
                        int row = valueArray.GetLength(0);
                        string command = "";
                        switch (i)
                        {
                            case 1: // SANBAY                              
                                for (int j = 2; j <= row; j++)
                                {
                                    string maSanBay = valueArray[j, 1].ToString();
                                    string tenSanBay = valueArray[j, 2].ToString();
                                    string quocGia = valueArray[j, 3].ToString();
                                    command = "INSERT INTO SANBAY VALUES("
                                     + "'" + maSanBay + "'" + ", "
                                     + "'" + tenSanBay + "'" + ", "
                                     + "'" + quocGia + "'" + ")";
                                    ExcuteCommand(command);
                                }                                
                                break;                    
                            case 2: // CHUYENBAY
                                for (int j = 2; j <= row; j++)
                                {
                                    if (valueArray[j, 1] == null)
                                    {
                                        break;
                                    }
                                    string maChuyenBay = valueArray[j, 1].ToString();
                                    long giaVeHang1 = long.Parse(valueArray[j, 2].ToString());
                                    long giaVeHang2 = long.Parse(valueArray[j, 3].ToString());
                                    string sanBayDi = valueArray[j, 4].ToString();
                                    string sanBayDen = valueArray[j, 5].ToString();
                                    string ngayBay = valueArray[j, 6].ToString();
                                    string gioBay = valueArray[j, 13].ToString();
                                    int thoiGianBay = int.Parse(valueArray[j, 8].ToString());
                                    int hang1 = int.Parse(valueArray[j, 9].ToString());
                                    int hang2 = int.Parse(valueArray[j, 10].ToString());
                                    int hang1conlai = int.Parse(valueArray[j, 11].ToString());
                                    int hang2conlai = int.Parse(valueArray[j, 12].ToString());

                                    command = "INSERT INTO CHUYENBAY VALUES("
                                     + "'" + maChuyenBay + "'" + ", "
                                     + giaVeHang2 + ", " + giaVeHang1 + ", " + "'" + sanBayDi + "'" + ", "
                                     + "'" + sanBayDen + "'" + ", " + "'" + ngayBay + "'" + ", "
                                     + "'" + gioBay + "'" + ", " + thoiGianBay + ", " + hang1 + ", "
                                     + hang2 + ", " + hang1conlai + ", " + hang2conlai + ")";
                                    ExcuteCommand(command);
                                }
                                break;
                            case 3: // SANBAYTRUNGGIAN
                                for (int j = 2; j <= row; j++)
                                {
                                    string chuyenBay = valueArray[j, 1].ToString();
                                    string sanbay = valueArray[j, 2].ToString();
                                    int thoiGianDung = int.Parse(valueArray[j, 3].ToString());
                                    command = "INSERT INTO SANBAYTRUNGGIAN VALUES("
                                     + "'" + chuyenBay + "'" + ", "
                                     + "'" + sanbay + "'" + ", "
                                     + thoiGianDung + ")";
                                    ExcuteCommand(command);
                                }
                                break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn tếp tin nào !", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        #endregion

        #region Support Methods

        public void ExcuteCommand(string command)
        {
            SqlCommand cmd = new SqlCommand(command, Form1.Connection.Connection);
            cmd.ExecuteNonQuery();
        }

        #endregion
    }
}
