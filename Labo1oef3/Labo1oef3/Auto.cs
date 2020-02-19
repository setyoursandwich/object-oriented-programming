using System;
using System.Collections.Generic;
using System.Text;

/* Maak een auto met een merk, type, nummerplaat en aantal kilometers. De auto kan je enkel
aanmaken als je alle gegevens hebt of helemaal geen gegevens. Default heeft de auto merk en type
“ONBEKEND”, nummerplaat “1-AAA-000”, aantal kilometers 0.
Elk jaar komt er 20.000 km bij. Zorg ervoor dat je kan berekenen wat de uiteindelijke km stand is na x
aantal jaar. Zorg er ook voor dat je dit kan berekenen voor 10 jaar zonder dat je het aantal jaar
meegeeft.
De auto moet je kunnen afdrukken als “De auto met [nummerplaat] heeft [aantal kilometers]
kilometers.” */

namespace Labo1oef3
{
    class Auto
    {
        //Public attributes
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Nummerplaat { get; set; }
        public uint Kilometers { get; set; }

        /**
        * Constructor methode
        * @Param {string} merk - Het merk van auto 
        * @Param {string} type - Het Type van auto
        * @Param {string} nummerplaat - De nummerplaat van de auto
        * @Param {uint} kilometer - Hoeveel kilometers er op de auto staan (alleen positieve getallen)
        */
        public Auto(string merk, string type, string nummerplaat, uint kilometers)
        {
            Merk = merk;
            Type = type;
            Nummerplaat = nummerplaat;
            Kilometers = kilometers;
        }

        /**
        * Constructor zonder parameters met als de default values: merk "onbekend", type "onbekend", nummerplaat "1-AAA-000", kilometers 0 
        */
        public Auto() : this("ONBEKEND", "ONBEKEND", "1-AAA-000", 0) { }

        /**
        * Bereken hoeveel kilometers er na x aantal jaar op de auto staan, waarbij ieder jaar de auto 20 000 kilometers bij de teller heeft
        * @param {uint} jaren = Hoeveel jaren de berekening toe te passen
        * @return {uint} - De berekende aantal kilometers
        */
        public uint BerekenKilometerstandMetJaarEenheid( uint jaren ) {
            uint kilometerstand = Kilometers + (jaren * 20000);
            return kilometerstand;
        }

        /**
        * Bereken hoeveel kilometers er na 10 jaar op de auto staan, waarbij ieder jaar de auto 20 000 kilometers bij de teller heeft
        * Spoiler: het zijn er 200 000 meer
        * @return {uint} - De berekende aantal kilometers
        */
        public uint BerekenKilometerstandMetJaarEenheid() {
            uint kilometerstand = BerekenKilometerstandMetJaarEenheid(10);
            return kilometerstand;
        }

        /**
        * Print de standaarde informatie over de auto in de console 
        */
        public void PrintInfo() {
            Console.WriteLine("De auto met {0} heeft {1} kilometers.", Nummerplaat, Kilometers);
        }
    }
}
