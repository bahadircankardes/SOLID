using System;
using OpenClose.Ornek2.Validate.Abstract;

namespace OpenClose.Ornek2.Validate.Concrete
{
    public class ValidDikdortgen : ISekil
    {
        public int KisaKenar { get; }
        public int UzunKenar { get; }

        public ValidDikdortgen(int kisa, int uzun)
        {
            KisaKenar = kisa;
            UzunKenar = uzun;
        }

        public double AlanHesapla()
        {
            return KisaKenar * UzunKenar;
        } 

        public double CevreHesapla()
        {
            return (KisaKenar + UzunKenar) * 2;
        }
    }
}

