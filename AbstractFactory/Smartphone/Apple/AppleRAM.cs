using AbstractFactory.AbstractSpecifications;
using System;

namespace AbstractFactory.Smartphone.Apple
{
	/// <summary>
	/// Класс оперативной памяти компании Apple.
	/// </summary>
	public class AppleRAM : Ram
	{
        /// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="ramName">Марка оперативной памяти.</param>
		/// <param name="ramAmount">Объем оперативной памяти.</param>
		public AppleRAM(string ramName, int ramAmount)
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
