using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FalconrySYS
{
    public partial class frmUpdateBird : Form
    {
        Bird theBird = new Bird();
        frmMainMenu parent;
        public frmUpdateBird()
        {
            InitializeComponent();
        }

        public frmUpdateBird(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateBird_Load(object sender, EventArgs e)
        {
            dtmDOB.MaxDate = DateTime.Today;
            dtmDOB.MinDate = DateTime.Today.AddYears(-30);
            dtmDOB.Value = DateTime.Today.AddYears(-1);

            cboSpeciesFind.DataSource = Species.getAllSpecies().Tables[0];
            cboSpeciesFind.DisplayMember = "Description";
            cboSpeciesFind.ValueMember = "SpeciesID";

            cboTrainer.DataSource = Trainer.getAllTrainers().Tables[0];
            cboTrainer.DisplayMember = "Name";
            cboTrainer.ValueMember = "trainerID";

            cboSpecies.DataSource = Species.getAllSpecies().Tables[0];
            cboSpecies.DisplayMember = "Description";
            cboSpecies.ValueMember = "SpeciesID";

            cboGender.DataSource = Gender.getAllGenders().Tables[0];
            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "GenderID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cboNameFind.SelectedValue);

            theBird.getBird(ID);

            txtName.Text = theBird.getName();
            dtmDOB.Value = theBird.getDob();

            int trainerID = theBird.getTrainer();
            cboTrainer.Text = Trainer.findTrainerName(trainerID.ToString());

            String speciesID = theBird.getSpecies();
            cboSpecies.Text = Species.findSpeciesDescription(speciesID);

            String genderID = theBird.getGender();
            cboGender.Text = Gender.findGenderDescription(genderID);

            cboStatus.Text = theBird.getStatus();
            txtBirdID.Text = theBird.getBirdID().ToString();

            grpBirdIDStatus.Visible = true;
            grpFindBird.Visible = false;
            grpBirdDetails.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            theBird.setName(txtName.Text);
            theBird.setDob(dtmDOB.Value);
            theBird.setTrainer(Convert.ToInt32(Trainer.findTrainerID(cboTrainer.Text)));
            theBird.setSpecies(Species.findSpeciesID(cboSpecies.Text));
            theBird.setGender(Gender.findGenderID(cboGender.Text));
            theBird.setStatus(cboStatus.Text);

            theBird.updateBird();

            MessageBox.Show("Bird " + txtBirdID.Text + " updated successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboSpeciesFind_SelectedIndexChanged(sender, e);
            grpBirdIDStatus.Visible = false;
            grpFindBird.Visible = true;
            grpBirdDetails.Visible = false;
        }

        private void backToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void cboSpeciesFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNameFind.DataSource = null;
            cboNameFind.DataSource = Bird.getAllBirds(Species.findSpeciesID(cboSpeciesFind.Text)).Tables[0];
            cboNameFind.DisplayMember = "Name";
            cboNameFind.ValueMember = "BirdID";
        }
    }
}
