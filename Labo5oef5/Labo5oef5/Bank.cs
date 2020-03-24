using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef5
{
    class Bank
    {
        public string Naam { get; set; }
        public Adres Adres { get; set; }
        private List<Klant> klanten;

        public Bank(string naam, Adres adres)
        {
            this.Naam = naam;
            this.Adres = adres;
            this.klanten = new List<Klant>();
        }

        public 
    }
}
