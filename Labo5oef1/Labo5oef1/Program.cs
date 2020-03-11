using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef1
{
    /*
    Een Hond en Kat zijn beide huisdieren.Elk huisdier heeft een naam, gewicht en geboortejaar.We
kunnen van elke huisdier een leeftijd berekenen en het geluid dat een dier maakt is algemeen “grom
grom”. De hond heeft lange oren of korte oren, is agressief of niet en maakt het geluid “waf waf”. De
kat zegt “miauw miauw” en heeft een lange of korte vacht.
        */
    class Program
    {
        static void Main(string[] args)
        {
            try {
                Hond jacky = new Hond("Jacky", 5, 2016, "lang", false);
                Console.WriteLine( jacky.VraagGeluid() );
                Console.WriteLine( jacky.Gewicht );
            }
            catch ( Exception e ) {
                Console.WriteLine( e.Message );
            }
        }
    }
}
