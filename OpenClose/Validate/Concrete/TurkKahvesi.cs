using System;
using OpenClose.Validate.Abstract;

namespace OpenClose.Validate.Concrete
{
	public class TurkKahvesi:ICoffee
	{
        private readonly double fiyat;

        public TurkKahvesi(double fiyat)
        {
            this.fiyat = fiyat;
        }

        public double FiyatHesapla(int adet)
        {
            return fiyat * adet;
        }
    }
}

