
namespace Zoo_Management_System
{
    partial class frmEmployeeAddAnimal
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
            this.btnExit = new System.Windows.Forms.Button();
            this.gpbTransferAnimalDetails = new System.Windows.Forms.GroupBox();
            this.txtAnimalHabitat = new System.Windows.Forms.TextBox();
            this.lblAnimalHabiat = new System.Windows.Forms.Label();
            this.gpbAnimalSex = new System.Windows.Forms.GroupBox();
            this.radFemale = new System.Windows.Forms.RadioButton();
            this.radMale = new System.Windows.Forms.RadioButton();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.txtAnimalAge = new System.Windows.Forms.TextBox();
            this.lblAnimalAge = new System.Windows.Forms.Label();
            this.txtAnimalBehavior = new System.Windows.Forms.TextBox();
            this.lblAnimalBehavior = new System.Windows.Forms.Label();
            this.txtAnimalDescription = new System.Windows.Forms.TextBox();
            this.lblAnimalDescription = new System.Windows.Forms.Label();
            this.txtAnimalType = new System.Windows.Forms.TextBox();
            this.lblAnimalType = new System.Windows.Forms.Label();
            this.txtAnimalBreed = new System.Windows.Forms.TextBox();
            this.lblAnimalBreed = new System.Windows.Forms.Label();
            this.txtAnimalCountryofOrigin = new System.Windows.Forms.TextBox();
            this.lblAnimalCountryofOrigin = new System.Windows.Forms.Label();
            this.txtAnimalCountryofOriginPhoto = new System.Windows.Forms.TextBox();
            this.lblAnimalCountryofOriginPhoto = new System.Windows.Forms.Label();
            this.txtAnimalPhoto = new System.Windows.Forms.TextBox();
            this.lblAnimalPhoto = new System.Windows.Forms.Label();
            this.txtAnimalPersonalName = new System.Windows.Forms.TextBox();
            this.lblAnimalPersonalName = new System.Windows.Forms.Label();
            this.lblTitleForm = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.gpbTransferAnimalDetails.SuspendLayout();
            this.gpbAnimalSex.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(352, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbTransferAnimalDetails
            // 
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalHabitat);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalHabiat);
            this.gpbTransferAnimalDetails.Controls.Add(this.gpbAnimalSex);
            this.gpbTransferAnimalDetails.Controls.Add(this.btnTransfer);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalAge);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalAge);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalBehavior);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalBehavior);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalDescription);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalDescription);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalType);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalType);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalBreed);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalBreed);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalCountryofOrigin);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalCountryofOrigin);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalCountryofOriginPhoto);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalCountryofOriginPhoto);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalPhoto);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalPhoto);
            this.gpbTransferAnimalDetails.Controls.Add(this.txtAnimalPersonalName);
            this.gpbTransferAnimalDetails.Controls.Add(this.lblAnimalPersonalName);
            this.gpbTransferAnimalDetails.Location = new System.Drawing.Point(12, 13);
            this.gpbTransferAnimalDetails.Name = "gpbTransferAnimalDetails";
            this.gpbTransferAnimalDetails.Size = new System.Drawing.Size(330, 425);
            this.gpbTransferAnimalDetails.TabIndex = 1;
            this.gpbTransferAnimalDetails.TabStop = false;
            this.gpbTransferAnimalDetails.Text = "Details of the transfer animal:";
            // 
            // txtAnimalHabitat
            // 
            this.txtAnimalHabitat.Location = new System.Drawing.Point(130, 296);
            this.txtAnimalHabitat.Name = "txtAnimalHabitat";
            this.txtAnimalHabitat.Size = new System.Drawing.Size(179, 20);
            this.txtAnimalHabitat.TabIndex = 20;
            // 
            // lblAnimalHabiat
            // 
            this.lblAnimalHabiat.AutoSize = true;
            this.lblAnimalHabiat.Location = new System.Drawing.Point(4, 297);
            this.lblAnimalHabiat.Name = "lblAnimalHabiat";
            this.lblAnimalHabiat.Size = new System.Drawing.Size(110, 13);
            this.lblAnimalHabiat.TabIndex = 19;
            this.lblAnimalHabiat.Text = "Enter animal\'s habitat:";
            this.lblAnimalHabiat.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gpbAnimalSex
            // 
            this.gpbAnimalSex.Controls.Add(this.radFemale);
            this.gpbAnimalSex.Controls.Add(this.radMale);
            this.gpbAnimalSex.Location = new System.Drawing.Point(7, 347);
            this.gpbAnimalSex.Name = "gpbAnimalSex";
            this.gpbAnimalSex.Size = new System.Drawing.Size(118, 72);
            this.gpbAnimalSex.TabIndex = 18;
            this.gpbAnimalSex.TabStop = false;
            this.gpbAnimalSex.Text = "Gender:";
            // 
            // radFemale
            // 
            this.radFemale.AutoSize = true;
            this.radFemale.Location = new System.Drawing.Point(15, 42);
            this.radFemale.Name = "radFemale";
            this.radFemale.Size = new System.Drawing.Size(59, 17);
            this.radFemale.TabIndex = 21;
            this.radFemale.TabStop = true;
            this.radFemale.Text = "Female";
            this.radFemale.UseVisualStyleBackColor = true;
            // 
            // radMale
            // 
            this.radMale.AutoSize = true;
            this.radMale.Location = new System.Drawing.Point(15, 19);
            this.radMale.Name = "radMale";
            this.radMale.Size = new System.Drawing.Size(48, 17);
            this.radMale.TabIndex = 20;
            this.radMale.TabStop = true;
            this.radMale.Text = "Male";
            this.radMale.UseVisualStyleBackColor = true;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(244, 377);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(80, 40);
            this.btnTransfer.TabIndex = 3;
            this.btnTransfer.Text = "Start the Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // txtAnimalAge
            // 
            this.txtAnimalAge.Location = new System.Drawing.Point(130, 270);
            this.txtAnimalAge.Name = "txtAnimalAge";
            this.txtAnimalAge.Size = new System.Drawing.Size(179, 20);
            this.txtAnimalAge.TabIndex = 18;
            // 
            // lblAnimalAge
            // 
            this.lblAnimalAge.AutoSize = true;
            this.lblAnimalAge.Location = new System.Drawing.Point(4, 273);
            this.lblAnimalAge.Name = "lblAnimalAge";
            this.lblAnimalAge.Size = new System.Drawing.Size(96, 13);
            this.lblAnimalAge.TabIndex = 17;
            this.lblAnimalAge.Text = "Enter animal\'s age:";
            // 
            // txtAnimalBehavior
            // 
            this.txtAnimalBehavior.Location = new System.Drawing.Point(130, 244);
            this.txtAnimalBehavior.Name = "txtAnimalBehavior";
            this.txtAnimalBehavior.Size = new System.Drawing.Size(179, 20);
            this.txtAnimalBehavior.TabIndex = 16;
            // 
            // lblAnimalBehavior
            // 
            this.lblAnimalBehavior.AutoSize = true;
            this.lblAnimalBehavior.Location = new System.Drawing.Point(4, 247);
            this.lblAnimalBehavior.Name = "lblAnimalBehavior";
            this.lblAnimalBehavior.Size = new System.Drawing.Size(120, 13);
            this.lblAnimalBehavior.TabIndex = 15;
            this.lblAnimalBehavior.Text = "Enter animal\'s Behavior:";
            // 
            // txtAnimalDescription
            // 
            this.txtAnimalDescription.Location = new System.Drawing.Point(136, 166);
            this.txtAnimalDescription.Multiline = true;
            this.txtAnimalDescription.Name = "txtAnimalDescription";
            this.txtAnimalDescription.Size = new System.Drawing.Size(188, 77);
            this.txtAnimalDescription.TabIndex = 14;
            this.txtAnimalDescription.WordWrap = false;
            // 
            // lblAnimalDescription
            // 
            this.lblAnimalDescription.AutoSize = true;
            this.lblAnimalDescription.Location = new System.Drawing.Point(4, 173);
            this.lblAnimalDescription.Name = "lblAnimalDescription";
            this.lblAnimalDescription.Size = new System.Drawing.Size(129, 13);
            this.lblAnimalDescription.TabIndex = 13;
            this.lblAnimalDescription.Text = "Enter animal\'s description:";
            // 
            // txtAnimalType
            // 
            this.txtAnimalType.Location = new System.Drawing.Point(108, 144);
            this.txtAnimalType.Name = "txtAnimalType";
            this.txtAnimalType.Size = new System.Drawing.Size(179, 20);
            this.txtAnimalType.TabIndex = 12;
            // 
            // lblAnimalType
            // 
            this.lblAnimalType.AutoSize = true;
            this.lblAnimalType.Location = new System.Drawing.Point(4, 151);
            this.lblAnimalType.Name = "lblAnimalType";
            this.lblAnimalType.Size = new System.Drawing.Size(98, 13);
            this.lblAnimalType.TabIndex = 11;
            this.lblAnimalType.Text = "Enter animal\'s type:";
            // 
            // txtAnimalBreed
            // 
            this.txtAnimalBreed.Location = new System.Drawing.Point(115, 117);
            this.txtAnimalBreed.Name = "txtAnimalBreed";
            this.txtAnimalBreed.Size = new System.Drawing.Size(179, 20);
            this.txtAnimalBreed.TabIndex = 10;
            // 
            // lblAnimalBreed
            // 
            this.lblAnimalBreed.AutoSize = true;
            this.lblAnimalBreed.Location = new System.Drawing.Point(4, 124);
            this.lblAnimalBreed.Name = "lblAnimalBreed";
            this.lblAnimalBreed.Size = new System.Drawing.Size(105, 13);
            this.lblAnimalBreed.TabIndex = 9;
            this.lblAnimalBreed.Text = "Enter animal\'s breed:";
            // 
            // txtAnimalCountryofOrigin
            // 
            this.txtAnimalCountryofOrigin.Location = new System.Drawing.Point(165, 92);
            this.txtAnimalCountryofOrigin.Name = "txtAnimalCountryofOrigin";
            this.txtAnimalCountryofOrigin.Size = new System.Drawing.Size(129, 20);
            this.txtAnimalCountryofOrigin.TabIndex = 8;
            // 
            // lblAnimalCountryofOrigin
            // 
            this.lblAnimalCountryofOrigin.AutoSize = true;
            this.lblAnimalCountryofOrigin.Location = new System.Drawing.Point(6, 95);
            this.lblAnimalCountryofOrigin.Name = "lblAnimalCountryofOrigin";
            this.lblAnimalCountryofOrigin.Size = new System.Drawing.Size(153, 13);
            this.lblAnimalCountryofOrigin.TabIndex = 7;
            this.lblAnimalCountryofOrigin.Text = "Enter animal\'s country of origin:";
            // 
            // txtAnimalCountryofOriginPhoto
            // 
            this.txtAnimalCountryofOriginPhoto.Location = new System.Drawing.Point(195, 67);
            this.txtAnimalCountryofOriginPhoto.Name = "txtAnimalCountryofOriginPhoto";
            this.txtAnimalCountryofOriginPhoto.Size = new System.Drawing.Size(99, 20);
            this.txtAnimalCountryofOriginPhoto.TabIndex = 6;
            // 
            // lblAnimalCountryofOriginPhoto
            // 
            this.lblAnimalCountryofOriginPhoto.AutoSize = true;
            this.lblAnimalCountryofOriginPhoto.Location = new System.Drawing.Point(6, 70);
            this.lblAnimalCountryofOriginPhoto.Name = "lblAnimalCountryofOriginPhoto";
            this.lblAnimalCountryofOriginPhoto.Size = new System.Drawing.Size(183, 13);
            this.lblAnimalCountryofOriginPhoto.TabIndex = 5;
            this.lblAnimalCountryofOriginPhoto.Text = "Enter animal\'s country of origin photo:";
            // 
            // txtAnimalPhoto
            // 
            this.txtAnimalPhoto.Location = new System.Drawing.Point(117, 41);
            this.txtAnimalPhoto.Name = "txtAnimalPhoto";
            this.txtAnimalPhoto.Size = new System.Drawing.Size(177, 20);
            this.txtAnimalPhoto.TabIndex = 4;
            this.txtAnimalPhoto.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblAnimalPhoto
            // 
            this.lblAnimalPhoto.AutoSize = true;
            this.lblAnimalPhoto.Location = new System.Drawing.Point(6, 48);
            this.lblAnimalPhoto.Name = "lblAnimalPhoto";
            this.lblAnimalPhoto.Size = new System.Drawing.Size(105, 13);
            this.lblAnimalPhoto.TabIndex = 3;
            this.lblAnimalPhoto.Text = "Enter animal\'s photo:";
            // 
            // txtAnimalPersonalName
            // 
            this.txtAnimalPersonalName.Location = new System.Drawing.Point(159, 18);
            this.txtAnimalPersonalName.Name = "txtAnimalPersonalName";
            this.txtAnimalPersonalName.Size = new System.Drawing.Size(152, 20);
            this.txtAnimalPersonalName.TabIndex = 2;
            // 
            // lblAnimalPersonalName
            // 
            this.lblAnimalPersonalName.AutoSize = true;
            this.lblAnimalPersonalName.Location = new System.Drawing.Point(6, 25);
            this.lblAnimalPersonalName.Name = "lblAnimalPersonalName";
            this.lblAnimalPersonalName.Size = new System.Drawing.Size(147, 13);
            this.lblAnimalPersonalName.TabIndex = 1;
            this.lblAnimalPersonalName.Text = "Enter animal\'s personal name:";
            // 
            // lblTitleForm
            // 
            this.lblTitleForm.AutoSize = true;
            this.lblTitleForm.Location = new System.Drawing.Point(479, 13);
            this.lblTitleForm.Name = "lblTitleForm";
            this.lblTitleForm.Size = new System.Drawing.Size(121, 13);
            this.lblTitleForm.TabIndex = 2;
            this.lblTitleForm.Text = "Acquisition and Transfer";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(431, 337);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(99, 13);
            this.lblError.TabIndex = 17;
            this.lblError.Text = "Error (space holder)";
            this.lblError.Visible = false;
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(352, 38);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(1236, 228);
            this.dgvTable.TabIndex = 18;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(348, 272);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 40);
            this.btnModify.TabIndex = 19;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(520, 272);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 40);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(434, 272);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(80, 40);
            this.btnViewAll.TabIndex = 21;
            this.btnViewAll.Text = "View All";
            this.btnViewAll.UseVisualStyleBackColor = true;
            // 
            // frmEmployeeAddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zoo_Management_System.Properties.Resources.image1;
            this.ClientSize = new System.Drawing.Size(1753, 450);
            this.Controls.Add(this.btnViewAll);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitleForm);
            this.Controls.Add(this.gpbTransferAnimalDetails);
            this.Controls.Add(this.btnExit);
            this.Name = "frmEmployeeAddAnimal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbTransferAnimalDetails.ResumeLayout(false);
            this.gpbTransferAnimalDetails.PerformLayout();
            this.gpbAnimalSex.ResumeLayout(false);
            this.gpbAnimalSex.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gpbTransferAnimalDetails;
        private System.Windows.Forms.TextBox txtAnimalPhoto;
        private System.Windows.Forms.Label lblAnimalPhoto;
        private System.Windows.Forms.TextBox txtAnimalPersonalName;
        private System.Windows.Forms.Label lblAnimalPersonalName;
        private System.Windows.Forms.Label lblTitleForm;
        private System.Windows.Forms.TextBox txtAnimalCountryofOriginPhoto;
        private System.Windows.Forms.Label lblAnimalCountryofOriginPhoto;
        private System.Windows.Forms.GroupBox gpbAnimalSex;
        private System.Windows.Forms.RadioButton radFemale;
        private System.Windows.Forms.RadioButton radMale;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.TextBox txtAnimalAge;
        private System.Windows.Forms.Label lblAnimalAge;
        private System.Windows.Forms.TextBox txtAnimalBehavior;
        private System.Windows.Forms.Label lblAnimalBehavior;
        private System.Windows.Forms.TextBox txtAnimalDescription;
        private System.Windows.Forms.Label lblAnimalDescription;
        private System.Windows.Forms.TextBox txtAnimalType;
        private System.Windows.Forms.Label lblAnimalType;
        private System.Windows.Forms.TextBox txtAnimalBreed;
        private System.Windows.Forms.Label lblAnimalBreed;
        private System.Windows.Forms.TextBox txtAnimalCountryofOrigin;
        private System.Windows.Forms.Label lblAnimalCountryofOrigin;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.TextBox txtAnimalHabitat;
        private System.Windows.Forms.Label lblAnimalHabiat;
    }
}

