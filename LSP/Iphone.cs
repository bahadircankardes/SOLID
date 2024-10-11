using System;
using LSP.TelefonOrnegi;

namespace LSP
{
    public class Iphone : BasePhone
    {
        public override void TakeAPhoto()
        {
            Console.WriteLine($"{this.GetType().Name} Fotograf Cekti...");
        }
    }
}

