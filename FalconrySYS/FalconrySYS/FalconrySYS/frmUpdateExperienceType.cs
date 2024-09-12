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
    public partial class frmUpdateExperienceType : Form
    {
        Experience theExperience = new Experience();
        frmMainMenu parent;
        public frmUpdateExperienceType()
        {
            InitializeComponent();
        }

        public frmUpdateExperienceType(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmUpdateExperienceType_Load(object sender, EventArgs e)
        {
            cboExp.DataSource = Experience.getAllExperiences().Tables[0];
            cboExp.DisplayMember = "Description";
            cboExp.ValueMember = "ExperienceID";
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String ID = cboExp.SelectedValue.ToString();

            theExperience.getExperience(ID);

            txtExpID.Text = theExperience.getId();
            cboStatus.Text = theExperience.getStatus();
            txtCost.Value = theExperience.getCost();
            txtDescription.Text = theExperience.getDesctiption();

            grpFindExperience.Visible = false;
            grpDetails.Visible = true;

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtExpID.Text.Equals(""))
            {
                MessageBox.Show("ExperienceID must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExpID.Focus();
            }
            else if (txtExpID.Text.Any(char.IsDigit))
            {
                MessageBox.Show("ExperienceID must not be numeric!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExpID.Focus();
            }
            else if (txtExpID.Text.Length < 2)
            {
                MessageBox.Show("ExperienceID must be 2 characters!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtExpID.Focus();
            }
            else if (txtCost.Text.Equals(""))
            {
                MessageBox.Show("Cost must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCost.Focus();
            }
            else if (txtCost.Text.All(char.IsDigit) == false)
            {
                MessageBox.Show("Cost must be numeric!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCost.Focus();
            }
            else if (txtDescription.Text.Equals(""))
            {
                MessageBox.Show("Description must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
            }
            else if (txtDescription.Text.Any(char.IsDigit))
            {
                MessageBox.Show("Description must not be numeric!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDescription.Focus();
            }
            else
            {
                theExperience.setID(txtExpID.Text);
                theExperience.setCost(txtCost.Value);
                theExperience.setStatus(cboStatus.Text);
                theExperience.setDescription(txtDescription.Text);

                theExperience.updateExperience();

                MessageBox.Show("Experience Type Updated!", "Experience Type");

                grpFindExperience.Visible = true;
                grpDetails.Visible = false;
                cboExp.Focus();
            }
        }
    }
}
