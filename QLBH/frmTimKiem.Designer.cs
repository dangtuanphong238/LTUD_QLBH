namespace QLBH
{
    partial class frmTimKiem
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
            this.txtSearchSP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSearchSP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSearchKH = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearchKH = new System.Windows.Forms.TextBox();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.btnThoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sản Phẩm";
            // 
            // txtSearchSP
            // 
            this.txtSearchSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchSP.Location = new System.Drawing.Point(94, 27);
            this.txtSearchSP.Name = "txtSearchSP";
            this.txtSearchSP.Size = new System.Drawing.Size(166, 24);
            this.txtSearchSP.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSearchSP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtSearchSP);
            this.groupBox1.Location = new System.Drawing.Point(12, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(266, 132);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản Phẩm";
            // 
            // btnSearchSP
            // 
            this.btnSearchSP.Location = new System.Drawing.Point(143, 79);
            this.btnSearchSP.Name = "btnSearchSP";
            this.btnSearchSP.Size = new System.Drawing.Size(75, 31);
            this.btnSearchSP.TabIndex = 2;
            this.btnSearchSP.Text = "Search";
            this.btnSearchSP.UseVisualStyleBackColor = true;
            this.btnSearchSP.Click += new System.EventHandler(this.BtnSearchSP_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSearchKH);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtSearchKH);
            this.groupBox2.Location = new System.Drawing.Point(311, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(277, 132);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Khách Hàng";
            // 
            // btnSearchKH
            // 
            this.btnSearchKH.Location = new System.Drawing.Point(143, 79);
            this.btnSearchKH.Name = "btnSearchKH";
            this.btnSearchKH.Size = new System.Drawing.Size(75, 31);
            this.btnSearchKH.TabIndex = 2;
            this.btnSearchKH.Text = "Search";
            this.btnSearchKH.UseVisualStyleBackColor = true;
            this.btnSearchKH.Click += new System.EventHandler(this.BtnSearchKH_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Khách Hàng";
            // 
            // txtSearchKH
            // 
            this.txtSearchKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKH.Location = new System.Drawing.Point(108, 27);
            this.txtSearchKH.Name = "txtSearchKH";
            this.txtSearchKH.Size = new System.Drawing.Size(163, 24);
            this.txtSearchKH.TabIndex = 1;
            // 
            // dgvSearch
            // 
            this.dgvSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSearch.Location = new System.Drawing.Point(0, 226);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(600, 152);
            this.dgvSearch.TabIndex = 3;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(454, 183);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 27);
            this.btnThoat.TabIndex = 4;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.BtnThoat_Click);
            // 
            // frmTimKiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 378);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.dgvSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmTimKiem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTimKiem";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearchSP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSearchSP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSearchKH;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearchKH;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.Button btnThoat;
    }
}