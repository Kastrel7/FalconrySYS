using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FalconrySYS
{
    public partial class frmSetExperienceType : Form
    {
        frmMainMenu parent;
        public frmSetExperienceType()
        {
            InitializeComponent();
        }

        public frmSetExperienceType(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
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
                Experience aExperience = new Experience(txtExpID.Text.ToUpper(), "A", txtCost.Value, txtDescription.Text, 0);
                aExperience.addExperience();

                MessageBox.Show("Experience Type Created!", "Experience Type");
                txtExpID.Text = "";
                txtCost.Value = 0;
                txtDescription.Text = "";
                txtExpID.Focus();
            }
        }

        private void frmSetExperienceType_Load(object sender, EventArgs e)
        {

        }
    }
}
