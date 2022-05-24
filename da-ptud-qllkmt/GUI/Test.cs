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
    public partial class Test : Form
    {
        Helper hp = new Helper();
        BLLGioHang bllgiohang = new BLLGioHang();
        public static string taikhoan;
        public string tensanpham;
        public Test()
        {
            InitializeComponent();
        }
        public static int? tongtien = 0;
        public static int mahd;
        public static int makh;
        private void button1_Click(object sender, EventArgs e)
        {
            dataExcel.DataSource = bllgiohang.loadBieuMauGioHangAPI(int.Parse(textBox1.Text), int.Parse(textBox2.Text));
            taikhoan = textBox1.Text;
            //mahd = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            ExcelExport ex = new ExcelExport();
            //if (dataGridView1.Rows.Count == 0)
            //{
            //    MessageBox.Show("khong co du lieu de xuat");
            //    return;
            //}
            int a = 0;
            for (int x = 0; x < dataExcel.Rows.Count; x++)
            {
                tongtien += int.Parse(dataExcel.Rows[a].Cells[1].Value.ToString()) * int.Parse(dataExcel.Rows[a].Cells[2].Value.ToString());
                a++;
            }
            makh = int.Parse(textBox1.Text);
            List<View_BieuMauGio> pListKhoa = new List<View_BieuMauGio>();

            foreach (DataGridViewRow item in dataExcel.Rows)
            {
                View_BieuMauGio i = new View_BieuMauGio();
                i.TenSanPham = item.Cells[0].Value.ToString();
                i.soluong = int.Parse(item.Cells[1].Value.ToString());
                i.giaban = int.Parse(item.Cells[2].Value.ToString());
                i.NgayLapHoaDon = DateTime.Parse(item.Cells[3].Value.ToString());
                i.TongTien = int.Parse(item.Cells[5].Value.ToString());

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
