﻿namespace GUI
{
    partial class frmQuanLySP
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
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.lbl_image = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txt_TonKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.txt_LoaiSP = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.txt_HangSX = new System.Windows.Forms.TextBox();
            this.txt_MaNPP = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.dgv_QLLK = new System.Windows.Forms.DataGridView();
            this.btn_Dong = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.lblmsv = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLK)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Image
            // 
            this.txt_Image.Location = new System.Drawing.Point(535, 225);
            this.txt_Image.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(160, 22);
            this.txt_Image.TabIndex = 82;
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_image.Location = new System.Drawing.Point(423, 225);
            this.lbl_image.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(46, 17);
            this.lbl_image.TabIndex = 81;
            this.lbl_image.Text = "Image";
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(535, 254);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(160, 38);
            this.btn.TabIndex = 80;
            this.btn.Text = "Chọn tệp";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_TonKho
            // 
            this.txt_TonKho.Location = new System.Drawing.Point(172, 225);
            this.txt_TonKho.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TonKho.Name = "txt_TonKho";
            this.txt_TonKho.Size = new System.Drawing.Size(160, 22);
            this.txt_TonKho.TabIndex = 78;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 225);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tồn Kho";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Location = new System.Drawing.Point(535, 168);
            this.txt_GiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(160, 22);
            this.txt_GiaBan.TabIndex = 76;
            // 
            // txt_LoaiSP
            // 
            this.txt_LoaiSP.Location = new System.Drawing.Point(535, 70);
            this.txt_LoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_LoaiSP.Name = "txt_LoaiSP";
            this.txt_LoaiSP.Size = new System.Drawing.Size(160, 22);
            this.txt_LoaiSP.TabIndex = 75;
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Location = new System.Drawing.Point(172, 65);
            this.txt_MaSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(160, 22);
            this.txt_MaSP.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Location = new System.Drawing.Point(172, 165);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(160, 22);
            this.txt_TenSP.TabIndex = 72;
            // 
            // txt_HangSX
            // 
            this.txt_HangSX.Location = new System.Drawing.Point(535, 113);
            this.txt_HangSX.Margin = new System.Windows.Forms.Padding(4);
            this.txt_HangSX.Name = "txt_HangSX";
            this.txt_HangSX.Size = new System.Drawing.Size(160, 22);
            this.txt_HangSX.TabIndex = 71;
            // 
            // txt_MaNPP
            // 
            this.txt_MaNPP.Location = new System.Drawing.Point(172, 113);
            this.txt_MaNPP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_MaNPP.Name = "txt_MaNPP";
            this.txt_MaNPP.Size = new System.Drawing.Size(160, 22);
            this.txt_MaNPP.TabIndex = 70;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblhoten.Location = new System.Drawing.Point(423, 168);
            this.lblhoten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(59, 17);
            this.lblhoten.TabIndex = 69;
            this.lblhoten.Text = "Giá Bán";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Location = new System.Drawing.Point(423, 116);
            this.lblmalop.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(104, 17);
            this.lblmalop.TabIndex = 68;
            this.lblmalop.Text = "Hãng Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(423, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 67;
            this.label3.Text = "Loại Sản Phẩm";
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Location = new System.Drawing.Point(42, 68);
            this.lblmakhoa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(93, 17);
            this.lblmakhoa.TabIndex = 65;
            this.lblmakhoa.Text = "Mã sản phẩm";
            // 
            // dgv_QLLK
            // 
            this.dgv_QLLK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QLLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLLK.Location = new System.Drawing.Point(12, 351);
            this.dgv_QLLK.Name = "dgv_QLLK";
            this.dgv_QLLK.RowTemplate.Height = 24;
            this.dgv_QLLK.Size = new System.Drawing.Size(1209, 336);
            this.dgv_QLLK.TabIndex = 63;
            this.dgv_QLLK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLLK_CellClick);
            // 
            // btn_Dong
            // 
            this.btn_Dong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(50, 24);
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(38, 24);
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(39, 24);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // lblmsv
            // 
            this.lblmsv.AutoSize = true;
            this.lblmsv.Location = new System.Drawing.Point(42, 116);
            this.lblmsv.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmsv.Name = "lblmsv";
            this.lblmsv.Size = new System.Drawing.Size(122, 17);
            this.lblmsv.TabIndex = 66;
            this.lblmsv.Text = "Mã nhà phân phối";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btn_Xoa,
            this.btn_Sua,
            this.btn_Dong});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1233, 27);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::GUI.Properties.Resources.timkiem;
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(70, 24);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(712, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(486, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // frmQuanLySP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 798);
            this.Controls.Add(this.txt_Image);
            this.Controls.Add(this.lbl_image);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_TonKho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_GiaBan);
            this.Controls.Add(this.txt_LoaiSP);
            this.Controls.Add(this.txt_MaSP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_TenSP);
            this.Controls.Add(this.txt_HangSX);
            this.Controls.Add(this.txt_MaNPP);
            this.Controls.Add(this.lblhoten);
            this.Controls.Add(this.lblmalop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblmakhoa);
            this.Controls.Add(this.dgv_QLLK);
            this.Controls.Add(this.lblmsv);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmQuanLySP";
            this.Text = "frmQuanLySP";
            this.Load += new System.EventHandler(this.frmQuanLySP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLK)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Image;
        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txt_TonKho;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_GiaBan;
        private System.Windows.Forms.TextBox txt_LoaiSP;
        private System.Windows.Forms.TextBox txt_MaSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_TenSP;
        private System.Windows.Forms.TextBox txt_HangSX;
        private System.Windows.Forms.TextBox txt_MaNPP;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.DataGridView dgv_QLLK;
        private System.Windows.Forms.ToolStripButton btn_Dong;
        private System.Windows.Forms.ToolStripButton btn_Sua;
        private System.Windows.Forms.ToolStripButton btn_Xoa;
        private System.Windows.Forms.ToolStripButton btn_Them;
        private System.Windows.Forms.Label lblmsv;
        private System.Windows.Forms.ToolStrip toolStrip1;
    }
}