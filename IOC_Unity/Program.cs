using Unity;
using Unity.Injection;
using static IOC_Unity.Program;

namespace IOC_Unity;

class Program
{
    static void Main(string[] args)
    {
        #region Standart NEsne olusumu 

        //Bmw bmw = new Bmw();
        //Ford ford = new Ford();
        //Driver driver = new Driver(ford);
        //driver.RunCar();
        //driver.RunCar();
        //driver.RunCar();
        //driver.RunCar();

        #endregion

        #region IOC Container ile Kullanimi

        IUnityContainer container = new UnityContainer();

        //Containere clasların register edilmesi
        container.RegisterType<ICar, Bmw>("Bmw");
        container.RegisterType<ICar, Ford>("Ford");
        container.RegisterType<ICar, Mercedes>("Mercedes");


        //Containerden nesnesin geri cagırılması

        var bmw = container.Resolve<ICar>("Bmw");
        container.RegisterType<Driver>("BmwSurucusu", new InjectionConstructor(bmw));
        var surucu = container.Resolve<Driver>("BmwSurucusu");

        surucu.RunCar();

        #endregion
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
}

