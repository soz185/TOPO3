using System;

namespace TOPO3.Core
{
    public class TConvertor
    {
        public TConvertor() { }

        public double LengthFromSIToRussian(double convertedValue, LengthSI from, LengthRussian to)
        {
            return 0.7112;
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
