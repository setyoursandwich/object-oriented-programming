using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5Oef3
{
    class Winkel
    {
        public String Naam { get; set; }
        public double Verkoopprijs { get; set; }
        private List<Product> productLijst;
        
        public Winkel(string naam, double verkoopprijs)
        {
            Naam = naam;
            Verkoopprijs = verkoopprijs;
            this.productLijst = new List<Product>();
        }

        public void VoegProductToe( Product product ) {
            if ( product == null ) {
                throw new Exception( "Enkel geldige producten kunnen aan de product lijst worden toegevoegd" );
            }
            productLijst.Add( product );
        }

        public List<Product> VraagProductenOp() {
            return this.productLijst;
        }
    }
}
