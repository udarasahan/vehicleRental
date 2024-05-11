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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
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

        private void vansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 vans = new Form4();
            this.Close();
            vans.Show();
        }

        private void electricCarToolStripMenuItem_Click(object sender, EventArgs e) // to passenger cars
        {
            Form3 passenger = new Form3();
            this.Close();
            passenger.Show();
        }

        private void button1_Click(object sender, EventArgs e) // Clear button
        {
            
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

        private void buttonEC001_Click(object sender, EventArgs e) //Button EC001
        {
            conn.Open();
            string select = "Select * from elecCar Where ecID = 'EC001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["ecAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["ecName"];
                        vehicleYear = (int)reader["ecYear"];
                        vehicleID = (string)reader["ecID"];
                        vehiclePrice = (int)reader["ecPrice"];
                        vehicleTransmission = (string)reader["ecTransmission"];
                        vehicleAvailability = (string)reader["ecAvailability"];
                        vehicleFuelType = (string)reader["ecFuel"];

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

        private void buttonEC002_Click(object sender, EventArgs e) // Button EC002
        {
            conn.Open();
            string select = "Select * from elecCar Where ecID = 'EC002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["ecAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["ecName"];
                        vehicleYear = (int)reader["ecYear"];
                        vehicleID = (string)reader["ecID"];
                        vehiclePrice = (int)reader["ecPrice"];
                        vehicleTransmission = (string)reader["ecTransmission"];
                        vehicleAvailability = (string)reader["ecAvailability"];
                        vehicleFuelType = (string)reader["ecFuel"];

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

        private void buttonEC003_Click(object sender, EventArgs e) //Button EC003
        {
            conn.Open();
            string select = "Select * from elecCar Where ecID = 'EC003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["ecAvailability"];
                if (availability == "Available")
                {
                    DialogResult result = MessageBox.Show("Are Your Sure You want to Rent this Car?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        vehicleName = (string)reader["ecName"];
                        vehicleYear = (int)reader["ecYear"];
                        vehicleID = (string)reader["ecID"];
                        vehiclePrice = (int)reader["ecPrice"];
                        vehicleTransmission = (string)reader["ecTransmission"];
                        vehicleAvailability = (string)reader["ecAvailability"];
                        vehicleFuelType = (string)reader["ecFuel"];

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

        private void btnEC001_Click(object sender, EventArgs e) // EC001 Availability
        {
            ec001Yes.Text = "";
            ec001No.Text = "";
            ec002Yes.Text = "";
            ec002No.Text = "";
            ec003Yes.Text = "";
            ec003No.Text = "";

            conn.Open();
            string select = "Select * from elecCar Where ecID = 'EC001'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["ecAvailability"];
                if (availability == "Available")
                {
                    ec001Yes.Text = "Availavle";
                    ec001No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    ec001Yes.Text = "";
                    ec001No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnEC002_Click(object sender, EventArgs e) // EC002 Availability
        {
            ec001Yes.Text = "";
            ec001No.Text = "";
            ec002Yes.Text = "";
            ec002No.Text = "";
            ec003Yes.Text = "";
            ec003No.Text = "";

            conn.Open();
            string select = "Select * from elecCar Where ecID = 'EC002'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["ecAvailability"];
                if (availability == "Available")
                {
                    ec002Yes.Text = "Availavle";
                    ec002No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    ec002Yes.Text = "";
                    ec002No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void btnEC003_Click(object sender, EventArgs e) // EC003 Availability
        {
            ec001Yes.Text = "";
            ec001No.Text = "";
            ec002Yes.Text = "";
            ec002No.Text = "";
            ec003Yes.Text = "";
            ec003No.Text = "";

            conn.Open();
            string select = "Select * from elecCar Where ecID = 'EC003'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string availability = (string)reader["ecAvailability"];
                if (availability == "Available")
                {
                    ec003Yes.Text = "Availavle";
                    ec003No.Text = "";
                }
                else if (availability == "Not Avbl")
                {
                    ec003Yes.Text = "";
                    ec003No.Text = "Not Available";
                }
            }
            conn.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void ec001Yes_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void ec001No_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void ec003No_Click(object sender, EventArgs e)
        {

        }

        private void ec003Yes_Click(object sender, EventArgs e)
        {

        }

        private void ec002No_Click(object sender, EventArgs e)
        {

        }

        private void ec002Yes_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void labelp_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
