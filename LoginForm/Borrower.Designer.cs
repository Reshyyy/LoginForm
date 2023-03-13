﻿namespace LoginForm
{
    partial class Borrower
    {
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
            if (disposing && (components != null))
            {
                components.Dispose();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cmbBooks = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtDepartment = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreateBorrowerAccount = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnViewBorrowers = new System.Windows.Forms.Button();
            this.txtenteridno = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBorrowBook);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.cmbBooks);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtContactNumber);
            this.groupBox1.Controls.Add(this.txtDepartment);
            this.groupBox1.Controls.Add(this.txtStudentName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(73, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 363);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrow Book...";
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Location = new System.Drawing.Point(459, 252);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(108, 44);
            this.btnBorrowBook.TabIndex = 14;
            this.btnBorrowBook.Text = "BORROW";
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(189, 251);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker.TabIndex = 13;
            // 
            // cmbBooks
            // 
            this.cmbBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBooks.FormattingEnabled = true;
            this.cmbBooks.Location = new System.Drawing.Point(189, 209);
            this.cmbBooks.Name = "cmbBooks";
            this.cmbBooks.Size = new System.Drawing.Size(378, 23);
            this.cmbBooks.TabIndex = 12;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(189, 169);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(378, 23);
            this.txtEmail.TabIndex = 11;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(189, 132);
            this.txtContactNumber.MaxLength = 11;
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.ReadOnly = true;
            this.txtContactNumber.Size = new System.Drawing.Size(378, 23);
            this.txtContactNumber.TabIndex = 10;
            // 
            // txtDepartment
            // 
            this.txtDepartment.Location = new System.Drawing.Point(189, 92);
            this.txtDepartment.Name = "txtDepartment";
            this.txtDepartment.ReadOnly = true;
            this.txtDepartment.Size = new System.Drawing.Size(378, 23);
            this.txtDepartment.TabIndex = 9;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(189, 54);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(378, 23);
            this.txtStudentName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(67, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Book Issue Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(67, 210);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 20);
            this.label7.TabIndex = 5;
            this.label7.Text = "Book Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(66, 171);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(65, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Contact Number";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(66, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Department";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(65, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Student Name";
            // 
            // btnCreateBorrowerAccount
            // 
            this.btnCreateBorrowerAccount.BackgroundImage = global::LoginForm.Properties.Resources.student;
            this.btnCreateBorrowerAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateBorrowerAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCreateBorrowerAccount.Location = new System.Drawing.Point(86, 23);
            this.btnCreateBorrowerAccount.Name = "btnCreateBorrowerAccount";
            this.btnCreateBorrowerAccount.Size = new System.Drawing.Size(89, 58);
            this.btnCreateBorrowerAccount.TabIndex = 3;
            this.btnCreateBorrowerAccount.UseVisualStyleBackColor = true;
            this.btnCreateBorrowerAccount.Click += new System.EventHandler(this.btnCreateBorrowerAccount_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(73, 86);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Create Borrower ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(211, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "View Borrowers ";
            // 
            // btnViewBorrowers
            // 
            this.btnViewBorrowers.BackgroundImage = global::LoginForm.Properties.Resources.view_student;
            this.btnViewBorrowers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnViewBorrowers.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnViewBorrowers.Location = new System.Drawing.Point(223, 23);
            this.btnViewBorrowers.Name = "btnViewBorrowers";
            this.btnViewBorrowers.Size = new System.Drawing.Size(89, 58);
            this.btnViewBorrowers.TabIndex = 5;
            this.btnViewBorrowers.UseVisualStyleBackColor = true;
            this.btnViewBorrowers.Click += new System.EventHandler(this.btnViewBorrowers_Click);
            // 
            // txtenteridno
            // 
            this.txtenteridno.Location = new System.Drawing.Point(546, 42);
            this.txtenteridno.Name = "txtenteridno";
            this.txtenteridno.Size = new System.Drawing.Size(161, 23);
            this.txtenteridno.TabIndex = 7;
            this.txtenteridno.TextChanged += new System.EventHandler(this.txtenteridno_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(458, 45);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 8;
            this.label10.Text = "ENTER ID NO.:";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(577, 77);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(102, 40);
            this.btnSearchStudent.TabIndex = 9;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // Borrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 568);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtenteridno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnViewBorrowers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCreateBorrowerAccount);
            this.Controls.Add(this.groupBox1);
            this.Name = "Borrower";
            this.Text = "Borrower";
            this.Load += new System.EventHandler(this.Borrower_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtEmail;
        private TextBox txtContactNumber;
        private TextBox txtDepartment;
        private TextBox txtStudentName;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label2;
        private ComboBox cmbBooks;
        private Button btnBorrowBook;
        private DateTimePicker dateTimePicker;
        private Button btnCreateBorrowerAccount;
        private Label label9;
        private Label label1;
        private Button btnViewBorrowers;
        private TextBox txtenteridno;
        private Label label10;
        private Button btnSearchStudent;
    }
}