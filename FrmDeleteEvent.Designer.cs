
namespace Zoo_Management_System
{
    partial class FrmDeleteEvent
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
            this.btnTransferOut = new System.Windows.Forms.Button();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTransferOut
            // 
            this.btnTransferOut.Location = new System.Drawing.Point(255, 279);
            this.btnTransferOut.Name = "btnTransferOut";
            this.btnTransferOut.Size = new System.Drawing.Size(80, 40);
            this.btnTransferOut.TabIndex = 22;
            this.btnTransferOut.Text = "Transfer Out";
            this.btnTransferOut.UseVisualStyleBackColor = true;
            this.btnTransferOut.Click += new System.EventHandler(this.btnTransferOut_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(255, 45);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(344, 228);
            this.dgvTable.TabIndex = 23;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(519, 279);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 24;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblTitle.Location = new System.Drawing.Point(341, 26);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(143, 16);
            this.lblTitle.TabIndex = 25;
            this.lblTitle.Text = "Remove Zoo events";
            // 
            // FrmDeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnTransferOut);
            this.Name = "FrmDeleteEvent";
            this.Text = "FrmDeleteEvent";
            this.Load += new System.EventHandler(this.FrmDeleteEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTransferOut;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblTitle;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}