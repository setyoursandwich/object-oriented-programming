using System;

namespace Labo3Oef2
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                Persoon gebruiker = new Persoon("Kevin", new DateTime(2002, 02, 18));
                DateTime vandaag = DateTime.Now;
                int jaarVerschil = vandaag.Year - gebruiker.Birthday.Year;
                bool meerderjarig = true;
                if (jaarVerschil < 18 ) {
                    meerderjarig = false;
                } else if (jaarVerschil == 18) {
                    int maandVerschil = vandaag.Month - gebruiker.Birthday.Month;
                    if (maandVerschil < 0)
                    {
                        meerderjarig = false;
                    }
                    else if( maandVerschil == 0 ){
                        if ( vandaag.Day < gebruiker.Birthday.Day ) {
                            meerderjarig = false;
                        }
                    }
                }

                if ( meerderjarig == false ) {
                    throw new Exception("Gebruiker is geen 18 jaar");
                }
            }
			catch (Exception ex)
			{
                Console.WriteLine($"Fout gevonden: {ex.Message}");
			}
            Console.WriteLine("Einde van programma");
        }
    }
}
