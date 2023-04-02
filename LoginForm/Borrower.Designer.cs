namespace LoginForm
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
            groupBox2 = new GroupBox();
            btnSave = new Button();
            btnclearb = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            label6 = new Label();
            label7 = new Label();
            txtdepartment = new TextBox();
            txtemail = new TextBox();
            txtcontact = new TextBox();
            txtidnumber = new TextBox();
            txtname = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            label5 = new Label();
            txtsearchid = new TextBox();
            gridviewborrower = new DataGridView();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewborrower).BeginInit();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSave);
            groupBox2.Controls.Add(btnclearb);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnUpdate);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(txtdepartment);
            groupBox2.Controls.Add(txtemail);
            groupBox2.Controls.Add(txtcontact);
            groupBox2.Controls.Add(txtidnumber);
            groupBox2.Controls.Add(txtname);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Location = new Point(54, 512);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(898, 284);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "Borrower Details..";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(475, 176);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(91, 56);
            btnSave.TabIndex = 19;
            btnSave.Text = "Add";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnclearb
            // 
            btnclearb.Location = new Point(781, 176);
            btnclearb.Margin = new Padding(3, 4, 3, 4);
            btnclearb.Name = "btnclearb";
            btnclearb.Size = new Size(87, 55);
            btnclearb.TabIndex = 18;
            btnclearb.Text = "Clear";
            btnclearb.UseVisualStyleBackColor = true;
            btnclearb.Click += btnclearb_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(680, 176);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(87, 55);
            btnDelete.TabIndex = 18;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(581, 176);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(87, 55);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(469, 109);
            label6.Name = "label6";
            label6.Size = new Size(58, 25);
            label6.TabIndex = 17;
            label6.Text = "Email";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(467, 63);
            label7.Name = "label7";
            label7.Size = new Size(111, 25);
            label7.TabIndex = 16;
            label7.Text = "Contact No.";
            // 
            // txtdepartment
            // 
            txtdepartment.Location = new Point(171, 159);
            txtdepartment.Margin = new Padding(3, 4, 3, 4);
            txtdepartment.Name = "txtdepartment";
            txtdepartment.Size = new Size(241, 27);
            txtdepartment.TabIndex = 15;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(581, 111);
            txtemail.Margin = new Padding(3, 4, 3, 4);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(241, 27);
            txtemail.TabIndex = 14;
            // 
            // txtcontact
            // 
            txtcontact.Location = new Point(581, 63);
            txtcontact.Margin = new Padding(3, 4, 3, 4);
            txtcontact.MaxLength = 11;
            txtcontact.Name = "txtcontact";
            txtcontact.Size = new Size(241, 27);
            txtcontact.TabIndex = 13;
            // 
            // txtidnumber
            // 
            txtidnumber.Location = new Point(171, 111);
            txtidnumber.Margin = new Padding(3, 4, 3, 4);
            txtidnumber.Name = "txtidnumber";
            txtidnumber.Size = new Size(241, 27);
            txtidnumber.TabIndex = 14;
            // 
            // txtname
            // 
            txtname.Location = new Point(171, 61);
            txtname.Margin = new Padding(3, 4, 3, 4);
            txtname.Name = "txtname";
            txtname.Size = new Size(241, 27);
            txtname.TabIndex = 13;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(32, 159);
            label4.Name = "label4";
            label4.Size = new Size(112, 25);
            label4.TabIndex = 12;
            label4.Text = "Department";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(32, 112);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 11;
            label3.Text = "ID NUMBER";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(31, 61);
            label2.Name = "label2";
            label2.Size = new Size(131, 25);
            label2.TabIndex = 10;
            label2.Text = "Student Name";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtsearchid);
            groupBox1.Controls.Add(gridviewborrower);
            groupBox1.Location = new Point(54, 59);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(898, 403);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "View";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(553, 29);
            btnClear.Margin = new Padding(3, 4, 3, 4);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(86, 31);
            btnClear.TabIndex = 3;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(209, 33);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 2;
            label5.Text = "ID NUMBER";
            // 
            // txtsearchid
            // 
            txtsearchid.Location = new Point(306, 29);
            txtsearchid.Margin = new Padding(3, 4, 3, 4);
            txtsearchid.Name = "txtsearchid";
            txtsearchid.Size = new Size(227, 27);
            txtsearchid.TabIndex = 1;
            txtsearchid.TextChanged += txtsearchid_TextChanged;
            // 
            // gridviewborrower
            // 
            gridviewborrower.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridviewborrower.Location = new Point(21, 73);
            gridviewborrower.Margin = new Padding(3, 4, 3, 4);
            gridviewborrower.Name = "gridviewborrower";
            gridviewborrower.ReadOnly = true;
            gridviewborrower.RowHeadersWidth = 51;
            gridviewborrower.RowTemplate.Height = 25;
            gridviewborrower.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridviewborrower.Size = new Size(851, 292);
            gridviewborrower.TabIndex = 0;
            gridviewborrower.CellClick += gridviewborrower_CellClick;
            // 
            // Borrower
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.istockphoto_1390650788_612x612;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1005, 873);
            Controls.Add(groupBox1);
            Controls.Add(groupBox2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Borrower";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Borrower";
            Load += Borrower_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)gridviewborrower).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox2;
        private Button btnclearb;
        private Button btnDelete;
        private Button btnUpdate;
        private Label label6;
        private Label label7;
        private TextBox txtdepartment;
        private TextBox txtemail;
        private TextBox txtcontact;
        private TextBox txtidnumber;
        private TextBox txtname;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnSave;
        private GroupBox groupBox1;
        private Button btnClear;
        private Label label5;
        private TextBox txtsearchid;
        private DataGridView gridviewborrower;
    }
}