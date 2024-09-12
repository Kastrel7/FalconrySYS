using FalconrySYS.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FalconrySYS
{
    public partial class frmRateBooking : Form
    {
        Experience theExperience = new Experience();
        Booking theBooking = new Booking();
        frmMainMenu parent;
        public static int rating = 0;

        private void setRating(int rating)
        {
            if (rating == 0)
            {
                pbStar1.Image = Resources.white;
                pbStar2.Image = Resources.white;
                pbStar3.Image = Resources.white;
                pbStar4.Image = Resources.white;
                pbStar5.Image = Resources.white;
            }
            else if (rating == 1)
            {
                pbStar1.Image = Resources.gold;
                pbStar2.Image = Resources.white;
                pbStar3.Image = Resources.white; 
                pbStar4.Image = Resources.white;
                pbStar5.Image = Resources.white;
            }
            else if (rating == 2)
            {
                pbStar1.Image = Resources.gold;
                pbStar2.Image = Resources.gold;
                pbStar3.Image = Resources.white;
                pbStar4.Image = Resources.white;
                pbStar5.Image = Resources.white;
            }
            else if (rating == 3)
            {
                pbStar1.Image = Resources.gold;
                pbStar2.Image = Resources.gold;
                pbStar3.Image = Resources.gold;
                pbStar4.Image = Resources.white;
                pbStar5.Image = Resources.white;
            }
            else if (rating == 4)
            {
                pbStar1.Image = Resources.gold;
                pbStar2.Image = Resources.gold;
                pbStar3.Image = Resources.gold;
                pbStar4.Image = Resources.gold;
                pbStar5.Image = Resources.white;
            }
            else if (rating == 5)
            {
                pbStar1.Image = Resources.gold;
                pbStar2.Image = Resources.gold;
                pbStar3.Image = Resources.gold;
                pbStar4.Image = Resources.gold;
                pbStar5.Image = Resources.gold;
            }
        }

        public frmRateBooking()
        {
            InitializeComponent();
        }

        public frmRateBooking(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            rating = 1;
            setRating(rating);
        }

        private void pbStar2_Click(object sender, EventArgs e)
        {
            rating = 2;
            setRating(rating);
        }

        private void pbStar3_Click(object sender, EventArgs e)
        {
            rating = 3;
            setRating(rating);
        }

        private void pbStar4_Click(object sender, EventArgs e)
        {
            rating = 4;
            setRating(rating);
        }

        private void pbStar5_Click(object sender, EventArgs e)
        {
            rating = 5;
            setRating(rating);
        }

        private void pbStar1_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.gold;
            pbStar2.Image = Resources.white;
            pbStar3.Image = Resources.white;
            pbStar4.Image = Resources.white;
            pbStar5.Image = Resources.white;
        }

        private void pbStar1_MouseLeave(object sender, EventArgs e)
        {
            setRating(rating);
        }

        private void pbStar2_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.gold;
            pbStar2.Image = Resources.gold;
            pbStar3.Image = Resources.white;
            pbStar4.Image = Resources.white;
            pbStar5.Image = Resources.white;
        }

        private void pbStar2_MouseLeave(object sender, EventArgs e)
        {
            setRating(rating);
        }

        private void pbStar3_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.gold;
            pbStar2.Image = Resources.gold;
            pbStar3.Image = Resources.gold;
            pbStar4.Image = Resources.white;
            pbStar5.Image = Resources.white;
        }

        private void pbStar3_MouseLeave(object sender, EventArgs e)
        {
            setRating(rating);
        }

        private void pbStar4_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.gold;
            pbStar2.Image = Resources.gold;
            pbStar3.Image = Resources.gold;
            pbStar4.Image = Resources.gold;
            pbStar5.Image = Resources.white;
        }

        private void pbStar4_MouseLeave(object sender, EventArgs e)
        {
            setRating(rating);
        }

        private void pbStar5_MouseHover(object sender, EventArgs e)
        {
            pbStar1.Image = Resources.gold;
            pbStar2.Image = Resources.gold;
            pbStar3.Image = Resources.gold;
            pbStar4.Image = Resources.gold;
            pbStar5.Image = Resources.gold;
        }

        private void pbStar5_MouseLeave(object sender, EventArgs e)
        {
            setRating(rating);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rating == 0)
            {
                MessageBox.Show("You have not rated your experience", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                pbStar5.Focus();
            }
            else
            {
                if (txtFeedback.Text.Contains("'"))
                {
                    txtFeedback.Text = txtFeedback.Text.Replace("'", "''");
                }

                DateTime dateTime = DateTime.Parse(DateTime.Now.ToString("dd-MMM-yy HH:mm:ss"));

                Rating aRating = new Rating(Convert.ToInt32(lblRatingID.Text), txtFeedback.Text, rating, lblEmail.Text, DateTime.Now, Convert.ToInt32(lblID.Text));

                aRating.addRating();

                theExperience.getExperience(theBooking.getExperienceID());
                float avgRating = Convert.ToInt32(Experience.getAverageRating(theBooking.getExperienceID()));
                theExperience.setRating(avgRating);

                theExperience.updateExperience();


                MessageBox.Show("Thank you for leaving a rating!\n\nRatings help our falconry get better with feedback!", "Rating");

                rating = 0;
                txtFeedback.Text = "";
                txtEmailFind.Text = "";
                lblNameFind.Visible = false;
                btnEnter.Visible = false;
                grpEmail.Visible = true;
                grpRating.Visible = false;
                txtEmailFind.Focus();
            }

            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            DataRow[] ratingRows = Rating.getAllRatings().Tables[0].Select("Email ='" + txtEmailFind.Text + "'");
            if (!frmCreateBooking.IsValidEmail(txtEmailFind.Text))
            {
                MessageBox.Show("Email is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailFind.Focus();
                lblNameFind.Visible = false;
            }
            else if (ratingRows.Length > 0)
            {
                MessageBox.Show("You have already left a rating for this booking", "Already Rated", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailFind.Focus();
                txtEmailFind.Text = null;
                lblNameFind.Visible = false;
            }
            else
            {
                DataRow[] bookingRows = Booking.getAllBookings().Tables[0].Select("Email ='" + txtEmailFind.Text + "'");
                if (bookingRows.Length > 0 && ratingRows.Length == 0)
                {
                    theBooking.getBooking(txtEmailFind.Text);

                    lblNameFind.Visible = true;
                    btnEnter.Visible = true;

                    lblNameFind.Text = theBooking.getName();
                }
                else
                {
                    lblNameFind.Visible = true;
                    lblNameFind.Text = "Booking not found";
                }
            }
        }

        private void btnEnter_Click_1(object sender, EventArgs e)
        {
            theBooking.getBooking(txtEmailFind.Text);

            grpEmail.Visible = false;
            grpRating.Visible = true;

            lblID.Text = theBooking.getId().ToString();
            lblName.Text = theBooking.getName();
            lblEmail.Text = theBooking.getEmail();
            lblDate.Text = theBooking.getDAndT().ToString("dd-MMM-yy");
            lblTime.Text = theBooking.getDAndT().ToString("HH:mm");
        }

        private void frmRateBooking_Load(object sender, EventArgs e)
        {
            lblRatingID.Text = Rating.getNextRatingID().ToString("000");
        }
    }
}
