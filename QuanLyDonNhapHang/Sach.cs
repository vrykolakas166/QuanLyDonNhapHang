using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyDonNhapHang
{
    class Sach
    {
        private string _TenSach;

        public string TenSach
        {
            get { return _TenSach; }
            set { _TenSach = value; }
        }

        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private double _DonGia;

        public double DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        private double _ThanhTien;
        public double ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }
        public Sach(string ten, int sl, double dg)
        {
            this.TenSach = ten;
            this.SoLuong = sl;
            this.DonGia = dg;
            this.ThanhTien = sl * dg;
        }
    }
}
