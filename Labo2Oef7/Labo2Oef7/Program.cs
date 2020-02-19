using System;
using System.Collections.Generic;

namespace Labo2Oef7
{
    /**
     * Maak zelf een undo actie. Zorg ervoor dat je in de console letter per letter kan ingeven gevolgd met ENTER(1 letter per lijn).
     * Lees dit karakter in. Als dit geen hoofdletter Z is, dan voeg je de letter toe aan de uitgevoerde letters. 
     * Als de ingevoerde letter een Z is, dan zorg je ervoor dat de laatst ingevoerde letter verdwijnt uit de collection. 
     * De Z uitvoeren is mogelijk tot de undo list leeg is, daarna geef je een foutmelding. Gebruik de meest geschikte collection.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> karakterLijst = new Stack<char>();
            do
            {
                Console.Write("Geef een karakter in: ");
                char karakter = Console.ReadKey().KeyChar;
                Console.WriteLine();
                //add to stack
                if (karakter != 'Z')
                {
                    karakterLijst.Push(karakter);
                }
                else
                {
                    //remove from stack
                    karakterLijst.Pop();

                }
            } while ( karakterLijst.Count > 0 );

            Console.WriteLine("Lijst leeg.");
        }
    }
}
