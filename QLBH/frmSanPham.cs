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
    public partial class frmSanPham : Form
    {
        public frmSanPham()
        {
            InitializeComponent();
        }

        clsKetNoiDB ketnoi = new clsKetNoiDB();


        private void FrmSanPham_Load(object sender, EventArgs e)
        {
            getSanPham();
        }

        //GET SANPHAM
        public void getSanPham()
        {
            try
            {
                dgvSanPham.DataSource = ketnoi.LayDSSanPham();
                dgvSanPham.Columns[0].HeaderText = "Mã sản phẩm";
                dgvSanPham.Columns[1].HeaderText = "Tên sản phẩm";
                dgvSanPham.Columns[2].HeaderText = "Đơn vị tính";
                dgvSanPham.Columns[3].HeaderText = "Đơn giá";
                //dgvSanPham.Columns[4].HeaderText = "Hình";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //LẤY DÒNG VỪA CLICK DGV VÀ ĐỔ LÊN CONTROL
        private void DgvSanPham_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgvSanPham.CurrentCell.RowIndex;
                txtMaSP.Text = dgvSanPham.Rows[row].Cells[0].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[row].Cells[1].Value.ToString();
                txtDonViTinh.Text = dgvSanPham.Rows[row].Cells[2].Value.ToString();
                txtDonGia.Text = dgvSanPham.Rows[row].Cells[3].Value.ToString();
                pictureBox1.Image = Image.FromFile(dgvSanPham.Rows[row].Cells[4].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (txtMaSP.Text != string.Empty && txtTenSP.Text != string.Empty && txtDonViTinh.Text != string.Empty && txtDonGia.Text != string.Empty)
                {
                    if (ketnoi.ThemSanPham(txtMaSP.Text, txtTenSP.Text, txtDonViTinh.Text, int.Parse(txtDonGia.Text), openFileDialog1.FileName) == 1)
                    {
                        MessageBox.Show("Đã thêm thành công", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getSanPham();
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
                string maSP = txtMaSP.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ketnoi.XoaSanPham(maSP) != 0)
                    {
                        MessageBox.Show("Xóa Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getSanPham();
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

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (ketnoi.SuaSanPham(txtMaSP.Text, txtTenSP.Text, txtDonViTinh.Text,int.Parse(txtDonGia.Text), openFileDialog1.FileName) == 1)
                {
                    MessageBox.Show("Đã sửa thành công", "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getSanPham();
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

        private void FrmSanPham_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
