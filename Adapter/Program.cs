using System;
using Adapter.Adapters;
using Adapter.FlyingSuperheroes;
using Adapter.WalkingSuperheroes;

namespace Adapter
{
	class Program
	{
		static void Main(string[] args)
		{
			IWalkingSuperhero hulk = new HulkSuperhero();
            SuperheroInfoPrinter.PrintSuperheroInfo(hulk);
            Console.WriteLine();

            IWalkingSuperhero wolverine = new WolverineSuperhero();
            SuperheroInfoPrinter.PrintSuperheroInfo(wolverine);
            Console.WriteLine();

            IFlyingSuperhero tony = new IronManSuperhero();
            var adapter = new FlyingSuperheroAdapter(tony);
            SuperheroInfoPrinter.PrintSuperheroInfo(adapter);
            Console.WriteLine();
        }
	}
}
