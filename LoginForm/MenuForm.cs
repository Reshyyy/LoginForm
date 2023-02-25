﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
        }

        private void borrowerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrower borrower = new Borrower();
            borrower.ShowDialog();
        }

        private void borrowedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Borrowed borrowed = new Borrowed();
            borrowed.ShowDialog();
        }

        private void returnedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Returned returned = new Returned();
            returned.ShowDialog();
        }
    }
}
