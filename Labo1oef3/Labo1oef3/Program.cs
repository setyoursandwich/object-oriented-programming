using System;

namespace Labo1oef3
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto onbekend = new Auto();
            onbekend.PrintInfo();

            Auto Bmw = new Auto("BMWX2", "Sport auto", "H4CK3R", 39852);
            Bmw.PrintInfo();
        }
    }
}
