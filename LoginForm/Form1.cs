using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
//using System.Data.OleDb;

namespace LoginForm
{
    public partial class LoginForm : Form
    {

        public LoginForm()
        {
            InitializeComponent();
            //conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\\3rd Year\\2nd Sem\\DB SYS 2\\LAB\\LoginForm\\bin\\Debug\\LibSys.mdb");
            //OleDbCommand cmd = new OleDbCommand();
            //OleDbDataAdapter da = new OleDbDataAdapter();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-OQ7MM4J;Initial Catalog=LoginFormTest;Integrated Security=True");


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string Password = "";
            bool IsExist = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblUserRegistration where UserName='" + txtUsername.Text + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
            //OleDbCommand cmd = new OleDbCommand("select * from tblUser where UserName='" + txtUsername.Text + "'", conn);
            //OleDbDataReader sdr = cmd.ExecuteReader();
            if (sdr.Read())
            {
                Password = sdr.GetString(2);  //get the user password from db if the user name is exist in that.  
                IsExist = true;
            }
            conn.Close();
            if (IsExist)  //if record exis in db , it will return true, otherwise it will return false  
            {
                if (Cryptography.Decrypt(Password).Equals(txtPassword.Text))
                {
                    MessageBox.Show("Login Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MenuForm main = new MenuForm();
                    main.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Password is wrong!...", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else  //showing the error message if user credential is wrong  
            {
                MessageBox.Show("Please enter the valid credentials", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //check if username already exists
            SqlCommand cmd = new SqlCommand("select * from tblUserRegistration where username = '" + txtRegUsername.Text + "' ", conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            int i = ds.Tables[0].Rows.Count;
            if (i > 0)
            {
                MessageBox.Show("Username Already Exists.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtRegUsername.Text != "" && txtRegPassword.Text != "" && txtRegCPassword.Text != "")  //validating the fields whether the fields or empty or not  
                {

                    if (txtRegPassword.Text.ToString().Trim().ToLower() == txtRegCPassword.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                    {
                        string UserName = txtRegUsername.Text;
                        string Password = Cryptography.Encrypt(txtRegPassword.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                        conn.Open();
                        SqlCommand insert = new SqlCommand("insert into tblUserRegistration(UserName,Password)values('" + UserName + "','" + Password + "')", conn);
                        //OleDbCommand insert = new OleDbCommand("INSERT INTO tblUser(UserName,Password)values('" + UserName + "','" + Password + "')", conn);
                        insert.ExecuteNonQuery();
                        conn.Close();
                        MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        txtRegUsername.Clear();
                        txtRegPassword.Clear();
                        txtRegCPassword.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Password and Confirm Password doesn't match!.. Please Check..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if password and confirm password doesn't match  
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all the fields!..", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);  //showing the error message if any fields is empty  
                }
            }
        }

        private void btnLoginForm_Click(object sender, EventArgs e)
        {
            panel_Login.BringToFront();
        }

        private void btnRegisterForm_Click(object sender, EventArgs e)
        {
            panel_Register.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtRegUsername.Clear();
            txtRegPassword.Clear();
            txtRegCPassword.Clear();

            //txtUsername.Focus();
        }


        private void btnExitForm_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {

            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnDialogChangePassword_Click(object sender, EventArgs e)
        {
            btnChangePassword2 cp = new btnChangePassword2();
            cp.ShowDialog();
        }
    }
}