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
    public partial class Finale : Form
    {
        public Finale()
        {
            InitializeComponent();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void Finale_Load(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DriveJoy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            // Import Data from Order Table
            conn.Open();
            string select = "Select * from Order_Table Where OrderID = '" + Form9.orderNo + "'";
            cmd = new SqlCommand(select, conn);
            SqlDataReader reader = cmd.ExecuteReader();

            while(reader.Read())
            {
                lblVname.Text = (string)reader["VehicleName"];
                lblVid.Text = (string)reader["VehicleID"];
                lblPick.Text = (string)reader["PickupDate"];
                lblRet.Text = (string)reader["ReturnDate"];
                
            }
            conn.Close();

            // Import data from Customer table
            conn.Open();
            string Customer = "Select * from Customer_Table Where OrderID = '" + Form9.orderNo + "'";
            cmd = new SqlCommand(Customer, conn);
            SqlDataReader searcher = cmd.ExecuteReader();

            while(searcher.Read())
            {
                lblCname.Text = (string)searcher["CustomerName"];
                lblTel.Text = (string)searcher["CustomerPhone"];
                lblEmail.Text = (string)searcher["CustomerEmail"];
                lblAddress.Text = (string)searcher["CustomerAddress"];
                lblNic.Text = (string)searcher["CustomerNIC"];
                lblLice.Text = (string)searcher["CustomerLicNo"];
                lblReq.Text = (string)searcher["SpecialReq"];

            }
            conn.Close();

            lblFuel.Text = Form9.fuelType;
            lblTrans.Text = Form9.Transmission;
            lblDays.Text = Form9.dayCount.ToString();
            lblVehi.Text = Form9.vehiPrice.ToString();
            lblAdd.Text = Form9.additionalDriverFee.ToString();
            lblGps.Text = Form9.gpsFee.ToString();
            lblChild.Text = Form9.childSeatFee.ToString();
            orderNo.Text = Form9.orderNo.ToString();
            lblTotal.Text = Form9.totalAmount.ToString();



        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            
        }
    }
}
