using System;
namespace DIP.Ornek1
{
	public class FileLogger
	{
		public void DosyayaYAz(string message)
		{
			Console.WriteLine($"{this.GetType().Name} Dosyaya{message} Yazdi...");
		}
	}
}

