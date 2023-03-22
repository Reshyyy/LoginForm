namespace LoginForm
{
    partial class MenuForm
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
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            booksToolStripMenuItem = new ToolStripMenuItem();
            borrowerToolStripMenuItem = new ToolStripMenuItem();
            transactionToolStripMenuItem = new ToolStripMenuItem();
            borrowToolStripMenuItem = new ToolStripMenuItem();
            returnToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem();
            logoutToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            btnBooks = new Button();
            label2 = new Label();
            btnBorrower = new Button();
            label3 = new Label();
            btnBorrowed = new Button();
            btnReturned = new Button();
            label4 = new Label();
            label5 = new Label();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, transactionToolStripMenuItem, reportToolStripMenuItem, logoutToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(645, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { booksToolStripMenuItem, borrowerToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(46, 24);
            fileToolStripMenuItem.Text = "File";
            // 
            // booksToolStripMenuItem
            // 
            booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            booksToolStripMenuItem.Size = new Size(153, 26);
            booksToolStripMenuItem.Text = "Books";
            booksToolStripMenuItem.Click += booksToolStripMenuItem_Click;
            // 
            // borrowerToolStripMenuItem
            // 
            borrowerToolStripMenuItem.Name = "borrowerToolStripMenuItem";
            borrowerToolStripMenuItem.Size = new Size(153, 26);
            borrowerToolStripMenuItem.Text = "Borrower";
            borrowerToolStripMenuItem.Click += borrowerToolStripMenuItem_Click;
            // 
            // transactionToolStripMenuItem
            // 
            transactionToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { borrowToolStripMenuItem, returnToolStripMenuItem });
            transactionToolStripMenuItem.Name = "transactionToolStripMenuItem";
            transactionToolStripMenuItem.Size = new Size(98, 24);
            transactionToolStripMenuItem.Text = "Transaction";
            transactionToolStripMenuItem.Click += transactionToolStripMenuItem_Click;
            // 
            // borrowToolStripMenuItem
            // 
            borrowToolStripMenuItem.Name = "borrowToolStripMenuItem";
            borrowToolStripMenuItem.Size = new Size(140, 26);
            borrowToolStripMenuItem.Text = "Borrow";
            borrowToolStripMenuItem.Click += borrowToolStripMenuItem_Click;
            // 
            // returnToolStripMenuItem
            // 
            returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            returnToolStripMenuItem.Size = new Size(140, 26);
            returnToolStripMenuItem.Text = "Return";
            returnToolStripMenuItem.Click += returnToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(74, 24);
            reportToolStripMenuItem.Text = "Reports";
            reportToolStripMenuItem.Click += reportToolStripMenuItem_Click;
            // 
            // logoutToolStripMenuItem
            // 
            logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            logoutToolStripMenuItem.Size = new Size(70, 24);
            logoutToolStripMenuItem.Text = "Logout";
            logoutToolStripMenuItem.Click += logoutToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Courier New", 24F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(153, 57);
            label1.Name = "label1";
            label1.Size = new Size(356, 46);
            label1.TabIndex = 1;
            label1.Text = "Library System";
            // 
            // btnBooks
            // 
            btnBooks.BackgroundImage = Properties.Resources.book_img;
            btnBooks.BackgroundImageLayout = ImageLayout.Zoom;
            btnBooks.Location = new Point(184, 125);
            btnBooks.Margin = new Padding(3, 4, 3, 4);
            btnBooks.Name = "btnBooks";
            btnBooks.Size = new Size(118, 105);
            btnBooks.TabIndex = 14;
            btnBooks.UseVisualStyleBackColor = true;
            btnBooks.Click += btnBooks_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(223, 245);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 15;
            label2.Text = "Books";
            // 
            // btnBorrower
            // 
            btnBorrower.BackgroundImage = Properties.Resources.student;
            btnBorrower.BackgroundImageLayout = ImageLayout.Zoom;
            btnBorrower.Location = new Point(354, 125);
            btnBorrower.Margin = new Padding(3, 4, 3, 4);
            btnBorrower.Name = "btnBorrower";
            btnBorrower.Size = new Size(118, 105);
            btnBorrower.TabIndex = 16;
            btnBorrower.UseVisualStyleBackColor = true;
            btnBorrower.Click += btnBorrower_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(382, 245);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 17;
            label3.Text = "Borrower";
            // 
            // btnBorrowed
            // 
            btnBorrowed.BackgroundImage = Properties.Resources.borrower;
            btnBorrowed.BackgroundImageLayout = ImageLayout.Stretch;
            btnBorrowed.Location = new Point(184, 291);
            btnBorrowed.Margin = new Padding(3, 4, 3, 4);
            btnBorrowed.Name = "btnBorrowed";
            btnBorrowed.Size = new Size(118, 105);
            btnBorrowed.TabIndex = 18;
            btnBorrowed.UseVisualStyleBackColor = true;
            btnBorrowed.Click += btnBorrowed_Click;
            // 
            // btnReturned
            // 
            btnReturned.BackgroundImage = Properties.Resources.returned;
            btnReturned.BackgroundImageLayout = ImageLayout.Stretch;
            btnReturned.Location = new Point(354, 291);
            btnReturned.Margin = new Padding(3, 4, 3, 4);
            btnReturned.Name = "btnReturned";
            btnReturned.Size = new Size(118, 105);
            btnReturned.TabIndex = 19;
            btnReturned.UseVisualStyleBackColor = true;
            btnReturned.Click += btnReturned_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(214, 411);
            label4.Name = "label4";
            label4.Size = new Size(57, 20);
            label4.TabIndex = 20;
            label4.Text = "Borrow";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(390, 411);
            label5.Name = "label5";
            label5.Size = new Size(52, 20);
            label5.TabIndex = 21;
            label5.Text = "Return";
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(645, 488);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnReturned);
            Controls.Add(btnBorrowed);
            Controls.Add(label3);
            Controls.Add(btnBorrower);
            Controls.Add(label2);
            Controls.Add(btnBooks);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MenuForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MenuForm";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem booksToolStripMenuItem;
        private ToolStripMenuItem borrowerToolStripMenuItem;
        private ToolStripMenuItem transactionToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem;
        private ToolStripMenuItem logoutToolStripMenuItem;
        private Label label1;
        private Button btnBooks;
        private Label label2;
        private Button btnBorrower;
        private Label label3;
        private Button btnBorrowed;
        private Button btnReturned;
        private Label label4;
        private Label label5;
        private ToolStripMenuItem borrowToolStripMenuItem;
        private ToolStripMenuItem returnToolStripMenuItem;
    }
}