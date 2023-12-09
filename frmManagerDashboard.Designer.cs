
namespace Zoo_Management_System
{
    partial class frmManagerDashboard
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
            this.btnTransferIn = new System.Windows.Forms.Button();
            this.gpbManageAnimal = new System.Windows.Forms.GroupBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.btnTransferOut = new System.Windows.Forms.Button();
            this.gpbEducational = new System.Windows.Forms.GroupBox();
            this.btnFunFact = new System.Windows.Forms.Button();
            this.btnZooMap = new System.Windows.Forms.Button();
            this.btnLabelingGame = new System.Windows.Forms.Button();
            this.btnQuiz = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnViewEvents = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.gpbManageAnimal.SuspendLayout();
            this.gpbEducational.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(28, 386);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(80, 40);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTransferIn
            // 
            this.btnTransferIn.Location = new System.Drawing.Point(6, 37);
            this.btnTransferIn.Name = "btnTransferIn";
            this.btnTransferIn.Size = new System.Drawing.Size(80, 40);
            this.btnTransferIn.TabIndex = 2;
            this.btnTransferIn.Text = "Transfer In";
            this.btnTransferIn.UseVisualStyleBackColor = true;
            this.btnTransferIn.Click += new System.EventHandler(this.btnTransferIn_Click);
            // 
            // gpbManageAnimal
            // 
            this.gpbManageAnimal.Controls.Add(this.btnModify);
            this.gpbManageAnimal.Controls.Add(this.btnViewAll);
            this.gpbManageAnimal.Controls.Add(this.btnTransferOut);
            this.gpbManageAnimal.Controls.Add(this.btnTransferIn);
            this.gpbManageAnimal.Location = new System.Drawing.Point(26, 75);
            this.gpbManageAnimal.Name = "gpbManageAnimal";
            this.gpbManageAnimal.Size = new System.Drawing.Size(174, 297);
            this.gpbManageAnimal.TabIndex = 3;
            this.gpbManageAnimal.TabStop = false;
            this.gpbManageAnimal.Text = "Animal Management";
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(6, 175);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(80, 40);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(6, 129);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(80, 40);
            this.btnViewAll.TabIndex = 4;
            this.btnViewAll.Text = "View ";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // btnTransferOut
            // 
            this.btnTransferOut.Location = new System.Drawing.Point(6, 83);
            this.btnTransferOut.Name = "btnTransferOut";
            this.btnTransferOut.Size = new System.Drawing.Size(80, 40);
            this.btnTransferOut.TabIndex = 3;
            this.btnTransferOut.Text = "Transfer Out";
            this.btnTransferOut.UseVisualStyleBackColor = true;
            this.btnTransferOut.Click += new System.EventHandler(this.btnTransferOut_Click);
            // 
            // gpbEducational
            // 
            this.gpbEducational.Controls.Add(this.btnFunFact);
            this.gpbEducational.Controls.Add(this.btnZooMap);
            this.gpbEducational.Controls.Add(this.btnLabelingGame);
            this.gpbEducational.Controls.Add(this.btnQuiz);
            this.gpbEducational.Location = new System.Drawing.Point(206, 75);
            this.gpbEducational.Name = "gpbEducational";
            this.gpbEducational.Size = new System.Drawing.Size(180, 297);
            this.gpbEducational.TabIndex = 6;
            this.gpbEducational.TabStop = false;
            this.gpbEducational.Text = "Educational Content and Quiz";
            // 
            // btnFunFact
            // 
            this.btnFunFact.Location = new System.Drawing.Point(6, 175);
            this.btnFunFact.Name = "btnFunFact";
            this.btnFunFact.Size = new System.Drawing.Size(80, 40);
            this.btnFunFact.TabIndex = 5;
            this.btnFunFact.Text = "Fun Facts";
            this.btnFunFact.UseVisualStyleBackColor = true;
            this.btnFunFact.Click += new System.EventHandler(this.btnFunFact_Click);
            // 
            // btnZooMap
            // 
            this.btnZooMap.Location = new System.Drawing.Point(6, 129);
            this.btnZooMap.Name = "btnZooMap";
            this.btnZooMap.Size = new System.Drawing.Size(80, 40);
            this.btnZooMap.TabIndex = 4;
            this.btnZooMap.Text = "Zoo Map";
            this.btnZooMap.UseVisualStyleBackColor = true;
            this.btnZooMap.Click += new System.EventHandler(this.btnZooMap_Click);
            // 
            // btnLabelingGame
            // 
            this.btnLabelingGame.Location = new System.Drawing.Point(6, 83);
            this.btnLabelingGame.Name = "btnLabelingGame";
            this.btnLabelingGame.Size = new System.Drawing.Size(80, 40);
            this.btnLabelingGame.TabIndex = 3;
            this.btnLabelingGame.Text = "Labeling Game";
            this.btnLabelingGame.UseVisualStyleBackColor = true;
            this.btnLabelingGame.Click += new System.EventHandler(this.btnLabelingGame_Click);
            // 
            // btnQuiz
            // 
            this.btnQuiz.Location = new System.Drawing.Point(6, 37);
            this.btnQuiz.Name = "btnQuiz";
            this.btnQuiz.Size = new System.Drawing.Size(80, 40);
            this.btnQuiz.TabIndex = 2;
            this.btnQuiz.Text = "Quiz";
            this.btnQuiz.UseVisualStyleBackColor = true;
            this.btnQuiz.Click += new System.EventHandler(this.btnQuiz_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnViewEvents);
            this.groupBox1.Controls.Add(this.btnDeleteEvent);
            this.groupBox1.Controls.Add(this.btnAddEvent);
            this.groupBox1.Location = new System.Drawing.Point(392, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 297);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Educational Content and Quiz";
            // 
            // btnViewEvents
            // 
            this.btnViewEvents.Location = new System.Drawing.Point(6, 129);
            this.btnViewEvents.Name = "btnViewEvents";
            this.btnViewEvents.Size = new System.Drawing.Size(80, 40);
            this.btnViewEvents.TabIndex = 4;
            this.btnViewEvents.Text = "View Events";
            this.btnViewEvents.UseVisualStyleBackColor = true;
            this.btnViewEvents.Click += new System.EventHandler(this.btnViewEvents_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(6, 83);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(80, 40);
            this.btnDeleteEvent.TabIndex = 3;
            this.btnDeleteEvent.Text = "Delete Event";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(6, 37);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(80, 40);
            this.btnAddEvent.TabIndex = 2;
            this.btnAddEvent.Text = "Add Event";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // frmManagerDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbEducational);
            this.Controls.Add(this.gpbManageAnimal);
            this.Controls.Add(this.btnExit);
            this.Name = "frmManagerDashboard";
            this.Text = "ManagerDashboard";
            this.gpbManageAnimal.ResumeLayout(false);
            this.gpbEducational.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnTransferIn;
        private System.Windows.Forms.GroupBox gpbManageAnimal;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Button btnTransferOut;
        private System.Windows.Forms.GroupBox gpbEducational;
        private System.Windows.Forms.Button btnFunFact;
        private System.Windows.Forms.Button btnZooMap;
        private System.Windows.Forms.Button btnLabelingGame;
        private System.Windows.Forms.Button btnQuiz;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnViewEvents;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Button btnAddEvent;
    }
}