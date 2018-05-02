using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
        

        }

        private void saleBt_Click(object sender, EventArgs e)
        {
            searchControl1.Visible = true;
            searchControl1.BringToFront();
            //location: 202, 100
            //SIze :599, 349
        }

        private void bookBt_Click(object sender, EventArgs e)
        {
            saleControl1.Visible = true;
            saleControl1.BringToFront();
        }

        private void dataBt_Click(object sender, EventArgs e)
        {
            databaseControl1.Visible = true;
            databaseControl1.BringToFront();
        }

        private void reportBt_Click(object sender, EventArgs e)
        {
            reportControl1.Visible = true;
            reportControl1.BringToFront();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            ruleChangeControl1.Visible = true;
            ruleChangeControl1.BringToFront();
        }
        // nút tắt
        private void closeBt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // nút minimized
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reportControl1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
          //  changeWidthPanel(200,56,true);
        }

        private void panel1_MouseLeave(object sender, EventArgs e)
        {
           // changeWidthPanel(56,200,false);
        }

        //private void changeWidthPanel(int newWidth, int oldWidth, bool isGrow) // hàm thay đổi kích thước panel
        //{
        //    if (isGrow)
        //        for (int i = oldWidth; i <= newWidth; i++)
        //        {
        //            panel1.Width = i;
        //            searchBt.Width = i;
        //            bookBt.Width = i;
        //            reportBt.Width = i;
        //            dataBt.Width = i;
        //            changeBt.Width = i;
        //        }
        //    else
        //        for (int i = oldWidth; i >= newWidth; i--)
        //        {
        //            panel1.Width = i;
        //            searchBt.Width = i;
        //            bookBt.Width = i;
        //            reportBt.Width = i;
        //            dataBt.Width = i;
        //            changeBt.Width = i;
        //        }

            
        //}

        private void searchBt_MouseHover(object sender, EventArgs e)
        {   
        //    if(panel1.Width == 56)
        //    changeWidthPanel(200, 56, true);
        }
    }
}
