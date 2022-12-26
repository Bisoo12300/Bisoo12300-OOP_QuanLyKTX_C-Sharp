using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Phòng (Mã phòng, Mã tòa, Mã loại phòng, Trạng thái)
    public class Phong
    {
        public string maPhong { get; set; }
        public char maToa { get; set; }
        public string maLoaiPhong { get; set; }
        public bool trangThai { get; set; }

        //related = singular
        public Toa toa { get; set; }
        public LoaiPhong loaiPhong { get; set; }

        //related = plural
        public ICollection<SinhVien> dssv_phong { get; set; }

        //Constructor
        public Phong() { }
        public Phong(string maPhong, char maToa, string maLoaiPhong, bool trangThai, 
            Toa toa, LoaiPhong loaiPhong, ICollection<SinhVien> dssv_phong)
        {
            this.maPhong = maPhong;
            this.maToa = maToa;
            this.maLoaiPhong = maLoaiPhong;
            this.trangThai = trangThai; //true = đã thuê
            this.toa = toa;
            this.loaiPhong = loaiPhong;
            this.dssv_phong = dssv_phong;
        }
        public Phong(Phong p)
        {
            this.maPhong = p.maPhong;
            this.maToa = p.maToa;
            this.maLoaiPhong = p.maLoaiPhong;
            this.trangThai = p.trangThai;
            this.toa = p.toa;
            this.loaiPhong = p.loaiPhong;
            this.dssv_phong = p.dssv_phong;
        }
    }
}
