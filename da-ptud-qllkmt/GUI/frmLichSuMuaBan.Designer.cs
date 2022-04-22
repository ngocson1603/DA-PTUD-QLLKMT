namespace GUI
{
    partial class frmLichSuMuaBan
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
            this.tìmKiếmLíchSửToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgv_LichSuMua = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.dgv_LichSuThanhToan = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txbsdt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbten = new System.Windows.Forms.TextBox();
            this.ts_LichSuNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.ts_LichSuBan = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuMua)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuThanhToan)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts_LichSuNhap,
            this.ts_LichSuBan,
            this.tìmKiếmLíchSửToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1204, 28);
            this.menuStrip1.TabIndex = 18;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tìmKiếmLíchSửToolStripMenuItem
            // 
            this.tìmKiếmLíchSửToolStripMenuItem.Image = global::GUI.Properties.Resources.timkiem;
            this.tìmKiếmLíchSửToolStripMenuItem.Name = "tìmKiếmLíchSửToolStripMenuItem";
            this.tìmKiếmLíchSửToolStripMenuItem.Size = new System.Drawing.Size(227, 24);
            this.tìmKiếmLíchSửToolStripMenuItem.Text = "Tìm kiếm lích sử khách hàng";
            // 
            // dgv_LichSuMua
            // 
            this.dgv_LichSuMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichSuMua.Location = new System.Drawing.Point(26, 152);
            this.dgv_LichSuMua.Name = "dgv_LichSuMua";
            this.dgv_LichSuMua.RowTemplate.Height = 24;
            this.dgv_LichSuMua.Size = new System.Drawing.Size(1144, 255);
            this.dgv_LichSuMua.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(182, 34);
            this.label4.TabIndex = 25;
            this.label4.Text = "Lịch sử khách hàng đã mua\r\n\r\n";
            // 
            // dgv_LichSuThanhToan
            // 
            this.dgv_LichSuThanhToan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_LichSuThanhToan.Location = new System.Drawing.Point(26, 455);
            this.dgv_LichSuThanhToan.Name = "dgv_LichSuThanhToan";
            this.dgv_LichSuThanhToan.RowTemplate.Height = 24;
            this.dgv_LichSuThanhToan.Size = new System.Drawing.Size(1144, 266);
            this.dgv_LichSuThanhToan.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 422);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "Lịch sử khách hàng đã thanh toán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số điện thoại";
            // 
            // txbsdt
            // 
            this.txbsdt.Location = new System.Drawing.Point(500, 78);
            this.txbsdt.Margin = new System.Windows.Forms.Padding(4);
            this.txbsdt.Name = "txbsdt";
            this.txbsdt.Size = new System.Drawing.Size(212, 22);
            this.txbsdt.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 80);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Tên khách hàng";
            // 
            // txbten
            // 
            this.txbten.Location = new System.Drawing.Point(161, 76);
            this.txbten.Margin = new System.Windows.Forms.Padding(4);
            this.txbten.Name = "txbten";
            this.txbten.Size = new System.Drawing.Size(212, 22);
            this.txbten.TabIndex = 19;
            // 
            // ts_LichSuNhap
            // 
            this.ts_LichSuNhap.Image = global::GUI.Properties.Resources.nhap2;
            this.ts_LichSuNhap.Name = "ts_LichSuNhap";
            this.ts_LichSuNhap.Size = new System.Drawing.Size(191, 24);
            this.ts_LichSuNhap.Text = "Lịch sử nhập sản phẩm";
            // 
            // ts_LichSuBan
            // 
            this.ts_LichSuBan.Image = global::GUI.Properties.Resources.banra;
            this.ts_LichSuBan.Name = "ts_LichSuBan";
            this.ts_LichSuBan.Size = new System.Drawing.Size(200, 24);
            this.ts_LichSuBan.Text = "Lịch sử bán sản phẩm ra";
            // 
            // frmLichSuMuaBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 752);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgv_LichSuMua);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgv_LichSuThanhToan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbsdt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbten);
            this.Name = "frmLichSuMuaBan";
            this.Text = "frmLichSuMuaBan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuMua)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_LichSuThanhToan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ts_LichSuNhap;
        private System.Windows.Forms.ToolStripMenuItem ts_LichSuBan;
        private System.Windows.Forms.ToolStripMenuItem tìmKiếmLíchSửToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgv_LichSuMua;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgv_LichSuThanhToan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbsdt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbten;
    }
}