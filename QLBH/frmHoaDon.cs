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
    public partial class frmHoaDon : Form
    {
        public frmHoaDon()
        {
            InitializeComponent();
        }
        clsKetNoiDB ketnoi = new clsKetNoiDB();

        //GET KHACHHANG
        public void getHoaDon()
        {
            dgvHoaDon.DataSource = ketnoi.LayDSHoaDon();
            dgvHoaDon.Columns[0].HeaderText = "Mã HĐ";
            dgvHoaDon.Columns[1].HeaderText = "Mã KH";
            dgvHoaDon.Columns[2].HeaderText = "Mã NV";
            dgvHoaDon.Columns[3].HeaderText = "Ngày Lập HĐ";
            dgvHoaDon.Columns[4].HeaderText = "Ngày Nhận Hàng";
        }

        private void FrmHoaDon_Load(object sender, EventArgs e)
        {

            getHoaDon();
            try
            {
                dgvHoaDon.DataSource = ketnoi.LayDSHoaDon();
                dgvHoaDon.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                ketnoi.setComboboxData("sp_SelectAllKhachHang", cbMaKH, "MAKH");
                ketnoi.setComboboxData("sp_SelectAllNhanVien", cbMaNV, "MANV");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DgvHoaDon_Click(object sender, EventArgs e)
        {
            int row = dgvHoaDon.CurrentCell.RowIndex;
            txtMaHD.Text = dgvHoaDon.Rows[row].Cells[0].Value.ToString();
            cbMaKH.Text = dgvHoaDon.Rows[row].Cells[1].Value.ToString();
            cbMaNV.Text = dgvHoaDon.Rows[row].Cells[2].Value.ToString();
            dtNgayLapHD.Text = dgvHoaDon.Rows[row].Cells[3].Value.ToString();
            dtNgayNhanHang.Text = dgvHoaDon.Rows[row].Cells[4].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (txtMaHD.Text != string.Empty && cbMaKH.Text != string.Empty && cbMaNV.Text != string.Empty && dtNgayLapHD.Text != string.Empty && dtNgayNhanHang.Text != string.Empty)
                {
                    if (ketnoi.ThemHoaDon(txtMaHD.Text, cbMaKH.Text, cbMaNV.Text, dtNgayLapHD.Text, dtNgayNhanHang.Text) == 1)
                    {
                        MessageBox.Show("Đã thêm thành công", "Thêm", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getHoaDon();
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
                    if (ketnoi.XoaHoaDon(maHD) != 0)
                    {
                        MessageBox.Show("Xóa Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getHoaDon();
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
                if (ketnoi.SuaHoaDon(txtMaHD.Text, cbMaKH.Text, cbMaNV.Text, dtNgayLapHD.Text, dtNgayNhanHang.Text) == 1)
                {
                    MessageBox.Show("Đã sửa thành công", "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getHoaDon();
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

        private void FrmHoaDon_FormClosing(object sender, FormClosingEventArgs e)
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
