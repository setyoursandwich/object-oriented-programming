using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef5
{
    class Klant
    {
        public String Naam { get; set; }
        public Adres Adres { get; set; }
        private List<Rekening> rekening;

        public Klant(string naam, Adres adres)
        {
            Naam = naam;
            Adres = adres;
            this.rekening = new List<Rekening>();
        }
    }
}
