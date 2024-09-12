namespace FalconrySYS
{
    partial class frmRemoveTrainer
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
            this.grpFindTrainer = new System.Windows.Forms.GroupBox();
            this.cboNameFind = new System.Windows.Forms.ComboBox();
            this.btnFindTrainer = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.grpTrainerDetails = new System.Windows.Forms.GroupBox();
            this.dtmDOB = new System.Windows.Forms.DateTimePicker();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpTrainerIDStatus = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrainerID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpFindTrainer.SuspendLayout();
            this.grpTrainerDetails.SuspendLayout();
            this.grpTrainerIDStatus.SuspendLayout();
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
            this.backToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.backToolStripMenuItem.Text = "Back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(579, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 73);
            this.label1.TabIndex = 13;
            this.label1.Text = "Remove Trainer";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpFindTrainer
            // 
            this.grpFindTrainer.Controls.Add(this.cboNameFind);
            this.grpFindTrainer.Controls.Add(this.btnFindTrainer);
            this.grpFindTrainer.Controls.Add(this.label9);
            this.grpFindTrainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpFindTrainer.Location = new System.Drawing.Point(581, 300);
            this.grpFindTrainer.Name = "grpFindTrainer";
            this.grpFindTrainer.Size = new System.Drawing.Size(500, 288);
            this.grpFindTrainer.TabIndex = 1;
            this.grpFindTrainer.TabStop = false;
            this.grpFindTrainer.Text = "Find Trainer";
            // 
            // cboNameFind
            // 
            this.cboNameFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboNameFind.FormattingEnabled = true;
            this.cboNameFind.Location = new System.Drawing.Point(6, 108);
            this.cboNameFind.Name = "cboNameFind";
            this.cboNameFind.Size = new System.Drawing.Size(303, 39);
            this.cboNameFind.TabIndex = 1;
            // 
            // btnFindTrainer
            // 
            this.btnFindTrainer.Location = new System.Drawing.Point(224, 200);
            this.btnFindTrainer.Name = "btnFindTrainer";
            this.btnFindTrainer.Size = new System.Drawing.Size(270, 50);
            this.btnFindTrainer.TabIndex = 8;
            this.btnFindTrainer.Text = "Find Trainer";
            this.btnFindTrainer.UseVisualStyleBackColor = true;
            this.btnFindTrainer.Click += new System.EventHandler(this.btnFindBird_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name";
            // 
            // grpTrainerDetails
            // 
            this.grpTrainerDetails.Controls.Add(this.dtmDOB);
            this.grpTrainerDetails.Controls.Add(this.lblGender);
            this.grpTrainerDetails.Controls.Add(this.lblName);
            this.grpTrainerDetails.Controls.Add(this.btnRegister);
            this.grpTrainerDetails.Controls.Add(this.label4);
            this.grpTrainerDetails.Controls.Add(this.label3);
            this.grpTrainerDetails.Controls.Add(this.label2);
            this.grpTrainerDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTrainerDetails.Location = new System.Drawing.Point(581, 273);
            this.grpTrainerDetails.Name = "grpTrainerDetails";
            this.grpTrainerDetails.Size = new System.Drawing.Size(500, 550);
            this.grpTrainerDetails.TabIndex = 2;
            this.grpTrainerDetails.TabStop = false;
            this.grpTrainerDetails.Text = "Trainer Details";
            this.grpTrainerDetails.Visible = false;
            // 
            // dtmDOB
            // 
            this.dtmDOB.Enabled = false;
            this.dtmDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmDOB.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtmDOB.Location = new System.Drawing.Point(11, 246);
            this.dtmDOB.Name = "dtmDOB";
            this.dtmDOB.Size = new System.Drawing.Size(200, 38);
            this.dtmDOB.TabIndex = 14;
            this.dtmDOB.Value = new System.DateTime(2023, 11, 25, 12, 51, 37, 0);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(6, 383);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(125, 37);
            this.lblGender.TabIndex = 11;
            this.lblGender.Text = "label10";
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
            this.btnRegister.Location = new System.Drawing.Point(224, 494);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(270, 50);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Remove Trainer";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 33);
            this.label4.TabIndex = 2;
            this.label4.Text = "Gender";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 210);
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
            // grpTrainerIDStatus
            // 
            this.grpTrainerIDStatus.Controls.Add(this.txtStatus);
            this.grpTrainerIDStatus.Controls.Add(this.label6);
            this.grpTrainerIDStatus.Controls.Add(this.txtTrainerID);
            this.grpTrainerIDStatus.Controls.Add(this.label7);
            this.grpTrainerIDStatus.Location = new System.Drawing.Point(581, 176);
            this.grpTrainerIDStatus.Name = "grpTrainerIDStatus";
            this.grpTrainerIDStatus.Size = new System.Drawing.Size(500, 91);
            this.grpTrainerIDStatus.TabIndex = 15;
            this.grpTrainerIDStatus.TabStop = false;
            this.grpTrainerIDStatus.Visible = false;
            // 
            // txtStatus
            // 
            this.txtStatus.Enabled = false;
            this.txtStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStatus.Location = new System.Drawing.Point(416, 24);
            this.txtStatus.MaxLength = 20;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(78, 38);
            this.txtStatus.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 33);
            this.label6.TabIndex = 3;
            this.label6.Text = "TrainerID";
            // 
            // txtTrainerID
            // 
            this.txtTrainerID.Enabled = false;
            this.txtTrainerID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTrainerID.Location = new System.Drawing.Point(140, 22);
            this.txtTrainerID.MaxLength = 20;
            this.txtTrainerID.Name = "txtTrainerID";
            this.txtTrainerID.Size = new System.Drawing.Size(167, 38);
            this.txtTrainerID.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(313, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 33);
            this.label7.TabIndex = 5;
            this.label7.Text = "Status";
            // 
            // frmRemoveTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.grpTrainerIDStatus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpTrainerDetails);
            this.Controls.Add(this.grpFindTrainer);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRemoveTrainer";
            this.Text = "Remove Trainer";
            this.Load += new System.EventHandler(this.frmRemoveTrainer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpFindTrainer.ResumeLayout(false);
            this.grpFindTrainer.PerformLayout();
            this.grpTrainerDetails.ResumeLayout(false);
            this.grpTrainerDetails.PerformLayout();
            this.grpTrainerIDStatus.ResumeLayout(false);
            this.grpTrainerIDStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpFindTrainer;
        private System.Windows.Forms.ComboBox cboNameFind;
        private System.Windows.Forms.Button btnFindTrainer;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox grpTrainerDetails;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtmDOB;
        private System.Windows.Forms.GroupBox grpTrainerIDStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrainerID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtStatus;
    }
}