using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMZ_App
{
    public partial class FrmAnimals : Form
    {
        public FrmAnimals()
        {
            InitializeComponent();

            //Changes the colour of the text of the labels in the navigation bar if they are hovered
            foreach (Control ctrl in pnlNavBar.Controls)
            {
                if (ctrl is Label lbl && ctrl != lblOurAnimals) //Excludes the Our Animals label as this is the current form
                {
                    lbl.MouseEnter += (s, e) => lbl.ForeColor = Color.FromArgb(144, 229, 157); //Hover Colour
                    lbl.MouseLeave += (s, e) => lbl.ForeColor = Color.FromArgb(250, 253, 250); //Default Colour
                }
            }
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

        private void btnBookNow_Click(object sender, EventArgs e)
        {
            //Opens the Booking form

            FrmBooking frmBooking = new FrmBooking();
            frmBooking.Show();
            this.Hide();
        }
    }
}
