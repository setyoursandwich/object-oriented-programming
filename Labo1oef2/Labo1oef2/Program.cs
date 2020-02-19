using System;

namespace Labo1oef2
{
    class Program
    {
        static void Main(string[] args)
        {
            Persoon william = new Persoon("Martin", "Robin", new DateTime(1952, 12,5), Persoon.TOEGELATENGESLACHTEN.Man);
            william.PrintInfo();
        }
    }
}
