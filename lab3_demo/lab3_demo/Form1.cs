using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace lab3_demo
{
    public partial class frmSinhVien : Form
    {
        QuanLySinhVien qlsv;
      
       
        public frmSinhVien()
        {
            InitializeComponent();

            
        }
        //them sv vao list view
        #region
        private SinhVien GetSinhVien()
        {
            
            SinhVien sv=new SinhVien();
            bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo=this.mtxtMaSo.Text;
            sv.HoTen=this.txtxHoTen.Text;
            sv.NGaySinh=this.dtpNgaySinh.Value;
            sv.DiaChi=this.txtDiaChi.Text;
            sv.Lop = this.cboLop.Text;
            sv.Hinh=this.txtHinh.Text;
            if (rdNu.Checked)
                gt = false;
            for(int i=0;i<this.clbChuyenNganh.Items.Count;i++)
            {
                if(clbChuyenNganh.GetItemChecked(i))
                    cn.Add(clbChuyenNganh.Items[i].ToString());
                
            }   
            sv.ChuyeNganh=cn;
            return sv;
        }
        private SinhVien GetSinhVien(ListViewItem lvitem)
        {
            SinhVien sv=    new SinhVien();
            //bool gt = true;
            List<string> cn = new List<string>();
            sv.MaSo = lvitem.SubItems[0].Text;
            sv.HoTen = lvitem.SubItems[1].Text;
            sv.NGaySinh = DateTime.Parse(lvitem.SubItems[2].Text);
            sv.DiaChi = lvitem.SubItems[3].Text;
            sv.Lop = lvitem.SubItems[4].Text;
            sv.GioiTinh = false;
            if(lvitem.SubItems[5].Text=="Nam")
                sv.GioiTinh= true;
            string[] s = lvitem.SubItems[6].Text.Split(',');
            foreach(string s2 in s)
                cn.Add(s2);
            sv.ChuyeNganh = cn;
            sv.Hinh = lvitem.SubItems[7].Text;
            return sv;
        }

        //thiết lập thôgn tin sinh viên trên controls
        private void ThietLapThongTin(SinhVien sv)
        {
            this.mtxtMaSo.Text = sv.MaSo;
            this.txtxHoTen.Text = sv.HoTen;
            this.dtpNgaySinh.Value = sv.NGaySinh;
            this.txtDiaChi.Text = sv.DiaChi;
            this.cboLop.Text = sv.Lop;  
            this.txtHinh.Text = sv.Hinh;
            this.pdHinh.ImageLocation = sv.Hinh;
            if (sv.GioiTinh)
                this.rdNam.Checked = true;
            else this.rdNu.Checked = true;
            for(int i=0;i<this.clbChuyenNganh.Items.Count;i++)
                this.clbChuyenNganh.SetItemChecked(i, false);
            foreach (string s in sv.ChuyeNganh)
                for (int i = 0; i < this.clbChuyenNganh.Items.Count; i++)
                    if (s.CompareTo(this.clbChuyenNganh.Items[i]) == 0)
                        this.clbChuyenNganh.SetItemChecked(i, true);
        }
        private void ThemSV(SinhVien sv)
        {
            ListViewItem lview=new ListViewItem(sv.MaSo);
            lview.SubItems.Add(sv.HoTen);
            lview.SubItems.Add(sv.NGaySinh.ToShortDateString());
            lview.SubItems.Add(sv.DiaChi);
            lview.SubItems.Add(sv.Lop);
            string gt = "Nữ";
            if (sv.GioiTinh)
                gt = "Nam";
            lview.SubItems.Add(gt);
            string cn = "";
            foreach (string s in sv.ChuyeNganh)
                cn += s + ",";
           cn=cn.Substring(0, cn.Length - 1);
            lview.SubItems.Add(cn);
            lview.SubItems.Add(sv.Hinh);
            this.lvSinhVien.Items.Add(lview);
        }    
        //hiển thị sinh viên lên list sinh viên
        private void LoadListView()
        {
            this.lvSinhVien.Items.Clear();
            foreach(SinhVien sv in qlsv.DanhSach)
            {
                ThemSV(sv);
            }
           
           sttTongSV.Text = string.Empty;
            sttTongSV.Text ="Tổng số sinh viên:" + lvSinhVien.Items.Count;   
        }

        #endregion

        private void lvSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            int count = this.lvSinhVien.SelectedItems.Count;
            if(count>0)
            {
                ListViewItem lvitem = this.lvSinhVien.SelectedItems[0] ;
                SinhVien sv=GetSinhVien(lvitem);
                ThietLapThongTin(sv);
            }    
        }
      

       

        

        private void btnThem_Click(object sender, EventArgs e)
        {


            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if(kq!=null)
                MessageBox.Show("Mã số sinh viên đã tồn tại","lỗi dữ thêm dữ liệu",MessageBoxButtons.OK,MessageBoxIcon.Error);
            else {
                this.qlsv.Them(sv);
                this.LoadListView();
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count =this.lvSinhVien.Items.Count-1;
            for(i=count;i>=0;i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }
        private int SoSanhTheoMa(object obj1 ,object obj2)
        {
            SinhVien sv=obj2 as SinhVien;   
            return sv.MaSo.CompareTo(obj1.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
            string[] maso = sv.MaSo.Split(',');
            kqsua = qlsv.Sua(sv, maso[1]);
            if (kqsua)

            {
                MessageBox.Show("Sửa thành công");
                this.LoadListView();
            }

        }

        private void btnMacDinh_Click(object sender, EventArgs e)
        {
            this.mtxtMaSo.Text = "";
            this.mtxtMaSo.Text ="";
            this.txtxHoTen.Text ="";
            this.dtpNgaySinh.Value =DateTime.Now;
            this.txtDiaChi.Text = "";
            this.cboLop.Text = "";
            this.txtHinh.Text = ""; 
            this.pdHinh.ImageLocation ="";
            this.rdNam.Checked = true;
           for(int i=0;i<this.clbChuyenNganh.Items.Count-1;i++)
            {
                this.clbChuyenNganh.SetItemChecked(i, false);
            }    
           
        }

  

        private void frmSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QuanLySinhVien();
            qlsv.DocTuFile();
            LoadListView();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFile();
        }
        private void OpenFile()
        {
            OpenFileDialog thedialog = new OpenFileDialog();
            thedialog.Title = "open file image";
            thedialog.Multiselect = true;
            thedialog.Filter = "JPGE file |*.jpg;*.jpeg" + "bitmap files |*.bmp" + "all file (*.*)|*.*";
            thedialog.InitialDirectory = Environment.CurrentDirectory;
            thedialog.InitialDirectory = Environment.CurrentDirectory;
            if (thedialog.ShowDialog() == DialogResult.OK)
            {
                txtHinh.Text = thedialog.FileName;

            }
        }

   
        private void lvtsThem_Click(object sender, EventArgs e)
        {

            SinhVien sv = GetSinhVien();
            SinhVien kq = qlsv.Tim(sv.MaSo, delegate (object obj1, object obj2)
            {
                return (obj2 as SinhVien).MaSo.CompareTo(obj1.ToString());
            });
            if (kq != null)
                MessageBox.Show("Mã số sinh viên đã tồn tại", "lỗi dữ thêm dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                this.qlsv.Them(sv);
                this.LoadListView();
            }
        }

        private void lvtsXoa_Click(object sender, EventArgs e)
        {
            int count, i;
            ListViewItem lvitem;
            count = this.lvSinhVien.Items.Count - 1;
            for (i = count; i >= 0; i--)
            {
                lvitem = this.lvSinhVien.Items[i];
                if (lvitem.Checked)
                    qlsv.Xoa(lvitem.SubItems[0].Text, SoSanhTheoMa);
            }
            this.LoadListView();
            this.btnMacDinh.PerformClick();
        }

        private void lvtsSua_Click(object sender, EventArgs e)
        {
            SinhVien sv = GetSinhVien();
            bool kqsua;
             string[] maso = sv.MaSo.Split(',');
            kqsua = qlsv.Sua(sv, maso[1]);
            if (kqsua)

            {
                MessageBox.Show("Sửa thành công");
                this.LoadListView(); 
            }

        }
        private void tsmiFont_Click(object sender, EventArgs e)
        {
  FontDialog font = new FontDialog();
            if (font.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.Font = font.Font;
            }
        }

        private void tsmiFontColor_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                lvSinhVien.ForeColor = colorDialog.Color;
            }

        }

   
        private void tsmiOpenFile_Click(object sender, EventArgs e)
        {
            OpenFile();
        }

        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        } 
        private void tsmSapXep_Click(object sender, EventArgs e)
        {
            TuyChon();
        }

      
        public void TuyChon()
        {
            int kieu = 0;
            string data = "";
            var frm = new frmTuyChon();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                kieu = frm.KieuSapXep;
                data = frm.data;
            }
            if (frm.chon == 1)
                SapXep(kieu);
            if (frm.chon == 2)
                TimKien(kieu, data);
        }
        private void TimKien(int kieu, string data)
        { 
            lvSinhVien.Items.Clear();
            List<SinhVien> sinhViens= new List<SinhVien>();
           sinhViens= qlsv.TimKiem(kieu, data);
            if (sinhViens.Count == 0)
                MessageBox.Show("không tồn tại sinh viên này");
            else
                MessageBox.Show("Đã tìm thấy sinh viên");
            foreach (SinhVien sv in sinhViens)
            {
                ThemSV(sv);
            }
            sttTongSV.Text = string.Empty;
            sttTongSV.Text = "Tổng số sinh viên:" + lvSinhVien.Items.Count;
        }
        //===============================================================
   private void SapXep(int kieu)
        {
            if (kieu == 1)
            {
                MessageBox.Show("Sắp xếp sinh viên theo mã giảm dần");
                qlsv.SapXep1(1);
            }
             if  (kieu == 2)
            {
                MessageBox.Show("Sắp xếp sinh viên theo tên giảm dần");
                qlsv.SapXep1(2);
            }
            if (kieu == 3)
            {
                MessageBox.Show("Sắp xếp sinh viên theo ngày sinh giảm dần");
                qlsv.SapXep1(3);
            }
            LoadListView();     
        }

        private void btnHienThiDS_Click(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void tsmiTimKiem_Click_1(object sender, EventArgs e)
        {
            TuyChon();
        }
    }

}
