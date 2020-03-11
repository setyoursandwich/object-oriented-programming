using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef1
{
    class Huisdier
    {
        public string Naam { get; set; }
        public double Gewicht { get; set; }
        public int GeboorteJaar { get; set; }

        protected String Geluid { get; set; }

        protected Huisdier(string naam, double gewicht, int geboorteJaar, string geluid) {
            this.Naam = naam;
            this.Gewicht = gewicht;
            this.GeboorteJaar = geboorteJaar;
            this.Geluid = geluid;
        }

        public Huisdier(string naam, double gewicht, int geboorteJaar):this( naam, gewicht, geboorteJaar, "grom grom") {

        }


        public string VraagGeluid() {
            return this.Geluid;
        }
    }
}
