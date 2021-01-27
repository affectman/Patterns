using System;
using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// Список продуктов.
    /// </summary>
    class ProductsList
    {
        /// <summary>
        /// Список продуктов.
        /// </summary>
        private List<string> _productList = new List<string>();

        /// <summary>
        /// Стратегия продажи.
        /// </summary>
        private  SaleStrategy _saleStrategy;

        /// <summary>
        /// Установить стратегию продажи.
        /// </summary>
        /// <param name="saleStrategy"> Стратегия продажи. </param>
        public void SetSaleStrategy(SaleStrategy saleStrategy)
        {
            _saleStrategy = saleStrategy ?? throw new ArgumentNullException(nameof(saleStrategy));
        }

        /// <summary>
        /// Добавить товар в список.
        /// </summary>
        /// <param name="name"> Наименование. </param>
        public void Add(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(name));
            }
            _productList.Add(name);
        }

        /// <summary>
        /// Продажа.
        /// </summary>
        public void Sale()
        {
            if (_productList.Count == 0)
            {
                Console.WriteLine("Не выбрано ни одного товара!");
                return;
            }
            _saleStrategy.Sale(_productList);
            foreach (var product in _productList)
            {
                Console.WriteLine($"Товар :{product}");
            }
            Console.WriteLine("Оплата прошла успешно.");
            Console.WriteLine();

        }
    }
}
