using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5Oef3
{
    class Nonfood:Product
    {
        public TimeSpan Garantieperiode { get; set; }
        public double Fragiel { get; set; }
        public double BatterijenNodig { get; set; }

        public Nonfood(String leverancier, string naam, double verkoopPrijs, TimeSpan garantieperiode, double fragiel, double batterijenNodig):base( leverancier, naam, verkoopPrijs )
        {
            this.Garantieperiode = garantieperiode;
            this.Fragiel = fragiel;
            this.BatterijenNodig = batterijenNodig;
        }


    }
}
