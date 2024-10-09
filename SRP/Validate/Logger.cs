using System;
namespace SRP.Validate
{
	internal class Logger
	{
        private readonly string dosya;
        private readonly string msg;

        public Logger(string dosya, string msg)
		{
            this.dosya = dosya;
            this.msg = msg;
            this.Logla(msg);
        }
	}

    public bool Logla(string msg)
    {
        File.WriteAllText(dosya, msg);
        return true;
    }
}

