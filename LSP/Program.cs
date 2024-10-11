using LSP.TelefonOrnegi;

namespace LSP;

class Program
{
    static void Main(string[] args)
    {
        BasePhone iphone = new Iphone();
        BasePhone nokia = new Nokia3310();
        iphone.TakeAPhoto();
        Nokia3310.TakePhoto();

        Console.WriteLine("Hello, World!");
    }
}

