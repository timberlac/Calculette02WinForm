using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculette02WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEffacer_Click(object sender, EventArgs e)
        {
            txtValeur1.Text = "";
            txtValeur2.Text = "";
            txtResultat.Text = "";
            lblOperation.Text = "";
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            try            // évite les plantage si les valeurs sont fausses
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) + float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "+";
            }
            catch
            { }
        }

        private void btnMultiplier_Click(object sender, EventArgs e)
        {
            try            // évite les plantage si les valeurs sont fausses
            {
                txtResultat.Text = (float.Parse(txtValeur1.Text) * float.Parse(txtValeur2.Text)).ToString();
                lblOperation.Text = "X";
            }
            catch
            { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnEffacer_Click(null,null);
        }

        private void txtValeur1_TextChanged(object sender, EventArgs e)
        {
            annuleOperations();
        }

        private void txtValeur2_TextChanged(object sender, EventArgs e)
        {
            annuleOperations();
        }
        private void annuleOperations()
        {
            txtResultat.Text = "";
            lblOperation.Text = "";
        }
    }
}
