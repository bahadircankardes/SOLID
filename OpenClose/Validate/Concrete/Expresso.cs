using System;
using OpenClose.Validate.Abstract;

namespace OpenClose.Validate.Concrete
{
	public class Expresso:ICoffee
	{
        private readonly double fiyat;

        public Expresso(double fiyat)
        {
            this.fiyat = fiyat;
        }

        public double FiyatHesapla(int adet)
        {
            return fiyat * adet;
        }
    }
}

