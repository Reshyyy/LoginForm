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
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtenteridno = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnReturn = new System.Windows.Forms.Button();
            this.dtreturndate = new System.Windows.Forms.DateTimePicker();
            this.txtBorrowedDate = new System.Windows.Forms.TextBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gridReturn = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReturn)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Location = new System.Drawing.Point(551, 85);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(102, 40);
            this.btnSearchStudent.TabIndex = 15;
            this.btnSearchStudent.Text = "Search Student";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.btnSearchStudent_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 53);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 15);
            this.label10.TabIndex = 14;
            this.label10.Text = "ENTER ID NO.:";
            // 
            // txtenteridno
            // 
            this.txtenteridno.Location = new System.Drawing.Point(520, 50);
            this.txtenteridno.Name = "txtenteridno";
            this.txtenteridno.Size = new System.Drawing.Size(161, 23);
            this.txtenteridno.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnReturn);
            this.groupBox1.Controls.Add(this.dtreturndate);
            this.groupBox1.Controls.Add(this.txtBorrowedDate);
            this.groupBox1.Controls.Add(this.txtBookName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(47, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(634, 228);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Return Book...";
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(459, 127);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(108, 44);
            this.btnReturn.TabIndex = 14;
            this.btnReturn.Text = "RETURN";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // dtreturndate
            // 
            this.dtreturndate.Location = new System.Drawing.Point(189, 135);
            this.dtreturndate.Name = "dtreturndate";
            this.dtreturndate.Size = new System.Drawing.Size(209, 23);
            this.dtreturndate.TabIndex = 13;
            // 
            // txtBorrowedDate
            // 
            this.txtBorrowedDate.Location = new System.Drawing.Point(189, 94);
            this.txtBorrowedDate.Name = "txtBorrowedDate";
            this.txtBorrowedDate.ReadOnly = true;
            this.txtBorrowedDate.Size = new System.Drawing.Size(378, 23);
            this.txtBorrowedDate.TabIndex = 9;
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(189, 54);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.ReadOnly = true;
            this.txtBookName.Size = new System.Drawing.Size(378, 23);
            this.txtBookName.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(21, 135);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 20);
            this.label8.TabIndex = 6;
            this.label8.Text = "Book Returned Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(21, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Borrowed Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(20, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Book Name";
            // 
            // gridReturn
            // 
            this.gridReturn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridReturn.Location = new System.Drawing.Point(47, 404);
            this.gridReturn.Name = "gridReturn";
            this.gridReturn.RowTemplate.Height = 25;
            this.gridReturn.Size = new System.Drawing.Size(634, 199);
            this.gridReturn.TabIndex = 17;
            this.gridReturn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridReturn_CellClick);
            // 
            // Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 640);
            this.Controls.Add(this.gridReturn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSearchStudent);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtenteridno);
            this.Name = "Return";
            this.Text = "Return";
            this.Load += new System.EventHandler(this.Return_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridReturn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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