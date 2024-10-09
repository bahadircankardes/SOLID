using System;
using OpenClose.Validate.Abstract;

namespace OpenClose.Validate.Concrete
{
	internal class KahveDunyasi
	{
        public double ToplamMasaTutar(List<ICoffee> KahveListesi)
		{
			double toplamtutar = 0;
			foreach (var kahve in KahveListesi)
			{
				toplamtutar += kahve.FiyatHesapla(1);
			}
			return toplamtutar;
		}
	}
}

