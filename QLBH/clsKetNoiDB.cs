using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace QLBH
{

    class clsKetNoiDB
    {
        SqlConnection conn = new SqlConnection("Data Source=.;Initial Catalog=QLBH;Integrated Security=True");

        //CONSTRUCTOR
        public clsKetNoiDB()
        {
            try
            {
                conn.Open();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi " + ex.Message);
            }
        }

        //SET DATA TO COMBOBOX
        public void setComboboxData(String spName, ComboBox cb, String sValue)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand(spName, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                cb.DataSource = dt;
                cb.ValueMember = sValue;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        /*I.NHANVIEN*/

        //SELECT ALL ROW OF TABLE NHANVIEN
        public DataTable LayDSNhanVien()
        {
            DataTable dtNhanVien = new DataTable();
            string spName = "sp_SelectAllNhanVien";
            SqlCommand cmdNhanVien = new SqlCommand(spName, conn);
            cmdNhanVien.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daPhongBan = new SqlDataAdapter(cmdNhanVien);
            daPhongBan.Fill(dtNhanVien);
            return dtNhanVien;
        }

        //ADD NHANVIEN
        public int ThemNhanVien(string maNV, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string dienThoai, string hinh)
        {
            string spName = "sp_InsertNhanVien";
            SqlCommand cmdThem = new SqlCommand(spName, conn);
            cmdThem.CommandText = spName;
            cmdThem.CommandType = CommandType.StoredProcedure;
            cmdThem.Parameters.Add(new SqlParameter("@maNV", maNV));
            cmdThem.Parameters.Add(new SqlParameter("@hoTen", hoTen));
            cmdThem.Parameters.Add(new SqlParameter("@gioiTinh", gioiTinh));
            cmdThem.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinh));
            cmdThem.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            cmdThem.Parameters.Add(new SqlParameter("@dienThoai", dienThoai));
            cmdThem.Parameters.Add(new SqlParameter("@hinh", hinh));
            if (cmdThem.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //DELETE NHANVIEN
        public int XoaNhanVien(string maNV)
        {
            string spName = "sp_DeleteNhanVien";
            SqlCommand cmdXoa = new SqlCommand(spName, conn);
            cmdXoa.CommandText = spName;
            cmdXoa.CommandType = CommandType.StoredProcedure;
            cmdXoa.Parameters.Add(new SqlParameter("@maNV", maNV));
            if (cmdXoa.ExecuteNonQuery() != 0)
            {
                //conn.Close();
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //UPDATE NHANVIEN
        public int SuaNhanVien(string maNV, string hoTen, string gioiTinh, string ngaySinh, string diaChi, string dienThoai, string hinh)
        {
            string spName = "sp_UpdateNhanVien";
            SqlCommand cmdSua = new SqlCommand(spName, conn);
            cmdSua.CommandText = spName;
            cmdSua.CommandType = CommandType.StoredProcedure;
            cmdSua.Parameters.Add(new SqlParameter("@maNV", maNV));
            cmdSua.Parameters.Add(new SqlParameter("@hoTen", hoTen));
            cmdSua.Parameters.Add(new SqlParameter("@gioiTinh", gioiTinh));
            cmdSua.Parameters.Add(new SqlParameter("@ngaySinh", ngaySinh));
            cmdSua.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            cmdSua.Parameters.Add(new SqlParameter("@dienThoai", dienThoai));
            cmdSua.Parameters.Add(new SqlParameter("@hinh", hinh));


            if (cmdSua.ExecuteNonQuery() != 0)
            {
              //  conn.Close();
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        /*II.THANHPHO*/

        //SELECT ALL ROW OF TABLE THANHPHO
        public DataTable LayDSThanhPho()
        {
            DataTable dtThanhPho = new DataTable();
            string spName = "sp_SelectAllThanhPho";
            SqlCommand cmdThanhPho = new SqlCommand(spName, conn);
            cmdThanhPho.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daThanhPho = new SqlDataAdapter(cmdThanhPho);
            daThanhPho.Fill(dtThanhPho);
            return dtThanhPho;
        }
        
        //ADD THANHPHO
        public int ThemThanhPho(string maTP, string tenTP)
        {
            string spName = "sp_InsertThanhPho";
            SqlCommand cmdThem = new SqlCommand(spName, conn);
            cmdThem.CommandText = spName;
            cmdThem.CommandType = CommandType.StoredProcedure;
            cmdThem.Parameters.Add(new SqlParameter("@maTP", maTP));
            cmdThem.Parameters.Add(new SqlParameter("@tenTP", tenTP));
            if (cmdThem.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //DELETE THANHPHO
        public int XoaThanhPho(string maTP)
        {
            string spName = "sp_DeleteThanhPho";
            SqlCommand cmdXoa = new SqlCommand(spName, conn);
            cmdXoa.CommandText = spName;
            cmdXoa.CommandType = CommandType.StoredProcedure;
            cmdXoa.Parameters.Add(new SqlParameter("@maTP", maTP));
            if (cmdXoa.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //UPDATE THANHPHO
        public int SuaThanhPho(string maTP, string tenTP)
        {
            string spName = "sp_UpdateThanhPho";
            SqlCommand cmdSua = new SqlCommand(spName, conn);
            cmdSua.CommandText = spName;
            cmdSua.CommandType = CommandType.StoredProcedure;
            cmdSua.Parameters.Add(new SqlParameter("@maTP", maTP));
            cmdSua.Parameters.Add(new SqlParameter("@tenTP", tenTP));
            if (cmdSua.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        /*III.SANPHAM*/

        //SELECT ALL ROW OF TABLE SANPHAM
        public DataTable LayDSSanPham()
        {
            DataTable dtSanPham = new DataTable();
            string spName = "sp_SelectAllSanPham";
            SqlCommand cmdSanPham = new SqlCommand(spName, conn);
            cmdSanPham.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daSanPham = new SqlDataAdapter(cmdSanPham);
            daSanPham.Fill(dtSanPham);
            return dtSanPham;
        }

        //ADD SANPHAM
        public int ThemSanPham(string maSP, string tenSP, string donviTinh, int donGia, string hinh)
        {
            string spName = "sp_InsertSanPham";
            SqlCommand cmdThem = new SqlCommand(spName, conn);
            cmdThem.CommandText = spName;
            cmdThem.CommandType = CommandType.StoredProcedure;
            cmdThem.Parameters.Add(new SqlParameter("@maSP", maSP));
            cmdThem.Parameters.Add(new SqlParameter("@tenSP", tenSP));
            cmdThem.Parameters.Add(new SqlParameter("@donviTinh", donviTinh));
            cmdThem.Parameters.Add(new SqlParameter("@donGia", donGia));
            cmdThem.Parameters.Add(new SqlParameter("@hinh", hinh));
            if (cmdThem.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //DELETE SANPHAM
        public int XoaSanPham(string maSP)
        {
            string spName = "sp_DeleteSanPham";
            SqlCommand cmdXoa = new SqlCommand(spName, conn);
            cmdXoa.CommandText = spName;
            cmdXoa.CommandType = CommandType.StoredProcedure;
            cmdXoa.Parameters.Add(new SqlParameter("@maSP", maSP));
            if (cmdXoa.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //UPDATE SANPHAM
        public int SuaSanPham(string maSP, string tenSP, string donviTinh, int donGia, string hinh)
        {
            string spName = "sp_UpdateSanPham";
            SqlCommand cmdSua = new SqlCommand(spName, conn);
            cmdSua.CommandText = spName;
            cmdSua.CommandType = CommandType.StoredProcedure;
            cmdSua.Parameters.Add(new SqlParameter("@maSP", maSP));
            cmdSua.Parameters.Add(new SqlParameter("@tenSP", tenSP));
            cmdSua.Parameters.Add(new SqlParameter("@donviTinh", donviTinh));
            cmdSua.Parameters.Add(new SqlParameter("@donGia", donGia));
            cmdSua.Parameters.Add(new SqlParameter("@hinh", hinh));
            if (cmdSua.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //SelectSanPhamByMaSP
        public DataTable SelectSanPhamByMaSP(string maSP)
        {
            DataTable dtSanPham = new DataTable();
            string spName = "sp_SelectSanPhamByMaSP";
            SqlCommand cmdTim = new SqlCommand(spName, conn);
            cmdTim.CommandType = CommandType.StoredProcedure;
            cmdTim.Parameters.Add(new SqlParameter("@maSP", maSP));
            SqlDataAdapter daSanPham = new SqlDataAdapter(cmdTim);
            daSanPham.Fill(dtSanPham);
            return dtSanPham;
        }

        public DataTable SelectKhachHangByMaKH(string maKH)
        {
            DataTable dtKhachHang = new DataTable();
            string spName = "sp_SelectKhachHangByMaKH";
            SqlCommand cmdTim = new SqlCommand(spName, conn);
            cmdTim.CommandType = CommandType.StoredProcedure;
            cmdTim.Parameters.Add(new SqlParameter("@maKH", maKH));
            SqlDataAdapter daKhachHang = new SqlDataAdapter(cmdTim);
            daKhachHang.Fill(dtKhachHang);
            return dtKhachHang;
        }


        /*IV.KHACHHANG*/
        //SELECT ALL ROW OF TABLE KHACHHANG
        public DataTable LayDSKhachHang()
        {
            DataTable dtKhachHang = new DataTable();
            string spName = "sp_SelectAllKhachHang";
            SqlCommand cmdKhachHang = new SqlCommand(spName, conn);
            cmdKhachHang.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daKhachHang = new SqlDataAdapter(cmdKhachHang);
            daKhachHang.Fill(dtKhachHang);
            return dtKhachHang;
        }
 
        //ADD KHACHHANG
        public int ThemKhachHang(string maKH, string tenCty, string diaChi, string maTP, string dienThoai)
        {
            string spName = "sp_InsertKhachHang";
            SqlCommand cmdThem = new SqlCommand(spName, conn);
            cmdThem.CommandText = spName;
            cmdThem.CommandType = CommandType.StoredProcedure;
            cmdThem.Parameters.Add(new SqlParameter("@maKH", maKH));
            cmdThem.Parameters.Add(new SqlParameter("@tenCty", tenCty));
            cmdThem.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            cmdThem.Parameters.Add(new SqlParameter("@maTP", maTP));
            cmdThem.Parameters.Add(new SqlParameter("@dienThoai", dienThoai));
            if (cmdThem.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //DELETE KHACHHANG
        public int XoaKhachHang(string maKH)
        {
            string spName = "sp_DeleteKhachHang";
            SqlCommand cmdXoa = new SqlCommand(spName, conn);
            cmdXoa.CommandText = spName;
            cmdXoa.CommandType = CommandType.StoredProcedure;
            cmdXoa.Parameters.Add(new SqlParameter("@maKH", maKH));
            if (cmdXoa.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //UPDATE KHACHHANG
        public int SuaKhachHang(string maKH, string tenCty, string diaChi, string maTP, string dienThoai)
        {
            string spName = "sp_UpdateKhachHang";
            SqlCommand cmdSua = new SqlCommand(spName, conn);
            cmdSua.CommandText = spName;
            cmdSua.CommandType = CommandType.StoredProcedure;
            cmdSua.Parameters.Add(new SqlParameter("@maKH", maKH));
            cmdSua.Parameters.Add(new SqlParameter("@tenCty", tenCty));
            cmdSua.Parameters.Add(new SqlParameter("@diaChi", diaChi));
            cmdSua.Parameters.Add(new SqlParameter("@maTP", maTP));
            cmdSua.Parameters.Add(new SqlParameter("@dienThoai", dienThoai));
            if (cmdSua.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }


        /*V.HOADON*/
        //SELECT ALL ROW OF TABLE HOADON
        public DataTable LayDSHoaDon()
        {
            DataTable dtHoaDon = new DataTable();
            string spName = "sp_SelectAllHoaDon";
            SqlCommand cmdHoaDon = new SqlCommand(spName, conn);
            cmdHoaDon.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daHoaDon = new SqlDataAdapter(cmdHoaDon);
            daHoaDon.Fill(dtHoaDon);
            return dtHoaDon;
        }

        //ADD HOADON
        public int ThemHoaDon(string maHD, string maKH, string maNV, string ngayLapHD, string ngayNhanHang)
        {
            string spName = "sp_InsertHoaDon";
            SqlCommand cmdThem = new SqlCommand(spName, conn);
            cmdThem.CommandText = spName;
            cmdThem.CommandType = CommandType.StoredProcedure;
            cmdThem.Parameters.Add(new SqlParameter("@maHD", maHD));
            cmdThem.Parameters.Add(new SqlParameter("@maKH", maKH));
            cmdThem.Parameters.Add(new SqlParameter("@maNV", maNV));
            cmdThem.Parameters.Add(new SqlParameter("@ngayLapHD", ngayLapHD));
            cmdThem.Parameters.Add(new SqlParameter("@ngayNhanHang", ngayNhanHang));
            if (cmdThem.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //DELETE HOADON
        public int XoaHoaDon(string maHD)
        {
            string spName = "sp_DeleteHoaDon";
            SqlCommand cmdXoa = new SqlCommand(spName, conn);
            cmdXoa.CommandText = spName;
            cmdXoa.CommandType = CommandType.StoredProcedure;
            cmdXoa.Parameters.Add(new SqlParameter("@maHD", maHD));
            if (cmdXoa.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //UPDATE HOADON
        public int SuaHoaDon(string maHD, string maKH, string maNV, string ngayLapHD, string ngayNhanHang)
        {
            string spName = "sp_UpdateHoaDon";
            SqlCommand cmdSua = new SqlCommand(spName, conn);
            cmdSua.CommandText = spName;
            cmdSua.CommandType = CommandType.StoredProcedure;
            cmdSua.Parameters.Add(new SqlParameter("@maHD", maHD));
            cmdSua.Parameters.Add(new SqlParameter("@maKH", maKH));
            cmdSua.Parameters.Add(new SqlParameter("@maNV", maNV));
            cmdSua.Parameters.Add(new SqlParameter("@ngayLapHD", ngayLapHD));
            cmdSua.Parameters.Add(new SqlParameter("@ngayNhanHang", ngayNhanHang));
            if (cmdSua.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        /*VI.CHITIETHOADON*/
        //SELECT ALL ROW OF TABLE HOADON
        public DataTable LayDSChiTietHoaDon()
        {
            DataTable dtChiTietHoaDon = new DataTable();
            string spName = "sp_SelectAllChiTietHoaDon";
            SqlCommand cmdChiTiet = new SqlCommand(spName, conn);
            cmdChiTiet.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter daChiTietHoaDon = new SqlDataAdapter(cmdChiTiet);
            daChiTietHoaDon.Fill(dtChiTietHoaDon);
            return dtChiTietHoaDon;
        }

        //ADD HOADON
        public int ThemChiTietHoaDon(string maHD, string maSP, string soLuong)
        {
            string spName = "sp_InsertChiTietHoaDon";
            SqlCommand cmdThem = new SqlCommand(spName, conn);
            cmdThem.CommandText = spName;
            cmdThem.CommandType = CommandType.StoredProcedure;
            cmdThem.Parameters.Add(new SqlParameter("@maHD", maHD));
            cmdThem.Parameters.Add(new SqlParameter("@maSP", maSP));
            cmdThem.Parameters.Add(new SqlParameter("@soLuong", soLuong));
            if (cmdThem.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //DELETE HOADON
        public int XoaChiTietHoaDon(string maHD)
        {
            string spName = "sp_DeleteChiTietHoaDon";
            SqlCommand cmdXoa = new SqlCommand(spName, conn);
            cmdXoa.CommandText = spName;
            cmdXoa.CommandType = CommandType.StoredProcedure;
            cmdXoa.Parameters.Add(new SqlParameter("@maHD", maHD));
            if (cmdXoa.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }

        //UPDATE HOADON
        public int SuaChiTietHoaDon(string maHD, string maSP, string soLuong)
        {
            string spName = "sp_UpdateChiTietHoaDon";
            SqlCommand cmdSua = new SqlCommand(spName, conn);
            cmdSua.CommandText = spName;
            cmdSua.CommandType = CommandType.StoredProcedure;
            cmdSua.Parameters.Add(new SqlParameter("@maHD", maHD));
            cmdSua.Parameters.Add(new SqlParameter("@maSP", maSP));
            cmdSua.Parameters.Add(new SqlParameter("@soLuong", soLuong));
            if (cmdSua.ExecuteNonQuery() != 0)
            {
                return 1;
            }
            else
            {
                conn.Close();
                return 0;
            }
        }


    }
}
