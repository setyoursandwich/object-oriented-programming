using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labo_5_oef4
{
    class Festival
    {
        public string Plaats { get; set; }
        public string Naam { get; set; }
        public DateTime Datum { get; set; }
        public double InkomPrijs { get; set; }

        private List<Artiest> artiesten;

        public Festival( string plaats, string naam, DateTime datum, double inkomPrijs ) {
            this.Plaats = plaats;
            this.Naam = naam;
            this.Datum = datum;
            this.artiesten = new List<Artiest>();
            this.InkomPrijs = inkomPrijs;
        }

        public void VoegArtiestToe(Artiest artiest) {
            if (artiest != null) {
                this.artiesten.Add(artiest);
            }
        }

        public void VerwijderArtiest(Artiest artist) {
            this.artiesten.Remove( artist );
        }

        public List<Artiest> VraagArtiestenLijst() {
            return this.artiesten;
        }
    }
}
