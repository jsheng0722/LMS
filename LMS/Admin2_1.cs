// <copyright file="Admin2_1.cs" company="PlaceholderCompany">
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
    /// Admin2_1 window for adding book window.
    /// </summary>
    public partial class Admin2_1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Admin2_1"/> class.
        /// </summary>
        public Admin2_1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// button for adding book.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty && this.textBox2.Text != string.Empty && this.textBox3.Text != string.Empty && this.textBox4.Text != string.Empty && this.textBox5.Text != string.Empty)
            {
                Dao dao = new Dao();
                string sql = $"insert into t_book values('{this.textBox1.Text}','{this.textBox2.Text}','{this.textBox3.Text}','{this.textBox4.Text}','{this.textBox5.Text}')";
                int n = dao.Execute(sql);
                if (n > 0)
                {
                    MessageBox.Show("成功添加图书");
                }
                else
                {
                    MessageBox.Show("添加失败");
                }

                this.textBox1.Text = string.Empty;
                this.textBox2.Text = string.Empty;
                this.textBox3.Text = string.Empty;
                this.textBox4.Text = string.Empty;
                this.textBox5.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("存在空文本框");
            }
        }

        /// <summary>
        /// clear button.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Text = string.Empty;
            this.textBox2.Text = string.Empty;
            this.textBox3.Text = string.Empty;
            this.textBox4.Text = string.Empty;
            this.textBox5.Text = string.Empty;
        }
    }
}
