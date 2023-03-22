namespace LoginForm
{
    partial class Reports
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
            dg_reports1 = new DataGridView();
            groupBox2 = new GroupBox();
            dg_reports2 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            groupBox3 = new GroupBox();
            btnFilter = new Button();
            dateTimePicker2 = new DateTimePicker();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_reports1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dg_reports2).BeginInit();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dg_reports1);
            groupBox1.Location = new Point(45, 72);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(1113, 376);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Borrowed Books";
            // 
            // dg_reports1
            // 
            dg_reports1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_reports1.Location = new Point(19, 29);
            dg_reports1.Margin = new Padding(3, 4, 3, 4);
            dg_reports1.Name = "dg_reports1";
            dg_reports1.ReadOnly = true;
            dg_reports1.RowHeadersWidth = 51;
            dg_reports1.RowTemplate.Height = 25;
            dg_reports1.Size = new Size(1073, 324);
            dg_reports1.TabIndex = 0;
            dg_reports1.CellContentClick += dg_reports1_CellContentClick;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dg_reports2);
            groupBox2.Location = new Point(45, 475);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(1113, 376);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Returned Books";
            // 
            // dg_reports2
            // 
            dg_reports2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dg_reports2.Location = new Point(22, 35);
            dg_reports2.Margin = new Padding(3, 4, 3, 4);
            dg_reports2.Name = "dg_reports2";
            dg_reports2.RowHeadersWidth = 51;
            dg_reports2.RowTemplate.Height = 25;
            dg_reports2.Size = new Size(1071, 315);
            dg_reports2.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(550, 35);
            label1.Name = "label1";
            label1.Size = new Size(119, 32);
            label1.TabIndex = 2;
            label1.Text = "REPORTS";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(1258, 35);
            label2.Name = "label2";
            label2.Size = new Size(132, 32);
            label2.TabIndex = 3;
            label2.Text = "Filter Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(117, 25);
            label3.Name = "label3";
            label3.Size = new Size(43, 20);
            label3.TabIndex = 4;
            label3.Text = "From";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(125, 128);
            label4.Name = "label4";
            label4.Size = new Size(25, 20);
            label4.TabIndex = 4;
            label4.Text = "To";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(21, 63);
            dateTimePicker1.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(228, 27);
            dateTimePicker1.TabIndex = 5;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnFilter);
            groupBox3.Controls.Add(dateTimePicker2);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(dateTimePicker1);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(1185, 87);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(267, 339);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            // 
            // btnFilter
            // 
            btnFilter.Location = new Point(21, 231);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(229, 71);
            btnFilter.TabIndex = 7;
            btnFilter.Text = "FILTER";
            btnFilter.UseVisualStyleBackColor = true;
            btnFilter.Click += btnFilter_Click;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.CustomFormat = "yyyy-MM-dd";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.Location = new Point(21, 167);
            dateTimePicker2.Margin = new Padding(3, 4, 3, 4);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(228, 27);
            dateTimePicker2.TabIndex = 6;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1483, 919);
            Controls.Add(label2);
            Controls.Add(groupBox3);
            Controls.Add(label1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Reports";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Reports";
            Load += Reports_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_reports1).EndInit();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dg_reports2).EndInit();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dg_reports1;
        private GroupBox groupBox2;
        private DataGridView dg_reports2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private GroupBox groupBox3;
        private Button btnFilter;
        private DateTimePicker dateTimePicker2;
    }
}