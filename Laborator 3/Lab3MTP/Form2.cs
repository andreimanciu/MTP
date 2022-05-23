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
    public partial class Form2 : Form
    {
        public Form2()
        {
            
            InitializeComponent();
            IncarcaEchipe();
            
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            Form1 f = new Form1();

            if (f.ShowDialog() == DialogResult.Cancel)
                this.Close();
            //if (f.ShowDialog() == DialogResult.OK)
            //    this.Opacity = 100;


        }

        private void btnEchipa_Click(object sender, EventArgs e)
        {
            Form4 dlg = new Form4();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                IncarcaEchipe();
            }
        }

        private void IncarcaEchipe()
        {
            flowLayoutPanel1.Controls.Clear();
            cmbEchipa.Items.Clear();
            foreach(String dirPath in Directory.EnumerateDirectories(Application.StartupPath))
            {
                DirectoryInfo dirName =new DirectoryInfo(dirPath);
                cmbEchipa.Items.Add(dirName.Name);
            }
        }

        private void btnJucator_Click(object sender, EventArgs e)
        {
            if (cmbEchipa.Text.Length > 0)
            {
                Form3 f = new Form3();
                if (f.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Application.StartupPath + "\\" + cmbEchipa.Text + "\\" + f.Cnp + ".lpf";
                    using(StreamWriter sw=new StreamWriter(fileName))
                    {
                        sw.WriteLine(f.Nume);
                        sw.WriteLine(f.Post.ToString());
                    }
                    IncarcaJucatoriEchipa(cmbEchipa.Text);
                }
            }
        }

        private void IncarcaJucatoriEchipa(string echipa)
        {
            flowLayoutPanel1.Controls.Clear();
            string path = Application.StartupPath + "\\" + echipa;
            foreach(string fileName in Directory.EnumerateFiles(path, "*.lpf"))
            {
                using(StreamReader sr=new StreamReader(fileName))
                {
                    string cnp = Path.GetFileNameWithoutExtension(fileName);
                    string nume = sr.ReadLine();
                    Post post = (Post)Enum.Parse(typeof(Post), sr.ReadLine());
                    Jucator j = new Jucator(cnp, nume, post);
                    Button btn = new Button();
                    btn.Text = j.Nume;
                    btn.Width = 200;
                    btn.Tag = j;
                    flowLayoutPanel1.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Jucator j = (Jucator)btn.Tag;
            txtNume.Text = j.Nume;
            txtPost.Text = j.Post.ToString();
            txtCNP.Text = j.CNP;
            dateTimePicker1.Value= j.DataNasterii;
            txtVarsta.Text = j.Varsta.ToString();

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbEchipa_SelectedIndexChanged(object sender, EventArgs e)
        {
            IncarcaJucatoriEchipa(cmbEchipa.Text);
        }
    }
}
