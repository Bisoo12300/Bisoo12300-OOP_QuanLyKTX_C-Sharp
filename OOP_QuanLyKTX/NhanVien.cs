using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Nhân viên (Mã nhân viên, Mã loại NV, Mã tòa, Tên nhân viên, SDT, Lương)
    public class NhanVien
    {
        public string maNV { get; set; }
        public string maLoaiNV { get; set; }
        public char maToa { get; set; }
        public string tenNhanVien { get; set; }
        public string soDienThoai { get; set; }
        public double luong { get; set; }

        //related = singular
        public LoaiNhanVien loaiNhanVien { get; set; }
        public Toa toa { get; set; }

        //Constructor
        public NhanVien() { }
        public NhanVien(string maNV, string maLoaiNV, char maToa, string tenNhanVien, 
            string soDienThoai, double luong, LoaiNhanVien loaiNhanVien, Toa toa)
        {
            this.maNV = maNV;
            this.maLoaiNV = maLoaiNV;
            this.maToa = maToa;
            this.tenNhanVien = tenNhanVien;
            this.soDienThoai = soDienThoai;
            this.luong = luong;
            this.loaiNhanVien = loaiNhanVien;
            this.toa = toa;
        }
        public NhanVien(NhanVien nv)
        {
            this.maNV = nv.maNV;
            this.tenNhanVien = nv.tenNhanVien;
            this.soDienThoai = nv.soDienThoai;
            this.luong = nv.luong;
            this.loaiNhanVien = nv.loaiNhanVien;
            this.toa = nv.toa;
        }
    }
}
