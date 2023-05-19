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
            List<Ugyfel> ugyfelek = new List<Ugyfel>();
            UgyfelekBeOlvas(ugyfelek);
            
            int x = -9;
            bool dowhile = false;
            
            while(x!=0){
               
                Console.WriteLine("1=kiirtas,2=ingatlanfelvetel,3=ugyfelfelvetel,4=torles,0=kilep");
                do
                {
                    
                    try
                    {
                        x = int.Parse(Console.ReadLine());
                        dowhile = false;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Szar vagy");
                        dowhile = true;
                        
                    }
                } while (dowhile);
                
                switch (x)
                {
                    case 1:
                        {
                            for (int i = 0; i < ingatlanok.Count; i++)
                            {
                                Console.WriteLine(ingatlanok[i].Id + "\t" + ingatlanok[i].Cim + "\t" + ingatlanok[i].Terulet + "\t" + ingatlanok[i].Ar);
                            }

                            for (int i = 0; i < ugyfelek.Count; i++)
                            {
                                Console.WriteLine(ugyfelek[i].Id + "\t" + ugyfelek[i].Nev + "\t" + ugyfelek[i].Telefonszam);
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Adja meg a címet!");
                            string cim = Console.ReadLine();
                            Console.WriteLine("Adja meg az ingatlan Területét");
                            int ter = int.Parse(Console.ReadLine());
                            Console.WriteLine("Adja meg az ingatlan Árát");
                            int ar = int.Parse(Console.ReadLine());
                            ingatlanok.Add(new Ingatlan(ingatlanok.Count + 1, cim, ter, ar));
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Adja meg a Nevét!");
                            string nev = Console.ReadLine();
                            Console.WriteLine("Adja meg az ingatlan Telefonszámát");
                            string tele = Console.ReadLine();
                            ugyfelek.Add(new Ugyfel(ugyfelek.Count + 1, nev, tele));
                            break;
                        }
                    case 4:
                        {
                            
                            bool funi = false;
                            do
                            {
                                try
                                {
                                    Console.WriteLine("Adja meg melyik ingatlant akarja törölni!(Id-t adja meg!)");
                                    ingatlanok.RemoveAt(int.Parse(Console.ReadLine()) - 1);
                                    funi = false;
                                }
                                catch (Exception)
                                {
                                    Console.ForegroundColor=ConsoleColor.Red;
                                    Console.WriteLine("tulment az indexen");
                                    funi = true;
                                    Console.ResetColor();

                                }
                                

                            } while (funi);
                                                
                            break;
                        }
                }
            }

            
            
            Console.ReadKey();
        }
    }
}