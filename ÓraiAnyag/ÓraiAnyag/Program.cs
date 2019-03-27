using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harmadik
{
    class Program
    {
        Program()
        {
            //elso();
            szuletes();
        }

        public void elso()
        {
            int aInt = 0;
            int bInt = 0;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nKérek két számot!");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\nElső szám: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string a = Console.ReadLine();
            aInt = KonvertSzamKeres(a);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Második szám: ");
            Console.ForegroundColor = ConsoleColor.Red;
            string b = Console.ReadLine();
            bInt = KonvertSzamKeres(b);
            Console.ForegroundColor = ConsoleColor.Yellow;
            kulonbseg(aInt, bInt);
        }

        public void kulonbseg(int a, int b)
        {
            if (a > b) Console.WriteLine("\nA két szám távolsága: " + (a - b));
            else if (a < b) Console.WriteLine("\nA két szám távolsága: " + (b - a));
            else if ((a - b) == 0) Console.WriteLine("\nA két szám ugyanaz!");
        }


        public int SzamOsszeg(int szam)
        {

            if (szam < 10)
            {
                return szam;
            }

            int temp = szam;
            int osszeg = 0;
            while (temp > 0)
            {
                osszeg += temp % 10;  //osszeg = 2002 %10 = 2
                temp /= 10;
            }
            //osszeg = 4




            return osszeg;
        }

        public void szuletes()
        {
            int ev = 0;
            int honap = 0;
            int nap = 0;

            Console.WriteLine("Kérem szépen a születési idődet!");
            Console.Write("Év: ");
            do
            {
                ev = Konvert(Console.ReadLine(), 4);
            } while (ev <= 0);
            Console.Write("Hónap: ");
            do
            {
                honap = Konvert(Console.ReadLine(), 2, 1, 12);
            } while (honap <= 0);
            Console.Write("Nap: ");
            do
            {
                switch (honap)
                {
                    //31 naposak
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        nap = Konvert(Console.ReadLine(), 2, 1, 31);
                        break;

                    //Február
                    case 2:
                        nap = Konvert(Console.ReadLine(), 2, 1, 28);
                        break;

                    //30 naposak
                    default:
                        nap = Konvert(Console.ReadLine(), 2, 1, 30);
                        break;
                }
            } while (nap <= 0);
            int ossz = SzamOsszeg(ev);
            ossz += SzamOsszeg(honap);
            ossz += SzamOsszeg(nap);


            if (ossz>=10) {
                ossz = SzamOsszeg(ossz);
            }
            Console.WriteLine("A számjegyeinek összege: {0}", ossz);
        }

        public int KonvertSzamKeres(String szam)
        {//Konvertálás a számkérőshöz
            int temp = 0;
            try
            {
                temp = Convert.ToInt32(szam);
            }

            catch (FormatException e)
            {//a felhasználó betűt ad meg
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("\nHibás adat!");
                Console.WriteLine();
                elso();
            }

            catch (OverflowException e)
            {//nagyobb a szám, mint az int maximum értéke
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("A szám túl nagy!");
                Console.WriteLine();
                elso();
            }

            return temp;
        }

        public int Konvert(String szam)
        {
            int temp = -1;
            Int32.TryParse(szam, out temp);
            return temp;
        }

        public int Konvert(String szam, int hossz)
        {
            int n = this.Konvert(szam);

            if (n > 0 && szam.Length != hossz) return 0;
            else return n;
        }

        public int Konvert(String szam, int hossz, int min, int max)
        {
            int n = Konvert(szam, hossz);
            if (n >= min && n <= max) return n;
            else return 0;
        }

        static void Main(string[] args)
        {
            new Program();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\nNyomj egy gombot a kilépéshez...");
            Console.ReadKey();
        }
    }
}


