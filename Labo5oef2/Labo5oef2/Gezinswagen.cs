using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef2
{
    class Gezinswagen:Wagen
    {
        public int Zitplaatsen { get; set; }
        public int KofferVolume { get; set; }

        public Gezinswagen(string merk, string type, int kMAantal, DateTime ingebruikDatum, string nummerplaat, int zitplaatsen, int kofferVolume) : base(merk, type, kMAantal, ingebruikDatum, nummerplaat)
        {
            Zitplaatsen = zitplaatsen;
            KofferVolume = kofferVolume;
        }

        public override double BerekenBrandstofVerbruik()
        {
            double brandstofVerbruik = base.BerekenBrandstofVerbruik();
            if ( this.Zitplaatsen > 6 ) {
                brandstofVerbruik *= 1.1;
            }
            return brandstofVerbruik;
        }
    }
}
