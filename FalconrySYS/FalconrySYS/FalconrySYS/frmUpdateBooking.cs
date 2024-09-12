using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Xml.Linq;

namespace FalconrySYS
{
    public partial class frmUpdateBooking : Form
    {
        Booking theBooking = new Booking();
        frmMainMenu parent;
        public frmUpdateBooking()
        {
            InitializeComponent();
        }

        public frmUpdateBooking(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text.Replace("'", "");
            newName = newName.Replace("-", "");
            newName = newName.Replace(" ", "");
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Name must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (!newName.All(char.IsLetter))
            {
                MessageBox.Show("Name must only contain letters, a single quote (') or a hyphon (-)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if (txtEmail.Text.Equals(""))
            {
                MessageBox.Show("Email must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (!frmCreateBooking.IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (!frmCreateBooking.isValidPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPhone.Focus();
            }
            else
            {
                if (txtName.Text.Contains("'"))
                {
                    txtName.Text = txtName.Text.Replace("'", "''");
                }
                string[] time = cboTime.Text.Split(':');
                int hr = Convert.ToInt32(time[0]);
                dtmDate.Value = dtmDate.Value.AddHours(hr);

                decimal cost = Convert.ToDecimal(Experience.findExperience(cboExperienceType.Text).Tables[0].Rows[0]["COST"]);
                cost = cost + ((Convert.ToInt32(cboNoP.Text) - 1) * 10);

                theBooking.setExperienceID(cboExperienceType.SelectedValue.ToString());
                theBooking.setDAndT(dtmDate.Value);
                theBooking.setNoOfP(Convert.ToInt32(cboNoP.Text));
                theBooking.setCost(cost);
                theBooking.setName(txtName.Text);
                theBooking.setEmail(txtEmail.Text);
                theBooking.setPhone(txtPhone.Text);

                theBooking.updateBooking();

                MessageBox.Show("Booking Updated with new cost of €" + cost + "!", "Booking");

                txtEmailFind.Text = "";
                lblNameFind.Visible = false;
                grpEmail.Visible = true;
                grpBooking.Visible = false;
                grpCustomer.Visible = false;
                btnEnter.Visible = false;
                txtEmailFind.Focus();
            }
        }

        private void frmUpdateBooking_Load(object sender, EventArgs e)
        {
            cboExperienceType.DataSource = Experience.getAllExperiences().Tables[0];
            cboExperienceType.DisplayMember = "Description";
            cboExperienceType.ValueMember = "ExperienceID";

            dtmDate.MinDate = DateTime.Today;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (!frmCreateBooking.IsValidEmail(txtEmailFind.Text))
            {
                MessageBox.Show("Email is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmailFind.Focus();
            }
            else
            {
                DataRow[] rows = Booking.getAllBookings().Tables[0].Select("Email ='" + txtEmailFind.Text + "'");
                if (rows.Length > 0)
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

        private void btnEnter_Click(object sender, EventArgs e)
        {
            theBooking.getBooking(txtEmailFind.Text);

            grpEmail.Visible = false;
            grpBooking.Visible = true;
            grpCustomer.Visible = true;

            txtID.Text = theBooking.getId().ToString();
            txtStatus.Text = theBooking.getStatus();
            cboExperienceType.SelectedValue = theBooking.getExperienceID();
            dtmDate.Value = theBooking.getDAndT();
            cboTime.Text = theBooking.getDAndT().ToString("HH:mm");
            dtmDate.Value = dtmDate.Value.AddHours(-Convert.ToInt32(theBooking.getDAndT().ToString("HH")));
            cboNoP.Text = theBooking.getNoOfP().ToString();
            txtName.Text = theBooking.getName();
            txtEmail.Text = theBooking.getEmail();
            txtPhone.Text = theBooking.getPhone();
        }

        private void dtmDate_ValueChanged(object sender, EventArgs e)
        {
            cboTime.Items.Clear();
            for (int x = 9; x < 18; x++)
            {
                DataRow[] rows = Booking.getAllBookings().Tables[0].Select("DateAndTime ='" + dtmDate.Value.AddHours(x).ToString() + "'");  
                if (rows.Length > 0)
                {
                    if (dtmDate.Value.AddHours(Convert.ToInt32(theBooking.getDAndT().ToString("HH"))) == theBooking.getDAndT())
                    {
                        cboTime.Items.Add(theBooking.getDAndT().ToString("HH:mm"));
                        cboTime.SelectedItem = theBooking.getDAndT().ToString("HH:mm");
                    }
                }
                else
                {
                    if (dtmDate.Value.ToString("dd/MMM/yy") == DateTime.Today.ToString("dd/MMM/yy"))
                    {
                        if (x <= Convert.ToInt32(DateTime.Now.ToString("HH")))
                        {

                        }
                        else
                        {
                            cboTime.Items.Add(x.ToString("D2") + ":00");
                        }
                    }
                    else
                    {
                        cboTime.Items.Add(x.ToString("D2") + ":00");
                    }
                }
            }
        }
    }
}
