using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2MTP
{
    public partial class Form1 : Form
    {
        List<Persoana> agenda = new List<Persoana>();
        int maxIndex = 0;
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Actualizare();
            
        }
        private void Actualizare()
        {
            txtNume.Text = "";
            txtTelefon.Text = "";
            txtTelefon.Text = "";
            txtAdresa.Text = "";
            cmbCategorie.SelectedIndex = 0;
            tvwAgenda.Nodes.Clear();
            pgdAgenda.SelectedObject = null;
            tvwAgenda.Nodes.Add("Prieteni", "Prieteni", 1);
            tvwAgenda.Nodes.Add("Colegi", "Colegi", 2);
            tvwAgenda.Nodes.Add("Rude", "Rude", 3);
            tvwAgenda.Nodes.Add("Diversi", "Diversi", 4);
           
            foreach(Persoana p in agenda)
            {
                TreeNode myNode;
                switch (p.Categorie)
                {
                    case Categorie.Prieteni:
                        myNode = tvwAgenda.Nodes["Prieteni"];
                        break;
                    case Categorie.Colegi:
                        myNode = tvwAgenda.Nodes["Colegi"];
                        break;
                    case Categorie.Rude:
                        myNode = tvwAgenda.Nodes["Rude"];
                        break;
                    default:
                        myNode = tvwAgenda.Nodes["Diversi"];
                        break;
                }
                myNode.Nodes.Add(p.Index.ToString(), p.Nume, GetImageIndex(p.Categorie));
            }
            


        }
        private int GetImageIndex(Categorie categorie)
        {
            return Convert.ToInt32(categorie) + 1;
        }
        private bool VerificaDuplicat(Persoana p)
        {
            Persoana pers = agenda.Find(delegate (Persoana myPers)
              {
                  return myPers.Nume == p.Nume;
              });
            return (pers != null);
        }
        private void adauga_Click(object sender, EventArgs e)
        {
            Persoana p;
            p = new Persoana(maxIndex++, txtNume.Text, dateTimePicker1.Value, txtTelefon.Text, txtAdresa.Text, (Categorie)cmbCategorie.SelectedIndex);
            bool duplicat = VerificaDuplicat(p);
            if (!duplicat)
            {
                agenda.Add(p);
                Actualizare();
            }
            else
                MessageBox.Show("Persoana exista in agenda","Dublura", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        private void tvwAgenda_AfterSelect(object sender, TreeViewEventArgs e)
        {
            Persoana pers;
            int index;
            pgdAgenda.SelectedObject = null;
            if(int.TryParse(e.Node.Name,out index))
            {
                pers = getByIndex(index);
                if(pers!=null)
                {
                    pgdAgenda.SelectedObject = pers;
                }
            }
        }

        private Persoana getByIndex(int index)
        {
            foreach(Persoana p in agenda)
            {
                if (p.Index == index)
                    return p;
               
            }
            return null;
        }

        private void btnSalveaza_Click(object sender, EventArgs e)
        {
            string dir = Application.StartupPath;
            StreamWriter sw = new StreamWriter(dir + "\\agenda.txt", false);
            foreach (Persoana p in agenda)
            {
                sw.WriteLine("Nume: " + p.Nume);
                sw.WriteLine("Categorie: " + p.Categorie);
                sw.WriteLine("Data nasterii: " + p.DataNasterii);
                sw.WriteLine("Telefon: " + p.Telefon);
                sw.WriteLine("Adresa: " + p.Adresa);
                sw.WriteLine("-----------------------");
            }
            sw.Close();
            Process.Start("notepad.exe", dir + "\\agenda.txt");

        }

        private void btnCauta_Click(object sender, EventArgs e)
        {
            Persoana pers = agenda.Find(delegate (Persoana p)
             {
                 return p.Nume == txtCautare.Text;
             });
            if (pers == null)
                MessageBox.Show("Persoana nu a fost gasita in agenda");
            else
                pgdAgenda.SelectedObject = pers;
        }

        private void btnSterge_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Doriti sa stergeti persoana [" + tvwAgenda.SelectedNode.Text + "]", "Intrebare", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Persoana p = agenda.Find(Pers => Pers.Nume == tvwAgenda.SelectedNode.Text);
                    agenda.Remove(p);
                    tvwAgenda.Nodes.Clear();
                    Actualizare();
                
                    
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show("Nicio persoana nu a fost selectata");
            }
        }

        private void btnIncarcare_Click(object sender, EventArgs e)
        {
           
            try
            {
                string dir = Application.StartupPath;
                string nume, categorie, dataNasterii, telefon, adresa,linie,dubluri="";
                
                bool duplicat;
                StreamReader sr = new StreamReader(dir + "\\agenda.txt");
                    while ((linie = sr.ReadLine()) != null)
                    {
                        nume = linie.Substring(6);
                        linie = sr.ReadLine();
                        categorie = linie.Substring(11);
                        linie = sr.ReadLine();
                        dataNasterii = linie.Substring(15);
                        linie = sr.ReadLine();
                        telefon = linie.Substring(9);
                        linie = sr.ReadLine();
                        adresa = linie.Substring(8);
                        sr.ReadLine();
                        DateTime date = DateTime.ParseExact(dataNasterii, "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        Persoana p = new Persoana(maxIndex++, nume, date, telefon, adresa, (Categorie)Enum.Parse(typeof(Categorie), categorie));
                        duplicat = VerificaDuplicat(p);
                    if (duplicat == false)
                    {
                        agenda.Add(p);
                        Actualizare();
                    }
                    else
                        dubluri += p.Nume + "\n";

                    }
                if (dubluri.Length > 0)
                    MessageBox.Show("Dubluri intre agenda actuala si fisierul agenda.txt: \n" + dubluri);
                   sr.Close();
            }
            catch(Exception ee)
            {
                
                MessageBox.Show(ee.ToString());
            }
            
        }

        private void pgdAgenda_PropertyValueChanged(object s, PropertyValueChangedEventArgs e)
        {
            if(e.ChangedItem.Label.CompareTo("Categorie")==0)
            {
                if(e.ChangedItem.Value.ToString().CompareTo(e.OldValue.ToString())!=0)
                {
                    String nume = tvwAgenda.SelectedNode.Text;
                    Persoana p = agenda.Find(pers => pers.Nume == nume);
                    Actualizare();
                    pgdAgenda.SelectedObject = p;
                    
                    
                }
            }

            
        }
    }
    enum Categorie : int
    {
        Prieteni,
        Colegi,
        Rude,
        Diversi
    };
}
