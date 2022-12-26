using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_QuanLyKTX
{
    //Tòa (Mã tòa, Mã quản lý, Sức chứa, Số lượng phòng)
    public class Toa
    {
        public char maToa { get; set; }
        public int sucChua { get; set; }
        public int soPhong { get; set; }

        //related = plural
        public ICollection<NhanVien> dsnhanvien_toa { get; set; }
        public ICollection<Phong> dsphong_toa { get; set; }

        //Constructor
        public Toa() { }
        public Toa(char maToa, int sucChua, int soPhong,
            ICollection<Phong> dsphong_toa, ICollection<NhanVien> dsnhanvien_toa)
        {
            this.maToa = maToa;
            this.sucChua = sucChua;
            this.soPhong = soPhong;
            this.dsphong_toa = dsphong_toa;
            this.dsnhanvien_toa = dsnhanvien_toa;
        }
        public Toa(Toa t)
        {
            this.maToa = t.maToa;
            this.sucChua = t.sucChua;
            this.soPhong = t.soPhong;
            this.dsphong_toa = dsphong_toa;
            this.dsnhanvien_toa = t.dsnhanvien_toa;
        }
    }
}
