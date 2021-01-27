using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractSpecifications;
using System;

namespace AbstractFactory.Smartphone.Apple
{
	/// <summary>
	/// Класс смартфона компании Apple.
	/// </summary>
	class Apple : SmartphoneFactory
	{
		/// <summary>
		/// Марка оперативной памяти.
		/// </summary>
		public string RAMName { get; set; }

		/// <summary>
		/// Марка процессора.
		/// </summary>
		public string CPUName { get; set; }

		/// <summary>
		/// Единица измерения емкости батареи.
		/// </summary>
		public string BatteryUnitOfMeasurement { get; set; }

		/// <summary>
		/// Емкость батареи.
		/// </summary>
		public int BatteryCapacity { get; set; }

		/// <summary>
		/// Частота процессора.
		/// </summary>
		public int CPUFrequency { get; set; }

		/// <summary>
		/// Объем оперативной памяти.
		/// </summary>
		public int RAMAmount { get; set; }

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="ramName">Марка оперативной памяти.</param>
		/// <param name="cpuName">Марка процессора.</param>
		/// <param name="batteryUnitOfMeasurement">Единица измерения емкости батареи.</param>
		/// <param name="batteryCapacity">Емкость батареи.</param>
		/// <param name="ramAmount">Объем оперативной памяти.</param>
		/// <param name="cpuFrequency">Частота процессора.</param>
		public Apple(string ramName, string cpuName, string batteryUnitOfMeasurement, int batteryCapacity, int ramAmount, int cpuFrequency)
		{
			if (string.IsNullOrWhiteSpace(ramName))
			{
				throw new ArgumentException("Неверно задан параметр", nameof(ramName));
			}

			if (string.IsNullOrWhiteSpace(cpuName))
			{
				throw new ArgumentException("Неверно задан параметр", nameof(cpuName));
			}

			if (string.IsNullOrWhiteSpace(batteryUnitOfMeasurement))
			{
				throw new ArgumentException("Неверно задан параметр", nameof(batteryUnitOfMeasurement));
			}

			RAMName = ramName;
			CPUName = cpuName;
			CPUFrequency = cpuFrequency;
			BatteryUnitOfMeasurement = batteryUnitOfMeasurement;
			BatteryCapacity = batteryCapacity;
			RAMAmount = ramAmount;
		}

		/// <summary>
		/// Получение батареи.
		/// </summary>
		/// <returns>Объект батареи.</returns>
		public override Battery GetBattery()
		{
			return new AppleBattery(BatteryUnitOfMeasurement, BatteryCapacity);
		}

		/// <summary>
		/// Получение процессора.
		/// </summary>
		/// <returns>Объект процессора.</returns>
		public override CPU GetCPU()
		{
			return new AppleCPU(CPUName, CPUFrequency);
		}

		/// <summary>
		/// Получение оперативной памяти.
		/// </summary>
		/// <returns>Объект оперативной памяти.</returns>
		public override RAM GetRAM()
		{
			return new AppleRAM(RAMName, RAMAmount);
		}
	}
}
