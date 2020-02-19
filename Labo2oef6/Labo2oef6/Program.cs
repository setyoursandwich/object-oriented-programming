using System;

namespace Labo2oef6
{
    class Program
    {
        static void Main(string[] args)
        {
            Vlucht v1 = new Vlucht();
            v1.PrintVluchtInfo();
            Vlucht v2 = new Vlucht();
            v2.PrintVluchtInfo();
            Console.WriteLine();

            printVluchtInVluchtLijst(v2.VluchtNummer);
            Console.WriteLine();

            Vlucht.VerwijderVluchtVanLijst(v2);
            printVluchtInVluchtLijst(v2.VluchtNummer);
            Console.WriteLine();

            Vlucht.VoegVluchtToeAanLijst(v2);
            printVluchtInVluchtLijst(v2.VluchtNummer);
            
        }

        static void printVluchtInVluchtLijst( int vluchtNummer ) {
            Vlucht gevondenVluchtInLijst = Vlucht.ZoekVluchtOpVluchtnummer(vluchtNummer);
            if (gevondenVluchtInLijst != null) {
                Console.WriteLine( "Vlucht met vluchtnummer {0} gevonden in de vlucht lijst: ", vluchtNummer );
                gevondenVluchtInLijst.PrintVluchtInfo();
            }else {
                Console.WriteLine("Vlucht met vluchtnummer {0} niet gevonden in de vlucht lijst.", vluchtNummer);
            }
        }
    }
}
