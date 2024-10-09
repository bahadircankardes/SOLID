using System;
using SRP.Ornek;

namespace SRP.Validate
	//Burada loglama islemi ayri bir sinifa verilmistir.
	//Buradaki sinifin sadece isi urun create etmektir.
{
	internal class UrunCreate
	{
		public Logger Logger { get; set; }

		public UrunCreate()
		{
			Logger = new Logger("UrunTanimlamalari.csv", "Urun Kayit Islemi");
		}

		public void UrunEkle(Urun urun)
		{
			string kayit = "";
			if (!string.IsNullOrEmpty(urun.Name))
			{
				kayit = $"{DateTime.Now}; {urun.Name}; created";
			}
			else
			{
                kayit = $"{DateTime.Now}; urun adi bos olamaz";

            }

			Logger.Logla(kayit);
        }
	}
}

