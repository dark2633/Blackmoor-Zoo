namespace BMZ_App
{
    partial class FrmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnBookNow = new System.Windows.Forms.Button();
            this.picHeroImage = new System.Windows.Forms.PictureBox();
            this.pnlNavBar = new System.Windows.Forms.Panel();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.lblLogIn = new System.Windows.Forms.Label();
            this.lblEvents = new System.Windows.Forms.Label();
            this.lblFacilities = new System.Windows.Forms.Label();
            this.lblOurAnimals = new System.Windows.Forms.Label();
            this.lblAboutUs = new System.Windows.Forms.Label();
            this.picLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picHeroImage)).BeginInit();
            this.pnlNavBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Font = new System.Drawing.Font("Inter", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblWelcome.Location = new System.Drawing.Point(23, 504);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(1304, 68);
            this.lblWelcome.TabIndex = 3;
            this.lblWelcome.Text = "Welcome to Blackmoor Zoo!";
            this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBookNow
            // 
            this.btnBookNow.BackgroundImage = global::BMZ_App.Properties.Resources.Book_Now_button;
            this.btnBookNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBookNow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookNow.FlatAppearance.BorderSize = 0;
            this.btnBookNow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBookNow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBookNow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookNow.Font = new System.Drawing.Font("Inter", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookNow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.btnBookNow.Location = new System.Drawing.Point(498, 596);
            this.btnBookNow.Name = "btnBookNow";
            this.btnBookNow.Size = new System.Drawing.Size(354, 94);
            this.btnBookNow.TabIndex = 4;
            this.btnBookNow.Text = "Book Now";
            this.btnBookNow.UseVisualStyleBackColor = true;
            this.btnBookNow.Click += new System.EventHandler(this.btnBookNow_Click);
            // 
            // picHeroImage
            // 
            this.picHeroImage.BackgroundImage = global::BMZ_App.Properties.Resources.Hero_Image;
            this.picHeroImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picHeroImage.Location = new System.Drawing.Point(23, 143);
            this.picHeroImage.Name = "picHeroImage";
            this.picHeroImage.Size = new System.Drawing.Size(1304, 339);
            this.picHeroImage.TabIndex = 2;
            this.picHeroImage.TabStop = false;
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
            this.pnlNavBar.TabIndex = 1;
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
            this.picLogo.Image = global::BMZ_App.Properties.Resources.BMZ_Symbol;
            this.picLogo.Location = new System.Drawing.Point(23, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(208, 93);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.btnBookNow);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picHeroImage);
            this.Controls.Add(this.pnlNavBar);
            this.Controls.Add(this.picLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            ((System.ComponentModel.ISupportInitialize)(this.picHeroImage)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.PictureBox picHeroImage;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.Label lblOurAnimals;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBookNow;
    }
}

