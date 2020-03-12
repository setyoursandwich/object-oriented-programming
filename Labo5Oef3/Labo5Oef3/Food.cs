using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5Oef3
{
    class Food:Product
    {
        public DateTime VervalDatum { get; set; }
        public double KoelTemperatuur { get; set; }

        public Food(string leverancier, string naam, double verkoopPrijsPerLiter, DateTime vervalDatum, double koelTemperatuur) : base(leverancier, naam, verkoopPrijsPerLiter)
        {
            if (vervalDatum <= DateTime.Now) {
                throw new Exception("Het product is voorbij de vervaldatum.");
            }
            this.VervalDatum = vervalDatum;
            this.KoelTemperatuur = koelTemperatuur;
        }
        
        public double BerekenVerkoopPrijs(double hoeveelHeid)
        {
            if ( hoeveelHeid <= 0 ) {
                return 0;
            }

            double verkoopprijs = base.BerekenVerkoopPrijs();

            verkoopprijs *= hoeveelHeid;

            return verkoopprijs;
        }


    }
}
