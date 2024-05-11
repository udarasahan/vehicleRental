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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
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

        private void vansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 vans = new Form4();
            this.Close();
            vans.Show();
        }

        private void electricCarToolStripMenuItem_Click(object sender, EventArgs e) // To electric cars
        {
            Form5 electric = new Form5();
            this.Close();
            electric.Show();
        }

        private void passengerCarToolStripMenuItem_Click(object sender, EventArgs e) // to passenger cars
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

        private void buttonOR001_Click(object sender, EventArgs e) // Button OR001
        {
            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["suvName"];
                        vehicleYear = (int)reader["suvYear"];
                        vehicleID = (string)reader["suvID"];
                        vehiclePrice = (int)reader["suvPrice"];
                        vehicleTransmission = (string)reader["suvTransmission"];
                        vehicleAvailability = (string)reader["suvAvailability"];
                        vehicleFuelType = (string)reader["suvFuel"];

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

        private void buttonOR002_Click(object sender, EventArgs e) //Button OR002
        {
            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["suvName"];
                        vehicleYear = (int)reader["suvYear"];
                        vehicleID = (string)reader["suvID"];
                        vehiclePrice = (int)reader["suvPrice"];
                        vehicleTransmission = (string)reader["suvTransmission"];
                        vehicleAvailability = (string)reader["suvAvailability"];
                        vehicleFuelType = (string)reader["suvFuel"];

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

        private void buttonOR003_Click(object sender, EventArgs e) //Button OR003
        {
            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["suvName"];
                        vehicleYear = (int)reader["suvYear"];
                        vehicleID = (string)reader["suvID"];
                        vehiclePrice = (int)reader["suvPrice"];
                        vehicleTransmission = (string)reader["suvTransmission"];
                        vehicleAvailability = (string)reader["suvAvailability"];
                        vehicleFuelType = (string)reader["suvFuel"];

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

        private void buttonOR004_Click(object sender, EventArgs e) //Button OR004
        {
            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR004'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["suvName"];
                        vehicleYear = (int)reader["suvYear"];
                        vehicleID = (string)reader["suvID"];
                        vehiclePrice = (int)reader["suvPrice"];
                        vehicleTransmission = (string)reader["suvTransmission"];
                        vehicleAvailability = (string)reader["suvAvailability"];
                        vehicleFuelType = (string)reader["suvFuel"];

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

        private void btnOR001_Click(object sender, EventArgs e) // OR001 Availability
        {
            or001Yes.Text = "";
            or001No.Text = "";
            or002Yes.Text = "";
            or002No.Text = "";
            or003Yes.Text = "";
            or003No.Text = "";
            or004Yes.Text = "";
            or004No.Text = "";

            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    or001Yes.Text = "Availavle";
                    or001No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    or001Yes.Text = "";
                    or001No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnOR002_Click(object sender, EventArgs e) // OR002 Availability
        {
            or001Yes.Text = "";
            or001No.Text = "";
            or002Yes.Text = "";
            or002No.Text = "";
            or003Yes.Text = "";
            or003No.Text = "";
            or004Yes.Text = "";
            or004No.Text = "";

            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    or002Yes.Text = "Availavle";
                    or002No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    or002Yes.Text = "";
                    or002No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnOR003_Click(object sender, EventArgs e) // OR003 Availability
        {
            or001Yes.Text = "";
            or001No.Text = "";
            or002Yes.Text = "";
            or002No.Text = "";
            or003Yes.Text = "";
            or003No.Text = "";
            or004Yes.Text = "";
            or004No.Text = "";

            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    or003Yes.Text = "Availavle";
                    or003No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    or003Yes.Text = "";
                    or003No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnOR004_Click(object sender, EventArgs e) //OR004 Availability
        {
            or001Yes.Text = "";
            or001No.Text = "";
            or002Yes.Text = "";
            or002No.Text = "";
            or003Yes.Text = "";
            or003No.Text = "";
            or004Yes.Text = "";
            or004No.Text = "";

            conn.Open();
            string select = "Select * from SUVs Where suvID = 'OR004'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["suvAvailability"];
                if (availability == "Available")
                {
                    or004Yes.Text = "Availavle";
                    or004No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    or004Yes.Text = "";
                    or004No.Text = "Not Available";
                }
            }
            conn.Close();
        }
    }
}
