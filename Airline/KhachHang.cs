using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline.DTO
{
    class KhachHang
    {
        private string mAKHACHHANG;
        private string hOTEN;
        private bool gIOITINH;
        private string cMND;
        private string sDT;
        private string eMAIL;
        public KhachHang(string mkh, string hoten, bool gioitinh, string cmnd, string sdt, string email)
        {
            this.MAKHACHHANG = mkh;
            this.HOTEN = hoten;
            this.GIOITINH = gioitinh;
            this.cMND = cmnd;
            this.sDT = sdt;
            this.eMAIL = email;
        }
        public KhachHang() { }

        public string MAKHACHHANG { get => mAKHACHHANG; set => mAKHACHHANG = value; }
        public string HOTEN { get => hOTEN; set => hOTEN = value; }
        public bool GIOITINH { get => gIOITINH; set => gIOITINH = value; }
        public string CMND { get => cMND; set => cMND = value; }
        public string SDT { get => sDT; set => sDT = value; }
        public string EMAIL { get => eMAIL; set => eMAIL = value; }
    }
}
