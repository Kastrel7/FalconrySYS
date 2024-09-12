namespace FalconrySYS
{
    partial class frmRemoveBooking
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblNoP = new System.Windows.Forms.Label();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblExperienceType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.lblNameFind = new System.Windows.Forms.Label();
            this.txtEmailFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpBooking.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1636, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuRemoveBooking";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(83, 44);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.lblStatus);
            this.grpBooking.Controls.Add(this.lblID);
            this.grpBooking.Controls.Add(this.label9);
            this.grpBooking.Controls.Add(this.label8);
            this.grpBooking.Controls.Add(this.lblNoP);
            this.grpBooking.Controls.Add(this.lblTime);
            this.grpBooking.Controls.Add(this.lblDate);
            this.grpBooking.Controls.Add(this.lblExperienceType);
            this.grpBooking.Controls.Add(this.label4);
            this.grpBooking.Controls.Add(this.label3);
            this.grpBooking.Controls.Add(this.label2);
            this.grpBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooking.Location = new System.Drawing.Point(268, 197);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(500, 700);
            this.grpBooking.TabIndex = 6;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking Details";
            this.grpBooking.Visible = false;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(246, 103);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(108, 37);
            this.lblStatus.TabIndex = 15;
            this.lblStatus.Text = "label8";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(6, 103);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(108, 37);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(247, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 33);
            this.label9.TabIndex = 13;
            this.label9.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 33);
            this.label8.TabIndex = 12;
            this.label8.Text = "Booking ID";
            // 
            // lblNoP
            // 
            this.lblNoP.AutoSize = true;
            this.lblNoP.Location = new System.Drawing.Point(6, 523);
            this.lblNoP.Name = "lblNoP";
            this.lblNoP.Size = new System.Drawing.Size(123, 37);
            this.lblNoP.TabIndex = 8;
            this.lblNoP.Text = "label11";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(180, 383);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 37);
            this.lblTime.TabIndex = 7;
            this.lblTime.Text = "label10";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(6, 383);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 37);
            this.lblDate.TabIndex = 6;
            this.lblDate.Text = "label9";
            // 
            // lblExperienceType
            // 
            this.lblExperienceType.AutoSize = true;
            this.lblExperienceType.Location = new System.Drawing.Point(6, 243);
            this.lblExperienceType.Name = "lblExperienceType";
            this.lblExperienceType.Size = new System.Drawing.Size(108, 37);
            this.lblExperienceType.TabIndex = 5;
            this.lblExperienceType.Text = "label8";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 490);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(249, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Number of People";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(206, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date and Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Experience Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(535, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Remove Booking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.lblPhone);
            this.grpCustomer.Controls.Add(this.lblEmail);
            this.grpCustomer.Controls.Add(this.lblName);
            this.grpCustomer.Controls.Add(this.btnRemove);
            this.grpCustomer.Controls.Add(this.label7);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.label5);
            this.grpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(868, 197);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(500, 700);
            this.grpCustomer.TabIndex = 7;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Details";
            this.grpCustomer.Visible = false;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(6, 383);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(125, 37);
            this.lblPhone.TabIndex = 7;
            this.lblPhone.Text = "label10";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(6, 243);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 37);
            this.lblEmail.TabIndex = 6;
            this.lblEmail.Text = "label9";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 37);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "label8";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(212, 644);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(282, 50);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Remove Booking";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 350);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 33);
            this.label6.TabIndex = 1;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 70);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 33);
            this.label5.TabIndex = 0;
            this.label5.Text = "Full Name";
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.lblNameFind);
            this.grpEmail.Controls.Add(this.txtEmailFind);
            this.grpEmail.Controls.Add(this.btnFind);
            this.grpEmail.Controls.Add(this.btnEnter);
            this.grpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmail.Location = new System.Drawing.Point(575, 350);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(491, 233);
            this.grpEmail.TabIndex = 9;
            this.grpEmail.TabStop = false;
            this.grpEmail.Tag = "";
            this.grpEmail.Text = "Please enter your Email";
            // 
            // lblNameFind
            // 
            this.lblNameFind.AutoSize = true;
            this.lblNameFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameFind.Location = new System.Drawing.Point(6, 114);
            this.lblNameFind.Name = "lblNameFind";
            this.lblNameFind.Size = new System.Drawing.Size(93, 33);
            this.lblNameFind.TabIndex = 6;
            this.lblNameFind.Text = "Name";
            this.lblNameFind.Visible = false;
            // 
            // txtEmailFind
            // 
            this.txtEmailFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailFind.Location = new System.Drawing.Point(6, 39);
            this.txtEmailFind.MaxLength = 100;
            this.txtEmailFind.Name = "txtEmailFind";
            this.txtEmailFind.Size = new System.Drawing.Size(479, 38);
            this.txtEmailFind.TabIndex = 3;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(241, 177);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(119, 50);
            this.btnFind.TabIndex = 7;
            this.btnFind.Text = "Find";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(366, 177);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 50);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Visible = false;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // frmRemoveBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grpCustomer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpEmail);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmRemoveBooking";
            this.Text = "Remove Booking";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblExperienceType;
        private System.Windows.Forms.Label lblNoP;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.Label lblNameFind;
        private System.Windows.Forms.TextBox txtEmailFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}