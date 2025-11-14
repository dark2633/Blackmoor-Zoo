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
    public partial class FrmFacilities : Form
    {
        public FrmFacilities()
        {
            InitializeComponent();

            //Changes the colour of the text of the labels in the navigation bar if they are hovered
            foreach (Control ctrl in pnlNavBar.Controls)
            {
                if (ctrl is Label lbl && ctrl != lblFacilities) //Excludes the Facilities label as this is the current form
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

        private void lblOurAnimals_Click(object sender, EventArgs e)
        {
            //Opens the Our Animals form
            FrmAnimals frmAnimals = new FrmAnimals();
            frmAnimals.Show();
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
