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
    public partial class frmThanhPho : Form
    {
        public frmThanhPho()
        {
            InitializeComponent();
        }

        //khoi tao class
        clsKetNoiDB ketnoi = new clsKetNoiDB();

        private void getThanhPho()
        {
            dgvThanhPho.DataSource = ketnoi.LayDSThanhPho();
            dgvThanhPho.Columns[0].HeaderText = "Mã thành phố";
            dgvThanhPho.Columns[1].HeaderText = "Tên thành phố";
        }

        private void FrmThanhPho_Load(object sender, EventArgs e)
        {
            getThanhPho();
        }

        private void DgvThanhPho_Click(object sender, EventArgs e)
        {
            int row = dgvThanhPho.CurrentCell.RowIndex;
            txtMaTP.Text = dgvThanhPho.Rows[row].Cells[0].Value.ToString();
            txtTenTP.Text = dgvThanhPho.Rows[row].Cells[1].Value.ToString();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtMaTP.Text != string.Empty && txtTenTP.Text != string.Empty)
                {
                    if(ketnoi.ThemThanhPho(txtMaTP.Text,txtTenTP.Text) == 1)
                    {
                        MessageBox.Show("Thêm thành công");
                        getThanhPho();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại");
                    }
                }
                else
                {
                    MessageBox.Show("Hãy nhập đầy đủ các trường");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //goi thuc thi
            try
            {
                if (ketnoi.SuaThanhPho(txtMaTP.Text, txtTenTP.Text) == 1)
                {
                    MessageBox.Show("Đã sửa thành công", "Sửa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getThanhPho();
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

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string maTP = txtMaTP.Text;
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa không?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (ketnoi.XoaThanhPho(maTP) != 0)
                    {
                        MessageBox.Show("Xóa Thành Công", "Xóa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        getThanhPho();
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

        private void FrmThanhPho_FormClosing(object sender, FormClosingEventArgs e)
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
