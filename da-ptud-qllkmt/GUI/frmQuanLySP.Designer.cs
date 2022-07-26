namespace GUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLySP));
            this.txt_Image = new System.Windows.Forms.TextBox();
            this.lbl_image = new System.Windows.Forms.Label();
            this.btn = new System.Windows.Forms.Button();
            this.txt_TonKho = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_GiaBan = new System.Windows.Forms.TextBox();
            this.txt_MaSP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_TenSP = new System.Windows.Forms.TextBox();
            this.lblhoten = new System.Windows.Forms.Label();
            this.lblmalop = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblmakhoa = new System.Windows.Forms.Label();
            this.dgv_QLLK = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Them = new System.Windows.Forms.ToolStripButton();
            this.btn_Xoa = new System.Windows.Forms.ToolStripButton();
            this.btn_Sua = new System.Windows.Forms.ToolStripButton();
            this.btn_Dong = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.btn_nhapvao = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtHSD = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_LoaiSP = new System.Windows.Forms.ComboBox();
            this.txt_HangSX = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLK)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Image
            // 
            this.txt_Image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Image.Location = new System.Drawing.Point(573, 103);
            this.txt_Image.Name = "txt_Image";
            this.txt_Image.Size = new System.Drawing.Size(184, 20);
            this.txt_Image.TabIndex = 82;
            // 
            // lbl_image
            // 
            this.lbl_image.AutoSize = true;
            this.lbl_image.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lbl_image.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_image.Location = new System.Drawing.Point(383, 100);
            this.lbl_image.Name = "lbl_image";
            this.lbl_image.Size = new System.Drawing.Size(184, 25);
            this.lbl_image.TabIndex = 81;
            this.lbl_image.Text = "Image";
            // 
            // btn
            // 
            this.btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn.Location = new System.Drawing.Point(572, 127);
            this.btn.Margin = new System.Windows.Forms.Padding(2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(186, 46);
            this.btn.TabIndex = 80;
            this.btn.Text = "Chọn tệp";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // txt_TonKho
            // 
            this.txt_TonKho.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TonKho.Location = new System.Drawing.Point(193, 78);
            this.txt_TonKho.Name = "txt_TonKho";
            this.txt_TonKho.Size = new System.Drawing.Size(184, 20);
            this.txt_TonKho.TabIndex = 78;
            this.txt_TonKho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_TonKho_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 25);
            this.label5.TabIndex = 77;
            this.label5.Text = "Tồn Kho";
            // 
            // txt_GiaBan
            // 
            this.txt_GiaBan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_GiaBan.Location = new System.Drawing.Point(573, 78);
            this.txt_GiaBan.Name = "txt_GiaBan";
            this.txt_GiaBan.Size = new System.Drawing.Size(184, 20);
            this.txt_GiaBan.TabIndex = 76;
            this.txt_GiaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_GiaBan_KeyPress);
            // 
            // txt_MaSP
            // 
            this.txt_MaSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_MaSP.Enabled = false;
            this.txt_MaSP.Location = new System.Drawing.Point(193, 28);
            this.txt_MaSP.Name = "txt_MaSP";
            this.txt_MaSP.Size = new System.Drawing.Size(184, 20);
            this.txt_MaSP.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(2, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 73;
            this.label1.Text = "Tên Sản Phẩm";
            // 
            // txt_TenSP
            // 
            this.txt_TenSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_TenSP.Location = new System.Drawing.Point(192, 52);
            this.txt_TenSP.Margin = new System.Windows.Forms.Padding(2);
            this.txt_TenSP.Name = "txt_TenSP";
            this.txt_TenSP.Size = new System.Drawing.Size(186, 20);
            this.txt_TenSP.TabIndex = 72;
            // 
            // lblhoten
            // 
            this.lblhoten.AutoSize = true;
            this.lblhoten.BackColor = System.Drawing.Color.MediumTurquoise;
            this.lblhoten.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblhoten.Location = new System.Drawing.Point(383, 75);
            this.lblhoten.Name = "lblhoten";
            this.lblhoten.Size = new System.Drawing.Size(184, 25);
            this.lblhoten.TabIndex = 69;
            this.lblhoten.Text = "Giá Bán";
            // 
            // lblmalop
            // 
            this.lblmalop.AutoSize = true;
            this.lblmalop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmalop.Location = new System.Drawing.Point(383, 50);
            this.lblmalop.Name = "lblmalop";
            this.lblmalop.Size = new System.Drawing.Size(184, 25);
            this.lblmalop.TabIndex = 68;
            this.lblmalop.Text = "Hãng Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(383, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 67;
            this.label3.Text = "Loại Sản Phẩm";
            // 
            // lblmakhoa
            // 
            this.lblmakhoa.AutoSize = true;
            this.lblmakhoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblmakhoa.Location = new System.Drawing.Point(3, 25);
            this.lblmakhoa.Name = "lblmakhoa";
            this.lblmakhoa.Size = new System.Drawing.Size(184, 25);
            this.lblmakhoa.TabIndex = 65;
            this.lblmakhoa.Text = "Mã sản phẩm";
            // 
            // dgv_QLLK
            // 
            this.dgv_QLLK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_QLLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel1.SetColumnSpan(this.dgv_QLLK, 5);
            this.dgv_QLLK.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_QLLK.Location = new System.Drawing.Point(2, 177);
            this.dgv_QLLK.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_QLLK.Name = "dgv_QLLK";
            this.dgv_QLLK.RowTemplate.Height = 24;
            this.dgv_QLLK.Size = new System.Drawing.Size(1046, 388);
            this.dgv_QLLK.TabIndex = 63;
            this.dgv_QLLK.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLLK_CellClick);
            // 
            // toolStrip1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.toolStrip1, 5);
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Them,
            this.btn_Xoa,
            this.btn_Sua,
            this.btn_Dong,
            this.toolStripButton1,
            this.btn_nhapvao});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1050, 25);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Them
            // 
            this.btn_Them.Image = global::GUI.Properties.Resources.timkiem;
            this.btn_Them.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(61, 22);
            this.btn_Them.Text = "Thêm";
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.Enabled = false;
            this.btn_Xoa.Image = global::GUI.Properties.Resources.trash_can_1153121;
            this.btn_Xoa.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(51, 22);
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.Enabled = false;
            this.btn_Sua.Image = global::GUI.Properties.Resources._4014665_fix_fixing_phone_repair_tool_wrench_112887;
            this.btn_Sua.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(50, 22);
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // btn_Dong
            // 
            this.btn_Dong.Image = global::GUI.Properties.Resources.Home_80_icon_icons_com_57317;
            this.btn_Dong.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Dong.Name = "btn_Dong";
            this.btn_Dong.Size = new System.Drawing.Size(60, 22);
            this.btn_Dong.Text = "Đóng";
            this.btn_Dong.Click += new System.EventHandler(this.btn_Dong_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Enabled = false;
            this.toolStripButton1.Image = global::GUI.Properties.Resources.sell1;
            this.toolStripButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(131, 22);
            this.toolStripButton1.Text = "Chọn sản phẩm bán ra";
            this.toolStripButton1.Visible = false;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // btn_nhapvao
            // 
            this.btn_nhapvao.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btn_nhapvao.Enabled = false;
            this.btn_nhapvao.Image = ((System.Drawing.Image)(resources.GetObject("btn_nhapvao.Image")));
            this.btn_nhapvao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nhapvao.Name = "btn_nhapvao";
            this.btn_nhapvao.Size = new System.Drawing.Size(147, 22);
            this.btn_nhapvao.Text = "Chọn sản phẩm nhập vào";
            this.btn_nhapvao.Visible = false;
            this.btn_nhapvao.Click += new System.EventHandler(this.btn_nhapvao_Click);
            // 
            // groupBox1
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.groupBox1, 2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 128);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 44);
            this.groupBox1.TabIndex = 83;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm sản phẩm";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(133, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nhập vào tên sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(762, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.tableLayoutPanel1.SetRowSpan(this.pictureBox1, 5);
            this.pictureBox1.Size = new System.Drawing.Size(286, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 79;
            this.pictureBox1.TabStop = false;
            // 
            // txtHSD
            // 
            this.txtHSD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtHSD.Location = new System.Drawing.Point(193, 103);
            this.txtHSD.Name = "txtHSD";
            this.txtHSD.Size = new System.Drawing.Size(184, 20);
            this.txtHSD.TabIndex = 85;
            this.txtHSD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHSD_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 25);
            this.label4.TabIndex = 84;
            this.label4.Text = "HSD";
            // 
            // txt_LoaiSP
            // 
            this.txt_LoaiSP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_LoaiSP.FormattingEnabled = true;
            this.txt_LoaiSP.Location = new System.Drawing.Point(573, 28);
            this.txt_LoaiSP.Name = "txt_LoaiSP";
            this.txt_LoaiSP.Size = new System.Drawing.Size(184, 21);
            this.txt_LoaiSP.TabIndex = 86;
            // 
            // txt_HangSX
            // 
            this.txt_HangSX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_HangSX.FormattingEnabled = true;
            this.txt_HangSX.Location = new System.Drawing.Point(573, 53);
            this.txt_HangSX.Name = "txt_HangSX";
            this.txt_HangSX.Size = new System.Drawing.Size(184, 21);
            this.txt_HangSX.TabIndex = 87;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.27273F));
            this.tableLayoutPanel1.Controls.Add(this.toolStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgv_QLLK, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.pictureBox1, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.btn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txt_HangSX, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_Image, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblmakhoa, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_image, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_LoaiSP, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtHSD, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_GiaBan, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblhoten, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txt_MaSP, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txt_TenSP, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblmalop, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txt_TonKho, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 567);
            this.tableLayoutPanel1.TabIndex = 88;
            // 
            // frmQuanLySP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(1050, 567);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmQuanLySP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmQuanLySP";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmQuanLySP_FormClosed);
            this.Load += new System.EventHandler(this.frmQuanLySP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLLK)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_image;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblhoten;
        private System.Windows.Forms.Label lblmalop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblmakhoa;
        private System.Windows.Forms.DataGridView dgv_QLLK;
        private System.Windows.Forms.ToolStripButton btn_Dong;
        private System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txt_Image;
        public System.Windows.Forms.Button btn;
        public System.Windows.Forms.TextBox txt_TonKho;
        public System.Windows.Forms.TextBox txt_GiaBan;
        public System.Windows.Forms.TextBox txt_MaSP;
        public System.Windows.Forms.TextBox txt_TenSP;
        public System.Windows.Forms.ToolStripButton btn_Sua;
        public System.Windows.Forms.ToolStripButton btn_Xoa;
        public System.Windows.Forms.ToolStripButton btn_Them;
        public System.Windows.Forms.ToolStripButton btn_nhapvao;
        public System.Windows.Forms.TextBox txtHSD;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox txt_LoaiSP;
        public System.Windows.Forms.ComboBox txt_HangSX;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}