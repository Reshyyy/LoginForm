namespace LoginForm
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblWelcome = new Label();
            btnLoginForm = new Button();
            btnRegisterForm = new Button();
            panel_Login = new Panel();
            chkShowPassword = new CheckBox();
            btnLogin = new Button();
            txtPassword = new TextBox();
            txtUsername = new TextBox();
            label1 = new Label();
            lblUsername = new Label();
            btnExitForm = new Button();
            btnClearForm = new Button();
            btnRegister = new Button();
            lblRegUsername = new Label();
            lblRegPassword = new Label();
            txtRegUsername = new TextBox();
            txtRegPassword = new TextBox();
            lblRegCPassword = new Label();
            txtRegCPassword = new TextBox();
            panel_Register = new Panel();
            btnDialogChangePassword = new Button();
            panel_Login.SuspendLayout();
            panel_Register.SuspendLayout();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Lucida Calligraphy", 24F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.SlateBlue;
            lblWelcome.Location = new Point(245, 20);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(212, 52);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            // 
            // btnLoginForm
            // 
            btnLoginForm.BackColor = Color.MediumPurple;
            btnLoginForm.FlatStyle = FlatStyle.Flat;
            btnLoginForm.ForeColor = SystemColors.ControlLightLight;
            btnLoginForm.Location = new Point(37, 95);
            btnLoginForm.Margin = new Padding(3, 4, 3, 4);
            btnLoginForm.Name = "btnLoginForm";
            btnLoginForm.Size = new Size(158, 69);
            btnLoginForm.TabIndex = 8;
            btnLoginForm.Text = "LOGIN";
            btnLoginForm.UseVisualStyleBackColor = false;
            btnLoginForm.Click += btnLoginForm_Click;
            // 
            // btnRegisterForm
            // 
            btnRegisterForm.BackColor = Color.Plum;
            btnRegisterForm.FlatStyle = FlatStyle.Flat;
            btnRegisterForm.ForeColor = Color.WhiteSmoke;
            btnRegisterForm.Location = new Point(201, 95);
            btnRegisterForm.Margin = new Padding(3, 4, 3, 4);
            btnRegisterForm.Name = "btnRegisterForm";
            btnRegisterForm.Size = new Size(158, 69);
            btnRegisterForm.TabIndex = 9;
            btnRegisterForm.Text = "REGISTER";
            btnRegisterForm.UseVisualStyleBackColor = false;
            btnRegisterForm.Click += btnRegisterForm_Click;
            // 
            // panel_Login
            // 
            panel_Login.BackColor = Color.Tan;
            panel_Login.Controls.Add(chkShowPassword);
            panel_Login.Controls.Add(btnLogin);
            panel_Login.Controls.Add(txtPassword);
            panel_Login.Controls.Add(txtUsername);
            panel_Login.Controls.Add(label1);
            panel_Login.Controls.Add(lblUsername);
            panel_Login.Location = new Point(35, 168);
            panel_Login.Margin = new Padding(3, 4, 3, 4);
            panel_Login.Name = "panel_Login";
            panel_Login.Size = new Size(584, 324);
            panel_Login.TabIndex = 10;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(483, 116);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(67, 24);
            chkShowPassword.TabIndex = 14;
            chkShowPassword.Text = "Show";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(285, 163);
            btnLogin.Margin = new Padding(3, 4, 3, 4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(96, 51);
            btnLogin.TabIndex = 13;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click_1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(226, 112);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(249, 27);
            txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(226, 61);
            txtUsername.Margin = new Padding(3, 4, 3, 4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(249, 27);
            txtUsername.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 115);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 9;
            label1.Text = "Password";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(145, 67);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(75, 20);
            lblUsername.TabIndex = 8;
            lblUsername.Text = "Username";
            // 
            // btnExitForm
            // 
            btnExitForm.BackColor = Color.IndianRed;
            btnExitForm.ForeColor = Color.White;
            btnExitForm.Location = new Point(523, 113);
            btnExitForm.Margin = new Padding(3, 4, 3, 4);
            btnExitForm.Name = "btnExitForm";
            btnExitForm.Size = new Size(96, 51);
            btnExitForm.TabIndex = 14;
            btnExitForm.Text = "Exit";
            btnExitForm.UseVisualStyleBackColor = false;
            btnExitForm.Click += btnExitForm_Click;
            // 
            // btnClearForm
            // 
            btnClearForm.BackColor = Color.LightBlue;
            btnClearForm.ForeColor = Color.MidnightBlue;
            btnClearForm.Location = new Point(421, 113);
            btnClearForm.Margin = new Padding(3, 4, 3, 4);
            btnClearForm.Name = "btnClearForm";
            btnClearForm.Size = new Size(96, 51);
            btnClearForm.TabIndex = 12;
            btnClearForm.Text = "Clear";
            btnClearForm.UseVisualStyleBackColor = false;
            btnClearForm.Click += button3_Click;
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(285, 223);
            btnRegister.Margin = new Padding(3, 4, 3, 4);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(96, 51);
            btnRegister.TabIndex = 13;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = true;
            btnRegister.Click += btnRegister_Click;
            // 
            // lblRegUsername
            // 
            lblRegUsername.AutoSize = true;
            lblRegUsername.Location = new Point(147, 67);
            lblRegUsername.Name = "lblRegUsername";
            lblRegUsername.Size = new Size(75, 20);
            lblRegUsername.TabIndex = 15;
            lblRegUsername.Text = "Username";
            // 
            // lblRegPassword
            // 
            lblRegPassword.AutoSize = true;
            lblRegPassword.Location = new Point(149, 116);
            lblRegPassword.Name = "lblRegPassword";
            lblRegPassword.Size = new Size(70, 20);
            lblRegPassword.TabIndex = 16;
            lblRegPassword.Text = "Password";
            // 
            // txtRegUsername
            // 
            txtRegUsername.Location = new Point(226, 61);
            txtRegUsername.Margin = new Padding(3, 4, 3, 4);
            txtRegUsername.Name = "txtRegUsername";
            txtRegUsername.Size = new Size(249, 27);
            txtRegUsername.TabIndex = 17;
            // 
            // txtRegPassword
            // 
            txtRegPassword.Location = new Point(226, 111);
            txtRegPassword.Margin = new Padding(3, 4, 3, 4);
            txtRegPassword.Name = "txtRegPassword";
            txtRegPassword.PasswordChar = '*';
            txtRegPassword.Size = new Size(249, 27);
            txtRegPassword.TabIndex = 18;
            // 
            // lblRegCPassword
            // 
            lblRegCPassword.AutoSize = true;
            lblRegCPassword.Location = new Point(97, 169);
            lblRegCPassword.Name = "lblRegCPassword";
            lblRegCPassword.Size = new Size(127, 20);
            lblRegCPassword.TabIndex = 19;
            lblRegCPassword.Text = "Confirm Password";
            // 
            // txtRegCPassword
            // 
            txtRegCPassword.Location = new Point(226, 165);
            txtRegCPassword.Margin = new Padding(3, 4, 3, 4);
            txtRegCPassword.Name = "txtRegCPassword";
            txtRegCPassword.PasswordChar = '*';
            txtRegCPassword.Size = new Size(249, 27);
            txtRegCPassword.TabIndex = 20;
            // 
            // panel_Register
            // 
            panel_Register.BackColor = Color.Tan;
            panel_Register.Controls.Add(txtRegCPassword);
            panel_Register.Controls.Add(lblRegCPassword);
            panel_Register.Controls.Add(txtRegPassword);
            panel_Register.Controls.Add(txtRegUsername);
            panel_Register.Controls.Add(lblRegPassword);
            panel_Register.Controls.Add(lblRegUsername);
            panel_Register.Controls.Add(btnRegister);
            panel_Register.Location = new Point(35, 168);
            panel_Register.Margin = new Padding(3, 4, 3, 4);
            panel_Register.Name = "panel_Register";
            panel_Register.Size = new Size(584, 324);
            panel_Register.TabIndex = 11;
            // 
            // btnDialogChangePassword
            // 
            btnDialogChangePassword.Location = new Point(421, 67);
            btnDialogChangePassword.Name = "btnDialogChangePassword";
            btnDialogChangePassword.Size = new Size(198, 37);
            btnDialogChangePassword.TabIndex = 15;
            btnDialogChangePassword.Text = "Change Password";
            btnDialogChangePassword.UseVisualStyleBackColor = true;
            btnDialogChangePassword.Click += btnDialogChangePassword_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.lain_kobeni_bg;
            ClientSize = new Size(664, 540);
            Controls.Add(btnDialogChangePassword);
            Controls.Add(panel_Login);
            Controls.Add(panel_Register);
            Controls.Add(btnRegisterForm);
            Controls.Add(btnLoginForm);
            Controls.Add(lblWelcome);
            Controls.Add(btnClearForm);
            Controls.Add(btnExitForm);
            Margin = new Padding(3, 4, 3, 4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            panel_Login.ResumeLayout(false);
            panel_Login.PerformLayout();
            panel_Register.ResumeLayout(false);
            panel_Register.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private Button btnLoginForm;
        private Button btnRegisterForm;
        private Panel panel_Login;
        private Button btnLogin;
        private TextBox txtPassword;
        private TextBox txtUsername;
        private Label label1;
        private Label lblUsername;
        private Button btnExitForm;
        private Button btnClearForm;
        private Panel panel_Register;
        private TextBox txtRegCPassword;
        private Label lblRegCPassword;
        private TextBox txtRegPassword;
        private TextBox txtRegUsername;
        private Label lblRegPassword;
        private Label lblRegUsername;
        private Button btnRegister;
        private CheckBox chkShowPassword;
        private Button btnDialogChangePassword;
    }
}