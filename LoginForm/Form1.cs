using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-UOSHB5L;Initial Catalog=LoginFormTest;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblUsername_Click(object sender, EventArgs e)
        {

        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string Password = "";
            bool IsExist = false;
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from tblUserRegistration where UserName='" + txtUsername.Text + "'", conn);
            SqlDataReader sdr = cmd.ExecuteReader();
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
                    main.ShowDialog();
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
            if (txtRegUsername.Text != "" && txtRegPassword.Text != "" && txtRegCPassword.Text != "")  //validating the fields whether the fields or empty or not  
            {
                if (txtRegPassword.Text.ToString().Trim().ToLower() == txtRegCPassword.Text.ToString().Trim().ToLower()) //validating Password textbox and confirm password textbox is match or unmatch    
                {
                    string UserName = txtRegUsername.Text;
                    string Password = Cryptography.Encrypt(txtRegPassword.Text.ToString());   // Passing the Password to Encrypt method and the method will return encrypted string and stored in Password variable.  
                    conn.Open();
                    SqlCommand insert = new SqlCommand("insert into tblUserRegistration(UserName,Password)values('" + UserName + "','" + Password + "')", conn);
                    insert.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record inserted successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            DialogResult res;
            res = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void txtRegPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRegCPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}