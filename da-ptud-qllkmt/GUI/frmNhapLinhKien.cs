﻿using System;
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
        BLLHoaDon bllhoadon = new BLLHoaDon();

        public frmNhapLinhKien()
        {
            InitializeComponent();
        }

        private void frmNhapLinhKien_Load(object sender, EventArgs e)
        {
            

        }
    }
}
