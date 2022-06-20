// <copyright file="Admin1.cs" company="PlaceholderCompany">
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
    /// Admin1 window for book manage main page.
    /// </summary>
    public partial class Admin1 : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Admin1"/> class.
        /// </summary>
        public Admin1()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// tool strip menu click.
        /// </summary>
        /// <param name="sender">the sender.</param>
        /// <param name="e">the event.</param>
        private void 图书管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Admin2 admin = new Admin2();
            admin.ShowDialog();
        }
    }
}
