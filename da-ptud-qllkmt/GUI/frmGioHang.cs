using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;

namespace GUI
{
    public partial class frmGioHang : Form
    {
        Helper hp = new Helper();
        BLLGioHang bllgiohang = new BLLGioHang();
        public frmGioHang()
        {
            InitializeComponent();
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        { 
            dataGridView1.DataSource = bllgiohang.loadGioHang(frmDN.taikhoan);
            txtMaSP.Text = UserControls.detailProduct.ma;
            txtGiaTien.Text = UserControls.detailProduct.gia;
            txtTK.Text = frmDN.taikhoan;
            
            dataGridView1.Columns[7].Visible = false;
            tinhTien();
        }

        public void tinhTien()
        {
            cboSoLuong.SelectedIndex = 0;
            int sl = int.Parse(cboSoLuong.SelectedItem.ToString());
            int gia = int.Parse(txtGiaTien.Text);
            int kq = sl * gia;
            txtTongTien.Text = kq.ToString();
        }

        private void cboSoLuong_SelectedIndexChanged(object sender, EventArgs e)
        {
            int a = 0;
            if (txtGiaTien.Text.Equals(string.Empty))
            {
                txtGiaTien.Text = a.ToString();
            }
            else
            {
                int gia = int.Parse(txtGiaTien.Text);
                int sl = int.Parse(cboSoLuong.SelectedItem.ToString());
                int kq = sl * gia;
                txtTongTien.Text = kq.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChiTietHoaDon cthd = new ChiTietHoaDon()
            {
                MaSanPham = int.Parse(txtMaSP.Text),
                Gmail = txtTK.Text,
                SoLuong = int.Parse(cboSoLuong.SelectedItem.ToString()),
                TongTien = int.Parse(txtGiaTien.Text),
                TongTienHoaDon = int.Parse(txtTongTien.Text),
                NgayLapHoaDon = dateTimeNgay.Value
            };

            if (bllgiohang.themGioHang(cthd))
            {
                MessageBox.Show("Mua hàng thành công");
                
            }
            else
            {
                MessageBox.Show("Mua hàng thất bại");
                return;
            }
        }

        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                textBox2.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                txtMaSP.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                txtTK.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                cboSoLuong.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtGiaTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtTongTien.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                dateTimeNgay.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[7].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);
            }
        }
    }
}
