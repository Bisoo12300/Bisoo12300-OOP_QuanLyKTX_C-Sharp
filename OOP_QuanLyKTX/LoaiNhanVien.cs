using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Loại nhân viên (Mã loại NV, Chức vụ, Công việc Mã quản lý)
    public class LoaiNhanVien
    {
        public string maLoaiNV { get; set; }
        public string chucVu { get; set; }
        public string congViec { get; set; }
        public string maQuanLy { get; set; }
        //related = plural
        public ICollection<NhanVien> dsnhanvien_loai { get; set; }

        //related = singular
        public NhanVien quanLy { get; set; }

        //Constructor
        public LoaiNhanVien() { }
        public LoaiNhanVien(string maLoaiNV, string chucVu, string congViec,
            ICollection<NhanVien> dsnhanvien_loai, string maQuanLy)
        {
            this.maLoaiNV = maLoaiNV;
            this.chucVu = chucVu;
            this.congViec = congViec;
            this.dsnhanvien_loai = dsnhanvien_loai;
            this.maQuanLy = maQuanLy;
        }
        public LoaiNhanVien(LoaiNhanVien lnv)
        {
            this.maLoaiNV = lnv.maLoaiNV;
            this.chucVu = lnv.chucVu;
            this.congViec = lnv.congViec;
            this.dsnhanvien_loai = lnv.dsnhanvien_loai;
            this.maQuanLy = lnv.maQuanLy;
        }
    }
}
