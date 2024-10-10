using System;
using InterfaceSegrigationPrinciple.Ornek1.Validate.Abstract;

namespace InterfaceSegrigationPrinciple.Ornek1.Validate.Concrete
{
	public class ValidKartal:IYuzebilir,IYuruyebilir,IKosabilir,IUcabilir
	{
		public ValidKartal()
		{
		}

        public void Kos()
        {
            throw new NotImplementedException();
        }

        public void Uc()
        {
            throw new NotImplementedException();
        }

        public void Yuru()
        {
            throw new NotImplementedException();
        }

        public void Yuz()
        {
            throw new NotImplementedException();
        }
    }
}

