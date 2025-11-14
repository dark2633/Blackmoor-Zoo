namespace BMZ_App
{
    partial class FrmBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBooking));
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlSignup = new System.Windows.Forms.Panel();
            this.lblTotalBody = new System.Windows.Forms.Label();
            this.lblTotalHeader = new System.Windows.Forms.Label();
            this.lblSenior = new System.Windows.Forms.Label();
            this.nudSenior = new System.Windows.Forms.NumericUpDown();
            this.lblChild = new System.Windows.Forms.Label();
            this.nudChild = new System.Windows.Forms.NumericUpDown();
            this.lblAdult = new System.Windows.Forms.Label();
            this.nudAdult = new System.Windows.Forms.NumericUpDown();
            this.lblDateSelect = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblVisitorNum = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblBookHeader = new System.Windows.Forms.Label();
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
            ((System.ComponentModel.ISupportInitialize)(this.nudSenior)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChild)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).BeginInit();
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
            this.pnlMain.TabIndex = 46;
            // 
            // pnlSignup
            // 
            this.pnlSignup.BackColor = System.Drawing.Color.Transparent;
            this.pnlSignup.BackgroundImage = global::BMZ_App.Properties.Resources.Action_Panel;
            this.pnlSignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlSignup.Controls.Add(this.lblTotalBody);
            this.pnlSignup.Controls.Add(this.lblTotalHeader);
            this.pnlSignup.Controls.Add(this.lblSenior);
            this.pnlSignup.Controls.Add(this.nudSenior);
            this.pnlSignup.Controls.Add(this.lblChild);
            this.pnlSignup.Controls.Add(this.nudChild);
            this.pnlSignup.Controls.Add(this.lblAdult);
            this.pnlSignup.Controls.Add(this.nudAdult);
            this.pnlSignup.Controls.Add(this.lblDateSelect);
            this.pnlSignup.Controls.Add(this.dtpDate);
            this.pnlSignup.Controls.Add(this.lblVisitorNum);
            this.pnlSignup.Controls.Add(this.btnSubmit);
            this.pnlSignup.Controls.Add(this.lblBookHeader);
            this.pnlSignup.Location = new System.Drawing.Point(438, 61);
            this.pnlSignup.Name = "pnlSignup";
            this.pnlSignup.Size = new System.Drawing.Size(428, 451);
            this.pnlSignup.TabIndex = 39;
            // 
            // lblTotalBody
            // 
            this.lblTotalBody.AutoSize = true;
            this.lblTotalBody.Font = new System.Drawing.Font("Inter", 17.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBody.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblTotalBody.Location = new System.Drawing.Point(237, 315);
            this.lblTotalBody.Name = "lblTotalBody";
            this.lblTotalBody.Size = new System.Drawing.Size(78, 32);
            this.lblTotalBody.TabIndex = 16;
            this.lblTotalBody.Text = "£0.00";
            // 
            // lblTotalHeader
            // 
            this.lblTotalHeader.AutoSize = true;
            this.lblTotalHeader.Font = new System.Drawing.Font("Inter Medium", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblTotalHeader.Location = new System.Drawing.Point(113, 315);
            this.lblTotalHeader.Name = "lblTotalHeader";
            this.lblTotalHeader.Size = new System.Drawing.Size(132, 32);
            this.lblTotalHeader.TabIndex = 15;
            this.lblTotalHeader.Text = "Total Cost:";
            // 
            // lblSenior
            // 
            this.lblSenior.AutoSize = true;
            this.lblSenior.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblSenior.Location = new System.Drawing.Point(27, 260);
            this.lblSenior.Name = "lblSenior";
            this.lblSenior.Size = new System.Drawing.Size(179, 22);
            this.lblSenior.TabIndex = 14;
            this.lblSenior.Text = "Senior (Over 60) - 14.95";
            // 
            // nudSenior
            // 
            this.nudSenior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.nudSenior.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSenior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.nudSenior.Location = new System.Drawing.Point(295, 258);
            this.nudSenior.Name = "nudSenior";
            this.nudSenior.Size = new System.Drawing.Size(107, 26);
            this.nudSenior.TabIndex = 13;
            this.nudSenior.ValueChanged += new System.EventHandler(this.nudSenior_ValueChanged);
            // 
            // lblChild
            // 
            this.lblChild.AutoSize = true;
            this.lblChild.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblChild.Location = new System.Drawing.Point(27, 224);
            this.lblChild.Name = "lblChild";
            this.lblChild.Size = new System.Drawing.Size(179, 22);
            this.lblChild.TabIndex = 12;
            this.lblChild.Text = "Child (Under 16) - £9.95";
            // 
            // nudChild
            // 
            this.nudChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.nudChild.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudChild.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.nudChild.Location = new System.Drawing.Point(295, 222);
            this.nudChild.Name = "nudChild";
            this.nudChild.Size = new System.Drawing.Size(107, 26);
            this.nudChild.TabIndex = 11;
            this.nudChild.ValueChanged += new System.EventHandler(this.nudChild_ValueChanged);
            // 
            // lblAdult
            // 
            this.lblAdult.AutoSize = true;
            this.lblAdult.Font = new System.Drawing.Font("Inter", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.lblAdult.Location = new System.Drawing.Point(27, 188);
            this.lblAdult.Name = "lblAdult";
            this.lblAdult.Size = new System.Drawing.Size(108, 22);
            this.lblAdult.TabIndex = 10;
            this.lblAdult.Text = "Adult - £19.95";
            // 
            // nudAdult
            // 
            this.nudAdult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.nudAdult.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAdult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(17)))), ((int)(((byte)(12)))));
            this.nudAdult.Location = new System.Drawing.Point(295, 186);
            this.nudAdult.Name = "nudAdult";
            this.nudAdult.Size = new System.Drawing.Size(107, 26);
            this.nudAdult.TabIndex = 9;
            this.nudAdult.ValueChanged += new System.EventHandler(this.nudAdult_ValueChanged);
            // 
            // lblDateSelect
            // 
            this.lblDateSelect.AutoSize = true;
            this.lblDateSelect.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblDateSelect.Location = new System.Drawing.Point(26, 97);
            this.lblDateSelect.Name = "lblDateSelect";
            this.lblDateSelect.Size = new System.Drawing.Size(137, 27);
            this.lblDateSelect.TabIndex = 8;
            this.lblDateSelect.Text = "Select a Date:";
            // 
            // dtpDate
            // 
            this.dtpDate.CalendarFont = new System.Drawing.Font("Inter", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.CalendarForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.dtpDate.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dtpDate.CalendarTitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.dtpDate.CalendarTitleForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(253)))), ((int)(((byte)(250)))));
            this.dtpDate.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(229)))), ((int)(((byte)(157)))));
            this.dtpDate.Font = new System.Drawing.Font("Inter Light", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDate.Location = new System.Drawing.Point(217, 98);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(185, 26);
            this.dtpDate.TabIndex = 7;
            // 
            // lblVisitorNum
            // 
            this.lblVisitorNum.AutoSize = true;
            this.lblVisitorNum.Font = new System.Drawing.Font("Inter Medium", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVisitorNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblVisitorNum.Location = new System.Drawing.Point(26, 153);
            this.lblVisitorNum.Name = "lblVisitorNum";
            this.lblVisitorNum.Size = new System.Drawing.Size(185, 27);
            this.lblVisitorNum.TabIndex = 4;
            this.lblVisitorNum.Text = "Number of Visitors:";
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
            this.btnSubmit.Location = new System.Drawing.Point(111, 364);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 57);
            this.btnSubmit.TabIndex = 6;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblBookHeader
            // 
            this.lblBookHeader.AutoSize = true;
            this.lblBookHeader.Font = new System.Drawing.Font("Inter SemiBold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(74)))), ((int)(((byte)(35)))));
            this.lblBookHeader.Location = new System.Drawing.Point(76, 4);
            this.lblBookHeader.Name = "lblBookHeader";
            this.lblBookHeader.Size = new System.Drawing.Size(276, 50);
            this.lblBookHeader.TabIndex = 0;
            this.lblBookHeader.Text = "Book Your Visit";
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
            this.pnlNavBar.TabIndex = 45;
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
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Image = global::BMZ_App.Properties.Resources.BMZ_Symbol;
            this.picLogo.Location = new System.Drawing.Point(23, 20);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(208, 93);
            this.picLogo.TabIndex = 44;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // FrmBooking
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
            this.Name = "FrmBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Booking";
            this.pnlMain.ResumeLayout(false);
            this.pnlSignup.ResumeLayout(false);
            this.pnlSignup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSenior)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudChild)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAdult)).EndInit();
            this.pnlNavBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel pnlSignup;
        private System.Windows.Forms.Label lblVisitorNum;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblBookHeader;
        private System.Windows.Forms.Panel pnlNavBar;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label lblLogIn;
        private System.Windows.Forms.Label lblEvents;
        private System.Windows.Forms.Label lblFacilities;
        private System.Windows.Forms.Label lblOurAnimals;
        private System.Windows.Forms.Label lblAboutUs;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDateSelect;
        private System.Windows.Forms.NumericUpDown nudAdult;
        private System.Windows.Forms.Label lblAdult;
        private System.Windows.Forms.Label lblSenior;
        private System.Windows.Forms.NumericUpDown nudSenior;
        private System.Windows.Forms.Label lblChild;
        private System.Windows.Forms.NumericUpDown nudChild;
        private System.Windows.Forms.Label lblTotalBody;
        private System.Windows.Forms.Label lblTotalHeader;
    }
}