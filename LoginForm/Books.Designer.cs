namespace LoginForm
{
    partial class Books
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
            txtprice = new TextBox();
            label = new Label();
            datepurchased = new DateTimePicker();
            label8 = new Label();
            txtqty = new TextBox();
            label7 = new Label();
            txtauthor = new TextBox();
            txttitle = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtno = new TextBox();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnClear = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            txtSearch = new TextBox();
            label5 = new Label();
            grid1 = new DataGridView();
            lblWelcome = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grid1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txtprice);
            groupBox1.Controls.Add(label);
            groupBox1.Controls.Add(datepurchased);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtqty);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtauthor);
            groupBox1.Controls.Add(txttitle);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtno);
            groupBox1.Location = new Point(39, 493);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(587, 377);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Book";
            // 
            // txtprice
            // 
            txtprice.Location = new Point(201, 203);
            txtprice.Margin = new Padding(3, 4, 3, 4);
            txtprice.Name = "txtprice";
            txtprice.Size = new Size(335, 27);
            txtprice.TabIndex = 11;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(48, 207);
            label.Name = "label";
            label.Size = new Size(41, 20);
            label.TabIndex = 10;
            label.Text = "Price";
            // 
            // datepurchased
            // 
            datepurchased.Location = new Point(201, 305);
            datepurchased.Margin = new Padding(3, 4, 3, 4);
            datepurchased.Name = "datepurchased";
            datepurchased.Size = new Size(335, 27);
            datepurchased.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(48, 309);
            label8.Name = "label8";
            label8.Size = new Size(112, 20);
            label8.TabIndex = 8;
            label8.Text = "Date Purchased";
            // 
            // txtqty
            // 
            txtqty.Location = new Point(201, 253);
            txtqty.Margin = new Padding(3, 4, 3, 4);
            txtqty.Name = "txtqty";
            txtqty.Size = new Size(335, 27);
            txtqty.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(48, 256);
            label7.Name = "label7";
            label7.Size = new Size(65, 20);
            label7.TabIndex = 6;
            label7.Text = "Quantity";
            // 
            // txtauthor
            // 
            txtauthor.Location = new Point(201, 151);
            txtauthor.Margin = new Padding(3, 4, 3, 4);
            txtauthor.Name = "txtauthor";
            txtauthor.Size = new Size(335, 27);
            txtauthor.TabIndex = 5;
            // 
            // txttitle
            // 
            txttitle.Location = new Point(201, 100);
            txttitle.Margin = new Padding(3, 4, 3, 4);
            txttitle.Name = "txttitle";
            txttitle.Size = new Size(335, 27);
            txttitle.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 155);
            label4.Name = "label4";
            label4.Size = new Size(54, 20);
            label4.TabIndex = 3;
            label4.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 103);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 53);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 1;
            label2.Text = "Accession Number";
            // 
            // txtno
            // 
            txtno.Location = new Point(201, 49);
            txtno.Margin = new Padding(3, 4, 3, 4);
            txtno.Name = "txtno";
            txtno.Size = new Size(335, 27);
            txtno.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.GreenYellow;
            btnAdd.Location = new Point(659, 503);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(93, 64);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.Yellow;
            btnEdit.Location = new Point(771, 503);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(93, 64);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "UPDATE";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(255, 128, 128);
            btnDelete.Location = new Point(659, 592);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(93, 64);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnClear
            // 
            btnClear.BackColor = Color.FromArgb(192, 192, 255);
            btnClear.Location = new Point(771, 592);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(93, 64);
            btnClear.TabIndex = 6;
            btnClear.Text = "CLEAR";
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += btnClear_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(txtSearch);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(grid1);
            groupBox2.Location = new Point(39, 87);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(825, 385);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "View Books";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 33);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 4;
            label6.Text = "Book Name:";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(117, 29);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(381, 27);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(520, 33);
            label5.Name = "label5";
            label5.Size = new Size(96, 20);
            label5.TabIndex = 2;
            label5.Text = "Search Book...";
            // 
            // grid1
            // 
            grid1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grid1.Location = new Point(27, 72);
            grid1.Margin = new Padding(3, 4, 3, 4);
            grid1.Name = "grid1";
            grid1.ReadOnly = true;
            grid1.RowHeadersWidth = 51;
            grid1.RowTemplate.Height = 25;
            grid1.Size = new Size(773, 283);
            grid1.TabIndex = 0;
            grid1.CellClick += grid1_CellClick;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.SlateBlue;
            lblWelcome.Location = new Point(275, 23);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(389, 52);
            lblWelcome.TabIndex = 8;
            lblWelcome.Text = "BOOKS SECTION";
            // 
            // Books
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = Properties.Resources.library_background_white_bookshelves_books_textbooks_learning_education_concept_d_illustration_146004771;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(921, 920);
            Controls.Add(lblWelcome);
            Controls.Add(groupBox2);
            Controls.Add(btnClear);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Books";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Books";
            Load += Books_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)grid1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private GroupBox groupBox1;
        private TextBox txtauthor;
        private TextBox txttitle;
        private Label label4;
        private Label label3;
        private Label label2;
        private TextBox txtno;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnClear;
        private GroupBox groupBox2;
        private Label label5;
        private DataGridView grid1;
        private TextBox txtSearch;
        private Label label6;
        private DateTimePicker datepurchased;
        private Label label8;
        private TextBox txtqty;
        private Label label7;
        private TextBox txtprice;
        private Label label;
        private Label lblWelcome;
    }
}