using System;
using System.Collections.Generic;
using System.Text;

/*
 Labo1(1): Maak een klasse Vlucht met volgende properties : vluchtnummer,plaats bestemming, plaats vertrek,
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

/*
 Labo2(4):
Een vlucht kan meerdere passagiers hebben, houd deze bij in de vorm van een lijst.
Maak 2 methodes, 1 om een passagier toe te voegen, 1 om een passagier te verwijderen uit de lijst van vluchten.
Maak een methode die een bepaalde passagier zoekt op basis van zijn naam. Geef de betreffende passagier terug, indien geen gevonden, geef null terug.
Maak code zodat je de functionaliteit van de vlucht en van de passagiers kan laten zien in de console
 */


namespace Labo2Oef4
{
    class Vlucht
    {
        //Defineer attributen van het object
        public static int VluchtNummer { get; set; } = 0;
        public string PlaatsBestemming { get; set; }
        public string PlaatsVertrek { get; set; }
        public DateTime TijdVertrek { get; set; }
        public DateTime TijdAankomst { get; set; }
        //Defineer fields van het object
        private List<Persoon> passagierLijst = new List<Persoon>();
        //lijst van alle geldige vertrek plaatsen
        public enum VERTREKPLAATSEN {
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
        public Vlucht( AANKOMSTPLAATSEN plaatsBestemming, VERTREKPLAATSEN plaatsVertrek, DateTime tijdVertrek, DateTime tijdAankomst)
        {
            VluchtNummer = Vlucht.VluchtNummer++;
            PlaatsBestemming = plaatsBestemming.ToString() ;
            PlaatsVertrek = plaatsVertrek.ToString();
            TijdVertrek = tijdVertrek;
            TijdAankomst = tijdAankomst;
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
            String vluchtInfo = String.Format("Vlucht {0} vliegt van {1} naar {2}.\n\n", VluchtNummer, PlaatsVertrek, PlaatsBestemming);

            vluchtInfo += "De vlucht heeft de volgende Passagiers:\n";
            vluchtInfo += String.Format("Naam \t\tVoornaam \tGeslacht \tLeeftijd\n");
            foreach ( Persoon passagier in passagierLijst ) {
                vluchtInfo += String.Format("{0, -10} \t{1, -10} \t{2, -10} \t{3, -10}\n", passagier.Naam, passagier.VoorNaam, passagier.Geslacht, passagier.BerekenLeeftijd() );
            }
            Console.WriteLine(vluchtInfo);
        }

        /**
        * Voeg een persoon toe aan de passagierLijst
        * @Param {Persoon} passagier - De persoon die we willen toevoegen aan de lijst
        * @Return {bool}
        */
        public bool VoegPassagierToe( Persoon passagier  ) {
            //indien de passagier null is return false
            if ( passagier == null ) {
                return false;
            }
            //Kijk of de lijst al een referentie heeft naar de passagier, zo ja return false
            foreach (Persoon bestaandePassagier in passagierLijst) {
                if ( bestaandePassagier == passagier ) {
                    //return false, stopt ook de verdere executie van de foreach loop
                    return false;
                }
            }
            //als de passagier niet null is voeg toe aan de lijst en return true
            passagierLijst.Add( passagier );
            return true;
        }
        
        /**
        * Verwijder een persoon van de passagierLijst
        * @Param {Persoon} passagier - De persoon die we willen verwijderen van de lijst
        * @Return {bool} 
        */
        public bool VerwijderPassagier(Persoon passagier) {
            if ( passagierLijst.Remove( passagier ) ) {
                return true;
            }
            return false;
            //return passagierLijst.Remove( passagier );
        }

        /**
         * Kijk of een passagier in de lijst staat en return het object instantie van deze passagier terug indien gevonden, null indien niet gevonden
         * @Param {Persoon} passagier - De passagier die we in de lijst zoeken
         * @Return {Persoon} - Het gevonden object (null indien niet gevonden)
         */
        public Persoon ZoekPassagier( Persoon passagier ) {
            if ( passagier != null ) {
                foreach ( Persoon bestaandePassagier in passagierLijst ) {
                    if ( bestaandePassagier == passagier ) {
                        return passagier;
                    }
                }
            }
            return null;
        }
    }
}
