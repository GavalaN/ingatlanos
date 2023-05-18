using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    struct ingatlan{
        public int id;
        public string cim;
        public int alap;
        public int ar;
    }
    struct ugyfel{
        public int azon;
        public string nev;
        public int telefon;
    }
    class Program
    {
        static List<ingatlan> Ingatlan(List<ingatlan> lista)
        {
            ingatlan sor;
            StreamReader sr = new StreamReader(@"ingatlan.txt" + Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split('\t');
                sor.id = int.Parse(temp[0]);
                sor.cim = temp[1];
                sor.alap = int.Parse(temp[2]);
                sor.ar = int.Parse(temp[3]);
                lista.Add(sor);
            }
            sr.Close();
            return lista;
        }
        static List<ugyfel> Ugyfel(List<ugyfel> lista)
        {
            ugyfel sor;
            StreamReader sr = new StreamReader(@"ugyfel.txt" + Encoding.UTF8);
            while (!sr.EndOfStream)
            {
                string[] temp = sr.ReadLine().Split('\t');
                sor.azon = int.Parse(temp[0]);
                sor.nev = temp[1];
                sor.telefon = int.Parse(temp[2]);
                lista.Add(sor);
            }
            sr.Close();
            return lista;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            List<ingatlan> uj =new List<ingatlan>();
            uj = Ingatlan(uj);
        }
    }
}
