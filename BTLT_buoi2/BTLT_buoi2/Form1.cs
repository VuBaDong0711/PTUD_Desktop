using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLT_buoi2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.tabcontrol.TabPages.Clear();
            TabPage tabsv=new TabPage();
            TabPage tabGV=new TabPage();
            TabPage tabMH=new TabPage();
            tabMH.Text = "Môn học";
            tabGV.Text = "Giáo viên";
            tabsv.Text = "Sinh viên";
            this.tabcontrol.TabPages.Add(tabsv);
            this.tabcontrol.TabPages.Add(tabGV);
            this.tabcontrol.TabPages.Add(tabMH);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is open butoon");
        }
    }
}
