using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Ingatlan
    {
        int id;
        string cim;
        double terulet;
        int ar;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Cim
        {
            get
            {
                return this.cim;
            }
            set
            {
                this.cim = value;
            }
        }
        public double Terulet
        {
            get
            {
                return this.terulet;
            }
            set
            {
                this.terulet = value;
            }
        }
        public int Ar
        {
            get
            {
                return this.ar;
            }
            set
            {
                this.ar = value;
            }
        }
    }

    class Ugyfel
    {
        int id;
        string nev;
        string telefonszam;

        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        public string Nev
        {
            get
            {
                return this.nev;
            }
            set
            {
                this.nev = value;
            }
        }
        public string Telefonszam
        {
            get
            {
                return this.telefonszam;
            }
            set
            {
                this.telefonszam = value;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadKey();
        }
    }
}
