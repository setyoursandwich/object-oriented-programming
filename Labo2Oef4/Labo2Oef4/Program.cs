using System;

namespace Labo2Oef4
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Vlucht a352 = new Vlucht(Vlucht.AANKOMSTPLAATSEN.Duitsland, Vlucht.VERTREKPLAATSEN.België, new DateTime(2020, 5, 10, 14, 30, 0), new DateTime(2020, 5, 10, 15, 20, 0));

            Persoon Pieter = new Persoon("Goethals", "Pieter", new DateTime(1985, 2, 1), Persoon.TOEGELATENGESLACHTEN.Man);
            a352.VoegPassagierToe(Pieter);
            a352.VoegPassagierToe(Pieter);

            a352.VerwijderPassagier(Pieter);
            a352.VerwijderPassagier(Pieter);
            a352.VoegPassagierToe(Pieter);
            a352.PrintVluchtInfo();

            Persoon Imke = new Persoon("Magnette", "Imke", new DateTime(1992, 1, 20), Persoon.TOEGELATENGESLACHTEN.Vrouw);
            PrintPassagierGevonden( a352, Imke );
            PrintPassagierGevonden(a352, Pieter);
        }

        //print informatie over de passagier af indien gevonden, niet successvol message indien niet gevonden
        static void PrintPassagierGevonden( Vlucht vlucht, Persoon passagier ) {
            Persoon gevondenPassagier = vlucht.ZoekPassagier(passagier);
            if (gevondenPassagier != null)
            {
                Console.WriteLine( "Passagier gevonden in de vlucht:" );
                gevondenPassagier.PrintInfo();
            }
            else {
                Console.WriteLine("Deze persoon staat niet op de passagierlijst van de vlucht.");
            }
        }
    }
}
