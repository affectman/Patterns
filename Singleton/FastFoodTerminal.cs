using System;
using System.Collections.Generic;

namespace Singleton
{
	/// <summary>
	/// Терминал для фастфуда.
	/// </summary>
	public class FastFoodTerminal
	{
		/// <summary>
		/// Экземпляр класса.
		/// </summary>
		private static FastFoodTerminal _instance = null;

		/// <summary>
		/// Объект для безопасности потоков.
		/// </summary>
		private static object _lockCreate = new object();

		/// <summary>
		/// Список заказов.
		/// </summary>
		private readonly IList<Order> _orders;

		/// <summary>
		/// Номер заказа.
		/// </summary>
		public int GetNumberOfOrder => _orders.Count;

		/// <summary>
		/// Возвращает экземпляр класса.
		/// </summary>
		public static FastFoodTerminal Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_lockCreate)
					{
                        if (_instance == null)
                        {
                            _instance = new FastFoodTerminal();
                        }
                    }
				}

				return _instance;
			}
		}

		/// <summary>
		/// Конструктор класса.
		/// </summary>
		public FastFoodTerminal()
		{
			_orders = new List<Order>();
		}

        /// <summary>
        /// Создание заказа.
        /// </summary>
        /// <param name="order">Заказ.</param>
        public void CreateOrder(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order));
            }

            _orders.Add(order);

        }
    }
}
