namespace FalconrySYS
{
    partial class frmAnalyseRevenue
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
            this.grpYear = new System.Windows.Forms.GroupBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.grpMonth = new System.Windows.Forms.GroupBox();
            this.tblMonth = new System.Windows.Forms.TableLayoutPanel();
            this.grpExp = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tblExp = new System.Windows.Forms.TableLayoutPanel();
            this.grpTotal = new System.Windows.Forms.GroupBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.grpYear.SuspendLayout();
            this.grpMonth.SuspendLayout();
            this.grpExp.SuspendLayout();
            this.grpTotal.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(453, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(757, 73);
            this.label1.TabIndex = 2;
            this.label1.Text = "Analyse Yearly Revenue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpYear
            // 
            this.grpYear.Controls.Add(this.cboYear);
            this.grpYear.Controls.Add(this.btnEnter);
            this.grpYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpYear.Location = new System.Drawing.Point(586, 400);
            this.grpYear.Name = "grpYear";
            this.grpYear.Size = new System.Drawing.Size(491, 160);
            this.grpYear.TabIndex = 7;
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
            // grpMonth
            // 
            this.grpMonth.Controls.Add(this.tblMonth);
            this.grpMonth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpMonth.Location = new System.Drawing.Point(154, 400);
            this.grpMonth.Name = "grpMonth";
            this.grpMonth.Size = new System.Drawing.Size(600, 500);
            this.grpMonth.TabIndex = 8;
            this.grpMonth.TabStop = false;
            this.grpMonth.Text = "Revenue by Month";
            this.grpMonth.Visible = false;
            // 
            // tblMonth
            // 
            this.tblMonth.ColumnCount = 4;
            this.tblMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tblMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tblMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tblMonth.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tblMonth.Location = new System.Drawing.Point(6, 76);
            this.tblMonth.Name = "tblMonth";
            this.tblMonth.RowCount = 6;
            this.tblMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblMonth.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66666F));
            this.tblMonth.Size = new System.Drawing.Size(585, 400);
            this.tblMonth.TabIndex = 0;
            // 
            // grpExp
            // 
            this.grpExp.Controls.Add(this.button1);
            this.grpExp.Controls.Add(this.tblExp);
            this.grpExp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpExp.Location = new System.Drawing.Point(908, 400);
            this.grpExp.Name = "grpExp";
            this.grpExp.Size = new System.Drawing.Size(600, 500);
            this.grpExp.TabIndex = 9;
            this.grpExp.TabStop = false;
            this.grpExp.Text = "Revenue by Experience";
            this.grpExp.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 444);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(391, 50);
            this.button1.TabIndex = 6;
            this.button1.Text = "Select Another Year";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tblExp
            // 
            this.tblExp.ColumnCount = 2;
            this.tblExp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tblExp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tblExp.Location = new System.Drawing.Point(3, 76);
            this.tblExp.Name = "tblExp";
            this.tblExp.RowCount = 1;
            this.tblExp.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tblExp.Size = new System.Drawing.Size(591, 362);
            this.tblExp.TabIndex = 0;
            // 
            // grpTotal
            // 
            this.grpTotal.Controls.Add(this.lblTotal);
            this.grpTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpTotal.Location = new System.Drawing.Point(531, 200);
            this.grpTotal.Name = "grpTotal";
            this.grpTotal.Size = new System.Drawing.Size(600, 150);
            this.grpTotal.TabIndex = 10;
            this.grpTotal.TabStop = false;
            this.grpTotal.Text = "Total Revenue";
            this.grpTotal.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(60, 60);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(99, 33);
            this.lblTotal.TabIndex = 0;
            this.lblTotal.Text = "label2";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmAnalyseRevenue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1636, 994);
            this.Controls.Add(this.grpTotal);
            this.Controls.Add(this.grpExp);
            this.Controls.Add(this.grpMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grpYear);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAnalyseRevenue";
            this.Text = "Analyse Yearly Revenue";
            this.Load += new System.EventHandler(this.frmAnalyseRevenue_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpYear.ResumeLayout(false);
            this.grpMonth.ResumeLayout(false);
            this.grpExp.ResumeLayout(false);
            this.grpTotal.ResumeLayout(false);
            this.grpTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpYear;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.GroupBox grpMonth;
        private System.Windows.Forms.GroupBox grpExp;
        private System.Windows.Forms.GroupBox grpTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TableLayoutPanel tblMonth;
        private System.Windows.Forms.TableLayoutPanel tblExp;
        private System.Windows.Forms.Button button1;
    }
}