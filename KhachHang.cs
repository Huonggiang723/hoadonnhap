using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace hoadonnhap
{
    public partial class KhachHang : Form
    {
        public SqlConnection con;
        public DataTable tblKhachHang = new DataTable();

        public KhachHang()
        {
            InitializeComponent();
        }

        private void KhachHang_Load(object sender, EventArgs e)
        {
         
            LoadDataGridView();
        }
        public void Connect()
        {
            con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\hoadonnhap\\KhachHang.mdf;Integrated Security=True");
        }

        public void Disconnect()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
                con.Dispose();
            }
        }
        private void LoadDataGridView()
        {
            Connect();
            string sql = "SELECT * FROM tblKhachHang";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            sqlDataAdapter.SelectCommand = new SqlCommand(sql, con);
            tblKhachHang = new DataTable();
            sqlDataAdapter.Fill(tblKhachHang);
            dataGridView1.DataSource = tblKhachHang;
        }

      

        public void RunSQL(string sql)
        {
            Connect(); // Mở kết nối trước khi thực hiện câu lệnh SQL
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                con.Open(); // Mở kết nối
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                con.Close(); // Đóng kết nối sau khi thực hiện câu lệnh SQL
            }

        }

  

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maKhachHang = txtMaKhachHang.Text;
            string diaChi = txtDiaChi.Text;

            if (!string.IsNullOrEmpty(maKhachHang) && !string.IsNullOrEmpty(diaChi))
            {
                Connect(); // Khởi tạo kết nối trước khi sử dụng

                // Kiểm tra trùng lặp
                string sqlCheck = $"SELECT COUNT(*) FROM tblKhachHang WHERE MaKhachHang = '{maKhachHang}'";
                SqlCommand checkCmd = new SqlCommand(sqlCheck, con);

                try
                {
                    con.Open(); // Mở kết nối
                    int existingCount = (int)checkCmd.ExecuteScalar();

                    if (existingCount == 0)
                    {
                        string sql = $"INSERT INTO tblKhachHang (MaKhachHang, DiaChi) VALUES ('{maKhachHang}', '{diaChi}')";
                        RunSQL(sql);
                        MessageBox.Show("Thêm thành công!");
                        LoadDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Mã khách hàng đã tồn tại!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close(); // Đóng kết nối sau khi sử dụng
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Lấy dữ liệu từ các ô văn bản hoặc điều khiển tương ứng
            string maKichThuoc = txtMaKhachHang.Text;
            string tenKichThuoc = txtDiaChi.Text;

            // Cập nhật dữ liệu trong DataTable hoặc cơ sở dữ liệu
            selectedRow.Cells["MaKhachHang"].Value = maKichThuoc;
            selectedRow.Cells["DiaChi"].Value = tenKichThuoc;

            // Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi chỉnh sửa dữ liệu
            MessageBox.Show("Đã cập nhật dữ liệu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
                return;
            }

            // Hiển thị hộp thoại xác nhận xóa
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Lấy hàng được chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Lấy giá trị của cột MaKichThuoc từ hàng được chọn
                string maKichThuoc = selectedRow.Cells["MaKhachHang"].Value.ToString();

                // Xóa hàng được chọn khỏi DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Xóa dữ liệu tương ứng trong cơ sở dữ liệu
                string sql = "DELETE FROM tblKhachHang WHERE MaKhachHang = '" + maKichThuoc + "'";

                Connect(); // Mở kết nối
                con.Open(); // Mở kết nối đến cơ sở dữ liệu

                RunSQL(sql); // Thực hiện câu lệnh SQL

                con.Close(); // Đóng kết nối

                // Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa dữ liệu
                MessageBox.Show("Đã xóa dữ liệu thành công.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat khong?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}