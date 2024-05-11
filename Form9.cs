using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Timers;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GroupProject
{


    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this.TopMost = true; // Set the form to be top-most
            btnConfirmOrder.Enabled = false;
        }

        public static int orderNo = 0;

        string carName = Form3.vehicleName;
        int carYear = Form3.vehicleYear;
        string carID = Form3.vehicleID;
        int carPrice = Form3.vehiclePrice;
        string carTransmission = Form3.vehicleTransmission;
        string carFuelType = Form3.vehicleFuelType;

        string vanName = Form4.vehicleName;
        int vanYear = Form4.vehicleYear;
        string vanID = Form4.vehicleID;
        int vanPrice = Form4.vehiclePrice;
        string vanTransmission = Form4.vehicleTransmission;
        string vanFuelType = Form4.vehicleFuelType;

        string elecName = Form5.vehicleName;
        int elecYear = Form5.vehicleYear;
        string elecID = Form5.vehicleID;
        int elecPrice = Form5.vehiclePrice;
        string elecTransmission = Form5.vehicleTransmission;
        string elecFuelType = Form5.vehicleFuelType;

        string suvName = Form6.vehicleName;
        int suvYear = Form6.vehicleYear;
        string suvID = Form6.vehicleID;
        int suvPrice = Form6.vehiclePrice;
        string suvTransmission = Form6.vehicleTransmission;
        string suvFuelType = Form6.vehicleFuelType;


        private void Form9_Load(object sender, EventArgs e)
        {
           
            Random random = new Random();

            // Generate a random 5-digit number
            orderNo = random.Next(10000, 99999);
            lblOrder.Text = orderNo.ToString();

            if (vanID == "" && elecID == "" && suvID == "")
            {
                txtName.Text = carName;
                txtVehicleID.Text = carID;
                txtYear.Text = carYear.ToString();
                txtTransmission.Text = carTransmission;
                txtFuel.Text = carFuelType;
                txtPrice.Text = carPrice.ToString();
            }
            if (carID == "" && elecID == "" && suvID == "")
            {
                txtName.Text = vanName;
                txtVehicleID.Text = vanID;
                txtYear.Text = vanYear.ToString();
                txtTransmission.Text = vanTransmission;
                txtFuel.Text = vanFuelType;
                txtPrice.Text = vanPrice.ToString();
            }
            if (carID == "" && vanID == "" && suvID == "")
            {
                txtName.Text = elecName;
                txtVehicleID.Text = elecID;
                txtYear.Text = elecYear.ToString();
                txtTransmission.Text = elecTransmission;
                txtFuel.Text = elecFuelType;
                txtPrice.Text = elecPrice.ToString();
            }
            if (carID == "" && elecID == "" && vanID == "")
            {
                txtName.Text = suvName;
                txtVehicleID.Text = suvID;
                txtYear.Text = suvYear.ToString();
                txtTransmission.Text = suvTransmission;
                txtFuel.Text = suvFuelType;
                txtPrice.Text = suvPrice.ToString();
            }

            if (txtVehicleID.Text == "PC001")
            {
                pictureBox1.Image = Properties.Resources.Toyota_Axio_1_e1686125996936;
            }
            else if (txtVehicleID.Text == "PC002")
            {
                pictureBox1.Image = Properties.Resources.image_337f8501f1;
            }
            else if (txtVehicleID.Text == "PC003")
            {
                pictureBox1.Image = Properties.Resources._1200px_Toyota_PREMIO_1_5F_L_Package;
            }
            else if (txtVehicleID.Text == "PC004")
            {
                pictureBox1.Image = Properties.Resources._2003_nissan_sunny_n17_ex_saloon_023;
            }
            else if (txtVehicleID.Text == "V001")
            {
                pictureBox1.Image = Properties.Resources._4999_0;
            }
            else if (txtVehicleID.Text == "V002")
            {
                pictureBox1.Image = Properties.Resources.hqdefault;
            }
            else if (txtVehicleID.Text == "V003")
            {
                pictureBox1.Image = Properties.Resources._5135799_carP_l_1_jpg20220123_1537_1apdsyk;
            }
            else if (txtVehicleID.Text == "V004")
            {
                pictureBox1.Image = Properties.Resources.x5_11125968977x3;
            }
            else if (txtVehicleID.Text == "EC001")
            {
                pictureBox1.Image = Properties.Resources.nkvULX9afXDf2nGt3vDBPj_1200_80;
            }
            else if (txtVehicleID.Text == "EC002")
            {
                pictureBox1.Image = Properties.Resources._1200px_2018_BMW_i3_facelift__1_;
            }
            else if (txtVehicleID.Text == "EC003")
            {
                pictureBox1.Image = Properties.Resources._20161019021552_e2x2;
            }
            else if (txtVehicleID.Text == "OR001")
            {
                pictureBox1.Image = Properties.Resources.nissan_patrol_exterior_view_1_e1692938842637;
            }
            else if (txtVehicleID.Text == "OR002")
            {
                pictureBox1.Image = Properties.Resources._20200810_180004;
            }
            else if (txtVehicleID.Text == "OR003")
            {
                pictureBox1.Image = Properties.Resources.image_420293cad9;
            }
            else if (txtVehicleID.Text == "OR004")
            {
                pictureBox1.Image = Properties.Resources._42017;
            }
            else
            {

            }


        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // Button Cancel
        {
            // Display a confirmation dialog using MessageBox.
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel the Order?", "Order Cancelation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response.
            if (result == DialogResult.Yes)
            {
                if (vanID == "" && elecID == "" && suvID == "")
                {
                    Form3 objForm3 = new Form3();
                    objForm3.Show();

                    txtName.Text = "";
                    txtVehicleID.Text = "";
                    txtYear.Text = "";
                    txtTransmission.Text = "";
                    txtFuel.Text = "";
                    txtPrice.Text = "";
                    carID = "";
                    vanID = "";
                    elecID = "";
                    suvID = "";

                    this.Close();
                    MessageBox.Show("Your Order has been Cancelled!", "DriveJoy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (carID == "" && elecID == "" && suvID == "")
                {
                    Form4 objForm4 = new Form4();
                    objForm4.Show();

                    txtName.Text = "";
                    txtVehicleID.Text = "";
                    txtYear.Text = "";
                    txtTransmission.Text = "";
                    txtFuel.Text = "";
                    txtPrice.Text = "";
                    carID = "";
                    vanID = "";
                    elecID = "";
                    suvID = "";

                    this.Close();
                    MessageBox.Show("Your Order is Cancelled!", "DriveJoy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (carID == "" && vanID == "" && suvID == "")
                {
                    Form5 objForm5 = new Form5();
                    objForm5.Show();

                    txtName.Text = "";
                    txtVehicleID.Text = "";
                    txtYear.Text = "";
                    txtTransmission.Text = "";
                    txtFuel.Text = "";
                    txtPrice.Text = "";
                    carID = "";
                    vanID = "";
                    elecID = "";
                    suvID = "";

                    this.Close();
                    MessageBox.Show("Your Order is Cancelled!", "DriveJoy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }
                if (carID == "" && elecID == "" && vanID == "")
                {
                    Form6 objForm6 = new Form6();
                    objForm6.Show();

                    txtName.Text = "";
                    txtVehicleID.Text = "";
                    txtYear.Text = "";
                    txtTransmission.Text = "";
                    txtFuel.Text = "";
                    txtPrice.Text = "";
                    carID = "";
                    vanID = "";
                    elecID = "";
                    suvID = "";

                    this.Close();
                    MessageBox.Show("Your Order is Cancelled!", "DriveJoy", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;
                }

            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e) // Pick up Date
        {
            pickupPicker.MinDate = DateTime.Today; // Sets the minimum date to the current date

            pickupPicker.Format = DateTimePickerFormat.Custom;
            pickupPicker.CustomFormat = "yyyy-MM-dd";
           
            
        }

        public static string fuelType = "";
        public static string Transmission = "";
        public static int vehiPrice = 0;

        private bool AreDatesSelected() //Method to disable the confirm button untill select the two dats
        {
            // Check if both DateTimePickers have valid dates selected
            return pickupPicker.Value != pickupPicker.MinDate && returnPicker.Value != returnPicker.MinDate;
        }
        private void dateTimePicker3_ValueChanged(object sender, EventArgs e) // Return Date
        {
            returnPicker.Format = DateTimePickerFormat.Custom;
            returnPicker.CustomFormat = "yyyy-MM-dd";

            // Get the selected date from datetimepicker1
            DateTime selectedDate = pickupPicker.Value;

            // Calculate the minimum date for datetimepicker2 (one day after selectedDate)
            DateTime minDateForPicker2 = selectedDate.AddDays(1);

            

            // Set the minimum date for datetimepicker2
            returnPicker.MinDate = minDateForPicker2;
            
        }
        public static string customerName = "";
        public static string phoneNo = "";
        public static string address = "";
        public static string email = "";
        public static string nicNo = "";
        public static string driverLicense = "";
        public static int dayCount = 0;
        public static string specialRequests = "";
        public DateTime pickupDate;
        public DateTime returnDate;

        public static int additionalDriverFee = 0;
        public static int gpsFee = 0;
        public static int childSeatFee = 0;
        public static int totalAmount = 0;


        private void btnConfirmOrder_Click(object sender, EventArgs e) // Confirm My Order Button
        {

            SqlConnection conn = new SqlConnection("Data Source=.\\sqlexpress;Initial Catalog=DriveJoy;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            SqlDataAdapter adapter = new SqlDataAdapter();

            


            customerName = txtCustomerName.Text;
            phoneNo = txtCustomerPhone.Text;
            address = txtCustomerAddress.Text;
            email = txtCustomerEmail.Text;
            nicNo = txtCustomerNIC.Text;
            driverLicense = txtLicenseNo.Text;

            

            // Get the selected pickup and return dates
            pickupDate = pickupPicker.Value;
            returnDate = returnPicker.Value;

            // Calculate the number of days
            TimeSpan rentalPeriod = returnDate - pickupDate;
            dayCount = (int)rentalPeriod.TotalDays;

            

            if (checkChildSeat.Checked)
            {
                comboSeatCount.Visible = checkChildSeat.Checked;

                int selectedIndex = comboSeatCount.SelectedIndex;
                int childSeatCount = 0;

                // Check the selected index to perform actions
                if (selectedIndex == 0)
                {
                    childSeatCount = 1;
                }
                else if (selectedIndex == 1)
                {
                    childSeatCount = 2;
                }
                else if (selectedIndex == 2)
                {
                    childSeatCount = 3;
                }
                else
                {
                    childSeatCount = 1;
                }

                childSeatFee = 1500 * childSeatCount;
            }
            if (checkAddDriver.Checked)
            {
                additionalDriverFee = 2000 * dayCount;
            }
            if (checkGPS.Checked)
            {
                gpsFee = 500 * dayCount;
            }
            // Calculate the Total Amount
            totalAmount = int.Parse(txtPrice.Text) * dayCount + additionalDriverFee + childSeatFee + gpsFee;

            if (customerName == "" || phoneNo == "" || address == "" || email == ""
                || nicNo == "" || driverLicense == "" || dayCount < 0 || dayCount == 0)
            {
                if (customerName == ""){lblName.Text = "*Required Field";}
                else{lblName.Text = "";}
                if (phoneNo == ""){lblPhone.Text = "*Required Field";}else { lblPhone.Text = ""; }
                if (address == ""){lblAddress.Text = "*Required Field";}else { lblAddress.Text = ""; }
                if (email == ""){lblEmail.Text = "*Required Field";}else { lblEmail.Text = ""; }
                if (nicNo == ""){lblNic.Text = "*Required Field";}else { lblNic.Text = ""; }
                if (driverLicense == ""){lblLicense.Text = "*Required Field";}else { lblLicense.Text = ""; }
                if (dayCount < 0 || dayCount == 0){lblReturn.Text = "*Please select the pickup date & return date";}else{lblReturn.Text = "";}}
            else 
            {
                string carID = txtVehicleID.Text;
                // Update the tabel when the dar is rent
                if (carID == "PC001" || carID == "PC002" || carID == "PC003" || carID == "PC004")
                {
                    conn.Open();
                    string select = "UPDATE passengerCar SET carAvailability = 'Not Avbl' WHERE CarID = '" + carID + "'";
                    cmd = new SqlCommand(select, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                }
                else if (carID == "V001" || carID == "V002" || carID == "V003" || carID == "V004")
                {
                    conn.Open();
                    string select = "UPDATE vans SET vanAvailability = 'Not Avbl' WHERE VanID = '" + carID + "'";
                    cmd = new SqlCommand(select, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                }
                else if (carID == "EC001" || carID == "EC002" || carID == "EC003")
                {
                    conn.Open();
                    string select = "UPDATE elecCar SET ecAvailability = 'Not Avbl' WHERE ecID = '" + carID + "'";
                    cmd = new SqlCommand(select, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                }
                else if (carID == "OR001" || carID == "OR002" || carID == "OR003" || carID == "OR004")
                {
                    conn.Open();
                    string select = "UPDATE SUVs SET suvAvailability = 'Not Avbl' WHERE suvID = '" + carID + "'";
                    cmd = new SqlCommand(select, conn);
                    SqlDataReader reader = cmd.ExecuteReader();
                    conn.Close();
                }

                fuelType = txtFuel.Text;
                Transmission = txtTransmission.Text;
                vehiPrice = int.Parse(txtPrice.Text) * dayCount;

                string customerName = txtCustomerName.Text;
                string customerPhone = txtCustomerPhone.Text;
                string customerEmail = txtCustomerEmail.Text;
                string customerAddress = txtCustomerAddress.Text;
                string customerNic = txtCustomerNIC.Text;
                string customerLicNo = txtLicenseNo.Text;
                string specialReq = txtSpecialReq.Text;

                // Adding Details to the Tables

                conn.Open();
                string register = "INSERT INTO Order_Table VALUES ('" + orderNo + "','" + customerName + "','" + 
                    nicNo + "','" + txtName.Text + "','" + txtVehicleID.Text + "','" + pickupDate + "','" + returnDate + "','" + totalAmount + "')";
                cmd = new SqlCommand(register, conn);
                cmd.ExecuteNonQuery();
                conn.Close();

                conn.Open();
                string CustomerInsert = "INSERT INTO Customer_Table VALUES ('" + orderNo + "','" + customerName +"','" + customerPhone + "','" 
                    + customerEmail + "','" + customerAddress + "','" + customerNic + "','" + customerLicNo + "','" + specialReq + "')";
                cmd = new SqlCommand(CustomerInsert, conn);
                cmd.ExecuteNonQuery();
                conn.Close();


                Form11 objForm11 = new Form11();
                this.Close();
                objForm11.Show();
                MessageBox.Show("Congratulations!! Your Order has been Successfully placed.", "DriveJoy", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

           
        }


        private void CheckFormCompletion()
        {
            
        }

        private void checkTerms_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTerms.Checked)
            {
                btnConfirmOrder.Enabled = true;
            }
            else 
            {
                btnConfirmOrder.Enabled = false;
            }
        }

        private void lblAddress_Click(object sender, EventArgs e)
        {

        }

        private void pickupPicker_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void returnPicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                returnPicker.CustomFormat = " ";
            }
        }
    }
}
