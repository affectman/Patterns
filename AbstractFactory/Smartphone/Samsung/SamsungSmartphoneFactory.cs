using AbstractFactory.AbstractFactory;
using AbstractFactory.AbstractSpecifications;
using System;

namespace AbstractFactory.Smartphone.Samsung
{
	/// <summary>
	/// Класс смартфона компании Samsung.
	/// </summary>
	public class SamsungSmartphoneFactory : SmartphoneFactory
	{
		/// <summary>
		/// Марка оперативной памяти.
		/// </summary>
		public string RamName { get; }

		/// <summary>
		/// Марка процессора.
		/// </summary>
		public string CpuName { get; }

		/// <summary>
		/// Единица измерения емкости батареи.
		/// </summary>
		public string BatteryUnitOfMeasurement { get; }

		/// <summary>
		/// Емкость батареи.
		/// </summary>
		public int BatteryCapacity { get; }

		/// <summary>
		/// Частота процессора.
		/// </summary>
		public int CpuFrequency { get; }

		/// <summary>
		/// Объем оперативной памяти.
		/// </summary>
		public int RamAmount { get; }

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="ramName">Марка оперативной памяти.</param>
		/// <param name="cpuName">Марка процессора.</param>
		/// <param name="batteryUnitOfMeasurement">Единица измерения емкости батареи.</param>
		/// <param name="batteryCapacity">Емкость батареи.</param>
		/// <param name="ramAmount">Объем оперативной памяти.</param>
		/// <param name="cpuFrequency">Частота процессора.</param>
		public SamsungSmartphoneFactory(string ramName, string cpuName, string batteryUnitOfMeasurement, int batteryCapacity, int ramAmount, int cpuFrequency)
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

            if (batteryCapacity < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение", nameof(batteryCapacity));
            }

            if (ramAmount < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение", nameof(ramAmount));
            }

            if (cpuFrequency < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение", nameof(cpuFrequency));
            }

            RamName = ramName;
			CpuName = cpuName;
			CpuFrequency = cpuFrequency;
			BatteryUnitOfMeasurement = batteryUnitOfMeasurement;
			BatteryCapacity = batteryCapacity;
			RamAmount = ramAmount;
		}

		/// <summary>
		/// Получение батареи.
		/// </summary>
		/// <returns>Объект батареи.</returns>
		public override Battery GetBattery()
		{
			return new SamsungBattery(BatteryUnitOfMeasurement, BatteryCapacity);
		}

		/// <summary>
		/// Получение процессора.
		/// </summary>
		/// <returns>Объект процессора.</returns>
		public override Cpu GetCpu()
		{
			return new SamsungCPU(CpuName, CpuFrequency);
		}

		/// <summary>
		/// Получение оперативной памяти.
		/// </summary>
		/// <returns>Объект оперативной памяти.</returns>
		public override Ram GetRam()
		{
			return new SamsungRAM(RamName, RamAmount);
		}
	}
}
