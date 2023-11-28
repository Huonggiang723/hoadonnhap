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
    public partial class ChiTietHDN : Form
    {
        processDatabase pd = new processDatabase();
        public ChiTietHDN()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int maHDN;
            int maSP;
            int soLuong;
            float donGia;
            float khuyenMai;

            if (int.TryParse(txtMaHDN.Text, out maHDN) &&
                int.TryParse(txtMaSP.Text, out maSP) &&
                int.TryParse(txtSoLuong.Text, out soLuong) &&
                float.TryParse(txtDonGia.Text, out donGia) &&
                float.TryParse(txtKhuyenMai.Text, out khuyenMai))
            {
                string checkExistSql = string.Format("SELECT COUNT(*) FROM tblChiTietHDN WHERE MaHDN='{0}' AND MaSP='{1}'", maHDN, maSP);
                int existingRecords = (int)pd.ExecuteScalar(checkExistSql);

                if (existingRecords > 0)
                {
                    MessageBox.Show("Mã này đã tồn tại");
                    return;
                }


                string insertSql = string.Format("INSERT INTO tblChiTietHDN (MaHDN, MaSP, SoLuong, DonGia, KhuyenMai) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')",
                                                maHDN, maSP, soLuong, donGia, khuyenMai);
                pd.CapNhat(insertSql);
                dvgHD.DataSource = pd.DocBang("SELECT * FROM tblChiTietHDN");
            }
            else
            {
                MessageBox.Show("Lỗi: Dữ liệu không hợp lệ. Vui lòng kiểm tra lại các trường dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ChiTietHDN_Load(object sender, EventArgs e)
        {

            dvgHD.DataSource = pd.DocBang("Select * from tblChiTietHDN");
        }

        private void dvgHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtMaHDN.Text = dvgHD.CurrentRow.Cells[0].Value.ToString();
            txtMaSP.Text = dvgHD.CurrentRow.Cells[1].Value.ToString();
            txtSoLuong.Text = dvgHD.CurrentRow.Cells[2].Value.ToString();
            txtDonGia.Text = dvgHD.CurrentRow.Cells[3].Value.ToString();
            txtKhuyenMai.Text = dvgHD.CurrentRow.Cells[4].Value.ToString();
           
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            string sql = "delete from tblChiTietHDN where MaHDN ='" +
              txtMaHDN.Text + "'";
            pd.CapNhat(sql);
            dvgHD.DataSource = pd.DocBang
            ("select * from tblChiTietHDN");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem có hàng nào được chọn không
            if (dvgHD.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
                return;
            }

            // Lấy hàng được chọn
            DataGridViewRow selectedRow = dvgHD.SelectedRows[0];

            // Lấy dữ liệu từ các ô văn bản hoặc điều khiển tương ứng
            int maHDN = Convert.ToInt32(selectedRow.Cells["MaHDN"].Value);
            int maSP = Convert.ToInt32(selectedRow.Cells["MaSP"].Value);

            int newMaHDN;
            if (!int.TryParse(txtMaHDN.Text, out newMaHDN))
            {
                MessageBox.Show("Mã HDN không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            int newMaSP;
            if (!int.TryParse(txtMaSP.Text, out newMaSP))
            {
                MessageBox.Show("Mã SP không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            int soLuong;
            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            float donGia;
            if (!float.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ. Vui lòng nhập một số thực.");
                return;
            }

            float khuyenMai;
            if (!float.TryParse(txtKhuyenMai.Text, out khuyenMai))
            {
                MessageBox.Show("Khuyến mãi không hợp lệ. Vui lòng nhập một số thực.");
                return;
            }

            // Cập nhật dữ liệu trong cơ sở dữ liệu
            string updateSql = string.Format("UPDATE tblChiTietHDN SET SoLuong='{0}', DonGia='{1}', KhuyenMai='{2}', MaHDN='{3}', MaSP='{4}' WHERE MaHDN='{5}' AND MaSP='{6}'",
                                             soLuong, donGia, khuyenMai, newMaHDN, newMaSP, maHDN, maSP);
            pd.CapNhat(updateSql);

            // Hiển thị thông báo hoặc thực hiện các thao tác khác sau khi chỉnh sửa dữ liệu
            MessageBox.Show("Đã cập nhật dữ liệu thành công.");

            // Làm mới nguồn dữ liệu hiển thị trên DataGridView
            dvgHD.DataSource = pd.DocBang("SELECT * FROM tblChiTietHDN");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ban muon thoat khong?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void btnTongTien_Click(object sender, EventArgs e)
        {
            int soLuong;
            if (!int.TryParse(txtSoLuong.Text, out soLuong))
            {
                MessageBox.Show("Số lượng không hợp lệ. Vui lòng nhập một số nguyên.");
                return;
            }

            float donGia;
            if (!float.TryParse(txtDonGia.Text, out donGia))
            {
                MessageBox.Show("Đơn giá không hợp lệ. Vui lòng nhập một số thực.");
                return;
            }

            float khuyenMai;
            if (!float.TryParse(txtKhuyenMai.Text, out khuyenMai))
            {
                MessageBox.Show("Khuyến mãi không hợp lệ. Vui lòng nhập một số thực.");
                return;
            }

            float tongTien = (soLuong * donGia) * ( khuyenMai / 100);

            MessageBox.Show("Tổng tiền: " + tongTien.ToString("N2")); // Hiển thị tổng tiền với định dạng số thập phân (N2)


        }
    }
    }

       
    

