using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef1
{
    class Hond:Huisdier
    {
        public enum ToegelatenOorlengte{
            kort,
            lang
        };

        public String Oorlengte { get; set; }

        private String oorlengte;
        public bool Agressief { get; set; }
        private Hond(string naam, double gewicht, int geboorteJaar, string geluid, ToegelatenOorlengte oorlengte, bool agressief):base(naam, gewicht, geboorteJaar, geluid) {
            this.Oorlengte = oorlengte.ToString();
            this.Agressief = agressief;
        }

        public Hond(string naam, double gewicht, int geboorteJaar, String oorlengte, bool agressief):this( naam, gewicht, geboorteJaar, "waf waf", oorlengte, agressief) {
        
        }

        public string VraagOorlangte() {
            return this.Oorlengte;
        }

        public void ZetOorlengte( ToegelatenOorlengte oorlengte ) {
            this.oorlengte = oorlengte.ToString();
        }
    }
}
