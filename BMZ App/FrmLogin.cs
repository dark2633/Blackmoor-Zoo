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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            //Changes the colour of the text of the labels in the navigation bar if they are hovered
            foreach (Control ctrl in pnlNavBar.Controls)
            {
                if (ctrl is Label lbl && ctrl != lblLogIn) //Excludes the Login label as this is the current form
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

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            //Opens the Signup form

            FrmSignup frmSignup = new FrmSignup();
            frmSignup.Show();
            this.Hide();
        }

        private void lblSignUp_Click(object sender, EventArgs e)
        {
            //Opens the Signup form

            FrmSignup frmSignup = new FrmSignup();
            frmSignup.Show();
            this.Hide();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            if (txtPassword.PasswordChar != '\0')
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Creates variables to store the information entered into the input fields
            string enteredUsername = txtUsername.Text;
            string enteredPassword = txtPassword.Text;

            bool usernameFound = false;

            //Attempts to find the entered username and password combination entered by the user in the loginInfo file
            try
            {
                using (StreamReader sr = new StreamReader("loginInfo.txt"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        //Splits the line into individual sets of data
                        string[] credentials = line.Split(',');

                        if (credentials.Length != 5) continue; //Skip invalid lines - Each line should have 5 parts of information if created using the Signup page

                        //Only stores the username and password
                        string fileUsername = credentials[2].Trim();
                        string filePassword = credentials[3].Trim();

                        if (fileUsername == enteredUsername)
                        {
                            usernameFound = true;

                            if (filePassword == enteredPassword)
                            {
                                //Clears the text boxes
                                txtUsername.Clear();
                                txtPassword.Clear();

                                //Updates the global variables to store the info of the current user
                                Globals.name = credentials[0];
                                Globals.username = fileUsername;

                                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                //Opens the Home form
                                FrmHome frmHome = new FrmHome();
                                frmHome.Show();
                                this.Hide();
                                return;
                            }
                            else
                            {
                                MessageBox.Show("Password incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }
                    }
                }

                if (!usernameFound)
                {
                    MessageBox.Show("Username doesn't exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            catch (FileNotFoundException)
            {
                MessageBox.Show("Logins file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
