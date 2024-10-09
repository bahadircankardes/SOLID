using System;
using OpenClose.Ornek2.Validate.Abstract;

namespace OpenClose.Ornek2.Validate.Concrete
{
	public class ValidDaire:ISekil
	{
		public int YariCap { get;}

		public ValidDaire(int yariCap)
		{
			YariCap = yariCap;
		}

        public double AlanHesapla()
        {
            return Math.PI*YariCap*YariCap;
        }

        public double CevreHesapla()
        {
            return Math.PI*2*YariCap;
        }
    }
}

