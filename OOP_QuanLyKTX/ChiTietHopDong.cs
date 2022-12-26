using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Chi tiết hợp đồng (Mã HĐ, Mã phòng, Mã tòa, Ngày bắt đầu, Ngày kết thúc)
    public class ChiTietHopDong
    {
        public string maHopDong { get; set; }
        public string maPhong { get; set; }
        public DateTime ngayBatDau { get; set; }
        public DateTime ngayKetThuc { get; set; }

        //related = singular
        public HopDongThuePhong hopDong { get; set; }
        public Phong phong { get; set; }

        //Constructor
        public ChiTietHopDong() { }
        public ChiTietHopDong(string maHopDong, string maPhong, DateTime ngayBatDau, DateTime ngayKetThuc,
            HopDongThuePhong hopDong, Phong phong)
        {
            this.maHopDong = maHopDong;
            this.maPhong = maPhong;
            this.ngayBatDau = ngayBatDau;
            this.ngayKetThuc = ngayKetThuc;
            this.hopDong = hopDong;
            this.phong = phong;
        }
        public ChiTietHopDong(ChiTietHopDong ct)
        {
            this.maHopDong = ct.maHopDong;
            this.maPhong = ct.maPhong;
            this.ngayBatDau = ct.ngayBatDau;
            this.ngayKetThuc = ct.ngayKetThuc;
            this.hopDong = ct.hopDong;
            this.phong = ct.phong;
        }
    }
}
