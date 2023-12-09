
namespace Zoo_Management_System
{
    partial class frmVisitorAnimals
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
            this.btnLoadAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLoadAnimals
            // 
            this.btnLoadAnimals.Location = new System.Drawing.Point(12, 12);
            this.btnLoadAnimals.Name = "btnLoadAnimals";
            this.btnLoadAnimals.Size = new System.Drawing.Size(112, 53);
            this.btnLoadAnimals.TabIndex = 1;
            this.btnLoadAnimals.Text = "Load Animals";
            this.btnLoadAnimals.UseVisualStyleBackColor = true;
            this.btnLoadAnimals.Click += new System.EventHandler(this.btnLoadAnimals_Click);
            // 
            // frmVisitorAnimals
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 1011);
            this.Controls.Add(this.btnLoadAnimals);
            this.Name = "frmVisitorAnimals";
            this.Text = "frmVisitorAnimals";
            this.Load += new System.EventHandler(this.frmVisitorAnimals_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoadAnimals;
    }
}