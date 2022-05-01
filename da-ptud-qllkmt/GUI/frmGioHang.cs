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
using GUI.XuLy;

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

                guna2Button2.Enabled = true;
                guna2Button3.Enabled = true;

                int a = int.Parse(txtMaSP.Text);
                cboten.DataSource = bllgiohang.loadTenSP(a);
                cboten.DisplayMember = "TenSanPham";
                cboten.ValueMember = "TenSanPham";
                cboten.SelectedIndex = 0;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            dateTimeNgay.Text = DateTime.Now.ToString();

            int a = int.Parse(txtGiaTien.Text);
            if (a == 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm ở trang Mua Hàng");
                return;
            }
            else
            {
                int sl = int.Parse(cboSoLuong.SelectedItem.ToString());
                int gia = int.Parse(txtGiaTien.Text);
                int kq = sl * gia;
                txtTongTien.Text = kq.ToString();
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
                    dataGridView1.DataSource = bllgiohang.loadGioHang(frmDN.taikhoan);
                }
                else
                {
                    MessageBox.Show("Mua hàng thất bại");
                    return;
                }
            }
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            int ngay = int.Parse(DateTime.Now.Day.ToString());
            int ngaymua = int.Parse(dateTimeNgay.Value.Day.ToString());
            int kq = ngay - ngaymua;
            int a = int.Parse(textBox2.Text);
            if (kq > 2)
            {
                MessageBox.Show("Đã mua 2 ngày không thể hủy đơn");
                return;
            }
            else
            {
                if (bllgiohang.xoaGioHang(a))
                {
                    MessageBox.Show("Hủy đơn thành công");
                    dataGridView1.DataSource = bllgiohang.loadGioHang(frmDN.taikhoan);
                    guna2Button2.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Hủy đơn thất bại");
                    guna2Button2.Enabled = false;
                    return;
                }
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            WordExport we = new WordExport();
            string ngay = DateTime.Now.Day.ToString();
            string thang = DateTime.Now.Month.ToString();
            string nam = DateTime.Now.Year.ToString();
            string ma = textBox2.Text.ToString();
            string ngayt = dateTimeNgay.Value.Day.ToString();
            string thangt = dateTimeNgay.Value.Month.ToString();
            string namt = dateTimeNgay.Value.Year.ToString();

            string tensp = cboten.SelectedValue.ToString();
            string sl = cboSoLuong.Text.ToString();
            string gia = txtGiaTien.Text.ToString();
            string tongtien = txtTongTien.Text.ToString();

            we.QuyetDinhKhenThuong(ngay, thang, nam, ma, ngayt,thangt,namt, tensp, sl, gia, tongtien);
            guna2Button3.Enabled = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            dataExcel.DataSource = bllgiohang.loadBieuMauGio(frmDN.taikhoan);
            ExcelExport ex = new ExcelExport();
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("khong co du lieu de xuat");
                return;
            }

            List<View_BieuMauGio> pListKhoa = new List<View_BieuMauGio>();

            foreach (DataGridViewRow item in dataExcel.Rows)
            {
                View_BieuMauGio i = new View_BieuMauGio();
                i.TenSanPham = item.Cells[0].Value.ToString();
                i.SoLuong = int.Parse(item.Cells[1].Value.ToString());
                i.TongTien = int.Parse(item.Cells[2].Value.ToString());
                i.TongTienHoaDon = int.Parse(item.Cells[3].Value.ToString());
                i.NgayLapHoaDon = DateTime.Parse(item.Cells[4].Value.ToString());
                i.Gmail = item.Cells[5].Value.ToString();

                pListKhoa.Add(i);
            }


            string path = string.Empty;

            ex.ExportKhoa(pListKhoa, ref path, false);

            DialogResult r = MessageBox.Show("ban co muon mo file khong", "thong bao", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (!string.IsNullOrEmpty(path) && r == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start(path);
            }
        }
    }
}
