// <copyright file="Login.cs" company="PlaceholderCompany">
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
    /// login window.
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Login"/> class.
        /// </summary>
        public Login()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// The button that work to login the account.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text != string.Empty && this.textBox2.Text != string.Empty)
            {
                this.LoginIn();
            }
            else
            {
                MessageBox.Show("请确保账户以及密码不为空");
            }
        }

        /// <summary>
        /// judge if login in or not.
        /// </summary>
        private void LoginIn()
        {
            // user verify.
            if (this.radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();

                // string sql = "select * from t_user where id='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
                // string sql = String.Format("select * from t_user where id='{0}' and password='{1}'", textBox1.Text, textBox2.Text);
                string sql = $"select * from t_user where id ='{this.textBox1.Text}' and password='{this.textBox2.Text}'";
                IDataReader dc = dao.Read(sql);
                if (dc.Read())
                {
                    Data.UId = dc["id"].ToString();
                    Data.UName = dc["name"].ToString();
                    MessageBox.Show("登陆成功!");
                    User1 user = new User1();
                    this.Hide();
                    user.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败!");
                }

                dao.Daoclose();
            }
            else if (this.radioButtonAdmin.Checked == true)
            {
                // admin verify.
                Dao dao = new Dao();
                string sql = $"select * from t_admin where id ='{this.textBox1.Text}' and password='{this.textBox2.Text}'";
                IDataReader dc = dao.Read(sql);
                if (dc.Read())
                {
                    Data.UId = dc["id"].ToString();

                    // Data.UName = dc["name"].ToString();
                    MessageBox.Show("登陆成功!");
                    Admin1 a = new Admin1();
                    this.Hide();
                    a.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("登陆失败!");
                }

                dao.Daoclose();
            }
            else
            {
                MessageBox.Show("未选中单选框");
            }
        }
    }
}
