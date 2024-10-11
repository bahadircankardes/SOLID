using System;
namespace LSP.TelefonOrnegi.Validate
{
    public class NewIPhone : NewBasePhone, ITakePhoto
    {
        

        public void TakePhoto()
        {
            Console.WriteLine("Foto Cekildi...");
        }
    }
}

