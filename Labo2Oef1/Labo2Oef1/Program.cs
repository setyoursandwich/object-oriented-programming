using System;

namespace Labo2Oef1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vlucht FrankrijkBelgie = new Vlucht(35, Vlucht.AANKOMSTPLAATSEN.Frankrijk, Vlucht.VERTREKPLAATSEN.België, new DateTime(2020, 10, 15, 20, 25, 0), new DateTime(2020, 10, 15, 21, 25, 0));

            Persoon Pieter = new Persoon("De Clerk", "Pieter", new DateTime(1990, 5, 15), Persoon.ToegelatenGeslachten.MAN);
            Pieter.SchrijfVluchtInformatie();
        }
    }
}
