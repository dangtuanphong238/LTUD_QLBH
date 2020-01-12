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
    public partial class frmTimKiem : Form
    {
        public frmTimKiem()
        {
            InitializeComponent();
        }
        clsKetNoiDB ketnoi = new clsKetNoiDB();
        //GET SANPHAM
        public void getSanPham()
        {
            try
            {
                dgvSearch.DataSource = ketnoi.LayDSSanPham();
                dgvSearch.Columns[0].HeaderText = "Mã Sản Phẩm";
                dgvSearch.Columns[1].HeaderText = "Tên Sản Phẩm";
                dgvSearch.Columns[2].HeaderText = "Đơn vị tính";
                dgvSearch.Columns[3].HeaderText = "Đơn giá";
                dgvSearch.Columns[4].HeaderText = "Hình";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //GET KHACHHANG
        public void getKhachHang()
        {
            try
            {
                dgvSearch.DataSource = ketnoi.LayDSKhachHang();
                dgvSearch.Columns[0].HeaderText = "Mã khách hàng";
                dgvSearch.Columns[1].HeaderText = "Tên công ty";
                dgvSearch.Columns[2].HeaderText = "Địa chỉ";
                dgvSearch.Columns[3].HeaderText = "Thành phố";
                dgvSearch.Columns[4].HeaderText = "Điện thoại";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
        private void BtnSearchSP_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (txtSearchSP.Text.Length == 0)
                {
                    getSanPham();
                }
                else
                {
                    dgvSearch.DataSource = ketnoi.SelectSanPhamByMaSP(txtSearchSP.Text);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void BtnSearchKH_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearchKH.Text.Length == 0)
                {
                    getKhachHang();
                }
                else
                {
                    dgvSearch.DataSource = ketnoi.SelectKhachHangByMaKH(txtSearchKH.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
            
        }

        private void exit()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            exit();
        }
    }
}
