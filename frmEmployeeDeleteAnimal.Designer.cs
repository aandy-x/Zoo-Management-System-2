
namespace Zoo_Management_System
{
    partial class frmEmployeeDeleteAnimal
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
            this.gpbFilter = new System.Windows.Forms.GroupBox();
            this.cobNickName = new System.Windows.Forms.ComboBox();
            this.lblNickName = new System.Windows.Forms.Label();
            this.lblBreed = new System.Windows.Forms.Label();
            this.cobBreed = new System.Windows.Forms.ComboBox();
            this.lblType = new System.Windows.Forms.Label();
            this.cobAnimalType = new System.Windows.Forms.ComboBox();
            this.btnFilterType = new System.Windows.Forms.Button();
            this.btnFilterBreed = new System.Windows.Forms.Button();
            this.btnFilterNickName = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.gpbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnTransferOut
            // 
            this.btnTransferOut.Location = new System.Drawing.Point(256, 283);
            this.btnTransferOut.Name = "btnTransferOut";
            this.btnTransferOut.Size = new System.Drawing.Size(80, 40);
            this.btnTransferOut.TabIndex = 0;
            this.btnTransferOut.Text = "Transfer Out";
            this.btnTransferOut.UseVisualStyleBackColor = true;
            this.btnTransferOut.Click += new System.EventHandler(this.btnTransferOut_Click);
            // 
            // dgvTable
            // 
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.Location = new System.Drawing.Point(256, 49);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTable.Size = new System.Drawing.Size(344, 228);
            this.dgvTable.TabIndex = 19;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 398);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 20;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gpbFilter
            // 
            this.gpbFilter.Controls.Add(this.btnFilterNickName);
            this.gpbFilter.Controls.Add(this.btnFilterBreed);
            this.gpbFilter.Controls.Add(this.btnFilterType);
            this.gpbFilter.Controls.Add(this.lblType);
            this.gpbFilter.Controls.Add(this.cobAnimalType);
            this.gpbFilter.Controls.Add(this.lblBreed);
            this.gpbFilter.Controls.Add(this.cobBreed);
            this.gpbFilter.Controls.Add(this.lblNickName);
            this.gpbFilter.Controls.Add(this.cobNickName);
            this.gpbFilter.Location = new System.Drawing.Point(13, 49);
            this.gpbFilter.Name = "gpbFilter";
            this.gpbFilter.Size = new System.Drawing.Size(200, 343);
            this.gpbFilter.TabIndex = 21;
            this.gpbFilter.TabStop = false;
            this.gpbFilter.Text = "Filter";
            // 
            // cobNickName
            // 
            this.cobNickName.FormattingEnabled = true;
            this.cobNickName.Location = new System.Drawing.Point(8, 65);
            this.cobNickName.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cobNickName.Name = "cobNickName";
            this.cobNickName.Size = new System.Drawing.Size(92, 21);
            this.cobNickName.TabIndex = 2;
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblNickName.Location = new System.Drawing.Point(5, 46);
            this.lblNickName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(160, 16);
            this.lblNickName.TabIndex = 3;
            this.lblNickName.Text = "Search by nickname:";
            // 
            // lblBreed
            // 
            this.lblBreed.AutoSize = true;
            this.lblBreed.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblBreed.Location = new System.Drawing.Point(3, 149);
            this.lblBreed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBreed.Name = "lblBreed";
            this.lblBreed.Size = new System.Drawing.Size(136, 16);
            this.lblBreed.TabIndex = 5;
            this.lblBreed.Text = "Search by breed:";
            // 
            // cobBreed
            // 
            this.cobBreed.FormattingEnabled = true;
            this.cobBreed.Location = new System.Drawing.Point(6, 168);
            this.cobBreed.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cobBreed.Name = "cobBreed";
            this.cobBreed.Size = new System.Drawing.Size(92, 21);
            this.cobBreed.TabIndex = 4;
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Font = new System.Drawing.Font("SimSun", 12F);
            this.lblType.Location = new System.Drawing.Point(3, 245);
            this.lblType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(128, 16);
            this.lblType.TabIndex = 7;
            this.lblType.Text = "Search by Type:";
            // 
            // cobAnimalType
            // 
            this.cobAnimalType.FormattingEnabled = true;
            this.cobAnimalType.Location = new System.Drawing.Point(6, 264);
            this.cobAnimalType.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cobAnimalType.Name = "cobAnimalType";
            this.cobAnimalType.Size = new System.Drawing.Size(92, 21);
            this.cobAnimalType.TabIndex = 6;
            // 
            // btnFilterType
            // 
            this.btnFilterType.Location = new System.Drawing.Point(6, 297);
            this.btnFilterType.Name = "btnFilterType";
            this.btnFilterType.Size = new System.Drawing.Size(80, 40);
            this.btnFilterType.TabIndex = 22;
            this.btnFilterType.Text = "Filter";
            this.btnFilterType.UseVisualStyleBackColor = true;
            this.btnFilterType.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // btnFilterBreed
            // 
            this.btnFilterBreed.Location = new System.Drawing.Point(6, 195);
            this.btnFilterBreed.Name = "btnFilterBreed";
            this.btnFilterBreed.Size = new System.Drawing.Size(80, 40);
            this.btnFilterBreed.TabIndex = 23;
            this.btnFilterBreed.Text = "Filter";
            this.btnFilterBreed.UseVisualStyleBackColor = true;
            this.btnFilterBreed.Click += new System.EventHandler(this.btnFilterBreed_Click);
            // 
            // btnFilterNickName
            // 
            this.btnFilterNickName.Location = new System.Drawing.Point(6, 92);
            this.btnFilterNickName.Name = "btnFilterNickName";
            this.btnFilterNickName.Size = new System.Drawing.Size(80, 40);
            this.btnFilterNickName.TabIndex = 24;
            this.btnFilterNickName.Text = "Filter";
            this.btnFilterNickName.UseVisualStyleBackColor = true;
            this.btnFilterNickName.Click += new System.EventHandler(this.btnFilterNickName_Click);
            // 
            // frmEmployeeDeleteAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpbFilter);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvTable);
            this.Controls.Add(this.btnTransferOut);
            this.Name = "frmEmployeeDeleteAnimal";
            this.Text = "EmployeeDeleteAnimal";
            this.Load += new System.EventHandler(this.frmEmployeeDeleteAnimal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.gpbFilter.ResumeLayout(false);
            this.gpbFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTransferOut;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gpbFilter;
        private System.Windows.Forms.Button btnFilterType;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.ComboBox cobAnimalType;
        private System.Windows.Forms.Label lblBreed;
        private System.Windows.Forms.ComboBox cobBreed;
        private System.Windows.Forms.Label lblNickName;
        private System.Windows.Forms.ComboBox cobNickName;
        private System.Windows.Forms.Button btnFilterNickName;
        private System.Windows.Forms.Button btnFilterBreed;
    }
}