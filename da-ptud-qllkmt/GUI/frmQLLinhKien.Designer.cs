namespace GUI
{
    partial class frmQLLinhKien
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
            this.dgv_nhaplinhkien = new System.Windows.Forms.DataGridView();
            this.btn_CapNhatLinhKien = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaplinhkien)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_CapNhatLinhKien});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1094, 27);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // dgv_nhaplinhkien
            // 
            this.dgv_nhaplinhkien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_nhaplinhkien.Location = new System.Drawing.Point(12, 99);
            this.dgv_nhaplinhkien.Name = "dgv_nhaplinhkien";
            this.dgv_nhaplinhkien.RowTemplate.Height = 24;
            this.dgv_nhaplinhkien.Size = new System.Drawing.Size(1065, 418);
            this.dgv_nhaplinhkien.TabIndex = 2;
            // 
            // btn_CapNhatLinhKien
            // 
            this.btn_CapNhatLinhKien.Image = global::GUI.Properties.Resources.capnhat;
            this.btn_CapNhatLinhKien.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_CapNhatLinhKien.Name = "btn_CapNhatLinhKien";
            this.btn_CapNhatLinhKien.Size = new System.Drawing.Size(151, 24);
            this.btn_CapNhatLinhKien.Text = "Cập nhật linh kiện";
            // 
            // frmQLLinhKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 535);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgv_nhaplinhkien);
            this.Name = "frmQLLinhKien";
            this.Text = "frmQLLinhKien";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_nhaplinhkien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btn_CapNhatLinhKien;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView dgv_nhaplinhkien;
    }
}