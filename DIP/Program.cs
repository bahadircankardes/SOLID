﻿using DIP.Ornek1;
using DIP.Validate.Abstract;
using DIP.Validate.Concrete;

namespace DIP;

class Program
{
    #region Giriş
    /*Dependency Inversion Principle (Bağımlılığı Tersine Çevirme)

Bu ilkenin ana fikri, alt yada üst seviyeli sınıfların seviyesine 
bakılmaksızın soyutlamalara bağlı olmasını gerektiğini söylemektedir. 
Bu ilkede ki temel amaç sınıflar arasındaki bağımlılığı kırmak ve 
loose couple gevşek bağlı sınıflar oluşturmak. 
Çünkü tight couple sınıflar projelerimizi extend etmemiz yada 
ölçeklendirmemiz için önümüzdeki engellerden biridir. 


Somut bir örnek vermek gerekirse, kumanda ile kumanda pili arasındaki
ilişkiyi düşünelim. Uzaktan kumandanın çalışması için pile ihtiyaç vardır, 
ancak pil markası ile kumandanın çalışması için bir alaka bir ilişki yoktur. 
Yani istediğimiz herhangi bir pil markasını tercih edebileceimizden 
kumanda ile pil markası loose couple olmalıdır.


Junior developer'lar tarafından DIP ve DI hep bir birine karıştırılır. 
DIP bir prensiptir DI (Dependency Injection) ile bir desing pattern'dır. 
DI, DIP yada IoC prensiplerini uygulamak için bir araçtır, yoldur, usuldur. 
     */
    #endregion

    static void Main(string[] args)
    {
        #region Yanlış Örnek
        //FileLogger fileLogger = new FileLogger();
        //Loglayici loglayici = new Loglayici();
        //loglayici.FileLogger = fileLogger;
        //loglayici.DosyayaYaz("qweqweqwe");
        //DBLogger dBLogger = new DBLogger();
        #endregion

        #region Validate Edilmiş Hali
        ILogger logger = new EmailLogger();

        ValidLoglayici validLoglayici = new ValidLoglayici(logger);

        validLoglayici.Logla("asdasdasd");


        #endregion

    }
}

