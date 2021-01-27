using System;

namespace Singleton
{
	class Program
	{
		static void Main(string[] args)
		{
			var firstorder = FastFoodTerminal.Instance;

			firstorder.CreateOrder(new Order("Петя", "хороший заказ"));
			Console.WriteLine($"{firstorder.GetNumberOfOrder} sad");

			var secondOrder = FastFoodTerminal.Instance;

			firstorder.CreateOrder(new Order("Вася", "плохой заказ"));
			Console.WriteLine($"{secondOrder.GetNumberOfOrder} bad");

			firstorder.CreateOrder(new Order("Вася", "хороший заказ"));

			Console.WriteLine($"{ReferenceEquals(firstorder, secondOrder)} равны");
			Console.ReadLine();

		}
	}
}
