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
    public partial class frmAddBird : Form
    {
        frmMainMenu parent;
        public frmAddBird()
        {
            InitializeComponent();
        }

        public frmAddBird(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void frmAddBird_Load(object sender, EventArgs e)
        {
            dtmDOB.MaxDate = DateTime.Today;
            dtmDOB.MinDate = DateTime.Today.AddYears(-30);
            dtmDOB.Value = DateTime.Today.AddYears(-1);

            cboTrainer.DataSource = Trainer.getAllTrainers().Tables[0];
            cboTrainer.DisplayMember = "Name";
            cboTrainer.ValueMember = "trainerID";

            cboSpecies.DataSource = Species.getAllSpecies().Tables[0];
            cboSpecies.DisplayMember = "Description";
            cboSpecies.ValueMember = "speciesID";

            cboGender.DataSource = Gender.getAllGenders().Tables[0];
            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "GenderID";

            txtBirdID.Text = Bird.getNextBirdID().ToString("0000000");
            txtStatus.Text = "A";
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if ( !txtName.Text.All(char.IsLetter) )
            {
                MessageBox.Show("Name must only contain letters!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else {
                Bird aBird = new Bird(Convert.ToInt32(txtBirdID.Text), txtName.Text, dtmDOB.Value, txtStatus.Text, Convert.ToInt32(Trainer.findTrainerID(cboTrainer.Text)), Species.findSpeciesID(cboSpecies.Text), Gender.findGenderID(cboGender.Text));

                aBird.addBird();

                MessageBox.Show("Bird " + txtBirdID.Text + " added successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Text = null;
                txtBirdID.Text = Bird.getNextBirdID().ToString();
                txtName.Focus();
            }
        }

    }
}
