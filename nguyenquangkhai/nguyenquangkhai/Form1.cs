using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nguyenquangkhai
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        static string strChuoiKetNoi = @"Data Source=DESKTOP-PP2C079\SQLEXPRESS;Initial Catalog=thongtinkhachhang;Integrated Security=True";
        private void btnthem_Click(object sender, EventArgs e)
        {

            // Báo lỗi khi chưa nhập dữ liệu
            if (string.IsNullOrEmpty(txtMaNV.Text) || string.IsNullOrEmpty(txthovaten.Text) || string.IsNullOrEmpty(txtthuongtru.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Thêm thông tin vào listview
            ListViewItem item = new ListViewItem(txtMaNV.Text);

            item.SubItems.Add(txthovaten.Text);
            item.SubItems.Add(gioitinh.Text);
            item.SubItems.Add(dtpngaysinh.Value.ToString("dd/MM/yy"));
            item.SubItems.Add(txtphongban.Text);
            item.SubItems.Add(txtthuongtru.Text);

            lvnghiencuu.Items.Add(item);


            // Cấm nút Sửa & Xóa
            btnsua.Enabled = false;
            btnxoa.Enabled = false;
            btnthem.Enabled = true;


            // Xóa trắng groupbox thông tin nhân viên
            txtMaNV.Text = string.Empty;
            txthovaten.Text = string.Empty;
            dtpngaysinh.Value = DateTime.Now;
            txtgioitinh.Text = "NAM";
            txtphongban.Text = "ban nghiên cứu";
            txtthuongtru.Text = string.Empty;

        }
        // Sự kiện khi người dùng chọn một dòng dữ liệu trong listview
        private void lvnghiencuu_SelectedIndexChanged(object sender, EventArgs e)
        {

            //Kiểm tra người dùng có chọn hay không
            if (lvnghiencuu.SelectedItems.Count > 0)
            { 
                ListViewItem item = lvnghiencuu.SelectedItems[0];

                txtMaNV.Text = item.SubItems[0].Text;
                txthovaten.Text = item.SubItems[1].Text;
                txtgioitinh.Text = item.SubItems[2].Text;
                //dtpngaysinh.Value = DateTime.Parse(item.SubItems[3].Text);
                txtphongban.Text = item.SubItems[4].Text;
                txtthuongtru.Text = item.SubItems[5].Text;
            }
            

            // Cấm nút Thêm
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = false;
        }
            // Sự kiện sửa thông tin khách hàng sau khi đã chọn
            private void btnsua_Click(object sender, EventArgs e)
            {
            if (lvnghiencuu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int index = lvnghiencuu.SelectedIndices[0];



                lvnghiencuu.Items[index].SubItems[0].Text = txtMaNV.Text;
                lvnghiencuu.Items[index].SubItems[1].Text = txthovaten.Text;
                lvnghiencuu.Items[index].SubItems[2].Text = txtgioitinh.Text;
                lvnghiencuu.Items[index].SubItems[3].Text = dtpngaysinh.Value.ToString("dd/MM/yy");
                lvnghiencuu.Items[index].SubItems[4].Text = txtphongban.Text;
                lvnghiencuu.Items[index].SubItems[5].Text = txtthuongtru.Text;



                // Xóa trắng groupbox thông tin nhân viên
                txtMaNV.Text = string.Empty;
                txthovaten.Text = string.Empty;
                dtpngaysinh.Value = DateTime.Now;
                txtgioitinh.Text = "NAM";
                txtphongban.Text = "ban nghiên cứu";
                txtthuongtru.Text = string.Empty;
            }
            //Sự kiện xóa thông tin của nhân viên
            private void btnxoa_Click(object sender, EventArgs e)
            {
            if (lvnghiencuu.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn thông tin !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Bạn có chắc muốn xóa thông tin khách hàng !", "Xác nhận",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes &&
                    lvnghiencuu.SelectedIndices.Count > 0)
                {
                    lvnghiencuu.Items.RemoveAt(lvnghiencuu.SelectedIndices[0]);

                }

                // Kích hoạt các nút để dễ dàng chỉnh sửa, thêm thông tin mới và xóa thông tin cũ
                btnsua.Enabled = true;
                btnxoa.Enabled = true;
                btnthem.Enabled = true;


                // Xóa trắng groupbox thông tin nhân viên 
                txtMaNV.Text = string.Empty;
                txthovaten.Text = string.Empty;
                dtpngaysinh.Value = DateTime.Now;
                txtgioitinh.Text = "NAM";
                txtphongban.Text = "ban nghiên cứu";
                txtthuongtru.Text = string.Empty;
            }
        private void btnmoi_Click(object sender, EventArgs e)
        {
          

            // Kích hoạt các nút để dễ dàng chỉnh sửa, thêm thông tin mới và xóa thông tin cũ
            btnsua.Enabled = true;
            btnxoa.Enabled = true;
            btnthem.Enabled = true;
            btnmoi.Enabled = true;


            // Xóa trắng groupbox thông tin nhân viên
            txtMaNV.Text = string.Empty;
            txthovaten.Text = string.Empty;
            dtpngaysinh.Value = DateTime.Now;
            txtgioitinh.Text = "NAM";
            txtphongban.Text = "ban nghiên cứu";
            txtthuongtru.Text = string.Empty;
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {   

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ngaysinh_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtphongban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lvnghiencuu_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            this.lvnghiencuu.Location = new System.Drawing.Point(26, 187);
            this.lvnghiencuu.Margin = new System.Windows.Forms.Padding(2);
            this.lvnghiencuu.Name = "lvnghiencuu";
            this.lvnghiencuu.Size = new System.Drawing.Size(411, 155);
            this.lvnghiencuu.TabIndex = 1;
            this.lvnghiencuu.UseCompatibleStateImageBehavior = false;
            this.lvnghiencuu.View = System.Windows.Forms.View.Details;
            this.lvnghiencuu.SelectedIndexChanged += new System.EventHandler(this.lvnghiencuu_SelectedIndexChanged_1);
        }
    }
}
