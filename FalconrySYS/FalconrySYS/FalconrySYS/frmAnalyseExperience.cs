using FalconrySYS.Properties;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FalconrySYS
{
    public partial class frmAnalyseExperience : Form
    {
        frmMainMenu parent;
        ArrayList years = new ArrayList();
        Experience theExperience = new Experience();
        public frmAnalyseExperience()
        {
            InitializeComponent();
        }

        public frmAnalyseExperience(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmAnalyseExperience_Load(object sender, EventArgs e)
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
            int yr = Convert.ToInt32(cboYear.Text.Substring(2, 2));

            string[] lbls = { "Experience", "ID", "Rating", " ", " ", " " };

            int[] ratings = new int[Experience.getAllExperiences().Tables[0].Rows.Count];

            for(int x = 0; x < lbls.Length; x++)
            {
                if(x < 3)
                {
                    Label newLabel = new Label();
                    newLabel.Name = "lbl" + lbls[x] + x.ToString();
                    newLabel.Text = lbls[x];
                    tblAvg.Controls.Add(newLabel, x, 0);
                }
                else
                {
                    Label newLabel = new Label();
                    newLabel.Name = "lbl" + lbls[x] + x.ToString();
                    newLabel.Text = lbls[x];
                    tblAvg.Controls.Add(newLabel, x-3, 1);
                }
            }

            for (int x = 0; x < Experience.getAllExperiences().Tables[0].Rows.Count; x++)
            {
                Label desc = new Label();
                desc.Name = "lblExperience" + x.ToString();
                desc.Text = Experience.getAllExperiences().Tables[0].Rows[x]["DESCRIPTION"].ToString();
                tblAvg.Controls.Add(desc, 0, x+2);

                Label id = new Label();
                id.Name = "lblID" + x.ToString();
                id.Text = Experience.getAllExperiences().Tables[0].Rows[x]["EXPERIENCEID"].ToString();
                tblAvg.Controls.Add(id, 1, x+2);

                Label avgRating = new Label();
                avgRating.Name = "lblAvgRating" + x.ToString();
                avgRating.Text = Rating.getAvgRatingForYear(yr, Experience.getAllExperiences().Tables[0].Rows[x]["EXPERIENCEID"].ToString()).ToString();
                tblAvg.Controls.Add(avgRating, 2, x+2);

                ratings[x] = Rating.getAvgRatingForYear(yr, Experience.getAllExperiences().Tables[0].Rows[x]["EXPERIENCEID"].ToString());
            }

            Label hiDesc = new Label();
            hiDesc.Name = "lblHiDesc";
            hiDesc.Text = Experience.getAllExperiences().Tables[0].Rows[Array.IndexOf(ratings, ratings.Max())]["DESCRIPTION"].ToString();
            Label hi = new Label();
            hi.Name = "lblHi";
            hi.Text = ratings.Max().ToString();
            tblHi.Controls.Add(hiDesc, 0, 0);
            tblHi.Controls.Add(hi, 1, 0);

            Label loDesc = new Label();
            loDesc.Name = "lblLoDesc";
            loDesc.Text = Experience.getAllExperiences().Tables[0].Rows[Array.IndexOf(ratings, ratings.Min())]["DESCRIPTION"].ToString();
            Label lo = new Label();
            lo.Name = "lblLo";
            lo.Text = ratings.Min().ToString();
            tblLo.Controls.Add(loDesc, 0, 0);
            tblLo.Controls.Add(lo, 1, 0);

            grpAvg.Visible = true;
            grpHi.Visible = true;
            grpLo.Visible = true;
            grpYear.Visible = false;
            btnYear.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grpAvg.Visible = false;
            grpHi.Visible = false;
            grpLo.Visible = false;
            grpYear.Visible = true;

            cboYear.Text = "";
            cboYear.Focus();
        }

        private void btnYear_Click(object sender, EventArgs e)
        {
            grpAvg.Visible = false;
            grpHi.Visible = false;
            grpYear.Visible = true;
            grpLo.Visible = false;
            btnYear.Visible = false;

            cboYear.Text = "";
            cboYear.Focus();

            tblAvg.Controls.Clear();
            tblHi.Controls.Clear();
            tblLo.Controls.Clear();
        }
    }
}
