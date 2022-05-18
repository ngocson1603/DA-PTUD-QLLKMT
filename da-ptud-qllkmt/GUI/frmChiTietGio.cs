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

namespace GUI
{
    public partial class frmChiTietGio : Form
    {
        Helper hp = new Helper();
        XuLy.loadProduct xl = new XuLy.loadProduct();
        public frmChiTietGio()
        {
            InitializeComponent();
        }
        public static string a;
        private void frmChiTietGio_Load(object sender, EventArgs e)
        {
            dataGridView2.DataSource = xl.LoadDLSPtangdan();
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.CurrentCell = dataGridView2[1, 0];
                a = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            }

            if (dataGridView1.Rows.Count > 0)
            {
                dataGridView1.CurrentCell = dataGridView1[1, 0];
                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);
            }
        }
        List<String> load = new List<String>();
        DataTable dt = new DataTable();
        public void loaddata(List<String> loadsp)
        {
            load = loadsp;
            dt.Columns.Add("TenSP");
            dt.Columns.Add("TenLoai");
            dt.Columns.Add("TenHang");
            dt.Columns.Add("GiaBan");
            dt.Columns.Add("SoLuong");
            dt.Columns.Add("Hinh");
            dt.Columns.Add("MaSP");
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
                string direct = hp.Directory() + dataGridView1.CurrentRow.Cells[5].Value.ToString();
                pictureBox1.Image = GetImg(direct, pictureBox1.Width, pictureBox1.Height);
            }
        }
    }
}
