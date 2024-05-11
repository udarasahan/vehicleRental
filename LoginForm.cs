using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DriveJoy;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Menu Strip Exit
        {
            // Display a confirmation dialog using MessageBox.
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response.
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }


        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 aboutUS = new Form7();
            aboutUS.Show();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        public static string userName = "";
        public static string passWord = "";

        private void btnLogin_Click(object sender, EventArgs e) // Login Button
        {
            conn.Open();
            string logIn = "SELECT * FROM userTable WHERE username = '" + txtuserName.Text + "' and password = '" +txtPassword.Text + "'";
            cmd = new SqlCommand(logIn,conn);
            SqlDataReader reader = cmd.ExecuteReader();

            if (txtuserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("Please Enter the Username & Password.\n Or\nDon't have an account? Let's Create an Account.", "Login Failed!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (reader.Read() == true)
            {
                userName = txtuserName.Text;
                passWord = txtPassword.Text;

                Form2 objForm2 = new Form2();
                this.Hide();
                objForm2.Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again.\n Or\nDon't have an account? Let's Create an Account.", "Login Failed!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                txtuserName.Clear();
                txtPassword.Clear();
                txtuserName.Focus();
            }
            conn.Close();
        }
        

        private void checkBox1_CheckedChanged(object sender, EventArgs e) // Show Password Icon
        {
            if (checkBox1.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void button1_Click(object sender, EventArgs e) // Acreate an Account
        {
            Form10 objForm10 = new Form10();
            txtuserName.Clear();
            txtPassword.Clear();
            this.Hide();
            objForm10.Show();
        }
    }
}
