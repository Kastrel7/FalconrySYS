namespace FalconrySYS
{
    partial class frmRateBooking
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
            this.grpRating = new System.Windows.Forms.GroupBox();
            this.lblRatingID = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.txtFeedback = new System.Windows.Forms.TextBox();
            this.pbStar5 = new System.Windows.Forms.PictureBox();
            this.pbStar4 = new System.Windows.Forms.PictureBox();
            this.pbStar3 = new System.Windows.Forms.PictureBox();
            this.pbStar2 = new System.Windows.Forms.PictureBox();
            this.pbStar1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEmail = new System.Windows.Forms.GroupBox();
            this.lblNameFind = new System.Windows.Forms.Label();
            this.txtEmailFind = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1636, 40);
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
            this.label1.Location = new System.Drawing.Point(616, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 73);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rate Booking";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpRating
            // 
            this.grpRating.Controls.Add(this.lblRatingID);
            this.grpRating.Controls.Add(this.label9);
            this.grpRating.Controls.Add(this.lblID);
            this.grpRating.Controls.Add(this.label8);
            this.grpRating.Controls.Add(this.lblTime);
            this.grpRating.Controls.Add(this.lblDate);
            this.grpRating.Controls.Add(this.label4);
            this.grpRating.Controls.Add(this.lblEmail);
            this.grpRating.Controls.Add(this.lblName);
            this.grpRating.Controls.Add(this.label6);
            this.grpRating.Controls.Add(this.label5);
            this.grpRating.Controls.Add(this.btnSubmit);
            this.grpRating.Controls.Add(this.txtFeedback);
            this.grpRating.Controls.Add(this.pbStar5);
            this.grpRating.Controls.Add(this.pbStar4);
            this.grpRating.Controls.Add(this.pbStar3);
            this.grpRating.Controls.Add(this.pbStar2);
            this.grpRating.Controls.Add(this.pbStar1);
            this.grpRating.Controls.Add(this.label3);
            this.grpRating.Controls.Add(this.label2);
            this.grpRating.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpRating.Location = new System.Drawing.Point(231, 200);
            this.grpRating.Margin = new System.Windows.Forms.Padding(0);
            this.grpRating.Name = "grpRating";
            this.grpRating.Size = new System.Drawing.Size(1200, 700);
            this.grpRating.TabIndex = 6;
            this.grpRating.TabStop = false;
            this.grpRating.Text = "Leave a Rating!";
            this.grpRating.Visible = false;
            // 
            // lblRatingID
            // 
            this.lblRatingID.AutoSize = true;
            this.lblRatingID.Location = new System.Drawing.Point(5, 143);
            this.lblRatingID.Name = "lblRatingID";
            this.lblRatingID.Size = new System.Drawing.Size(108, 37);
            this.lblRatingID.TabIndex = 25;
            this.lblRatingID.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(136, 33);
            this.label9.TabIndex = 24;
            this.label9.Text = "Rating ID";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(5, 73);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(108, 37);
            this.lblID.TabIndex = 23;
            this.lblID.Text = "label8";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(157, 33);
            this.label8.TabIndex = 22;
            this.label8.Text = "Booking ID";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(412, 157);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(108, 37);
            this.lblEmail.TabIndex = 20;
            this.lblEmail.Text = "label9";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(412, 73);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(108, 37);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "label8";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(412, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 33);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(412, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 33);
            this.label5.TabIndex = 15;
            this.label5.Text = "Full Name";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(924, 644);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(270, 50);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // txtFeedback
            // 
            this.txtFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFeedback.Location = new System.Drawing.Point(6, 355);
            this.txtFeedback.Multiline = true;
            this.txtFeedback.Name = "txtFeedback";
            this.txtFeedback.Size = new System.Drawing.Size(1188, 281);
            this.txtFeedback.TabIndex = 10;
            // 
            // pbStar5
            // 
            this.pbStar5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStar5.Image = global::FalconrySYS.Properties.Resources.white;
            this.pbStar5.Location = new System.Drawing.Point(266, 212);
            this.pbStar5.Margin = new System.Windows.Forms.Padding(0);
            this.pbStar5.Name = "pbStar5";
            this.pbStar5.Padding = new System.Windows.Forms.Padding(15);
            this.pbStar5.Size = new System.Drawing.Size(75, 75);
            this.pbStar5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar5.TabIndex = 9;
            this.pbStar5.TabStop = false;
            this.pbStar5.Click += new System.EventHandler(this.pbStar5_Click);
            this.pbStar5.MouseLeave += new System.EventHandler(this.pbStar5_MouseLeave);
            this.pbStar5.MouseHover += new System.EventHandler(this.pbStar5_MouseHover);
            // 
            // pbStar4
            // 
            this.pbStar4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStar4.Image = global::FalconrySYS.Properties.Resources.white;
            this.pbStar4.Location = new System.Drawing.Point(205, 212);
            this.pbStar4.Margin = new System.Windows.Forms.Padding(0);
            this.pbStar4.Name = "pbStar4";
            this.pbStar4.Padding = new System.Windows.Forms.Padding(15);
            this.pbStar4.Size = new System.Drawing.Size(75, 75);
            this.pbStar4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar4.TabIndex = 8;
            this.pbStar4.TabStop = false;
            this.pbStar4.Click += new System.EventHandler(this.pbStar4_Click);
            this.pbStar4.MouseLeave += new System.EventHandler(this.pbStar4_MouseLeave);
            this.pbStar4.MouseHover += new System.EventHandler(this.pbStar4_MouseHover);
            // 
            // pbStar3
            // 
            this.pbStar3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStar3.Image = global::FalconrySYS.Properties.Resources.white;
            this.pbStar3.Location = new System.Drawing.Point(140, 212);
            this.pbStar3.Margin = new System.Windows.Forms.Padding(0);
            this.pbStar3.Name = "pbStar3";
            this.pbStar3.Padding = new System.Windows.Forms.Padding(15);
            this.pbStar3.Size = new System.Drawing.Size(75, 75);
            this.pbStar3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar3.TabIndex = 7;
            this.pbStar3.TabStop = false;
            this.pbStar3.Click += new System.EventHandler(this.pbStar3_Click);
            this.pbStar3.MouseLeave += new System.EventHandler(this.pbStar3_MouseLeave);
            this.pbStar3.MouseHover += new System.EventHandler(this.pbStar3_MouseHover);
            // 
            // pbStar2
            // 
            this.pbStar2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStar2.Image = global::FalconrySYS.Properties.Resources.white;
            this.pbStar2.Location = new System.Drawing.Point(75, 212);
            this.pbStar2.Margin = new System.Windows.Forms.Padding(0);
            this.pbStar2.Name = "pbStar2";
            this.pbStar2.Padding = new System.Windows.Forms.Padding(15);
            this.pbStar2.Size = new System.Drawing.Size(75, 75);
            this.pbStar2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar2.TabIndex = 6;
            this.pbStar2.TabStop = false;
            this.pbStar2.Click += new System.EventHandler(this.pbStar2_Click);
            this.pbStar2.MouseLeave += new System.EventHandler(this.pbStar2_MouseLeave);
            this.pbStar2.MouseHover += new System.EventHandler(this.pbStar2_MouseHover);
            // 
            // pbStar1
            // 
            this.pbStar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbStar1.Image = global::FalconrySYS.Properties.Resources.white;
            this.pbStar1.Location = new System.Drawing.Point(10, 212);
            this.pbStar1.Margin = new System.Windows.Forms.Padding(0);
            this.pbStar1.Name = "pbStar1";
            this.pbStar1.Padding = new System.Windows.Forms.Padding(15);
            this.pbStar1.Size = new System.Drawing.Size(75, 75);
            this.pbStar1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbStar1.TabIndex = 5;
            this.pbStar1.TabStop = false;
            this.pbStar1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pbStar1.MouseLeave += new System.EventHandler(this.pbStar1_MouseLeave);
            this.pbStar1.MouseHover += new System.EventHandler(this.pbStar1_MouseHover);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "Leave some feedback!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 33);
            this.label2.TabIndex = 0;
            this.label2.Text = "Please give us a rating!";
            // 
            // grpEmail
            // 
            this.grpEmail.Controls.Add(this.lblNameFind);
            this.grpEmail.Controls.Add(this.txtEmailFind);
            this.grpEmail.Controls.Add(this.btnFind);
            this.grpEmail.Controls.Add(this.btnEnter);
            this.grpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEmail.Location = new System.Drawing.Point(592, 350);
            this.grpEmail.Name = "grpEmail";
            this.grpEmail.Size = new System.Drawing.Size(491, 233);
            this.grpEmail.TabIndex = 10;
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
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click_1);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(586, 245);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(125, 37);
            this.lblTime.TabIndex = 21;
            this.lblTime.Text = "label10";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(412, 245);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 37);
            this.lblDate.TabIndex = 19;
            this.lblDate.Text = "label9";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(412, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 33);
            this.label4.TabIndex = 16;
            this.label4.Text = "Date and Time of Booking";
            // 
            // frmRateBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpRating);
            this.Controls.Add(this.grpEmail);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmRateBooking";
            this.Text = "Rate Booking";
            this.Load += new System.EventHandler(this.frmRateBooking_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpRating.ResumeLayout(false);
            this.grpRating.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbStar1)).EndInit();
            this.grpEmail.ResumeLayout(false);
            this.grpEmail.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpRating;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbStar1;
        private System.Windows.Forms.PictureBox pbStar5;
        private System.Windows.Forms.PictureBox pbStar4;
        private System.Windows.Forms.PictureBox pbStar3;
        private System.Windows.Forms.PictureBox pbStar2;
        private System.Windows.Forms.TextBox txtFeedback;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.GroupBox grpEmail;
        private System.Windows.Forms.Label lblNameFind;
        private System.Windows.Forms.TextBox txtEmailFind;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRatingID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label label4;
    }
}