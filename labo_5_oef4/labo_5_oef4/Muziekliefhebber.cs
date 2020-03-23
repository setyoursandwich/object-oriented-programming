using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo_5_oef4
{
    class Muziekliefhebber
    {
        public String Naam { get; set; }
        public String Voornaam { get; set; }
        public string MuziekStijl { get; set; }

        public enum MuziekStijlen {
            DANCE,
            ROCK,
            PUNK
        }

        public Muziekliefhebber(String naam, String voornaam, MuziekStijlen muziekStijl) {
            this.Naam = naam;
            this.Voornaam = voornaam;
            this.MuziekStijl = muziekStijl.ToString();
        }
    }
}
