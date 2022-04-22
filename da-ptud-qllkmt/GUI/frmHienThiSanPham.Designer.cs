namespace GUI
{
    partial class frmHienThiSanPham
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
            this.dgv_hienthi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbhienthi = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_hienthi
            // 
            this.dgv_hienthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_hienthi.Location = new System.Drawing.Point(37, 141);
            this.dgv_hienthi.Name = "dgv_hienthi";
            this.dgv_hienthi.RowTemplate.Height = 24;
            this.dgv_hienthi.Size = new System.Drawing.Size(1009, 428);
            this.dgv_hienthi.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Loại";
            // 
            // cbbhienthi
            // 
            this.cbbhienthi.FormattingEnabled = true;
            this.cbbhienthi.Location = new System.Drawing.Point(37, 58);
            this.cbbhienthi.Name = "cbbhienthi";
            this.cbbhienthi.Size = new System.Drawing.Size(516, 24);
            this.cbbhienthi.TabIndex = 3;
            // 
            // frmHienThiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 589);
            this.Controls.Add(this.dgv_hienthi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbhienthi);
            this.Name = "frmHienThiSanPham";
            this.Text = "frmHienThiSanPham";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hienthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_hienthi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbhienthi;
    }
}