using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator1
{
    class Student:Persoana
    {
        private byte an;
        private byte[] note = new byte[5];

        public Student(string nume,byte varsta,byte an,byte[] note):base(nume,varsta)
        {
            this.an = an;
            this.note = note;
        }
        public byte AnStudiu
        {
            get { return an; }
        }
        public string NumeStudent
        {
            get { return nume; }
        }
        public float Medie()
        {
            float m = 0;
            foreach(byte n in note)
            {
                m += n;
            }
            return m / 5;
        }
        public string AfisareStudent()
        {
            return nume + ", " + varsta + "ani, anul" + an + ", " + "media" +Medie();
        }
    }
}
