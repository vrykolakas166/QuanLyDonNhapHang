using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDonNhapHang
{
    class PhieuNhap
    {
        private string _MaPhieu;

        public string MaPhieu
        {
            get { return _MaPhieu; }
            set { _MaPhieu = value; }
        }

        private string _TenNCC;

        public string TenNCC
        {
            get { return _TenNCC; }
            set { _TenNCC = value; }
        }

        private string _NgayNhap;

        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }

        private string _MaDDH;

        public string MaDDH
        {
            get { return _MaDDH; }
            set { _MaDDH = value; }
        }

        public PhieuNhap(string mp, string ten, string ngay, string mad)
        {
            this.MaPhieu = mp;
            this.TenNCC = ten;
            this.NgayNhap = ngay;
            this.MaDDH = mad;
        }
    }
}
