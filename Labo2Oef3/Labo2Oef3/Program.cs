using System;

namespace Labo2Oef3
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon Pieter = new Persoon("De Clerk", "Pieter", new DateTime(2000, 5, 15), Persoon.TOEGELATENGESLACHTEN.Man);
            Pieter.PrintInfo();
            Console.WriteLine();

            Auto CitroenC3 = new Auto();
            Auto BMWX3 = new Auto("BMW", "X6", "A89 32T", 0);
            Pieter.VoegAutoToe(CitroenC3);
            Pieter.VoegAutoToe(BMWX3);
            Pieter.PrintInfo();
            Console.WriteLine();

            Pieter.VerwijderAuto(CitroenC3);
            Pieter.PrintInfo();

            Pieter.VerwijderAuto(BMWX3);
            Pieter.PrintInfo();



        }
    }
}
