using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3_demo
{
    public class SinhVien
    {
        public string  MaSo { get; set; }
        public string HoTen  { get; set; }
        public DateTime NGaySinh { get; set; }
        public string  DiaChi { get; set; }
        public string Lop { get; set; }
        public string  Hinh { get; set; }
        public bool GioiTinh { get; set; }
        public List<string> ChuyeNganh  { get; set; }
        public SinhVien() {
            ChuyeNganh = new List<string>();
        }
        public SinhVien(string maSo, string hoTen, DateTime nGaySinh, string diaChi, string lop, string hinh, bool gioiTinh, List<string> chuyeNganh)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NGaySinh = nGaySinh;
            DiaChi = diaChi;
            Lop = lop;
            Hinh = hinh;
            GioiTinh = gioiTinh;
            ChuyeNganh = chuyeNganh;
        }
    }
}
