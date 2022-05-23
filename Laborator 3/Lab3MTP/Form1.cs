using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3MTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            txtUtilizator.Text = "Admin";
            txtParola.Text = "Admin";
        }

     

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtUtilizator.Text.CompareTo("Admin") != 0 || txtParola.Text.CompareTo("Admin") != 0)
            {
                errorProvider.SetError(txtUtilizator, "Combinatie invalida");
                errorProvider.SetError(txtParola, "Combinatie invalida");
                return;
            }
            errorProvider.Clear();
            btnOk.Enabled = false;
            btnCancel.Enabled = false;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
           if( progressBar.Value+1>progressBar.Maximum)
            {
                timer.Stop();
                DialogResult = DialogResult.OK;
                return;
            }
            progressBar.Value++;
        }
    }
}
