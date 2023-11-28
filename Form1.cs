using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace hoadonnhap
{
    public partial class Form1 : Form
    {
        processDatabase pd = new processDatabase();

        public Form1()
        {
            InitializeComponent();
            dvgHDN.CellClick += dvgHDN_CellClick;
        }

        private void btLuu_Click(object sender, EventArgs e)
        {
            int maHDN;
            int maSP;
            int soLuong;
            float donGia;
           

            if (int.TryParse(txtMaHDN.Text, out maHDN) &&
                int.TryParse(txtMaNCC.Text, out maSP) &&
                int.TryParse(txtMaNhanVien.Text, out soLuong) &&
                float.TryParse(mtxtNgayNhap.Text, out donGia) )
               // float.TryParse(txtKhuyenMai.Text, out khuyenMai))
            {
                string checkExistSql = string.Format("SELECT COUNT(*) FROM tblHoaDonNhap WHERE MaHDN='{0}' AND MaNCC='{1}'", maHDN, maSP);
                int existingRecords = (int)pd.ExecuteScalar(checkExistSql);

                if (existingRecords > 0)
                {
                    MessageBox.Show("Mã này đã tồn tại");
                    return;
                }


                string insertSql = string.Format("INSERT INTO tblHoaDonNhap(MaHDN, MaNCC, MaNV, NgayNhap) VALUES ('{0}', '{1}', '{2}', '{3}')",
                                                maHDN, maSP, soLuong, donGia);
                pd.CapNhat(insertSql);
                dvgHDN.DataSource = pd.DocBang("SELECT * FROM tblHoaDonNhap");
            }
            else
            {
                MessageBox.Show("Lỗi: Dữ liệu không hợp lệ. Vui lòng kiểm tra lại các trường dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

     

        private void btThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                System.Windows.Forms.Application.Exit();
        }

        private void btSua_Click(object sender, EventArgs e)
        {

            // Kiểm tra xem có hàng nào được chọn không
            if (dvgHDN.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dvgHDN.SelectedRows[0];

            // Lấy dữ liệu từ các ô văn bản hoặc điều khiển tương ứng
            int maHDN = Convert.ToInt32(selectedRow.Cells["MaHDN"].Value);
            int maNCC = Convert.ToInt32(selectedRow.Cells["MaNCC"].Value);

            int newMaHDN;
            if (!int.TryParse(txtMaHDN.Text, out newMaHDN))
            {
                MessageBox.Show("Mã HDN không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            int newMaNCC;
            if (!int.TryParse(txtMaNCC.Text, out newMaNCC))
            {
                MessageBox.Show("Mã SP không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            int maNhanVien;
            if (!int.TryParse(txtMaNhanVien.Text, out maNhanVien))
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            float tenNgayNhap;
            if (!float.TryParse(mtxtNgayNhap.Text, out tenNgayNhap))
            {
                MessageBox.Show("Đơn giá không hợp lệ. Vui lòng nhập một số thực.");
                return;
            }

            string updateSql = string.Format("UPDATE tblHoaDonNhap SET MaHDN='{0}', MaNCC='{1}', MaNV='{2}', NgayNhap='{3}' WHERE MaHDN='{4}'",
        newMaHDN, newMaNCC, maNhanVien, tenNgayNhap, maHDN);
            pd.CapNhat(updateSql);

            // Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi chỉnh sửa dữ liệu
            MessageBox.Show("Đã cập nhật dữ liệu thành công.");

            // Làm mới nguồn dữ liệu hiển thị trên DataGridView
            dvgHDN.DataSource = pd.DocBang("SELECT * FROM tblHoaDonNhap");
        }

        private void btHuy_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn chắc chắn muốn xóa dữ liệu?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Tạo câu truy vấn DELETE SQL
                string sql = string.Format("DELETE FROM tblHoaDonNhap WHERE MaHDN = '{0}' AND MaNCC = '{1}' AND MaNV = '{2}' AND NgayNhap = '{3}'",
                    txtMaHDN.Text, txtMaNCC.Text, txtMaNhanVien.Text, mtxtNgayNhap.Text);

                // Thực hiện xóa dữ liệu trong cơ sở dữ liệu
                pd.CapNhat(sql);

                // Làm mới nguồn dữ liệu hiển thị trên DataGridView
                dvgHDN.DataSource = pd.DocBang("SELECT * FROM tblHoaDonNhap");

                MessageBox.Show("Đã xóa dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dvgHDN.DataSource = pd.DocBang("Select * from tblHoaDonNhap");
        }

        private void dvgHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
              txtMaHDN.Text = dvgHDN.CurrentRow.Cells[0].Value.ToString();
              txtMaNCC.Text = dvgHDN.CurrentRow.Cells[1].Value.ToString();
              txtMaNhanVien.Text = dvgHDN.CurrentRow.Cells[2].Value.ToString();
              mtxtNgayNhap.Text = dvgHDN.CurrentRow.Cells[3].Value.ToString();
         //   txtKhuyenMai.Text = dvgHDN.CurrentRow.Cells[4].Value.ToString();
        }

      
    }
}
