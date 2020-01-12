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
    public partial class frmChiTietHoaDon : Form
    {
        public frmChiTietHoaDon()
        {
            InitializeComponent();
        }

        clsKetNoiDB ketnoi = new clsKetNoiDB();

        //GET KHACHHANG
        public void getChiTietHoaDon()
        {
            dgvChiTietHD.DataSource = ketnoi.LayDSChiTietHoaDon();
            dgvChiTietHD.Columns[0].HeaderText = "Mã hóa đơn";
            dgvChiTietHD.Columns[1].HeaderText = "Mã sản phẩm";
            dgvChiTietHD.Columns[2].HeaderText = "Số lượng";
        }
        private void FrmChiTietHoaDon_Load(object sender, EventArgs e)
        {
            getChiTietHoaDon();
            try
            {
                dgvChiTietHD.DataSource = ketnoi.LayDSChiTietHoaDon();
                dgvChiTietHD.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ketnoi.setComboboxData("sp_SelectAllSanPham", cbMaSP, "TENSP");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (txtMaHD.Text != string.Empty && cbMaSP.Text != string.Empty && txtSoLuong.Text != string.Empty)
                {
                    if (ketnoi.ThemChiTietHoaDon(txtMaHD.Text, cbMaSP.Text, txtSoLuong.Text) == 1)
                    {
                        MessageBox.Show("Đã thêm thành công", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getChiTietHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Nhập đủ thông tin", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maHD = txtMaHD.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ketnoi.XoaChiTietHoaDon(maHD) != 0)
                    {
                        MessageBox.Show("Xóa Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getChiTietHoaDon();
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (ketnoi.SuaChiTietHoaDon(txtMaHD.Text, cbMaSP.Text, txtSoLuong.Text) == 1)
                {
                    MessageBox.Show("Đã sửa thành công", "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getChiTietHoaDon();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại", "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //EXIT function
        public void exit()
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void BtnThoat_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void FrmChiTietHoaDon_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }

        }

        //LẤY DÒNG VỪA CLICK DGV VÀ ĐỔ LÊN CONTROL
        private void DgvChiTietHD_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgvChiTietHD.CurrentCell.RowIndex;
                txtMaHD.Text = dgvChiTietHD.Rows[row].Cells[0].Value.ToString();
                cbMaSP.Text = dgvChiTietHD.Rows[row].Cells[1].Value.ToString();
                txtSoLuong.Text = dgvChiTietHD.Rows[row].Cells[2].Value.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
