namespace nguyenquangkhai
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnthem = new System.Windows.Forms.Button();
            this.btnmoi = new System.Windows.Forms.Button();
            this.dtpngaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtgioitinh = new System.Windows.Forms.ComboBox();
            this.txtphongban = new System.Windows.Forms.ComboBox();
            this.txthovaten = new System.Windows.Forms.TextBox();
            this.txtthuongtru = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.gioitinh = new System.Windows.Forms.Label();
            this.phongban = new System.Windows.Forms.Label();
            this.ngaysinh = new System.Windows.Forms.Label();
            this.thuongtru = new System.Windows.Forms.Label();
            this.hoten = new System.Windows.Forms.Label();
            this.MaNV = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nghiencuu = new System.Windows.Forms.TabPage();
            this.lvnghiencuu = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.kinhdoanh = new System.Windows.Forms.TabPage();
            this.lvkinhdoanh = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.nghiencuu.SuspendLayout();
            this.kinhdoanh.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnxoa);
            this.groupBox1.Controls.Add(this.btnsua);
            this.groupBox1.Controls.Add(this.btnthem);
            this.groupBox1.Controls.Add(this.btnmoi);
            this.groupBox1.Controls.Add(this.dtpngaysinh);
            this.groupBox1.Controls.Add(this.txtgioitinh);
            this.groupBox1.Controls.Add(this.txtphongban);
            this.groupBox1.Controls.Add(this.txthovaten);
            this.groupBox1.Controls.Add(this.txtthuongtru);
            this.groupBox1.Controls.Add(this.txtMaNV);
            this.groupBox1.Controls.Add(this.gioitinh);
            this.groupBox1.Controls.Add(this.phongban);
            this.groupBox1.Controls.Add(this.ngaysinh);
            this.groupBox1.Controls.Add(this.thuongtru);
            this.groupBox1.Controls.Add(this.hoten);
            this.groupBox1.Controls.Add(this.MaNV);
            this.groupBox1.Location = new System.Drawing.Point(14, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 183);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(302, 147);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 17;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(221, 147);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(75, 23);
            this.btnsua.TabIndex = 16;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnthem
            // 
            this.btnthem.Location = new System.Drawing.Point(140, 147);
            this.btnthem.Name = "btnthem";
            this.btnthem.Size = new System.Drawing.Size(75, 23);
            this.btnthem.TabIndex = 15;
            this.btnthem.Text = "Thêm";
            this.btnthem.UseVisualStyleBackColor = true;
            this.btnthem.Click += new System.EventHandler(this.btnthem_Click);
            // 
            // btnmoi
            // 
            this.btnmoi.Location = new System.Drawing.Point(6, 147);
            this.btnmoi.Name = "btnmoi";
            this.btnmoi.Size = new System.Drawing.Size(75, 23);
            this.btnmoi.TabIndex = 14;
            this.btnmoi.Text = "Mới";
            this.btnmoi.UseVisualStyleBackColor = true;
            this.btnmoi.Click += new System.EventHandler(this.btnmoi_Click);
            // 
            // dtpngaysinh
            // 
            this.dtpngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpngaysinh.Location = new System.Drawing.Point(265, 23);
            this.dtpngaysinh.Name = "dtpngaysinh";
            this.dtpngaysinh.Size = new System.Drawing.Size(112, 20);
            this.dtpngaysinh.TabIndex = 13;
            // 
            // txtgioitinh
            // 
            this.txtgioitinh.FormattingEnabled = true;
            this.txtgioitinh.Items.AddRange(new object[] {
            "NAM",
            "NỮ",
            "KHÁC"});
            this.txtgioitinh.Location = new System.Drawing.Point(265, 52);
            this.txtgioitinh.Name = "txtgioitinh";
            this.txtgioitinh.Size = new System.Drawing.Size(112, 21);
            this.txtgioitinh.TabIndex = 12;
            this.txtgioitinh.Text = "NAM";
            // 
            // txtphongban
            // 
            this.txtphongban.FormattingEnabled = true;
            this.txtphongban.Items.AddRange(new object[] {
            "phòng nghiên cứu",
            "phòng kinh doanh"});
            this.txtphongban.Location = new System.Drawing.Point(82, 81);
            this.txtphongban.Name = "txtphongban";
            this.txtphongban.Size = new System.Drawing.Size(121, 21);
            this.txtphongban.TabIndex = 11;
            this.txtphongban.Text = "phòng nghiên cứu";
            this.txtphongban.SelectedIndexChanged += new System.EventHandler(this.txtphongban_SelectedIndexChanged);
            // 
            // txthovaten
            // 
            this.txthovaten.Location = new System.Drawing.Point(82, 52);
            this.txthovaten.Name = "txthovaten";
            this.txthovaten.Size = new System.Drawing.Size(100, 20);
            this.txthovaten.TabIndex = 10;
            // 
            // txtthuongtru
            // 
            this.txtthuongtru.Location = new System.Drawing.Point(82, 115);
            this.txtthuongtru.Name = "txtthuongtru";
            this.txtthuongtru.Size = new System.Drawing.Size(295, 20);
            this.txtthuongtru.TabIndex = 8;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Location = new System.Drawing.Point(82, 23);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(100, 20);
            this.txtMaNV.TabIndex = 7;
            // 
            // gioitinh
            // 
            this.gioitinh.AutoSize = true;
            this.gioitinh.Location = new System.Drawing.Point(209, 55);
            this.gioitinh.Name = "gioitinh";
            this.gioitinh.Size = new System.Drawing.Size(47, 13);
            this.gioitinh.TabIndex = 5;
            this.gioitinh.Text = "Giới tính";
            // 
            // phongban
            // 
            this.phongban.AutoSize = true;
            this.phongban.Location = new System.Drawing.Point(13, 84);
            this.phongban.Name = "phongban";
            this.phongban.Size = new System.Drawing.Size(59, 13);
            this.phongban.TabIndex = 4;
            this.phongban.Text = "Phòng ban";
            // 
            // ngaysinh
            // 
            this.ngaysinh.AutoSize = true;
            this.ngaysinh.Location = new System.Drawing.Point(209, 26);
            this.ngaysinh.Name = "ngaysinh";
            this.ngaysinh.Size = new System.Drawing.Size(54, 13);
            this.ngaysinh.TabIndex = 3;
            this.ngaysinh.Text = "Ngày sinh";
            this.ngaysinh.Click += new System.EventHandler(this.ngaysinh_Click);
            // 
            // thuongtru
            // 
            this.thuongtru.AutoSize = true;
            this.thuongtru.Location = new System.Drawing.Point(13, 118);
            this.thuongtru.Name = "thuongtru";
            this.thuongtru.Size = new System.Drawing.Size(63, 13);
            this.thuongtru.TabIndex = 2;
            this.thuongtru.Text = "Thường Trú";
            // 
            // hoten
            // 
            this.hoten.AutoSize = true;
            this.hoten.Location = new System.Drawing.Point(13, 55);
            this.hoten.Name = "hoten";
            this.hoten.Size = new System.Drawing.Size(54, 13);
            this.hoten.TabIndex = 1;
            this.hoten.Text = "Họ và tên";
            // 
            // MaNV
            // 
            this.MaNV.AutoSize = true;
            this.MaNV.Location = new System.Drawing.Point(13, 26);
            this.MaNV.Name = "MaNV";
            this.MaNV.Size = new System.Drawing.Size(40, 13);
            this.MaNV.TabIndex = 0;
            this.MaNV.Text = "Mã NV";
            this.MaNV.Click += new System.EventHandler(this.label1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.nghiencuu);
            this.tabControl1.Controls.Add(this.kinhdoanh);
            this.tabControl1.Location = new System.Drawing.Point(14, 203);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(383, 156);
            this.tabControl1.TabIndex = 2;
            // 
            // nghiencuu
            // 
            this.nghiencuu.Controls.Add(this.lvnghiencuu);
            this.nghiencuu.Location = new System.Drawing.Point(4, 22);
            this.nghiencuu.Name = "nghiencuu";
            this.nghiencuu.Padding = new System.Windows.Forms.Padding(3);
            this.nghiencuu.Size = new System.Drawing.Size(375, 130);
            this.nghiencuu.TabIndex = 0;
            this.nghiencuu.Text = "Phòng nghiên cứu";
            this.nghiencuu.UseVisualStyleBackColor = true;
            this.nghiencuu.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // lvnghiencuu
            // 
            this.lvnghiencuu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvnghiencuu.FullRowSelect = true;
            this.lvnghiencuu.GridLines = true;
            this.lvnghiencuu.HideSelection = false;
            this.lvnghiencuu.Location = new System.Drawing.Point(-4, 0);
            this.lvnghiencuu.Name = "lvnghiencuu";
            this.lvnghiencuu.Size = new System.Drawing.Size(383, 134);
            this.lvnghiencuu.TabIndex = 1;
            this.lvnghiencuu.UseCompatibleStateImageBehavior = false;
            this.lvnghiencuu.View = System.Windows.Forms.View.Details;
            this.lvnghiencuu.SelectedIndexChanged += new System.EventHandler(this.lvnghiencuu_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã nhân viên";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Giới tính";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Thường trú";
            // 
            // kinhdoanh
            // 
            this.kinhdoanh.Controls.Add(this.lvkinhdoanh);
            this.kinhdoanh.Location = new System.Drawing.Point(4, 22);
            this.kinhdoanh.Name = "kinhdoanh";
            this.kinhdoanh.Padding = new System.Windows.Forms.Padding(3);
            this.kinhdoanh.Size = new System.Drawing.Size(375, 130);
            this.kinhdoanh.TabIndex = 1;
            this.kinhdoanh.Text = "Phòng kinh doanh";
            this.kinhdoanh.UseVisualStyleBackColor = true;
            // 
            // lvkinhdoanh
            // 
            this.lvkinhdoanh.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10});
            this.lvkinhdoanh.GridLines = true;
            this.lvkinhdoanh.HideSelection = false;
            this.lvkinhdoanh.Location = new System.Drawing.Point(-4, 0);
            this.lvkinhdoanh.Name = "lvkinhdoanh";
            this.lvkinhdoanh.Size = new System.Drawing.Size(383, 134);
            this.lvkinhdoanh.TabIndex = 1;
            this.lvkinhdoanh.UseCompatibleStateImageBehavior = false;
            this.lvkinhdoanh.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Mã nhân viên";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Họ và tên";
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Giới tính";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Ngày sinh";
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Thường trú";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Quản lý thông tin nhân viên ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.nghiencuu.ResumeLayout(false);
            this.kinhdoanh.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MaNV;
        private System.Windows.Forms.DateTimePicker dtpngaysinh;
        private System.Windows.Forms.ComboBox txtgioitinh;
        private System.Windows.Forms.ComboBox txtphongban;
        private System.Windows.Forms.TextBox txthovaten;
        private System.Windows.Forms.TextBox txtthuongtru;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.Label gioitinh;
        private System.Windows.Forms.Label phongban;
        private System.Windows.Forms.Label ngaysinh;
        private System.Windows.Forms.Label thuongtru;
        private System.Windows.Forms.Label hoten;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnthem;
        private System.Windows.Forms.Button btnmoi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage nghiencuu;
        private System.Windows.Forms.TabPage kinhdoanh;
        private System.Windows.Forms.ListView lvnghiencuu;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ListView lvkinhdoanh;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
    }
}

