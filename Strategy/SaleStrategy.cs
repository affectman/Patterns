using System.Collections.Generic;

namespace Strategy
{
    /// <summary>
    /// Стратегия продаж.
    /// </summary>
    public abstract class SaleStrategy
    {
        /// <summary>
        /// Продажа.
        /// </summary>
        /// <param name="productsList">Список товаров.</param>
        public abstract void Sale(List<string> productsList);
    }

}
