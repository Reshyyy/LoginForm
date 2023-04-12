namespace LoginForm
{
    partial class btnChangePassword2
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
            label1 = new Label();
            label2 = new Label();
            txtUser = new TextBox();
            txtOldPassword = new TextBox();
            label3 = new Label();
            txtNewPassword = new TextBox();
            label4 = new Label();
            txtConfirmNewPassword = new TextBox();
            label5 = new Label();
            btnChangePassword = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(112, 41);
            label1.Name = "label1";
            label1.Size = new Size(264, 41);
            label1.TabIndex = 0;
            label1.Text = "Change Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 137);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 1;
            label2.Text = "Username";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(223, 137);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(194, 27);
            txtUser.TabIndex = 2;
            // 
            // txtOldPassword
            // 
            txtOldPassword.Location = new Point(223, 189);
            txtOldPassword.Name = "txtOldPassword";
            txtOldPassword.Size = new Size(194, 27);
            txtOldPassword.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 189);
            label3.Name = "label3";
            label3.Size = new Size(98, 20);
            label3.TabIndex = 3;
            label3.Text = "Old Password";
            // 
            // txtNewPassword
            // 
            txtNewPassword.Location = new Point(223, 242);
            txtNewPassword.Name = "txtNewPassword";
            txtNewPassword.Size = new Size(194, 27);
            txtNewPassword.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 242);
            label4.Name = "label4";
            label4.Size = new Size(104, 20);
            label4.TabIndex = 5;
            label4.Text = "New Password";
            // 
            // txtConfirmNewPassword
            // 
            txtConfirmNewPassword.Location = new Point(223, 288);
            txtConfirmNewPassword.Name = "txtConfirmNewPassword";
            txtConfirmNewPassword.Size = new Size(194, 27);
            txtConfirmNewPassword.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(56, 288);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 7;
            label5.Text = "Confirm New Password";
            // 
            // btnChangePassword
            // 
            btnChangePassword.Location = new Point(169, 359);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(156, 57);
            btnChangePassword.TabIndex = 9;
            btnChangePassword.Text = "Change Password";
            btnChangePassword.UseVisualStyleBackColor = true;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // btnChangePassword2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 491);
            Controls.Add(btnChangePassword);
            Controls.Add(txtConfirmNewPassword);
            Controls.Add(label5);
            Controls.Add(txtNewPassword);
            Controls.Add(label4);
            Controls.Add(txtOldPassword);
            Controls.Add(label3);
            Controls.Add(txtUser);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "btnChangePassword2";
            Text = "ChangePassword";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtUser;
        private TextBox txtOldPassword;
        private Label label3;
        private TextBox txtNewPassword;
        private Label label4;
        private TextBox txtConfirmNewPassword;
        private Label label5;
        private Button btnChangePassword;
    }
}