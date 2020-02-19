using System;
using System.Collections.Generic;
using System.Text;

/*Maak een klasse Vlucht met volgende properties : vluchtnummer,plaats bestemming, plaats vertrek,
datum/tijdstip van vertrek, datum/tijdstip van aankomst.Maak 2 constructors : 1 constructor met
vluchtnummer, vertrek, bestemming, datum/tijdstip van vertrek, datum/tijdstip van aankomst.De
andere constructor met enkel het vluchtnummer, de andere properties krijgen de gewone default
waardes.
Zorg voor constructor overloading.Maak een methode die de vluchtduur berekent en teruggeeft.
De Vlucht moet je kunnen afdrukken als “Vlucht[vluchtnummer] vliegt van[vertrek] naar
[bestemming].”
Maak code om te bewijzen dat je klasse Vlucht werkt.
Extra : Pas de oefening aan, laat vluchtnummer automatisch verhogen, elke keer als je een vlucht
aanmaakt.
Extra : Pas de oefening aan, zorg dat de bestemming enkel Frankrijk, Engeland, Duitsland kan zijn.
Vertrek altijd enkel België*/

namespace Labo1
{
    class Vlucht
    {
        //Defineer attributen van het object
        public static int VluchtNummer { get; set; }
        public string PlaatsBestemming { get; set; }
        public string PlaatsVertrek { get; set; }
        public DateTime TijdVertrek { get; set; }
        public DateTime TijdAankomst { get; set; }
        //lijst van alle geldige vertrek plaatsen
        public enum VERTREKPLAATSEN
        {
            België
        }
        //Lijst van alle geldige aankomst plaatsen
        public enum AANKOMSTPLAATSEN
        {
            China,
            Frankrijk,
            Engeland,
            Duitsland
        }

        /**
         * Maak een nieuw vlucht aan
         * @Param {int} vluchtNummer - Het nummer voor de vlucht
         * @Param {string} plaatsBestemming - De naam van de bestemming plaats
         * @Param {string} plaatsVertrek - De naam van de vertrek plaats
         * @Param {DateTime} tijdVertrek - Vertrek tijd van de vlucht
         * @Param {DateTime} tijdAankomst - Tijd van aankomst
         */
        public Vlucht(int vluchtNummer, AANKOMSTPLAATSEN plaatsBestemming, VERTREKPLAATSEN plaatsVertrek, DateTime tijdVertrek, DateTime tijdAankomst)
        {
            VluchtNummer = vluchtNummer;
            PlaatsBestemming = plaatsBestemming.ToString();
            PlaatsVertrek = plaatsVertrek.ToString();
            TijdVertrek = tijdVertrek;
            TijdAankomst = tijdAankomst;
        }
        /**
         * Maak een nieuwe vlucht waar buiten het vluchtnummer default waarde wordt ingevuld. Bestemming: Duitsland, Vertrekpunt België, vertrektijd: uur van de tijd van aanmaak, aankomstTijd: 2 van van de huidige tijd
         * @Param {int} vluchtnummer - Vluchtnummer voor de nieuwe vlucht
         */
        public Vlucht(int vluchtNummer) : this(vluchtNummer, AANKOMSTPLAATSEN.Frankrijk, VERTREKPLAATSEN.België, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2)) { }


        /**
         * Bereken de vlucht's duurtijd 
         */
        public TimeSpan BerekenVluchtDuur()
        {
            TimeSpan TijdVerschil = TijdAankomst.Subtract(TijdVertrek);
            return TijdVerschil;
        }
        /**
         * Schrijf de vlucht's informatie in de console
         */
        public void PrintVluchtInfo()
        {
            String Info = String.Format("Vlucht {0} vliegt van {1} naar {2}.", VluchtNummer, PlaatsVertrek, PlaatsBestemming);
            Console.WriteLine(Info);
        }
    }
}
