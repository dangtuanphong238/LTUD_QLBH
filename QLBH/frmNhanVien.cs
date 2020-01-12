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
    public partial class frmNhanVien : Form
    {
        public frmNhanVien()
        {
            InitializeComponent();
        }

        clsKetNoiDB ketnoi = new clsKetNoiDB();

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            getNhanVien();
        }

        //GET PHONGBAN
        public void getNhanVien()
        {
            try
            {
                dgvNhanVien.DataSource = ketnoi.LayDSNhanVien();
                dgvNhanVien.Columns[0].HeaderText = "Mã NV";
                dgvNhanVien.Columns[1].HeaderText = "Ho Tên NV";
                dgvNhanVien.Columns[2].HeaderText = "Giới Tính";
                dgvNhanVien.Columns[4].HeaderText = "Ngày Sinh";
                dgvNhanVien.Columns[5].HeaderText = "Địa Chỉ";
                dgvNhanVien.Columns[6].HeaderText = "Điện Thoại";
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //LẤY DÒNG VỪA CLICK DGV VÀ ĐỔ LÊN CONTROL

        private void DgvNhanVien_Click(object sender, EventArgs e)
        {
            try
            {
                int row = dgvNhanVien.CurrentCell.RowIndex;
                txtMaNV.Text = dgvNhanVien.Rows[row].Cells[0].Value.ToString();
                txtHoTen.Text = dgvNhanVien.Rows[row].Cells[1].Value.ToString();
                cbGioiTinh.Text = dgvNhanVien.Rows[row].Cells[2].Value.ToString();
                dtNgaySinh.Text = dgvNhanVien.Rows[row].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[row].Cells[4].Value.ToString();
                txtDienThoai.Text = dgvNhanVien.Rows[row].Cells[5].Value.ToString();
                pictureBox1.Image = Image.FromFile(dgvNhanVien.Rows[row].Cells[6].Value.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }


        //btn add
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (txtMaNV.Text != string.Empty && txtHoTen.Text != string.Empty && cbGioiTinh.Text != string.Empty && dtNgaySinh.Text != string.Empty && txtDiaChi.Text != string.Empty && txtDienThoai.Text != string.Empty)
                {
                    if (ketnoi.ThemNhanVien(txtMaNV.Text, txtHoTen.Text, cbGioiTinh.Text, dtNgaySinh.Text, txtDiaChi.Text, txtDienThoai.Text, openFileDialog1.FileName) == 1)
                    {
                        MessageBox.Show("Đã thêm thành công", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getNhanVien();
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

        //ảnh
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //btnUpdate
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (ketnoi.SuaNhanVien(txtMaNV.Text, txtHoTen.Text, cbGioiTinh.Text, dtNgaySinh.Text, txtDiaChi.Text, txtDienThoai.Text, openFileDialog1.FileName) == 1)
                {
                    MessageBox.Show("Đã sửa thành công", "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getNhanVien();
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

        //btn delete
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maNV = txtMaNV.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ketnoi.XoaNhanVien(maNV) != 0)
                    {
                        MessageBox.Show("Xóa Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getNhanVien();
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

        //btn Thoát
        private void BtnThoat_Click(object sender, EventArgs e)
        {
            exit();
        }

        //form closing
        private void FrmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }
    }
}
