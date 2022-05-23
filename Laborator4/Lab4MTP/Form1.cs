using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4MTP
{
    public partial class Form1 : Form
    {
        public static string imgFolder = @"D:\UPT\Anul 3\Mtp\Lab4_MTP_Laiu Lucian-Laurentiu\Lab4MTP\_IMG";
        public Form1()
        {
            InitializeComponent();
        }

        private void pacientiBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pacientDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pacientDataSet.Radiografii' table. You can move, or remove it, as needed.
            this.radiografiiTableAdapter.Fill(this.pacientDataSet.Radiografii);
            // TODO: This line of code loads data into the 'pacientDataSet.Pacienti' table. You can move, or remove it, as needed.
            this.pacientiTableAdapter.Fill(this.pacientDataSet.Pacienti);
            
            
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientiBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pacientDataSet);
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(((DataRowView)pacientiBindingSource.Current)["CNP"].ToString());
            if(f.ShowDialog()==DialogResult.OK)
            {
                radiografiiTableAdapter.Insert(f.CNP, f.Imagine, f.Data, f.Diagnostic, f.Comentarii);
                tableAdapterManager.UpdateAll(pacientDataSet);
                radiografiiTableAdapter.Fill(pacientDataSet.Radiografii);
                
                ShowImages();
            }
        }

        private void ShowImages()
        {
            PictureBox myPict;
            int index = 0;
            flowLayoutPanel1.Controls.Clear();
            picBoxDimensComplet.Image = null;
            txtDetalii.Text = "";
            
            foreach (DataRowView drv in radiografiiBindingSource.List)
            {
                String detalii = "";
                myPict = new PictureBox();
                myPict.Name = "Picture" + index.ToString();
                myPict.SetBounds(0, 0, 90, 70);
                myPict.BackColor = Color.Black;
                myPict.SizeMode = PictureBoxSizeMode.Zoom;
                myPict.Image = Image.FromFile(imgFolder + @"\" + drv["Imagine"]);
                DateTime dt = (DateTime)drv["Data"];
                detalii += "Data:"+dt.ToString("dd.MM.yyyy")+Environment.NewLine;
                detalii += "Diagnostic:" + drv["Diagnostic"] + Environment.NewLine;
                detalii += "Comentarii:" + drv["comentarii"] + Environment.NewLine;
                myPict.Tag = detalii;
                
                flowLayoutPanel1.Controls.Add(myPict);

                myPict.Click += myPict_Click;
            }
        }

        private void myPict_Click(object sender, EventArgs e)
        {
            PictureBox pic = (PictureBox)sender;
            picBoxDimensComplet.SizeMode = PictureBoxSizeMode.AutoSize;
            picBoxDimensComplet.Image = pic.Image;
            txtDetalii.Visible = true;
            txtDetalii.Text = "";
            txtDetalii.Text += pic.Tag;
            
        }

        private void pacientiDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDetalii.Visible = false;
            ShowImages();
        }

        private void txtCautare_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtCautare.Text.Length != 0)
            {
                if (e.KeyCode == Keys.Enter)
                {

                    pacientiBindingSource.Filter = "Nume=" + "'" + txtCautare.Text + "'";
                    
                }
            }
            else { 
            pacientiBindingSource.RemoveFilter();
            }
        }
    }
}
