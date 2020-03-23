using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo_5_oef4
{
    class Festivalganger:Muziekliefhebber
    {
        public string Woonplaats { get; set; }
        public int Leeftijd { get; set; }
        public bool Handicap { get; set; }

        public Festivalganger(string woonplaats, int leeftijd, bool handicap, String naam, String voornaam, MuziekStijlen muziekstijl):base(naam, voornaam, muziekstijl)
        {
            Woonplaats = woonplaats;
            Leeftijd = leeftijd;
            Handicap = handicap;
        }

        public double BerekenInkomPrijs( Festival festival ) {

            double berekendInkomPrijs = festival.InkomPrijs;

            if (Woonplaats == festival.Plaats) {
                berekendInkomPrijs = 0;
            } else if (this.Leeftijd > 60 || this.Leeftijd < 25 || this.Handicap == true) {
                berekendInkomPrijs *= 0.5;
            }

            return berekendInkomPrijs;
        }
    }
}
