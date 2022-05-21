using BLL;
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
    public partial class frmChiTietGio : Form
    {
        Helper hp = new Helper();
        BLLGioHang bllgiohang = new BLLGioHang();

        public frmChiTietGio()
        {
            InitializeComponent();
        }
        public static string b;
        private void frmChiTietGio_Load(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[1, 0];
                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);

                dataGridView1.Columns[5].Visible = false;
            }
            txtTK.Text = frmDN.taikhoan;
        }

        public void loaddulieu()
        {
            dataGridView2.DataSource = bllgiohang.loadHDAPI();
            int soa = dataGridView2.Rows.Count;
            dataGridView2.CurrentCell = dataGridView2[1, soa - 1];
            b = dataGridView2.CurrentRow.Cells[0].Value.ToString();
        }
        List<String> load = new List<String>();
        DataTable dt = new DataTable();
        public void loaddata(List<String> loadsp)
        {
            load = loadsp;
            dt.Columns.Add("Tên sản phẩm");
            dt.Columns.Add("Loại");
            dt.Columns.Add("Hãng");
            dt.Columns.Add("Giá");
            dt.Columns.Add("Nhập vào số lượng");
            dt.Columns.Add("Hinh");
            dt.Columns.Add("Mã sản phẩm");
            dt.Columns[0].ReadOnly = true;
            dt.Columns[1].ReadOnly = true;
            dt.Columns[2].ReadOnly = true;
            dt.Columns[3].ReadOnly = true;
            dt.Columns[5].ReadOnly = true;
            dt.Columns[6].ReadOnly = true;
            for (int x = 0; x < loadsp.Count; x = x + 7)
            {
                dt.Rows.Add(load[x], load[x + 1], load[x + 2], load[x + 3], load[x + 4], load[x + 5], load[x + 6]);

                dataGridView1.DataSource = dt;
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
                int kq = int.Parse(dataGridView1.CurrentRow.Cells[3].Value.ToString()) * int.Parse(dataGridView1.CurrentRow.Cells[4].Value.ToString());
                txtTongTien.Text = kq.ToString();
                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);

                button1.Enabled = true;
            }
        }
        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            int a = 0;
            if (dataGridView1.Rows.Count > 0)
            {
                ThemGioHang cthdsp = new ThemGioHang()
                {
                    Gmail = txtTK.Text,
                    NgayLapHoaDon = dateTimePicker1.Value
                };

                if (bllgiohang.postGioHang(cthdsp))
                {
                    loaddulieu();
                    textBox1.Text = b;
                    for (int x = 0; x < load.Count; x = x + 7)
                    {
                        ThemCTHD cthd = new ThemCTHD()
                        {
                            MaHoaDon = int.Parse(b.ToString()),
                            tensp = dataGridView1.Rows[a].Cells[0].Value.ToString(),
                            tenloai = dataGridView1.Rows[a].Cells[1].Value.ToString(),
                            tenhang = dataGridView1.Rows[a].Cells[2].Value.ToString(),
                            giaban = int.Parse(dataGridView1.Rows[a].Cells[3].Value.ToString()),
                            soluong = int.Parse(dataGridView1.Rows[a].Cells[4].Value.ToString()),
                            TongTien = int.Parse(dataGridView1.Rows[a].Cells[3].Value.ToString()) * int.Parse(dataGridView1.Rows[a].Cells[4].Value.ToString()),
                            hinh = dataGridView1.Rows[a].Cells[5].Value.ToString(),
                            MaSanPham = int.Parse(dataGridView1.Rows[a].Cells[6].Value.ToString()),
                        };
                        a++;
                        bllgiohang.postGioHangCTHD(cthd);
                    }
                    MessageBox.Show("Mua hàng thành công");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn sản phẩm");
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int row = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows.RemoveAt(row);

            button1.Enabled = false;
        }
    }
}
