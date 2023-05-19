using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Ingatlan
    {
        int id;
        string cim;
        double terulet;
        int ar;

        public Ingatlan(int id, string cim, double terulet, int ar)
        {
            this.id = id;
            this.cim = cim;
            this.terulet = terulet;
            this.ar = ar;
        }


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
        public Ugyfel(int id, string nev, string telefonszam)
        {
            this.id = id;
            this.nev = nev;
            this.telefonszam = telefonszam;
        }

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
        static List<Ingatlan> IngatlanokBeOlvas(List<Ingatlan> lista)
        {
            StreamReader sr = new StreamReader(@"ingatlan.txt");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split('\t');
                lista.Add(new Ingatlan(int.Parse(temp[0]), temp[1], int.Parse(temp[2]), int.Parse(temp[3])));
            }
            sr.Close();
            return lista;
        }
        static List<Ugyfel> UgyfelekBeOlvas(List<Ugyfel> lista)
        {
            StreamReader sr = new StreamReader(@"ugyfel.txt");
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split('\t');
                lista.Add(new Ugyfel(int.Parse(temp[0]), temp[1], temp[2]));
            }
            sr.Close();
            return lista;
        }
        static void Main(string[] args)
        {
            List<Ingatlan> ingatlanok = new List<Ingatlan>();
            IngatlanokBeOlvas(ingatlanok);
            for (int i = 0; i < ingatlanok.Count; i++)
            {
                Console.WriteLine(ingatlanok[i].Id + "\t" + ingatlanok[i].Cim + "\t" + ingatlanok[i].Terulet + "\t" + ingatlanok[i].Ar);
            }
            List<Ugyfel> ugyfelek = new List<Ugyfel>();
            Console.WriteLine();
            UgyfelekBeOlvas(ugyfelek);
            for (int i = 0; i < ugyfelek.Count; i++)
            {
                Console.WriteLine(ugyfelek[i].Id + "\t" + ugyfelek[i].Nev + "\t" + ugyfelek[i].Telefonszam);
            }
            Console.ReadKey();
        }
    }
}
