namespace Zoo_Management_System
{
    partial class frmEducationalInfo
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
            this.pbxQuiz1 = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.pbxQuiz2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuiz1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuiz2)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxQuiz1
            // 
            this.pbxQuiz1.Location = new System.Drawing.Point(203, 42);
            this.pbxQuiz1.Name = "pbxQuiz1";
            this.pbxQuiz1.Size = new System.Drawing.Size(307, 376);
            this.pbxQuiz1.TabIndex = 1;
            this.pbxQuiz1.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblTitle.Location = new System.Drawing.Point(447, 9);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(87, 16);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Fun facts!";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 352);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 25;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pbxQuiz2
            // 
            this.pbxQuiz2.Location = new System.Drawing.Point(516, 42);
            this.pbxQuiz2.Name = "pbxQuiz2";
            this.pbxQuiz2.Size = new System.Drawing.Size(307, 376);
            this.pbxQuiz2.TabIndex = 26;
            this.pbxQuiz2.TabStop = false;
            // 
            // frmEducationalInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Zoo_Management_System.Properties.Resources.funfacts;
            this.ClientSize = new System.Drawing.Size(1029, 415);
            this.Controls.Add(this.pbxQuiz2);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbxQuiz1);
            this.Name = "frmEducationalInfo";
            this.Text = "frmEducationalInfo";
            this.Load += new System.EventHandler(this.frmEducationalInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuiz1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxQuiz2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxQuiz1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pbxQuiz2;
    }
}