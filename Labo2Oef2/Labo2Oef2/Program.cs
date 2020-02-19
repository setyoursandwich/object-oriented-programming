using System;

namespace Labo2Oef2
{
    /*
    Zorg ervoor dat elke auto steeds een eigenaar heeft.
    Maak code zodat je gegevens van de auto en de eigenaar van de auto kan laten zien in de console.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Persoon Pieter = new Persoon("Jansens", "Pieter", new DateTime(1995, 2, 23), Persoon.TOEGELATENGESLACHTEN.Man);
            Auto Citroen = new Auto("Citroen", "C3", "586 ASA", 20, Pieter);

            Citroen.PrintInfo();
        }
    }
}
