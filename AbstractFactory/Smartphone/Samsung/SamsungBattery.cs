using AbstractFactory.AbstractSpecifications;
using System;

namespace AbstractFactory.Smartphone.Samsung
{
	/// <summary>
	/// Класс батареи компании Samsung.
	/// </summary>
    public class SamsungBattery : Battery
	{
        /// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="batteryUnitOfMeasurement">Единица измерения батареи.</param>
		/// <param name="batteryCapacity">Емкость батареи.</param>
		public SamsungBattery(string batteryUnitOfMeasurement, int batteryCapacity)
		{
			if (string.IsNullOrWhiteSpace(batteryUnitOfMeasurement))
			{
				throw new ArgumentException("Неверно задан параметр", nameof(batteryUnitOfMeasurement));
			}

            if (batteryCapacity < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение", nameof(batteryCapacity));
            }

            BatteryUnitOfMeasurement = batteryUnitOfMeasurement;
			BatteryCapacity = batteryCapacity;
		}
	}
}
