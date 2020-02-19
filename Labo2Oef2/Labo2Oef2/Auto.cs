using System;
using System.Collections.Generic;
using System.Text;

/*
Zorg ervoor dat elke auto steeds een eigenaar heeft.
Maak code zodat je gegevens van de auto en de eigenaar van de auto kan laten zien in de console.
*/
namespace Labo2Oef2
{
    class Auto
    {
        //Public attributes
        public string Merk { get; set; }
        public string Type { get; set; }
        public string Nummerplaat { get; set; }
        public uint Kilometers { get; set; }

        public Persoon Eigenaar { get; set; }

        /**
        * Constructor methode
        * @Param {string} merk - Het merk van auto 
        * @Param {string} type - Het Type van auto
        * @Param {string} nummerplaat - De nummerplaat van de auto
        * @Param {uint} kilometer - Hoeveel kilometers er op de auto staan (alleen positieve getallen)
        * @Param {Persoon} eigenaar - De eigenaar van de auto
        */
        public Auto(string merk, string type, string nummerplaat, uint kilometers, Persoon eigenaar)
        {
            Merk = merk;
            Type = type;
            Nummerplaat = nummerplaat;
            Kilometers = kilometers;
            Eigenaar = eigenaar;
        }

        /**
        * Constructor zonder parameters met als de default values: merk "onbekend", type "onbekend", nummerplaat "1-AAA-000", kilometers 0 
        */
        public Auto(Persoon eigenaar) : this("ONBEKEND", "ONBEKEND", "1-AAA-000", 0, eigenaar) { }

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
            Console.WriteLine("De auto is in bezit van {0} {1}", Eigenaar.VoorNaam, Eigenaar.Naam);
            Eigenaar.PrintInfo();
        }
    }
}
