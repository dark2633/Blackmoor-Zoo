using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMZ_App
{
    public partial class FrmSignup : Form
    {
        public FrmSignup()
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

        private void lblLogInCTA_Click(object sender, EventArgs e)
        {
            //Opens the Login form

            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private bool usernameExists(string username)
        {
            //Checks if the entered username already exists and registered to an account

            bool usernameFound = false;

            using (StreamReader sr = new StreamReader("loginInfo.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    //Splits the line into individual sets of data
                    string[] credentials = line.Split(',');

                    if (credentials.Length != 5) continue; //Skip invalid lines - Each line should have 5 parts of information if created using the Signup page

                    //Only stores the username
                    string fileUsername = credentials[2].Trim();

                    if (fileUsername == username)
                    {
                        usernameFound = true;
                    }
                }
            }

            return usernameFound;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Creates variables to store the information entered into the input fields
            string strName = txtName.Text;
            string strEmail = txtEmail.Text;
            string strUsername = txtUsername.Text;
            string strPassword = txtPassword.Text;

            //Checks if all input fields are filled out
            if (string.IsNullOrWhiteSpace(strName) || string.IsNullOrWhiteSpace(strEmail) || string.IsNullOrWhiteSpace(strUsername) || string.IsNullOrWhiteSpace(strPassword))
            {
                MessageBox.Show("All input fields must be filled out.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Creates a variable to store the filepath of the login information
            string filePath = Path.Combine(Environment.CurrentDirectory, "loginInfo.txt");

            if (!usernameExists(strUsername))
            {
                //Writes the information into the text file
                try
                {
                    using (StreamWriter writer = new StreamWriter(filePath, append: true))
                    {
                        if (chkEmailOptIn.Checked)
                        {
                            writer.WriteLine($"{strName},{strEmail},{strUsername},{strPassword},OptIn");
                        }
                        else
                        {
                            writer.WriteLine($"{strName},{strEmail},{strUsername},{strPassword},OptOut");
                        }
                    }

                    MessageBox.Show("Signup Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    //Clears the text boxes
                    txtName.Clear();
                    txtEmail.Clear();
                    txtUsername.Clear();
                    txtPassword.Clear();

                    //Opens the Login form
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error writing to file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                txtUsername.Clear();
                MessageBox.Show("Username already exists.", "Invalid Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
