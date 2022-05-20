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
        public static string taikhoan;
        public frmGioHang()
        {
            InitializeComponent();
        }

        private void frmGioHang_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = bllgiohang.loadGioHangAPI(frmDN.taikhoan);
            dataGridView1.Columns[6].Visible = false;

            dataGridView1.CurrentCell = dataGridView1[1, 0];
        }

        public void tinhTien()
        {
            int sl = int.Parse(txtSL.Text);
            int gia = int.Parse(txtGiaTien.Text);
            int kq = sl * gia;
            txtTongTien.Text = kq.ToString();
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
                txtSL.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                txtGiaTien.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                dateTimeNgay.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();

                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[6].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);

                tinhTien();

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
                if (bllgiohang.deleteGioHangCTHD(a))
                {
                    bllgiohang.deleteGioHang(a);
                    MessageBox.Show("Hủy đơn thành công");
                    dataGridView1.DataSource = bllgiohang.loadGioHangAPI(frmDN.taikhoan);
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
            string sl = txtSL.Text.ToString();
            string gia = txtGiaTien.Text.ToString();
            string tongtien = txtTongTien.Text.ToString();

            we.QuyetDinhKhenThuong(ngay, thang, nam, ma, ngayt,thangt,namt, tensp, sl, gia, tongtien);
            guna2Button3.Enabled = false;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            dataExcel.DataSource = bllgiohang.loadBieuMauGioHangAPI(frmDN.taikhoan);
            taikhoan = txtTK.Text;
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
                i.tensp = item.Cells[0].Value.ToString();
                i.soluong = int.Parse(item.Cells[1].Value.ToString());
                i.giaban = int.Parse(item.Cells[2].Value.ToString());
                i.NgayLapHoaDon = DateTime.Parse(item.Cells[3].Value.ToString());

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
