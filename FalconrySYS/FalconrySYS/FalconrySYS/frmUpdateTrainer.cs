using System;
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
    public partial class frmUpdateTrainer : Form
    {
        Trainer theTrainer = new Trainer();
        frmMainMenu parent;
        public frmUpdateTrainer()
        {
            InitializeComponent();
        }

        public frmUpdateTrainer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateTrainer_Load(object sender, EventArgs e)
        {
            dtmDOB.MinDate = DateTime.Today.AddYears(-70);
            dtmDOB.MaxDate = DateTime.Today.AddYears(-16);
            dtmDOB.Value = DateTime.Today.AddYears(-18);

            cboNameFind.DataSource = Trainer.getAllTrainers().Tables[0];
            cboNameFind.DisplayMember = "Name";
            cboNameFind.ValueMember = "TrainerID";

            cboGender.DataSource = Gender.getAllGenders().Tables[0];
            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "GenderID";
        }

        private void btnFindBird_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cboNameFind.SelectedValue);

            theTrainer.getTrainer(ID);

            txtName.Text = theTrainer.getName();
            dtmDOB.Value = theTrainer.getDob();

            String genderID = theTrainer.getGender();
            cboGender.Text = Gender.findGenderDescription(genderID);

            cboStatus.Text = theTrainer.getStatus();
            txtTrainerID.Text = theTrainer.getTrainerID().ToString();

            grpTrainerIDStatus.Visible = true;
            grpFindTrainer.Visible = false;
            grpTrainerDetails.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text.Replace("'", "");
            newName = newName.Replace("-", "");
            newName = newName.Replace(" ", "");
            if (!newName.All(char.IsLetter))
            {
                MessageBox.Show("Name must only contain letters, a single quote (') or a hyphon (-)!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else
            {
                if (txtName.Text.Contains("'"))
                {
                    txtName.Text = txtName.Text.Replace("'", "''");
                }
                theTrainer.setName(txtName.Text);
                theTrainer.setDob(dtmDOB.Value);
                theTrainer.setGender(Gender.findGenderID(cboGender.Text));
                theTrainer.setStatus(cboStatus.Text);

                theTrainer.updateTrainer();

                MessageBox.Show("Trainer " + txtTrainerID.Text + " updated successfully", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                grpTrainerIDStatus.Visible = false;
                grpFindTrainer.Visible = true;
                grpTrainerDetails.Visible = false;
            }
            cboNameFind.Items.Clear();
            cboNameFind.DataSource = Trainer.getAllTrainers().Tables[0];
            cboNameFind.DisplayMember = "Name";
            cboNameFind.ValueMember = "TrainerID";
        }
    }
}
