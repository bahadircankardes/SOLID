using System;
namespace LSP.TelefonOrnegi
{
	public abstract class BasePhone
	{
		public void Call()
		{
			Console.WriteLine("Arama Yapildi...");
		}

		public abstract void TakeAPhoto();
	}
}

