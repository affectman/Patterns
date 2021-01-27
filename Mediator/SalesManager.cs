using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    /// <summary>
    /// Менеджер по продажам.
    /// </summary>
    public abstract class SalesManager
    {
        /// <summary>
        /// Экземпляр посредника.
        /// </summary>
        protected IMediator mediator;

        /// <summary>
        /// Менеджер по продажам.
        /// </summary>
        /// <param name="mediator">Посредник.</param>
        protected SalesManager(IMediator mediator)
        {
            this.mediator = mediator ?? throw new ArgumentNullException(nameof(mediator)); ;
        }
    }
}
