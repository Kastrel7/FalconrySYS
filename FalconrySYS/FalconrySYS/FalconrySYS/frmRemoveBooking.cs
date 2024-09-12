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
    public partial class frmRemoveBooking : Form
    {
        Booking theBooking = new Booking();
        frmMainMenu parent;
        public frmRemoveBooking()
        {
            InitializeComponent();
        }

        public frmRemoveBooking(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            theBooking.setStatus("C");

            theBooking.updateBooking();

            MessageBox.Show("Booking Removed!", "Booking");

            txtEmailFind.Text = "";
            lblNameFind.Visible = false;
            grpEmail.Visible = true;
            grpBooking.Visible = false;
            grpCustomer.Visible = false;
            btnEnter.Visible = false;
            txtEmailFind.Focus();
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

            lblID.Text = theBooking.getId().ToString();
            lblStatus.Text = theBooking.getStatus();
            lblExperienceType.Text = theBooking.getExperienceID();
            lblDate.Text = theBooking.getDAndT().ToString("dd-MMM-yy");
            lblTime.Text = theBooking.getDAndT().ToString("HH:mm");
            lblNoP.Text = theBooking.getNoOfP().ToString();
            lblName.Text = theBooking.getName();
            lblEmail.Text = theBooking.getEmail();
            lblPhone.Text = theBooking.getPhone();
        }
    }
}
