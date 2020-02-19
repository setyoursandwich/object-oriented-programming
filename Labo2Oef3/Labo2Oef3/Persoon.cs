using System;
using System.Collections.Generic;
using System.Text;

/*
 * Een persoon is eigenaar van meerdere auto’s, houd deze bij in de vorm van een lijst.
Maak 2 methodes, 1 om een auto toe te voegen, 1 om een auto te verwijderen uit de lijst van auto’s.
Maak code zodat je gegevens van de eigenaar en van al zijn auto’s kan laten zien in de console.
*/

namespace Labo2Oef3
{
    class Persoon
    {
        //publieke properties van het object Persoon
        public string Naam { get; set; }
        public string VoorNaam { get; set; }
        public DateTime GeboorteDatum { get; set; }
        public string Geslacht { get; set; }

        private List<Auto> autoLijst = new List<Auto>();

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

            if ( autoLijst.Count > 0) {
                foreach (Auto specifiekeAuto in autoLijst)
                {

                    specifiekeAuto.PrintInfo();
                }
            }
            else {
                Console.WriteLine("{0} heeft geen auto, fundraiser starten misschien?");
            }
            
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
         *  Voeg een nieuwe auto toe
         *  @Param {Auto} nieuweAuto - De auto om toe te voegen
         *  @return {bool} - succesvol toegevoegd of niet
         */
        public bool VoegAutoToe( Auto nieuweAuto ) {
            if ( nieuweAuto != null ) {
                autoLijst.Add( nieuweAuto );
                return true;
            }
            return false;
        }

        /**
         *  Verwijder een auto
         *  @Param {Auto} autoToDelete - De auto om te verwijderen
         *  @return {bool} - succesvol verwijderd of niet
         */
        public Boolean VerwijderAuto( Auto autoToDelete ) {
            if ( autoToDelete != null ) {
                //return true als de auto verwijderd is, false als deze niet in de lijst gevonden is
                return autoLijst.Remove( autoToDelete );
            }
            return false;
        }
    }
}
