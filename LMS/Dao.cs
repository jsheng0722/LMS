using System.Data.SqlClient;

namespace LMS
{
    class Dao
    {
        SqlConnection sc;
        public SqlConnection connect()
        {
            string str = @"Data Source=LAPTOP-O9OBELQO; Initial Catalog=BookDB;Integrated Security=True";
            sc = new SqlConnection(str);
            sc.Open();
            return sc;
        }

        public SqlCommand command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, connect());
            return cmd;
        }

        public int Execute(string sql)
        {
            return command(sql).ExecuteNonQuery();
        }

        public SqlDataReader read(string sql)
        {
            return command(sql).ExecuteReader();
        }

        public void Daoclose()
        {
            sc.Close();
        }
    }
}
