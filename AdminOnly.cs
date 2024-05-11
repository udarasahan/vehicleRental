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
    public partial class AdminOnly : Form
    {
        public AdminOnly()
        {
            InitializeComponent();
        }

        private void AdminOnly_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            string carID = txtCarID.Text;

            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DriveJoy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            if (carID == "PC001" || carID == "PC002" || carID == "PC003" || carID == "PC004")
            {
                conn.Open();
                string select = "UPDATE passengerCar SET carAvailability = 'Available' WHERE CarID = '" + carID + "'";
                cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }
            else if (carID == "V001" || carID == "V002" || carID == "V003" || carID == "V004")
            {
                conn.Open();
                string select = "UPDATE vans SET vanAvailability = 'Available' WHERE VanID = '" + carID + "'";
                cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }
            else if (carID == "EC001" || carID == "EC002" || carID == "EC003")
            {
                conn.Open();
                string select = "UPDATE elecCar SET ecAvailability = 'Available' WHERE ecID = '" + carID + "'";
                cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }
            else if (carID == "OR001" || carID == "OR002" || carID == "OR003" || carID == "OR004")
            {
                conn.Open();
                string select = "UPDATE SUVs SET suvAvailability = 'Available' WHERE suvID = '" + carID + "'";
                cmd = new SqlCommand(select, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                conn.Close();
            }

            string orderID = txtOrderNo.Text;
            conn.Open();
            string delete1 = "DELETE FROM Customer_Table WHERE OrderID = '"+ orderID + "'";
            string delete2 = "DELETE FROM Order_Table WHERE OrderID = '" + orderID + "'";
            cmd = new SqlCommand(delete1, conn);
            cmd = new SqlCommand(delete2, conn);
            SqlDataReader remover = cmd.ExecuteReader();
            conn.Close();


        }

        private void button1_Click(object sender, EventArgs e) // Home Page
        {
            Form2 objForm2 = new Form2();
            this.Close();
            objForm2.Show();
        }
    }
}
