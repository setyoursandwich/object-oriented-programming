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

/* Labo2(6): Maak een collection (kies zelf de meest geschikte) zodat je vluchten makkelijk kan opsporen op basis van vluchtnummer. Eens het vluchtnummer gekend is, kan de vlucht makkelijk opgehaald worden.
 * Zorg ervoor dat er vluchten toegevoegd/verwijderd/opgehaald kunnen worden.
 */

namespace Labo2oef6
{
    class Vlucht
    {
        //Defineer attributen van het object
        public int VluchtNummer { get; set; }
        public string PlaatsBestemming { get; set; }
        public string PlaatsVertrek { get; set; }
        public DateTime TijdVertrek { get; set; }
        public DateTime TijdAankomst { get; set; }
        //static fields
        //Hou bij wat het laatst gegeven nummer is
        private static int laatsteVluchtNummer = 1;
        //Hou een lijst bij van alle vluchten: vluchtNummer => vlucht
        private static Dictionary<int, Vlucht> vluchtLijst = new Dictionary<int, Vlucht>();

        //lijst van alle geldige vertrek plaatsen
        public enum VERTREKPLAATSEN
        {
            België
        }
        //Lijst van alle geldige aankomst plaatsen
        public enum AANKOMSTPLAATSEN
        {
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
        public Vlucht(AANKOMSTPLAATSEN plaatsBestemming, VERTREKPLAATSEN plaatsVertrek, DateTime tijdVertrek, DateTime tijdAankomst)
        {
            VluchtNummer = laatsteVluchtNummer++;
            PlaatsBestemming = plaatsBestemming.ToString();
            PlaatsVertrek = plaatsVertrek.ToString();
            TijdVertrek = tijdVertrek;
            TijdAankomst = tijdAankomst;
            //voeg vlucht toe aan de lijst van bestaande vluchten: vluchtNummer => vlucht
            vluchtLijst.Add(VluchtNummer, this);
        }
        /**
         * Maak een nieuwe vlucht waar buiten het vluchtnummer default waarde wordt ingevuld. Bestemming: Duitsland, Vertrekpunt België, vertrektijd: uur van de tijd van aanmaak, aankomstTijd: 2 van van de huidige tijd
         * @Param {int} vluchtnummer - Vluchtnummer voor de nieuwe vlucht
         */
        public Vlucht() : this(AANKOMSTPLAATSEN.Frankrijk, VERTREKPLAATSEN.België, DateTime.Now.AddHours(1), DateTime.Now.AddHours(2)) { }


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

        /**
         * Zoek vlucht op vluchtnummer
         * @Param {int} vluchtNummer - Nummer van de vlucht die we in de lijst willen opzoeken
         * @Return {Vlucht}
         */
        public static Vlucht ZoekVluchtOpVluchtnummer(int vluchtNummer) {
            if (vluchtLijst.ContainsKey(vluchtNummer)) {
                return vluchtLijst[vluchtNummer];
            }
            return null;
        }

        /**
         * Voeg vlucht toe aan de lijst van vluchten
         * @Param {Vlucht } toeTeVoegenVlucht - De vlucht die we in de lijst willen steken
         * @Return {bool}
         */
        public static bool VoegVluchtToeAanLijst( Vlucht toeTeVoegenVlucht )
        {
            if ( toeTeVoegenVlucht != null && !vluchtLijst.ContainsKey(toeTeVoegenVlucht.VluchtNummer) ) {
                vluchtLijst.Add(toeTeVoegenVlucht.VluchtNummer, toeTeVoegenVlucht);
                return true;
            }
            return false;
        }

        /**
         * Verwijder vlucht van de lijst van vluchten
         * @Param {Vlucht } teVerwijderenVlucht - De vlucht die we uit de lijst willen halen
         * @Return {bool}
         */
        public static bool VerwijderVluchtVanLijst(Vlucht teVerwijderenVlucht) {
            if ( teVerwijderenVlucht != null ) {
                return vluchtLijst.Remove(teVerwijderenVlucht.VluchtNummer);
            }
            return false;
        }
    }
}
