// <copyright file="User2.Designer.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>
namespace LMS
{
    /// <summary>
    /// User2 window components.
    /// </summary>
    public partial class User2
    {
        /// <summary>
        /// data grid for showing data.
        /// </summary>
        private System.Windows.Forms.DataGridView dataGridView1;

        /// <summary>
        /// column1 for book id.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;

        /// <summary>
        /// column2 for book name.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;

        /// <summary>
        /// column3 for author.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;

        /// <summary>
        /// column4 for press.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;

        /// <summary>
        /// column5 for number store.
        /// </summary>
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;

        /// <summary>
        /// button for borrowing book.
        /// </summary>
        private System.Windows.Forms.Button button1;

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
            this.dataGridView1.TabIndex = 1;
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
            this.button1.Location = new System.Drawing.Point(530, 368);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "借出图书";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // User2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "User2";
            this.Text = "查看图书和借阅";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}