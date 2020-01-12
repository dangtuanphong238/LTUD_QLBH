namespace QLBH
{
    partial class frmHoaDon
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
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.dtNgayLapHD = new System.Windows.Forms.DateTimePicker();
            this.dtNgayNhanHang = new System.Windows.Forms.DateTimePicker();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(292, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "HÓA ĐƠN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(98, 228);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Ngày Nhận Hàng:";
            // 
            // cbMaNV
            // 
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(210, 143);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(354, 21);
            this.cbMaNV.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(98, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Ngày Lập HĐ: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(98, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Mã Nhân Viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(98, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Mã Khách Hàng: ";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Location = new System.Drawing.Point(210, 61);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(354, 20);
            this.txtMaHD.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Mã Hóa Đơn: ";
            // 
            // cbMaKH
            // 
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(210, 102);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(354, 21);
            this.cbMaKH.TabIndex = 22;
            // 
            // dtNgayLapHD
            // 
            this.dtNgayLapHD.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayLapHD.Location = new System.Drawing.Point(210, 182);
            this.dtNgayLapHD.Name = "dtNgayLapHD";
            this.dtNgayLapHD.Size = new System.Drawing.Size(354, 20);
            this.dtNgayLapHD.TabIndex = 24;
            // 
            // dtNgayNhanHang
            // 
            this.dtNgayNhanHang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtNgayNhanHang.Location = new System.Drawing.Point(210, 224);
            this.dtNgayNhanHang.Name = "dtNgayNhanHang";
            this.dtNgayNhanHang.Size = new System.Drawing.Size(354, 20);
            this.dtNgayNhanHang.TabIndex = 25;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(559, 265);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(81, 34);
            this.btnThoat.TabIndex = 29;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(401, 265);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(81, 34);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(238, 265);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(81, 34);
            this.btnDelete.TabIndex = 27;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(84, 265);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(81, 34);
            this.btnAdd.TabIndex = 26;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvHoaDon.Location = new System.Drawing.Point(0, 315);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(725, 184);
            this.dgvHoaDon.TabIndex = 30;
            this.dgvHoaDon.Click += new System.EventHandler(this.DgvHoaDon_Click);
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 499);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dtNgayNhanHang);
            this.Controls.Add(this.dtNgayLapHD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbMaKH);
            this.Controls.Add(this.cbMaNV);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaHD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHoaDon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHoaDon_FormClosing);
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.DateTimePicker dtNgayLapHD;
        private System.Windows.Forms.DateTimePicker dtNgayNhanHang;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvHoaDon;
    }
}