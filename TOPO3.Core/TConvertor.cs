using System;

namespace TOPO3.Core
{
    public class TConvertor
    {
        public TConvertor() { }

        public double LengthFromSIToRussian(double convertedValue, LengthSI from, LengthRussian to)
        {
            double calcValueFrom = 0;
            switch(from)
            {
                case LengthSI.Centimetre: calcValueFrom = convertedValue * 0.01; break;
                case LengthSI.Kilometre: calcValueFrom = convertedValue * 1000; break;
                case LengthSI.Millimetre: calcValueFrom = convertedValue * 0.001; break;
                default: calcValueFrom = convertedValue; break;
            }
            double calcValueTo = 0;
            switch(to)
            {
                case LengthRussian.Arshin: calcValueTo = calcValueFrom / 0.7112; break;
                case LengthRussian.Sazhen: calcValueTo = calcValueFrom / 2.1336; break;
                case LengthRussian.Versta: calcValueTo = calcValueFrom / 1066.8; break;
                case LengthRussian.Pyad: calcValueTo = calcValueFrom / 0.1778; break;
            }
            return calcValueTo;
        }
    }

    public enum LengthSI 
    { 
        Kilometre,
        Metre,
        Centimetre,
        Millimetre
    }

    public enum LengthRussian
    {
        Versta,
        Sazhen,
        Arshin,
        Pyad
    }

}
