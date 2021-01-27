using AbstractFactory.AbstractSpecifications;
using System;

namespace AbstractFactory.Smartphone.Apple
{
	/// <summary>
	/// Класс процессоров компании Apple.
	/// </summary>
	public class AppleCPU : Cpu
	{

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="cpuName">Название процессора.</param>
		/// <param name="cpuFrequency">Частота процессора.</param>
		public AppleCPU(string cpuName, int cpuFrequency)
		{
			if (string.IsNullOrWhiteSpace(cpuName))
			{
				throw new ArgumentException("Неверно задан параметр", nameof(cpuName));
			}

            if (cpuFrequency < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение", nameof(cpuFrequency));
            }
            CpuName = cpuName;
			CpuFrequency = cpuFrequency;
		}
	}
}
