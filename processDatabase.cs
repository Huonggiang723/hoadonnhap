using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace hoadonnhap
{
    internal class processDatabase
    {
        string stringcon = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Admin\\source\\repos\\hoadonnhap\\BangHoadonnhap.mdf;Integrated Security=True";
        SqlConnection con;
        public void KetNoi()
        {
            con = new SqlConnection(stringcon);
            if (con.State != ConnectionState.Open)
                con.Open();
        }
        public void DongKetNoi()
        {
            if (con.State != ConnectionState.Closed)
                con.Close();
            con.Dispose();
        }
        public DataTable DocBang(string sql)
        {
            DataTable tb = new DataTable();
            KetNoi();
            SqlDataAdapter adap = new SqlDataAdapter(sql, con);
            adap.Fill(tb);
            DongKetNoi();
            return tb;
        }
        public void CapNhat(string sql)
        {
            KetNoi();
            SqlCommand com = new SqlCommand();
            com.CommandText = sql;
            com.Connection = con;
            com.ExecuteNonQuery();

           

            DongKetNoi();
        }

        public object ExecuteScalar(string sql)
        {
            KetNoi();
            SqlCommand com = new SqlCommand();
            com.CommandText = sql;
            com.Connection = con;
            object result = com.ExecuteScalar();
            DongKetNoi();
            return result;
        }

    }

}
