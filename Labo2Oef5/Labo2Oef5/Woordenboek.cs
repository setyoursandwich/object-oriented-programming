using System;
using System.Collections.Generic;
using System.Text;

namespace Labo2Oef5
{
    class Woordenboek
    {
        private Dictionary<string, string> woordenLijst = new Dictionary<string, string>();
        
        public Woordenboek() {
            woordenLijst.Add("FYI", "Ter info");
            woordenLijst.Add("TX", "Dank u");
            woordenLijst.Add("BRB", "Ben snel terug");
            woordenLijst.Add("LOL", "Heel grappig");
        }

        public string ZoekBetekenis( string sleutel ) {
            if (woordenLijst.ContainsKey(sleutel)) {
                return woordenLijst[sleutel];
            }
            return null;
        }
    }
}
