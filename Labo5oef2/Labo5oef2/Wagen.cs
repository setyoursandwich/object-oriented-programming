using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef2
{
    class Wagen
    {
        public String Merk { get; set; }
        public String Type { get; set; }
        public int KMAantal { get; set; }
        public DateTime IngebruikDatum { get; set; }
        public String Nummerplaat { get; set; }

        public Wagen(string merk, string type, int kMAantal, DateTime ingebruikDatum, string nummerplaat)
        {
            Merk = merk;
            Type = type;
            KMAantal = kMAantal;
            IngebruikDatum = ingebruikDatum;
            Nummerplaat = nummerplaat;
        }

        public virtual double BerekenBrandstofVerbruik() {
            return 5;
        }
    }
}
