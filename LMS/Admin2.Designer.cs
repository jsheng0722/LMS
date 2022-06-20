// <copyright file="Admin2.Designer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace LMS
{
    /// <summary>
    /// Admin2 window for manage book.
    /// </summary>
    public partial class Admin2
    {
        /// <summary>
        /// data grid for data.
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridView1;

        /// <summary>
        /// book id.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;

        /// <summary>
        /// book name.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;

        /// <summary>
        /// author of book.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;

        /// <summary>
        /// press of book.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;

        /// <summary>
        /// number of store for book.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;

        /// <summary>
        /// button for add book.
        /// </summary>
        private System.Windows.Forms.Button button1;

        /// <summary>
        /// button for modify book.
        /// </summary>
        private System.Windows.Forms.Button button2;

        /// <summary>
        /// button for delete book.
        /// </summary>
        private System.Windows.Forms.Button button3;

        /// <summary>
        /// button for refresh interface.
        /// </summary>
        private System.Windows.Forms.Button button4;
        
        /// <summary>
        /// button for search book by book id.
        /// </summary>
        private System.Windows.Forms.Button button5;

        /// <summary>
        /// button for search book by book name.
        /// </summary>
        private System.Windows.Forms.Button button6;

        /// <summary>
        /// text box for search book by book id.
        /// </summary>
        private System.Windows.Forms.TextBox textBox1;

        /// <summary>
        /// text box for search book by book name.
        /// </summary>
        private System.Windows.Forms.TextBox textBox2;

        /// <summary>
        /// label1 for book information.
        /// </summary>
        private System.Windows.Forms.Label label1;

        /// <summary>
        /// label1 for showing book information.
        /// </summary>
        private System.Windows.Forms.Label label2;

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(488, 450);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.Click += new System.EventHandler(this.DataGridView1_Click);
            // 
            // Column1
            // 
            this.column1.HeaderText = "书号";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "Column1";
            // 
            // Column2
            // 
            this.column2.HeaderText = "书名";
            this.column2.MinimumWidth = 6;
            this.column2.Name = "Column2";
            // 
            // Column3
            // 
            this.column3.HeaderText = "作者";
            this.column3.MinimumWidth = 6;
            this.column3.Name = "Column3";
            // 
            // Column4
            // 
            this.column4.HeaderText = "出版社";
            this.column4.MinimumWidth = 6;
            this.column4.Name = "Column4";
            // 
            // Column5
            // 
            this.column5.HeaderText = "库存";
            this.column5.MinimumWidth = 6;
            this.column5.Name = "Column5";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(521, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "添加图书";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 73);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 46);
            this.button2.TabIndex = 2;
            this.button2.Text = "修改图书";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(667, 149);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 46);
            this.button3.TabIndex = 4;
            this.button3.Text = "刷新";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(521, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 46);
            this.button4.TabIndex = 3;
            this.button4.Text = "删除图书";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(667, 381);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(110, 46);
            this.button5.TabIndex = 6;
            this.button5.Text = "书名查询";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(667, 268);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(110, 46);
            this.button6.TabIndex = 5;
            this.button6.Text = "书号查询";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(507, 216);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(270, 34);
            this.textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(507, 332);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(270, 34);
            this.textBox2.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(521, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "当权选中的图书为: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "无";
            // 
            // Admin2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Admin2";
            this.Text = "图书管理页面";
            this.Load += new System.EventHandler(this.Admin2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}