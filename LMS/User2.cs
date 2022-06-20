// <copyright file="User2.cs" company="PlaceholderCompany">
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
    /// User2 window for borrow book.
    /// </summary>
    public partial class User2 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="User2"/> class.
        /// </summary>
        public User2()
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
            string sql = "select * from t_book";
            IDataReader dc = dao.Read(sql);
            while (dc.Read())
            {
                this.dataGridView1.Rows.Add(
                                            dc[0].ToString(),
                                            dc[1].ToString(),
                                            dc[2].ToString(),
                                            dc[3].ToString(),
                                            dc[4].ToString());
            }

            dc.Close();
            dao.Daoclose();
        }

        /// <summary>
        /// button for borrow book.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            // get book id.
            string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            // store number.
            int number = int.Parse(this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString());

            if (number < 1)
            {
                MessageBox.Show("库存不足，请联系管理员购入");
            }
            else
            {
                string sql = $"insert into t_lend ([uid],bid,[datetime]) values('{Data.UId}','{id}',getdate()); update t_book set number=number-1 where id = '{id}'";
                Dao dao = new Dao();
                if (dao.Execute(sql) > 1)
                {
                    MessageBox.Show($"用户{Data.UName}: 借出id为{id}的图书");
                    this.Table();
                }
            }
        }
    }
}
