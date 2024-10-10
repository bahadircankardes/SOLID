using System;
using InterfaceSegrigationPrinciple.Validate.Abstract;

namespace InterfaceSegrigationPrinciple.Validate.Concrete
{
	public class YanginUcagi:IGozlemYapabilir, IYanginSondurebilir
	{
		public YanginUcagi()
		{
		}

        public void GozlemYap()
        {
            throw new NotImplementedException();
        }

        public void YanginSondur()
        {
            throw new NotImplementedException();
        }
    }
}

