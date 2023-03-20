using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFrom_Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbNam_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ReSet()
        {
            this.cboMaHV.Text = "";
            this.txtHoTen.Text = "";
            this.dtpNgayDK.Value = DateTime.Now;
            this.rdbNam.Checked = false;
            this.chkTiengAnhA.Checked = false;
            this.chkTiengAnhB.Checked = false;
            this.chkTinHocA.Checked = false;
            this.chkTinHocB.Checked = false;
            this.txtTongTien.Text = "";


        }
        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.ReSet();

        }

        private void btnTinhTien_Click(object sender, EventArgs e)
        {
            int tong = 0;
            if (chkTiengAnhA.Checked)
            {
                tong += int.Parse(lblTienTHA.Text.Split('.')[0]);
            }
            if (chkTiengAnhB.Checked)
            {
                tong += int.Parse(lblTienTHB.Text.Split('.')[0]);
            }
            if (chkTinHocA.Checked)
            {
                tong += int.Parse(lblTienTHA.Text.Split('.')[0]);
            }
            if (chkTinHocB.Checked)
            {
                tong += int.Parse(lblTienTHB.Text.Split('.')[0]);
            }
            this.txtTongTien.Text = tong + ".000 đồng";
        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboMaHV_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = cboMaHV.SelectedIndex;
            if (i == 0)
                txtHoTen.Text = "Ngyễn Văn A";
            else if (i == 1)
                txtHoTen.Text = "Ngyễn Văn B";
            else if (i == 2)
                txtHoTen.Text = "Ngyễn Văn C";
            else if (i == 3)
                txtHoTen.Text = "Ngyễn Văn D";
            else 
                txtHoTen.Text = "";
        }
    }
    }

