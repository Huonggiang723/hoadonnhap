using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hoadonnhap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btxoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Xóa dữ liệu trên các TextBox
                txtuser.Text = string.Empty;
                textBox1.Text = string.Empty;

                // Xóa dữ liệu trên ComboBox
                comboBox1.SelectedIndex = -1;

                // Bỏ chọn RadioButton
                rabt1.Checked = false;
                rabt2.Checked = false;
                rabt3.Checked = false;
            }

        }

        private void btdangki_Click(object sender, EventArgs e)
        {
            bool isFormValid = true;

            // Kiểm tra TextBox
            if (string.IsNullOrWhiteSpace(txtuser.Text))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo");
                isFormValid = false;
            }
            else if (!IsValidEmail(txtuser.Text))
            {
                MessageBox.Show("Tên đăng nhập không hợp lệ. Vui lòng sử dụng định dạng email.", "Lỗi");
                isFormValid = false;
            }

            if (string.IsNullOrWhiteSpace(txtpassword.Text))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo");
                isFormValid = false;
            }

            // Kiểm tra ComboBox
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tỉnh thành.", "Thông báo");
                isFormValid = false;
            }

            // Kiểm tra RadioButton
            if (!rabt1.Checked && !rabt2.Checked && !rabt3.Checked)
            {
                MessageBox.Show("Vui lòng chọn giới tính.", "Thông báo");
                isFormValid = false;
            }

            if (isFormValid)
            {
                // Nếu form hợp lệ, thực hiện các hành động khác
                // ...
                MessageBox.Show("Đăng kí thành công!", "Thông báo");
            }

        }
        private bool IsValidEmail(string email)
        {
            // Sử dụng biểu thức chính quy để kiểm tra định dạng email
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void btlogin_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog();
        }

     

  

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.PasswordChar = '\0'; // Hiển thị mật khẩu
            }
            else
            {
                textBox1.PasswordChar = '*'; // Che giấu mật khẩu
            }
        }
    }

    
    
}
