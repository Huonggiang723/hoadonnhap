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
    public partial class kichthuoc : Form
    {
        public SqlConnection con;
        public DataTable tblKichThuoc = new DataTable();
        public kichthuoc()
        {
            InitializeComponent();
            btSua.Click += btnSua_Click;
          //  btXoa.Click += btnXoa_Click;
        }

        private void kichthuoc_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\hoadonnhap\\kichthuoc.mdf;Integrated Security=True";
        }
        public void Disconnect() //Ng?t k?t n?i
        {
            if (con.State == ConnectionState.Open) //n?u dang m?
            {
                con.Close(); //dóng
                con.Dispose(); //hu?
            }
        }

        public void LoadDataGridView()
        {
            Connect();
            string sql;
            sql = "select * from tblKichThuoc";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
            tblKichThuoc = new DataTable();
            sqlDataAdapter.Fill(tblKichThuoc);
            dataGridView1.DataSource = tblKichThuoc;

          
        }


        public void RunSQL(string sql) //Th?c hi?n m?t câu l?nh SQL
        {
            SqlCommand cmd = new SqlCommand(); //Ð?i tu?ng d? th?c hi?n l?nh
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery(); //Th?c hi?n câu l?nh
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtMaKichThuoc.Text) || string.IsNullOrWhiteSpace(txtTenKichThuoc1.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            string sql;
            sql = "SELECT MaKichThuoc FROM tblKichThuoc WHERE MaKichThuoc=N'" + txtMaKichThuoc.Text + "'";
            SqlDataAdapter MyData = new SqlDataAdapter(sql, con);
            DataTable table = new DataTable();
            MyData.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Mã này đã tồn tại");
                return;
            }

            // Hiển thị MessageBox xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu dữ liệu?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            // Kết nối đến cơ sở dữ liệu
            Connect();

            // Mở kết nối
            con.Open();

            // Thực hiện chèn thêm mới
            sql = "INSERT INTO tblKichThuoc VALUES ('" + txtMaKichThuoc.Text + "', '" + txtTenKichThuoc1.Text + "')";
            RunSQL(sql);
            LoadDataGridView();

            // Ngắt kết nối từ cơ sở dữ liệu
            Disconnect();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // Lấy dữ liệu từ các ô văn bản hoặc điều khiển tương ứng
            string maKichThuoc = txtMaKichThuoc.Text;
            string tenKichThuoc = txtTenKichThuoc1.Text;

            // Cập nhật dữ liệu trong DataTable hoặc cơ sở dữ liệu
            selectedRow.Cells["MaKichThuoc"].Value = maKichThuoc;
            selectedRow.Cells["TenKichThuoc"].Value = tenKichThuoc;

            // Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi chỉnh sửa dữ liệu
            MessageBox.Show("Đã cập nhật dữ liệu thành công.");
        }

        private void btXoa_Click(object sender, EventArgs e)
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
                string maKichThuoc = selectedRow.Cells["MaKichThuoc"].Value.ToString();

                // Xóa hàng được chọn khỏi DataGridView
                dataGridView1.Rows.Remove(selectedRow);

                // Xóa dữ liệu tương ứng trong cơ sở dữ liệu
                string sql = "DELETE FROM tblKichThuoc WHERE MaKichThuoc = '" + maKichThuoc + "'";

                Connect(); // Mở kết nối
                con.Open(); // Mở kết nối đến cơ sở dữ liệu

                RunSQL(sql); // Thực hiện câu lệnh SQL

                con.Close(); // Đóng kết nối

                // Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi xóa dữ liệu
                MessageBox.Show("Đã xóa dữ liệu thành công.");
            }
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat khong?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btSua_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtTenKichThuoc1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaKichThuoc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtTe_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
