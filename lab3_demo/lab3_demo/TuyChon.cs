using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_demo
{

    public partial class frmTuyChon : Form
    {
        // QuanLySinhVien qlsv;
        public int KieuSapXep;
        public string data="";
        public int chon;
        public frmTuyChon()
        {
            InitializeComponent();
          // frmSinhVien sv=new frmSinhVien();
            //frmSinhVien sv;
            //sv.Xoa();
        }

        

        private void txtThongTin_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem.Enabled = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {

           
               // KieuSapXep = 1;
            if (rdbMaSV.Checked)
                KieuSapXep = 1;
            if (rdbHoTen.Checked)
                KieuSapXep = 2;
            if(rdbNgaySinh.Checked)
                KieuSapXep = 3;
            chon = 1;
            this.DialogResult=DialogResult.OK;
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
           // KieuSapXep = 1;
            if (rdbMaSV.Checked)
                KieuSapXep = 1;
            if (rdbHoTen.Checked)
                KieuSapXep = 2;
            if(rdbNgaySinh.Checked)
                KieuSapXep = 3;
            data = txtThongTin.Text;
            chon = 2;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
       

    }
}
