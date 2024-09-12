using Oracle.ManagedDataAccess.Client;
using System;
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
    public partial class frmMainMenu : Form
    {
        OracleConnection conn;
        public frmMainMenu()
        {
            InitializeComponent();
        }

        private bool testConn()
        {
            conn = new OracleConnection(DBConnect.connection);
            try
            {
                conn.Open();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("You are not connected to the database!\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void createBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }

            frmCreateBooking nextForm = new frmCreateBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void updateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmUpdateBooking nextForm = new frmUpdateBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void removeBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmRemoveBooking nextForm = new frmRemoveBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void addBirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmAddBird nextForm = new frmAddBird(this);
            this.Hide();
            nextForm.Show();
        }

        private void updateBirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmUpdateBird nextForm = new frmUpdateBird(this);
            this.Hide();
            nextForm.Show();
        }

        private void removeBirdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmRemoveBird nextForm = new frmRemoveBird(this);
            this.Hide();
            nextForm.Show();
        }

        private void addTrainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmRegisterTrainer nextForm = new frmRegisterTrainer(this);
            this.Hide();
            nextForm.Show();
        }

        private void updateTrainersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmUpdateTrainer nextForm = new frmUpdateTrainer(this);
            this.Hide();
            nextForm.Show();
        }

        private void removeTrainerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmRemoveTrainer nextForm = new frmRemoveTrainer(this);
            this.Hide();
            nextForm.Show();
        }

        private void analyseYealryRevenueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmAnalyseRevenue nextForm = new frmAnalyseRevenue(this);
            this.Hide();
            nextForm.Show();
        }

        private void analyseYearlyExperienceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmAnalyseExperience nextForm = new frmAnalyseExperience(this);
            this.Hide();
            nextForm.Show();

        }

        private void setExperienceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmSetExperienceType nextForm = new frmSetExperienceType(this);
            this.Hide();
            nextForm.Show();
        }

        private void updateExperienceTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmUpdateExperienceType nextForm = new frmUpdateExperienceType(this);
            this.Hide();
            nextForm.Show();
        }

        private void rateBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!testConn()) { return; }
            frmRateBooking nextForm = new frmRateBooking(this);
            this.Hide();
            nextForm.Show();
        }

        private void testConnectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDBConnect nextForm = new frmDBConnect(this);
            this.Hide();
            nextForm.Show();
        }
    }
}
