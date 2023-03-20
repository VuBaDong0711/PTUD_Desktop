using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmGiaoVien
{
    public partial class TimKiem : Form
    {
        public TimKiem()
        {
            InitializeComponent();
        }

       

        private void rdTimMaGV_CheckedChanged(object sender, EventArgs e)
        {
            if(rdTimMaGV.Checked)
            {
                txtTimKiem.Text = "Mã GV";
            }
        }

        private void rdTimHoTen_CheckedChanged(object sender, EventArgs e)
        {
            if(rdTimHoTen.Checked)
            {
                txtTimKiem.Text = "Họ Tên";
            }    
        }

        private void rdTimSDT_CheckedChanged(object sender, EventArgs e)
        {
            if(rdTimSDT.Checked)
            {
                txtTimKiem.Text = "Số điện thoại";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GiaoVien gv=new GiaoVien();
            if(rdTimMaGV.Checked)
            gv = QuanLyGiaoVien.TimKiem(0, txtNhapTimKiem.Text);
            else if(rdTimHoTen.Checked)
            {
                gv = QuanLyGiaoVien.TimKiem(1, txtNhapTimKiem.Text);
            }
            else
            {
                gv = QuanLyGiaoVien.TimKiem(2, txtNhapTimKiem.Text);
            }
            if (gv == null)
            {
                MessageBox.Show("Không tìm thấy giáo viên có điều kiện tương ứng");

            }
            else
            {
                frmTBGiaoVien frm = new frmTBGiaoVien();
                 
               
                frm.SetText(gv.ToString());
                frm.ShowDialog();
            }
        }

        private void Xóa_Click(object sender, EventArgs e)
        {
            GiaoVien gv = new GiaoVien();
            if (rdTimMaGV.Checked)
                gv = QuanLyGiaoVien.TimKiem(0, txtNhapTimKiem.Text);
            else if (rdTimHoTen.Checked)
            {
                gv = QuanLyGiaoVien.TimKiem(1, txtNhapTimKiem.Text);
            }
            else
            {
                gv = QuanLyGiaoVien.TimKiem(2, txtNhapTimKiem.Text);
            }
            if (gv == null)
            {
                MessageBox.Show("Không tìm thấy giáo viên có điều kiện tương ứng");

            }
            else
            {
                QuanLyGiaoVien.Xoa(gv);
                MessageBox.Show("Đã xóa thành công giáo viên này");
            }
        }
    }
}
