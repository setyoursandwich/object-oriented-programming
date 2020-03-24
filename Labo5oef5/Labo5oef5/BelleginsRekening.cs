using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef5
{
    class BelleginsRekening:Rekening
    {

        public BelleginsRekening(double saldo, double interestRente, DateTime startDatum, DateTime laatsteAfhaling):base(saldo, interestRente, 0, startDatum, laatsteAfhaling)
        {
            
        }

        public BelleginsRekening(double saldo, double interestRente, DateTime startDatum) : base(saldo, interestRente, 0, startDatum, startDatum)
        {

        }



    }
}
