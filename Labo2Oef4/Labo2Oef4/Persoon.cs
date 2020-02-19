using System;
using System.Collections.Generic;
using System.Text;

/* Maak een klasse Persoon met volgende properties : naam, voornaam, geboortedatum, geslacht.
Maak 2 constructoren, 1 met alle properties als parameter, 1 met enkel voornaam en naam. Default
geboortedatum is 1/1/2000, geslacht vrouw. Zorg voor constructor overloading. Maak een methode
om de leeftijd van de persoon te berekenen op basis van de systeemdatum.
De Persoon moet je kunnen afdrukken als “[voornaam] + [naam] + is [leeftijd] jaar oud.”
Maak code om te bewijzen dat je klasse Persoon werkt.
Extra : Pas de oefening aan zodat je een extra methode BerekenLeeftijd maakt die de leeftijd berekent
op basis van een meegegeven datum – geboortedatum. */

namespace Labo2Oef4
{
    class Persoon
    {
        //publieke properties van het object Persoon
        public string Naam { get; set; }
        public string VoorNaam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Geslacht { get; set; }

        public enum TOEGELATENGESLACHTEN {
            Man,
            Vrouw,
            x
        }
        
        /**
         * Hoofd constructor
         * @Param {string} naam - De achternaam van de persoon
         * @Param {string} voorNaam - De voornaam van de persoon
         * @Param {DateTime} geboorteDatum - De geboorteDatum van de persoon
         * @Param {char} - geslacht - Geslacht van de persoon, 1 karakter
         */
        public Persoon(string naam, string voorNaam, DateTime geboorteDatum, TOEGELATENGESLACHTEN geslacht) {
            Naam = naam;
            VoorNaam = voorNaam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht.ToString();
        }

        /**
         * Constructor overloading waar we alleen de naam en voornaaam ingeven en als geboortedatum 1 januari 2000 en geslacht V standaard meegeven
         * @Param {string} naam - De naam van de persoon
         * @Param {string} voorNaam - De voornaam van de persoon
         */
        public Persoon(string naam, string voorNaam) : this(naam, voorNaam, new DateTime(2000, 1, 1), TOEGELATENGESLACHTEN.Vrouw) {
        }

        /**
         * Methode die basis informatie van de persoon in de console uitprint
         */
        public void PrintInfo() {
            int leeftijd = BerekenLeeftijd();
            Console.WriteLine("{0} {1} is {2} jaar oud.", VoorNaam, Naam, leeftijd);
        }
        
        /**
         * Methode die de leeftijd van de persoon berekend ten opzichte van een vergelijkingsdatum
         * @return {int} - leeftijd in jaren
         */
        public int BerekenLeeftijd( DateTime vergelijkingsDatum ) {
            //Bereken verschill tussen geboortejaar en het meegegeven jaar
            int leeftijd = vergelijkingsDatum.Year - GeboorteDatum.Year;
            //Indien jaardag nog niet in het meegegeven Datetime jaar gebeurd trekken we er een jaar af
            if ( (vergelijkingsDatum.Month < GeboorteDatum.Month ) || (vergelijkingsDatum.Month == GeboorteDatum.Month && vergelijkingsDatum.Day < GeboorteDatum.Day)) {
                leeftijd--;
            }
            return leeftijd;
        }

        /**
        * Bereken leeftijd tegenover de huidige datum
        * @ return {int} - leeftijd in jaren
        */
        public int BerekenLeeftijd() {
            int leeftijd = BerekenLeeftijd(DateTime.Now);
            return leeftijd;
        }
    }
}
