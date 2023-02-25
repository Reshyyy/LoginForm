namespace LoginForm
{
    partial class Form1
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLoginForm = new System.Windows.Forms.Button();
            this.btnRegisterForm = new System.Windows.Forms.Button();
            this.panel_Login = new System.Windows.Forms.Panel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.btnExitForm = new System.Windows.Forms.Button();
            this.btnClearForm = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.lblRegUsername = new System.Windows.Forms.Label();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.txtRegUsername = new System.Windows.Forms.TextBox();
            this.txtRegPassword = new System.Windows.Forms.TextBox();
            this.lblRegCPassword = new System.Windows.Forms.Label();
            this.txtRegCPassword = new System.Windows.Forms.TextBox();
            this.panel_Register = new System.Windows.Forms.Panel();
            this.panel_Login.SuspendLayout();
            this.panel_Register.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWelcome.ForeColor = System.Drawing.Color.SlateBlue;
            this.lblWelcome.Location = new System.Drawing.Point(214, 15);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(169, 41);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome";
            // 
            // btnLoginForm
            // 
            this.btnLoginForm.BackColor = System.Drawing.Color.MediumPurple;
            this.btnLoginForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoginForm.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLoginForm.Location = new System.Drawing.Point(32, 71);
            this.btnLoginForm.Name = "btnLoginForm";
            this.btnLoginForm.Size = new System.Drawing.Size(138, 52);
            this.btnLoginForm.TabIndex = 8;
            this.btnLoginForm.Text = "LOGIN";
            this.btnLoginForm.UseVisualStyleBackColor = false;
            this.btnLoginForm.Click += new System.EventHandler(this.btnLoginForm_Click);
            // 
            // btnRegisterForm
            // 
            this.btnRegisterForm.BackColor = System.Drawing.Color.Plum;
            this.btnRegisterForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterForm.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterForm.Location = new System.Drawing.Point(176, 71);
            this.btnRegisterForm.Name = "btnRegisterForm";
            this.btnRegisterForm.Size = new System.Drawing.Size(138, 52);
            this.btnRegisterForm.TabIndex = 9;
            this.btnRegisterForm.Text = "REGISTER";
            this.btnRegisterForm.UseVisualStyleBackColor = false;
            this.btnRegisterForm.Click += new System.EventHandler(this.btnRegisterForm_Click);
            // 
            // panel_Login
            // 
            this.panel_Login.BackColor = System.Drawing.Color.Tan;
            this.panel_Login.Controls.Add(this.btnLogin);
            this.panel_Login.Controls.Add(this.txtPassword);
            this.panel_Login.Controls.Add(this.txtUsername);
            this.panel_Login.Controls.Add(this.label1);
            this.panel_Login.Controls.Add(this.lblUsername);
            this.panel_Login.Location = new System.Drawing.Point(31, 126);
            this.panel_Login.Name = "panel_Login";
            this.panel_Login.Size = new System.Drawing.Size(511, 243);
            this.panel_Login.TabIndex = 10;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(249, 122);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(84, 38);
            this.btnLogin.TabIndex = 13;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click_1);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(198, 84);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(218, 23);
            this.txtPassword.TabIndex = 11;
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(198, 46);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(218, 23);
            this.txtUsername.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Location = new System.Drawing.Point(127, 50);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(60, 15);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username";
            // 
            // btnExitForm
            // 
            this.btnExitForm.BackColor = System.Drawing.Color.IndianRed;
            this.btnExitForm.ForeColor = System.Drawing.Color.White;
            this.btnExitForm.Location = new System.Drawing.Point(458, 85);
            this.btnExitForm.Name = "btnExitForm";
            this.btnExitForm.Size = new System.Drawing.Size(84, 38);
            this.btnExitForm.TabIndex = 14;
            this.btnExitForm.Text = "Exit";
            this.btnExitForm.UseVisualStyleBackColor = false;
            this.btnExitForm.Click += new System.EventHandler(this.btnExitForm_Click);
            // 
            // btnClearForm
            // 
            this.btnClearForm.BackColor = System.Drawing.Color.LightBlue;
            this.btnClearForm.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnClearForm.Location = new System.Drawing.Point(368, 85);
            this.btnClearForm.Name = "btnClearForm";
            this.btnClearForm.Size = new System.Drawing.Size(84, 38);
            this.btnClearForm.TabIndex = 12;
            this.btnClearForm.Text = "Clear";
            this.btnClearForm.UseVisualStyleBackColor = false;
            this.btnClearForm.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(249, 167);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(84, 38);
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblRegUsername
            // 
            this.lblRegUsername.AutoSize = true;
            this.lblRegUsername.Location = new System.Drawing.Point(129, 50);
            this.lblRegUsername.Name = "lblRegUsername";
            this.lblRegUsername.Size = new System.Drawing.Size(60, 15);
            this.lblRegUsername.TabIndex = 15;
            this.lblRegUsername.Text = "Username";
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Location = new System.Drawing.Point(130, 87);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(57, 15);
            this.lblRegPassword.TabIndex = 16;
            this.lblRegPassword.Text = "Password";
            // 
            // txtRegUsername
            // 
            this.txtRegUsername.Location = new System.Drawing.Point(198, 46);
            this.txtRegUsername.Name = "txtRegUsername";
            this.txtRegUsername.Size = new System.Drawing.Size(218, 23);
            this.txtRegUsername.TabIndex = 17;
            // 
            // txtRegPassword
            // 
            this.txtRegPassword.Location = new System.Drawing.Point(198, 83);
            this.txtRegPassword.Name = "txtRegPassword";
            this.txtRegPassword.Size = new System.Drawing.Size(218, 23);
            this.txtRegPassword.TabIndex = 18;
            this.txtRegPassword.TextChanged += new System.EventHandler(this.txtRegPassword_TextChanged);
            // 
            // lblRegCPassword
            // 
            this.lblRegCPassword.AutoSize = true;
            this.lblRegCPassword.Location = new System.Drawing.Point(85, 127);
            this.lblRegCPassword.Name = "lblRegCPassword";
            this.lblRegCPassword.Size = new System.Drawing.Size(104, 15);
            this.lblRegCPassword.TabIndex = 19;
            this.lblRegCPassword.Text = "Confirm Password";
            // 
            // txtRegCPassword
            // 
            this.txtRegCPassword.Location = new System.Drawing.Point(198, 124);
            this.txtRegCPassword.Name = "txtRegCPassword";
            this.txtRegCPassword.Size = new System.Drawing.Size(218, 23);
            this.txtRegCPassword.TabIndex = 20;
            this.txtRegCPassword.TextChanged += new System.EventHandler(this.txtRegCPassword_TextChanged);
            // 
            // panel_Register
            // 
            this.panel_Register.BackColor = System.Drawing.Color.Tan;
            this.panel_Register.Controls.Add(this.txtRegCPassword);
            this.panel_Register.Controls.Add(this.lblRegCPassword);
            this.panel_Register.Controls.Add(this.txtRegPassword);
            this.panel_Register.Controls.Add(this.txtRegUsername);
            this.panel_Register.Controls.Add(this.lblRegPassword);
            this.panel_Register.Controls.Add(this.lblRegUsername);
            this.panel_Register.Controls.Add(this.btnRegister);
            this.panel_Register.Location = new System.Drawing.Point(31, 126);
            this.panel_Register.Name = "panel_Register";
            this.panel_Register.Size = new System.Drawing.Size(511, 243);
            this.panel_Register.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LoginForm.Properties.Resources.lain_kobeni_bg;
            this.ClientSize = new System.Drawing.Size(581, 405);
            this.Controls.Add(this.panel_Register);
            this.Controls.Add(this.panel_Login);
            this.Controls.Add(this.btnRegisterForm);
            this.Controls.Add(this.btnLoginForm);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.btnClearForm);
            this.Controls.Add(this.btnExitForm);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel_Login.ResumeLayout(false);
            this.panel_Login.PerformLayout();
            this.panel_Register.ResumeLayout(false);
            this.panel_Register.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}