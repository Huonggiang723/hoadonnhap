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
    public partial class HoaVan : Form
    {
        public SqlConnection con;
        public DataTable tblHoaVan = new DataTable();
        public HoaVan()
        {
            InitializeComponent();

        }
        private void HoaVan_Load(object sender, EventArgs e)
        {
            LoadDataGridView();
        }
        public void Connect()
        {
            con = new SqlConnection();
            con.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\hoadonnhap\\HoaVan.mdf;Integrated Security=True";
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
            string sql = "SELECT * FROM tblHoaVan";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql, con);
            tblHoaVan = new DataTable();
            sqlDataAdapter.SelectCommand.Connection = con; // Gán kết nối vào SelectCommand của SqlDataAdapter
            sqlDataAdapter.Fill(tblHoaVan);
            dataGridView1.DataSource = tblHoaVan;
        }
        public void RunSQL(string sql) 
        {
            SqlCommand cmd = new SqlCommand(); 
            cmd.CommandText = sql;
            cmd.Connection = con;
            try
            {
                cmd.ExecuteNonQuery(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

      
        private void btnSua_Click(object sender, EventArgs e)
        {
            // Ki?m tra xem có hàng nào du?c ch?n không
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng");
                return;
            }

            // L?y hàng du?c ch?n
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

            // L?y d? li?u t? các ô van b?n ho?c di?u khi?n tuong ?ng
            string maHoaVan = txtMaHoaVan.Text;
            string tenHoaVan = txtTenHoaVan.Text;

            // C?p nh?t d? li?u trong DataTable ho?c co s? d? li?u
            selectedRow.Cells["MaHoaVan"].Value = maHoaVan;
            selectedRow.Cells["TenHoaVan"].Value = tenHoaVan;

            // Hi?n th? thông báo ho?c th?c hi?n các thao tác khác sau khi ch?nh s?a d? li?u
            MessageBox.Show("Ðã cập nhật dl thành công.");
        }

    

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn 1 dòng cần xóa.");
                return;
            }

          
            DialogResult result = MessageBox.Show("bạn có chắc chắn xóa dòng này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                string maHoaVan = selectedRow.Cells["MaHoaVan"].Value.ToString();

                dataGridView1.Rows.Remove(selectedRow);

                string sql = "DELETE FROM tblHoaVan WHERE MaHoaVan = '" + maHoaVan + "'";

                Connect(); // M? k?t n?i
                con.Open(); // M? k?t n?i d?n co s? d? li?u

                RunSQL(sql); // Th?c hi?n câu l?nh SQL

                con.Close(); // Ðóng k?t n?i

                // Hi?n th? thông báo ho?c th?c hi?n các thao tác khác sau khi xóa d? li?u
                MessageBox.Show("Ðã xóa dữ liệu thành công.");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat khong?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            // Kiểm tra các trường không được để trống
            if (string.IsNullOrWhiteSpace(txtMaHoaVan.Text) || string.IsNullOrWhiteSpace(txtTenHoaVan.Text))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin");
                return;
            }

            string maHoaVan = txtMaHoaVan.Text;
            string tenHoaVan = txtTenHoaVan.Text;

            // Kiểm tra xem mã hoa văn đã tồn tại hay chưa
            string sql = "SELECT MaHoaVan FROM tblHoaVan WHERE MaHoaVan = N'" + maHoaVan + "'";
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                Connect();
                con.Open();
                cmd.Connection = con;
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Mã này đã tồn tại");
                    con.Close();
                    return;
                }
                con.Close();
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
            sql = "INSERT INTO tblHoaVan (MaHoaVan, TenHoaVan) VALUES (N'" + maHoaVan + "', N'" + tenHoaVan + "')";
            RunSQL(sql);
            LoadDataGridView();

            // Ngắt kết nối từ cơ sở dữ liệu
            Disconnect();
        }
    }

       
   }

