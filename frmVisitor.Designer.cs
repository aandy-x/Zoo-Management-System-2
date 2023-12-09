
namespace Zoo_Management_System
{
    partial class frmVisitor
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
            this.btnEvents = new System.Windows.Forms.Button();
            this.btnAnimals = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEvents
            // 
            this.btnEvents.Location = new System.Drawing.Point(91, 247);
            this.btnEvents.Name = "btnEvents";
            this.btnEvents.Size = new System.Drawing.Size(134, 53);
            this.btnEvents.TabIndex = 3;
            this.btnEvents.Text = "View Events";
            this.btnEvents.UseVisualStyleBackColor = true;
            // 
            // btnAnimals
            // 
            this.btnAnimals.Location = new System.Drawing.Point(91, 175);
            this.btnAnimals.Name = "btnAnimals";
            this.btnAnimals.Size = new System.Drawing.Size(134, 53);
            this.btnAnimals.TabIndex = 2;
            this.btnAnimals.Text = "View Animals";
            this.btnAnimals.UseVisualStyleBackColor = true;
            this.btnAnimals.Click += new System.EventHandler(this.btnAnimals_Click);
            // 
            // frmVisitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 414);
            this.Controls.Add(this.btnEvents);
            this.Controls.Add(this.btnAnimals);
            this.Name = "frmVisitor";
            this.Text = "frmVisitor";
            this.Load += new System.EventHandler(this.frmVisitor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEvents;
        private System.Windows.Forms.Button btnAnimals;
    }
}