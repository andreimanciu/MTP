using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3MTP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (txtEchipa.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtEchipa, "Numele echipei trebuie completat");
                return;
            }
            else if (Directory.Exists(Application.StartupPath + "\\" + txtEchipa.Text))
            {
                errorProvider1.SetError(txtEchipa,"Exista deja o echipa cu acelasi nume");
                return;
            }
            Directory.CreateDirectory(Application.StartupPath + "\\" + txtEchipa.Text);
            DialogResult = DialogResult.OK;
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
