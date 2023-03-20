using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace frmGiaoVien
{
    public  class QuanLyGiaoVien
    {
        
       public static List<GiaoVien> dsGV=new List<GiaoVien>();

        public  static bool AddGiaoVien(GiaoVien giaoVien)
        {
            if (dsGV.Find(x => x.MaSo == giaoVien.MaSo) == null)
            {
                dsGV.Add(giaoVien);
                return true;
            }
            return false;
        }
        QuanLyGiaoVien() {
        }
        //kieuTimKiem kieu=kieuTimKiem.timTheoMaGV;
        public static GiaoVien TimKiem(int  kieu,string value)
        {
            if (kieu == 0)
                  foreach(GiaoVien g in dsGV)
                {
                    if(g.MaSo==value)
                    {
                        return g;
                    }
                }    
            else if(kieu == 1)
                foreach (GiaoVien g in dsGV)
                {
                    if (g.HoTen == value)
                    {
                        return g;
                    }
                }
            else foreach(GiaoVien g in dsGV)
                { if (g.STD == value) { return g; } }
            
            return null;
                
            
        }
        public static bool Xoa(GiaoVien gv)
        {
            dsGV.Remove(gv);
            return true;
        }
    }
}
