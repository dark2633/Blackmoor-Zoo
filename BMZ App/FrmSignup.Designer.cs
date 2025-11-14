namespace BMZ_App
{
    partial class FrmSignup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSignup));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.chkEmailOptIn = new System.Windows.Forms.CheckBox();
            this.pnlEmail = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.pnlName = new System.Windows.Forms.Panel();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblLogInCTA = new System.Windows.Forms.Label();
            this.lblAlreadyHaveAccount = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSignUpHeader = new System.Windows.Forms.Label();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.lblOurAnimals = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlSignup.SuspendLayout();
            this.pnlEmail.SuspendLayout();
            this.pnlName.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::BMZ_App.Properties.Resources.Image___Background;
            this.pnlMain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlMain.Controls.Add(this.pnlSignup);
            this.pnlMain.Location = new System.Drawing.Point(23, 133);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1304, 573);
            this.pnlMain.TabIndex = 43;
            // 
            // pnlSignup
            // 
            this.pnlSignup.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignup.BackgroundImage = global::BMZ_App.Properties.Resources.Action_Panel;
            this.pnlSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSignup.Controls.Add(this.chkEmailOptIn);
            this.pnlSignup.Controls.Add(this.pnlEmail);
            this.pnlSignup.Controls.Add(this.lblEmail);
            this.pnlSignup.Controls.Add(this.pnlName);
            this.pnlSignup.Controls.Add(this.lblName);
            this.pnlSignup.Controls.Add(this.lblLogInCTA);
            this.pnlSignup.Controls.Add(this.lblAlreadyHaveAccount);
            this.pnlSignup.Controls.Add(this.btnSubmit);
            this.pnlSignup.Controls.Add(this.pnlPassword);
            this.pnlSignup.Controls.Add(this.lblPassword);
            this.pnlSignup.Controls.Add(this.pnlUsername);
            this.pnlSignup.Controls.Add(this.lblUsername);
            this.pnlSignup.Controls.Add(this.lblSignUpHeader);
            this.pnlSignup.Location = new System.Drawing.Point(438, 20);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(428, 533);
            this.pnlSignup.TabIndex = 39;
            // 
            // chkEmailOptIn
            // 
            this.chkEmailOptIn.AutoSize = true;
            this.chkEmailOptIn.Checked = true;
            this.chkEmailOptIn.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEmailOptIn.Font = new System.Drawing.Font("Inter Light", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEmailOptIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.chkEmailOptIn.Location = new System.Drawing.Point(49, 372);
            this.chkEmailOptIn.Name = "chkEmailOptIn";
            this.chkEmailOptIn.Size = new System.Drawing.Size(330, 28);
            this.chkEmailOptIn.TabIndex = 6;
            this.chkEmailOptIn.Text = "I would like to opt-in to receive emails";
            this.chkEmailOptIn.UseVisualStyleBackColor = true;
            // 
            // pnlEmail
            // 
            this.pnlEmail.BackgroundImage = global::BMZ_App.Properties.Resources.Input_Field;
            this.pnlEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlEmail.Controls.Add(this.txtEmail);
            this.pnlEmail.Location = new System.Drawing.Point(31, 161);
            this.pnlEmail.Name = "pnlEmail";
            this.pnlEmail.Size = new System.Drawing.Size(366, 36);
            this.pnlEmail.TabIndex = 7;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Inter Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.txtEmail.Location = new System.Drawing.Point(3, 3);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(0);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(360, 30);
            this.txtEmail.TabIndex = 2;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Inter Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblEmail.Location = new System.Drawing.Point(27, 134);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 24);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "Email";
            // 
            // pnlName
            // 
            this.pnlName.BackgroundImage = global::BMZ_App.Properties.Resources.Input_Field;
            this.pnlName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlName.Controls.Add(this.txtName);
            this.pnlName.Location = new System.Drawing.Point(31, 83);
            this.pnlName.Name = "pnlName";
            this.pnlName.Size = new System.Drawing.Size(366, 36);
            this.pnlName.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Font = new System.Drawing.Font("Inter Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.txtName.Location = new System.Drawing.Point(3, 3);
            this.txtName.Margin = new System.Windows.Forms.Padding(0);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(360, 30);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Inter Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblName.Location = new System.Drawing.Point(27, 56);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(58, 24);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name";
            // 
            // lblLogInCTA
            // 
            this.lblLogInCTA.AutoSize = true;
            this.lblLogInCTA.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogInCTA.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogInCTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblLogInCTA.Location = new System.Drawing.Point(279, 506);
            this.lblLogInCTA.Name = "lblLogInCTA";
            this.lblLogInCTA.Size = new System.Drawing.Size(53, 22);
            this.lblLogInCTA.TabIndex = 8;
            this.lblLogInCTA.Text = "Log In";
            this.lblLogInCTA.Click += new System.EventHandler(this.lblLogInCTA_Click);
            // 
            // lblAlreadyHaveAccount
            // 
            this.lblAlreadyHaveAccount.AutoSize = true;
            this.lblAlreadyHaveAccount.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlreadyHaveAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblAlreadyHaveAccount.Location = new System.Drawing.Point(97, 506);
            this.lblAlreadyHaveAccount.Name = "lblAlreadyHaveAccount";
            this.lblAlreadyHaveAccount.Size = new System.Drawing.Size(189, 22);
            this.lblAlreadyHaveAccount.TabIndex = 7;
            this.lblAlreadyHaveAccount.Text = "Already have an account?";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackgroundImage = global::BMZ_App.Properties.Resources.Submit_Button;
            this.btnSubmit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.FlatAppearance.BorderSize = 0;
            this.btnSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Inter Medium", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.btnSubmit.Location = new System.Drawing.Point(111, 424);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 57);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackgroundImage = global::BMZ_App.Properties.Resources.Input_Field;
            this.pnlPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPassword.Controls.Add(this.btnShowHide);
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(31, 317);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Size = new System.Drawing.Size(366, 36);
            this.pnlPassword.TabIndex = 5;
            // 
            // btnShowHide
            // 
            this.btnShowHide.BackgroundImage = global::BMZ_App.Properties.Resources.Password_Show_Hide1;
            this.btnShowHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnShowHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShowHide.FlatAppearance.BorderSize = 0;
            this.btnShowHide.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnShowHide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowHide.Location = new System.Drawing.Point(333, 3);
            this.btnShowHide.Name = "btnShowHide";
            this.btnShowHide.Size = new System.Drawing.Size(30, 30);
            this.btnShowHide.TabIndex = 5;
            this.btnShowHide.UseVisualStyleBackColor = true;
            this.btnShowHide.Click += new System.EventHandler(this.btnShowHide_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Inter Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.txtPassword.Location = new System.Drawing.Point(3, 3);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(360, 30);
            this.txtPassword.TabIndex = 4;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Inter Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblPassword.Location = new System.Drawing.Point(27, 290);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(91, 24);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "Password";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackgroundImage = global::BMZ_App.Properties.Resources.Input_Field;
            this.pnlUsername.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Location = new System.Drawing.Point(31, 239);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Size = new System.Drawing.Size(366, 36);
            this.pnlUsername.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Inter Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.txtUsername.Location = new System.Drawing.Point(3, 3);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(360, 30);
            this.txtUsername.TabIndex = 3;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Inter Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblUsername.Location = new System.Drawing.Point(27, 212);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblSignUpHeader
            // 
            this.lblSignUpHeader.AutoSize = true;
            this.lblSignUpHeader.Font = new System.Drawing.Font("Inter SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUpHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblSignUpHeader.Location = new System.Drawing.Point(137, 4);
            this.lblSignUpHeader.Name = "lblSignUpHeader";
            this.lblSignUpHeader.Size = new System.Drawing.Size(154, 50);
            this.lblSignUpHeader.TabIndex = 0;
            this.lblSignUpHeader.Text = "Sign Up";
            // 
            // pnlNavBar
            // 
            this.pnlNavBar.BackgroundImage = global::BMZ_App.Properties.Resources.Navigation_Bar;
            this.pnlNavBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlNavBar.Controls.Add(this.btnSignUp);
            this.pnlNavBar.Controls.Add(this.lblLogIn);
            this.pnlNavBar.Controls.Add(this.lblEvents);
            this.pnlNavBar.Controls.Add(this.lblFacilities);
            this.pnlNavBar.Controls.Add(this.lblOurAnimals);
            this.pnlNavBar.Controls.Add(this.lblAboutUs);
            this.pnlNavBar.Location = new System.Drawing.Point(234, 21);
            this.pnlNavBar.Name = "pnlNavBar";
            this.pnlNavBar.Size = new System.Drawing.Size(1093, 91);
            this.pnlNavBar.TabIndex = 42;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnSignUp.BackgroundImage = global::BMZ_App.Properties.Resources.Sign_Up_button;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnSignUp.FlatAppearance.BorderSize = 0;
            this.btnSignUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnSignUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Inter", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.btnSignUp.Location = new System.Drawing.Point(909, 10);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(174, 70);
            this.btnSignUp.TabIndex = 3;
            this.btnSignUp.Text = "Sign Up!";
            this.btnSignUp.UseVisualStyleBackColor = false;
            // 
            // lblLogIn
            // 
            this.lblLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblLogIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblLogIn.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblLogIn.Location = new System.Drawing.Point(822, 27);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(85, 36);
            this.lblLogIn.TabIndex = 8;
            this.lblLogIn.Text = "Log In";
            this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblLogIn.Click += new System.EventHandler(this.lblLogIn_Click);
            // 
            // lblEvents
            // 
            this.lblEvents.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblEvents.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblEvents.Font = new System.Drawing.Font("Inter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblEvents.Location = new System.Drawing.Point(663, 20);
            this.lblEvents.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblEvents.Name = "lblEvents";
            this.lblEvents.Size = new System.Drawing.Size(121, 48);
            this.lblEvents.TabIndex = 7;
            this.lblEvents.Text = "Events";
            this.lblEvents.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEvents.Click += new System.EventHandler(this.lblEvents_Click);
            // 
            // lblFacilities
            // 
            this.lblFacilities.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblFacilities.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblFacilities.Font = new System.Drawing.Font("Inter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFacilities.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblFacilities.Location = new System.Drawing.Point(467, 20);
            this.lblFacilities.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblFacilities.Name = "lblFacilities";
            this.lblFacilities.Size = new System.Drawing.Size(152, 48);
            this.lblFacilities.TabIndex = 6;
            this.lblFacilities.Text = "Facilities";
            this.lblFacilities.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblFacilities.Click += new System.EventHandler(this.lblFacilities_Click);
            // 
            // lblOurAnimals
            // 
            this.lblOurAnimals.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblOurAnimals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOurAnimals.Font = new System.Drawing.Font("Inter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOurAnimals.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblOurAnimals.Location = new System.Drawing.Point(219, 20);
            this.lblOurAnimals.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblOurAnimals.Name = "lblOurAnimals";
            this.lblOurAnimals.Size = new System.Drawing.Size(204, 48);
            this.lblOurAnimals.TabIndex = 5;
            this.lblOurAnimals.Text = "Our Animals";
            this.lblOurAnimals.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOurAnimals.Click += new System.EventHandler(this.lblOurAnimals_Click);
            // 
            // lblAboutUs
            // 
            this.lblAboutUs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblAboutUs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblAboutUs.Font = new System.Drawing.Font("Inter", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutUs.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblAboutUs.Location = new System.Drawing.Point(15, 20);
            this.lblAboutUs.Margin = new System.Windows.Forms.Padding(22, 0, 22, 0);
            this.lblAboutUs.Name = "lblAboutUs";
            this.lblAboutUs.Size = new System.Drawing.Size(160, 48);
            this.lblAboutUs.TabIndex = 4;
            this.lblAboutUs.Text = "About Us";
            this.lblAboutUs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAboutUs.Click += new System.EventHandler(this.lblAboutUs_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BMZ_App.Properties.Resources.BMZ_Symbol;
            this.picLogo.Location = new System.Drawing.Point(23, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(208, 93);
            this.picLogo.TabIndex = 41;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // FrmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmSignup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.pnlMain.ResumeLayout(false);
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            this.pnlEmail.ResumeLayout(false);
            this.pnlEmail.PerformLayout();
            this.pnlName.ResumeLayout(false);
            this.pnlName.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSignup;
        private System.Windows.Forms.Label lblLogInCTA;
        private System.Windows.Forms.Label lblAlreadyHaveAccount;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSignUpHeader;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.Label lblOurAnimals;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Panel pnlEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.CheckBox chkEmailOptIn;
    }
}