using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FalconrySYS
{

    public partial class frmCreateBooking : Form
    {
        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        public static bool isValidPhone(string phone)
        {
            if (phone.All(char.IsNumber) == false)
            {
                return false;
            }
            else if (phone.Length > 0 && phone.Length < 10)
            {
                return false;
            }
            else { return true; }
        }

        frmMainMenu parent;
        public frmCreateBooking()
        {
            InitializeComponent();
        }

        public frmCreateBooking(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmCreateBooking_Load(object sender, EventArgs e)
        {
            cboExperienceType.DataSource = Experience.getAllExperiences().Tables[0];
            cboExperienceType.DisplayMember = "Description";
            cboExperienceType.ValueMember = "ExperienceID";

            dtmDate.MinDate = DateTime.Today;

            txtID.Text = Booking.getNextBookingID().ToString("0000000");
            txtStatus.Text = "R";
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
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
            else if (!IsValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Email is invalid!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail.Focus();
            }
            else if (!isValidPhone(txtPhone.Text))
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

                Random rnd = new Random();
                int rand = rnd.Next(Trainer.getAllTrainers().Tables[0].Rows.Count);
                int trainer = Convert.ToInt32(Trainer.getAllTrainers().Tables[0].Rows[rand]["TRAINERID"]);

                Booking aBooking = new Booking(Convert.ToInt32(txtID.Text), dtmDate.Value, Convert.ToInt32(cboNoP.Text), txtName.Text, txtPhone.Text, txtEmail.Text, cost, cboExperienceType.SelectedValue.ToString(), trainer, "A");

                aBooking.addBooking();

                MessageBox.Show("Booking Created!\n\nYour booking will cost €" + cost, "Booking");
                cboTime.Text = "09:00";
                cboNoP.Text = "2";
                txtName.Text = "";
                txtEmail.Text = "";
                txtPhone.Text = "";
                cboExperienceType.Focus();
            }
        }

        private void dtmDate_ValueChanged(object sender, EventArgs e)
        {
            cboTime.Items.Clear();
            for (int x = 9; x < 18; x++)
            {
                String dtm = dtmDate.Value.AddHours(x).ToString();
                DataRow[] rows = Booking.getAllBookings().Tables[0].Select("DateAndTime ='" + dtm + "'");
                if (rows.Length > 0)
                {
                    Console.WriteLine("Exists");
                }
                else
                {
                    if(dtmDate.Value.ToString("dd/MMM/yy") == DateTime.Today.ToString("dd/MMM/yy"))
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
