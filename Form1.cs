using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e) // Login Button
        {
            string userName = txtuserName.Text;
            string passWord = txtPassword.Text;

           

            if (userName == "Admin123" && passWord == "User123") 
            {
                Form2 homePage = new Form2();
                this.Hide();
                homePage.Show();

                
            }
            else if (userName != "Admin123" || passWord != "User123")
            {
                txtuserName.Clear();
                txtPassword.Clear();
                MessageBox.Show("User Name and Password is not Matched.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void servicesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e) // About Us
        {
            Form7 aboutUS = new Form7();
            aboutUS.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog using MessageBox.
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response.
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void button1_Click_1(object sender, EventArgs e) // Create an account button
        {
            
        }
    }
}
