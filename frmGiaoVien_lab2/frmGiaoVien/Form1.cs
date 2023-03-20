using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGiaoVien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int i = this.lbMomHoc.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbMomHoc.SelectedItems[i]);
                this.lbMomHoc.Items.RemoveAt(i);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbMomHoc.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbMonHocDay.Items.Add(lbMomHoc.SelectedItems[i]);
                this.lbMomHoc.Items.RemoveAt(i);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ReSet();
        }
        public void ReSet()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.rdNam.Checked = true;
            for (int i = 0; i < chklNgoaiNgu.Items.Count - 1; i++)
            {
                chklNgoaiNgu.SetItemChecked(i, false);
                foreach (object ob in this.lbMonHocDay.Items)
                { this.lbMomHoc.Items.Add(ob); }
                this.lbMonHocDay.Items.Clear();
            }
        }
        private void frmGiaoVien_Load(object sender, EventArgs e)
        {
            string lienhe = "https://cntt.dlu.edu.vn/";
            this.linklblLienHe.Links.Add(0, lienhe.Length, lienhe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }

        private void linklblLienHe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string s = e.Link.LinkData.ToString();
            Process.Start(s);
        }
        public  GiaoVien GetGiaoVien()
        {

            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiaoVien gv = new GiaoVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dateTimePicker1.Value;
            DanhMucMonHoc mh = new DanhMucMonHoc();
            foreach (object ob in lbMonHocDay.Items)
                mh.Them(new MonHoc(ob.ToString()));
            gv.dsMonHoc = mh;
            gv.GioiTinh = gt;
            string ngoaingu = "";
            for (int i = 0; i < chklNgoaiNgu.Items.Count - 1; i++)
            {
                if (chklNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklNgoaiNgu.Items[i] + ";";
            }
            gv.NgoaiNgu = ngoaingu.Split(';');
            gv.STD = this.txtSDT.Text;
            gv.Mail = this.txtMail.Text;


           return gv;

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            frmTBGiaoVien frm=new frmTBGiaoVien();
            GiaoVien gv=GetGiaoVien();
            if(QuanLyGiaoVien.AddGiaoVien(gv)==false)
            {
                MessageBox.Show("Đã Tồn tại gv này");
                return;
            }    
            frm.SetText(GetGiaoVien().ToString());
            frm.ShowDialog();
        }

      

       
        private void txtSDT_MouseClick(object sender, MouseEventArgs e)
        {
            txtSDT.Text = "";
        }

        private void btnThemGV_Click(object sender, EventArgs e)
        {
            GiaoVien gv = GetGiaoVien();
            if (QuanLyGiaoVien.AddGiaoVien(gv) == false)
            {
                MessageBox.Show("Đã Tồn tại gv này( hoặc trùng mã số)", "thông báo");
                return;
            }
            MessageBox.Show("Đã thêm giáo viên này vào danh sách", "thông báo");
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            Form form  = new TimKiem();
            form.ShowDialog();
        }
    }
}
