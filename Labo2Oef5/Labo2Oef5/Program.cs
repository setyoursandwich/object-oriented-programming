using System;

namespace Labo2Oef5
{
    class Program
    {
        static void Main(string[] args)
        {
            Woordenboek woordenLijst = new Woordenboek();
            printBetekenis(woordenLijst, "FYI");
            printBetekenis(woordenLijst, "ROFL");
            printBetekenis(woordenLijst, "LOL");
        }

        static void printBetekenis( Woordenboek woordenLijst, string afkorting ) {
            string betekenis = woordenLijst.ZoekBetekenis( afkorting );
            string infoString;
            if (betekenis != null)
            {
                infoString = string.Format("Betekenis gevonden. De afkorting {0} staat voor \"{1}\".", afkorting, betekenis);
            }
            else {
                infoString = string.Format("Geen betekenis gevonden voor {0}. Probeer een andere afkorting.", afkorting);
            }

            Console.WriteLine( infoString );
        }
    }
}
