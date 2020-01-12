using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QLBH
{
    public partial class frmKhachHang : Form
    {
        public frmKhachHang()
        {
            InitializeComponent();
        }

        clsKetNoiDB ketnoi = new clsKetNoiDB();
        
        //GET KHACHHANG
        public void getKhachHang()
        {
            dgvKhachHang.DataSource = ketnoi.LayDSKhachHang();
            dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns[1].HeaderText = "Tên công ty";
            dgvKhachHang.Columns[2].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns[3].HeaderText = "Mã Thành Phố";
            dgvKhachHang.Columns[4].HeaderText = "Điện Thoại";
        }


        private void FrmKhachHang_Load(object sender, EventArgs e)
        {
            getKhachHang();
            try
            {
                dgvKhachHang.DataSource = ketnoi.LayDSKhachHang();
                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ketnoi.setComboboxData("sp_SelectAllThanhPho", cbThanhPho, "MATP");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                
        }

        //LẤY DÒNG VỪA CLICK DGV VÀ ĐỔ LÊN CONTROL
        private void DgvKhachHang_Click(object sender, EventArgs e)
        {
            int row = dgvKhachHang.CurrentCell.RowIndex;
            txtMaKH.Text = dgvKhachHang.Rows[row].Cells[0].Value.ToString();
            txtTenCty.Text = dgvKhachHang.Rows[row].Cells[1].Value.ToString();
            txtDiaChi.Text = dgvKhachHang.Rows[row].Cells[2].Value.ToString();
            cbThanhPho.Text = dgvKhachHang.Rows[row].Cells[3].Value.ToString();
            txtDienThoai.Text = dgvKhachHang.Rows[row].Cells[4].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (txtMaKH.Text != string.Empty && txtTenCty.Text != string.Empty && txtDiaChi.Text != string.Empty && cbThanhPho.Text != string.Empty && txtDienThoai.Text != string.Empty)
                {
                    if (ketnoi.ThemKhachHang(txtMaKH.Text, txtTenCty.Text, txtDiaChi.Text,cbThanhPho.Text,txtDienThoai.Text) == 1)
                    {
                        MessageBox.Show("Đã thêm thành công", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getKhachHang();
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
                string maKH = txtMaKH.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ketnoi.XoaKhachHang(maKH) != 0)
                    {
                        MessageBox.Show("Xóa Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getKhachHang();
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
                if (ketnoi.SuaKhachHang(txtMaKH.Text, txtTenCty.Text, txtDiaChi.Text, cbThanhPho.Text, txtDienThoai.Text) == 1)
                {
                    MessageBox.Show("Đã sửa thành công", "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getKhachHang();
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

        private void FrmKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
