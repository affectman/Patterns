using AbstractFactory.Smartphone.Apple;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			var iphone = new AppleSmartphoneFactory("Samsung", "Intel", "mAh", 3500, 4, 2800);
			var client = new CustomerChoice(iphone);

			Console.WriteLine($"{client.CpuName}, {client.BatteryCapacity}, {client.RamAmount}");
			Console.ReadLine();
		}
	}
}
