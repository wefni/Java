using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÓraiAnyag
{
    class Program
    {
        Program() {
            Elso();


        }


        public void Elso() {

            Console.WriteLine("Kérek két számot kedves felhasználó: ");
            Console.WriteLine("1. szám: ");
            string a = Console.ReadLine();
            int aInt = Konvert(a);
            Console.WriteLine("2. szám: ");
            string b = Console.ReadLine();
            int bInt = Konvert(b);
            Szamok(aInt,bInt);



        }
        public int Konvert(String szam) {
            int temp = 0;

            try
            {
                temp = Convert.ToInt32(szam);
               
            }
            catch (FormatException e)
            {
                Console.WriteLine("Hibás adat!");
                Elso();
            }

            return temp;



        }

        public void Szamok(int a, int b) {

            if (a > b)
            {
                Console.WriteLine("A két szám különbsége: " + (a - b));
            }
            else if (a < b)
            {
                Console.WriteLine("A két szám különbsége: " + (b - a));
            }
            else if(a==b){
                Console.WriteLine("A kettő szám megegyezik, különbsége: " + (a-b));
            }
        }



        static void Main(string[] args)
        {

            new Program();
            Console.ReadKey();
        }
    }
}
