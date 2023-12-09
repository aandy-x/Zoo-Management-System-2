
namespace Zoo_Management_System
{
    partial class frmSignUp
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
            this.gBoxRegister = new System.Windows.Forms.GroupBox();
            this.txtBoxAccountEmployeePhoto = new System.Windows.Forms.TextBox();
            this.lblAccountEmployeePhoto = new System.Windows.Forms.Label();
            this.cBoxAccountEmployeeType = new System.Windows.Forms.ComboBox();
            this.lblAccountEmployeeType = new System.Windows.Forms.Label();
            this.txtBoxAccountCountry = new System.Windows.Forms.TextBox();
            this.lblAccountCountry = new System.Windows.Forms.Label();
            this.txtBoxAccountUserName = new System.Windows.Forms.TextBox();
            this.lblAccountUserName = new System.Windows.Forms.Label();
            this.mTxtBoxAccountPhone = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxAccountZip = new System.Windows.Forms.MaskedTextBox();
            this.mTxtBoxAccountState = new System.Windows.Forms.MaskedTextBox();
            this.lblAccountType = new System.Windows.Forms.Label();
            this.cBoxAccountType = new System.Windows.Forms.ComboBox();
            this.txtBoxAccountAddress = new System.Windows.Forms.TextBox();
            this.lblAccountAddress = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtBoxAccountPassword = new System.Windows.Forms.TextBox();
            this.lblAccountPassword = new System.Windows.Forms.Label();
            this.txtBoxAccountEmail = new System.Windows.Forms.TextBox();
            this.lblAccountEmail = new System.Windows.Forms.Label();
            this.lblAccountPhone = new System.Windows.Forms.Label();
            this.lblAccountZip = new System.Windows.Forms.Label();
            this.lblAccountState = new System.Windows.Forms.Label();
            this.txtBoxAccountCity = new System.Windows.Forms.TextBox();
            this.lblAccountCity = new System.Windows.Forms.Label();
            this.txtBoxAccountLName = new System.Windows.Forms.TextBox();
            this.lblAccountLName = new System.Windows.Forms.Label();
            this.txtboxAccountFName = new System.Windows.Forms.TextBox();
            this.lblAccountFName = new System.Windows.Forms.Label();
            this.gBoxRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBoxRegister
            // 
            this.gBoxRegister.Controls.Add(this.txtBoxAccountEmployeePhoto);
            this.gBoxRegister.Controls.Add(this.lblAccountEmployeePhoto);
            this.gBoxRegister.Controls.Add(this.cBoxAccountEmployeeType);
            this.gBoxRegister.Controls.Add(this.lblAccountEmployeeType);
            this.gBoxRegister.Controls.Add(this.txtBoxAccountCountry);
            this.gBoxRegister.Controls.Add(this.lblAccountCountry);
            this.gBoxRegister.Controls.Add(this.txtBoxAccountUserName);
            this.gBoxRegister.Controls.Add(this.lblAccountUserName);
            this.gBoxRegister.Controls.Add(this.mTxtBoxAccountPhone);
            this.gBoxRegister.Controls.Add(this.mTxtBoxAccountZip);
            this.gBoxRegister.Controls.Add(this.mTxtBoxAccountState);
            this.gBoxRegister.Controls.Add(this.lblAccountType);
            this.gBoxRegister.Controls.Add(this.cBoxAccountType);
            this.gBoxRegister.Controls.Add(this.txtBoxAccountAddress);
            this.gBoxRegister.Controls.Add(this.lblAccountAddress);
            this.gBoxRegister.Controls.Add(this.btnSubmit);
            this.gBoxRegister.Controls.Add(this.txtBoxAccountPassword);
            this.gBoxRegister.Controls.Add(this.lblAccountPassword);
            this.gBoxRegister.Controls.Add(this.txtBoxAccountEmail);
            this.gBoxRegister.Controls.Add(this.lblAccountEmail);
            this.gBoxRegister.Controls.Add(this.lblAccountPhone);
            this.gBoxRegister.Controls.Add(this.lblAccountZip);
            this.gBoxRegister.Controls.Add(this.lblAccountState);
            this.gBoxRegister.Controls.Add(this.txtBoxAccountCity);
            this.gBoxRegister.Controls.Add(this.lblAccountCity);
            this.gBoxRegister.Controls.Add(this.txtBoxAccountLName);
            this.gBoxRegister.Controls.Add(this.lblAccountLName);
            this.gBoxRegister.Controls.Add(this.txtboxAccountFName);
            this.gBoxRegister.Controls.Add(this.lblAccountFName);
            this.gBoxRegister.Location = new System.Drawing.Point(9, 11);
            this.gBoxRegister.Name = "gBoxRegister";
            this.gBoxRegister.Size = new System.Drawing.Size(330, 474);
            this.gBoxRegister.TabIndex = 3;
            this.gBoxRegister.TabStop = false;
            this.gBoxRegister.Text = "Create an account";
            // 
            // txtBoxAccountEmployeePhoto
            // 
            this.txtBoxAccountEmployeePhoto.Location = new System.Drawing.Point(160, 364);
            this.txtBoxAccountEmployeePhoto.Name = "txtBoxAccountEmployeePhoto";
            this.txtBoxAccountEmployeePhoto.Size = new System.Drawing.Size(151, 20);
            this.txtBoxAccountEmployeePhoto.TabIndex = 33;
            this.txtBoxAccountEmployeePhoto.Visible = false;
            // 
            // lblAccountEmployeePhoto
            // 
            this.lblAccountEmployeePhoto.AutoSize = true;
            this.lblAccountEmployeePhoto.Location = new System.Drawing.Point(12, 367);
            this.lblAccountEmployeePhoto.Name = "lblAccountEmployeePhoto";
            this.lblAccountEmployeePhoto.Size = new System.Drawing.Size(143, 13);
            this.lblAccountEmployeePhoto.TabIndex = 32;
            this.lblAccountEmployeePhoto.Text = "Enter Employee Photo URL: ";
            this.lblAccountEmployeePhoto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAccountEmployeePhoto.Visible = false;
            // 
            // cBoxAccountEmployeeType
            // 
            this.cBoxAccountEmployeeType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAccountEmployeeType.FormattingEnabled = true;
            this.cBoxAccountEmployeeType.Items.AddRange(new object[] {
            "Animal Staff",
            "Manager"});
            this.cBoxAccountEmployeeType.Location = new System.Drawing.Point(127, 337);
            this.cBoxAccountEmployeeType.Name = "cBoxAccountEmployeeType";
            this.cBoxAccountEmployeeType.Size = new System.Drawing.Size(184, 21);
            this.cBoxAccountEmployeeType.TabIndex = 31;
            this.cBoxAccountEmployeeType.Visible = false;
            // 
            // lblAccountEmployeeType
            // 
            this.lblAccountEmployeeType.AutoSize = true;
            this.lblAccountEmployeeType.Location = new System.Drawing.Point(11, 340);
            this.lblAccountEmployeeType.Name = "lblAccountEmployeeType";
            this.lblAccountEmployeeType.Size = new System.Drawing.Size(116, 13);
            this.lblAccountEmployeeType.TabIndex = 30;
            this.lblAccountEmployeeType.Text = "Select Employee Type:";
            this.lblAccountEmployeeType.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAccountEmployeeType.Visible = false;
            // 
            // txtBoxAccountCountry
            // 
            this.txtBoxAccountCountry.Location = new System.Drawing.Point(127, 311);
            this.txtBoxAccountCountry.Name = "txtBoxAccountCountry";
            this.txtBoxAccountCountry.Size = new System.Drawing.Size(184, 20);
            this.txtBoxAccountCountry.TabIndex = 29;
            // 
            // lblAccountCountry
            // 
            this.lblAccountCountry.AutoSize = true;
            this.lblAccountCountry.Location = new System.Drawing.Point(12, 314);
            this.lblAccountCountry.Name = "lblAccountCountry";
            this.lblAccountCountry.Size = new System.Drawing.Size(77, 13);
            this.lblAccountCountry.TabIndex = 28;
            this.lblAccountCountry.Text = "Enter Country: ";
            this.lblAccountCountry.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBoxAccountUserName
            // 
            this.txtBoxAccountUserName.Location = new System.Drawing.Point(127, 233);
            this.txtBoxAccountUserName.Name = "txtBoxAccountUserName";
            this.txtBoxAccountUserName.Size = new System.Drawing.Size(184, 20);
            this.txtBoxAccountUserName.TabIndex = 27;
            // 
            // lblAccountUserName
            // 
            this.lblAccountUserName.AutoSize = true;
            this.lblAccountUserName.Location = new System.Drawing.Point(12, 236);
            this.lblAccountUserName.Name = "lblAccountUserName";
            this.lblAccountUserName.Size = new System.Drawing.Size(86, 13);
            this.lblAccountUserName.TabIndex = 26;
            this.lblAccountUserName.Text = "Enter Username:";
            // 
            // mTxtBoxAccountPhone
            // 
            this.mTxtBoxAccountPhone.Location = new System.Drawing.Point(127, 181);
            this.mTxtBoxAccountPhone.Mask = "(999) 000-0000";
            this.mTxtBoxAccountPhone.Name = "mTxtBoxAccountPhone";
            this.mTxtBoxAccountPhone.Size = new System.Drawing.Size(184, 20);
            this.mTxtBoxAccountPhone.TabIndex = 25;
            // 
            // mTxtBoxAccountZip
            // 
            this.mTxtBoxAccountZip.Location = new System.Drawing.Point(127, 155);
            this.mTxtBoxAccountZip.Mask = "00000-9999";
            this.mTxtBoxAccountZip.Name = "mTxtBoxAccountZip";
            this.mTxtBoxAccountZip.Size = new System.Drawing.Size(184, 20);
            this.mTxtBoxAccountZip.TabIndex = 24;
            // 
            // mTxtBoxAccountState
            // 
            this.mTxtBoxAccountState.Location = new System.Drawing.Point(127, 128);
            this.mTxtBoxAccountState.Mask = "aa";
            this.mTxtBoxAccountState.Name = "mTxtBoxAccountState";
            this.mTxtBoxAccountState.Size = new System.Drawing.Size(184, 20);
            this.mTxtBoxAccountState.TabIndex = 23;
            // 
            // lblAccountType
            // 
            this.lblAccountType.AutoSize = true;
            this.lblAccountType.Location = new System.Drawing.Point(11, 27);
            this.lblAccountType.Name = "lblAccountType";
            this.lblAccountType.Size = new System.Drawing.Size(110, 13);
            this.lblAccountType.TabIndex = 22;
            this.lblAccountType.Text = "Select Account Type:";
            // 
            // cBoxAccountType
            // 
            this.cBoxAccountType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBoxAccountType.FormattingEnabled = true;
            this.cBoxAccountType.Items.AddRange(new object[] {
            "Visitor",
            "Employee"});
            this.cBoxAccountType.Location = new System.Drawing.Point(127, 24);
            this.cBoxAccountType.Name = "cBoxAccountType";
            this.cBoxAccountType.Size = new System.Drawing.Size(184, 21);
            this.cBoxAccountType.TabIndex = 21;
            // 
            // txtBoxAccountAddress
            // 
            this.txtBoxAccountAddress.Location = new System.Drawing.Point(127, 285);
            this.txtBoxAccountAddress.Name = "txtBoxAccountAddress";
            this.txtBoxAccountAddress.Size = new System.Drawing.Size(184, 20);
            this.txtBoxAccountAddress.TabIndex = 20;
            // 
            // lblAccountAddress
            // 
            this.lblAccountAddress.AutoSize = true;
            this.lblAccountAddress.Location = new System.Drawing.Point(12, 288);
            this.lblAccountAddress.Name = "lblAccountAddress";
            this.lblAccountAddress.Size = new System.Drawing.Size(76, 13);
            this.lblAccountAddress.TabIndex = 19;
            this.lblAccountAddress.Text = "Enter Address:";
            this.lblAccountAddress.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(118, 403);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 40);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Create Account";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtBoxAccountPassword
            // 
            this.txtBoxAccountPassword.Location = new System.Drawing.Point(127, 259);
            this.txtBoxAccountPassword.Name = "txtBoxAccountPassword";
            this.txtBoxAccountPassword.Size = new System.Drawing.Size(184, 20);
            this.txtBoxAccountPassword.TabIndex = 18;
            // 
            // lblAccountPassword
            // 
            this.lblAccountPassword.AutoSize = true;
            this.lblAccountPassword.Location = new System.Drawing.Point(12, 262);
            this.lblAccountPassword.Name = "lblAccountPassword";
            this.lblAccountPassword.Size = new System.Drawing.Size(84, 13);
            this.lblAccountPassword.TabIndex = 17;
            this.lblAccountPassword.Text = "Enter Password:";
            // 
            // txtBoxAccountEmail
            // 
            this.txtBoxAccountEmail.Location = new System.Drawing.Point(127, 207);
            this.txtBoxAccountEmail.Name = "txtBoxAccountEmail";
            this.txtBoxAccountEmail.Size = new System.Drawing.Size(184, 20);
            this.txtBoxAccountEmail.TabIndex = 16;
            // 
            // lblAccountEmail
            // 
            this.lblAccountEmail.AutoSize = true;
            this.lblAccountEmail.Location = new System.Drawing.Point(11, 210);
            this.lblAccountEmail.Name = "lblAccountEmail";
            this.lblAccountEmail.Size = new System.Drawing.Size(104, 13);
            this.lblAccountEmail.TabIndex = 15;
            this.lblAccountEmail.Text = "Enter Email Address:";
            // 
            // lblAccountPhone
            // 
            this.lblAccountPhone.AutoSize = true;
            this.lblAccountPhone.Location = new System.Drawing.Point(11, 184);
            this.lblAccountPhone.Name = "lblAccountPhone";
            this.lblAccountPhone.Size = new System.Drawing.Size(109, 13);
            this.lblAccountPhone.TabIndex = 11;
            this.lblAccountPhone.Text = "Enter Phone Number:";
            // 
            // lblAccountZip
            // 
            this.lblAccountZip.AutoSize = true;
            this.lblAccountZip.Location = new System.Drawing.Point(11, 158);
            this.lblAccountZip.Name = "lblAccountZip";
            this.lblAccountZip.Size = new System.Drawing.Size(81, 13);
            this.lblAccountZip.TabIndex = 9;
            this.lblAccountZip.Text = "Enter Zip Code:";
            // 
            // lblAccountState
            // 
            this.lblAccountState.AutoSize = true;
            this.lblAccountState.Location = new System.Drawing.Point(11, 131);
            this.lblAccountState.Name = "lblAccountState";
            this.lblAccountState.Size = new System.Drawing.Size(63, 13);
            this.lblAccountState.TabIndex = 7;
            this.lblAccountState.Text = "Enter State:";
            // 
            // txtBoxAccountCity
            // 
            this.txtBoxAccountCity.Location = new System.Drawing.Point(127, 103);
            this.txtBoxAccountCity.Name = "txtBoxAccountCity";
            this.txtBoxAccountCity.Size = new System.Drawing.Size(184, 20);
            this.txtBoxAccountCity.TabIndex = 6;
            // 
            // lblAccountCity
            // 
            this.lblAccountCity.AutoSize = true;
            this.lblAccountCity.Location = new System.Drawing.Point(11, 106);
            this.lblAccountCity.Name = "lblAccountCity";
            this.lblAccountCity.Size = new System.Drawing.Size(55, 13);
            this.lblAccountCity.TabIndex = 5;
            this.lblAccountCity.Text = "Enter City:";
            // 
            // txtBoxAccountLName
            // 
            this.txtBoxAccountLName.Location = new System.Drawing.Point(127, 77);
            this.txtBoxAccountLName.Name = "txtBoxAccountLName";
            this.txtBoxAccountLName.Size = new System.Drawing.Size(184, 20);
            this.txtBoxAccountLName.TabIndex = 4;
            // 
            // lblAccountLName
            // 
            this.lblAccountLName.AutoSize = true;
            this.lblAccountLName.Location = new System.Drawing.Point(11, 80);
            this.lblAccountLName.Name = "lblAccountLName";
            this.lblAccountLName.Size = new System.Drawing.Size(89, 13);
            this.lblAccountLName.TabIndex = 3;
            this.lblAccountLName.Text = "Enter Last Name:";
            // 
            // txtboxAccountFName
            // 
            this.txtboxAccountFName.Location = new System.Drawing.Point(127, 51);
            this.txtboxAccountFName.Name = "txtboxAccountFName";
            this.txtboxAccountFName.Size = new System.Drawing.Size(184, 20);
            this.txtboxAccountFName.TabIndex = 2;
            // 
            // lblAccountFName
            // 
            this.lblAccountFName.AutoSize = true;
            this.lblAccountFName.Location = new System.Drawing.Point(11, 54);
            this.lblAccountFName.Name = "lblAccountFName";
            this.lblAccountFName.Size = new System.Drawing.Size(88, 13);
            this.lblAccountFName.TabIndex = 1;
            this.lblAccountFName.Text = "Enter First Name:";
            // 
            // frmSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 497);
            this.Controls.Add(this.gBoxRegister);
            this.Name = "frmSignUp";
            this.Text = "frmSignUp";
            this.Load += new System.EventHandler(this.frmSignUp_Load);
            this.gBoxRegister.ResumeLayout(false);
            this.gBoxRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBoxRegister;
        private System.Windows.Forms.TextBox txtBoxAccountEmployeePhoto;
        private System.Windows.Forms.Label lblAccountEmployeePhoto;
        private System.Windows.Forms.ComboBox cBoxAccountEmployeeType;
        private System.Windows.Forms.Label lblAccountEmployeeType;
        private System.Windows.Forms.TextBox txtBoxAccountCountry;
        private System.Windows.Forms.Label lblAccountCountry;
        private System.Windows.Forms.TextBox txtBoxAccountUserName;
        private System.Windows.Forms.Label lblAccountUserName;
        private System.Windows.Forms.MaskedTextBox mTxtBoxAccountPhone;
        private System.Windows.Forms.MaskedTextBox mTxtBoxAccountZip;
        private System.Windows.Forms.MaskedTextBox mTxtBoxAccountState;
        private System.Windows.Forms.Label lblAccountType;
        private System.Windows.Forms.ComboBox cBoxAccountType;
        private System.Windows.Forms.TextBox txtBoxAccountAddress;
        private System.Windows.Forms.Label lblAccountAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox txtBoxAccountPassword;
        private System.Windows.Forms.Label lblAccountPassword;
        private System.Windows.Forms.TextBox txtBoxAccountEmail;
        private System.Windows.Forms.Label lblAccountEmail;
        private System.Windows.Forms.Label lblAccountPhone;
        private System.Windows.Forms.Label lblAccountZip;
        private System.Windows.Forms.Label lblAccountState;
        private System.Windows.Forms.TextBox txtBoxAccountCity;
        private System.Windows.Forms.Label lblAccountCity;
        private System.Windows.Forms.TextBox txtBoxAccountLName;
        private System.Windows.Forms.Label lblAccountLName;
        private System.Windows.Forms.TextBox txtboxAccountFName;
        private System.Windows.Forms.Label lblAccountFName;
    }
}