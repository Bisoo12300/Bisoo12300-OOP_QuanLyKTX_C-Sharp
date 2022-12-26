using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Loại phòng (Mã loại phòng, Tên loại phòng, Giá phòng)
    public class LoaiPhong
    {
        public string maLoaiPhong { get; set; }
        public string tenLoaiPhong { get; set; }
        public double giaPhong { get; set; }

        // related = plural
        public ICollection<Phong> dsphong_loai { get; set; }

        //Constructor
        public LoaiPhong() { }
        public LoaiPhong(string maLoaiPhong, string tenLoaiPhong, double giaPhong, ICollection<Phong> dsphong_loai)
        {
            this.maLoaiPhong = maLoaiPhong;
            this.tenLoaiPhong = tenLoaiPhong;
            this.giaPhong = giaPhong;
            this.dsphong_loai = dsphong_loai;
        }
        public LoaiPhong(LoaiPhong lp)
        {
            this.maLoaiPhong = lp.maLoaiPhong;
            this.tenLoaiPhong = lp.tenLoaiPhong;
            this.giaPhong = lp.giaPhong;
            this.dsphong_loai = lp.dsphong_loai;
        }
    }
}
