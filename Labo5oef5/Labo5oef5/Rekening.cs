using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labo5oef5
{
    class Rekening
    {
        public Double Saldo { get; set; }
        public double InterestRentePercentage { get; set; }
        public double GetrouwheidsRentePercentage { get; set; }
        public bool Open { get; set; }
        public DateTime StartDatum { get; set; }
        public DateTime LaatsteAfhaling { get; set; }

        public Rekening(double saldo, double interestRente, double getrouwheidsRente, bool open, DateTime startDatum, DateTime laatsteAfhaling)
        {
            Saldo = saldo;
            InterestRentePercentage = interestRente;
            GetrouwheidsRentePercentage = getrouwheidsRente;
            Open = open;
            StartDatum = StartDatum;
            LaatsteAfhaling = laatsteAfhaling;
        }

        public Rekening(double saldo, double interestRente, double getrouwheidsRente, DateTime startDatum) : this(saldo, interestRente, getrouwheidsRente, startDatum, startDatum) {

        }

        public void StortBedrag( double bedrag ) {
            if ( bedrag > 0  ) {
                Saldo += bedrag;
            }
        }

        public double BedragAfhalen( double bedrag ) {
            if (bedrag <= Saldo)
            {
                LaatsteAfhaling = DateTime.Now;
                Saldo -= bedrag;
                return bedrag;
            }
            return 0;
        }
        
        //logica gaat ervan uit dat de jaarlijkse interst berekening het saldo aanpast
        public double BerekenToekomstigBedrag( DateTime toekomstDatum) {

            DateTime nu = DateTime.Now;
            //alle datums die we vergelijken moet minstens 1 jaar verschil hebben met nu, anders is er nog geen interest berekening geweest
            if ( nu >= toekomstDatum || StartDatum.AddYears(1) > toekomstDatum) {
                return Saldo;
            }

            //we testen alleen op jaar basis
            int renteJarenTeBerekenen = toekomstDatum.Year - nu.Year;
            int jaarVerschilMetStartDatum = toekomstDatum.Year - StartDatum.Year;
            //als 
            if (StartDatum.AddYears(jaarVerschilMetStartDatum) <= toekomstDatum) {
                renteJarenTeBerekenen++;
            }

            double effectieveGetrouwheidsPercentage = this.LaatsteAfhaling <= DateTime.Now ? GetrouwheidsRentePercentage : 0;

            double totaalRenteAlsDouble = 1+(InterestRentePercentage / 100) + (GetrouwheidsRentePercentage/100);
            double toekomstigSalo = Math.Pow((Saldo * totaalRenteAlsDouble), renteJarenTeBerekenen);
            return toekomstigSalo;
        }

    }
}
