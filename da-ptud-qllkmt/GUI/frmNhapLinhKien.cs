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
    public partial class frmNhapLinhKien : Form
    {
        BLLPhieuNhap bllpn = new BLLPhieuNhap();

        public frmNhapLinhKien()
        {
            InitializeComponent();
        }

        private void frmNhapLinhKien_Load(object sender, EventArgs e)
        {
            dgv_PhieuNhap.DataSource = bllpn.LoadPN();
            dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPN();
        }

        private void btn_ThemPN_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap cthdsp = new ThemPhieuNhap()
            {
                //MaPhieuNhap = int.Parse(txt_MaPhieuNhap.Text),
                MaNhanVien = int.Parse(txt_MaNhanVien.Text),
                MaNhaPhanPhoi = int.Parse(comboBox2.Text),
                TongTien = int.Parse(txt_TongTien.Text),
                NgayNhap = dateTimePicker1.Value
            };

            if (bllpn.postPN(cthdsp))
            {
                MessageBox.Show("Thêm thành công");
                dgv_PhieuNhap.DataSource = bllpn.LoadPN();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_XoaPN_Click(object sender, EventArgs e)
        {
            if (bllpn.deletePN(int.Parse(txt_MaPhieuNhap.Text)))
            {
                MessageBox.Show("Xóa thành công");
                dgv_PhieuNhap.DataSource = bllpn.LoadPN();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void btn_SuaPN_Click(object sender, EventArgs e)
        {
            ThemPhieuNhap cthdsp = new ThemPhieuNhap()
            {
                MaPhieuNhap = int.Parse(txt_MaPhieuNhap.Text),
                MaNhanVien = int.Parse(txt_MaNhanVien.Text),
                MaNhaPhanPhoi = int.Parse(comboBox2.Text),
                TongTien = int.Parse(txt_TongTien.Text),
                NgayNhap = dateTimePicker1.Value
            };

            if (bllpn.putPN(cthdsp, int.Parse(txt_MaPhieuNhap.Text)))
            {
                MessageBox.Show("Sửa thành công");
                dgv_PhieuNhap.DataSource = bllpn.LoadPN();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
            }
        }

        private void btn_ThemCTPN_Click(object sender, EventArgs e)
        {
            ThemCTPN cthdsp = new ThemCTPN()
            {
                MaPhieuNhap = int.Parse(txt_MaCTPN.Text),
                MaSanPham = int.Parse(comboBox1.Text),
                SoLuong =  int.Parse(txt_Soluong.Text),
                TienNhap = int.Parse(txt_TienNhap.Text),
            };

            if (bllpn.postCTPN(cthdsp))
            {
                MessageBox.Show("Thêm thành công");
                dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPN();
            }
            else
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

        private void btn_XoaCTPN_Click(object sender, EventArgs e)
        {
            if (bllpn.deleteCTPN(int.Parse(txt_MaCTPN.Text)))
            {
                MessageBox.Show("Xóa thành công");
                dgv_ChiTietPhieuNhap.DataSource = bllpn.LoadCTPN();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }
    }
}
