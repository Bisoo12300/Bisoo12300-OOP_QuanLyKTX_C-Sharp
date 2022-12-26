using System.Collections.Generic;

namespace OOP_QuanLyKTX
{
    //Sinh Viên (MaSV, Tên SV, Giới tính, SĐT, Mã phòng)
    public class SinhVien
    {
        public string maSV { get; set; }
        public string tenSV { get; set; }
        public bool gioiTinh { get; set; }
        public string soDienThoai { get; set; }

        //related = singular
        public Phong phong { get; set; }

        //Constructor
        public SinhVien() { }

        public SinhVien(string maSV, string tenSV, bool gioiTinh, string soDienThoai, Phong phong)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.gioiTinh = gioiTinh;
            this.soDienThoai = soDienThoai;
            this.phong = phong;
        }
        public SinhVien(SinhVien sv)
        {
            this.maSV = sv.maSV;
            this.tenSV = sv.tenSV;
            this.gioiTinh = sv.gioiTinh;
            this.soDienThoai = sv.soDienThoai;
            this.phong = sv.phong;
        }
    }
}
