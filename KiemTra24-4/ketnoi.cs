using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace KiemTra24_4
{
    class ketnoi
    {
        public static SqlConnection conn;
        public static void connect()
        {
            conn = new SqlConnection(@"Data Source=DESKTOP-88NIE12;Initial Catalog=KIEMTRA;Integrated Security=True");
            conn.Open();

            if (conn.State == ConnectionState.Open)
            {
                MessageBox.Show("Kết nối thành công");
            }
            else
            {
                MessageBox.Show("Kết nối thất bại");
            }
        }

        public static DataTable getdata(String sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.SelectCommand = new SqlCommand();
            da.SelectCommand.Connection = conn;
            da.SelectCommand.CommandText = sql;
            DataTable tb = new DataTable();
            da.Fill(tb);
            return tb;
        }

        public static void runsql(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.Connection = conn;
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public static bool ktratrung(String sql)
        {
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            DataTable tb = new DataTable();
            da.Fill(tb);
            if (tb.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
