using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Посредник для связи.
    /// </summary>
    public class ConcreteMediator : IMediator
    {
        /// <summary>
        /// Экземпляр фермера.
        /// </summary>
        public Farmer Farmer { get; set; }

        /// <summary>
        /// Пивзавод.
        /// </summary>
        public BeerFactory BeerFactory { get; set; }

        /// <summary>
        /// Магазин.
        /// </summary>
        public Shop Shop { get; set; }

        /// <summary>
        /// Отправить сообщение.
        /// </summary>
        /// <param name="message">Тескт сообщения.</param>
        /// <param name="salesManager">Менеджер по продажам.</param>
        public void SendMessage(string message, SalesManager salesManager)
        {
            ;
            if (salesManager == null)
            {
                throw new ArgumentNullException(nameof(salesManager));
            }

            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException(nameof(message));
            }

            if (salesManager == Farmer)
            {
                BeerFactory.BrewBeer(message);
            }
            else if (salesManager == BeerFactory)
            {
                Shop.SellMalt(message);
            }
        }
    }
}
