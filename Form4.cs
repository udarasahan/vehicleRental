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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

      

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

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

        private void backToHomePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 homePage = new Form2();
            this.Close();
            homePage.Show();
        }

        private void passengerCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form6 suv = new Form6();
            this.Close();
            suv.Show();
        }

        private void electricCarToolStripMenuItem_Click(object sender, EventArgs e) // To electronic cars
        {
            Form5 electric = new Form5();
            this.Close();
            electric.Show();
        }

        private void vansToolStripMenuItem_Click(object sender, EventArgs e) // To passenger cars
        {
            Form3 passenger = new Form3();
            this.Close();
            passenger.Show();
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

        private void buttonV001_Click(object sender, EventArgs e) // Button V001
        {
            conn.Open();
            string select = "Select * from vans Where vanID = 'V001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["vanAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["vanName"];
                        vehicleYear = (int)reader["vanYear"];
                        vehicleID = (string)reader["vanID"];
                        vehiclePrice = (int)reader["vanPrice"];
                        vehicleTransmission = (string)reader["vanTransmission"];
                        vehicleAvailability = (string)reader["vanAvailability"];
                        vehicleFuelType = (string)reader["vanFuel"];

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

        private void buttonV002_Click(object sender, EventArgs e) // Button V002
        {
            conn.Open();
            string select = "Select * from vans Where vanID = 'V002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["vanAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["vanName"];
                        vehicleYear = (int)reader["vanYear"];
                        vehicleID = (string)reader["vanID"];
                        vehiclePrice = (int)reader["vanPrice"];
                        vehicleTransmission = (string)reader["vanTransmission"];
                        vehicleAvailability = (string)reader["vanAvailability"];
                        vehicleFuelType = (string)reader["vanFuel"];

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

        private void buttonV003_Click(object sender, EventArgs e) // Button V003
        {
            conn.Open();
            string select = "Select * from vans Where vanID = 'V003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["vanAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["vanName"];
                        vehicleYear = (int)reader["vanYear"];
                        vehicleID = (string)reader["vanID"];
                        vehiclePrice = (int)reader["vanPrice"];
                        vehicleTransmission = (string)reader["vanTransmission"];
                        vehicleAvailability = (string)reader["vanAvailability"];
                        vehicleFuelType = (string)reader["vanFuel"];

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

        private void buttonV004_Click(object sender, EventArgs e) // Button V004
        {
            conn.Open();
            string select = "Select * from vans Where vanID = 'V004'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["vanAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["vanName"];
                        vehicleYear = (int)reader["vanYear"];
                        vehicleID = (string)reader["vanID"];
                        vehiclePrice = (int)reader["vanPrice"];
                        vehicleTransmission = (string)reader["vanTransmission"];
                        vehicleAvailability = (string)reader["vanAvailability"];
                        vehicleFuelType = (string)reader["vanFuel"];

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

        private void btnV001_Click(object sender, EventArgs e) // V001 Availability 
        {
            v001Yes.Text = "";
            v001No.Text = "";
            v002Yes.Text = "";
            v002No.Text = "";
            v003Yes.Text = "";
            v003No.Text = "";
            v004Yes.Text = "";
            v004No.Text = "";

            conn.Open();
            string select = "Select * from vans Where vanID = 'V001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["VanAvailability"];
                if (availability == "Available")
                {
                    v001Yes.Text = "Availavle";
                    v001No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    v001Yes.Text = "";
                    v001No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnV002_Click(object sender, EventArgs e) // V002 Availability
        {
            v001Yes.Text = "";
            v001No.Text = "";
            v002Yes.Text = "";
            v002No.Text = "";
            v003Yes.Text = "";
            v003No.Text = "";
            v004Yes.Text = "";
            v004No.Text = "";

            conn.Open();
            string select = "Select * from vans Where vanID = 'V002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["VanAvailability"];
                if (availability == "Available")
                {
                    v002Yes.Text = "Availavle";
                    v002No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    v002Yes.Text = "";
                    v002No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnV003_Click(object sender, EventArgs e) // V003 Availability
        {

            v001Yes.Text = "";
            v001No.Text = "";
            v002Yes.Text = "";
            v002No.Text = "";
            v003Yes.Text = "";
            v003No.Text = "";
            v004Yes.Text = "";
            v004No.Text = "";

            conn.Open();
            string select = "Select * from vans Where vanID = 'V003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["VanAvailability"];
                if (availability == "Available")
                {
                    v003Yes.Text = "Availavle";
                    v003No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    v003Yes.Text = "";
                    v003No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnV004_Click(object sender, EventArgs e) // V004 Availability
        {

            v001Yes.Text = "";
            v001No.Text = "";
            v002Yes.Text = "";
            v002No.Text = "";
            v003Yes.Text = "";
            v003No.Text = "";
            v004Yes.Text = "";
            v004No.Text = "";

            conn.Open();
            string select = "Select * from vans Where vanID = 'V004'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["VanAvailability"];
                if (availability == "Available")
                {
                    v004Yes.Text = "Availavle";
                    v004No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    v004Yes.Text = "";
                    v004No.Text = "Not Available";
                }
            }
            conn.Close();
        }   
    }
}
