﻿using System.Diagnostics.Metrics;
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.ConstrainedExecution;
using System.Threading.Tasks;

namespace SRP;

class Program
{
    #region Giriş
//    Dünya üzerinde genel geçer kabul görmüş ve SOLID prensipleri diye
//    nitelendirilen beş adet tasarım deseninden ‘S‘ si olan
//Tek Sorumluluk Prensibi – Single Responsibility Principle(SRP)’yi
//izah etmeye çalışacağım.

//Nesne Tabanlı Programlama yaklaşımında temel unsur sınıf yapılarıdır.
//Bir proje inşa sürecinde sınıflar inşaatın her bir katmanında
//kendilerine has görev icra eden işçilerdir.

//Eğer bu işçilere birden fazla görev yüklenirse(ki biz bu görevlere
//sorumluluk diyeceğiz) ne kadar verim alınabileceğini
//düşünmenizi isterim.Evet, basit mantık düşünelim.Bir inşaat işçisine
//bir yandan duvarı örme ve bir yandan da
//tesisatı döşeme işini verirseniz bu iki işin güvenirliğini aklen
//ne kadar tasdik edebiliriz?

//İşte OOP yapılarındaki elemanlarımızında üstleneceği görevler sade ve
//sadece bir adet olmalıdır.

//Yani dahada açarsak eğer,

//Her sınıf ve metod sade ve sadece ‘Tek Bir Sorumluluğu’ yerine
//getirmelidir.

//İşte tek sorumluluk prensibi bu manada şekillenmiştir.

//Bir sınıf yahut metoda baktığımız zaman sorumluluk olarak genelde
//o sınıf yahut sınıf içerisindeki bir metod işlevi akla gelmekte,
//bu işlev sorumluluk(görev) olarak nitelendirilmektedir.
//Halbuki sizde bilirsiniz ki,çoğu sorumluluk birden fazla sınıf ve
//metod eşliğinde yerine getirilmektedir.

//O halde sorumluluk algımızı değiştirmeli ve aşağıdaki gibi
//olgunlaştırmalıyız.

//Bir sınıfın yahut metodun sorumluluğu, değişmesi için bulunan sebebidir.

//Anlayacağımız o ki, bir sınıfın veya metodun sorumluluk olarak bağlılığı
//kendisini değiştirmeye iten sebepleridir.
//O yapı ne kadar değişme sebebi arz ediyorsa o kadar sorumluluğu
//var demektir.

//Tek Bir Sorumluluğu yerine getirmek demek, ilgili sınıf ya da metodun
//değişmek için sade ve sadece bir sebebinin bulunması demektir.

//Eğer ki bir sınıf üzerinde iki ayrı işi yapıyorsanız iki ayrı
//değişiklik sebebiniz var demektir.
//Aslında bu iki ayrı iş için iki ayrı sınıfın olması gerçeğiyle
//yüzleşmek demektir.

//Elinizde 1000+ satırlık bir sınıfınız mevcutsa büyük ihtimal bu
//prensibi çiğniyorsunuz demektir.
    #endregion
    static void Main(string[] args)
    {
        Console.WriteLine("Gulin Hos Geldin");
    }
}

