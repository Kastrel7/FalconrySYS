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
    public partial class frmRegisterTrainer : Form
    {

        frmMainMenu parent;
        public frmRegisterTrainer()
        {
            InitializeComponent();
        }

        public frmRegisterTrainer(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void frmRegisterTrainer_Load(object sender, EventArgs e)
        {
            dtmDOB.MinDate = DateTime.Today.AddYears(-70);
            dtmDOB.MaxDate = DateTime.Today.AddYears(-16);
            dtmDOB.Value = DateTime.Today.AddYears(-18);

            cboGender.DataSource = Gender.getAllGenders().Tables[0];
            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "GenderID";

            txtTrainerID.Text = Trainer.getNextTrainerID().ToString("0000000");
            txtStatus.Text = "A";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("Name must be entered!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
            }
            else if ( txtName.Text.Contains("'") || txtName.Text.Contains("-") || txtName.Text.Contains(" ") )
            {
                string newName = txtName.Text.Replace("'", "");
                newName = newName.Replace("-", "");
                newName = newName.Replace(" ", "");
                Console.WriteLine(newName);
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
                    Trainer aTrainer = new Trainer(Convert.ToInt32(txtTrainerID.Text), txtName.Text, dtmDOB.Value, txtStatus.Text, Gender.findGenderID(cboGender.Text));

                    aTrainer.addTrainer();

                    MessageBox.Show("Trainer " + txtTrainerID.Text + " added successfully", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtName.Text = null;
                    txtTrainerID.Text = Bird.getNextBirdID().ToString();
                    txtName.Focus();
                }
            }
        }
    }
}
