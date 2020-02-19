using System;
using System.Collections.Generic;
using System.Text;

/* 
Zorg ervoor dat elke persoon een vlucht heeft. Zorg ervoor dat je een vlucht optioneel mee kan geven
in de constructor van persoon. Maak code zodat je gegevens van de passagier en de bijhorende
vlucht gegevens kan laten zien in de console. 
*/

namespace Labo2Oef1
{
    class Persoon
    {
        //publieke properties van het object Persoon
        public string Naam { get; set; }
        public string VoorNaam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Geslacht { get; set; }

        public Vlucht VluchtDetails { get; set; }

        public enum ToegelatenGeslachten {
            MAN,
            VROUW,
            X
        }

        /**
         * Hoofd constructor
         * @Param {string} naam - De achternaam van de persoon
         * @Param {string} voorNaam - De voornaam van de persoon
         * @Param {DateTime} geboorteDatum - De geboorteDatum van de persoon
         * @Param {char} - geslacht - Geslacht van de persoon, 1 karakter
         * @Param {Vlucht} - vluchtDetails - Vlucht van de persoon
         */
        public Persoon(string naam, string voorNaam, DateTime geboorteDatum, ToegelatenGeslachten geslacht, Vlucht vluchtDetails) {
            Naam = naam;
            VoorNaam = voorNaam;
            GeboorteDatum = geboorteDatum;
            Geslacht = geslacht.ToString();
            VluchtDetails = vluchtDetails;
        }

        /**
         * Hoofd constructor
         * @Param {string} naam - De achternaam van de persoon
         * @Param {string} voorNaam - De voornaam van de persoon
         * @Param {DateTime} geboorteDatum - De geboorteDatum van de persoon
         * @Param {char} - geslacht - Geslacht van de persoon, 1 karakter
         * @Param {Vlucht} - vluchtDetails - Vlucht van de persoon
         */
        public Persoon(string naam, string voorNaam, DateTime geboorteDatum, ToegelatenGeslachten geslacht) : this(naam, voorNaam, geboorteDatum, geslacht, null) {
        }

        /**
         * Constructor overloading waar we alleen de naam en voornaaam ingeven en als geboortedatum 1 januari 2000 en geslacht V standaard meegeven
         * @Param {string} naam - De naam van de persoon
         * @Param {string} voorNaam - De voornaam van de persoon
         */
        public Persoon( string naam, string voorNaam) : this(naam, voorNaam, new DateTime(2000, 1, 1), ToegelatenGeslachten.VROUW) {
        }

        /**
        * Valideer al de begin waarden
        * @Param {string} naam - De achternaam van de persoon
        * @Param {string} voorNaam - De voornaam van de persoon
        * @Param {DateTime} geboorteDatum - De geboorteDatum van de persoon
        * @Param {char} - geslacht - Geslacht van de persoon, 1 karakter
        * @Param {Vlucht} - vluchtDetails - Vlucht van de persoon
        */
        private void ValideerBeginWaarden(string naam, string voorNaam, DateTime geboorteDatum, string geslacht, Vlucht vluchtDetails) {
            ValideerGeboorteDatum(geboorteDatum);
            ValideerGeslacht(geslacht);
        }

        /**
        * Valideer geboorte datum
        * @Param {DateTime} geboorteDatum - De geboorteDatum van de persoon
        */
        private void ValideerGeboorteDatum( DateTime geboorteDatum ){
            if (DateTime.Now.Subtract(GeboorteDatum).Seconds < 0)
            {
                throw new System.ArgumentException("Een persoon kan geen geboortedatum in de toekomst hebben. Zelfs als de technologie om tijdreizen gemaakt zou worden zou iemand in theorie naar de toekomst gaan voor een nieuw persoon te \"verwekken\" is het onwaarschijnlijk dat ze ooit terug naar het verleden kunnen komen.");
            }
        }

        /**
        * Valideer geslacht
        * @Param {char} - geslacht - Geslacht van de persoon, 1 karakter
        */
         private void ValideerGeslacht(string geslacht)
         {
             if (!Enum.IsDefined(typeof(ToegelatenGeslachten), geslacht.ToUpper()))
             {
                 throw new System.ArgumentException("Geen geldig geslacht ingevoerd, geef een X in voor alle niet M/V geslachten.");
             }
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

        /**
        * Print de persoon zijn vlucht informatie, indien deze er heeft, anders printen we een tekst om te waarschuwen dat er geen vlucht is
        */
        public void SchrijfVluchtInformatie() {
            if (this.VluchtDetails == null) {
                Console.WriteLine( "Deze persoon heeft geen geldig vlucht" );
            }
            else {
                Console.WriteLine("{0} {1} heeft vlucht {2} van {3} naar {4}. Deze vertrekt om {5} en is verwacht te landen om {6}. De reistijd zou ongegveer {7} uur bedragen.", VoorNaam, Naam, VluchtDetails.VluchtNummer, VluchtDetails.PlaatsVertrek, VluchtDetails.PlaatsBestemming, VluchtDetails.TijdVertrek, VluchtDetails.TijdAankomst, VluchtDetails.BerekenVluchtDuur());
            }
            
        }
    }
}
