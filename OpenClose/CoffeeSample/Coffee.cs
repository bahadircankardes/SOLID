using System;
namespace OpenClose.CoffeeSample
{
	public enum CoffeeType
	{
		TurkKahvesi=1,
		Latte,
		Expresso,
		Kapuçino,
		OsmanliKahvesi
	}
	internal class Coffee
	{
		public  double FiyatHesapla(int adet, CoffeeType coffeeType)
		{
			double toplamtutar = 0;
			switch (coffeeType)
			{
				case CoffeeType.TurkKahvesi:
					toplamtutar = adet * 80;
					break;
				case CoffeeType.Latte:
					toplamtutar = adet * 100;
					break;
				case CoffeeType.Expresso:
					toplamtutar = adet * 120;
					break;
				case CoffeeType.Kapuçino:
					toplamtutar = adet * 125;
					break;
                case CoffeeType.OsmanliKahvesi:
                    toplamtutar = adet * 135;
                    break;
                default:
					break;
			}

			return toplamtutar;
		}
	}
}

