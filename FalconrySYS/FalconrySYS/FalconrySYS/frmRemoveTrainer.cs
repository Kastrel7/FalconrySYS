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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace FalconrySYS
{
    public partial class frmRemoveTrainer : Form
    {
        Trainer theTrainer = new Trainer();
        frmMainMenu parent;
        public frmRemoveTrainer()
        {
            InitializeComponent();
        }

        public frmRemoveTrainer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRemoveTrainer_Load(object sender, EventArgs e)
        {
            cboNameFind.DataSource = Trainer.getAllTrainers().Tables[0];
            cboNameFind.DisplayMember = "Name";
            cboNameFind.ValueMember = "TrainerID";
        }

        private void btnFindBird_Click(object sender, EventArgs e)
        {
            int ID = Convert.ToInt32(cboNameFind.SelectedValue);

            theTrainer.getTrainer(ID);

            lblName.Text = theTrainer.getName();
            dtmDOB.Value = theTrainer.getDob();
            String genderID = theTrainer.getGender();
            lblGender.Text = Gender.findGenderDescription(genderID);
            txtStatus.Text = theTrainer.getStatus();
            txtTrainerID.Text = theTrainer.getTrainerID().ToString();

            grpTrainerIDStatus.Visible = true;
            grpFindTrainer.Visible = false;
            grpTrainerDetails.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            theTrainer.setStatus("R");

            theTrainer.updateTrainer();

            MessageBox.Show("Trainer " + txtTrainerID.Text + " removed successfully", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            grpTrainerIDStatus.Visible = false;
            grpFindTrainer.Visible = true;
            grpTrainerDetails.Visible = false;

            cboNameFind.Items.Clear();
            cboNameFind.DataSource = Trainer.getAllTrainers().Tables[0];
            cboNameFind.DisplayMember = "Name";
            cboNameFind.ValueMember = "TrainerID";
        }
    }
}
