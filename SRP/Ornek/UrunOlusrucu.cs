using System;
namespace SRP.Ornek
{
	internal class UrunOlusrucu
	{
		public void UrunEkle(Urun urun)
		{
			try
			{
                #region Urun KAyit Islemi
                string kayit = $"{DateTime.Now} ; {urun.Name}; Created";
                File.WriteAllText("Urunler.csv", kayit);
				#endregion

				#region Yapilan isin Loglanmasi

				string log = $"{DateTime.Now}; {urun.Name}; kaydedildi.";
				File.WriteAllText("UrunLog.csv", log);

				#endregion

			}
            catch (Exception ex)
			{
                #region Alinan Hatanin Loglanmasi

                string log = $"{DateTime.Now}; {ex.Message}";
                File.WriteAllText("HataLog.csv", log);

                #endregion


            }
			
		}
    }
}

