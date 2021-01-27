using AbstractFactory.AbstractSpecifications;
using System;

namespace AbstractFactory.Smartphone.Samsung
{
	/// <summary>
	/// Класс оперативной памяти компании Samsung.
	/// </summary>
	public class SamsungRAM : Ram
	{
        /// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="ramName">Марка оперативной памяти.</param>
		/// <param name="ramAmount">Объем оперативной памяти.</param>
		public SamsungRAM(string ramName, int ramAmount)
		{
			if (string.IsNullOrWhiteSpace(ramName))
			{
				throw new ArgumentException("Неверно задан параметр", nameof(ramName));
			}

            if (ramAmount < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение", nameof(ramAmount));
            }

            RamName = ramName;
            RamAmount = ramAmount;
		}
	}
}
