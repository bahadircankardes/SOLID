using System;
using OpenClose.Validate.Abstract;

namespace OpenClose.Validate.Concrete
{
	public class Latte:ICoffee
	{
        private readonly double fiyat;

        public Latte(double fiyat)
		{
            this.fiyat = fiyat;
        }

        public double FiyatHesapla(int adet)
        {
            return fiyat * adet;
        }
    }
}

