using System;
using InterfaceSegrigationPrinciple.Validate.Abstract;

namespace InterfaceSegrigationPrinciple.Validate.Concrete
{
	public class Boeing751:IKargoTasiyabilir, IYolcuTasi
	{
		public Boeing751()
		{
		}

        public void KargoTasi()
        {
            throw new NotImplementedException();
        }

        public void YolcuTasi()
        {
            throw new NotImplementedException();
        }
    }
}

