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
    public partial class frmTuVanSuaChua : Form
    {
        BLLTuVan blltuvan = new BLLTuVan();
        public frmTuVanSuaChua()
        {
            InitializeComponent();
        }

        private void frmTuVanSuaChua_Load(object sender, EventArgs e)
        {
            cboTenMay.DataSource = blltuvan.loadTen();
            cboTenMay.ValueMember = "TenMay";
            cboTenMay.DisplayMember = "TenMay";
            cboTenMay.SelectedIndex = 0;
        }

        private void cboTT1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTT2.DataSource = blltuvan.LoadTinhTrang2(cboTT1.SelectedValue.ToString());
            cboTT2.DisplayMember = "TenTinhTrangTwo";
            cboTT2.ValueMember = "TenTinhTrangTwo";
        }

        private void cboTT2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboTT3.DataSource = blltuvan.LoadTinhTrang3(cboTT1.SelectedValue.ToString(), cboTT2.SelectedValue.ToString());
            cboTT3.DisplayMember = "TenTinhTrangThree";
            cboTT3.ValueMember = "TenTinhTrangThree";
        }
        private void cboTenMay_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tenmay = cboTenMay.SelectedValue.ToString();
            cboTT1.DataSource = blltuvan.LoadTinhTrang1(tenmay);
            cboTT1.DisplayMember = "TenTinhTrangOne";
            cboTT1.ValueMember = "TenTinhTrangOne";
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            listBox1.DataSource = blltuvan.LoadKetQua(cboTT1.SelectedValue.ToString(), cboTT2.SelectedValue.ToString(), cboTT3.SelectedValue.ToString());
            listBox1.DisplayMember = "KetQua";

            txtAnh.DataSource = blltuvan.LoadAnh(listBox1.Text);
            txtAnh.DisplayMember = "Anh";
            txtAnh.ValueMember = "Anh";
            txtAnh.SelectedIndex = 0;
            string a = txtAnh.SelectedValue.ToString();


            pictureBox1.Load("AnhLapTop\\" + a );
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
