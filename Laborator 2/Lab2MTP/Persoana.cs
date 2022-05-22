using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2MTP
{
    [DefaultPropertyAttribute("Nume")]
    class Persoana
    {
        private int index;
        private string nume;
        private DateTime dataNasterii;
        private string telefon;
        private string adresa;
        private Categorie categorie;
        public Persoana(int index, string nume, DateTime dataNasterii, string telefon, string adresa, Categorie categorie)
        {
            this.index = index;
            this.nume = nume;
            this.dataNasterii = dataNasterii;
            this.telefon = telefon;
            this.adresa = adresa;
            this.categorie = categorie;
        }

        
        [Description("Index"), Browsable(false)]
        public int Index { get { return index; } }
        [Description("Numele complet al persoanei"), Category("Date personale")]
        public string Nume { get { return nume; } }
        [Description("Data nasterii"), Category("Date personale")]
        public string DataNasterii { get { return dataNasterii.ToString("dd.MM.yyyy"); } }
        [Description("Categoria de incadrare"), Category("Date personale") ]
        public Categorie Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
        [Description("Numarul de telefon"), Category("Date personale") ]
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        [Description("Adresa completa"), Category("Date personale") ]
        public string Adresa
        {
            get { return adresa; }
            set { adresa = value; }
        }
    }
   

        
}

