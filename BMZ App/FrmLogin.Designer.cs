namespace BMZ_App
{
    partial class FrmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLogin));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.lblSignUp = new System.Windows.Forms.Label();
            this.lblNewToZoo = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.btnShowHide = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblLoginHeader = new System.Windows.Forms.Label();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.lblOurAnimals = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMain.SuspendLayout();
            this.pnlLogin.SuspendLayout();
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
            this.pnlMain.Controls.Add(this.pnlLogin);
            this.pnlMain.Location = new System.Drawing.Point(23, 133);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1304, 573);
            this.pnlMain.TabIndex = 40;
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Transparent;
            this.pnlLogin.BackgroundImage = global::BMZ_App.Properties.Resources.Action_Panel;
            this.pnlLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlLogin.Controls.Add(this.lblSignUp);
            this.pnlLogin.Controls.Add(this.lblNewToZoo);
            this.pnlLogin.Controls.Add(this.btnSubmit);
            this.pnlLogin.Controls.Add(this.pnlPassword);
            this.pnlLogin.Controls.Add(this.lblPassword);
            this.pnlLogin.Controls.Add(this.pnlUsername);
            this.pnlLogin.Controls.Add(this.lblUsername);
            this.pnlLogin.Controls.Add(this.lblLoginHeader);
            this.pnlLogin.Location = new System.Drawing.Point(438, 62);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(428, 449);
            this.pnlLogin.TabIndex = 39;
            // 
            // lblSignUp
            // 
            this.lblSignUp.AutoSize = true;
            this.lblSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblSignUp.Font = new System.Drawing.Font("Inter SemiBold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSignUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblSignUp.Location = new System.Drawing.Point(263, 422);
            this.lblSignUp.Name = "lblSignUp";
            this.lblSignUp.Size = new System.Drawing.Size(71, 22);
            this.lblSignUp.TabIndex = 8;
            this.lblSignUp.Text = "Sign Up!";
            this.lblSignUp.Click += new System.EventHandler(this.lblSignUp_Click);
            // 
            // lblNewToZoo
            // 
            this.lblNewToZoo.AutoSize = true;
            this.lblNewToZoo.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewToZoo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblNewToZoo.Location = new System.Drawing.Point(94, 422);
            this.lblNewToZoo.Name = "lblNewToZoo";
            this.lblNewToZoo.Size = new System.Drawing.Size(176, 22);
            this.lblNewToZoo.TabIndex = 7;
            this.lblNewToZoo.Text = "New to Blackmoor Zoo?";
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
            this.btnSubmit.Location = new System.Drawing.Point(111, 326);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 57);
            this.btnSubmit.TabIndex = 6;
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
            this.pnlPassword.Location = new System.Drawing.Point(31, 234);
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
            this.btnShowHide.TabIndex = 6;
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
            this.txtPassword.TabIndex = 1;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Inter Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblPassword.Location = new System.Drawing.Point(27, 207);
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
            this.pnlUsername.Location = new System.Drawing.Point(31, 127);
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
            this.txtUsername.TabIndex = 1;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Inter Medium", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblUsername.Location = new System.Drawing.Point(27, 100);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 24);
            this.lblUsername.TabIndex = 2;
            this.lblUsername.Text = "Username";
            // 
            // lblLoginHeader
            // 
            this.lblLoginHeader.AutoSize = true;
            this.lblLoginHeader.Font = new System.Drawing.Font("Inter SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblLoginHeader.Location = new System.Drawing.Point(152, 4);
            this.lblLoginHeader.Name = "lblLoginHeader";
            this.lblLoginHeader.Size = new System.Drawing.Size(125, 50);
            this.lblLoginHeader.TabIndex = 0;
            this.lblLoginHeader.Text = "Log In";
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
            this.pnlNavBar.TabIndex = 36;
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.btnSignUp.BackgroundImage = global::BMZ_App.Properties.Resources.Sign_Up_button;
            this.btnSignUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSignUp.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // lblLogIn
            // 
            this.lblLogIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblLogIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblLogIn.Font = new System.Drawing.Font("Inter", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.lblLogIn.Location = new System.Drawing.Point(822, 27);
            this.lblLogIn.Name = "lblLogIn";
            this.lblLogIn.Size = new System.Drawing.Size(85, 36);
            this.lblLogIn.TabIndex = 8;
            this.lblLogIn.Text = "Log In";
            this.lblLogIn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.picLogo.TabIndex = 35;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // FrmLogin
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
            this.Name = "FrmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pnlMain.ResumeLayout(false);
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.Label lblOurAnimals;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblLoginHeader;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnShowHide;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSignUp;
        private System.Windows.Forms.Label lblNewToZoo;
    }
}