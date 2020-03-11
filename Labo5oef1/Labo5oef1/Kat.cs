using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef1
{
    class Kat:Huisdier
    {
        public enum ToegelatenVachtLengtes {
            lang,
            kort
        };

        private string vachtLengte;

        private Kat(string naam, double gewicht, int geboorteJaar, string geluid, ToegelatenVachtLengtes vachtLengte ) : base(naam, gewicht, geboorteJaar, geluid) {
            this.vachtLengte = vachtLengte.ToString();
        }

        public Kat(string naam, double gewicht, int geboorteJaar, ToegelatenVachtLengtes vachtLengte) : this(naam, gewicht, geboorteJaar, "Miauw", vachtLengte)
        {

        }

        public string VraagVachtLengte() {
            return this.vachtLengte;
        }

        public void ZetVachtLengte(ToegelatenVachtLengtes vachtLengte ) {
            this.vachtLengte = vachtLengte.ToString();
        }


        
    }
}
