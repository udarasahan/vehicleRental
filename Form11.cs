using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace GroupProject
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnForm_Click(object sender, EventArgs e)
        {
            Finale objFinale = new Finale();
            objFinale.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 objForm2 = new Form2();
            this.Close();
            objForm2.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Display a confirmation dialog using MessageBox.
            DialogResult result = MessageBox.Show("Are you sure you want to Exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Check the user's response.
            if (result == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
