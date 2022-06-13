using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text!="" && textBox2.Text != "")
            {
                login();
            }
            else
            {
                MessageBox.Show("请确保账户以及密码不为空");
            }
        }

        // 登录方法，验证是否成功登录，允许返回真
        public Boolean login()
        {
            // 用户验证
            if(radioButtonUser.Checked == true)
            {
                Dao dao = new Dao();
                //string sql = "select * from t_user where id='" + textBox1.Text + "' and password ='" + textBox2.Text + "'";
                //string sql = String.Format("select * from t_user where id='{0}' and password='{1}'", textBox1.Text, textBox2.Text);
                string sql = $"select * from t_user where id ='{textBox1.Text}' and password='{textBox2.Text}'";
                IDataReader dc = dao.read(sql);
                dc.Read();
                MessageBox.Show(dc[0].ToString()+dc["name"].ToString());
            }
            // 管理员验证
            if(radioButtonAdmin.Checked == true)
            {
                Dao dao = new Dao();
            }
            return true;
        }
    }
}
