namespace FalconrySYS
{
    partial class frmUpdateBird
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
            this.grpBirdDetails = new System.Windows.Forms.GroupBox();
            this.cboTrainer = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSpecies = new System.Windows.Forms.ComboBox();
            this.dtmDOB = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpFindBird = new System.Windows.Forms.GroupBox();
            this.cboNameFind = new System.Windows.Forms.ComboBox();
            this.btnFindBird = new System.Windows.Forms.Button();
            this.cboSpeciesFind = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.grpBirdIDStatus = new System.Windows.Forms.GroupBox();
            this.cboStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBirdID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.grpBirdDetails.SuspendLayout();
            this.grpFindBird.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.grpBirdIDStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpBirdDetails
            // 
            this.grpBirdDetails.Controls.Add(this.cboTrainer);
            this.grpBirdDetails.Controls.Add(this.label10);
            this.grpBirdDetails.Controls.Add(this.btnRegister);
            this.grpBirdDetails.Controls.Add(this.cboGender);
            this.grpBirdDetails.Controls.Add(this.txtName);
            this.grpBirdDetails.Controls.Add(this.label5);
            this.grpBirdDetails.Controls.Add(this.cboSpecies);
            this.grpBirdDetails.Controls.Add(this.dtmDOB);
            this.grpBirdDetails.Controls.Add(this.label4);
            this.grpBirdDetails.Controls.Add(this.label3);
            this.grpBirdDetails.Controls.Add(this.label2);
            this.grpBirdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBirdDetails.Location = new System.Drawing.Point(581, 270);
            this.grpBirdDetails.Name = "grpBirdDetails";
            this.grpBirdDetails.Size = new System.Drawing.Size(500, 623);
            this.grpBirdDetails.TabIndex = 2;
            this.grpBirdDetails.TabStop = false;
            this.grpBirdDetails.Text = "Bird Details";
            this.grpBirdDetails.Visible = false;
            // 
            // cboTrainer
            // 
            this.cboTrainer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTrainer.FormattingEnabled = true;
            this.cboTrainer.Location = new System.Drawing.Point(6, 296);
            this.cboTrainer.Name = "cboTrainer";
            this.cboTrainer.Size = new System.Drawing.Size(303, 39);
            this.cboTrainer.TabIndex = 12;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 33);
            this.label10.TabIndex = 11;
            this.label10.Text = "Trainer";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(219, 515);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(270, 50);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Update Bird";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male - M",
            "Female - F",
            "Other - O"});
            this.cboGender.Location = new System.Drawing.Point(6, 526);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(176, 39);
            this.cboGender.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(6, 106);
            this.txtName.MaxLength = 20;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(483, 38);
            this.txtName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 490);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 33);
            this.label5.TabIndex = 5;
            this.label5.Text = "Gender";
            // 
            // cboSpecies
            // 
            this.cboSpecies.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpecies.FormattingEnabled = true;
            this.cboSpecies.Location = new System.Drawing.Point(6, 406);
            this.cboSpecies.Name = "cboSpecies";
            this.cboSpecies.Size = new System.Drawing.Size(303, 39);
            this.cboSpecies.TabIndex = 3;
            // 
            // dtmDOB
            // 
            this.dtmDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDOB.Location = new System.Drawing.Point(6, 196);
            this.dtmDOB.Name = "dtmDOB";
            this.dtmDOB.Size = new System.Drawing.Size(200, 38);
            this.dtmDOB.TabIndex = 2;
            this.dtmDOB.Value = new System.DateTime(1970, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Species";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Date of Birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // grpFindBird
            // 
            this.grpFindBird.Controls.Add(this.cboNameFind);
            this.grpFindBird.Controls.Add(this.btnFindBird);
            this.grpFindBird.Controls.Add(this.cboSpeciesFind);
            this.grpFindBird.Controls.Add(this.label7);
            this.grpFindBird.Controls.Add(this.label9);
            this.grpFindBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFindBird.Location = new System.Drawing.Point(581, 200);
            this.grpFindBird.Name = "grpFindBird";
            this.grpFindBird.Size = new System.Drawing.Size(500, 438);
            this.grpFindBird.TabIndex = 1;
            this.grpFindBird.TabStop = false;
            this.grpFindBird.Text = "Find Bird";
            // 
            // cboNameFind
            // 
            this.cboNameFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboNameFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNameFind.FormattingEnabled = true;
            this.cboNameFind.Location = new System.Drawing.Point(6, 249);
            this.cboNameFind.Name = "cboNameFind";
            this.cboNameFind.Size = new System.Drawing.Size(303, 39);
            this.cboNameFind.TabIndex = 2;
            // 
            // btnFindBird
            // 
            this.btnFindBird.Location = new System.Drawing.Point(224, 350);
            this.btnFindBird.Name = "btnFindBird";
            this.btnFindBird.Size = new System.Drawing.Size(270, 50);
            this.btnFindBird.TabIndex = 8;
            this.btnFindBird.Text = "Find Bird";
            this.btnFindBird.UseVisualStyleBackColor = true;
            this.btnFindBird.Click += new System.EventHandler(this.button1_Click);
            // 
            // cboSpeciesFind
            // 
            this.cboSpeciesFind.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSpeciesFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpeciesFind.FormattingEnabled = true;
            this.cboSpeciesFind.Location = new System.Drawing.Point(6, 106);
            this.cboSpeciesFind.Name = "cboSpeciesFind";
            this.cboSpeciesFind.Size = new System.Drawing.Size(303, 39);
            this.cboSpeciesFind.TabIndex = 1;
            this.cboSpeciesFind.SelectedIndexChanged += new System.EventHandler(this.cboSpeciesFind_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 33);
            this.label7.TabIndex = 2;
            this.label7.Text = "Species";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(640, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(382, 73);
            this.label1.TabIndex = 3;
            this.label1.Text = "Update Bird";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1636, 40);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // backToolStripMenuItem1
            // 
            this.backToolStripMenuItem1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem1.Name = "backToolStripMenuItem1";
            this.backToolStripMenuItem1.Size = new System.Drawing.Size(83, 36);
            this.backToolStripMenuItem1.Text = "Back";
            this.backToolStripMenuItem1.Click += new System.EventHandler(this.backToolStripMenuItem1_Click);
            // 
            // grpBirdIDStatus
            // 
            this.grpBirdIDStatus.Controls.Add(this.cboStatus);
            this.grpBirdIDStatus.Controls.Add(this.label6);
            this.grpBirdIDStatus.Controls.Add(this.txtBirdID);
            this.grpBirdIDStatus.Controls.Add(this.label8);
            this.grpBirdIDStatus.Location = new System.Drawing.Point(581, 180);
            this.grpBirdIDStatus.Name = "grpBirdIDStatus";
            this.grpBirdIDStatus.Size = new System.Drawing.Size(500, 84);
            this.grpBirdIDStatus.TabIndex = 11;
            this.grpBirdIDStatus.TabStop = false;
            this.grpBirdIDStatus.Visible = false;
            // 
            // cboStatus
            // 
            this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboStatus.FormattingEnabled = true;
            this.cboStatus.Items.AddRange(new object[] {
            "A",
            "U"});
            this.cboStatus.Location = new System.Drawing.Point(413, 27);
            this.cboStatus.Name = "cboStatus";
            this.cboStatus.Size = new System.Drawing.Size(76, 33);
            this.cboStatus.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "BirdID";
            // 
            // txtBirdID
            // 
            this.txtBirdID.Enabled = false;
            this.txtBirdID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBirdID.Location = new System.Drawing.Point(108, 22);
            this.txtBirdID.MaxLength = 20;
            this.txtBirdID.Name = "txtBirdID";
            this.txtBirdID.Size = new System.Drawing.Size(167, 38);
            this.txtBirdID.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(313, 24);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 33);
            this.label8.TabIndex = 5;
            this.label8.Text = "Status";
            // 
            // frmUpdateBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.grpBirdIDStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.grpBirdDetails);
            this.Controls.Add(this.grpFindBird);
            this.Name = "frmUpdateBird";
            this.Text = "Update Bird";
            this.Load += new System.EventHandler(this.frmUpdateBird_Load);
            this.grpBirdDetails.ResumeLayout(false);
            this.grpBirdDetails.PerformLayout();
            this.grpFindBird.ResumeLayout(false);
            this.grpFindBird.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.grpBirdIDStatus.ResumeLayout(false);
            this.grpBirdIDStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox grpBirdDetails;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSpecies;
        private System.Windows.Forms.DateTimePicker dtmDOB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFindBird;
        private System.Windows.Forms.ComboBox cboNameFind;
        private System.Windows.Forms.Button btnFindBird;
        private System.Windows.Forms.ComboBox cboSpeciesFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem1;
        private System.Windows.Forms.GroupBox grpBirdIDStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboStatus;
        private System.Windows.Forms.ComboBox cboTrainer;
        private System.Windows.Forms.Label label10;
    }
}