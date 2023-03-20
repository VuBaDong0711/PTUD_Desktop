namespace frmGiaoVien
{
    partial class TimKiem
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdTimSDT = new System.Windows.Forms.RadioButton();
            this.rdTimHoTen = new System.Windows.Forms.RadioButton();
            this.rdTimMaGV = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.Label();
            this.txtNhapTimKiem = new System.Windows.Forms.TextBox();
            this.Xóa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdTimSDT);
            this.groupBox1.Controls.Add(this.rdTimHoTen);
            this.groupBox1.Controls.Add(this.rdTimMaGV);
            this.groupBox1.Location = new System.Drawing.Point(77, 66);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(455, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Theo";
            // 
            // rdTimSDT
            // 
            this.rdTimSDT.AutoSize = true;
            this.rdTimSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTimSDT.Location = new System.Drawing.Point(252, 34);
            this.rdTimSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTimSDT.Name = "rdTimSDT";
            this.rdTimSDT.Size = new System.Drawing.Size(140, 24);
            this.rdTimSDT.TabIndex = 0;
            this.rdTimSDT.TabStop = true;
            this.rdTimSDT.Text = "Số điện thoại";
            this.rdTimSDT.UseVisualStyleBackColor = true;
            this.rdTimSDT.CheckedChanged += new System.EventHandler(this.rdTimSDT_CheckedChanged);
            // 
            // rdTimHoTen
            // 
            this.rdTimHoTen.AutoSize = true;
            this.rdTimHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTimHoTen.Location = new System.Drawing.Point(125, 34);
            this.rdTimHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTimHoTen.Name = "rdTimHoTen";
            this.rdTimHoTen.Size = new System.Drawing.Size(91, 24);
            this.rdTimHoTen.TabIndex = 0;
            this.rdTimHoTen.TabStop = true;
            this.rdTimHoTen.Text = "Họ Tên";
            this.rdTimHoTen.UseVisualStyleBackColor = true;
            this.rdTimHoTen.CheckedChanged += new System.EventHandler(this.rdTimHoTen_CheckedChanged);
            // 
            // rdTimMaGV
            // 
            this.rdTimMaGV.AutoSize = true;
            this.rdTimMaGV.Checked = true;
            this.rdTimMaGV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdTimMaGV.Location = new System.Drawing.Point(21, 34);
            this.rdTimMaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rdTimMaGV.Name = "rdTimMaGV";
            this.rdTimMaGV.Size = new System.Drawing.Size(87, 24);
            this.rdTimMaGV.TabIndex = 0;
            this.rdTimMaGV.TabStop = true;
            this.rdTimMaGV.Text = "Mã GV";
            this.rdTimMaGV.UseVisualStyleBackColor = true;
            this.rdTimMaGV.CheckedChanged += new System.EventHandler(this.rdTimMaGV_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(461, 199);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.AutoSize = true;
            this.txtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimKiem.Location = new System.Drawing.Point(73, 199);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(66, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.Text = "Mã GV";
            // 
            // txtNhapTimKiem
            // 
            this.txtNhapTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhapTimKiem.Location = new System.Drawing.Point(203, 199);
            this.txtNhapTimKiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNhapTimKiem.Name = "txtNhapTimKiem";
            this.txtNhapTimKiem.Size = new System.Drawing.Size(233, 26);
            this.txtNhapTimKiem.TabIndex = 3;
            // 
            // Xóa
            // 
            this.Xóa.Location = new System.Drawing.Point(243, 250);
            this.Xóa.Name = "Xóa";
            this.Xóa.Size = new System.Drawing.Size(135, 47);
            this.Xóa.TabIndex = 4;
            this.Xóa.Text = "btnXoa";
            this.Xóa.UseVisualStyleBackColor = true;
            this.Xóa.Click += new System.EventHandler(this.Xóa_Click);
            // 
            // TimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 450);
            this.Controls.Add(this.Xóa);
            this.Controls.Add(this.txtNhapTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TimKiem";
            this.Text = "Tìm Kiếm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdTimSDT;
        private System.Windows.Forms.RadioButton rdTimHoTen;
        private System.Windows.Forms.RadioButton rdTimMaGV;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label txtTimKiem;
        private System.Windows.Forms.TextBox txtNhapTimKiem;
        private System.Windows.Forms.Button Xóa;
    }
}