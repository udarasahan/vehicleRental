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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (LoginForm.userName == "Admin123" && LoginForm.passWord == "User123")
            {
                button1.Visible = true;
            } 
            else if (LoginForm.userName != "Admin123" && LoginForm.passWord != "User123")
            {
                button1.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e) // Passenger Car link
        {
            Form3 passengerCar = new Form3();
            passengerCar.Show();

            this.Hide();
        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e) // 4x4 SUV link
        {
            Form6 suvVehicle = new Form6();
            suvVehicle.Show();

            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e) //Van link
        {
            Form4 van = new Form4();
            van.Show();

            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e) // Electric vehicle link
        {
            Form5 electric = new Form5();
            electric.Show();

            this.Hide();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e) //About us
        {
            Form7 aboutUS = new Form7();
            aboutUS.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e) //Log Out
        {
            // Display a confirmation dialog using MessageBox.
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response.
            if (result == DialogResult.Yes)
            {
               
                LoginForm loginForm = new LoginForm();
                this.Close();
                loginForm.Show();

                
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e) // Exit
        {
            // Display a confirmation dialog using MessageBox.
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response.
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e) // Admin Only
        {
            AdminOnly admin = new AdminOnly();
            this.Close();
            admin.Show();
        }
    }
}
