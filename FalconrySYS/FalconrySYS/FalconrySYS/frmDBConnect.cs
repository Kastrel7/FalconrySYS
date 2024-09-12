using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess;
using Oracle.ManagedDataAccess.Client;

namespace FalconrySYS
{
    public partial class frmDBConnect : Form
    {
        OracleConnection conn;
        frmMainMenu parent;
        public frmDBConnect()
        {
            InitializeComponent();
        }

        public frmDBConnect(frmMainMenu parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DBConnect.setConnection(txtUsername.Text, txtPassword.Text);
            conn = new OracleConnection(DBConnect.connection);

            try
            {
                conn.Open();
                lblConn.Text = "Connection Succesful";
                conn.Close();
                btnContinue.Visible = true;
                Booking.updateStatus();
            }
            catch(Exception ex)
            {
                lblConn.Text = "Unable to connect to database with error:\n" + ex.Message;
                return;
            }
            
        }

        private void frmDBConnect_Load(object sender, EventArgs e)
        {
            lblConn.Text = "Not Connected";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chbPass.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '•';
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            parent.Visible = true;
        }
    }
}
