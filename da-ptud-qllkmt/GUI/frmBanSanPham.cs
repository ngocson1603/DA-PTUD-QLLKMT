using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;
namespace GUI
{
    public partial class frmBanSanPham : Form
    {
        QL_CUAHANGLINHKIENMAYTINHDataContext qllk = new QL_CUAHANGLINHKIENMAYTINHDataContext();
        BLLHoaDon bllhoadon = new BLLHoaDon();
        BLLGioHang bllgio = new BLLGioHang();
        BLLKhachHang bllkh = new BLLKhachHang();
        Helper hp = new Helper();
        public frmBanSanPham()
        {
            InitializeComponent();
        }

        private void frmBanSanPham_Load(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = bllhoadon.LoadHoaDon();
            loaddata(frmQuanLySP.lstsp);

            txt_MaNV.Text = frmTrangChuDanhChoNhanVien.manv;
            comboBox1.DataSource = bllkh.loadmakh();
            comboBox1.DisplayMember = "MaKH";
            comboBox1.ValueMember = "MaKH";
            comboBox1.SelectedIndex = 0;
        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_HoaDon.Rows[e.RowIndex];
                txt_MaHoaDon.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();

                //txt_TongTien.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_MaNV.Text = row.Cells[3].Value.ToString();

            }
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            int a = 0;
            QuanLyHoaDon cthdsp = new QuanLyHoaDon()
                {
                    MaKH = int.Parse(comboBox1.Text),
                    NgayLapHoaDon = dateTimePicker1.Value,
                    MaNhanVien = int.Parse(txt_MaNV.Text)
                };

            if (bllhoadon.postHD(cthdsp))
                {
                    dgv_HoaDon.DataSource = bllhoadon.LoadHoaDonNV(int.Parse(txt_MaNV.Text));
                    int so = dgv_HoaDon.RowCount;
                    dgv_HoaDon.CurrentCell = dgv_HoaDon[1, so-1];
                    txt_MaHoaDon.Text = dgv_HoaDon.CurrentRow.Cells[0].Value.ToString();
                    for (int x = 0; x < dgv_Chitiethoadon.Rows.Count; x++)
                    {
                        ThemCTHD cthd = new ThemCTHD()
                        {
                            MaHoaDon = int.Parse(txt_MaHoaDon.Text),
                            MaSanPham = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[6].Value.ToString()),
                            giaban = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[3].Value.ToString()),
                            soluong = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[4].Value.ToString()),
                            TongTien = int.Parse(dgv_Chitiethoadon.Rows[a].Cells[3].Value.ToString()) * int.Parse(dgv_Chitiethoadon.Rows[a].Cells[4].Value.ToString()),

                        };
                        a++;
                        if (bllgio.postGioHangCTHD(cthd))
                        {

                        }
                        else
                        {
                            MessageBox.Show("Mua hàng không thành công");
                            break;
                        }
                    }
                    MessageBox.Show("Mua hàng thành công");
                }
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            if (bllgio.deleteGioHangCTHD(int.Parse(txt_MaHoaDon.Text)))
               
                {
                    bllgio.deleteGioHang(int.Parse(txt_MaHoaDon.Text));
                    MessageBox.Show("Xóa thành công");
                    dgv_HoaDon.DataSource = bllhoadon.LoadHoaDon();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại");
                    return;
                }

        }

        private void btn_SuaHD_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon kh = new QuanLyHoaDon()
            {

                //MaHoaDon = int.Parse(txt_MaNV.Text),
                MaKH = int.Parse(comboBox1.Text),
                NgayLapHoaDon = dateTimePicker1.Value,
                MaNhanVien = int.Parse(txt_MaNV.Text) 
            };

            if (bllhoadon.putHD(kh, int.Parse(txt_MaHoaDon.Text)))
            {
                MessageBox.Show(" Sửa thành công");
                dgv_HoaDon.DataSource = bllhoadon.LoadHoaDonNV(int.Parse(txt_MaNV.Text));
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
                return;
            }

        }

        public static int kq;
        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }
        private void dgv_Chitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                kq = int.Parse(dgv_Chitiethoadon.CurrentRow.Cells[3].Value.ToString()) * int.Parse(dgv_Chitiethoadon.CurrentRow.Cells[4].Value.ToString());
                txt_TongTien.Text = kq.ToString();
                string direct = hp.Directory() + dgv_Chitiethoadon.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);
            }
        }
        public void loaddata(BindingList<ThemSanPham> loadsp)
        {
            dgv_Chitiethoadon.DataSource = loadsp;

            dgv_Chitiethoadon.Columns[0].ReadOnly = true;
            dgv_Chitiethoadon.Columns[1].ReadOnly = true;
            dgv_Chitiethoadon.Columns[2].ReadOnly = true;
            dgv_Chitiethoadon.Columns[3].ReadOnly = true;
            dgv_Chitiethoadon.Columns[4].ReadOnly = true;
            dgv_Chitiethoadon.Columns[5].ReadOnly = true;
            dgv_Chitiethoadon.Columns[6].ReadOnly = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmQuanLySP frm = new frmQuanLySP();
            frm.ShowDialog();
            frm.toolStripButton1.Enabled = true;
        }
    }
}
