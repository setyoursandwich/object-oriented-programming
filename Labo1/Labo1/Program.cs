using System;

namespace Labo1
{
    class Program
    {
        static void Main(string[] args)
        {

            //test oef 1
            VluchtSimple VluchtA352 = new VluchtSimple(5, "Litouwen", "België", new DateTime(2020, 3, 15, 9, 25, 0), new DateTime(2020, 3, 15, 14, 55, 0));
            VluchtA352.PrintVluchtInfo();
            VluchtSimple VluchtB352 = new VluchtSimple(2);
            VluchtB352.PrintVluchtInfo();

            //test oef2
            VluchtSimpleTwo VluchtC324 = new VluchtSimpleTwo("Malta", "Frankrijk", new DateTime(2020, 3, 19, 19, 25, 0), new DateTime(2020, 3, 19, 23, 55, 0));
            VluchtC324.PrintVluchtInfo();
            VluchtSimpleTwo VluchtD324 = new VluchtSimpleTwo();
            VluchtD324.PrintVluchtInfo();

            ////test oef3
            Vlucht VluchtE324 = new Vlucht(27, Vlucht.AANKOMSTPLAATSEN.Frankrijk, Vlucht.VERTREKPLAATSEN.België, new DateTime(2020, 3, 19, 19, 25, 0), new DateTime(2020, 3, 19, 23, 55, 0));
            VluchtE324.PrintVluchtInfo();
            Vlucht VluchtF324 = new Vlucht(33);
            VluchtF324.PrintVluchtInfo();

            Console.ReadLine();
        }
    }
}
