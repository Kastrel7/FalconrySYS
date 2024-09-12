namespace FalconrySYS
{
    partial class frmAnalyseExperience
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
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grpAvg = new System.Windows.Forms.GroupBox();
            this.tblAvg = new System.Windows.Forms.TableLayoutPanel();
            this.grpHi = new System.Windows.Forms.GroupBox();
            this.tblHi = new System.Windows.Forms.TableLayoutPanel();
            this.grpLo = new System.Windows.Forms.GroupBox();
            this.tblLo = new System.Windows.Forms.TableLayoutPanel();
            this.btnYear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.grpAvg.SuspendLayout();
            this.grpHi.SuspendLayout();
            this.grpLo.SuspendLayout();
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
            this.menuStrip1.TabIndex = 1;
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
            // grpYear
            // 
            this.grpYear.Controls.Add(this.cboYear);
            this.grpYear.Controls.Add(this.btnEnter);
            this.grpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYear.Location = new System.Drawing.Point(586, 400);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(491, 160);
            this.grpYear.TabIndex = 9;
            this.grpYear.TabStop = false;
            this.grpYear.Tag = "";
            this.grpYear.Text = "Select year for which to analyse";
            // 
            // cboYear
            // 
            this.cboYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(6, 39);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(153, 41);
            this.cboYear.TabIndex = 6;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(366, 104);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(119, 50);
            this.btnEnter.TabIndex = 5;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1034, 73);
            this.label1.TabIndex = 8;
            this.label1.Text = "Analyse Yealry Experience Rating";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpAvg
            // 
            this.grpAvg.Controls.Add(this.tblAvg);
            this.grpAvg.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAvg.Location = new System.Drawing.Point(231, 200);
            this.grpAvg.Name = "grpAvg";
            this.grpAvg.Size = new System.Drawing.Size(1200, 500);
            this.grpAvg.TabIndex = 10;
            this.grpAvg.TabStop = false;
            this.grpAvg.Text = "Average Ratings";
            this.grpAvg.Visible = false;
            // 
            // tblAvg
            // 
            this.tblAvg.ColumnCount = 3;
            this.tblAvg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.87206F));
            this.tblAvg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12.03704F));
            this.tblAvg.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.09091F));
            this.tblAvg.Location = new System.Drawing.Point(6, 37);
            this.tblAvg.Name = "tblAvg";
            this.tblAvg.RowCount = 1;
            this.tblAvg.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblAvg.Size = new System.Drawing.Size(1188, 457);
            this.tblAvg.TabIndex = 0;
            // 
            // grpHi
            // 
            this.grpHi.Controls.Add(this.tblHi);
            this.grpHi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpHi.Location = new System.Drawing.Point(237, 706);
            this.grpHi.Name = "grpHi";
            this.grpHi.Size = new System.Drawing.Size(450, 200);
            this.grpHi.TabIndex = 11;
            this.grpHi.TabStop = false;
            this.grpHi.Text = "Highest Rated Experience";
            this.grpHi.Visible = false;
            // 
            // tblHi
            // 
            this.tblHi.ColumnCount = 2;
            this.tblHi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblHi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblHi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblHi.Location = new System.Drawing.Point(6, 37);
            this.tblHi.Name = "tblHi";
            this.tblHi.RowCount = 1;
            this.tblHi.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblHi.Size = new System.Drawing.Size(438, 157);
            this.tblHi.TabIndex = 1;
            // 
            // grpLo
            // 
            this.grpLo.Controls.Add(this.tblLo);
            this.grpLo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLo.Location = new System.Drawing.Point(693, 706);
            this.grpLo.Name = "grpLo";
            this.grpLo.Size = new System.Drawing.Size(450, 200);
            this.grpLo.TabIndex = 12;
            this.grpLo.TabStop = false;
            this.grpLo.Text = "Lowest Rated Experience";
            this.grpLo.Visible = false;
            // 
            // tblLo
            // 
            this.tblLo.ColumnCount = 2;
            this.tblLo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblLo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblLo.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tblLo.Location = new System.Drawing.Point(6, 37);
            this.tblLo.Name = "tblLo";
            this.tblLo.RowCount = 1;
            this.tblLo.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblLo.Size = new System.Drawing.Size(438, 157);
            this.tblLo.TabIndex = 2;
            // 
            // btnYear
            // 
            this.btnYear.Location = new System.Drawing.Point(1149, 706);
            this.btnYear.Name = "btnYear";
            this.btnYear.Size = new System.Drawing.Size(282, 50);
            this.btnYear.TabIndex = 13;
            this.btnYear.Text = "Select Another Year";
            this.btnYear.UseVisualStyleBackColor = true;
            this.btnYear.Visible = false;
            this.btnYear.Click += new System.EventHandler(this.btnYear_Click);
            // 
            // frmAnalyseExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.btnYear);
            this.Controls.Add(this.grpLo);
            this.Controls.Add(this.grpHi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpYear);
            this.Controls.Add(this.grpAvg);
            this.Name = "frmAnalyseExperience";
            this.Text = "Analyse Yearly Experience Rating";
            this.Load += new System.EventHandler(this.frmAnalyseExperience_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpYear.ResumeLayout(false);
            this.grpAvg.ResumeLayout(false);
            this.grpHi.ResumeLayout(false);
            this.grpLo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpAvg;
        private System.Windows.Forms.TableLayoutPanel tblAvg;
        private System.Windows.Forms.GroupBox grpHi;
        private System.Windows.Forms.TableLayoutPanel tblHi;
        private System.Windows.Forms.GroupBox grpLo;
        private System.Windows.Forms.TableLayoutPanel tblLo;
        private System.Windows.Forms.Button btnYear;
    }
}