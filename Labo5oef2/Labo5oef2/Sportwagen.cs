using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef2
{
    class Sportwagen:Wagen
    {
        public int PK { get; set; }
        public int Vitessen { get; set; }

        public Sportwagen(string merk, string type, int kMAantal, DateTime ingebruikDatum, string nummerplaat, int pK, int vitessen):base(merk, type, kMAantal, ingebruikDatum, nummerplaat)
        {
            this.PK = pK;
            this.Vitessen = vitessen;
        }

        public override double BerekenBrandstofVerbruik() {
            double brandstofVerbruik = base.BerekenBrandstofVerbruik();
            if ( this.Vitessen == 6 ) {
                brandstofVerbruik *= 1.2;
            }
            return brandstofVerbruik;
        }
    }
}
