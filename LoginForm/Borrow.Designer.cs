namespace LoginForm
{
    partial class Borrow
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
            groupBox1 = new GroupBox();
            btnBorrowBook = new Button();
            dateTimePicker = new DateTimePicker();
            cmbBooks = new ComboBox();
            txtEmail = new TextBox();
            txtContactNumber = new TextBox();
            txtDepartment = new TextBox();
            txtStudentName = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            btnSearchStudent = new Button();
            label10 = new Label();
            txtenteridno = new TextBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnBorrowBook);
            groupBox1.Controls.Add(dateTimePicker);
            groupBox1.Controls.Add(cmbBooks);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtContactNumber);
            groupBox1.Controls.Add(txtDepartment);
            groupBox1.Controls.Add(txtStudentName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(91, 175);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(725, 484);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borrow Book...";
            // 
            // btnBorrowBook
            // 
            btnBorrowBook.Location = new Point(525, 336);
            btnBorrowBook.Margin = new Padding(3, 4, 3, 4);
            btnBorrowBook.Name = "btnBorrowBook";
            btnBorrowBook.Size = new Size(123, 59);
            btnBorrowBook.TabIndex = 14;
            btnBorrowBook.Text = "BORROW";
            btnBorrowBook.UseVisualStyleBackColor = true;
            btnBorrowBook.Click += btnBorrowBook_Click;
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(216, 335);
            dateTimePicker.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(228, 27);
            dateTimePicker.TabIndex = 13;
            // 
            // cmbBooks
            // 
            cmbBooks.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbBooks.FormattingEnabled = true;
            cmbBooks.Location = new Point(216, 279);
            cmbBooks.Margin = new Padding(3, 4, 3, 4);
            cmbBooks.Name = "cmbBooks";
            cmbBooks.Size = new Size(431, 28);
            cmbBooks.TabIndex = 12;
            cmbBooks.SelectedIndexChanged += cmbBooks_SelectedIndexChanged;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(216, 225);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(431, 27);
            txtEmail.TabIndex = 11;
            // 
            // txtContactNumber
            // 
            txtContactNumber.Location = new Point(216, 176);
            txtContactNumber.Margin = new Padding(3, 4, 3, 4);
            txtContactNumber.MaxLength = 11;
            txtContactNumber.Name = "txtContactNumber";
            txtContactNumber.ReadOnly = true;
            txtContactNumber.Size = new Size(431, 27);
            txtContactNumber.TabIndex = 10;
            // 
            // txtDepartment
            // 
            txtDepartment.Location = new Point(216, 123);
            txtDepartment.Margin = new Padding(3, 4, 3, 4);
            txtDepartment.Name = "txtDepartment";
            txtDepartment.ReadOnly = true;
            txtDepartment.Size = new Size(431, 27);
            txtDepartment.TabIndex = 9;
            // 
            // txtStudentName
            // 
            txtStudentName.Location = new Point(216, 72);
            txtStudentName.Margin = new Padding(3, 4, 3, 4);
            txtStudentName.Name = "txtStudentName";
            txtStudentName.ReadOnly = true;
            txtStudentName.Size = new Size(431, 27);
            txtStudentName.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(65, 335);
            label8.Name = "label8";
            label8.Size = new Size(145, 25);
            label8.TabIndex = 6;
            label8.Text = "Book Issue Date";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(65, 280);
            label7.Name = "label7";
            label7.Size = new Size(109, 25);
            label7.TabIndex = 5;
            label7.Text = "Book Name";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(63, 228);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 4;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(62, 177);
            label5.Name = "label5";
            label5.Size = new Size(151, 25);
            label5.TabIndex = 3;
            label5.Text = "Contact Number";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(63, 125);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 2;
            label4.Text = "Department";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(62, 73);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 0;
            label2.Text = "Student Name";
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(667, 99);
            btnSearchStudent.Margin = new Padding(3, 4, 3, 4);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(117, 53);
            btnSearchStudent.TabIndex = 12;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(523, 56);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 11;
            label10.Text = "ENTER ID NO.:";
            // 
            // txtenteridno
            // 
            txtenteridno.Location = new Point(632, 52);
            txtenteridno.Margin = new Padding(3, 4, 3, 4);
            txtenteridno.Name = "txtenteridno";
            txtenteridno.Size = new Size(183, 27);
            txtenteridno.TabIndex = 10;
            txtenteridno.TextChanged += txtenteridno_TextChanged;
            // 
            // Borrow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(921, 732);
            Controls.Add(btnSearchStudent);
            Controls.Add(label10);
            Controls.Add(txtenteridno);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Borrow";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrow";
            Load += Borrow_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnBorrowBook;
        private DateTimePicker dateTimePicker;
        private ComboBox cmbBooks;
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
        private Button btnSearchStudent;
        private Label label10;
        private TextBox txtenteridno;
    }
}