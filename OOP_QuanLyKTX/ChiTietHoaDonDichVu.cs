using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    public class ChiTietHoaDonDichVu
    {
        public string maHoaDon { get; set; }
        public string maPhong { get; set; }
        public double tongTien { get; set; }
        public DateTime ngayThanhToan { get; set; }
        
        //related = singular
        public DichVu dichvu { get; set; }

        //Constructor
        public ChiTietHoaDonDichVu() { }
        public ChiTietHoaDonDichVu(string maHoaDon, string maPhong, double tongTien, DateTime ngayThanhToan, DichVu dichvu)
        {
            this.maHoaDon = maHoaDon;
            this.maPhong = maPhong;
            this.tongTien = tongTien;
            this.ngayThanhToan = ngayThanhToan;
            this.dichvu = dichvu;
        }
        public ChiTietHoaDonDichVu(ChiTietHoaDonDichVu cthd)
        {
            this.maHoaDon = cthd.maHoaDon;
            this.maPhong = cthd.maPhong;
            this.tongTien = cthd.tongTien;
            this.ngayThanhToan = cthd.ngayThanhToan;
            this.dichvu = cthd.dichvu;
        }
    }
}
