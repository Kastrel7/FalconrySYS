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
    public partial class frmRemoveBird : Form
    {
        Bird theBird = new Bird();
        frmMainMenu parent;
        public frmRemoveBird()
        {
            InitializeComponent();
        }

        public frmRemoveBird(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRemoveBird_Load(object sender, EventArgs e)
        {
            cboSpeciesFind.DataSource = Species.getAllSpecies().Tables[0];
            cboSpeciesFind.DisplayMember = "Description";
            cboSpeciesFind.ValueMember = "SpeciesID";
        }

        private void cboSpeciesFind_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboNameFind.DataSource = null;
            cboNameFind.DataSource = Bird.getAllBirds(Species.findSpeciesID(cboSpeciesFind.Text)).Tables[0];
            cboNameFind.DisplayMember = "Name";
            cboNameFind.ValueMember = "BirdID";
        }

        private void btnFindBird_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cboNameFind.SelectedValue);

            theBird.getBird(ID);

            lblName.Text = theBird.getName();
            dtmDOB.Value = theBird.getDob();
            String trainerID = theBird.getTrainer().ToString();
            lblTrainer.Text = Trainer.findTrainerName(trainerID);
            String speciesID = theBird.getSpecies();
            lblSpecies.Text = Species.findSpeciesDescription(speciesID);
            String genderID = theBird.getGender();
            lblGender.Text = Gender.findGenderDescription(genderID);
            txtStatus.Text = theBird.getStatus();
            txtBirdID.Text = theBird.getBirdID().ToString();

            grpBirdIDStatus.Visible = true;
            grpFindBird.Visible = false;
            grpBirdDetails.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //theBird.setName(lblName.Text);
            //theBird.setDob(dtmDOB.Value);
            //theBird.setTrainer(Bird.findTrainerID(lblTrainer.Text));
            //theBird.setSpecies(Bird.findSpeciesID(lblSpecies.Text));
            //theBird.setGender(Bird.findGenderID(lblGender.Text));
            theBird.setStatus("R");

            theBird.updateBird();

            MessageBox.Show("Bird " + txtBirdID.Text + " removed successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            cboSpeciesFind_SelectedIndexChanged(sender, e);
            grpBirdIDStatus.Visible = false;
            grpFindBird.Visible = true;
            grpBirdDetails.Visible = false;
        }
    }
}
