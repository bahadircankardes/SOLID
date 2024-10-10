using System;
using InterfaceSegrigationPrinciple.Validate.Abstract;

namespace InterfaceSegrigationPrinciple.Validate.Concrete
{
	public class F35:IGozlemYapabilir, ISavasabilir
	{
		public F35()
		{
		}

        public void Bombala()
        {
            throw new NotImplementedException();
        }

        public void GozlemYap()
        {
            throw new NotImplementedException();
        }
    }
}

