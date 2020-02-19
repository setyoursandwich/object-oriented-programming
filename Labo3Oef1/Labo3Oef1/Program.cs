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
            Console.WriteLine("Geef een getal in");
            //Hou bij hoeveel waarde we opgevraagd hebben
            int counter = 1;
            List<int> ingevoerdeWaarden = new List<int>(3);
            //zolang de counter niet hoger is als 3
            do {
                try
                {
                    //Lees de waarde en tracht deze te parsen en asign ze aan de variable ingevoerde getal 
                    int ingevoerdGetal = int.Parse(Console.ReadLine());
                    //voeg de waarde toe aan de lijst van ingevoerde getallen
                    ingevoerdeWaarden.Add(ingevoerdGetal);
                    Console.WriteLine($"Je hebt het getal {ingevoerdGetal} ingevoerd");
                    //indien alles succesvol en deze code wordt gehaald voeg 1 toe aan de counter
                    counter++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Je mag enkel cijfers gebruiken");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Je getal is te groot");
                }
                catch (Exception)
                {
                    Console.WriteLine("er is iets mis gegaan");
                }
                finally {
                
                }
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
    }
}
