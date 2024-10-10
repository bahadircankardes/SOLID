using System;
namespace DIP.Ornek1
{
	public class DBLogger
	{
        public void DatabaseYAz(string message)
        {
            Console.WriteLine($"{this.GetType().Name} DataBase'e {message} Yazdi...");
        }
    }
}

