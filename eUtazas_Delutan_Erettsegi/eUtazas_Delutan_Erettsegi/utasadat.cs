using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace eUtazas_Delutan_Erettsegi
{
    public class Utasadat
    {

        public int Sorszam { get; set; }
        public string Felszall { get; set; }
        public string ID { get; set; }
        public string Tipus { get; set; }
        public string Ervenyes { get; set; }

        public Utasadat(string sor) {
            int temp;
            Int32.TryParse(sor.Split(' ')[0], out temp);
            Sorszam = temp;

            Felszall = sor.Split(' ')[1];
            ID = sor.Split(' ')[2];
            Tipus = sor.Split(' ')[3];
            Ervenyes = sor.Split(' ')[4];


        }

        public bool Lejart() {

            if (!Ervenyes.Equals("0"))
            {
                if (Ervenyes.Length == 8) {

                    DateTime erv = DateTime.ParseExact(Ervenyes, "yyyyMMdd", CultureInfo.InvariantCulture);
                    DateTime menet = DateTime.ParseExact(Felszall.Split('-')[0], "yyyyMMdd", CultureInfo.InvariantCulture);

                    if (erv < menet)
                    {
                        return true;
                    }
                }
            }
            else {
                return true;
            
            }
            return false;
        }



    }
}
