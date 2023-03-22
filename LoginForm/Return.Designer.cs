namespace LoginForm
{
    partial class Return
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
            btnSearchStudent = new Button();
            label10 = new Label();
            txtenteridno = new TextBox();
            groupBox1 = new GroupBox();
            btnReturn = new Button();
            dtreturndate = new DateTimePicker();
            txtBorrowedDate = new TextBox();
            txtBookName = new TextBox();
            label8 = new Label();
            label4 = new Label();
            label2 = new Label();
            gridReturn = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridReturn).BeginInit();
            SuspendLayout();
            // 
            // btnSearchStudent
            // 
            btnSearchStudent.Location = new Point(190, 120);
            btnSearchStudent.Margin = new Padding(3, 4, 3, 4);
            btnSearchStudent.Name = "btnSearchStudent";
            btnSearchStudent.Size = new Size(117, 53);
            btnSearchStudent.TabIndex = 15;
            btnSearchStudent.Text = "Search Student";
            btnSearchStudent.UseVisualStyleBackColor = true;
            btnSearchStudent.Click += btnSearchStudent_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(48, 77);
            label10.Name = "label10";
            label10.Size = new Size(104, 20);
            label10.TabIndex = 14;
            label10.Text = "ENTER ID NO.:";
            // 
            // txtenteridno
            // 
            txtenteridno.Location = new Point(155, 73);
            txtenteridno.Margin = new Padding(3, 4, 3, 4);
            txtenteridno.Name = "txtenteridno";
            txtenteridno.Size = new Size(183, 27);
            txtenteridno.TabIndex = 13;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnReturn);
            groupBox1.Controls.Add(dtreturndate);
            groupBox1.Controls.Add(txtBorrowedDate);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(184, 572);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(695, 304);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "Return Book...";
            // 
            // btnReturn
            // 
            btnReturn.Location = new Point(525, 169);
            btnReturn.Margin = new Padding(3, 4, 3, 4);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(123, 59);
            btnReturn.TabIndex = 14;
            btnReturn.Text = "RETURN";
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // dtreturndate
            // 
            dtreturndate.Location = new Point(216, 180);
            dtreturndate.Margin = new Padding(3, 4, 3, 4);
            dtreturndate.Name = "dtreturndate";
            dtreturndate.Size = new Size(238, 27);
            dtreturndate.TabIndex = 13;
            // 
            // txtBorrowedDate
            // 
            txtBorrowedDate.Location = new Point(216, 125);
            txtBorrowedDate.Margin = new Padding(3, 4, 3, 4);
            txtBorrowedDate.Name = "txtBorrowedDate";
            txtBorrowedDate.ReadOnly = true;
            txtBorrowedDate.Size = new Size(431, 27);
            txtBorrowedDate.TabIndex = 9;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(216, 72);
            txtBookName.Margin = new Padding(3, 4, 3, 4);
            txtBookName.Name = "txtBookName";
            txtBookName.ReadOnly = true;
            txtBookName.Size = new Size(431, 27);
            txtBookName.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(24, 180);
            label8.Name = "label8";
            label8.Size = new Size(179, 25);
            label8.TabIndex = 6;
            label8.Text = "Book Returned Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(24, 128);
            label4.Name = "label4";
            label4.Size = new Size(138, 25);
            label4.TabIndex = 2;
            label4.Text = "Borrowed Date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 72);
            label2.Name = "label2";
            label2.Size = new Size(109, 25);
            label2.TabIndex = 0;
            label2.Text = "Book Name";
            // 
            // gridReturn
            // 
            gridReturn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridReturn.Location = new Point(48, 197);
            gridReturn.Margin = new Padding(3, 4, 3, 4);
            gridReturn.Name = "gridReturn";
            gridReturn.ReadOnly = true;
            gridReturn.RowHeadersWidth = 51;
            gridReturn.RowTemplate.Height = 25;
            gridReturn.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridReturn.Size = new Size(978, 349);
            gridReturn.TabIndex = 17;
            gridReturn.CellClick += gridReturn_CellClick;
            gridReturn.CellContentClick += gridReturn_CellContentClick;
            // 
            // Return
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1081, 939);
            Controls.Add(gridReturn);
            Controls.Add(groupBox1);
            Controls.Add(btnSearchStudent);
            Controls.Add(label10);
            Controls.Add(txtenteridno);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Return";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Return";
            Load += Return_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridReturn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSearchStudent;
        private Label label10;
        private TextBox txtenteridno;
        private GroupBox groupBox1;
        private Button btnReturn;
        private DateTimePicker dtreturndate;
        private TextBox txtBorrowedDate;
        private TextBox txtBookName;
        private Label label8;
        private Label label4;
        private Label label2;
        private DataGridView gridReturn;
    }
}