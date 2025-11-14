using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace BMZ_App
{
    public partial class FrmBooking : Form
    {
        public FrmBooking()
        {
            InitializeComponent();

            //Changes the colour of the text of the labels in the navigation bar if they are hovered
            foreach (Control ctrl in pnlNavBar.Controls)
            {
                if (ctrl is Label lbl)
                {
                    lbl.MouseEnter += (s, e) => lbl.ForeColor = Color.FromArgb(144, 229, 157); //Hover Colour
                    lbl.MouseLeave += (s, e) => lbl.ForeColor = Color.FromArgb(250, 253, 250); //Default Colour
                }
            }

            //Sets the min and max date of the DateTimePicker based on the current date
            dtpDate.MinDate = DateTime.Today.AddDays(1);
            dtpDate.MaxDate = DateTime.Today.AddYears(1);
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            //Opens the Home form

            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Hide();
        }
        
        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            //Opens the About Us form

            FrmAbout frmAbout = new FrmAbout();
            frmAbout.Show();
            this.Hide();
        }

        private void lblOurAnimals_Click(object sender, EventArgs e)
        {
            //Opens the Our Animals form

            FrmAnimals frmAnimals = new FrmAnimals();
            frmAnimals.Show();
            this.Hide();
        }

        private void lblFacilities_Click(object sender, EventArgs e)
        {
            //Opens the Facilities form

            FrmFacilities frmFacilities = new FrmFacilities();
            frmFacilities.Show();
            this.Hide();
        }

        private void lblEvents_Click(object sender, EventArgs e)
        {
            //Opens the Events form

            FrmEvents frmEvents = new FrmEvents();
            frmEvents.Show();
            this.Hide();
        }

        private void lblLogIn_Click(object sender, EventArgs e)
        {
            //Opens the Login form

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Opens the Signup form

            FrmSignup frmSignup = new FrmSignup();
            frmSignup.Show();
            this.Hide();
        }

        static double totalCost = 0;

        private void UpdateTotalCost()
        {
            //Calculates the value of the tickets and adds it to the total cost

            totalCost = (Convert.ToDouble(nudAdult.Value) * 19.95) +
                        (Convert.ToDouble(nudChild.Value) * 9.95) +
                        (Convert.ToDouble(nudSenior.Value) * 14.95);

            lblTotalBody.Text = $"£{totalCost:F2}";
        }

        private void nudAdult_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void nudChild_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void nudSenior_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotalCost();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Checks that at least 1 ticket has been added to booking
            if (nudAdult.Value == 0 &&  nudChild.Value == 0 && nudSenior.Value == 0)
            {
                MessageBox.Show("Booking must contain at least 1 ticket", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Creates a variable to store the filepath of the login information
            string filePath = Path.Combine(Environment.CurrentDirectory, "bookingInfo.txt");

            //Writes the information into the text file
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, append: true))
                {
                    writer.WriteLine($"{Globals.username},{dtpDate.Value:dd/MM/yyyy},{nudAdult.Value},{nudChild.Value},{nudSenior.Value},{totalCost}");
                }

                MessageBox.Show("Booking Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Reverts the input fields back to original values
                dtpDate.Value = DateTime.Today.AddDays(1);
                nudAdult.Value = 0;
                nudChild.Value = 0;
                nudSenior .Value = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
