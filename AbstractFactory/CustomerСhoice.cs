using System;
using AbstractFactory.AbstractFactory;

namespace AbstractFactory
{
	/// <summary>
	/// Класс клиентского выбора.
	/// </summary>
	public class CustomerChoice
	{
		/// <summary>
		/// Название процессора.
		/// </summary>
		public string CpuName { get; }
		
		/// <summary>
		/// Емкость батареи.
		/// </summary>
		public int BatteryCapacity { get; }

		/// <summary>
		/// Объем оперативной памяти.
		/// </summary>
		public int RamAmount { get; }

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		/// <param name="phoneFactory">Телефон.</param>
		public CustomerChoice(SmartphoneFactory phoneFactory)
		{

            if (phoneFactory == null)
            {
                throw new ArgumentNullException(nameof(phoneFactory));
            }

            if (phoneFactory.GetRam().RamAmount < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение",nameof(RamAmount));
            }

            if (phoneFactory.GetBattery().BatteryCapacity < 0)
            {
                throw new ArgumentException("Вы ввели отрицательное значение", nameof(BatteryCapacity));
            }

            if (string.IsNullOrWhiteSpace(phoneFactory.GetCpu().CpuName))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(CpuName));
            }

            RamAmount = phoneFactory.GetRam().RamAmount;
			CpuName = phoneFactory.GetCpu().CpuName;
			BatteryCapacity = phoneFactory.GetBattery().BatteryCapacity;
		}
	}
}
