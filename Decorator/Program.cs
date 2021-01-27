using Decorator.Decorator;
using System;

namespace Decorator
{
	class Program
	{
		static void Main(string[] args)
		{
			AbstractEmployee alex = new EmployeeFree();
			alex = new EmployeeDecoratorWork(alex);
			alex = new EmployeeDecoratorChillOut(alex);
			alex.Work();
			Console.WriteLine("________________");

			AbstractEmployee petia = new EmployeePaid();
			petia = new EmployeeDecoratorWork(new EmployeeDecoratorChillOut(petia));
			petia.Work();
			Console.Read();
		}
	}
}
