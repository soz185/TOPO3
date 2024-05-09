using System;

namespace TOPO3.Core
{
    public class TConvertor
    {
        public TConvertor() { }

        public double LengthFromSIToRussian(double convertedValue, LengthSI from, LengthRussian to)
        {
            double calcValue = 0;
            switch(to)
            {
                case LengthRussian.Arshin: calcValue = 1 / 0.7112; break;
                case LengthRussian.Sazhen: calcValue = 1 / 2.1336; break;
                case LengthRussian.Versta: calcValue = 1 / 1066.8; break;
            }
            return calcValue;
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
