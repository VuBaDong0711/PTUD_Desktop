using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace lab3_demo
{
    public delegate int SoSanh(object sv1,object sv2);
    public   class QuanLySinhVien
    {
        public List<SinhVien> DanhSach;
        public QuanLySinhVien()
        {
            DanhSach=new List<SinhVien>();
        }
        public void Them(SinhVien sv)
        {
            DanhSach.Add(sv);
        }
        public SinhVien this[int index]
        {
            get { return DanhSach[index]; }
            set { DanhSach[index] = value; }
        }
      
    public void Xoa(object obj,SoSanh ss)
        {
            int i = DanhSach.Count - 1;
            for(;i>=0;i--)
            {
                if (ss(obj, this[i])==0)
                {
                    this.DanhSach.RemoveAt(i);
                }    
            }
        }
        public SinhVien Tim(object obj,SoSanh ss)
        {
            SinhVien svresult = null;
            foreach  (SinhVien sv in DanhSach)
            {
                if
                    (ss(obj, sv) == 0)
                {
                    svresult = sv; }
                break;
            }
            return svresult;
        }
        public bool Sua( SinhVien svSua,string ms )
        {
           // int i, count;
            bool kq=false;
          SinhVien the=new SinhVien();
           foreach(SinhVien sv in DanhSach)
            {
                if (sv.MaSo.Trim().CompareTo(ms.Trim()) == 0)
                {
                    kq=true;
                    the=sv; 
                }
                
                  //  sv = svSua;
            }
            DanhSach.Remove(the);
            DanhSach.Add(svSua);
            return kq;
        }
        public void SapXep1(int kieu)
        {
            if(kieu==1)
            {
                DanhSach.Sort((x, y) => int.Parse(x.MaSo).CompareTo(int.Parse(y.MaSo)));
                return;
            }
            if (kieu == 2)
            {
                DanhSach.Sort((x, y) => x.HoTen.CompareTo(y.HoTen));
                return;
            }
            if(kieu==3)
            {

               
                DanhSach.Sort((x,y)=>x.NGaySinh.CompareTo(y.NGaySinh));
                return;
            } 
        }
        public List<SinhVien> TimKiem(int kieu,string data)
        {List<SinhVien> ds=new List<SinhVien>();
            if(kieu==1)
                foreach(SinhVien item in DanhSach)
                {
                    if(item.MaSo.Trim().CompareTo(data.Trim())==0)
                        ds.Add(item);
                }    
            if(kieu==2)
                foreach(SinhVien item in DanhSach)
                {
                    if (item.HoTen.Trim().Contains(data.Trim()))
                        ds.Add(item);
                   
                }
            if (kieu == 3)
            {
                foreach (SinhVien item in DanhSach)
                {
                    if (item.NGaySinh.ToString() == data.Trim())
                        ds.Add(item);
                }
            }
            return ds;
        }

        public  void  DocTuFile()
        {
            string filename = "DanhSachSV.txt", t;
            string[] s;
            SinhVien sv;
            StreamReader sr = new StreamReader(
            new FileStream(filename,
           FileMode.Open));
            while ((t = sr.ReadLine()) != null)
            {
                s = t.Split('\t');
                sv = new SinhVien();
                sv.MaSo = s[0];
                sv.HoTen = s[1];
                sv.NGaySinh = DateTime.Parse(s[2]);
                sv.DiaChi = s[3];
                sv.Lop = s[4];
                sv.Hinh = s[5];
                sv.GioiTinh = false;
                if (s[6] == "1")
                    sv.GioiTinh = true;
                string[] cn = s[7].Split(',');
                foreach (string c in cn)
                    sv.ChuyeNganh.Add(c);
                this.Them(sv);
            }
        }
    }
    }

