namespace FalconrySYS
{
    partial class frmUpdateBooking
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
            this.label1 = new System.Windows.Forms.Label();
            this.grpCustomer = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.grpBooking = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboTime = new System.Windows.Forms.ComboBox();
            this.cboNoP = new System.Windows.Forms.ComboBox();
            this.dtmDate = new System.Windows.Forms.DateTimePicker();
            this.cboExperienceType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.lblNameFind = new System.Windows.Forms.Label();
            this.txtEmailFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpCustomer.SuspendLayout();
            this.grpBooking.SuspendLayout();
            this.grpEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1636, 48);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "mnuUpdateBooking";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(83, 44);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(504, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Update Booking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpCustomer
            // 
            this.grpCustomer.Controls.Add(this.btnUpdate);
            this.grpCustomer.Controls.Add(this.txtEmail);
            this.grpCustomer.Controls.Add(this.txtPhone);
            this.grpCustomer.Controls.Add(this.txtName);
            this.grpCustomer.Controls.Add(this.label7);
            this.grpCustomer.Controls.Add(this.label6);
            this.grpCustomer.Controls.Add(this.label5);
            this.grpCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCustomer.Location = new System.Drawing.Point(881, 200);
            this.grpCustomer.Name = "grpCustomer";
            this.grpCustomer.Size = new System.Drawing.Size(500, 700);
            this.grpCustomer.TabIndex = 4;
            this.grpCustomer.TabStop = false;
            this.grpCustomer.Text = "Customer Details";
            this.grpCustomer.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(222, 644);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(272, 50);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update Booking";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(6, 246);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(483, 38);
            this.txtEmail.TabIndex = 2;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(6, 386);
            this.txtPhone.MaxLength = 10;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(483, 38);
            this.txtPhone.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 107);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(483, 38);
            this.txtName.TabIndex = 1;
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
            // grpBooking
            // 
            this.grpBooking.Controls.Add(this.txtStatus);
            this.grpBooking.Controls.Add(this.label9);
            this.grpBooking.Controls.Add(this.txtID);
            this.grpBooking.Controls.Add(this.label8);
            this.grpBooking.Controls.Add(this.cboTime);
            this.grpBooking.Controls.Add(this.cboNoP);
            this.grpBooking.Controls.Add(this.dtmDate);
            this.grpBooking.Controls.Add(this.cboExperienceType);
            this.grpBooking.Controls.Add(this.label4);
            this.grpBooking.Controls.Add(this.label3);
            this.grpBooking.Controls.Add(this.label2);
            this.grpBooking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBooking.Location = new System.Drawing.Point(281, 200);
            this.grpBooking.Name = "grpBooking";
            this.grpBooking.Size = new System.Drawing.Size(500, 700);
            this.grpBooking.TabIndex = 3;
            this.grpBooking.TabStop = false;
            this.grpBooking.Text = "Booking Details";
            this.grpBooking.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(240, 106);
            this.txtStatus.MaxLength = 20;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(97, 38);
            this.txtStatus.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(240, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 33);
            this.label9.TabIndex = 11;
            this.label9.Text = "Status";
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(0, 106);
            this.txtID.MaxLength = 20;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(234, 38);
            this.txtID.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 33);
            this.label8.TabIndex = 9;
            this.label8.Text = "Booking ID";
            // 
            // cboTime
            // 
            this.cboTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTime.FormattingEnabled = true;
            this.cboTime.Items.AddRange(new object[] {
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00"});
            this.cboTime.Location = new System.Drawing.Point(212, 386);
            this.cboTime.Name = "cboTime";
            this.cboTime.Size = new System.Drawing.Size(179, 39);
            this.cboTime.TabIndex = 3;
            // 
            // cboNoP
            // 
            this.cboNoP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNoP.FormattingEnabled = true;
            this.cboNoP.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cboNoP.Location = new System.Drawing.Point(6, 526);
            this.cboNoP.Name = "cboNoP";
            this.cboNoP.Size = new System.Drawing.Size(179, 39);
            this.cboNoP.TabIndex = 4;
            // 
            // dtmDate
            // 
            this.dtmDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDate.Location = new System.Drawing.Point(6, 386);
            this.dtmDate.Name = "dtmDate";
            this.dtmDate.Size = new System.Drawing.Size(200, 38);
            this.dtmDate.TabIndex = 2;
            this.dtmDate.Value = new System.DateTime(2023, 11, 25, 12, 51, 37, 0);
            this.dtmDate.ValueChanged += new System.EventHandler(this.dtmDate_ValueChanged);
            // 
            // cboExperienceType
            // 
            this.cboExperienceType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExperienceType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboExperienceType.FormattingEnabled = true;
            this.cboExperienceType.Location = new System.Drawing.Point(6, 246);
            this.cboExperienceType.Name = "cboExperienceType";
            this.cboExperienceType.Size = new System.Drawing.Size(331, 39);
            this.cboExperienceType.TabIndex = 1;
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
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.lblNameFind);
            this.grpEmail.Controls.Add(this.txtEmailFind);
            this.grpEmail.Controls.Add(this.btnFind);
            this.grpEmail.Controls.Add(this.btnEnter);
            this.grpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmail.Location = new System.Drawing.Point(585, 350);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(491, 233);
            this.grpEmail.TabIndex = 5;
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
            // frmUpdateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.grpEmail);
            this.Controls.Add(this.grpBooking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpCustomer);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmUpdateBooking";
            this.Text = "frmUpdateBooking";
            this.Load += new System.EventHandler(this.frmUpdateBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpCustomer.ResumeLayout(false);
            this.grpCustomer.PerformLayout();
            this.grpBooking.ResumeLayout(false);
            this.grpBooking.PerformLayout();
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpCustomer;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grpBooking;
        private System.Windows.Forms.ComboBox cboTime;
        private System.Windows.Forms.ComboBox cboNoP;
        private System.Windows.Forms.DateTimePicker dtmDate;
        private System.Windows.Forms.ComboBox cboExperienceType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.TextBox txtEmailFind;
        private System.Windows.Forms.Label lblNameFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
    }
}