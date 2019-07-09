using BusinessLogic.Implementations;
using BusinessLogic.Interfaces;
using System;
using Unity;

namespace DesignPattern
{
    class Program
    {

        static void Main(string[] args)
        {
            var container = new UnityContainer();

            RegisterDependencyInjectionContainer(container);
            var startegyPattern = container.Resolve<IShippingStrategyFactory>();
            StrategyPattern strategy = new StrategyPattern(startegyPattern);
            var price=strategy.CalculatePrice();
            Console.WriteLine("StrategyPattern:price-" + price);


            var facadePattern = container.Resolve<IFacadePattern>();
            facadePattern.Method1();
            facadePattern.Method2();



        }

        private static void RegisterDependencyInjectionContainer(UnityContainer container)
        {
            container.RegisterType<IShippingStrategy, DHLShippingStrategy>("DHL");
            container.RegisterType<IShippingStrategy, UPSShippingStrategy>("UPS");
            container.RegisterType<IShippingStrategyFactory, ShippingStrategyFactory>();
            container.RegisterType<IFacadePattern, FacadeImplementation>();
        }
    }
}
