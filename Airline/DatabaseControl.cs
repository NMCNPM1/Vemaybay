using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class DatabaseControl : UserControl
    {
        public DatabaseControl()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void dataBt_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Excel | *.xlsx, *.xls";
            openFileDialog1.ShowDialog();

        }
    }
}
