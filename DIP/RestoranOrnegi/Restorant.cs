using System;
namespace DIP.RestoranOrnegi
{
	public class Restorant
	{
		public Balik Balik { get; set; }
		public Tavuk Tavuk { get; set; }

        public void YemekPisir()
        {
            Balik.BalikPisir();
            Tavuk.TavukPisir();
        }
    }

	
}

