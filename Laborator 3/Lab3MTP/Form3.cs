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
    public partial class Form3 : Form
    {
        public string Nume { get => txtNume.Text; set => txtNume.Text = value; }
        public string Cnp { get => txtCNP.Text; set => txtCNP.Text = value; }
        internal Post Post
        {
            get => (Post)Enum.Parse(typeof(Post), cmbPost.Text);
            set => cmbPost.Text = value.ToString();
        }
        public Form3()
        {
            InitializeComponent();
            //cmbPost.SelectedIndex = 0;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            if (DateValide())
            {
                DialogResult = DialogResult.OK;
            }
        }

        private bool DateValide()
        {
            bool result = true;
            errorProvider1.Clear();
            errorProvider2.Clear();
            if (txtNume.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNume, "Numele trebuie completat");
                result = false;
            }
            if (txtCNP.Text.Trim().Length == 0)
            {
                errorProvider2.SetError(txtCNP, "CNP trebuie completat");
                result = false;
            }
            else if (txtCNP.Text.Trim().Length != 13)
            {
                errorProvider2.SetError(txtCNP, "CNP trebuie sa aiba 13 cifre");
                result = false;
            }
            else
            {
                try
                {
                    DateTime dn = new DateTime();
                    int.TryParse(txtCNP.Text.Substring(1, 2), out int an);
                    int.TryParse(txtCNP.Text.Substring(3, 2), out int luna);
                    int.TryParse(txtCNP.Text.Substring(5, 2), out int zi);
                    if (txtCNP.Text.Substring(0, 1).CompareTo("1") == 0 || txtCNP.Text.Substring(0, 1).CompareTo("2") == 0)
                        dn = new DateTime(1900 + an, luna, zi);
                    else if (txtCNP.Text.Substring(0, 1).CompareTo("5") == 0 || txtCNP.Text.Substring(0, 1).CompareTo("6") == 0)
                        dn = new DateTime(2000 + an, luna, zi);
                }
                catch(Exception ex)
                {
                    result = false;
                    errorProvider2.SetError(txtCNP, ex.Message);
                }
            }
            return result;

        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
