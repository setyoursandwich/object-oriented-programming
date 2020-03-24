using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef5
{
    class Adres
    {
        public String Straat { get; set; }
        //huisnummer in string omdat deze 
        public String HuisNummer { get; set; }
        public int Postcode { get; set; }
        public String Gemeente { get; set; }

        public Adres(string straat, string huisNummer, int postcode, string gemeente)
        {
            Straat = straat;
            HuisNummer = huisNummer;
            Postcode = postcode;
            Gemeente = gemeente;
        }
    }
}
