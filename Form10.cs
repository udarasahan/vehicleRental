using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        
        SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DriveJoy;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void Form10_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string userName = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            if (txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please enter a username & password.", "Sign IN Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtPassword.Text == txtConfirmPassword.Text)
            {
                conn.Open();
                string register = "INSERT INTO userTable VALUES ('" + txtUsername.Text + "','" + txtPassword.Text + "')";
                cmd = new SqlCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                txtUsername.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created!", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoginForm objLogin = new LoginForm();
                this.Close();
                objLogin.Show();
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please Re-enter","Registration Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirmPassword.PasswordChar = '\0';
            } 
            else
            {
                txtPassword.PasswordChar = '*';
                txtConfirmPassword.PasswordChar = '*';
            }
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e) // Already Have an Account
        {
            LoginForm objLogin = new LoginForm();
            this.Close();
            objLogin.Show();
        }
    }
}
