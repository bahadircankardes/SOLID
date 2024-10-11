using Microsoft.Extensions.DependencyInjection;

namespace IOC_MicrosoftSample;

class Program
{
    static void Main(string[] args)
    {
        List<ServiceCollection> serviceDescriptors = new List<ServiceCollection>();
        ServiceCollection services = new ServiceCollection();

        //nesne olusturma metodlarına gore nesnelerın omurlerı belırlenıyor

        //services.AddKeyedSingleton<ICar, Bmw>("Bmw");
        //services.AddKeyedSingleton<ICar, Ford>("Ford");
        //services.AddKeyedSingleton<ICar, Mercedes>("Mercedes");

        //services.AddKeyedScoped<ICar, Bmw>("Bmw");
        //services.AddKeyedScoped<ICar, Ford>("Ford");
        //services.AddKeyedScoped<ICar, Mercedes>("Mercedes");

        services.AddKeyedTransient<ICar, Bmw>("Bmw");
        services.AddKeyedTransient<ICar, Ford>("Ford");
        services.AddKeyedTransient<ICar, Mercedes>("Mercedes");


        serviceDescriptors.Add(services);

        //services'lere eklenen bagimliliklari derler ya da cozumler
        ServiceProvider container = services.BuildServiceProvider();

        var bmw1 = container.GetKeyedService<ICar>("Bmw");
        var bmw2 = container.GetKeyedService<ICar>("Bmw");
        var bmw3 = container.GetKeyedService<ICar>("Bmw");

        Console.WriteLine(bmw1.GetHashCode());
        Console.WriteLine(bmw2.GetHashCode());
        Console.WriteLine(bmw3.GetHashCode());



    }
}
public interface ICar
{
    int Run();
}
public class Driver
{
    private readonly ICar car;
    public Driver()
    {

    }
    public Driver(ICar car)
    {
        this.car = car;
    }
    public void RunCar()
    {
        Console.WriteLine($"{car.GetType().Name} => {car.Run()} km hizla Gidiyor");
    }
}

public class Bmw : ICar
{
    int km = 0;
    public int Run()
    {
        km = km + 10;
        return km;
    }
}
public class Ford : ICar
{
    int km = 0;
    public int Run()
    {
        return ++km;
    }
}
public class Mercedes : ICar
{
    int km = 0;
    public int Run()
    {
        return ++km;
    }
}

