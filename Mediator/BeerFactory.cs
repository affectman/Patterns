using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Пивзавод.
    /// </summary>
    public class BeerFactory : SalesManager
    {
        /// <summary>
        /// Конструктор пивзавода.
        /// </summary>
        /// <param name="mediator">Экземпляр посредника.</param>
        public BeerFactory(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Варим пиво.
        /// </summary>
        /// <param name="message">Текст сообщения.</param>
        public void BrewBeer(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                throw new ArgumentNullException(nameof(message));
            }
            Console.WriteLine($"{GetType().Name} варит {message}");
            mediator.SendMessage(message, this);
        }
    }
}
