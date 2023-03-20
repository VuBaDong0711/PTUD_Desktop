using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmGiaoVien
{
    public class GiaoVien
    {
        public string MaSo { get; set; }
        public string HoTen { get; set; }
        public DateTime NgaySinh;
        public DanhMucMonHoc dsMonHoc;
        public string GioiTinh;
        public string[] NgoaiNgu;
        public string STD;
        public string Mail;
        public GiaoVien()
        {
            dsMonHoc = new DanhMucMonHoc();
            NgoaiNgu = new string[10];
        }

        public GiaoVien(string maSo, string hoTen, DateTime ngaySinh, DanhMucMonHoc dsMonHoc, string gioiTinh, string[] ngoaiNgu, string sTD, string mail)
        {
            MaSo = maSo;
            HoTen = hoTen;
            NgaySinh = ngaySinh;
            this.dsMonHoc = dsMonHoc;
            GioiTinh = gioiTinh;
            NgoaiNgu = ngoaiNgu;
            STD = sTD;
            Mail = mail;

        }
        public override string ToString()
        {
            string s = "Mã Số: " + MaSo +
                "\nHọ tên: " + HoTen +
                "\nNgày Sinh: " + NgaySinh.ToString() +
                "\nSố ĐT: " + STD +
                "\nMail: " + Mail;
            string gg = "Ngoại ngữ: ";
            foreach (string t in NgoaiNgu)
            {
                gg += t + ";";
            }
            string monDay = "danh sách môn dạy: ";
            foreach (MonHoc dsMonHoc in dsMonHoc.ds)
            {
                monDay += dsMonHoc + ";";
            }
            return s + "\n" + gg + "\n" + monDay;

        }
    }
}
