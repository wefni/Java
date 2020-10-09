using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sudokuCLI
{
    class Program
    {
        List<Feladvany> Feladvanyok = new List<Feladvany>();
        int szam, db = 0;
        Feladvany c;
        public Program() {
            Feltoltes();
            HarmadikFeladat();
            NegyedikFeladat();
            OtodikFeladat();
            HatosFeladat();

        }

        public void Feltoltes() {

            foreach (string sor in File.ReadAllLines("feladvanyok.txt", Encoding.UTF8)) {

                Feladvanyok.Add(new Feladvany(sor));
            
            }
        
        }

        public void HarmadikFeladat() {
            Console.WriteLine($"3.feladat: Beolvasva {Feladvanyok.Count} feladvány");
        }

        public void NegyedikFeladat() {

            

            while (true)
            {
                Console.Write("\n4. feladat: Kérek egy számot 3-nál nagyobb, de 10-nél kisebb számot: ");
                szam = Convert.ToInt32(Console.ReadLine());

                if (szam >= 4 && szam <=9)
                {
                    break;
                }

                


            }
            foreach (Feladvany f in Feladvanyok)
            {
                if (f.Meret == szam)
                {
                    db++;
                }
            }
            Console.WriteLine($"Ennyi feladvány található: {db}");

        }

        public void OtodikFeladat()
        {
            List<Feladvany> temp = new List<Feladvany>();
            foreach (Feladvany f in Feladvanyok)
            {
                if (f.Meret == szam)
                {
                    temp.Add(f);
                }
                
            }
            Random rnd = new Random();

            c = temp[rnd.Next(0, temp.Count - 1)];
            Console.WriteLine($"5. feladat: A feladvány: {c.Kezdo}");
        }
        public void HatosFeladat() {
            int db1=0;

            foreach (var s in c.Kezdo)
            {
                if (Convert.ToInt32(s)>0)
                {
                    db1++;

                }

            }
            double arany = ((double)c.Meret) / ((double)db1);
            int szazalek = (int) (arany * 100);
            Console.WriteLine($"6. feladat: A kitoltottsége: {szazalek}%");
        
        }

        static void Main(string[] args)
        {
            new Program();

            Console.WriteLine("Kilépéshez nyomjon meg egy billentyűt...");
            Console.ReadKey();
        }
    }
}
