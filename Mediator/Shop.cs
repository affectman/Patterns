using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Магазин.
    /// </summary>
    public class Shop : SalesManager
    {
        /// <summary>
        /// Конструктор магазина.
        /// </summary>
        /// <param name="mediator">Экзмепляр посредника.</param>
        public Shop(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Продать солод.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        public void SellMalt(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException(nameof(message));
            }

            Console.WriteLine($"{GetType().Name} продает {message}");
        }
    }
}
