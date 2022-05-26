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
        BLLHoaDon bllhoadon = new BLLHoaDon();
        BLLGioHang bllgio = new BLLGioHang();
        
        public frmBanSanPham()
        {
            InitializeComponent();
        }

        private void frmBanSanPham_Load(object sender, EventArgs e)
        {
            dgv_HoaDon.DataSource = bllhoadon.LoadHoaDon();



            dgv_Chitiethoadon.DataSource = bllgio.loadChiTietHoaDon();

        }

        private void dgv_HoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_HoaDon.Rows[e.RowIndex];
                txt_MaHoaDon.Text = row.Cells[0].Value.ToString();
                txt_Makh.Text = row.Cells[1].Value.ToString();

                //txt_TongTien.Text = row.Cells[3].Value.ToString();
                dateTimePicker1.Text = dgv_HoaDon.Rows[e.RowIndex].Cells[2].Value.ToString();
                txt_MaNV.Text = row.Cells[3].Value.ToString();

            }
        }

        private void btn_ThemHD_Click(object sender, EventArgs e)
        {
            QuanLyHoaDon cthdsp = new QuanLyHoaDon()
                {
                    MaHoaDon=  int.Parse(txt_MaNV.Text),
                    MaKH = int.Parse(txt_MaHoaDon.Text),
                    NgayLapHoaDon = dateTimePicker1.Value,
                    MaNhanVien = int.Parse(txt_MaNV.Text)
                };

            if (bllhoadon.postHD(cthdsp))
                {
                    MessageBox.Show("Thêm hóa đơn thành công");
                    dgv_HoaDon.DataSource = bllhoadon.LoadHoaDon();

                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }

          
        }

        private void btn_XoaHD_Click(object sender, EventArgs e)
        {
            if (bllgio.deleteGioHangCTHD(int.Parse(txt_MaHDCTHD.Text)))
            {
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
                MaKH = int.Parse(txt_MaHoaDon.Text),
                NgayLapHoaDon = dateTimePicker1.Value,
                MaNhanVien = int.Parse(txt_MaNV.Text) 
            };

            if (bllhoadon.putHD(kh, int.Parse(txt_MaHoaDon.Text)))
            {
                MessageBox.Show(" Sửa thành công");
                dgv_HoaDon.DataSource = bllhoadon.LoadHoaDon();
            }
            else
            {
                MessageBox.Show("Sửa thất bại");
                return;
            }

        }

        private void btn_ThemCTHD_Click(object sender, EventArgs e)
        {
            ThemCTHD cthd = new ThemCTHD()
            {
                MaHoaDon = int.Parse(txt_MaHDCTHD.Text),
                MaSanPham = int.Parse(txt_MaSanPham.Text),
                giaban = int.Parse(txt_GiaBan.Text),
                soluong = int.Parse(txt_SoLuong.Text),
                TongTien = int.Parse(txt_SoLuong.Text) * int.Parse(txt_GiaBan.Text),

            };
            
            if (bllgio.postGioHangCTHD(cthd))
            {
                MessageBox.Show("Thêm chi tiết hóa đơn thành công");
                dgv_Chitiethoadon.DataSource = bllgio.loadChiTietHoaDon();
            }
            else
            {
                MessageBox.Show("Thêm chi tiết hóa đơn thất bại ");
               
            }
        }

        private void dgv_Chitiethoadon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_Chitiethoadon.Rows[e.RowIndex];
                txt_MaHDCTHD.Text = row.Cells[0].Value.ToString();
                txt_MaSanPham.Text = row.Cells[1].Value.ToString();
                txt_GiaBan.Text = row.Cells[2].Value.ToString();
                txt_SoLuong.Text = row.Cells[3].Value.ToString();
                txt_TongTien.Text = row.Cells[4].Value.ToString();


            }
        }

        private void btn_XoaCTHD_Click(object sender, EventArgs e)
        {
            if (bllgio.deleteGioHang(int.Parse(txt_MaHDCTHD.Text)))
            {
                MessageBox.Show("Xóa thành công");
                dgv_Chitiethoadon.DataSource = bllgio.loadChiTietHoaDon();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }

        }

        private void btn_SuaCTHD_Click(object sender, EventArgs e)
        {
            ThemCTHD cthd = new ThemCTHD()
            {
                MaHoaDon = int.Parse(txt_MaHDCTHD.Text),
                MaSanPham = int.Parse(txt_MaSanPham.Text),
                giaban = int.Parse(txt_GiaBan.Text),
                soluong = int.Parse(txt_SoLuong.Text),
                TongTien = int.Parse(txt_SoLuong.Text) * int.Parse(txt_GiaBan.Text),

            };

            if (bllgio.SuaCTHD(cthd, int.Parse(txt_MaHDCTHD.Text)))
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thành công");
                dgv_Chitiethoadon.DataSource = bllgio.loadChiTietHoaDon();
            }
            else
            {
                MessageBox.Show("Sửa chi tiết hóa đơn thất bại ");

            }
        }
    }
}
