using System;

namespace Singleton
{
	/// <summary>
	/// Заказ.
	/// </summary>
	public class Order
	{
		/// <summary>
		/// Имя заказчика.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// Описание заказа.
		/// </summary>
		public string Description { get; set; }

		/// <summary>
		/// Создание заказа.
		/// </summary>
		/// <param name="name">Имя заказчика.</param>
		/// <param name="description">Описание заказа.</param>
		public Order(string name, string description)
		{
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(name));
            }
            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Неверно задан параметр", nameof(description));
            }
            Name = name;
			Description = description;
		}

	}
}
