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
using System.IO;
namespace GUI
{
    public partial class frmQuanLySP : Form
    {
        Helper hp = new Helper();
        BLLSanPham bllsanpham = new BLLSanPham();

        public frmQuanLySP()
        {
            InitializeComponent();
        }

        private void frmQuanLySP_Load(object sender, EventArgs e)
        {
            dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
        }
        public OpenFileDialog openFileDialog = new OpenFileDialog();
        private void btn_Them_Click(object sender, EventArgs e)
        {

            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png ";
            openFileDialog.FilterIndex = 1;
            string pathss = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
            string CorrectFileNames = System.IO.Path.GetFileName(openFileDialog.FileName);
            string a = pathss + "\\Images\\" + CorrectFileNames;


            if (!File.Exists(a))
            {
                string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                string CorrectFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                System.IO.File.Copy(openFileDialog.FileName, paths + "\\Images\\" + CorrectFileName);
                QuanLySanPham kh = new QuanLySanPham()
                {
                    //MaSanPham = int.Parse(txt_MaSP.Text),
                    TenSanPham = txt_TenSP.Text,
                    LoaiSanPham = int.Parse(txt_LoaiSP.Text),
                    HangSanXuat = int.Parse(txt_HangSX.Text),
                    GiaBan = int.Parse(txt_GiaBan.Text),
                    TonKho = int.Parse(txt_TonKho.Text),
                    Image = txt_Image.Text
                };

                if (bllsanpham.postSP(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
                
            }
            else if (File.Exists(a))
            {
                QuanLySanPham kh = new QuanLySanPham()
                {
                    MaSanPham = int.Parse(txt_MaSP.Text),
                    TenSanPham = txt_TenSP.Text,
                    LoaiSanPham = int.Parse(txt_LoaiSP.Text),
                    HangSanXuat = int.Parse(txt_HangSX.Text),
                    GiaBan = int.Parse(txt_GiaBan.Text),
                    TonKho = int.Parse(txt_TonKho.Text),
                    Image = txt_Image.Text
                };

                if (bllsanpham.postSP(kh))
                {
                    MessageBox.Show("Thêm thành công");
                    dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                    return;
                }
                
            }       
        }

        private void dgv_QLLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgv_QLLK.Rows[e.RowIndex];
                txt_MaSP.Text = row.Cells[0].Value.ToString();
                
                txt_TenSP.Text = row.Cells[1].Value.ToString();
                txt_LoaiSP.Text = row.Cells[2].Value.ToString();
                txt_HangSX.Text = row.Cells[3].Value.ToString();
                txt_GiaBan.Text = row.Cells[4].Value.ToString();
                txt_TonKho.Text = row.Cells[5].Value.ToString();
                txt_Image.Text = row.Cells[6].Value.ToString();

                string direct = hp.Directory() + dgv_QLLK.CurrentRow.Cells[6].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);

                btn_Xoa.Enabled = true;
                btn_Sua.Enabled = true;
            }
        }
        public Image GetImg(string direct, int w, int h)
        {
            Image i = Image.FromFile(direct);
            return (Image)(new Bitmap(i, new Size(w, h)));
        }

        private void btn_Click(object sender, EventArgs e)
        {
            
            openFileDialog.InitialDirectory = "C:\\";
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp, *.png)|*.jpg; *.jpeg; *.gif; *.bmp; *.png ";
            openFileDialog.FilterIndex = 1;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //if (openFileDialog.CheckFileExists)
                //{

                //    string paths = Application.StartupPath.Substring(0, (Application.StartupPath.Length - 10));
                //    string CorrectFileName = System.IO.Path.GetFileName(openFileDialog.FileName);
                //    System.IO.File.Copy(openFileDialog.FileName, paths + "\\Images\\" + CorrectFileName);
                //    MessageBox.Show("Upload thành công");

                //}
                pictureBox1.Image = new Bitmap(openFileDialog.FileName);
                txt_Image.Text = openFileDialog.SafeFileName;
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {
            if (bllsanpham.deleteSP(int.Parse(txt_MaSP.Text)))
            {
                MessageBox.Show("Xóa thành công");
                dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
                return;
            }
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            QuanLySanPham kh = new QuanLySanPham()
            {
                //MaSanPham = int.Parse(txt_MaSP.Text),
                TenSanPham = txt_TenSP.Text,
                LoaiSanPham = int.Parse(txt_LoaiSP.Text),
                HangSanXuat = int.Parse(txt_HangSX.Text),
                GiaBan = int.Parse(txt_GiaBan.Text),
                TonKho = int.Parse(txt_TonKho.Text),
                Image = txt_Image.Text
            };
            if (bllsanpham.putSP(kh, int.Parse(txt_MaSP.Text)))
            {
                MessageBox.Show("Sửa thông tin thành công");
                dgv_QLLK.DataSource = bllsanpham.LoadSanPham();
            }
            else
            {
                MessageBox.Show("Sửa thông tin thất bại");
                return;
            }
        }

        private void btn_Dong_Click(object sender, EventArgs e)
        {
            
        }



    }
}
