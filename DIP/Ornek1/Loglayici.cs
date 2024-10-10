using System;
namespace DIP.Ornek1
{
	public class Loglayici
	{
		public FileLogger FileLogger { get; set; }
		public DBLogger DBLogger { get; set; }

		public void DosyayaYaz(string message)
		{
			FileLogger.DosyayaYAz(message);
		}

		public void DatabaseYaz(string message)
		{
			DBLogger.DatabaseYAz(message);
		}
	}
}

