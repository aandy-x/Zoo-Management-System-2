
namespace Zoo_Management_System
{
    partial class FrmAddEvents
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
            this.gpbEvent = new System.Windows.Forms.GroupBox();
            this.txtEventDate = new System.Windows.Forms.TextBox();
            this.txtEventImage = new System.Windows.Forms.TextBox();
            this.txtEventDescription = new System.Windows.Forms.TextBox();
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.lblEventImage = new System.Windows.Forms.Label();
            this.lblEventDescription = new System.Windows.Forms.Label();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventName = new System.Windows.Forms.Label();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gpbEvent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEvent
            // 
            this.gpbEvent.Controls.Add(this.txtEventDate);
            this.gpbEvent.Controls.Add(this.txtEventImage);
            this.gpbEvent.Controls.Add(this.txtEventDescription);
            this.gpbEvent.Controls.Add(this.txtEventName);
            this.gpbEvent.Controls.Add(this.lblEventImage);
            this.gpbEvent.Controls.Add(this.lblEventDescription);
            this.gpbEvent.Controls.Add(this.lblEventDate);
            this.gpbEvent.Controls.Add(this.lblEventName);
            this.gpbEvent.Controls.Add(this.btnAddEvent);
            this.gpbEvent.Location = new System.Drawing.Point(12, 39);
            this.gpbEvent.Name = "gpbEvent";
            this.gpbEvent.Size = new System.Drawing.Size(240, 239);
            this.gpbEvent.TabIndex = 0;
            this.gpbEvent.TabStop = false;
            this.gpbEvent.Text = "Create Event";
            // 
            // txtEventDate
            // 
            this.txtEventDate.Location = new System.Drawing.Point(128, 49);
            this.txtEventDate.Name = "txtEventDate";
            this.txtEventDate.Size = new System.Drawing.Size(100, 20);
            this.txtEventDate.TabIndex = 11;
            // 
            // txtEventImage
            // 
            this.txtEventImage.Location = new System.Drawing.Point(128, 75);
            this.txtEventImage.Name = "txtEventImage";
            this.txtEventImage.Size = new System.Drawing.Size(100, 20);
            this.txtEventImage.TabIndex = 10;
            // 
            // txtEventDescription
            // 
            this.txtEventDescription.Location = new System.Drawing.Point(125, 103);
            this.txtEventDescription.Multiline = true;
            this.txtEventDescription.Name = "txtEventDescription";
            this.txtEventDescription.Size = new System.Drawing.Size(100, 111);
            this.txtEventDescription.TabIndex = 9;
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(128, 19);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(100, 20);
            this.txtEventName.TabIndex = 8;
            // 
            // lblEventImage
            // 
            this.lblEventImage.AutoSize = true;
            this.lblEventImage.Location = new System.Drawing.Point(6, 78);
            this.lblEventImage.Name = "lblEventImage";
            this.lblEventImage.Size = new System.Drawing.Size(96, 13);
            this.lblEventImage.TabIndex = 7;
            this.lblEventImage.Text = "Enter event image:";
            // 
            // lblEventDescription
            // 
            this.lblEventDescription.AutoSize = true;
            this.lblEventDescription.Location = new System.Drawing.Point(3, 103);
            this.lblEventDescription.Name = "lblEventDescription";
            this.lblEventDescription.Size = new System.Drawing.Size(116, 13);
            this.lblEventDescription.TabIndex = 6;
            this.lblEventDescription.Text = "Enter event desctipion:";
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(6, 49);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(89, 13);
            this.lblEventDate.TabIndex = 5;
            this.lblEventDate.Text = "Enter event date:";
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(6, 19);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(94, 13);
            this.lblEventName.TabIndex = 4;
            this.lblEventName.Text = "Enter event name:";
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(6, 193);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(80, 40);
            this.btnAddEvent.TabIndex = 3;
            this.btnAddEvent.Text = "Add";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(283, 88);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.Size = new System.Drawing.Size(436, 150);
            this.dgvTable.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblTitle.Location = new System.Drawing.Point(323, 39);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 16);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Create Zoo events";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(335, 284);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(99, 13);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "Error (space holder)";
            this.lblError.Visible = false;
            // 
            // FrmAddEvents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.gpbEvent);
            this.Name = "FrmAddEvents";
            this.Text = "FrmAddEvents";
            this.Load += new System.EventHandler(this.FrmAddEvents_Load);
            this.gpbEvent.ResumeLayout(false);
            this.gpbEvent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEvent;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.TextBox txtEventDate;
        private System.Windows.Forms.TextBox txtEventImage;
        private System.Windows.Forms.TextBox txtEventDescription;
        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.Label lblEventImage;
        private System.Windows.Forms.Label lblEventDescription;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblError;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}