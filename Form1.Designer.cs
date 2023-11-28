namespace hoadonnhap
{
    partial class Form1
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaNCC = new System.Windows.Forms.TextBox();
            this.txtMaNhanVien = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btThoat = new System.Windows.Forms.Button();
            this.btSua = new System.Windows.Forms.Button();
            this.btHuy = new System.Windows.Forms.Button();
            this.btLuu = new System.Windows.Forms.Button();
            this.dvgHDN = new System.Windows.Forms.DataGridView();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.btnTongTien = new System.Windows.Forms.Button();
            this.mtxtNgayNhap = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgHDN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 28);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hóa đơn nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã NCC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã HDN";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(445, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày nhập";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã nhân viên";
            // 
            // txtMaNCC
            // 
            this.txtMaNCC.Location = new System.Drawing.Point(522, 55);
            this.txtMaNCC.Name = "txtMaNCC";
            this.txtMaNCC.Size = new System.Drawing.Size(190, 20);
            this.txtMaNCC.TabIndex = 7;
            // 
            // txtMaNhanVien
            // 
            this.txtMaNhanVien.Location = new System.Drawing.Point(166, 103);
            this.txtMaNhanVien.Name = "txtMaNhanVien";
            this.txtMaNhanVien.Size = new System.Drawing.Size(199, 20);
            this.txtMaNhanVien.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btThoat);
            this.groupBox1.Controls.Add(this.btSua);
            this.groupBox1.Controls.Add(this.btHuy);
            this.groupBox1.Controls.Add(this.btLuu);
            this.groupBox1.Controls.Add(this.dvgHDN);
            this.groupBox1.Location = new System.Drawing.Point(25, 177);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 261);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn";
            // 
            // btThoat
            // 
            this.btThoat.Location = new System.Drawing.Point(603, 196);
            this.btThoat.Name = "btThoat";
            this.btThoat.Size = new System.Drawing.Size(100, 23);
            this.btThoat.TabIndex = 5;
            this.btThoat.Text = "Thoát";
            this.btThoat.UseVisualStyleBackColor = true;
            this.btThoat.Click += new System.EventHandler(this.btThoat_Click);
            // 
            // btSua
            // 
            this.btSua.Location = new System.Drawing.Point(423, 196);
            this.btSua.Name = "btSua";
            this.btSua.Size = new System.Drawing.Size(97, 23);
            this.btSua.TabIndex = 4;
            this.btSua.Text = "Sửa hóa đơn";
            this.btSua.UseVisualStyleBackColor = true;
            this.btSua.Click += new System.EventHandler(this.btSua_Click);
            // 
            // btHuy
            // 
            this.btHuy.Location = new System.Drawing.Point(243, 196);
            this.btHuy.Name = "btHuy";
            this.btHuy.Size = new System.Drawing.Size(97, 23);
            this.btHuy.TabIndex = 3;
            this.btHuy.Text = "Hủy hóa đơn";
            this.btHuy.UseVisualStyleBackColor = true;
            this.btHuy.Click += new System.EventHandler(this.btHuy_Click);
            // 
            // btLuu
            // 
            this.btLuu.Location = new System.Drawing.Point(46, 196);
            this.btLuu.Name = "btLuu";
            this.btLuu.Size = new System.Drawing.Size(112, 23);
            this.btLuu.TabIndex = 2;
            this.btLuu.Text = "Lưu hóa đơn";
            this.btLuu.UseVisualStyleBackColor = true;
            this.btLuu.Click += new System.EventHandler(this.btLuu_Click);
            // 
            // dvgHDN
            // 
            this.dvgHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgHDN.Location = new System.Drawing.Point(15, 19);
            this.dvgHDN.Name = "dvgHDN";
            this.dvgHDN.Size = new System.Drawing.Size(708, 150);
            this.dvgHDN.TabIndex = 0;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(166, 59);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(199, 20);
            this.txtMaHDN.TabIndex = 12;
            // 
            // btnTongTien
            // 
            this.btnTongTien.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTongTien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTongTien.Location = new System.Drawing.Point(648, 154);
            this.btnTongTien.Name = "btnTongTien";
            this.btnTongTien.Size = new System.Drawing.Size(100, 27);
            this.btnTongTien.TabIndex = 6;
            this.btnTongTien.Text = "Tổng tiền";
            this.btnTongTien.UseVisualStyleBackColor = false;
            // 
            // mtxtNgayNhap
            // 
            this.mtxtNgayNhap.Location = new System.Drawing.Point(522, 106);
            this.mtxtNgayNhap.Name = "mtxtNgayNhap";
            this.mtxtNgayNhap.Size = new System.Drawing.Size(190, 20);
            this.mtxtNgayNhap.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mtxtNgayNhap);
            this.Controls.Add(this.btnTongTien);
            this.Controls.Add(this.txtMaHDN);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtMaNhanVien);
            this.Controls.Add(this.txtMaNCC);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "hóa đơn nhập";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dvgHDN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaNCC;
        private System.Windows.Forms.TextBox txtMaNhanVien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btThoat;
        private System.Windows.Forms.Button btSua;
        private System.Windows.Forms.Button btHuy;
        private System.Windows.Forms.Button btLuu;
        private System.Windows.Forms.DataGridView dvgHDN;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Button btnTongTien;
        private System.Windows.Forms.TextBox mtxtNgayNhap;
    }
}

