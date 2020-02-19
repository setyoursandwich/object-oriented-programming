using System;

namespace Labo3Oef2
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Persoon gebruiker = new Persoon("Kevin", new DateTime(2003, 02, 18));
                DateTime vandaag = DateTime.Now;
                //if the user's birthday is more recent than today minus 18 years throw an exception
                if ( vandaag.AddYears( -18 ) < gebruiker.Birthday ) {
                    throw new Exception("Gebruiker geen 18 jaar");
                }
                Console.WriteLine("Gebruiker is meerderjarig");
            }
			catch (Exception ex)
			{
                Console.WriteLine($"Fout gevonden: {ex.Message}");
			}
            Console.WriteLine("Einde van programma");
        }
    }
}
