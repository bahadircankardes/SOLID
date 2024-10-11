using System;
using DIP.RestoranOrnegi.Validate.Abstract;

namespace DIP.RestoranOrnegi.Validate.Conrete
{
	public class BorsaRestaurant
	{
        private readonly List<IPisirilebilir> yemekler;

        public BorsaRestaurant(List<IPisirilebilir> yemekler)
		{
            this.yemekler = yemekler;
        }

        public void YemekPisir()
        {
            foreach (var item in yemekler)
            {
                item.Pisir();
            }
        }
	}
}

