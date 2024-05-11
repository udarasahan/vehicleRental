using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace GroupProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void passengerCarToolStripMenuItem_Click(object sender, EventArgs e) //To 4x4 page
        {
            Form6 suv = new Form6();
            this.Close();
            suv.Show();
        }

        private void backToHomePageToolStripMenuItem_Click(object sender, EventArgs e) // Back To Home Page
        {
            Form2 homePage = new Form2();
            this.Close();
            homePage.Show();
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

        private void vansToolStripMenuItem_Click(object sender, EventArgs e) // To vans
        {
            Form4 vans = new Form4();
            this.Close();
            vans.Show();
        }

        private void electricCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 electric = new Form5();
            this.Close();
            electric.Show();
        }


        public static string vehicleID = "";
        public static string vehicleName;
        public static int vehicleYear;
        public static int vehiclePrice;
        public static string vehicleFuelType;
        public static string vehicleTransmission;
        public static string vehicleAvailability;

        SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DriveJoy;Integrated Security=True");
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        private void button1_Click_1(object sender, EventArgs e) //Button PC001
        {
            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                            vehicleName = (string)reader["CarName"];
                            vehicleYear = (int)reader["CarYear"];
                            vehicleID = (string)reader["CarID"];
                            vehiclePrice = (int)reader["CarPrice"];
                            vehicleTransmission = (string)reader["CarTransmission"];
                            vehicleAvailability = (string)reader["CarAvailability"];
                            vehicleFuelType = (string)reader["CarFuelType"];

                            Form9 objForm9 = new Form9();
                            objForm9.Show();
                            this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("This Velicle is Not Available at the Moment.", "Sorry..!",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void buttonPC002_Click(object sender, EventArgs e) //button PC002
        {
            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["CarName"];
                        vehicleYear = (int)reader["CarYear"];
                        vehicleID = (string)reader["CarID"];
                        vehiclePrice = (int)reader["CarPrice"];
                        vehicleTransmission = (string)reader["CarTransmission"];
                        vehicleAvailability = (string)reader["CarAvailability"];
                        vehicleFuelType = (string)reader["CarFuelType"];

                        Form9 objForm9 = new Form9();
                        objForm9.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("This Velicle is Not Available at the Moment.", "Sorry..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void buttonPC003_Click(object sender, EventArgs e) //button PC003
        {
            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["CarName"];
                        vehicleYear = (int)reader["CarYear"];
                        vehicleID = (string)reader["CarID"];
                        vehiclePrice = (int)reader["CarPrice"];
                        vehicleTransmission = (string)reader["CarTransmission"];
                        vehicleAvailability = (string)reader["CarAvailability"];
                        vehicleFuelType = (string)reader["CarFuelType"];

                        Form9 objForm9 = new Form9();
                        objForm9.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("This Velicle is Not Available at the Moment.", "Sorry..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void buttonPC004_Click(object sender, EventArgs e) // button PC004
        {
            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC004'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["CarName"];
                        vehicleYear = (int)reader["CarYear"];
                        vehicleID = (string)reader["CarID"];
                        vehiclePrice = (int)reader["CarPrice"];
                        vehicleTransmission = (string)reader["CarTransmission"];
                        vehicleAvailability = (string)reader["CarAvailability"];
                        vehicleFuelType = (string)reader["CarFuelType"];

                        Form9 objForm9 = new Form9();
                        objForm9.Show();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("This Velicle is Not Available at the Moment.", "Sorry..!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            conn.Close();
        }

        private void btnPC001_Click(object sender, EventArgs e) // PC001 Availability
        {
            pc001Yes.Text = "";
            pc001No.Text = "";
            pc002Yes.Text = "";
            pc002No.Text = "";
            pc003Yes.Text = "";
            pc003No.Text = "";
            pc004Yes.Text = "";
            pc004No.Text = "";

            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    pc001Yes.Text = "Availavle";
                    pc001No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    pc001Yes.Text = "";
                    pc001No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnPC002_Click(object sender, EventArgs e) //PC002 Availability
        {
            pc001Yes.Text = "";
            pc001No.Text = "";
            pc002Yes.Text = "";
            pc002No.Text = "";
            pc003Yes.Text = "";
            pc003No.Text = "";
            pc004Yes.Text = "";
            pc004No.Text = "";

            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    pc002Yes.Text = "Availavle";
                    pc002No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    pc002Yes.Text = "";
                    pc002No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnPC003_Click(object sender, EventArgs e) // PC003 Availability
        {
            pc001Yes.Text = "";
            pc001No.Text = "";
            pc002Yes.Text = "";
            pc002No.Text = "";
            pc003Yes.Text = "";
            pc003No.Text = "";
            pc004Yes.Text = "";
            pc004No.Text = "";

            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    pc003Yes.Text = "Availavle";
                    pc003No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    pc003Yes.Text = "";
                    pc003No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnPC004_Click(object sender, EventArgs e) // PC004 Availability
        {
            pc001Yes.Text = "";
            pc001No.Text = "";
            pc002Yes.Text = "";
            pc002No.Text = "";
            pc003Yes.Text = "";
            pc003No.Text = "";
            pc004Yes.Text = "";
            pc004No.Text = "";

            conn.Open();
            string select = "Select * from PassengerCar Where CarID = 'PC004'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["CarAvailability"];
                if (availability == "Available")
                {
                    pc004Yes.Text = "Availavle";
                    pc004No.Text = "";
                }
                else if (availability == "Not Available")
                {
                    pc004Yes.Text = "";
                    pc004No.Text = "Not Available";
                }
            }
            conn.Close();
        }
    }
    
}