using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
            var mediator = new ConcreteMediator();
            var farmer = new Farmer(mediator);
            var beerFactory = new BeerFactory(mediator);
            var shop = new Shop(mediator);

            mediator.Farmer = farmer;
            mediator.BeerFactory = beerFactory;
            mediator.Shop = shop;

            farmer.ManufactureMalt();
            Console.ReadKey();
        }
    }
}
