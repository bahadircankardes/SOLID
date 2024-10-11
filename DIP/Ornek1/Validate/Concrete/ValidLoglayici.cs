using System;
using DIP.Validate.Abstract;

namespace DIP.Validate.Concrete
{
	public class ValidLoglayici : ILogger
	{
        private readonly ILogger logger;// Sadece tanimlandigi yerde ya da
                                        // constructor icerisinde atama yapilabilir.

        public ValidLoglayici(ILogger logger)
		{
            this.logger = logger;
        }

        public void Logla(string message)
        {
            logger.Logla(message);
        }
    }
}

