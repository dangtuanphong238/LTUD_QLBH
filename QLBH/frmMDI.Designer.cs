namespace QLBH
{
    partial class frmMDI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuQuanLy = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnSanPham = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnKhachHang = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnThanhPho = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnHoaDon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmnChiTietHD = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTimKiem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.munThoat = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuQuanLy,
            this.mnuTimKiem,
            this.toolStripMenuItem1,
            this.munThoat});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hToolStripMenuItem.Text = "&Hệ Thống";
            // 
            // mnuQuanLy
            // 
            this.mnuQuanLy.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmnSanPham,
            this.tsmnNhanVien,
            this.tsmnKhachHang,
            this.tsmnThanhPho,
            this.tsmnHoaDon,
            this.tsmnChiTietHD});
            this.mnuQuanLy.Name = "mnuQuanLy";
            this.mnuQuanLy.Size = new System.Drawing.Size(180, 22);
            this.mnuQuanLy.Text = "&Quản Lý";
            // 
            // tsmnSanPham
            // 
            this.tsmnSanPham.Name = "tsmnSanPham";
            this.tsmnSanPham.Size = new System.Drawing.Size(164, 22);
            this.tsmnSanPham.Text = "Sản Phẩm";
            this.tsmnSanPham.Click += new System.EventHandler(this.TsmnSanPham_Click);
            // 
            // tsmnNhanVien
            // 
            this.tsmnNhanVien.Name = "tsmnNhanVien";
            this.tsmnNhanVien.Size = new System.Drawing.Size(164, 22);
            this.tsmnNhanVien.Text = "Nhân Viên";
            this.tsmnNhanVien.Click += new System.EventHandler(this.TsmnNhanVien_Click);
            // 
            // tsmnKhachHang
            // 
            this.tsmnKhachHang.Name = "tsmnKhachHang";
            this.tsmnKhachHang.Size = new System.Drawing.Size(164, 22);
            this.tsmnKhachHang.Text = "Khách Hàng";
            this.tsmnKhachHang.Click += new System.EventHandler(this.TsmnKhachHang_Click);
            // 
            // tsmnThanhPho
            // 
            this.tsmnThanhPho.Name = "tsmnThanhPho";
            this.tsmnThanhPho.Size = new System.Drawing.Size(164, 22);
            this.tsmnThanhPho.Text = "Thành Phố";
            this.tsmnThanhPho.Click += new System.EventHandler(this.TsmnThanhPho_Click);
            // 
            // tsmnHoaDon
            // 
            this.tsmnHoaDon.Name = "tsmnHoaDon";
            this.tsmnHoaDon.Size = new System.Drawing.Size(164, 22);
            this.tsmnHoaDon.Text = "Hóa Đơn";
            this.tsmnHoaDon.Click += new System.EventHandler(this.TsmnHoaDon_Click);
            // 
            // tsmnChiTietHD
            // 
            this.tsmnChiTietHD.Name = "tsmnChiTietHD";
            this.tsmnChiTietHD.Size = new System.Drawing.Size(164, 22);
            this.tsmnChiTietHD.Text = "Chi Tiết Hóa Đơn";
            this.tsmnChiTietHD.Click += new System.EventHandler(this.TsmnChiTietHD_Click);
            // 
            // mnuTimKiem
            // 
            this.mnuTimKiem.Name = "mnuTimKiem";
            this.mnuTimKiem.Size = new System.Drawing.Size(180, 22);
            this.mnuTimKiem.Text = "&Tìm Kiếm";
            this.mnuTimKiem.Click += new System.EventHandler(this.MnuTimKiem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // munThoat
            // 
            this.munThoat.Name = "munThoat";
            this.munThoat.Size = new System.Drawing.Size(180, 22);
            this.munThoat.Text = "&Thoát";
            this.munThoat.Click += new System.EventHandler(this.munThoat_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // frmMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 426);
            this.ControlBox = false;
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMDI";
            this.Text = "Form MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuQuanLy;
        private System.Windows.Forms.ToolStripMenuItem mnuTimKiem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem munThoat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmnSanPham;
        private System.Windows.Forms.ToolStripMenuItem tsmnNhanVien;
        private System.Windows.Forms.ToolStripMenuItem tsmnKhachHang;
        private System.Windows.Forms.ToolStripMenuItem tsmnThanhPho;
        private System.Windows.Forms.ToolStripMenuItem tsmnHoaDon;
        private System.Windows.Forms.ToolStripMenuItem tsmnChiTietHD;
    }
}

