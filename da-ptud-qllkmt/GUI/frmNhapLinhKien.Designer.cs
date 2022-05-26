namespace GUI
{
    partial class frmNhapLinhKien
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
            this.components = new System.ComponentModel.Container();
            this.txt_TienNhap = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_MaCTPN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Soluong = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txt_MaSanPham = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_TongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_MaPhieuNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_MaNhanVien = new System.Windows.Forms.TextBox();
            this.txt_MaNhaPhanPhoi = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_SuaCTPN = new System.Windows.Forms.ToolStripButton();
            this.btn_XoaCTPN = new System.Windows.Forms.ToolStripButton();
            this.btn_ThemCTPN = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.dgv_PhieuNhap = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_ThemPN = new System.Windows.Forms.ToolStripButton();
            this.btn_XoaPN = new System.Windows.Forms.ToolStripButton();
            this.btn_SuaPN = new System.Windows.Forms.ToolStripButton();
            this.dgv_ChiTietPhieuNhap = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhap)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_TienNhap
            // 
            this.txt_TienNhap.Location = new System.Drawing.Point(188, 168);
            this.txt_TienNhap.Name = "txt_TienNhap";
            this.txt_TienNhap.Size = new System.Drawing.Size(136, 22);
            this.txt_TienNhap.TabIndex = 79;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 17);
            this.label10.TabIndex = 78;
            this.label10.Text = "Tiền Nhập";
            // 
            // txt_MaCTPN
            // 
            this.txt_MaCTPN.Location = new System.Drawing.Point(188, 28);
            this.txt_MaCTPN.Name = "txt_MaCTPN";
            this.txt_MaCTPN.Size = new System.Drawing.Size(136, 22);
            this.txt_MaCTPN.TabIndex = 72;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 71;
            this.label7.Text = "Mã Phiếu Nhập";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 17);
            this.label8.TabIndex = 73;
            this.label8.Text = "Mã Sản Phẩm";
            // 
            // txt_Soluong
            // 
            this.txt_Soluong.Location = new System.Drawing.Point(188, 117);
            this.txt_Soluong.Name = "txt_Soluong";
            this.txt_Soluong.Size = new System.Drawing.Size(136, 22);
            this.txt_Soluong.TabIndex = 76;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Số Lượng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_TienNhap);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txt_MaCTPN);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txt_Soluong);
            this.groupBox2.Controls.Add(this.txt_MaSanPham);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(744, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(452, 196);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi Tiết Phiếu Nhập";
            // 
            // txt_MaSanPham
            // 
            this.txt_MaSanPham.Location = new System.Drawing.Point(188, 73);
            this.txt_MaSanPham.Name = "txt_MaSanPham";
            this.txt_MaSanPham.Size = new System.Drawing.Size(136, 22);
            this.txt_MaSanPham.TabIndex = 74;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txt_TongTien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txt_MaPhieuNhap);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_MaNhanVien);
            this.groupBox1.Controls.Add(this.txt_MaNhaPhanPhoi);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(13, 136);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(712, 196);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu Nhập";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(427, 71);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 76;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Ngày Nhập";
            // 
            // txt_TongTien
            // 
            this.txt_TongTien.Location = new System.Drawing.Point(458, 24);
            this.txt_TongTien.Name = "txt_TongTien";
            this.txt_TongTien.Size = new System.Drawing.Size(136, 22);
            this.txt_TongTien.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(321, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tổng Tiền Phải Trả";
            // 
            // txt_MaPhieuNhap
            // 
            this.txt_MaPhieuNhap.Location = new System.Drawing.Point(165, 21);
            this.txt_MaPhieuNhap.Name = "txt_MaPhieuNhap";
            this.txt_MaPhieuNhap.Size = new System.Drawing.Size(136, 22);
            this.txt_MaPhieuNhap.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Mã Phiếu Nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Mã Nhà Phân Phối";
            // 
            // txt_MaNhanVien
            // 
            this.txt_MaNhanVien.Location = new System.Drawing.Point(165, 110);
            this.txt_MaNhanVien.Name = "txt_MaNhanVien";
            this.txt_MaNhanVien.Size = new System.Drawing.Size(136, 22);
            this.txt_MaNhanVien.TabIndex = 70;
            // 
            // txt_MaNhaPhanPhoi
            // 
            this.txt_MaNhaPhanPhoi.Location = new System.Drawing.Point(165, 66);
            this.txt_MaNhaPhanPhoi.Name = "txt_MaNhaPhanPhoi";
            this.txt_MaNhaPhanPhoi.Size = new System.Drawing.Size(136, 22);
            this.txt_MaNhaPhanPhoi.TabIndex = 68;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Mã Nhân Viên";
            // 
            // btn_SuaCTPN
            // 
            this.btn_SuaCTPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaCTPN.Name = "btn_SuaCTPN";
            this.btn_SuaCTPN.Size = new System.Drawing.Size(78, 24);
            this.btn_SuaCTPN.Text = "Sửa CTPN";
            // 
            // btn_XoaCTPN
            // 
            this.btn_XoaCTPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaCTPN.Name = "btn_XoaCTPN";
            this.btn_XoaCTPN.Size = new System.Drawing.Size(79, 24);
            this.btn_XoaCTPN.Text = "Xóa CTPN";
            // 
            // btn_ThemCTPN
            // 
            this.btn_ThemCTPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemCTPN.Name = "btn_ThemCTPN";
            this.btn_ThemCTPN.Size = new System.Drawing.Size(90, 24);
            this.btn_ThemCTPN.Text = "Thêm CTPN";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemCTPN,
            this.btn_XoaCTPN,
            this.btn_SuaCTPN});
            this.toolStrip2.Location = new System.Drawing.Point(0, 27);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1176, 27);
            this.toolStrip2.TabIndex = 85;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // dgv_PhieuNhap
            // 
            this.dgv_PhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_PhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PhieuNhap.Location = new System.Drawing.Point(13, 353);
            this.dgv_PhieuNhap.Name = "dgv_PhieuNhap";
            this.dgv_PhieuNhap.RowTemplate.Height = 24;
            this.dgv_PhieuNhap.Size = new System.Drawing.Size(1183, 182);
            this.dgv_PhieuNhap.TabIndex = 84;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_ThemPN,
            this.btn_XoaPN,
            this.btn_SuaPN});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1176, 27);
            this.toolStrip1.TabIndex = 83;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_ThemPN
            // 
            this.btn_ThemPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_ThemPN.Name = "btn_ThemPN";
            this.btn_ThemPN.Size = new System.Drawing.Size(130, 24);
            this.btn_ThemPN.Text = "Thêm Phiếu Nhập";
            // 
            // btn_XoaPN
            // 
            this.btn_XoaPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_XoaPN.Name = "btn_XoaPN";
            this.btn_XoaPN.Size = new System.Drawing.Size(119, 24);
            this.btn_XoaPN.Text = "Xóa Phiếu Nhập";
            // 
            // btn_SuaPN
            // 
            this.btn_SuaPN.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_SuaPN.Name = "btn_SuaPN";
            this.btn_SuaPN.Size = new System.Drawing.Size(118, 24);
            this.btn_SuaPN.Text = "Sửa Phiếu Nhập";
            // 
            // dgv_ChiTietPhieuNhap
            // 
            this.dgv_ChiTietPhieuNhap.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_ChiTietPhieuNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ChiTietPhieuNhap.Location = new System.Drawing.Point(13, 561);
            this.dgv_ChiTietPhieuNhap.Name = "dgv_ChiTietPhieuNhap";
            this.dgv_ChiTietPhieuNhap.Size = new System.Drawing.Size(1183, 169);
            this.dgv_ChiTietPhieuNhap.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(366, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 40);
            this.label2.TabIndex = 81;
            this.label2.Text = "Thông tin linh kiện nhập vào";
            // 
            // frmNhapLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 773);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.dgv_PhieuNhap);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_ChiTietPhieuNhap);
            this.Controls.Add(this.label2);
            this.Name = "frmNhapLinhKien";
            this.Text = "frmNhapLinhKien";
            this.Load += new System.EventHandler(this.frmNhapLinhKien_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PhieuNhap)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ChiTietPhieuNhap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_TienNhap;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_MaCTPN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Soluong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txt_MaSanPham;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_TongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_MaPhieuNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_MaNhanVien;
        private System.Windows.Forms.TextBox txt_MaNhaPhanPhoi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripButton btn_SuaCTPN;
        private System.Windows.Forms.ToolStripButton btn_XoaCTPN;
        private System.Windows.Forms.ToolStripButton btn_ThemCTPN;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.DataGridView dgv_PhieuNhap;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_ThemPN;
        private System.Windows.Forms.ToolStripButton btn_XoaPN;
        private System.Windows.Forms.ToolStripButton btn_SuaPN;
        private System.Windows.Forms.DataGridView dgv_ChiTietPhieuNhap;
        private System.Windows.Forms.Label label2;

    }
}