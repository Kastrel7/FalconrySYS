namespace FalconrySYS
{
    partial class frmRemoveBird
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
            this.grpFindBird = new System.Windows.Forms.GroupBox();
            this.cboNameFind = new System.Windows.Forms.ComboBox();
            this.btnFindBird = new System.Windows.Forms.Button();
            this.cboSpeciesFind = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grpBirdDetails = new System.Windows.Forms.GroupBox();
            this.dtmDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblSpecies = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpBirdIDStatus = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtBirdID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblTrainer = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpFindBird.SuspendLayout();
            this.grpBirdDetails.SuspendLayout();
            this.grpBirdIDStatus.SuspendLayout();
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
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(83, 40);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(625, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 73);
            this.label1.TabIndex = 10;
            this.label1.Text = "Remove Bird";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFindBird
            // 
            this.grpFindBird.Controls.Add(this.cboNameFind);
            this.grpFindBird.Controls.Add(this.btnFindBird);
            this.grpFindBird.Controls.Add(this.cboSpeciesFind);
            this.grpFindBird.Controls.Add(this.label7);
            this.grpFindBird.Controls.Add(this.label9);
            this.grpFindBird.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFindBird.Location = new System.Drawing.Point(575, 200);
            this.grpFindBird.Name = "grpFindBird";
            this.grpFindBird.Size = new System.Drawing.Size(500, 438);
            this.grpFindBird.TabIndex = 1;
            this.grpFindBird.TabStop = false;
            this.grpFindBird.Text = "Find Bird";
            // 
            // cboNameFind
            // 
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
            this.btnFindBird.Click += new System.EventHandler(this.btnFindBird_Click);
            // 
            // cboSpeciesFind
            // 
            this.cboSpeciesFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboSpeciesFind.FormattingEnabled = true;
            this.cboSpeciesFind.Items.AddRange(new object[] {
            "Peregrine - PG",
            "Gyrfalcon - GF",
            "Red-Footed - RF",
            "American Kestrel - AK",
            "Prarie - PR",
            "Aplomado - AP",
            "Merlin - MR",
            "Saker - SK",
            "Lanner - LN"});
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
            // grpBirdDetails
            // 
            this.grpBirdDetails.Controls.Add(this.lblTrainer);
            this.grpBirdDetails.Controls.Add(this.label10);
            this.grpBirdDetails.Controls.Add(this.dtmDOB);
            this.grpBirdDetails.Controls.Add(this.lblGender);
            this.grpBirdDetails.Controls.Add(this.lblSpecies);
            this.grpBirdDetails.Controls.Add(this.lblName);
            this.grpBirdDetails.Controls.Add(this.btnRegister);
            this.grpBirdDetails.Controls.Add(this.label5);
            this.grpBirdDetails.Controls.Add(this.label4);
            this.grpBirdDetails.Controls.Add(this.label3);
            this.grpBirdDetails.Controls.Add(this.label2);
            this.grpBirdDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpBirdDetails.Location = new System.Drawing.Point(575, 270);
            this.grpBirdDetails.Name = "grpBirdDetails";
            this.grpBirdDetails.Size = new System.Drawing.Size(500, 623);
            this.grpBirdDetails.TabIndex = 2;
            this.grpBirdDetails.TabStop = false;
            this.grpBirdDetails.Text = "Bird Details";
            this.grpBirdDetails.Visible = false;
            // 
            // dtmDOB
            // 
            this.dtmDOB.Enabled = false;
            this.dtmDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDOB.Location = new System.Drawing.Point(12, 196);
            this.dtmDOB.Name = "dtmDOB";
            this.dtmDOB.Size = new System.Drawing.Size(200, 38);
            this.dtmDOB.TabIndex = 13;
            this.dtmDOB.Value = new System.DateTime(2023, 11, 25, 12, 51, 37, 0);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 523);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(123, 37);
            this.lblGender.TabIndex = 12;
            this.lblGender.Text = "label11";
            // 
            // lblSpecies
            // 
            this.lblSpecies.AutoSize = true;
            this.lblSpecies.Location = new System.Drawing.Point(6, 406);
            this.lblSpecies.Name = "lblSpecies";
            this.lblSpecies.Size = new System.Drawing.Size(125, 37);
            this.lblSpecies.TabIndex = 11;
            this.lblSpecies.Text = "label10";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(6, 103);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 37);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "label6";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(224, 510);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(270, 50);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Remove Bird";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
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
            // grpBirdIDStatus
            // 
            this.grpBirdIDStatus.Controls.Add(this.label6);
            this.grpBirdIDStatus.Controls.Add(this.txtStatus);
            this.grpBirdIDStatus.Controls.Add(this.txtBirdID);
            this.grpBirdIDStatus.Controls.Add(this.label8);
            this.grpBirdIDStatus.Location = new System.Drawing.Point(575, 173);
            this.grpBirdIDStatus.Name = "grpBirdIDStatus";
            this.grpBirdIDStatus.Size = new System.Drawing.Size(500, 91);
            this.grpBirdIDStatus.TabIndex = 11;
            this.grpBirdIDStatus.TabStop = false;
            this.grpBirdIDStatus.Visible = false;
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
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(416, 22);
            this.txtStatus.MaxLength = 20;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(78, 38);
            this.txtStatus.TabIndex = 6;
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
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 260);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 33);
            this.label10.TabIndex = 14;
            this.label10.Text = "Trainer";
            // 
            // lblTrainer
            // 
            this.lblTrainer.AutoSize = true;
            this.lblTrainer.Location = new System.Drawing.Point(6, 296);
            this.lblTrainer.Name = "lblTrainer";
            this.lblTrainer.Size = new System.Drawing.Size(108, 37);
            this.lblTrainer.TabIndex = 15;
            this.lblTrainer.Text = "label9";
            // 
            // frmRemoveBird
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.grpBirdIDStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpBirdDetails);
            this.Controls.Add(this.grpFindBird);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRemoveBird";
            this.Text = "Remove Bird";
            this.Load += new System.EventHandler(this.frmRemoveBird_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpFindBird.ResumeLayout(false);
            this.grpFindBird.PerformLayout();
            this.grpBirdDetails.ResumeLayout(false);
            this.grpBirdDetails.PerformLayout();
            this.grpBirdIDStatus.ResumeLayout(false);
            this.grpBirdIDStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFindBird;
        private System.Windows.Forms.ComboBox cboNameFind;
        private System.Windows.Forms.Button btnFindBird;
        private System.Windows.Forms.ComboBox cboSpeciesFind;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpBirdDetails;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblSpecies;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpBirdIDStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtBirdID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtmDOB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblTrainer;
    }
}