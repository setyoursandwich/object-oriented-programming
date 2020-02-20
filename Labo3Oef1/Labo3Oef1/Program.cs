using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;

/*
 * Maak een programma dat aan een gebruiker vraagt om een getal in te lezen en print het vervolgens terug af aan de gebruiker. Zorg ervoor dat het programma niet stukgaat wanneer er iets 
 * anders dan een getal wordt ingelezen. Print dan naar de gebruiker: “er is iets mis gegaan”.
Extra: Pas de oefening aan, zorg ervoor dat je een format exception en een overflow exception op een andere manier opvangt en andere info naar de gebruiker stuurt. 
Format => “Je mag enkel cijfers gebruiken” 
Overflow => “Je getal is te groot”
Extra: Pas de oefening aan, blijf aan de gebruiker input vragen tot je echt een getal hebt gekregen.
Extra: Pas de oefening aan, vraag aan de gebruiker 3 getallen, blijf input vragen aan de gebruiker tot je 3 gevulde getallen hebt. Druk daarna de som af van deze 3 getallen.
 */

namespace Labo3Oef1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hou bij hoeveel waarde we opgevraagd hebben
            int counter = 1;
            List<int> ingevoerdeWaarden = new List<int>(3);
            
            do {
                SafeExecutor( ()=> {
                    Console.WriteLine("Geef een getal in");
                    //Lees de waarde en tracht deze te parsen en asign ze aan de variable ingevoerde getal
                    //SafeExecutor( Func<int> Action = () => { });
                    int ingevoerdGetal = int.Parse(Console.ReadLine());
                    //voeg de waarde toe aan de lijst van ingevoerde getallen
                    ingevoerdeWaarden.Add(ingevoerdGetal);
                    Console.WriteLine($"Je hebt het getal {ingevoerdGetal} ingevoerd");
                    //indien alles succesvol en deze code wordt gehaald voeg 1 toe aan de counter
                    counter++;
                    //callbacks moeten een return value hebben
                    return 0;
                });
                //ALternatief kan de safeExecutor een 1 of 0 teruggeven ipv void en voeren we deze toe aan de counter

            } while (counter <= 3);
            //hou het totaal bij
            int totaal = 0;
            //loop over al de waarden in de list en tel de waarde bij het totaal
            foreach ( int waarde in ingevoerdeWaarden ) {
                totaal += waarde;
            }
            //print het totaal uit
            Console.WriteLine($"De som van al de ingevoerde waarde is: {totaal}");
            //einde van het programma bereikt
            Console.WriteLine("Einde van programma");
        }

        static private void SafeExecutor(Func<int> action)
        {
            //voeg lege string waarde toe omdat visual studio niet begrijpt dat code in try het uitschrijven van message stopt
            string message = "";
            try
            {
                //indien succesvol voer callback uit en return het resultaat, dit stopt verdere executie van deze methode waardoor finally nooit bereikt wordt
                action();
            }
            //sepcifieke code afhankelijk van exception
            catch (FormatException fEx)
            {
                message = "Je mag enkel cijfers gebruiken";
            }
            catch (OverflowException oEx)
            {
                message = "Je getal is te groot";
            }
            //default exception code indien geen van de vorige catch iteraties opgevangen is
            catch (Exception ex)
            {
                message = "er is iets mis gegaan";
            }
            //code wordt voor al de catch statements uitevoerd
            finally
            {
                Console.WriteLine(message);
            }
        }
    }
}
