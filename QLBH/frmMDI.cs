using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmMDI : Form
    {
        public frmMDI()
        {
            InitializeComponent();
        }

        private void munThoat_Click(object sender, EventArgs e)
        {
            try
            {
                if(MessageBox.Show("Do you want exit?","Exit",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void TsmnSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham f = new frmSanPham();
            f.MdiParent = this;
            f.Show();
        }

        private void TsmnNhanVien_Click(object sender, EventArgs e)
        {
            frmNhanVien f = new frmNhanVien();
            f.MdiParent = this;
            f.Show();
        }

        private void TsmnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang f = new frmKhachHang();
            f.MdiParent = this;
            f.Show();
        }

        private void TsmnThanhPho_Click(object sender, EventArgs e)
        {
            frmThanhPho f = new frmThanhPho();
            f.MdiParent = this;
            f.Show();
        }

        private void TsmnHoaDon_Click(object sender, EventArgs e)
        {
            frmHoaDon f = new frmHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void TsmnChiTietHD_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDon f = new frmChiTietHoaDon();
            f.MdiParent = this;
            f.Show();
        }

        private void TsmuSearchSanPham_Click(object sender, EventArgs e)
        {

        }

        private void MnuTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem f = new frmTimKiem();
            f.MdiParent = this;
            f.Show();
        }
    }
}
