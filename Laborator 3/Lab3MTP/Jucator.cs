using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3MTP
{
    class Jucator
    {
        string cnp;
        string nume;
        Post post;
        public Jucator(){}
        public Jucator(string cnp,string nume,Post post)
        {
            this.cnp = cnp;
            this.nume = nume;
            this.post = post;
        }
        public string CNP { get => cnp; set => cnp = value; }
        public string Nume { get => nume; set => nume = value; }
        internal Post Post { get => post; set => post = value; }
        public DateTime DataNasterii
        {
            get
            {

                DateTime dn=new DateTime();
                int.TryParse(cnp.Substring(1, 2), out int an);
                int.TryParse(cnp.Substring(3, 2), out int luna);
                int.TryParse(cnp.Substring(5, 2), out int zi);
                if (cnp.Substring(0, 1).CompareTo("1") == 0 || cnp.Substring(0, 1).CompareTo("2") == 0)
                    dn = new DateTime(1900 + an, luna, zi);
                else if (cnp.Substring(0, 1).CompareTo("5") == 0 || cnp.Substring(0, 1).CompareTo("6") == 0)
                     dn = new DateTime(2000+an,luna,zi);
                return dn;
            }
        }
        public int Varsta
        {
            get
            {
                long ticks = DateTime.Now.Ticks - DataNasterii.Ticks;
                DateTime dt = new DateTime(ticks);
                return dt.Year - 1;
            }
        }

    }
    enum Post
    {
        Portar,
        Fundas,
        Mijlocas,
        Atacant
    }
}
