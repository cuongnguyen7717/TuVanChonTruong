using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace HCG_N15
{
    internal class ketnoi
    {
        private string con_str = "";
        private SqlConnection conn = null;
        public ketnoi()
        {
            con_str = @"Data Source=DESKTOP-1FHDCFR;Initial Catalog=Tuvanchontruong;Integrated Security=True";
            conn = new SqlConnection(con_str);
        }
        public bool ThucThi(string sql)
        {
            try
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataSet Laydulieu(string sql, string table_name)
        {
            DataSet ds = new DataSet();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                da.Fill(ds, table_name);
            }
            catch
            {

            }
            return ds;
        }
        public DataTable getTable(string sql)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, conn);
            da.Fill(dt);
            return dt;

        }
    }
}