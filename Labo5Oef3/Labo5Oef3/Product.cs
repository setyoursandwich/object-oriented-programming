using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5Oef3
{
    class Product
    {
        public String Leverancier { get; set; }
        public String Naam { get; set; }
        private double basisVerkoopPrijs;

        public Product(String leverancier, string naam, double verkoopPrijs)
        {
            Leverancier = leverancier;
            Naam = naam;
            this.basisVerkoopPrijs = verkoopPrijs;
        }

        public virtual double BerekenVerkoopPrijs() {
            return this.basisVerkoopPrijs;
        }
    }
}
