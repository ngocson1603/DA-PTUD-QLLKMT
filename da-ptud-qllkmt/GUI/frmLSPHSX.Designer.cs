namespace GUI
{
    partial class frmLSPHSX
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemlsp = new System.Windows.Forms.Button();
            this.btnxoalsp = new System.Windows.Forms.Button();
            this.btnsualsp = new System.Windows.Forms.Button();
            this.btnthemhsx = new System.Windows.Forms.Button();
            this.btnxoahsx = new System.Windows.Forms.Button();
            this.btnsuahsx = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(467, 320);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(476, 223);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(468, 320);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnsualsp);
            this.groupBox1.Controls.Add(this.btnxoalsp);
            this.groupBox1.Controls.Add(this.btnThemlsp);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 184);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loại Sản Phẩm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên Loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mã Loại";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(74, 95);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(144, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(74, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(144, 20);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnthoat);
            this.groupBox2.Controls.Add(this.btnsuahsx);
            this.groupBox2.Controls.Add(this.btnxoahsx);
            this.groupBox2.Controls.Add(this.btnthemhsx);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.textBox4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(476, 33);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(468, 184);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Hãng Sản Xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tên Hãng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Hãng";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(67, 49);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(150, 20);
            this.textBox3.TabIndex = 1;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(67, 95);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(150, 20);
            this.textBox4.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridView2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.90852F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.09148F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(947, 546);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(941, 30);
            this.label5.TabIndex = 4;
            this.label5.Text = "Quản lý Loai Sản Phẩm Hãng Sản Xuất";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThemlsp
            // 
            this.btnThemlsp.Location = new System.Drawing.Point(9, 155);
            this.btnThemlsp.Name = "btnThemlsp";
            this.btnThemlsp.Size = new System.Drawing.Size(75, 23);
            this.btnThemlsp.TabIndex = 4;
            this.btnThemlsp.Text = "Thêm";
            this.btnThemlsp.UseVisualStyleBackColor = true;
            this.btnThemlsp.Click += new System.EventHandler(this.btnThemlsp_Click);
            // 
            // btnxoalsp
            // 
            this.btnxoalsp.Enabled = false;
            this.btnxoalsp.Location = new System.Drawing.Point(90, 155);
            this.btnxoalsp.Name = "btnxoalsp";
            this.btnxoalsp.Size = new System.Drawing.Size(75, 23);
            this.btnxoalsp.TabIndex = 5;
            this.btnxoalsp.Text = "Xóa";
            this.btnxoalsp.UseVisualStyleBackColor = true;
            this.btnxoalsp.Click += new System.EventHandler(this.btnxoalsp_Click);
            // 
            // btnsualsp
            // 
            this.btnsualsp.Enabled = false;
            this.btnsualsp.Location = new System.Drawing.Point(171, 155);
            this.btnsualsp.Name = "btnsualsp";
            this.btnsualsp.Size = new System.Drawing.Size(75, 23);
            this.btnsualsp.TabIndex = 6;
            this.btnsualsp.Text = "Sửa";
            this.btnsualsp.UseVisualStyleBackColor = true;
            this.btnsualsp.Click += new System.EventHandler(this.btnsualsp_Click);
            // 
            // btnthemhsx
            // 
            this.btnthemhsx.Location = new System.Drawing.Point(6, 155);
            this.btnthemhsx.Name = "btnthemhsx";
            this.btnthemhsx.Size = new System.Drawing.Size(75, 23);
            this.btnthemhsx.TabIndex = 7;
            this.btnthemhsx.Text = "Thêm";
            this.btnthemhsx.UseVisualStyleBackColor = true;
            this.btnthemhsx.Click += new System.EventHandler(this.btnthemhsx_Click);
            // 
            // btnxoahsx
            // 
            this.btnxoahsx.Enabled = false;
            this.btnxoahsx.Location = new System.Drawing.Point(87, 155);
            this.btnxoahsx.Name = "btnxoahsx";
            this.btnxoahsx.Size = new System.Drawing.Size(75, 23);
            this.btnxoahsx.TabIndex = 8;
            this.btnxoahsx.Text = "Xóa";
            this.btnxoahsx.UseVisualStyleBackColor = true;
            this.btnxoahsx.Click += new System.EventHandler(this.btnxoahsx_Click);
            // 
            // btnsuahsx
            // 
            this.btnsuahsx.Enabled = false;
            this.btnsuahsx.Location = new System.Drawing.Point(168, 155);
            this.btnsuahsx.Name = "btnsuahsx";
            this.btnsuahsx.Size = new System.Drawing.Size(75, 23);
            this.btnsuahsx.TabIndex = 9;
            this.btnsuahsx.Text = "Sửa";
            this.btnsuahsx.UseVisualStyleBackColor = true;
            this.btnsuahsx.Click += new System.EventHandler(this.btnsuahsx_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(249, 155);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 10;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // frmLSPHSX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(947, 546);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmLSPHSX";
            this.Text = "frmLSPHSX";
            this.Load += new System.EventHandler(this.frmLSPHSX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsualsp;
        private System.Windows.Forms.Button btnxoalsp;
        private System.Windows.Forms.Button btnThemlsp;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnsuahsx;
        private System.Windows.Forms.Button btnxoahsx;
        private System.Windows.Forms.Button btnthemhsx;
    }
}