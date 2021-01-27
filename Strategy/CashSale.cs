using System;
using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// Продажа за наличные.
    /// </summary>
    public class CashSale : SaleStrategy
    {
        /// <summary>
        /// Продажа.
        /// </summary>
        /// <param name="productsList">Список товаров.</param>
        public override void Sale(List<string> productsList)
        {
            if (productsList == null)
            {
                throw new ArgumentNullException(nameof(productsList));
            }

            Console.WriteLine(productsList.Count == 0 ? "Не выбрано ни одного товара." : "Наличная оплата");
        }
    }
}
