// <copyright file="User3.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace LMS
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;

    /// <summary>
    /// User3 window for turn back book.
    /// </summary>
    public partial class User3 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User3"/> class.
        /// </summary>
        public User3()
        {
            this.InitializeComponent();
            this.Table();
        }

        /// <summary>
        /// Read data from database then show in table.
        /// </summary>
        private void Table()
        {
            // clear old data.
            this.dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select [id],[bid],[datetime] from t_lend where [uid]='{Data.UId}'";
            IDataReader dc = dao.Read(sql);
            while (dc.Read())
            {
                this.dataGridView1.Rows.Add(
                                            dc[0].ToString(),
                                            dc[1].ToString(),
                                            dc[2].ToString());
            }

            dc.Close();
            dao.Daoclose();
        }

        /// <summary>
        /// button for return book.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            string bid = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            string sql = $"delete from t_lend where id='{id}'; update t_book set number=number+1 where id='{bid}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 1)
            {
                MessageBox.Show("归还成功");
                this.Table();
            }
        }
    }
}
