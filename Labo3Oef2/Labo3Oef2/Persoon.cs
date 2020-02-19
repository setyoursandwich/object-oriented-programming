using System;
using System.Collections.Generic;
using System.Text;
/**
 * Maak een klasse persoon met volgende properties: firstname, birthday. Maak 1 constructor die een firstname en birthday binnenkrijgt. 
 * Wanneer je een persoon wil aanmaken die jonger dan 18 is krijgt de gebruiker volgende foutmelding: “Je mag geen minderjarig persoon aanmaken”.
 */
namespace Labo3Oef2
{
    class Persoon
    {
        public string FirstName { get; set; }
        public DateTime Birthday { get; set; }

        public Persoon( string firstName, DateTime birthday ) {
            FirstName = firstName;
            Birthday = birthday;
        }
    }
}
