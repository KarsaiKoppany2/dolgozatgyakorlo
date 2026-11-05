using System;
using System.Collections.Generic;
using System.Text;

namespace dolgozatgyakorlo
{
    public class Eszkoz
    {
        private int napiDij;
        private int keszlet;
        private static int osszesRegisztraltEszkoz = 0;
        public string Azonosito { get; set; }
        public string Nev { get; set; }
        public string Kategoria { get; set; }
        public int NapiDij { 
            get { return napiDij; }
            set 
            {
                if (value < 0) napiDij = 0;
                else napiDij = value;
            }
        }
        public int Keszlet
        {
            get { return keszlet; }
            set
            {
                if (value < 1) keszlet = 1;
                else keszlet = value;
            }
        }
        public static int OsszesRegisztraltEszkoz { get { return osszesRegisztraltEszkoz; } }
    }
}
