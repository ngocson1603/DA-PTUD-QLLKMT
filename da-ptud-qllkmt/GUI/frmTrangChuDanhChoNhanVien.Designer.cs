namespace GUI
{
    partial class frmTrangChuDanhChoNhanVien
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.button1 = new System.Windows.Forms.Button();
            this.dgv_muaban = new System.Windows.Forms.DataGridView();
            this.tsmitaikhoan = new System.Windows.Forms.ToolStripMenuItem();
            this.đổiMậtKhẩuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liênHệToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cậpNhậtPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitemNhaplinhkien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiHienthitimkiem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLichsumuaban = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmithongke = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNhapvao = new System.Windows.Forms.Button();
            this.btnBanra = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muaban)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmitaikhoan,
            this.liênHệToolStripMenuItem,
            this.tsmitemNhaplinhkien,
            this.tsmiHienthitimkiem,
            this.tsmiLichsumuaban,
            this.tsmithongke});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1207, 30);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::GUI.Properties.Resources.dangxuat;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(991, 115);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 66);
            this.button1.TabIndex = 16;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dgv_muaban
            // 
            this.dgv_muaban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_muaban.Location = new System.Drawing.Point(12, 180);
            this.dgv_muaban.Name = "dgv_muaban";
            this.dgv_muaban.RowTemplate.Height = 24;
            this.dgv_muaban.Size = new System.Drawing.Size(1146, 439);
            this.dgv_muaban.TabIndex = 15;
            // 
            // tsmitaikhoan
            // 
            this.tsmitaikhoan.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.đổiMậtKhẩuToolStripMenuItem});
            this.tsmitaikhoan.Image = global::GUI.Properties.Resources.taikhoan;
            this.tsmitaikhoan.Name = "tsmitaikhoan";
            this.tsmitaikhoan.Size = new System.Drawing.Size(105, 24);
            this.tsmitaikhoan.Text = "&Tài Khoản";
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            this.đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            this.đổiMậtKhẩuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.đổiMậtKhẩuToolStripMenuItem.Size = new System.Drawing.Size(228, 26);
            this.đổiMậtKhẩuToolStripMenuItem.Text = "Đổi Mật Khẩu";
            // 
            // liênHệToolStripMenuItem
            // 
            this.liênHệToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.liênHệToolStripMenuItem1,
            this.cậpNhậtPhầnMềmToolStripMenuItem});
            this.liênHệToolStripMenuItem.Image = global::GUI.Properties.Resources.info;
            this.liênHệToolStripMenuItem.Name = "liênHệToolStripMenuItem";
            this.liênHệToolStripMenuItem.Size = new System.Drawing.Size(104, 24);
            this.liênHệToolStripMenuItem.Text = "&Thông tin";
            // 
            // liênHệToolStripMenuItem1
            // 
            this.liênHệToolStripMenuItem1.Image = global::GUI.Properties.Resources.lienhe;
            this.liênHệToolStripMenuItem1.Name = "liênHệToolStripMenuItem1";
            this.liênHệToolStripMenuItem1.Size = new System.Drawing.Size(220, 26);
            this.liênHệToolStripMenuItem1.Text = "&Liên Hệ";
            // 
            // cậpNhậtPhầnMềmToolStripMenuItem
            // 
            this.cậpNhậtPhầnMềmToolStripMenuItem.Image = global::GUI.Properties.Resources.capnhat1;
            this.cậpNhậtPhầnMềmToolStripMenuItem.Name = "cậpNhậtPhầnMềmToolStripMenuItem";
            this.cậpNhậtPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(220, 26);
            this.cậpNhậtPhầnMềmToolStripMenuItem.Text = "&Cập Nhật Phần Mềm";
            // 
            // tsmitemNhaplinhkien
            // 
            this.tsmitemNhaplinhkien.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmitemNhaplinhkien.Image = global::GUI.Properties.Resources.nhap3;
            this.tsmitemNhaplinhkien.Name = "tsmitemNhaplinhkien";
            this.tsmitemNhaplinhkien.Size = new System.Drawing.Size(166, 25);
            this.tsmitemNhaplinhkien.Text = "&Quản lý linh kiện";
            this.tsmitemNhaplinhkien.Visible = false;
            // 
            // tsmiHienthitimkiem
            // 
            this.tsmiHienthitimkiem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmiHienthitimkiem.Image = global::GUI.Properties.Resources.hienthi1;
            this.tsmiHienthitimkiem.Name = "tsmiHienthitimkiem";
            this.tsmiHienthitimkiem.Size = new System.Drawing.Size(175, 25);
            this.tsmiHienthitimkiem.Text = "&Hiển thị sản phẩm";
            this.tsmiHienthitimkiem.Visible = false;
            // 
            // tsmiLichsumuaban
            // 
            this.tsmiLichsumuaban.Image = global::GUI.Properties.Resources.lichsumuaban;
            this.tsmiLichsumuaban.Name = "tsmiLichsumuaban";
            this.tsmiLichsumuaban.Size = new System.Drawing.Size(148, 25);
            this.tsmiLichsumuaban.Text = "Lịch sử mua bán";
            this.tsmiLichsumuaban.Visible = false;
            // 
            // tsmithongke
            // 
            this.tsmithongke.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tsmithongke.Image = global::GUI.Properties.Resources.thongketimkiem;
            this.tsmithongke.Name = "tsmithongke";
            this.tsmithongke.Size = new System.Drawing.Size(205, 25);
            this.tsmithongke.Text = "Thống &kê - Tìm Kiếm";
            this.tsmithongke.Visible = false;
            // 
            // btnNhapvao
            // 
            this.btnNhapvao.BackgroundImage = global::GUI.Properties.Resources.nhapvao;
            this.btnNhapvao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNhapvao.Location = new System.Drawing.Point(902, 115);
            this.btnNhapvao.Name = "btnNhapvao";
            this.btnNhapvao.Size = new System.Drawing.Size(83, 66);
            this.btnNhapvao.TabIndex = 14;
            this.btnNhapvao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapvao.UseVisualStyleBackColor = true;
            // 
            // btnBanra
            // 
            this.btnBanra.BackgroundImage = global::GUI.Properties.Resources.banra;
            this.btnBanra.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBanra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanra.Location = new System.Drawing.Point(790, 115);
            this.btnBanra.Name = "btnBanra";
            this.btnBanra.Size = new System.Drawing.Size(106, 66);
            this.btnBanra.TabIndex = 13;
            this.btnBanra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBanra.UseVisualStyleBackColor = true;
            // 
            // frmTrangChuDanhChoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 679);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgv_muaban);
            this.Controls.Add(this.btnNhapvao);
            this.Controls.Add(this.btnBanra);
            this.Name = "frmTrangChuDanhChoNhanVien";
            this.Text = "frmTrangChuDanhChoNhanVien";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_muaban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmitaikhoan;
        private System.Windows.Forms.ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liênHệToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cậpNhậtPhầnMềmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmitemNhaplinhkien;
        private System.Windows.Forms.ToolStripMenuItem tsmiHienthitimkiem;
        private System.Windows.Forms.ToolStripMenuItem tsmiLichsumuaban;
        private System.Windows.Forms.ToolStripMenuItem tsmithongke;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgv_muaban;
        private System.Windows.Forms.Button btnNhapvao;
        private System.Windows.Forms.Button btnBanra;
    }
}