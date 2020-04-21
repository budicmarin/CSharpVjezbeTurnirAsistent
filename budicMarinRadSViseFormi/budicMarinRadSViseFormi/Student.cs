using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinRadSViseFormi
{
    public class Student
    {
        private string ime;
        private string prezime;
        private string brojIndeksa;
        private string smjer;
        private DateTime datumRodjenja;
        public Student()
        {

        }
        public string Ime
        {
            get
            {
                return ime;
            }
            set
            {
                ime = value;
            }
        }
        public string Prezime
        {
            get
            {
                return prezime;
            }
            set
            {
                prezime = value;
            }
        }
        public string BrojIndeksa
        {
            get
            {
                return brojIndeksa;
            }
            set
            {
                brojIndeksa = value;
            }
        }
        public string Smjer
        {
            get
            {
                return smjer;
            }
            set
            {
                smjer = value;
            }
        }

        public DateTime DatumRodjenja
        {
            get
            {
                return datumRodjenja;
            }
            set
            {
                datumRodjenja = value;
            }
        }

        public override string ToString()
        {
            return ime + " " + prezime + " " + brojIndeksa + " " + datumRodjenja.ToShortDateString() + " " + smjer;
        }
    }



}

