using System;
using InterfaceSegrigationPrinciple.Ornek1.Validate.Abstract;

namespace InterfaceSegrigationPrinciple.Ornek1.Validate.Concrete
{
	public class ValidDeveKusu:IYuruyebilir, IKosabilir
	{
		public ValidDeveKusu()
		{

		}

        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }
    }
}

