using OpenClose.CoffeeSample;
using OpenClose.Validate.Abstract;
using OpenClose.Validate.Concrete;

namespace OpenClose;
#region Acıklama
/*Open & Close Principle

Bu ilkede, uygulama içerisinde var olan sınıflarımızda herhangi bir
değişiklik yapmadan bu değişiklik yerine gelistirme ister 
yani var olan sınıfımızda bulunan kodlara müdahele etmeden değişiklik
yapmamızı bizden talep eder. 
Bu prensibin bizden istediği sınıflarımızda var olan methodları değişime
kapamamız ,bunun yanın da yeniliklerede 
açık olmasıdır. Bunun nedeni ise var olan kodlar üzerinde değişiklik
yapmak bizler için çok maliyetli olacağından, 
var olan kodlara dokunmadan değişikliği yerine getirmiş oluruz.

 bir kahve dükkanımız olacak, bu kahve dükkanımızda hali hazırda satılan
kahve türleri bulunmaktadır. Dükkan sahibi yeni bir kahve türü satamk
istediğinde yeni kahve var olan kahvelere eklenecek yani 
bir modifikasyon yapılacak. Beklentimiz yeni kahve türleri
geldiğinde var olan sisteme dokunamdan değişiklik 
yapmadan hızlı ve çevik bir şekilde bu değişikliği yerine getirelim.
Harcanan süre maliyettir.
 */
#endregion

internal class Program
{
    static void Main(string[] args)
    {
        Coffee coffee = new Coffee();
        coffee.FiyatHesapla(3, CoffeeType.Latte);


        /****************/

        List<ICoffee> coffees = new List<ICoffee>();

        TurkKahvesi turkKahvesi = new TurkKahvesi(80);
        turkKahvesi.FiyatHesapla(3);

        Latte latte = new Latte(90);
        latte.FiyatHesapla(8);

        coffees.Add(latte);
        coffees.Add(turkKahvesi);

        KahveDunyasi kahveDunyasi = new KahveDunyasi();
        Console.WriteLine(kahveDunyasi.ToplamMasaTutar(coffees));
    }
}

