using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Фермер.
    /// </summary>
    public class Farmer : SalesManager
    {
        /// <summary>
        /// Конструктор фермера.
        /// </summary>
        /// <param name="mediator">Экземпляр посредника.</param>
        public Farmer(IMediator mediator)
            : base(mediator)
        {
        }

        /// <summary>
        /// Изготовление солода.
        /// </summary>
        public void ManufactureMalt()
        {
            string malt = "солод";
            Console.WriteLine($"{GetType().Name} изготавливает {malt}");
            mediator.SendMessage(malt, this);
        }
    }
}
