using System;

namespace TOPO3.Core
{
    public class TConvertor
    {
        public TConvertor() { }

        public double LengthFromSIToRussian(double convertedValue, LengthSI from, LengthRussian to)
        {
            switch(to)
            {
                case LengthRussian.Arshin: return 1 / 0.7112;
                case LengthRussian.Sazhen: return 1 / 2.1336;
            }
            return 1/0.7112;
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
