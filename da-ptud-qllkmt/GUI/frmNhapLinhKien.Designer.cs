﻿namespace GUI
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.dgvban = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txbTongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbThoigian = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbSdt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbDiachi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbTenkhachhang = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1137, 27);
            this.toolStrip1.TabIndex = 64;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgvban
            // 
            this.dgvban.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvban.Location = new System.Drawing.Point(37, 255);
            this.dgvban.Name = "dgvban";
            this.dgvban.Size = new System.Drawing.Size(1091, 349);
            this.dgvban.TabIndex = 63;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(303, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(441, 40);
            this.label2.TabIndex = 62;
            this.label2.Text = "Thông tin linh kiện nhập vào";
            // 
            // txbTongtien
            // 
            this.txbTongtien.Enabled = false;
            this.txbTongtien.Location = new System.Drawing.Point(582, 155);
            this.txbTongtien.Name = "txbTongtien";
            this.txbTongtien.Size = new System.Drawing.Size(145, 22);
            this.txbTongtien.TabIndex = 74;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(410, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 73;
            this.label5.Text = "Tổng tiền phải trả";
            // 
            // txbThoigian
            // 
            this.txbThoigian.Enabled = false;
            this.txbThoigian.Location = new System.Drawing.Point(582, 111);
            this.txbThoigian.Name = "txbThoigian";
            this.txbThoigian.Size = new System.Drawing.Size(145, 22);
            this.txbThoigian.TabIndex = 72;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(410, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 17);
            this.label6.TabIndex = 71;
            this.label6.Text = "Thời gian thanh toán";
            // 
            // txbSdt
            // 
            this.txbSdt.Location = new System.Drawing.Point(192, 197);
            this.txbSdt.Name = "txbSdt";
            this.txbSdt.Size = new System.Drawing.Size(76, 22);
            this.txbSdt.TabIndex = 70;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 17);
            this.label4.TabIndex = 69;
            this.label4.Text = "Số điện thoại";
            // 
            // txbDiachi
            // 
            this.txbDiachi.Location = new System.Drawing.Point(192, 153);
            this.txbDiachi.Name = "txbDiachi";
            this.txbDiachi.Size = new System.Drawing.Size(76, 22);
            this.txbDiachi.TabIndex = 68;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 67;
            this.label1.Text = "Địa chỉ";
            // 
            // txbTenkhachhang
            // 
            this.txbTenkhachhang.Location = new System.Drawing.Point(192, 108);
            this.txbTenkhachhang.Name = "txbTenkhachhang";
            this.txbTenkhachhang.Size = new System.Drawing.Size(76, 22);
            this.txbTenkhachhang.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 65;
            this.label3.Text = "Tên nhà cung cấp";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = global::GUI.Properties.Resources.nhap;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(69, 24);
            this.toolStripButton1.Text = "Nhập";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = global::GUI.Properties.Resources.thanhtoan;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(93, 24);
            this.toolStripButton2.Text = "Tính Tiền";
            // 
            // frmNhapLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 622);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvban);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbTongtien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbThoigian);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbSdt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbDiachi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbTenkhachhang);
            this.Controls.Add(this.label3);
            this.Name = "frmNhapLinhKien";
            this.Text = "frmNhapLinhKien";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvban)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.DataGridView dgvban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbThoigian;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbSdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbDiachi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenkhachhang;
        private System.Windows.Forms.Label label3;
    }
}