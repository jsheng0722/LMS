// <copyright file="Admin2_2.cs" company="PlaceholderCompany">
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
    /// admin2_2 window for modify book info.
    /// </summary>
    public partial class Admin2_2 : Form
    {
        /// <summary>
        /// id for book.
        /// </summary>
        private string iD = string.Empty;

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin2_2"/> class.
        /// </summary>
        public Admin2_2()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Admin2_2"/> class.
        /// </summary>
        /// <param name="id">the id.</param>
        /// <param name="name">the name.</param>
        /// <param name="author">the author.</param>
        /// <param name="press">the press.</param>
        /// <param name="number">the number.</param>
        public Admin2_2(string id, string name, string author, string press, string number)
        {
            this.InitializeComponent();
            this.iD = this.textBox1.Text = id;
            this.textBox2.Text = name;
            this.textBox3.Text = author;
            this.textBox4.Text = press;
            this.textBox5.Text = number;
        }

        /// <summary>
        /// modify confirm button.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            string sql = $"update t_book set id='{this.textBox1.Text}', [name]='{this.textBox2.Text}', author='{this.textBox3.Text}', press='{this.textBox4.Text}', number='{this.textBox5.Text}' where id='{this.iD}'";
            Dao dao = new Dao();
            if (dao.Execute(sql) > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
        }

        /// <summary>
        /// close window.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
