// <copyright file="Admin2.cs" company="PlaceholderCompany">
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
    /// admin2 window for managing book.
    /// </summary>
    public partial class Admin2 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Admin2"/> class.
        /// </summary>
        public Admin2()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// run while loading.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Admin2_Load(object sender, EventArgs e)
        {
            this.Table();

            // get book id.
            this.label2.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "的" + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
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
        /// show data according by book id.
        /// </summary>
        private void TableId()
        {
            // clear old data.
            this.dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_book where id='{this.textBox1.Text}'";
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
        /// show data according by book name.
        /// </summary>
        private void TableName()
        {
            // clear old data.
            this.dataGridView1.Rows.Clear();
            Dao dao = new Dao();
            string sql = $"select * from t_book where name like '%{this.textBox2.Text}%'";
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
        /// delete button function.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                // get book id.
                string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                this.label2.Text = id + this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DialogResult dr = MessageBox.Show("确认删除？", "信息提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    string sql = "delete from t_book where id='{id}'";
                    Dao dao = new Dao();
                    if (dao.Execute(sql) > 0)
                    {
                        MessageBox.Show("删除成功!");
                        this.Table();
                    }
                    else
                    {
                        MessageBox.Show("删除失败" + sql);
                    }

                    dao.Daoclose();
                }
            }
            catch
            {
                MessageBox.Show("请先选中要删除的图书记录!", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// change the label2 while click on table.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void DataGridView1_Click(object sender, EventArgs e)
        {
            this.label2.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
        }

        /// <summary>
        /// add book button.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            Admin2_1 a = new Admin2_1();
            a.ShowDialog();
        }

        /// <summary>
        /// button for modify book.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                string name = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string author = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                string press = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string number = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                Admin2_2 a = new Admin2_2(id, name, author, press, number);
                a.ShowDialog();

                // refresh data.
                this.Table();
            }
            catch
            {
                MessageBox.Show("error");
            }
        }

        /// <summary>
        /// search by id button.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button6_Click(object sender, EventArgs e)
        {
            this.TableId();
        }

        /// <summary>
        /// search by name button.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button5_Click(object sender, EventArgs e)
        {
            this.TableName();
        }

        /// <summary>
        /// refresh button.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Table();
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
        }
    }
}
