using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator1
{
    public partial class Form1 : Form
    {
        private List<Student> lista = new List<Student>();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonAdauga_Click(object sender, EventArgs e)
        {
            byte[] n = new byte[5];
            try
            {
                    n[0] = Convert.ToByte(comboBoxNote1.Text);
                    n[1] = Convert.ToByte(comboBoxNote2.Text);
                n[2] = Convert.ToByte(comboBoxNote3.Text);
                n[3] = Convert.ToByte(comboBoxNote4.Text);
                n[4] = Convert.ToByte(comboBoxNote5.Text);
                Student s = new Student(textBoxNume.Text, Convert.ToByte(numericUpDownVarsta.Value),
                    Convert.ToByte(comboBoxAn.Text), n);
                lista.Add(s);
                AfisareLista();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void AfisareLista()
        {
            listStudenti.Items.Clear();
            foreach(Student s in lista)
            {
                listStudenti.Items.Add(s.AfisareStudent());
            }
        }

        private void buttonOrdonarenume_Click(object sender, EventArgs e)
        {
            ComparaNume comp = new ComparaNume();
            lista.Sort(comp);
            AfisareLista();
        }

        private void buttonOrdonaremedie_Click(object sender, EventArgs e)
        {
            ComparaMedie comp = new ComparaMedie();
            lista.Sort(comp);
            AfisareLista();
        }

        private void buttonAfisarestudenti_Click(object sender, EventArgs e)
        {

            try
            {
                byte n=Convert.ToByte(comboBoxAfisaredinanul.Text);
                listStudenti.Items.Clear();
                foreach(Student s in lista)
                {
                    if (s.AnStudiu == n)
                        listStudenti.Items.Add(s.AfisareStudent());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCautare_Click(object sender, EventArgs e)
        {
            try
            {
                string n = textBoxCautare.Text;
                listStudenti.Items.Clear();
                foreach (Student s in lista)
                {
                    if (n == s.NumeStudent)
                    {
                        listStudenti.Items.Add(s.AfisareStudent());
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //lista.RemoveAt(1);
            //AfisareLista();
            try
            {
                int n = listStudenti.SelectedIndex;
                listStudenti.Items.RemoveAt(listStudenti.SelectedIndex);
                lista.RemoveAt(n);
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
