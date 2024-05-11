namespace GroupProject
{
    partial class Form9
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.driveJoy1 = new GroupProject.DriveJoy();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.txtFuel = new System.Windows.Forms.TextBox();
            this.txtTransmission = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVehicleID = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.txtCustomerPhone = new System.Windows.Forms.TextBox();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtCustomerNIC = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtLicenseNo = new System.Windows.Forms.TextBox();
            this.richTextBox4 = new System.Windows.Forms.RichTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.pickupPicker = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.returnPicker = new System.Windows.Forms.DateTimePicker();
            this.richTextBox5 = new System.Windows.Forms.RichTextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.checkAddDriver = new System.Windows.Forms.CheckBox();
            this.checkGPS = new System.Windows.Forms.CheckBox();
            this.checkChildSeat = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label27 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.checkTerms = new System.Windows.Forms.CheckBox();
            this.orderNumber = new System.Windows.Forms.Label();
            this.txtSpecialReq = new System.Windows.Forms.RichTextBox();
            this.btnConfirmOrder = new System.Windows.Forms.Button();
            this.label30 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label34 = new System.Windows.Forms.Label();
            this.comboSeatCount = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNic = new System.Windows.Forms.Label();
            this.lblLicense = new System.Windows.Forms.Label();
            this.lblReturn = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblOrder = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.driveJoy1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = resources.GetString("sqlSelectCommand1.CommandText");
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=.\\sqlexpress;Initial Catalog=DriveJoy;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "elecCar", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CarID", "CarID"),
                        new System.Data.Common.DataColumnMapping("CarName", "CarName"),
                        new System.Data.Common.DataColumnMapping("CarYear", "CarYear"),
                        new System.Data.Common.DataColumnMapping("CarPrice", "CarPrice"),
                        new System.Data.Common.DataColumnMapping("CarAvailability", "CarAvailability"),
                        new System.Data.Common.DataColumnMapping("CarTransmission", "CarTransmission"),
                        new System.Data.Common.DataColumnMapping("CarFuelType", "CarFuelType"),
                        new System.Data.Common.DataColumnMapping("ecID", "ecID"),
                        new System.Data.Common.DataColumnMapping("ecName", "ecName"),
                        new System.Data.Common.DataColumnMapping("ecYear", "ecYear"),
                        new System.Data.Common.DataColumnMapping("ecPrice", "ecPrice"),
                        new System.Data.Common.DataColumnMapping("ecAvailability", "ecAvailability"),
                        new System.Data.Common.DataColumnMapping("ecTransmission", "ecTransmission"),
                        new System.Data.Common.DataColumnMapping("ecFuel", "ecFuel"),
                        new System.Data.Common.DataColumnMapping("CarID1", "CarID1"),
                        new System.Data.Common.DataColumnMapping("CarName1", "CarName1"),
                        new System.Data.Common.DataColumnMapping("CarYear1", "CarYear1"),
                        new System.Data.Common.DataColumnMapping("CarPrice1", "CarPrice1"),
                        new System.Data.Common.DataColumnMapping("CarAvailability1", "CarAvailability1"),
                        new System.Data.Common.DataColumnMapping("CarTransmission1", "CarTransmission1"),
                        new System.Data.Common.DataColumnMapping("CarFuelType1", "CarFuelType1"),
                        new System.Data.Common.DataColumnMapping("ecID1", "ecID1"),
                        new System.Data.Common.DataColumnMapping("ecName1", "ecName1"),
                        new System.Data.Common.DataColumnMapping("ecYear1", "ecYear1"),
                        new System.Data.Common.DataColumnMapping("ecPrice1", "ecPrice1"),
                        new System.Data.Common.DataColumnMapping("ecAvailability1", "ecAvailability1"),
                        new System.Data.Common.DataColumnMapping("ecTransmission1", "ecTransmission1"),
                        new System.Data.Common.DataColumnMapping("ecFuel1", "ecFuel1"),
                        new System.Data.Common.DataColumnMapping("vanID", "vanID"),
                        new System.Data.Common.DataColumnMapping("vanName", "vanName"),
                        new System.Data.Common.DataColumnMapping("vanYear", "vanYear"),
                        new System.Data.Common.DataColumnMapping("vanPrice", "vanPrice"),
                        new System.Data.Common.DataColumnMapping("vanAvailability", "vanAvailability"),
                        new System.Data.Common.DataColumnMapping("vanTransmission", "vanTransmission"),
                        new System.Data.Common.DataColumnMapping("vanFuel", "vanFuel"),
                        new System.Data.Common.DataColumnMapping("suvID", "suvID"),
                        new System.Data.Common.DataColumnMapping("suvName", "suvName"),
                        new System.Data.Common.DataColumnMapping("suvYear", "suvYear"),
                        new System.Data.Common.DataColumnMapping("suvPrice", "suvPrice"),
                        new System.Data.Common.DataColumnMapping("suvAvailability", "suvAvailability"),
                        new System.Data.Common.DataColumnMapping("suvTransmission", "suvTransmission"),
                        new System.Data.Common.DataColumnMapping("suvFuel", "suvFuel"),
                        new System.Data.Common.DataColumnMapping("vanID1", "vanID1"),
                        new System.Data.Common.DataColumnMapping("vanName1", "vanName1"),
                        new System.Data.Common.DataColumnMapping("vanYear1", "vanYear1"),
                        new System.Data.Common.DataColumnMapping("vanPrice1", "vanPrice1"),
                        new System.Data.Common.DataColumnMapping("vanAvailability1", "vanAvailability1"),
                        new System.Data.Common.DataColumnMapping("vanTransmission1", "vanTransmission1"),
                        new System.Data.Common.DataColumnMapping("vanFuel1", "vanFuel1"),
                        new System.Data.Common.DataColumnMapping("suvID1", "suvID1"),
                        new System.Data.Common.DataColumnMapping("suvName1", "suvName1"),
                        new System.Data.Common.DataColumnMapping("suvYear1", "suvYear1"),
                        new System.Data.Common.DataColumnMapping("suvPrice1", "suvPrice1"),
                        new System.Data.Common.DataColumnMapping("suvAvailability1", "suvAvailability1"),
                        new System.Data.Common.DataColumnMapping("suvTransmission1", "suvTransmission1"),
                        new System.Data.Common.DataColumnMapping("suvFuel1", "suvFuel1")})});
            // 
            // driveJoy1
            // 
            this.driveJoy1.DataSetName = "DriveJoy";
            this.driveJoy1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(94, 829);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(1372, 215);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // txtFuel
            // 
            this.txtFuel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuel.Location = new System.Drawing.Point(338, 472);
            this.txtFuel.Name = "txtFuel";
            this.txtFuel.ReadOnly = true;
            this.txtFuel.Size = new System.Drawing.Size(487, 30);
            this.txtFuel.TabIndex = 2;
            // 
            // txtTransmission
            // 
            this.txtTransmission.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransmission.Location = new System.Drawing.Point(338, 552);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.ReadOnly = true;
            this.txtTransmission.Size = new System.Drawing.Size(487, 30);
            this.txtTransmission.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.Location = new System.Drawing.Point(338, 389);
            this.txtYear.Name = "txtYear";
            this.txtYear.ReadOnly = true;
            this.txtYear.Size = new System.Drawing.Size(487, 30);
            this.txtYear.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(338, 244);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(487, 30);
            this.txtName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1192, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Order No :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 396);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Year Of Manufacture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(121, 559);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Transmission";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(121, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Vehicle ID.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(121, 479);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Fuel Type";
            // 
            // txtVehicleID
            // 
            this.txtVehicleID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleID.Location = new System.Drawing.Point(338, 314);
            this.txtVehicleID.Name = "txtVehicleID";
            this.txtVehicleID.ReadOnly = true;
            this.txtVehicleID.Size = new System.Drawing.Size(487, 30);
            this.txtVehicleID.TabIndex = 6;
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(338, 635);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(487, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(121, 642);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 20);
            this.label7.TabIndex = 9;
            this.label7.Text = "Price Per Day Rs.";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.IndianRed;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1196, 730);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(271, 47);
            this.button1.TabIndex = 12;
            this.button1.Text = "Cancel My Order ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(86, 768);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(327, 58);
            this.label8.TabIndex = 13;
            this.label8.Text = "Customer Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(121, 873);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Customer Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(121, 935);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Telephone No";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(822, 935);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 14;
            this.label11.Text = "Email";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(121, 996);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Address";
            // 
            // richTextBox3
            // 
            this.richTextBox3.Location = new System.Drawing.Point(92, 1127);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.ReadOnly = true;
            this.richTextBox3.Size = new System.Drawing.Size(1372, 86);
            this.richTextBox3.TabIndex = 0;
            this.richTextBox3.Text = "";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(84, 1066);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(411, 58);
            this.label13.TabIndex = 13;
            this.label13.Text = "Driver License Details";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(338, 866);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(1093, 30);
            this.txtCustomerName.TabIndex = 15;
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(338, 989);
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(412, 30);
            this.txtCustomerAddress.TabIndex = 15;
            // 
            // txtCustomerPhone
            // 
            this.txtCustomerPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPhone.Location = new System.Drawing.Point(338, 928);
            this.txtCustomerPhone.Name = "txtCustomerPhone";
            this.txtCustomerPhone.Size = new System.Drawing.Size(412, 30);
            this.txtCustomerPhone.TabIndex = 15;
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerEmail.Location = new System.Drawing.Point(931, 928);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(500, 30);
            this.txtCustomerEmail.TabIndex = 15;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(822, 996);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 20);
            this.label14.TabIndex = 14;
            this.label14.Text = "NIC No.";
            // 
            // txtCustomerNIC
            // 
            this.txtCustomerNIC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNIC.Location = new System.Drawing.Point(931, 989);
            this.txtCustomerNIC.Name = "txtCustomerNIC";
            this.txtCustomerNIC.Size = new System.Drawing.Size(500, 30);
            this.txtCustomerNIC.TabIndex = 15;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(121, 1167);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(167, 20);
            this.label15.TabIndex = 14;
            this.label15.Text = "Driver License No.";
            // 
            // txtLicenseNo
            // 
            this.txtLicenseNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLicenseNo.Location = new System.Drawing.Point(338, 1160);
            this.txtLicenseNo.Name = "txtLicenseNo";
            this.txtLicenseNo.Size = new System.Drawing.Size(412, 30);
            this.txtLicenseNo.TabIndex = 15;
            // 
            // richTextBox4
            // 
            this.richTextBox4.Location = new System.Drawing.Point(94, 1300);
            this.richTextBox4.Name = "richTextBox4";
            this.richTextBox4.ReadOnly = true;
            this.richTextBox4.Size = new System.Drawing.Size(1372, 96);
            this.richTextBox4.TabIndex = 0;
            this.richTextBox4.Text = "";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(85, 1239);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(363, 58);
            this.label16.TabIndex = 13;
            this.label16.Text = "Rental Information";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(122, 1340);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(212, 20);
            this.label17.TabIndex = 14;
            this.label17.Text = "Choose the Pickup Date";
            // 
            // pickupPicker
            // 
            this.pickupPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pickupPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.pickupPicker.Location = new System.Drawing.Point(375, 1333);
            this.pickupPicker.Name = "pickupPicker";
            this.pickupPicker.Size = new System.Drawing.Size(200, 26);
            this.pickupPicker.TabIndex = 16;
            this.pickupPicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            this.pickupPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pickupPicker_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(822, 1340);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(212, 20);
            this.label18.TabIndex = 14;
            this.label18.Text = "Choose the Return Date";
            // 
            // returnPicker
            // 
            this.returnPicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnPicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.returnPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.returnPicker.Location = new System.Drawing.Point(1077, 1333);
            this.returnPicker.Name = "returnPicker";
            this.returnPicker.Size = new System.Drawing.Size(200, 26);
            this.returnPicker.TabIndex = 16;
            this.returnPicker.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            this.returnPicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.returnPicker_KeyDown);
            // 
            // richTextBox5
            // 
            this.richTextBox5.Location = new System.Drawing.Point(92, 1497);
            this.richTextBox5.Name = "richTextBox5";
            this.richTextBox5.ReadOnly = true;
            this.richTextBox5.Size = new System.Drawing.Size(1372, 168);
            this.richTextBox5.TabIndex = 0;
            this.richTextBox5.Text = "";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(83, 1436);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(364, 58);
            this.label19.TabIndex = 13;
            this.label19.Text = "Additional Services";
            // 
            // checkAddDriver
            // 
            this.checkAddDriver.AutoSize = true;
            this.checkAddDriver.Location = new System.Drawing.Point(375, 1519);
            this.checkAddDriver.Name = "checkAddDriver";
            this.checkAddDriver.Size = new System.Drawing.Size(18, 17);
            this.checkAddDriver.TabIndex = 17;
            this.checkAddDriver.UseVisualStyleBackColor = true;
            // 
            // checkGPS
            // 
            this.checkGPS.AutoSize = true;
            this.checkGPS.Location = new System.Drawing.Point(375, 1566);
            this.checkGPS.Name = "checkGPS";
            this.checkGPS.Size = new System.Drawing.Size(18, 17);
            this.checkGPS.TabIndex = 17;
            this.checkGPS.UseVisualStyleBackColor = true;
            // 
            // checkChildSeat
            // 
            this.checkChildSeat.AutoSize = true;
            this.checkChildSeat.Location = new System.Drawing.Point(375, 1616);
            this.checkChildSeat.Name = "checkChildSeat";
            this.checkChildSeat.Size = new System.Drawing.Size(18, 17);
            this.checkChildSeat.TabIndex = 17;
            this.checkChildSeat.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(121, 1519);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 20);
            this.label20.TabIndex = 14;
            this.label20.Text = "Additional Driver";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(121, 1566);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(47, 20);
            this.label21.TabIndex = 14;
            this.label21.Text = "GPS";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(121, 1614);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(96, 20);
            this.label22.TabIndex = 14;
            this.label22.Text = "Child Seat";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(124, 1491);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(0, 16);
            this.label26.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.Controls.Add(this.label27);
            this.panel1.Controls.Add(this.label25);
            this.panel1.Location = new System.Drawing.Point(92, 1740);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1371, 199);
            this.panel1.TabIndex = 19;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(29, 76);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(1414, 500);
            this.label27.TabIndex = 14;
            this.label27.Text = resources.GetString("label27.Text");
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(28, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(1067, 40);
            this.label25.TabIndex = 14;
            this.label25.Text = resources.GetString("label25.Text");
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(84, 1971);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(318, 58);
            this.label24.TabIndex = 20;
            this.label24.Text = "Special Requests";
            // 
            // checkTerms
            // 
            this.checkTerms.AutoSize = true;
            this.checkTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkTerms.Location = new System.Drawing.Point(1364, 1960);
            this.checkTerms.Name = "checkTerms";
            this.checkTerms.Size = new System.Drawing.Size(99, 24);
            this.checkTerms.TabIndex = 21;
            this.checkTerms.Text = "I agreed";
            this.checkTerms.UseVisualStyleBackColor = true;
            this.checkTerms.CheckedChanged += new System.EventHandler(this.checkTerms_CheckedChanged);
            // 
            // orderNumber
            // 
            this.orderNumber.AutoSize = true;
            this.orderNumber.Location = new System.Drawing.Point(1371, 142);
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Size = new System.Drawing.Size(0, 16);
            this.orderNumber.TabIndex = 23;
            // 
            // txtSpecialReq
            // 
            this.txtSpecialReq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpecialReq.ForeColor = System.Drawing.Color.Red;
            this.txtSpecialReq.Location = new System.Drawing.Point(94, 2055);
            this.txtSpecialReq.Name = "txtSpecialReq";
            this.txtSpecialReq.Size = new System.Drawing.Size(1372, 201);
            this.txtSpecialReq.TabIndex = 24;
            this.txtSpecialReq.Text = " ";
            // 
            // btnConfirmOrder
            // 
            this.btnConfirmOrder.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnConfirmOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmOrder.Location = new System.Drawing.Point(1147, 2281);
            this.btnConfirmOrder.Name = "btnConfirmOrder";
            this.btnConfirmOrder.Size = new System.Drawing.Size(319, 55);
            this.btnConfirmOrder.TabIndex = 25;
            this.btnConfirmOrder.Text = "Confirm My Order";
            this.btnConfirmOrder.UseVisualStyleBackColor = false;
            this.btnConfirmOrder.Click += new System.EventHandler(this.btnConfirmOrder_Click);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Sitka Heading", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(556, 41);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(535, 68);
            this.label30.TabIndex = 10;
            this.label30.Text = "ORDER CONFIRMATION";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(823, 1369);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(0, 16);
            this.label31.TabIndex = 23;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(84, 1668);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(409, 58);
            this.label29.TabIndex = 13;
            this.label29.Text = "Terms and Conditions";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(122, 1539);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(115, 16);
            this.label32.TabIndex = 23;
            this.label32.Text = "Rs.2000 per a day";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(122, 1586);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(97, 16);
            this.label33.TabIndex = 23;
            this.label33.Text = "Rs.500 per day";
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(120, 1638);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(109, 16);
            this.label34.TabIndex = 23;
            this.label34.Text = "Rs.1500 per Seat";
            // 
            // comboSeatCount
            // 
            this.comboSeatCount.FormattingEnabled = true;
            this.comboSeatCount.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboSeatCount.Location = new System.Drawing.Point(592, 1614);
            this.comboSeatCount.Name = "comboSeatCount";
            this.comboSeatCount.Size = new System.Drawing.Size(158, 24);
            this.comboSeatCount.TabIndex = 66;
            this.comboSeatCount.Text = "Number of Seats";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.Red;
            this.lblName.Location = new System.Drawing.Point(1285, 847);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 16);
            this.lblName.TabIndex = 67;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.Red;
            this.lblPhone.Location = new System.Drawing.Point(602, 909);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(0, 16);
            this.lblPhone.TabIndex = 67;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.ForeColor = System.Drawing.Color.Red;
            this.lblAddress.Location = new System.Drawing.Point(602, 970);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(0, 16);
            this.lblAddress.TabIndex = 67;
            this.lblAddress.Click += new System.EventHandler(this.lblAddress_Click);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.ForeColor = System.Drawing.Color.Red;
            this.lblEmail.Location = new System.Drawing.Point(1285, 909);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(0, 16);
            this.lblEmail.TabIndex = 67;
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.ForeColor = System.Drawing.Color.Red;
            this.lblNic.Location = new System.Drawing.Point(1285, 970);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(0, 16);
            this.lblNic.TabIndex = 67;
            // 
            // lblLicense
            // 
            this.lblLicense.AutoSize = true;
            this.lblLicense.ForeColor = System.Drawing.Color.Red;
            this.lblLicense.Location = new System.Drawing.Point(633, 1141);
            this.lblLicense.Name = "lblLicense";
            this.lblLicense.Size = new System.Drawing.Size(0, 16);
            this.lblLicense.TabIndex = 67;
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.ForeColor = System.Drawing.Color.Red;
            this.lblReturn.Location = new System.Drawing.Point(1161, 1369);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(0, 16);
            this.lblReturn.TabIndex = 67;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(94, 207);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(1372, 499);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Sitka Heading", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(83, 135);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(282, 58);
            this.label23.TabIndex = 68;
            this.label23.Text = "Vehicle Details";
            // 
            // lblOrder
            // 
            this.lblOrder.AutoSize = true;
            this.lblOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrder.Location = new System.Drawing.Point(1309, 175);
            this.lblOrder.Name = "lblOrder";
            this.lblOrder.Size = new System.Drawing.Size(0, 18);
            this.lblOrder.TabIndex = 69;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label35.Location = new System.Drawing.Point(120, 251);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(125, 20);
            this.label35.TabIndex = 9;
            this.label35.Text = "Vehicle Name";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::GroupProject.Properties.Resources.Capture;
            this.pictureBox5.Location = new System.Drawing.Point(1374, 41);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(92, 86);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 65;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(903, 296);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Form9
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1585, 900);
            this.Controls.Add(this.lblOrder);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.lblLicense);
            this.Controls.Add(this.lblNic);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.comboSeatCount);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.btnConfirmOrder);
            this.Controls.Add(this.txtSpecialReq);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.orderNumber);
            this.Controls.Add(this.checkTerms);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.checkChildSeat);
            this.Controls.Add(this.checkGPS);
            this.Controls.Add(this.checkAddDriver);
            this.Controls.Add(this.returnPicker);
            this.Controls.Add(this.pickupPicker);
            this.Controls.Add(this.txtCustomerPhone);
            this.Controls.Add(this.txtCustomerNIC);
            this.Controls.Add(this.txtCustomerEmail);
            this.Controls.Add(this.txtLicenseNo);
            this.Controls.Add(this.txtCustomerAddress);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label35);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFuel);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtTransmission);
            this.Controls.Add(this.txtVehicleID);
            this.Controls.Add(this.richTextBox4);
            this.Controls.Add(this.richTextBox5);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form9";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Declaration";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form9_Load);
            ((System.ComponentModel.ISupportInitialize)(this.driveJoy1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private DriveJoy driveJoy1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox txtFuel;
        private System.Windows.Forms.TextBox txtTransmission;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVehicleID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.TextBox txtCustomerPhone;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtCustomerNIC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtLicenseNo;
        private System.Windows.Forms.RichTextBox richTextBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DateTimePicker pickupPicker;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DateTimePicker returnPicker;
        private System.Windows.Forms.RichTextBox richTextBox5;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkAddDriver;
        private System.Windows.Forms.CheckBox checkGPS;
        private System.Windows.Forms.CheckBox checkChildSeat;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.CheckBox checkTerms;
        private System.Windows.Forms.Label orderNumber;
        private System.Windows.Forms.RichTextBox txtSpecialReq;
        private System.Windows.Forms.Button btnConfirmOrder;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comboSeatCount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.Label lblLicense;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblOrder;
        private System.Windows.Forms.Label label35;
    }
}