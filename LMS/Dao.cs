// <copyright file="Dao.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace LMS
{
    using System.Data.SqlClient;

    /// <summary>
    /// Dao class.
    /// </summary>
    public class Dao
    {
        /// <summary>
        /// database connection.
        /// </summary>
        private SqlConnection sc;

        /// <summary>
        /// connect to database.
        /// </summary>
        /// <returns>the database.</returns>
        public SqlConnection Connect()
        {
            string str = @"Data Source=LAPTOP-O9OBELQO; Initial Catalog=BookDB;Integrated Security=True";
            this.sc = new SqlConnection(str);
            this.sc.Open();
            return this.sc;
        }

        /// <summary>
        /// Command function.
        /// </summary>
        /// <param name="sql">the database.</param>
        /// <returns>the command.</returns>
        public SqlCommand Command(string sql)
        {
            SqlCommand cmd = new SqlCommand(sql, this.Connect());
            return cmd;
        }

        /// <summary>
        /// execute the command.
        /// </summary>
        /// <param name="sql">the database.</param>
        /// <returns>command execute.</returns>
        public int Execute(string sql)
        {
            return this.Command(sql).ExecuteNonQuery();
        }

        /// <summary>
        /// read from database.
        /// </summary>
        /// <param name="sql">database for read.</param>
        /// <returns>command read.</returns>
        public SqlDataReader Read(string sql)
        {
            return this.Command(sql).ExecuteReader();
        }

        /// <summary>
        /// use to close Dao.
        /// </summary>
        public void Daoclose()
        {
            this.sc.Close();
        }
    }
}
