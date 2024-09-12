using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalconrySYS
{
    public partial class frmAnalyseRevenue : Form
    {
        frmMainMenu parent;
        public DataSet dataSet = new DataSet();
        Booking theBooking = new Booking();
        ArrayList years = new ArrayList();
        string[] months = { "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
        public frmAnalyseRevenue()
        {
            InitializeComponent();
        }

        public frmAnalyseRevenue(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAnalyseRevenue_Load(object sender, EventArgs e)
        {
            for (int x = 0; x < Booking.getAllBookings().Tables[0].Rows.Count; x++)
            {
                int year = Convert.ToInt32(Booking.getAllBookings().Tables[0].Rows[x]["DATEANDTIME"].ToString().Split(' ')[0].Split('/')[2]);
                if (!years.Contains(year) && year != DateTime.Now.Year)
                {
                    years.Add(year);
                }
            }
            years.Sort();
            years.Reverse();
            cboYear.DataSource = years;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            int total = 0;
            grpYear.Visible = false;
            grpTotal.Visible = true;
            grpMonth.Visible = true;
            grpExp.Visible = true;

            int yr = Convert.ToInt32(cboYear.Text.Substring(2, 2));

            for(int x = 0; x < months.Length; x++)
            {
                total = total + Booking.analyseRevenue(months[x], yr);

                Label cost = new Label();
                cost.Name = "lblCost" + x.ToString();
                cost.Text = "€" + Booking.analyseRevenue(months[x], yr).ToString();

                Label month = new Label();
                month.Name = "lblMonth" + x.ToString();
                month.Text = months[x];
                if(x < 6)
                {
                    tblMonth.Controls.Add(month, 0, x);
                    tblMonth.Controls.Add(cost, 1, x);
                }
                else
                {
                    tblMonth.Controls.Add(month, 2, x-6);
                    tblMonth.Controls.Add(cost, 3, x-6);
                }
                
            } 
            lblTotal.Text = "€" + total.ToString();

            for (int x = 0; x < Experience.getAllExperiences().Tables[0].Rows.Count; x++)
            {
                Label exp = new Label();
                exp.Name = "lblExp" + x.ToString();
                exp.Text = Experience.getAllExperiences().Tables[0].Rows[x]["DESCRIPTION"].ToString();
                //Console.WriteLine(exp.Text);
                tblExp.RowCount++;
                tblExp.Controls.Add(exp, 0, tblExp.RowCount - 1);

                Label expCost = new Label();
                expCost.Name = "lblExpCost" + x.ToString();
                expCost.Text = "€" + Booking.analyseExperience(Experience.getAllExperiences().Tables[0].Rows[x]["EXPERIENCEID"].ToString(), yr);
                tblExp.Controls.Add(expCost, 1, tblExp.RowCount - 1);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpYear.Visible = true;
            grpTotal.Visible = false;
            grpMonth.Visible = false;
            grpExp.Visible = false;

            tblExp.Controls.Clear();
            tblMonth.Controls.Clear();

        }
    }
}
