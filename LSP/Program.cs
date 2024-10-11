using LSP.TelefonOrnegi;
using LSP.TelefonOrnegi.Validate;

namespace LSP;
/*Liskov Subsitition Principle


Bu ilke bize, türetilmiş sınıfların ata sınıflarıyla yer değiştirilebilir olmasını söylemektedir.
Bir başka değiş ile ata sınıfların hernagi biri alt sınıfın yerine geçebilir şekilde dizay
edilmelidir .
Örnek vermek gerekirse bir gemi kaptanı ve oğlunu düşünelim, gemi kaptanının gemiyi sevk ve idare 
edebilmesi için bazı yetenklere sahip olması gerekmektedir. Bu gemi kaptanının oğlu kaptan olacaksa 
bu yetenekleri kazanması gerekir ve LSP bu senaryoya uygundur. 

Lakin oğlu boksör olmak istiyorsa kaptanlık görevini icra ederken kullancağı yeteneklere 
ihtiyacı olmayacaktır, böylelikle ilk senaryodaki ata sınıf ile alt sınıf arasındaki 
yeteneklerin geçişkenliği kırılmış ve LSP ilkesine uyulmamış olunur.

Bu ilkenin klasik örneklerinden bir diğeri ise dikdörtgen ve kare geometrik şekilleri düşünelim. 
Dikdörtgen geometrik olarak uzun ve kısa kenarları bulunan bir şekildir. 
Kare geometrik olarak eşit kenarlara sahiptir. Şimdi dikdötgenden kalıtım alan bir kare sınıfı 
düşünelim, bu senaryoda gene bu prensibe aykırı hareket etmiş oluyoruz. 
Çünkü dikdörtgenin alan ve çevre hesabıyla karenin alan ve çevre hesapları farklıdır.

Yukarıdaki senaryoda LSP uymak istediğimizde dikdörtgen ve kare için bir ortak ata hazırlanarak 
ortak özellikler ve yetenekler barındırılmalıdır. Böylelikle ata ile alt sınıf arasındaki geçişkenlik 
sağlanmış olur ve LSP'ye uyulur.
 */
class Program
{
    static void Main(string[] args)
    {
        //BasePhone iphone = new Iphone();
        //BasePhone nokia = new Nokia3310();
        //iphone.TakeAPhoto();
        //Nokia3310.TakePhoto();

        #region Validate
        NewBasePhone newBasePhone = new NewBasePhone();
        newBasePhone.Call();

        NewIPhone newIPhone = new NewIPhone();
        newIPhone.Call();
        newIPhone.TakePhoto();

        NewNokia3310 newNokia3310 = new NewNokia3310();
        newNokia3310.Call();
        newNokia3310.

        #endregion

        Console.WriteLine("Hello, World!");
    }
}

