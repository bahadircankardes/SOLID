using System;
using InterfaceSegrigationPrinciple.Ornek1.Validate.Abstract;

namespace InterfaceSegrigationPrinciple.Ornek1.Validate.Concrete
{
	public class ValidPenguen:IYuruyebilir,IYuzebilir
	{
		public ValidPenguen()
		{
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

