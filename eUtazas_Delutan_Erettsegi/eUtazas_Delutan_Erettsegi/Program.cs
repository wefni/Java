using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace eUtazas_Delutan_Erettsegi
{
    public class Program
    {
        List<Utasadat> uList = new List<Utasadat>();

        Program() {

            Feladatok();
        
        }


        public void Feladatok() {

            Console.WriteLine("Első feladat: ");

            try
            {
                foreach (string sor in File.ReadAllLines("utasadat.txt", Encoding.UTF8))
                {
                    uList.Add(new Utasadat(sor));
                    
                }
                Console.WriteLine("Adatbeolvasva");
            }
            catch (FileNotFoundException fex)
            {

                Console.WriteLine("Fájl nem található!");
            }
            catch (Exception ex) {

                Console.WriteLine($"Hiba: {ex.Message}");
            
            }


            Console.WriteLine($"2.feladat:\nA buszra {uList.Count} utas akart felszállni!");
            int db = 0;
            foreach (Utasadat u in uList)
            {
                if (u.Lejart()) {
                    db++;
                
                }

            }

            Console.WriteLine($"3.feladat: A buszra {db} utas nem szállhatott fel");

            Console.WriteLine($"4.feladat: A legtöbb utas({} fő) a {}. megállóban szállt fel");

            List<string> temp = new List<string>();

            foreach  (Utasadat u in uList)
            {
                if (temp.Contains(u.ID))
                {
                    for (int i = 0; i < ; i++)
                    {

                    }

                }


            }


        
        }

        static void Main(string[] args)
        {
            new Program();

            Console.ReadKey();


        }
    }
}
